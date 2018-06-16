using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;

namespace tubesprovis.Model.tb_Detail_Keranjang
{
    public class DetailKeranjang_Repo
    {

        private MySqlConnection myConn;

        public DetailKeranjang_Repo()
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

        public List<DetailKeranjang_Class> getAllDetailKeranjang()
        {
            try
            {
                string query = "SELECT * FROM tb_detail_keranjang";

                OpenConnection();
                List<DetailKeranjang_Class> hasil = myConn.Query<DetailKeranjang_Class>(query).ToList();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void insertDetailKeranjang(DetailKeranjang_Class detail_keranjang)
        {
            try
            {
                int id_detail = detail_keranjang.Id_detail;
                int id_keranjang = detail_keranjang.Id_keranjang;
                int id_dvd = detail_keranjang.Id_dvd;
                int qty = detail_keranjang.Qty;
                int harga_jual = detail_keranjang.Harga_jual;
                int total_harga = detail_keranjang.Total_harga;

                string query = "INSERT INTO tb_detail_keranjang VALUES (null,'" + id_keranjang + "','" + id_dvd + "'" +
                    ",'" + qty + "','" + harga_jual + "','" + total_harga + "');";

                OpenConnection();
                var hasil = myConn.Execute(query);
                closeConnection();
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public DetailKeranjang_Class getById(int Id)
        {
            try
            {
                string query = "SELECT * FROM tb_detail_keranjang WHERE id_detail = " + Id + ";";

                OpenConnection();
                DetailKeranjang_Class hasil = myConn.Query<DetailKeranjang_Class>(query, new { id_cust = Id }).FirstOrDefault();
                closeConnection();

                return hasil;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DetailKeranjang_Class> getByIdKeranjang(int Id)
        {
            try
            {
                string query = "SELECT tb_gambar_dvd.url_gambar, tb_movie.judul , tb_detail_keranjang.qty, tb_detail_keranjang.harga_jual, tb_detail_keranjang.total_harga FROM tb_gambar_dvd " +
                    "INNER JOIN tb_detail_keranjang ON tb_gambar_dvd.id_dvd = tb_detail_keranjang.id_dvd " +
                    "INNER JOIN  tb_movie ON tb_gambar_dvd.id_movie = tb_movie.id_movie " +
                    "where tb_detail_keranjang.id_detail = 1 " +
                    "ORDER BY tb_detail_keranjang.id_dvd;";

                OpenConnection();
                List<DetailKeranjang_Class> hasil = myConn.Query<DetailKeranjang_Class>(query, new { id_keranjang = Id }).ToList();
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
