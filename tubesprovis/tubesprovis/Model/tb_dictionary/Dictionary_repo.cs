using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace tubesprovis.Model.tb_dictionary
{
    public class Dictionary_repo
    {
        private MySqlConnection myConn;

        public Dictionary_repo()
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

        public List<Dictionary_class> getDictionary()
        {

            try
            {
                string query = "SELECT * FROM tb_dictionary";

                OpenConnection();
                List<Dictionary_class> hasil = myConn.Query<Dictionary_class>(query).ToList();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public void DeleteDictionary(int id_dictionary)
        {
            try
            {

                string query = "DELETE FROM tb_dictionary WHERE id_dictionary = " + id_dictionary + ";";

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
