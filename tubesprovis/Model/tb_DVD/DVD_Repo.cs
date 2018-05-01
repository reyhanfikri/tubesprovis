using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace tubesprovis.Model.tb_DVD
{
    public class DVD_Repo
    {

        private MySqlConnection myConn;

        public DVD_Repo()
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

        public List<DVD_Class> getAllDVD()
        {
            try
            {
                string query = "SELECT * FROM tb_dvd";

                OpenConnection();
                List<DVD_Class> hasil = myConn.Query<DVD_Class>(query).ToList();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void insertNewDVD(DVD_Class dvd)
        {
            try
            {
                int id_dvd = dvd.Id_dvd;
                int id_movie = dvd.Id_movie;
                int stock = dvd.Stock;
                int harga_display = dvd.Harga_display;

                string query = "INSERT INTO tb_dvd VALUES (null,'" + id_movie + "','" + stock + "'" + " ,'"
                    + harga_display + "');";

                OpenConnection();
                var hasil = myConn.Execute(query);
                closeConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void updateStockDVD(int id,int stock_berkurang)
        {
            try
            {

                string query = "UPDATE tb_dvd SET stock = " + stock_berkurang + " WHERE id_dvd = " + id + ";";

                OpenConnection();
                var hasil = myConn.Execute(query);
                closeConnection();
            } catch (Exception)
            {
            }
            
        }
    }
}
