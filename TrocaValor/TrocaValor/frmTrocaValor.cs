using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocaValor
{
    public partial class frmTrocaValor : Form
    {
        public frmTrocaValor()
        {
            InitializeComponent();
        }

        private void btn_Trocar_Click(object sender, EventArgs e)
        {
            string valor1 = txtValor1.Text;
            string valor2 = txtValor2.Text;
            string valor3 = txtValor3.Text;

            valor1 = valor1 + valor2 + valor3;
            valor3 = valor1.Substring(valor1.Length - (valor2.Length + valor3.Length), valor2.Length);
            valor2 = valor1.Substring(0, valor1.Length - (valor2.Length + valor3.Length));
            valor1 = valor1.Substring((valor1.Length - (valor2.Length + valor3.Length)) + valor2.Length, valor3.Length);

            txtValor1.Text = valor1;
            txtValor2.Text = valor2;
            txtValor3.Text = valor3;

            MessageBox.Show("Troca de valores concluída", "Informaçao", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
