using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEachArray
{
    public partial class frmTurismo : Form
    {
        public frmTurismo()
        {
            InitializeComponent();
        }

        string[] Local = new string[5];
        int n;

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            for (n = 0; n < Local.Length; n++)
            {
                if(Local[n] == null)
                {
                    if(txtVisitar.Text != "")
                    {
                        Local[n] = txtVisitar.Text;
                        txtVisitar.Text = "";
                        txtVisitar.Focus();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Preencha o local preferido.", null, MessageBoxButtons.OK);
                        txtVisitar.Focus();
                        break;
                    }
                }
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (Local[0] == null)
            {
                MessageBox.Show("Sua lista esta vazia.", null, MessageBoxButtons.OK);
                txtVisitar.Focus();
            }
            else
            {
                foreach (string m in Local)
                {
                    btnMostrar.Enabled = false;

                    try
                    {
                        lbLocais.Items.Add(m);
                    }
                    catch (ArgumentNullException)
                    {

                        MessageBox.Show("Sua lista esta incompleta.", null, MessageBoxButtons.OK);

                        lbLocais.Items.Clear();
                        txtVisitar.Focus();
                        btnMostrar.Enabled = true;
                        break;
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            for(n = 0; n < Local.Length; n++)
            {
                Local[n] = null;
            }

            lbLocais.Items.Clear();
            n = 0;
            MessageBox.Show("O vetor e a lista foram limpas.", null, MessageBoxButtons.OK);
            txtVisitar.Focus();
            btnMostrar.Enabled = true;
         }
    }
}
