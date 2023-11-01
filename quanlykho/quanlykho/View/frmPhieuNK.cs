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
    public partial class frmPhieuNK : Form
    {
        KhoController controller;
        List<Kho> dsKho;
        Kho currentKho;
        public frmPhieuNK()
        {
            InitializeComponent();
            controller = new KhoController();
        }

       
        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            dsKho = controller.Load();
            foreach (Kho kho in dsKho)
            {
                // Tạo một chuỗi đại diện cho mục và thêm nó vào ComboBox.
                string itemText = $"{kho.getMakho()}";
                comboBox1.Items.Add(itemText);
            }
        }
    }
}
