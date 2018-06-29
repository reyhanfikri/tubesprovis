using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model.tb_Genre
{
    public class Genre_Class
    {
        private int id_genre;
        private string genre;

        public Genre_Class()
        {

        }

        public int Id_genre { get => id_genre; set => id_genre = value; }
        public string Genre { get => genre; set => genre = value; }
    }
}
