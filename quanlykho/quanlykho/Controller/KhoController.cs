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
    internal class KhoController
    {
        List<Kho> khoList;
        public KhoController()
        {
            khoList = new List<Kho>();
        }

        public List<Kho> Load()
        {
            SqlConnection conn = DBhelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                khoList.Clear();
                 // Tạo câu lệnh SQL để truy vấn dữ liệu
                 SqlCommand cmd = new SqlCommand("SELECT * FROM danhmuc",conn);

                // Thực hiện truy vấn
                SqlDataReader reader = cmd.ExecuteReader();   
                    while (reader.Read())
                    {
                        String makho = reader["makho"].ToString();
                        String tenkho = reader["tenkho"].ToString();
                        String diachi = reader["diachi"].ToString();
                    Kho kho = new Kho(makho,tenkho,diachi);
                        khoList.Add(kho);
                    }
                    conn.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return khoList;
        }
        public void InsertData(string makho, string tenkho, string diachi)
        {
            SqlConnection conn = DBhelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                // Tạo câu lệnh SQL để chèn dữ liệu
                string sql = "INSERT INTO danhmuc (makho, tenkho, diachi) VALUES (@makho, @tenkho, @diachi)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Sét đặt tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@makho", makho);
                cmd.Parameters.AddWithValue("@tenkho", tenkho);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                // Thực hiện câu lệnh INSERT
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateData(string makho, string tenkho, string diachi)
        {
            SqlConnection conn = DBhelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();

                // Tạo câu lệnh SQL để cập nhật dữ liệu
                string sql = "UPDATE danhmuc SET tenkho = @tenkho, diachi = @diachi WHERE makho = @makho";
                SqlCommand cmd = new SqlCommand(sql, conn);

                // Sét đặt tham số cho câu lệnh SQL
                cmd.Parameters.AddWithValue("@makho", makho);
                cmd.Parameters.AddWithValue("@tenkho", tenkho);
                cmd.Parameters.AddWithValue("@diachi", diachi);

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
        public List<Kho> FindData(string makho)
        {
            SqlConnection conn = DBhelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                khoList.Clear();
                // Tạo câu lệnh SQL để truy vấn dữ liệu
                SqlCommand cmd = new SqlCommand("SELECT * FROM danhmuc WHERE makho = @makho", conn);
                cmd.Parameters.AddWithValue("@makho", makho);
                // Thực hiện truy vấn
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String tenkho = reader["tenkho"].ToString();
                    String diachi = reader["diachi"].ToString();
                    Kho kho = new Kho(makho, tenkho, diachi);
                    khoList.Add(kho);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return khoList;
        }
        public List<Kho> DeleteData(string makho)
        {
            SqlConnection conn = DBhelper.getConnection();
            try
            {
                // Mở kết nối
                conn.Open();
                khoList.Clear();
                // Tạo câu lệnh SQL để truy vấn dữ liệu
                SqlCommand cmd = new SqlCommand("DELETE FROM danhmuc WHERE makho = @makho", conn);
                cmd.Parameters.AddWithValue("@makho", makho);
                // Thực hiện truy vấn
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String tenkho = reader["tenkho"].ToString();
                    String diachi = reader["diachi"].ToString();
                    Kho kho = new Kho(makho, tenkho, diachi);
                    khoList.Add(kho);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return khoList;
        }
        // Thêm các phương thức khác cho thêm, sửa, xóa, và các thao tác khác với dữ liệu

    }
}
