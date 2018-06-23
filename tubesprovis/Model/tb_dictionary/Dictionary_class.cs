using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model.tb_dictionary
{
    public class Dictionary_class
    {
    	private int id_dictionary;
        private string nama_tabel;
        private string atribut_tabel;

        public Dictionary_class()
        {

        }

        public int Id_dictionary { get => id_dictionary; set => id_dictionary = value; }
        public string Nama_tabel { get => nama_tabel; set => nama_tabel = value; }
        public string Atribut_tabel { get => atribut_tabel; set => atribut_tabel = value; }
    }
}
