using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplataformaDesktop
{
    public partial class FrmEpi : Form
    {
        private Epi epi;

        public FrmEpi()
        {
            InitializeComponent();
            epi = new Epi();
            CarregarDados();
            pbxEditar.Enabled = false;
            pbxExcluir.Enabled = false;
        }

        private void FrmEpi_Load(object sender, EventArgs e)
        {
            CarregarDados();
            pbxEditar.Enabled = false;
            pbxExcluir.Enabled = false;
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxInserir_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeEpi = txtEpi.Text.Trim();
                DateTime dataVencimento;

                if (!DateTime.TryParse(mkValidade.Text, out dataVencimento))
                {
                    MessageBox.Show("Formato de data inválido! Por favor, insira uma data válida.", "Erro de formato de data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (epi.RegistroRepetido(nomeEpi, dataVencimento))
                {
                    MessageBox.Show("Epi já existe em nossa base de dados!", "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                epi.Inserir(nomeEpi, dataVencimento);
                MessageBox.Show("Epi inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxLocalizar_Click(object sender, EventArgs e)
        {
            pbxEditar.Enabled = true;
            pbxExcluir.Enabled = true;
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                Epi epi = new Epi();
                epi.Localizar(id);
                txtEpi.Text = epi.epi;
                mkValidade.Text = epi.validade.ToString("dd/MM/yyyy");

                VerificarAlertaVencimento(epi);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEpi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEpi.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtEpi.Text = row.Cells[1].Value.ToString();
                mkValidade.Text = row.Cells[2].Value.ToString();
                pbxEditar.Enabled = true;
                pbxExcluir.Enabled = true;
            }
        }

        private void CarregarDados()
        {
            dgvEpi.DataSource = epi.listaepi();
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtEpi.Text = "";
            mkValidade.Text = "";
            lblAlerta.Text = "";
            pbxEditar.Enabled = false;
            pbxExcluir.Enabled = false;
        }

        private void pbxEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                string nomeEpi = txtEpi.Text.Trim();
                DateTime dataVencimento;

                if (!DateTime.TryParse(mkValidade.Text, out dataVencimento))
                {
                    MessageBox.Show("Formato de data inválido! Por favor, insira uma data válida.", "Erro de formato de data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                epi.Atualizar(id, nomeEpi, dataVencimento);
                MessageBox.Show("Epi atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                epi.Excluir(id);
                MessageBox.Show("Epi excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarDados();
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxVencimentos_Click(object sender, EventArgs e)
        {
            Epi epi = new Epi();
            List<Epi> episVencidos = epi.ListaEpiVencidos();
            dgvEpi.DataSource = episVencidos;
        }


        private void VerificarAlertaVencimento(Epi epi)
        {
            TimeSpan diferenca = epi.validade.Date - DateTime.Today;

            if (diferenca <= TimeSpan.FromDays(3) && diferenca > TimeSpan.Zero)
            {
                if (diferenca.Days == 1)
                {
                    lblAlerta.Text = $"{epi.epi} irá vencer amanhã.";
                }
                else
                {
                    lblAlerta.Text = $"{epi.epi} irá vencer em {diferenca.Days} dias.";
                }
            }
            else
            {
                lblAlerta.Text = "";
            }
        }

        private void pbxRegistros_Click(object sender, EventArgs e)
        {
            CarregarDados();
            LimparCampos();
            lblAlerta.Text = "";
        }

    }
}
