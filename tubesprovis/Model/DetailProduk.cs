using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model
{
    public class DetailProduk
    {
       
        private String judul;
        private String tahun_produksi;
        private int durasi;
        private String rating_IMDB;
        private String bahasa;
        private String rated;
        private String subtitle;
        private int harga_display;

        public string Judul { get => judul; set => judul = value; }
        public string Tahun_produksi { get => tahun_produksi; set => tahun_produksi = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public string Rating_IMDB { get => rating_IMDB; set => rating_IMDB = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public string Rated { get => rated; set => rated = value; }
        public string Subtitle { get => subtitle; set => subtitle = value; }
        public int Harga_display { get => harga_display; set => harga_display = value; }
    }
}
