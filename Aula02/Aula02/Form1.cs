using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            txtNomeOK.Text = txtNome.Text;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
