using quanlykho.View;

namespace quanlykho
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.frmKho frmKho = new View.frmKho();
            // T?o m?t ??i t??ng Form m?i
            frmKho.button1_Click(sender, e);
            // Hi?n th? Form m?i
            frmKho.ShowDialog();
        }



        private void hanghoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.frmHanghoa frmHanghoa = new View.frmHanghoa();
            frmHanghoa.buttonloadhh_Click(sender, e);
            // Hi?n th? Form m?i
            frmHanghoa.ShowDialog();
        }

        private void phieunhapkhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.frmPhieuNK frmPhieuNK = new View.frmPhieuNK();
            frmPhieuNK.ShowDialog();
        }
    }
}