using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model.tb_Customer
{
    public class Cust_Class
    {
        private string id_cust;
        private string nama_cust;
        private string username;
        private string email;
        private string password;

        public Cust_Class()
        {

        }

        public string Id_cust { get => id_cust; set => id_cust = value; }
        public string Nama_cust { get => nama_cust; set => nama_cust = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
