﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tubesprovis.Model
{
    public class Laman_Keranjang
    {
        private String url_gambar;
        private String judul;
        private int qty;
        private int harga_jual;
        private int total_harga;

        public string Url_gambar { get => url_gambar; set => url_gambar = value; }
        public string Judul { get => judul; set => judul = value; }
        public int Qty { get => qty; set => qty = value; }
        public int Harga_jual { get => harga_jual; set => harga_jual = value; }
        public int Total_harga { get => total_harga; set => total_harga = value; }
    }
}
