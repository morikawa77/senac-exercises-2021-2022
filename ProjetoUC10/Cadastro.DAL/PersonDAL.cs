using System.Data;
using System.Data.SqlClient;
using Cadastro.MODEL;

namespace Cadastro.DAL
{
    public class PersonDAL
    {
        ConfigurationReader configurationReader = new ConfigurationReader();

        private string myConn => configurationReader.ReadConnection();

        private const string SelectQuery = "Select * from Person";
        private const string InsertQuery = "Insert Into Person(name, telephone, number, address, city, state) Values (@name, @telephone, @number, @address, @city, @state)";
        private const string UpdateQuery = "Update Person set name=@name, telephone=@telephone, number=@number, address=@address, city=@city, state=@state where person_id=@person_id";
        private const string DeleteQuery = "Delete from Person where person_id=@person_id";

        public DataTable GetPersons()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        public bool InsertPerson(Person person)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@person_id", person.person_id);
                    com.Parameters.AddWithValue("@name", person.name);
                    com.Parameters.AddWithValue("@telephone", person.telephone);
                    com.Parameters.AddWithValue("@number", person.number);
                    com.Parameters.AddWithValue("@address", person.address);
                    com.Parameters.AddWithValue("@city", person.city);
                    com.Parameters.AddWithValue("@state", person.state);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool UpdatePerson(Person person)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@person_id", person.person_id);
                    com.Parameters.AddWithValue("@name", person.name);
                    com.Parameters.AddWithValue("@telephone", person.telephone);
                    com.Parameters.AddWithValue("@number", person.number);
                    com.Parameters.AddWithValue("@address", person.address);
                    com.Parameters.AddWithValue("@city", person.city);
                    com.Parameters.AddWithValue("@state", person.state);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool DeletePerson(Person person)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@person_id", person.person_id);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    }
}
