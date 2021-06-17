using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoUC10
{
    public partial class frmPessoas : Form
    {
        List<Person> listOfPerson = new List<Person>();
        
        public frmPessoas()
        {
            InitializeComponent();
        }

        private void frmPessoas_Load(object sender, EventArgs e)
        {
            // LoadPeople();

            string userName = "sa";
            string password = "^F^XnEKNnak%";
            string server = "192.168.15.77";

            var connectionString = string.Format($"Data Source={server};User ID={userName};Password={password}");

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM UC10Project.dbo.Person";
                using (var command = new SqlCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var person = new Person();
                            person.personId = Convert.ToInt32(reader["person_id"]);
                            person.name = reader["name"].ToString();
                            person.telephone = Convert.ToDouble(reader["telephone"]);
                            person.number = Convert.ToDouble(reader["number"]);
                            person.address = reader["address"].ToString();
                            person.city = reader["city"].ToString();
                            person.state = reader["state"].ToString();

                            listOfPerson.Add(person);
                        }
                    }
                }
            }

            dgvPersons.DataSource = listOfPerson;

            dgvPersons.Columns[0].HeaderText = "Código";
            dgvPersons.Columns[1].HeaderText = "Nome";
            dgvPersons.Columns[2].HeaderText = "Telefone";
            dgvPersons.Columns[3].HeaderText = "Número";
            dgvPersons.Columns[4].HeaderText = "Endereço";
            dgvPersons.Columns[5].HeaderText = "Cidade";
            dgvPersons.Columns[6].HeaderText = "Estado";
        }

    }
}
