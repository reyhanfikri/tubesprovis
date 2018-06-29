using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model
{
    public class UserModel
    {
        private int id_cust;
        private string nama_cust;
        private string username;
        private string email;
        

        public int Id_cust { get => id_cust; set => id_cust = value; }
        public string Nama_cust { get => nama_cust; set => nama_cust = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        

    }
}
