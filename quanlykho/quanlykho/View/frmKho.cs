using quanlykho.Controller;
using quanlykho.Model;
using quanlykho.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace quanlykho.View
{

    public partial class frmKho : Form
    {
        KhoController controller;
        List<Kho> dsKho;
        Kho currentKho;
        public frmKho()
        {
            InitializeComponent();
            controller = new KhoController();
        }

        public void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            dsKho = controller.Load();
            foreach (Kho kho in dsKho)
            {
                string[] row = { kho.getMakho(), kho.getTenkho(), kho.getDiachi() };
                dataGridView1.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string makho = textBox1.Text; // Lấy giá trị từ TextBox
                string tenkho = textBox2.Text; // Lấy giá trị từ TextBox
                string diachi = textBox3.Text; // Lấy giá trị từ TextBox
                controller.InsertData(makho, tenkho, diachi);
                button1_Click(sender, e);
            }

            else
            {
                MessageBox.Show("Vui lòng nhập mã kho!");
            }
            // Sau khi thêm dữ liệu, bạn có thể thực hiện các hành động khác như hiển thị thông báo hoặc làm mới giao diện.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string makho = textBox1.Text; // Lấy giá trị từ TextBox
                string tenkho = textBox2.Text; // Lấy giá trị từ TextBox
                string diachi = textBox3.Text; // Lấy giá trị từ TextBox
                controller.UpdateData(makho, tenkho, diachi);
                button1_Click(sender, e);
            }

            else
            {
                MessageBox.Show("Vui lòng nhập mã kho!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Lấy mã kho từ TextBox "makho"
            string makho = textBox1.Text;
            // Hiển thị dữ liệu hoặc thực hiện hành động ở đây.
            dsKho = controller.FindData(makho);
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                dataGridView1.Rows.Clear();
                foreach (Kho kho in dsKho)
                {
                    string[] row = { kho.getMakho(), kho.getTenkho(), kho.getDiachi() };
                    dataGridView1.Rows.Add(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã kho!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Lấy mã kho từ TextBox "makho"
            string makho = textBox1.Text;
            // Hiển thị dữ liệu hoặc thực hiện hành động ở đây.
            dsKho = controller.DeleteData(makho);
            dataGridView1.Rows.Clear();
            button1_Click(sender, e);
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {

                foreach (Kho kho in dsKho)
                {
                    string[] row = { kho.getMakho(), kho.getTenkho(), kho.getDiachi() };
                    dataGridView1.Rows.Add(row);

                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã kho!");
            }
        }
    }
}
