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
    public partial class frmCadastro : Form
    {

        List<Person> persons = new List<Person>();
        moduleExcel excelImp = new moduleExcel();

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            persons.Add(new Person() { Name = txtNome.Text, Surname = txtSobrenome.Text, birthDate = dtpDataNascimento.Value, Telefone = mtxtTelefone.Text});
            dgvPessoas.DataSource = null;
            dgvPessoas.DataSource = persons;
            dvgPessoasHeaders();
            clearFields();
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCadastro_Shown(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Maximized;
        }

        public void frmCadastro_Load(object sender, EventArgs e)
        {
            dgvPessoas.DataSource = persons;
            dvgPessoasHeaders();

        }

        public void dvgPessoasHeaders()
        {
            dgvPessoas.Columns[0].HeaderText = "Nome";
            dgvPessoas.Columns[1].HeaderText = "Sobrenome";
            dgvPessoas.Columns[2].HeaderText = "Data de Nascimento";
            dgvPessoas.Columns[3].HeaderText = "Celular";
        }

        public void clearFields()
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            dtpDataNascimento.Value = DateTime.Today;
            mtxtTelefone.Text = "";
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "Cadastro.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                excelImp.ToCsV(dgvPessoas, sfd.FileName);
                MessageBox.Show("Arquivo Exportado");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime birthDate { get; set; }

        public string Telefone { get; set; }
    }
}
