using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model.tb_dictionary
{
    public class Dictionary_class
    {
    	private int id_dictionary;
        private string nama_class;
        private string atribut_class;

        public Dictionary_class()
        {

        }

        public int Id_dictionary { get => id_dictionary; set => id_dictionary = value; }
        public string Nama_class { get => nama_class; set => nama_class = value; }
        public string Atribut_class { get => atribut_class; set => atribut_class = value; }
    }
}
