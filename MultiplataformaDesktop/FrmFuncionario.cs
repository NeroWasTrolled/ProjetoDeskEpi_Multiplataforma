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
    public partial class FrmFuncionario : Form
    {
        private Funcionario funcionario;

        public FrmFuncionario()
        {
            InitializeComponent();
            funcionario = new Funcionario();
            CarregarDados();
            pbxEditar.Enabled = false;
            pbxExcluir.Enabled = false;
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
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
                int matricula = Convert.ToInt32(txtMatricula.Text.Trim());
                if (funcionario.RegistroRepetido(matricula, txtNome.Text, mkCpf.Text, mkCelular.Text))
                {
                    MessageBox.Show("Funcionário já existe em nossa base de dados!", "Registro Repetido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    funcionario.Inserir(matricula, txtNome.Text, mkCpf.Text, mkCelular.Text);
                    MessageBox.Show("Funcionário inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarDados();
                    LimparCampos();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxLocalizar_Click(object sender, EventArgs e)
        {
            pbxEditar.Enabled = true;
            pbxExcluir.Enabled = true;
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                funcionario.Localizar(id);
                txtMatricula.Text = funcionario.matricula.ToString();
                txtNome.Text = funcionario.nome;
                mkCpf.Text = funcionario.cpf;
                mkCelular.Text = funcionario.celular;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                int matricula = Convert.ToInt32(txtMatricula.Text.Trim());
                funcionario.Atualizar(id, matricula, txtNome.Text, mkCpf.Text, mkCelular.Text);
                MessageBox.Show("Funcionário atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarDados();
                LimparCampos();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbxExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                funcionario.Excluir(id);
                MessageBox.Show("Funcionário excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarDados();
                LimparCampos();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvFuncionario.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtMatricula.Text = row.Cells[1].Value.ToString();
                txtNome.Text = row.Cells[2].Value.ToString();
                mkCpf.Text = row.Cells[3].Value.ToString();
                mkCelular.Text = row.Cells[4].Value.ToString();
            }
            pbxEditar.Enabled = true;
            pbxExcluir.Enabled = true;
        }

        private void CarregarDados()
        {
            dgvFuncionario.DataSource = funcionario.listafuncionario();
        }

        private void LimparCampos()
        {
            txtId.Text = "";
            txtMatricula.Text = "";
            txtNome.Text = "";
            mkCpf.Text = "";
            mkCelular.Text = "";
            pbxEditar.Enabled = false;
            pbxExcluir.Enabled = false;
        }
    }

}
