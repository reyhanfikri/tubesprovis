using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model
{
    public class Beranda
    {
        private int id_beranda;
        private int id_dvd;
        private int id_gambar;
        private int id_movie;
        private string url_gambar;
        private string judul;
        private int harga_display;

        public Beranda()
        {

        }

        public int Id_beranda { get => id_beranda; set => id_beranda = value; }
        public int Id_dvd { get => id_dvd; set => id_dvd = value; }
        public int Id_gambar { get => id_gambar; set => id_gambar = value; }
        public int Id_movie { get => id_movie; set => id_movie = value; }
        public string Url_gambar { get => url_gambar; set => url_gambar = value; }
        public string Judul { get => judul; set => judul = value; }
        public int Harga_display { get => harga_display; set => harga_display = value; }
    }
}
