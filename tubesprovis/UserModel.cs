using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis
{
    public class UserModel
    {
        private string name;
        private string email;
        private DateTime birthdate;

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }
    }
}
