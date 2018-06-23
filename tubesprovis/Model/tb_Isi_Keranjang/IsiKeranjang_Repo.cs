using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace tubesprovis.Model.tb_Isi_Keranjang
{
    public class IsiKeranjang_Repo
    {

        private MySqlConnection myConn;

        public IsiKeranjang_Repo()
        {
            string connectionString = "Server=localhost;Database=db_dvd;Username=root;Password=;SslMode=none";
            myConn = new MySqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            try
            {
                myConn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void closeConnection()
        {
            try
            {
                myConn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<IsiKeranjang_Class> getIsiKeranjang(int id)
        {
            try
            {
                string query = "SELECT id_keranjang FROM tb_keranjang where tb_keranjang.id_cust = "+id+" ORDER BY tb_detail_keranjang.id_detail DESC Limit 1;"
                OpenConnection();
                int id_keranjang = myConn.Query<Integer>()
                query = "SELECT tb_gambar_dvd.url_gambar, tb_movie.judul , tb_detail_keranjang.qty, tb_detail_keranjang.harga_jual, tb_detail_keranjang.total_harga FROM tb_gambar_dvd INNER JOIN tb_detail_keranjang ON tb_gambar_dvd.id_dvd = tb_detail_keranjang.id_dvd INNER JOIN  tb_movie ON tb_gambar_dvd.id_movie = tb_movie.id_movie where tb_detail_keranjang.id_keranjang = "+id_keranjang+" ORDER BY tb_detail_keranjang.id_detail";

                OpenConnection();
                List<IsiKeranjang_Class> hasil = myConn.Query(query).FirstOrDefault();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

    }
}
