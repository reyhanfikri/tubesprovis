using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using System.Diagnostics;

namespace tubesprovis.Model
{
    public class DetailProduk_Repo
    {
        private MySqlConnection myConn;

        public DetailProduk_Repo()
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

        public List<DetailProduk> Get(int ID)
        {
            List<DetailProduk> values = new List<DetailProduk>();

            string query = "SELECT tb_movie.judul, tb_movie.tahun_produksi, tb_movie.durasi,tb_movie.rating_IMDB, tb_movie.rated, tb_movie.bahasa,tb_movie.subtitle ,tb_dvd.harga_display FROM tb_movie INNER JOIN tb_dvd on tb_movie.id_movie = tb_dvd.id_movie where tb_movie.id_movie ="+ID+" group by tb_movie.id_movie; ";

            MySqlCommand command = new MySqlCommand(query, myConn);
            OpenConnection();

            MySqlDataReader reader = command.ExecuteReader();

            try
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        values.Add(new DetailProduk { Judul = reader.GetString(0),Tahun_produksi = reader.GetString(1),
                            Durasi = reader.GetInt32(2),Rating_IMDB = reader.GetDecimal(3).ToString(),
                            Bahasa = reader.GetString(4),Rated = reader.GetString(5),
                            Subtitle = reader.GetString(6),Harga_display = reader.GetInt32(7) });

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
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
