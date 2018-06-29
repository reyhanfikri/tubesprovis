using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model.tb_Gambar_DVD
{
    public class GambarDVD_Class
    {

        private int id_gambar;
        private int id_dvd;
        private int id_movie;
        private string url_gambar;

        public GambarDVD_Class()
        {

        }

        public int Id_gambar { get => id_gambar; set => id_gambar = value; }
        public int Id_dvd { get => id_dvd; set => id_dvd = value; }
        public int Id_movie { get => id_movie; set => id_movie = value; }
        public string Url_gambar { get => url_gambar; set => url_gambar = value; }
       
    }
}
