using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model.tb_Keranjang
{
    public class Keranjang_Class
    {
        private int id_keranjang;
        private int id_cust;

        public Keranjang_Class()
        {

        }

        public int Id_keranjang { get => id_keranjang; set => id_keranjang = value; }
        public int Id_cust { get => id_cust; set => id_cust = value; }
    }
}
