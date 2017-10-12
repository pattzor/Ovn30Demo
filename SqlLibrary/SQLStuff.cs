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

                    contacts.Add(new Contact(firstName, lastName, ssn, id));
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

        public void AddAddressToContact(int cid, Adress adress)
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connString;

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "insert into Adress (Street, City) values (@street, @city)";

                sqlCommand.Connection = sqlConnection;

                SqlParameter paramStreet = new SqlParameter("@street", System.Data.SqlDbType.VarChar);
                paramStreet.Value = adress.street;
                sqlCommand.Parameters.Add(paramStreet);

                SqlParameter paramCity = new SqlParameter("@city", System.Data.SqlDbType.VarChar);
                paramCity.Value = adress.city;
                sqlCommand.Parameters.Add(paramCity);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public void CreateContact(Contact contact)
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connString;

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "insert into Contact (Firstname, Lastname, SSN) values (@firstname, @lastname, @ssn)";

                sqlCommand.Connection = sqlConnection;

                SqlParameter paramFirstname = new SqlParameter("@firstname", System.Data.SqlDbType.VarChar);
                paramFirstname.Value = contact.Firstname;
                sqlCommand.Parameters.Add(paramFirstname);

                SqlParameter paramLastname = new SqlParameter("@lastname", System.Data.SqlDbType.VarChar);
                paramLastname.Value = contact.Lastname;
                sqlCommand.Parameters.Add(paramLastname);

                SqlParameter paramSSN = new SqlParameter("@ssn", System.Data.SqlDbType.VarChar);
                paramSSN.Value = contact.SSN;
                sqlCommand.Parameters.Add(paramSSN);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

        }
    }
}
