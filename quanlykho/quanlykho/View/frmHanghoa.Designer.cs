namespace quanlykho.View
{
    partial class frmHanghoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewhh = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            buttonloadhh = new Button();
            buttonaddhh = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonupdatehh = new Button();
            buttondeletehh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewhh).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewhh
            // 
            dataGridViewhh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewhh.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewhh.Location = new Point(12, 12);
            dataGridViewhh.Name = "dataGridViewhh";
            dataGridViewhh.RowHeadersWidth = 62;
            dataGridViewhh.RowTemplate.Height = 33;
            dataGridViewhh.Size = new Size(514, 225);
            dataGridViewhh.TabIndex = 0;
            dataGridViewhh.CellContentClick += dataGridViewhh_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mã Hàng";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tên Hàng";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Loại Hàng";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // buttonloadhh
            // 
            buttonloadhh.Location = new Point(589, 12);
            buttonloadhh.Name = "buttonloadhh";
            buttonloadhh.Size = new Size(112, 34);
            buttonloadhh.TabIndex = 1;
            buttonloadhh.Text = "Load";
            buttonloadhh.UseVisualStyleBackColor = true;
            buttonloadhh.Click += buttonloadhh_Click;
            // 
            // buttonaddhh
            // 
            buttonaddhh.Location = new Point(12, 391);
            buttonaddhh.Name = "buttonaddhh";
            buttonaddhh.Size = new Size(112, 34);
            buttonaddhh.TabIndex = 2;
            buttonaddhh.Text = "Add";
            buttonaddhh.UseVisualStyleBackColor = true;
            buttonaddhh.Click += buttonaddhh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 259);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 3;
            label1.Text = "Mã hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 297);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 4;
            label2.Text = "Tên hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 335);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 5;
            label3.Text = "Loại hàng";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(110, 259);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 297);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 334);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 8;
            // 
            // buttonupdatehh
            // 
            buttonupdatehh.Location = new Point(130, 391);
            buttonupdatehh.Name = "buttonupdatehh";
            buttonupdatehh.Size = new Size(112, 34);
            buttonupdatehh.TabIndex = 9;
            buttonupdatehh.Text = "Update";
            buttonupdatehh.UseVisualStyleBackColor = true;
            buttonupdatehh.Click += buttonupdatehh_Click;
            // 
            // buttondeletehh
            // 
            buttondeletehh.Location = new Point(248, 391);
            buttondeletehh.Name = "buttondeletehh";
            buttondeletehh.Size = new Size(112, 34);
            buttondeletehh.TabIndex = 10;
            buttondeletehh.Text = "Delete";
            buttondeletehh.UseVisualStyleBackColor = true;
            buttondeletehh.Click += buttondeletehh_Click;
            // 
            // frmHanghoa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttondeletehh);
            Controls.Add(buttonupdatehh);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonaddhh);
            Controls.Add(buttonloadhh);
            Controls.Add(dataGridViewhh);
            Name = "frmHanghoa";
            Text = "Hanghoa";
            ((System.ComponentModel.ISupportInitialize)dataGridViewhh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewhh;
        private Button buttonloadhh;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button buttonaddhh;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonupdatehh;
        private Button buttondeletehh;
    }
}