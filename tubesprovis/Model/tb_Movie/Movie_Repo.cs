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
    }
}
