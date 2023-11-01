namespace quanlykho
{
    partial class MDI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            khoToolStripMenuItem = new ToolStripMenuItem();
            hanghoaToolStripMenuItem = new ToolStripMenuItem();
            nhapxuatToolStripMenuItem = new ToolStripMenuItem();
            phieunhapkhoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, danhMụcToolStripMenuItem, nhapxuatToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khoToolStripMenuItem, hanghoaToolStripMenuItem });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(109, 29);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // khoToolStripMenuItem
            // 
            khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            khoToolStripMenuItem.Size = new Size(270, 34);
            khoToolStripMenuItem.Text = "Kho";
            khoToolStripMenuItem.Click += khoToolStripMenuItem_Click;
            // 
            // hanghoaToolStripMenuItem
            // 
            hanghoaToolStripMenuItem.Name = "hanghoaToolStripMenuItem";
            hanghoaToolStripMenuItem.Size = new Size(270, 34);
            hanghoaToolStripMenuItem.Text = "Hàng hóa";
            hanghoaToolStripMenuItem.Click += hanghoaToolStripMenuItem_Click;
            // 
            // nhapxuatToolStripMenuItem
            // 
            nhapxuatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phieunhapkhoToolStripMenuItem });
            nhapxuatToolStripMenuItem.Name = "nhapxuatToolStripMenuItem";
            nhapxuatToolStripMenuItem.Size = new Size(114, 29);
            nhapxuatToolStripMenuItem.Text = "Nhập/Xuất";
            // 
            // phieunhapkhoToolStripMenuItem
            // 
            phieunhapkhoToolStripMenuItem.Name = "phieunhapkhoToolStripMenuItem";
            phieunhapkhoToolStripMenuItem.Size = new Size(270, 34);
            phieunhapkhoToolStripMenuItem.Text = "Phiếu nhập kho";
            phieunhapkhoToolStripMenuItem.Click += phieunhapkhoToolStripMenuItem_Click;
            // 
            // MDI
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MDI";
            Text = "Trang chủ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem khoToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem hanghoaToolStripMenuItem;
        private ToolStripMenuItem nhapxuatToolStripMenuItem;
        private ToolStripMenuItem phieunhapkhoToolStripMenuItem;
    }
}