using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace tubesprovis.Model.tb_Keranjang
{
    public class Keranjang_Repo
    {
        private MySqlConnection myConn;

        public Keranjang_Repo()
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

        public List<Keranjang_Class> getAllKeranjang()
        {
            try
            {
                string query = "SELECT * FROM tb_keranjang";

                OpenConnection();
                List<Keranjang_Class> hasil = myConn.Query<Keranjang_Class>(query).ToList();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void insertKeranjang(Keranjang_Class keranjang)
        {
            int id_keranjang = keranjang.Id_keranjang;
            int id_cust = keranjang.Id_cust;

            string query = "INSERT INTO tb_keranjang VALUES (" + id_keranjang + ",'" + id_cust + "');";

            OpenConnection();
            var hasil = myConn.Execute(query);
            closeConnection();
        }
    }
}
