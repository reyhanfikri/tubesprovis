﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace tubesprovis.Model.tb_DVD
{
    public class DVD_Repo
    {

        private MySqlConnection myConn;

        public DVD_Repo()
        {
            string connectionString = "Server=localhost;Database=db_dvd;Username=root;Password=";
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

    }
}
