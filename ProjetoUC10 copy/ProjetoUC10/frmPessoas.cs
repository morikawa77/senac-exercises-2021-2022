using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoUC10
{
    public partial class frmPessoas : Form
    {
        Person person = new Person();


        public frmPessoas()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            dgvPersons.DataSource = person.GetPersons();

            SetHeadersNames();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            person.name = txtName.Text;
            person.address = txtAddress.Text;
            person.number = Convert.ToDouble(txtNumber.Text);
            Regex regexObj = new Regex(@"[^\d]");
            person.telephone = Convert.ToDouble(regexObj.Replace(txtTelephone.Text, ""));
            person.city = txtCity.Text;
            person.state = txtState.Text;

            var success = person.InsertPerson(person);

            dgvPersons.DataSource = person.GetPersons();

            SetHeadersNames();

            if (success)
            {
                ClearControls();
                MessageBox.Show("Pessoa adicionada com sucesso.");
            }
            else
                MessageBox.Show("Ocorreu algum erro, tente novamente.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            person.person_id = Convert.ToInt32(txtPersonId.Text);
            person.name = txtName.Text;
            person.address = txtAddress.Text;
            person.number = Convert.ToDouble(txtNumber.Text);
            Regex regexObj = new Regex(@"[^\d]");
            person.telephone = Convert.ToDouble(regexObj.Replace(txtTelephone.Text, ""));
            person.city = txtCity.Text;
            person.state = txtState.Text;

            var success = person.UpdatePerson(person);

            dgvPersons.DataSource = person.GetPersons();

            SetHeadersNames();

            if (success)
            {
                ClearControls();
                MessageBox.Show("Pessoa atualizada com sucesso.");
            }
            else
                MessageBox.Show("Ocorreu algum erro, tente novamente.");

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            person.person_id = Convert.ToInt32(txtPersonId.Text);

            var success = person.DeletePerson(person);

            dgvPersons.DataSource = person.GetPersons();

            SetHeadersNames();

            if (success)
            {
                ClearControls();
                MessageBox.Show("Pessoa apagada com sucesso.");
            }
            else
                MessageBox.Show("Ocorreu algum erro, tente novamente.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(person.GetPersons());

            dataView.RowFilter = $"Name LIKE '{txtSearchName.Text}%'";

            dgvPersons.DataSource = dataView;

            SetHeadersNames();
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            txtSearchName.Text = "";

            dgvPersons.DataSource = person.GetPersons();

            SetHeadersNames();
        }

        private void ClearControls()
        {
            txtPersonId.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtNumber.Text = "";
            txtTelephone.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
        }

        private void SetHeadersNames()
        {
            dgvPersons.Columns[0].HeaderText = "Código";
            dgvPersons.Columns[1].HeaderText = "Nome";
            dgvPersons.Columns[2].HeaderText = "Telefone";
            dgvPersons.Columns[3].HeaderText = "Número";
            dgvPersons.Columns[4].HeaderText = "Endereço";
            dgvPersons.Columns[5].HeaderText = "Cidade";
            dgvPersons.Columns[6].HeaderText = "Estado";
        }

        private void dgvPersons_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = e.RowIndex;
            txtPersonId.Text = dgvPersons.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dgvPersons.Rows[index].Cells[1].Value.ToString();
            txtAddress.Text = dgvPersons.Rows[index].Cells[4].Value.ToString();
            txtNumber.Text = dgvPersons.Rows[index].Cells[3].Value.ToString();
            txtTelephone.Text = dgvPersons.Rows[index].Cells[2].Value.ToString();
            txtCity.Text = dgvPersons.Rows[index].Cells[5].Value.ToString();
            txtState.Text = dgvPersons.Rows[index].Cells[6].Value.ToString();
        }
    }
}
