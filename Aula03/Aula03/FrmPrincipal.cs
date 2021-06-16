using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03
{
    public partial class FrmPrincipal : Form
    {
        List<Cliente> listaClientes;
        List<Estado> listaEstados;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            listaClientes = new List<Cliente>
            {
                new Cliente { Id = 1, Nome = "Reginaldo", Email = "morikawa77@gmail.com", Idade = 40}
            };

            dgvListaPessoas.DataSource = listaClientes;

            lblQuantidade.Text = listaClientes.Count.ToString() + " alunos";
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            listaEstados = new List<Estado>
            {
                new Estado { Id = 1, UF = "Sao Paulo"},
                new Estado { Id = 2, UF = "California"}
            };

            cbEstado.DataSource = listaEstados;
            cbEstado.ValueMember = "Id";
            cbEstado.DisplayMember = "UF";

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEstado.Text = cbEstado.Text;
        }
    }
}
