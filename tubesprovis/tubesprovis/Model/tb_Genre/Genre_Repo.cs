using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace tubesprovis.Model.tb_Genre
{
    public class Genre_Repo
    {
        private MySqlConnection myConn;

        public Genre_Repo()
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

        public List<Genre_Class> getAllGenre()
        {
            try
            {
                string query = "SELECT * FROM tb_genre";

                OpenConnection();
                List<Genre_Class> hasil = myConn.Query<Genre_Class>(query).ToList();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateNamaGenre(int Id, string Genre)
        {
            try
            {

                string query = "UPDATE tb_genre SET genre = " + Genre + " WHERE id_genre = " + Id + ";";

                OpenConnection();
                var hasil = myConn.Execute(query);
                closeConnection();
            }
            catch (Exception)
            {
            }
        }

        public Genre_Class getById(int Id)
        {
            try
            {
                string query = "SELECT * FROM tb_genre WHERE id_genre = " + Id + ";";

                OpenConnection();
                Genre_Class hasil = myConn.Query<Genre_Class>(query, new { id_cust = Id }).FirstOrDefault();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteGenre(int id_genre)
        {
            try
            {

                string query = "DELETE FROM tb_genre WHERE id_genre = " + id_genre + ";";

                OpenConnection();
                var hasil = myConn.Execute(query);
                closeConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
