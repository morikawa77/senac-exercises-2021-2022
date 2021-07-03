using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetorUni
{
    public partial class frmVetor : Form
    {
        public frmVetor()
        {
            InitializeComponent();
        }

        public int[] lista = new int[100];

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lista[0] = Convert.ToInt32(txtNumero.Text);

            pgbPreenche.Minimum = 0;
            pgbPreenche.Maximum = 100;
            pgbPreenche.Value = 0;

            for(int i = 1; i < lista.Length; i++)
            {
                lista[i] = lista[i - 1] + Convert.ToInt32(txtNumero.Text);

                pgbPreenche.Value++;
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            pgbPreenche.Minimum = 0;
            pgbPreenche.Maximum = 100;
            pgbPreenche.Value = 0;

            for (int i = 0; i < lista.Length; i++)
            {
                lstLista.Items.Add(i);

                pgbPreenche.Value++;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";

            lstLista.Items.Clear();

            pgbPreenche.Value = 0;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
