using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaAluno
{
    public partial class frmMatricula : Form
    {
        public frmMatricula()
        {
            InitializeComponent();

            lblHoje.Text = $"Hoje é dia {DateTime.Now.ToShortDateString()}";
        }

        private void btnIdentificar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty)
            {
                MessageBox.Show("Todos os dados solicitados devem ser informados.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                TimeSpan tsQuantidadeDeDias = DateTime.Now.Date - dtpNascimento.Value;


                int idade = Convert.ToInt32(tsQuantidadeDeDias.Days / 365.25);

                lblIdadeAtual.Text = $"Sua idade hoje é de {idade} anos.";

                if (idade > 17)
                {
                    lblMostraCategoria.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblMostraCategoria.Text = "Juvenil B";
                }
                else if (idade > 10)
                {
                    lblMostraCategoria.Text = "Juvenil A";
                }
                else if (idade > 7)
                {
                    lblMostraCategoria.Text = "Infantil B";
                }
                else if (idade > 5)
                {
                    lblMostraCategoria.Text = "Infantil A";
                }
                else
                {
                    lblMostraCategoria.Text = "Não existe esta categoria.";
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
