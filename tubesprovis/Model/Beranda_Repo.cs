using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using System.Diagnostics;

namespace tubesprovis.Model
{
    public class Beranda_Repo
    {
        private MySqlConnection myConn;

        public Beranda_Repo()
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

        public List<Beranda> GetBerandaByID(int id)
        {
            List<Beranda> values = new List<Beranda>();
          
            string query = "SELECT tb_gambar_dvd.url_gambar, tb_movie.judul, tb_dvd.harga_display " +
                "FROM tb_gambar_dvd INNER JOIN tb_dvd ON tb_gambar_dvd.id_movie = tb_dvd.id_movie" +
                "WHERE tb_gambar.id_gambar = " + id + "tb_movie.id_movie="+id+"tb_dvd.id_dvd="+id+  
                "INNER JOIN tb_movie ON tb_movie.id_movie = tb_dvd.id_movie group by tb_dvd.id_movie";

            MySqlCommand command = new MySqlCommand(query,myConn);
            OpenConnection();
           
            MySqlDataReader reader = command.ExecuteReader();
             
            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
            
                        values.Add(new Beranda { Url_gambar = reader.GetString(0), Judul = reader.GetString(1), Harga_display = reader.GetInt32(2) });
       
                    }
                    
                    reader.NextResult();
                }
                else
                {

                }
               
                reader.Close();
                closeConnection();
                return values;

            }
            catch(Exception ex)
            {
                
                throw ex;
            }
        }
    }
}
