using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace tubesprovis.Model.tb_Movie
{
    public class Movie_Repo
    {

        private MySqlConnection myConn;

        public Movie_Repo()
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

        public List<Movie_Class> getAllMovie()
        {
            try
            {
                string query = "SELECT * FROM tb_movie";

                OpenConnection();
                List<Movie_Class> hasil = myConn.Query<Movie_Class>(query).ToList();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void insertNewMovie(Movie_Class movie)
        {
            try
            {
                int id_genre = movie.Id_genre;
                string judul = movie.Judul;
                int tahun_produksi = movie.Tahun_produksi;
                int durasi = movie.Durasi;
                decimal rating_imdb = movie.Rating_imdb;
                string rated = movie.Rated;
                string bahasa = movie.Bahasa;
                string subtitle = movie.Subtitle;

                string query = "INSERT INTO tb_movie VALUES (null, '" + id_genre + "', '" + judul + "', '" + tahun_produksi + "', '" + durasi + "', '" + rating_imdb + "', '" + rated + "', '" + bahasa + "', '" + subtitle + "')";

                OpenConnection();
                var hasil = myConn.Execute(query);
                closeConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Movie_Class getById(int Id)
        {

            try
            {
                string query = "SELECT * FROM tb_movie  WHERE id_movie = " + Id + ";";

                OpenConnection();
                Movie_Class hasil = myConn.Query<Movie_Class>(query, new { id = Id }).FirstOrDefault();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Movie_Class> getAllNamaAndIDMovie()
        {
            try
            {
                string query = "SELECT id_movie,judul FROM tb_movie";

                OpenConnection();
                List<Movie_Class> hasil = myConn.Query<Movie_Class>(query).ToList();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void deleteMovieById(int Id)
        {
            try
            {
                string query = "DELETE FROM tb_movie WHERE id_movie = " + Id + ";";

                OpenConnection();
                var hasil = myConn.Execute(query);
                closeConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateJudulMovie(int Id, string Judul)
        {
            try
            {

                string query = "UPDATE tb_movie SET judul = " + Judul + " WHERE id_movie = " + Id + ";";

                OpenConnection();
                var hasil = myConn.Execute(query);
                closeConnection();
            }
            catch (Exception)
            {
            }
        }
    }
}
