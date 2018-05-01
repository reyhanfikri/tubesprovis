using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace tubesprovis.Model.tb_Gambar_DVD
{
    public class GambarDVD_Repo
    {
        private MySqlConnection myConn;

        public GambarDVD_Repo()
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

        public List<GambarDVD_Class> getAllGenre()
        {
            try
            {
                string query = "SELECT * FROM tb_genre";

                OpenConnection();
                List<GambarDVD_Class> hasil = myConn.Query<GambarDVD_Class>(query).ToList();
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
