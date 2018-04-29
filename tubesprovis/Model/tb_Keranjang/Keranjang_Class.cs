using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model.tb_Keranjang
{
    public class Keranjang_Class
    {
        private string id_keranjang;
        private string id_cust;

        public Keranjang_Class()
        {

        }

        public string Id_keranjang { get => id_keranjang; set => id_keranjang = value; }
        public string Id_cust { get => id_cust; set => id_cust = value; }
    }
}
