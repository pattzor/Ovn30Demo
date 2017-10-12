using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLibrary
{
    public class SQLStuff
    {
        private string connString = @"Data Source=.;Initial Catalog=MussePigg;Integrated Security=True";

        /// <summary>
        /// Reads all contacts from model and returns in a List<Contact>
        /// 
        /// Throws all kinds of Exceptions if the model is weird
        /// </summary>
        /// <returns>List<Contact></returns>
        public List<Contact> ReadAllContacts()
        {
            List<Contact> contacts = new List<Contact>();

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connString;

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "select * from Contact";

                sqlCommand.Connection = sqlConnection;

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    int id = Convert.ToInt32(sqlDataReader["ID"]);
                    string firstName = sqlDataReader["Firstname"].ToString();
                    string lastName = sqlDataReader["Lastname"].ToString();
                    string ssn = sqlDataReader["SSN"].ToString();

                    contacts.Add(new Contact() { Firstname = firstName, Lastname = lastName, SSN = ssn, ID = id });
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

            return contacts;
        }


    }
}
