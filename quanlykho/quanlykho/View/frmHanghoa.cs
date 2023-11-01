using quanlykho.Controller;
using quanlykho.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykho.View
{
    public partial class frmHanghoa : Form
    {
        HanghoaController controller;
        List<Hanghoa> dsHang;
        Hanghoa currentHang;
        public frmHanghoa()
        {
            InitializeComponent();
            controller = new HanghoaController();
        }

        public void buttonloadhh_Click(object sender, EventArgs e)
        {
            dataGridViewhh.Rows.Clear();
            dsHang = controller.Load();
            foreach (Hanghoa hanghoa in dsHang)
            {
                string[] row = { hanghoa.getMahang(), hanghoa.getTenhang(), hanghoa.getLoaihang() };
                dataGridViewhh.Rows.Add(row);
            }
        }

        private void dataGridViewhh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonaddhh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string mahang = textBox1.Text; // Lấy giá trị từ TextBox
                string tenhang = textBox2.Text; // Lấy giá trị từ TextBox
                string loaihang = textBox3.Text; // Lấy giá trị từ TextBox
                controller.InsertData(mahang, tenhang, loaihang);
                buttonloadhh_Click(sender, e);
            }

            else
            {
                MessageBox.Show("Vui lòng nhập mã kho!");
            }
        }

        private void buttonupdatehh_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string mahang = textBox1.Text; // Lấy giá trị từ TextBox
                string tenhang = textBox2.Text; // Lấy giá trị từ TextBox
                string loaihang = textBox3.Text; // Lấy giá trị từ TextBox
                controller.UpdateData(mahang, tenhang, loaihang);
                buttonloadhh_Click(sender, e);
            }

            else
            {
                MessageBox.Show("Vui lòng nhập mã kho!");
            }
        }

        private void buttondeletehh_Click(object sender, EventArgs e)
        {
            string mahang = textBox1.Text;
            // Hiển thị dữ liệu hoặc thực hiện hành động ở đây.
            dsHang = controller.DeleteData(mahang);
            
            
            
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                dataGridViewhh.Rows.Clear();
                foreach (Hanghoa hanghoa in dsHang)
                {
                    string[] row = { hanghoa.getMahang(), hanghoa.getTenhang(), hanghoa.getLoaihang() };
                    dataGridViewhh.Rows.Add(row);
                   
                }
                buttonloadhh_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã kho!");
            }
        }
    }
}
