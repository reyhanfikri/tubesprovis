using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model.tb_Detail_Keranjang
{
    public class DetailKeranjang_Class
    {
        private string id_detail;
        private string id_keranjang;
        private string id_dvd;
        private int qty;
        private int harga_jual;
        private int total_harga;

        public DetailKeranjang_Class()
        {

        }

        public string Id_detail { get => id_detail; set => id_detail = value; }
        public string Id_keranjang { get => id_keranjang; set => id_keranjang = value; }
        public string Id_dvd { get => id_dvd; set => id_dvd = value; }
        public int Qty { get => qty; set => qty = value; }
        public int Harga_jual { get => harga_jual; set => harga_jual = value; }
        public int Total_harga { get => total_harga; set => total_harga = value; }
    }
}
