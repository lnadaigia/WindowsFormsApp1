namespace WindowsFormsApp1
{
    partial class frmdatdonhang
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
            this.dtg_doan = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dtg_chitiet = new System.Windows.Forms.DataGridView();
            this.btn_xemdonhang = new System.Windows.Forms.Button();
            this.btn_dathang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chitiet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_doan
            // 
            this.dtg_doan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_doan.Location = new System.Drawing.Point(-3, 0);
            this.dtg_doan.Name = "dtg_doan";
            this.dtg_doan.RowTemplate.Height = 20;
            this.dtg_doan.Size = new System.Drawing.Size(465, 120);
            this.dtg_doan.TabIndex = 0;
            this.dtg_doan.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(467, 12);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dtg_chitiet
            // 
            this.dtg_chitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_chitiet.Location = new System.Drawing.Point(14, 26);
            this.dtg_chitiet.Name = "dtg_chitiet";
            this.dtg_chitiet.Size = new System.Drawing.Size(345, 150);
            this.dtg_chitiet.TabIndex = 2;
            // 
            // btn_xemdonhang
            // 
            this.btn_xemdonhang.Location = new System.Drawing.Point(348, 179);
            this.btn_xemdonhang.Name = "btn_xemdonhang";
            this.btn_xemdonhang.Size = new System.Drawing.Size(114, 23);
            this.btn_xemdonhang.TabIndex = 4;
            this.btn_xemdonhang.Text = "Xem đơn hàng";
            this.btn_xemdonhang.UseVisualStyleBackColor = true;
            this.btn_xemdonhang.Click += new System.EventHandler(this.btn_xemdonhang_Click);
            // 
            // btn_dathang
            // 
            this.btn_dathang.Location = new System.Drawing.Point(160, 255);
            this.btn_dathang.Name = "btn_dathang";
            this.btn_dathang.Size = new System.Drawing.Size(96, 23);
            this.btn_dathang.TabIndex = 5;
            this.btn_dathang.Text = "Đặt hàng";
            this.btn_dathang.UseVisualStyleBackColor = true;
            this.btn_dathang.Click += new System.EventHandler(this.btn_dathang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_thanhtoan);
            this.panel1.Controls.Add(this.txt_tongtien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtg_chitiet);
            this.panel1.Controls.Add(this.btn_dathang);
            this.panel1.Location = new System.Drawing.Point(65, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 308);
            this.panel1.TabIndex = 6;
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(298, 255);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(96, 23);
            this.btn_thanhtoan.TabIndex = 8;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(248, 181);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(100, 20);
            this.txt_tongtien.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng tiền: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(205, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số lượng khách";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_xemdonhang);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dtg_doan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chitiet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_doan;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dtg_chitiet;
        private System.Windows.Forms.Button btn_xemdonhang;
        private System.Windows.Forms.Button btn_dathang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

