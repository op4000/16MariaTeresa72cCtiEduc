using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16MariaTeresa72cCtiEduc
{
    public partial class frmFrase : Form
    {
        public frmFrase()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmFrase_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Você realmente deseja sair?",
                            "Cadastro de Curso",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void frmFrase_Load(object sender, EventArgs e)
        {
            btnRefazer.Visible = false;
        }

        private void btnBloqueado_Click(object sender, EventArgs e)
        {
            if (txtBloqueado.Text == "lembrei que to bloqueado e muita raiva misturada com tristeza") 
            {
                MessageBox.Show("Você acertou", "Acertou", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtBloqueado.Enabled = false;
                txtBloqueado.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Você errou", "Errou", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnEvidencias_Click(object sender, EventArgs e)
        {
            if (txtEvidencias.Text == "e nessa loucura de dizer que nao te quero vou negando as aparencias disfarçando as evidencias")
            {
                MessageBox.Show("Você acertou", "Acertou", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtEvidencias.Enabled = false;
                txtEvidencias.BackColor = Color.Green;
                txtEvidencias.Text = "";
            }
            else
            {
                MessageBox.Show("Você errou", "Errou", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void btnQueda_Click(object sender, EventArgs e)
        {
                if (txtAqueda.Text == "respeitavel publico um show tao maluco essa noite vai acontecer aqui a gente vai armar um circo")
                {
                    MessageBox.Show("Você acertou", "Acertou", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txtAqueda.Enabled = false;
                    txtAqueda.BackColor = Color.Green;
                    btnRefazer.Visible = true;
                    txtAqueda.Text = "";
            }
                else
                {
                    MessageBox.Show("Você errou", "Errou", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
        }

        private void btnRefazer_Click_1(object sender, EventArgs e)
        {
            txtBloqueado.Enabled = true;
            txtEvidencias.Enabled = true;
            txtAqueda.Enabled = true;
            txtBloqueado.BackColor = Color.White;
            txtEvidencias.BackColor = Color.White;
            txtAqueda.BackColor = Color.White;
            btnRefazer.Visible = false;
            txtEvidencias.Text = "";
            txtAqueda.Text = "";
            txtBloqueado.Text = "";
        }
    }
}
