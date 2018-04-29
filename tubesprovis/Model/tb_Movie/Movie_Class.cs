using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model.tb_Movie
{
    public class Movie_Class
    {
        private int id_movie;
        private int id_genre;
        private string judul;
        private int tahun_produksi;
        private DateTime durasi;
        private int rating_imdb;
        private string rated;
        private string bahasa;
        private string subtitle;

        public Movie_Class()
        {

        }

        public int Id_movie { get => id_movie; set => id_movie = value; }
        public int Id_genre { get => id_genre; set => id_genre = value; }
        public string Judul { get => judul; set => judul = value; }
        public int Tahun_produksi { get => tahun_produksi; set => tahun_produksi = value; }
        public DateTime Durasi { get => durasi; set => durasi = value; }
        public int Rating_imdb { get => rating_imdb; set => rating_imdb = value; }
        public string Rated { get => rated; set => rated = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public string Subtitle { get => subtitle; set => subtitle = value; }
    }
}
