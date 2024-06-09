using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplataformaDesktop
{
    public partial class FrmEntrega : Form
    {
        private Entrega entrega;
        public FrmEntrega()
        {
            InitializeComponent();
            carregarDados();
            pbxEditar.Enabled = false;
            pbxExcluir.Enabled = false;
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregaCbxFuncionario()
        {
            try
            {
                cbxFuncionario.Items.Clear();
                Funcionario funcionario = new Funcionario();
                List<Funcionario> funcionarios = funcionario.listafuncionario();
                foreach (Funcionario func in funcionarios)
                {
                    cbxFuncionario.Items.Add(func);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os funcionários: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CarregaCbxEpi()
        {
            try
            {
                cbxEpi.Items.Clear();
                Epi epi = new Epi();
                List<Epi> epis = epi.listaepi();
                foreach (Epi item in epis)
                {
                    cbxEpi.Items.Add(item.epi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os EPIs: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmEntrega_Load(object sender, EventArgs e)
        {
            configurarDataGridView();
            carregarDados();
            CarregaCbxFuncionario();
            CarregaCbxEpi();
            pbxEditar.Enabled = false;
            pbxExcluir.Enabled = false;
        }


        private void pbxInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFuncionario.SelectedItem == null || cbxEpi.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um funcionário e um EPI.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string nomeFuncionario = cbxFuncionario.SelectedItem.ToString();
                string epi = cbxEpi.SelectedItem.ToString();
                DateTime entrega = DateTime.Parse(mkEntrega.Text);

                Funcionario funcionario = new Funcionario();
                funcionario.LocalizarPorNome(nomeFuncionario);
                int matricula = funcionario.matricula;

                Epi epiSelecionado = new Epi();
                epiSelecionado.LocalizarPorNome(epi);
                DateTime validadeEpi = epiSelecionado.validade;

                Entrega entregaObj = new Entrega();
                entregaObj.Inserir(matricula, nomeFuncionario, epi, entrega, validadeEpi);

                MessageBox.Show("Entrega inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregarDados();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir entrega: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cbxFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxFuncionario.SelectedIndex != -1)
                {
                    Funcionario funcionarioSelecionado = (Funcionario)cbxFuncionario.SelectedItem;
                    int matricula = funcionarioSelecionado.matricula;
                    lblMatricula.Text = matricula.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir a matrícula do funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxEpi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxEpi.SelectedItem != null)
                {
                    string nomeEpiSelecionado = cbxEpi.SelectedItem.ToString();
                    Epi epi = new Epi();
                    List<Epi> epis = epi.listaepi();
                    foreach (Epi item in epis)
                    {
                        if (item.epi == nomeEpiSelecionado)
                        {
                            lblValidade.Text = item.validade.ToString("dd/MM/yyyy");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir a validade do EPI: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEntrega_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEntrega.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                lblMatricula.Text = row.Cells[1].Value.ToString();
                cbxFuncionario.Text = row.Cells[2].Value.ToString();
                cbxEpi.Text = row.Cells[3].Value.ToString();
                mkEntrega.Text = row.Cells[4].Value.ToString();
                lblValidade.Text = row.Cells[5].Value.ToString();
            }
            pbxEditar.Enabled = true;
            pbxExcluir.Enabled = true;
        }

        private void pbxLocalizar_Click(object sender, EventArgs e)
        {
            pbxEditar.Enabled = true;
            pbxExcluir.Enabled = true;
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                Entrega entrega = new Entrega();
                entrega.Localizar(id);

                cbxFuncionario.Text = entrega.nome;
                cbxFuncionario.SelectedItem = entrega.nome;
                cbxEpi.SelectedItem = entrega.epi;
                mkEntrega.Text = entrega.entregaData.ToString("yyyy-MM-dd");

                Funcionario funcionario = new Funcionario();
                funcionario.Localizar(entrega.matricula); 
                lblMatricula.Text = funcionario.matricula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao localizar entrega: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregarDados()
        {
            try
            {
                dgvEntrega.Rows.Clear();

                Entrega entrega = new Entrega();
                List<Entrega> entregas = entrega.ListarEntregas();

                foreach (var item in entregas)
                {
                    dgvEntrega.Rows.Add(item.id, item.matricula, item.nome, item.epi, item.entregaData, item.validade);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limparCampos()
        {
            lblMatricula.Text = "";
            cbxFuncionario.SelectedIndex = -1;
            cbxEpi.SelectedIndex = -1;
            mkEntrega.Text = "";
            lblValidade.Text = "";
            pbxEditar.Enabled = false;
            pbxExcluir.Enabled = false;
        }

        private void configurarDataGridView()
        {
            if (dgvEntrega != null)
            {
                dgvEntrega.Columns.Clear();

                dgvEntrega.Columns.Add("id", "ID");
                dgvEntrega.Columns.Add("matricula", "Matrícula");
                dgvEntrega.Columns.Add("nome", "Nome");
                dgvEntrega.Columns.Add("epi", "EPI");
                dgvEntrega.Columns.Add("entrega", "Data de Entrega");
                dgvEntrega.Columns.Add("validade", "Validade do EPI");
            }
            else
            {
                MessageBox.Show("O DataGridView não foi inicializado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Entrega entregaObj = new Entrega();
                int id = Convert.ToInt32(txtId.Text.Trim());
                string nomeFuncionario = cbxFuncionario.SelectedItem.ToString();
                string epi = cbxEpi.SelectedItem.ToString();
                DateTime entregaEpi;

                if (!DateTime.TryParse(mkEntrega.Text, out entregaEpi))
                {
                    MessageBox.Show("Formato de data de entrega inválido! Por favor, insira uma data válida.", "Erro de formato de data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime validadeEpi;
                if (!DateTime.TryParse(lblValidade.Text, out validadeEpi))
                {
                    MessageBox.Show("Formato de data de validade do EPI inválido! Por favor, insira uma data válida.", "Erro de formato de data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int matricula = Convert.ToInt32(lblMatricula.Text);

                entregaObj.Atualizar(id, nomeFuncionario, matricula, epi, entregaEpi, validadeEpi);
                MessageBox.Show("Entrega atualizada com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carregarDados();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar entrega: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Entrega entregaObj = new Entrega();
                int id = Convert.ToInt32(txtId.Text.Trim());
                entregaObj.Excluir(id);
                MessageBox.Show("Entrega excluída com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregarDados();
                limparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
