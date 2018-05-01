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
    }
}
