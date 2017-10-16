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

        public int AddAddressToContact(int cid, Adress adress)
        {
            int result = 0;

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connString;

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("AddAddress", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramType = new SqlParameter("@type", System.Data.SqlDbType.VarChar);
                paramType.Value = adress.Type;
                sqlCommand.Parameters.Add(paramType);

                SqlParameter paramStreet = new SqlParameter("@street", System.Data.SqlDbType.VarChar);
                paramStreet.Value = adress.Street;
                sqlCommand.Parameters.Add(paramStreet);

                SqlParameter paramCity = new SqlParameter("@city", System.Data.SqlDbType.VarChar);
                paramCity.Value = adress.City;
                sqlCommand.Parameters.Add(paramCity);

                SqlParameter paramCid = new SqlParameter("@cid", System.Data.SqlDbType.VarChar);
                paramCid.Value = cid;
                sqlCommand.Parameters.Add(paramCid);

                SqlParameter paramAid = new SqlParameter("@aid", System.Data.SqlDbType.VarChar);
                paramAid.Direction = System.Data.ParameterDirection.Output;
                sqlCommand.Parameters.Add(paramAid);

                sqlCommand.ExecuteNonQuery();

                result = int.Parse(paramAid.Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

            return result;
        }

        public int DeleteContact(int cid)
        {
            int result = 0;

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connString;

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("DeleteContact", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramCid = new SqlParameter("@cid", System.Data.SqlDbType.Int);
                paramCid.Value = cid;
                sqlCommand.Parameters.Add(paramCid);

                result = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

            return result;
        }
        public int CreateContact(Contact contact)
        {
            int result = 0;

            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = connString;

            try
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand("AddContact", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter paramFirstname = new SqlParameter("@firstname", System.Data.SqlDbType.VarChar);
                paramFirstname.Value = contact.Firstname;
                sqlCommand.Parameters.Add(paramFirstname);

                SqlParameter paramLastname = new SqlParameter("@lastname", System.Data.SqlDbType.VarChar);
                paramLastname.Value = contact.Lastname;
                sqlCommand.Parameters.Add(paramLastname);

                SqlParameter paramSSN = new SqlParameter("@ssn", System.Data.SqlDbType.VarChar);
                paramSSN.Value = contact.SSN;
                sqlCommand.Parameters.Add(paramSSN);

                SqlParameter paramCID = new SqlParameter("@ssn", System.Data.SqlDbType.VarChar);
                paramCID.Direction = System.Data.ParameterDirection.Output;
                sqlCommand.Parameters.Add(paramCID);

                sqlCommand.ExecuteNonQuery();

                result = int.Parse(paramCID.Value.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }

            return result;
        }
    }
}
