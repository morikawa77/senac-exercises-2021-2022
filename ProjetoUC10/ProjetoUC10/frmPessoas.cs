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
using Cadastro.DAL;
using Cadastro.MODEL;
using PersonDAL = Cadastro.DAL.PersonDAL;

namespace ProjetoUC10
{
    public partial class frmPessoas : Form
    {
        PersonDAL personDAL = new PersonDAL();

        Person person = new Person();


        public frmPessoas()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;

            dgvPersons.DataSource = personDAL.GetPersons();

            SetHeadersNames();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtPersonId.Text !="")
            {
                MessageBox.Show(
                    "Você está tentando adicionar um pessoa que já existe. Ao invés disso tente atualizar, apagar ou ainda, limpar os campos para inserir uma nova pessoa.",
                    "Atenção", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning
                );
            } else
            {
                if (verifyFields())
                {
                    MessageBox.Show(
                        "Preencha os campos corretamente",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    person.name = txtName.Text;
                    person.address = txtAddress.Text;
                    person.number = Convert.ToDouble(txtNumber.Text);
                    Regex regexObj = new Regex(@"[^\d]");
                    person.telephone = Convert.ToDouble(regexObj.Replace(txtTelephone.Text, ""));
                    person.city = txtCity.Text;
                    person.state = txtState.Text;

                    var success = personDAL.InsertPerson(person);

                    dgvPersons.DataSource = personDAL.GetPersons();

                    SetHeadersNames();

                    if (success)
                    {
                        ClearControls();
                        MessageBox.Show(
                            "Pessoa adicionada com sucesso.",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                        MessageBox.Show(
                            "Ocorreu algum erro, tente novamente.",
                            "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error  
                        );
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPersonId.Text))
            {
                MessageBox.Show(
                    "Você está tentando atualizar uma pessoa que não ainda não foi cadastrada.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                if (verifyFields())
                {
                    MessageBox.Show(
                        "Preencha os campos corretamente",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    person.person_id = Convert.ToInt32(txtPersonId.Text);
                    person.name = txtName.Text;
                    person.address = txtAddress.Text;
                    person.number = Convert.ToDouble(txtNumber.Text);
                    Regex regexObj = new Regex(@"[^\d]");
                    person.telephone = Convert.ToDouble(regexObj.Replace(txtTelephone.Text, ""));
                    person.city = txtCity.Text;
                    person.state = txtState.Text;

                    var success = personDAL.UpdatePerson(person);

                    dgvPersons.DataSource = personDAL.GetPersons();

                    SetHeadersNames();

                    if (success)
                    {
                        ClearControls();
                        MessageBox.Show(
                            "Pessoa atualizada com sucesso.",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                        MessageBox.Show(
                            "Ocorreu algum erro, tente novamente.",
                            "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPersonId.Text))
            {
                MessageBox.Show(
                    "Você está tentando apagar uma pessoa que ainda não foi cadastrada.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            } else {
                DialogResult dialogResult = MessageBox.Show(
                    "Tem certeza que deseja excluir esse registro?",
                    "Atenção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    person.person_id = Convert.ToInt32(txtPersonId.Text);

                    var success = personDAL.DeletePerson(person);

                    dgvPersons.DataSource = personDAL.GetPersons();

                    SetHeadersNames();

                    if (success)
                    {
                        ClearControls();
                        MessageBox.Show(
                            "Pessoa apagada com sucesso.",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    else
                        MessageBox.Show(
                            "Ocorreu algum erro, tente novamente.",
                            "Atenção",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
            }
                       
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(personDAL.GetPersons());

            dataView.RowFilter = $"Name LIKE '{txtSearchName.Text}%'";

            dgvPersons.DataSource = dataView;

            SetHeadersNames();
        }

        private void btnSearchClear_Click(object sender, EventArgs e)
        {
            txtSearchName.Text = "";

            dgvPersons.DataSource = personDAL.GetPersons();

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

        private bool verifyFields()
        {
            return
            (
            String.IsNullOrWhiteSpace(txtName.Text) ||
            String.IsNullOrWhiteSpace(txtAddress.Text) ||
            String.IsNullOrWhiteSpace(txtNumber.Text) ||
            String.IsNullOrWhiteSpace(txtTelephone.Text) ||
            String.IsNullOrWhiteSpace(txtCity.Text) ||
            String.IsNullOrWhiteSpace(txtState.Text)
            )
            ? true
            : false;
        }
    }
}
