using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model.tb_DVD
{
    public class DVD_Class
    {
        private int id_dvd;
        private int id_movie;
        private int stock;
        private int harga_display;

        public DVD_Class()
        {

        }

        public int Id_dvd { get => id_dvd; set => id_dvd = value; }
        public int Id_movie { get => id_movie; set => id_movie = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Harga_display { get => harga_display; set => harga_display = value; }
    }
}
