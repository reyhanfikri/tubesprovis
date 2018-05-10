using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Drawing;
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

        public List<GambarDVD_Class> getAllCover()
        {
            try
            {
                string query = "SELECT * FROM tb_gambar_dvd";

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
        public GambarDVD_Class getCoverByIDGambar(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_gambar_dvd where id_gambar="+id+"";

                OpenConnection();
                GambarDVD_Class hasil = myConn.Query<GambarDVD_Class>(query, new { id_gambar = id }).FirstOrDefault();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public GambarDVD_Class getCoverByIDDVD(int id)
        {
            try
            {
                string query = "SELECT * FROM tb_gambar_dvd where id_dvd=" + id + "";

                OpenConnection();
                GambarDVD_Class hasil = myConn.Query<GambarDVD_Class>(query, new { id_dvd = id }).FirstOrDefault();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void insertNewCover(GambarDVD_Class cover)
        {
            int id_gambar = cover.Id_gambar;
            int id_dvd = cover.Id_dvd;
            string url_gambar = cover.Url_gambar;

            string query = "INSERT INTO tb_gambar_dvd VALUES (" + id_gambar + ",'" + id_dvd + "','" + url_gambar + "');";

            OpenConnection();
            var hasil = myConn.Execute(query);
            closeConnection();
        }

        public void coverDVD(GambarDVD_Class cover)
        {
            string sURL = cover.Url_gambar;

            WebRequest req = WebRequest.Create(sURL); //jalur untuk mengakses url
            WebResponse res = req.GetResponse();
            Stream imgStream = res.GetResponseStream();

           // Image Cover = Image.FromStream(imgStream); //generate image dari url
            imgStream.Close();
            var hasil = myConn.Execute(sURL);

            closeConnection();
        }

        public void deleteCoverById(int Id)
        {
            try
            {
                string query = "DELETE FROM tb_gambar_dvd WHERE id = " + Id + ";";

                OpenConnection();
                var hasil = myConn.Execute(query);
                closeConnection();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateCoverDVD(int id, string gambar_sampul)
        {
            string Cover = gambar_sampul;

            string query = "UPDATE tb_gambar_dvd SET stock = " + Cover + " WHERE id_dvd = " + id + ";";

            OpenConnection();
            var hasil = myConn.Execute(query);
            closeConnection();
        }
    }
}
