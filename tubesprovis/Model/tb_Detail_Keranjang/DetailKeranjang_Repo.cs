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

                string query = "INSERT INTO tb_detail_keranjang VALUES (" + id_detail + ",'" + id_keranjang + "','" + id_dvd + "'" +
                    ",'" + qty + "','" + harga_jual + "','" + total_harga + "');";

                OpenConnection();
                var hasil = myConn.Execute(query);
                closeConnection();
            } catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
