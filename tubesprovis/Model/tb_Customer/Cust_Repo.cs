using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace tubesprovis.Model.tb_Customer
{
    public class Cust_Repo
    {
        private MySqlConnection myConn;

        public Cust_Repo()
        {
            string connectionString = "Server=localhost;Database=db_dvd;Username=root;Password=;SslMode=none";
            myConn = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                myConn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void closeConnection()
        {
            try
            {
                myConn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Cust_Class> getAllCustomer()
        {

            try
            {
                string query = "SELECT * FROM tb_customer";

                OpenConnection();
                List<Cust_Class> hasil = myConn.Query<Cust_Class>(query).ToList();
                closeConnection();

                return hasil;
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        
        public void insertNewCustomer(Cust_Class cust)
        {
            try
            {
                int id_cust = cust.Id_cust;
                string nama_cust = cust.Nama_cust;
                string username = cust.Username;
                string email = cust.Email;
                string password = cust.Password;

                string query = "INSERT INTO tb_customer VALUES (" + id_cust + ",'" + nama_cust + "','" + username + "'" + " ,'"
                    + email + "','" + password + "');";

                OpenConnection();
                var hasil = myConn.Execute(query);
                closeConnection();
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cust_Class getById(int Id)
        {

            try
            {
                string query = "SELECT * FROM tb_customer  WHERE id = " + Id + ";";

                OpenConnection();
                Cust_Class hasil = myConn.Query<Cust_Class>(query, new { id = Id }).FirstOrDefault();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
