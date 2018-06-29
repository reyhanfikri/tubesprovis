using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model
{
    public class Beranda
    {
        
        private int id_movie;
        private String url_gambar;
        private String judul;
        private int harga_display;

        public int Id_movie { get => id_movie; set => id_movie = value; }
        public string Url_gambar { get => url_gambar; set => url_gambar = value; }
        public string Judul { get => judul; set => judul = value; }
        public int Harga_display { get => harga_display; set => harga_display = value; }
    }
}
