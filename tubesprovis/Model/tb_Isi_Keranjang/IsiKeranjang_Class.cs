using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model.tb_Isi_Keranjang
{
    public class IsiKeranjang_Class
    {
        private int id_isi;
        private int id_keranjang;
        private int id_dvd;
        private String url_gambar;
        private String judul;
        private int qty;
        private int harga_jual;
        private int total_harga;

        public IsiKeranjang_Class()
        {

        }

        public int Id_isi { get => id_isi; set => id_isi = value; }
        public int Id_keranjang { get => id_keranjang; set => id_keranjang = value; }
        public int Id_dvd { get => id_dvd; set => id_dvd = value; }
        public string Url_gambar { get => url_gambar; set => url_gambar = value; }
        public string Judul { get => judul; set => judul = value; }
        public int Qty { get => qty; set => qty = value; }
        public int Harga_jual { get => harga_jual; set => harga_jual = value; }
        public int Total_harga { get => total_harga; set => total_harga = value; }
    }
}
