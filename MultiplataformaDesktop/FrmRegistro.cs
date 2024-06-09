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
    public partial class FrmRegistro : Form
    {
        private Entrega entrega;
        public FrmRegistro()
        {
            entrega = new Entrega();
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            
        }

        private void pbxSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEntregas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEntregas.Rows[e.RowIndex];
                txtMatricula.Text = row.Cells[0].Value.ToString();
            }
        }
        private void CarregarDados()
        {
            dgvEntregas.DataSource = entrega.ListarEntregas();
        }

        private void LimparCampos()
        {
            txtMatricula.Text = "";
        }

        private void pbxLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtMatricula.Text))
                {
                    int matricula = Convert.ToInt32(txtMatricula.Text.Trim());

                    // Realize a consulta ao banco de dados para obter as entregas correspondentes à matrícula
                    // Supondo que exista um método na classe Entrega para isso
                    dgvEntregas.DataSource = entrega.ListarPorMatricula(matricula);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
