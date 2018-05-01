using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace tubesprovis.Model.tb_Detail_Keranjang
{
    public class DetailKeranjang_Repo
    {

        private MySqlConnection myConn;

        public DetailKeranjang_Repo()
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

        public List<DetailKeranjang_Class> getAllDetailKeranjang()
        {
            try
            {
                string query = "SELECT * FROM tb_detail_keranjang";

                OpenConnection();
                List<DetailKeranjang_Class> hasil = myConn.Query<DetailKeranjang_Class>(query).ToList();
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
