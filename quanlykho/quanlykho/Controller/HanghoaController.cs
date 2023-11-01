using quanlykho.Model;
using quanlykho.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlykho.Controller
{
    internal class HanghoaController
    {
        List<Hanghoa> hanghoaList;
        public HanghoaController()
        {
            hanghoaList = new List<Hanghoa>();
        }
        public List<Hanghoa> Load()
        {
            SqlConnection conn = DBhelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                hanghoaList.Clear();
                // Tạo câu lệnh SQL để truy vấn dữ liệu
                SqlCommand cmd = new SqlCommand("SELECT * FROM hanghoa", conn);

                // Thực hiện truy vấn
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String mahang = reader["mahang"].ToString();
                    String tenhang = reader["tenhang"].ToString();
                    String loaihang = reader["loaihang"].ToString();
                    Hanghoa hanghoa = new Hanghoa(mahang, tenhang, loaihang);
                    hanghoaList.Add(hanghoa);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return hanghoaList;
        }
        public void InsertData(string mahang, string tenhang, string loaihang)
        {
            SqlConnection conn = DBhelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo câu lệnh SQL để chèn dữ liệu
                string sql = "INSERT INTO hanghoa (mahang, tenhang, loaihang) VALUES (@mahang, @tenhang, @loaihang)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Sét đặt tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@mahang", mahang);
                cmd.Parameters.AddWithValue("@tenhang", tenhang);
                cmd.Parameters.AddWithValue("@loaihang", loaihang);
                // Thực hiện câu lệnh INSERT
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateData(string mahang, string tenhang, string loaihang)
        {
            SqlConnection conn = DBhelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();

                // Tạo câu lệnh SQL để cập nhật dữ liệu
                string sql = "UPDATE hanghoa SET tenhang = @tenhang, loaihang = @loaihang WHERE mahang = @mahang";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Sét đặt tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@mahang", mahang);
                cmd.Parameters.AddWithValue("@tenhang", tenhang);
                cmd.Parameters.AddWithValue("@loaihang", loaihang);

                // Thực hiện câu lệnh UPDATE
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close(); // Đảm bảo đóng kết nối sau khi sử dụng xong
            }
        }
        public List<Hanghoa> DeleteData(string mahang)
        {
            SqlConnection conn = DBhelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                hanghoaList.Clear();
                // Tạo câu lệnh SQL để truy vấn dữ liệu
                SqlCommand cmd = new SqlCommand("DELETE FROM hanghoa WHERE mahang = @mahang", conn);
                cmd.Parameters.AddWithValue("@mahang", mahang);
                // Thực hiện truy vấn
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String tenhang = reader["tenhang"].ToString();
                    String loaihang = reader["loaihang"].ToString();
                    Hanghoa hanghoa = new Hanghoa(mahang, tenhang, loaihang);
                    hanghoaList.Add(hanghoa);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return hanghoaList;
        }
    }
}
