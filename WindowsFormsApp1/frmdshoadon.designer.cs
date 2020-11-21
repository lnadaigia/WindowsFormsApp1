namespace WindowsFormsApp1
{
    partial class frmdshoadon
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
            this.dtg_hoadon = new System.Windows.Forms.DataGridView();
            this.dtg_chitiet_hoa_don = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_chuathanhtoan = new System.Windows.Forms.RadioButton();
            this.rdb_dathanhtoan = new System.Windows.Forms.RadioButton();
            this.rdb_chontatca = new System.Windows.Forms.RadioButton();
            this.btn_check = new System.Windows.Forms.Button();
            this.dt_ngay = new System.Windows.Forms.DateTimePicker();
            this.rdb_chonngay = new System.Windows.Forms.RadioButton();
            this.rdb_chonkhoang = new System.Windows.Forms.RadioButton();
            this.dt_dau = new System.Windows.Forms.DateTimePicker();
            this.dt_sau = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdb_khong = new System.Windows.Forms.RadioButton();
            this.rdb_co = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdb_no = new System.Windows.Forms.RadioButton();
            this.rdb_yes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chitiet_hoa_don)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_hoadon
            // 
            this.dtg_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hoadon.Location = new System.Drawing.Point(0, 142);
            this.dtg_hoadon.Name = "dtg_hoadon";
            this.dtg_hoadon.Size = new System.Drawing.Size(769, 150);
            this.dtg_hoadon.TabIndex = 0;
            this.dtg_hoadon.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dtg_chitiet_hoa_don
            // 
            this.dtg_chitiet_hoa_don.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_chitiet_hoa_don.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_chitiet_hoa_don.Location = new System.Drawing.Point(0, 314);
            this.dtg_chitiet_hoa_don.Name = "dtg_chitiet_hoa_don";
            this.dtg_chitiet_hoa_don.Size = new System.Drawing.Size(554, 150);
            this.dtg_chitiet_hoa_don.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_chuathanhtoan);
            this.panel1.Controls.Add(this.rdb_dathanhtoan);
            this.panel1.Controls.Add(this.rdb_chontatca);
            this.panel1.Location = new System.Drawing.Point(12, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 3;
            // 
            // rdb_chuathanhtoan
            // 
            this.rdb_chuathanhtoan.AutoSize = true;
            this.rdb_chuathanhtoan.Location = new System.Drawing.Point(17, 75);
            this.rdb_chuathanhtoan.Name = "rdb_chuathanhtoan";
            this.rdb_chuathanhtoan.Size = new System.Drawing.Size(103, 17);
            this.rdb_chuathanhtoan.TabIndex = 3;
            this.rdb_chuathanhtoan.Text = "chưa thanh toán";
            this.rdb_chuathanhtoan.UseVisualStyleBackColor = true;
            // 
            // rdb_dathanhtoan
            // 
            this.rdb_dathanhtoan.AutoSize = true;
            this.rdb_dathanhtoan.Location = new System.Drawing.Point(17, 40);
            this.rdb_dathanhtoan.Name = "rdb_dathanhtoan";
            this.rdb_dathanhtoan.Size = new System.Drawing.Size(92, 17);
            this.rdb_dathanhtoan.TabIndex = 1;
            this.rdb_dathanhtoan.Text = "đã thanh toán";
            this.rdb_dathanhtoan.UseVisualStyleBackColor = true;
            // 
            // rdb_chontatca
            // 
            this.rdb_chontatca.AutoSize = true;
            this.rdb_chontatca.Checked = true;
            this.rdb_chontatca.Location = new System.Drawing.Point(17, 8);
            this.rdb_chontatca.Name = "rdb_chontatca";
            this.rdb_chontatca.Size = new System.Drawing.Size(79, 17);
            this.rdb_chontatca.TabIndex = 0;
            this.rdb_chontatca.TabStop = true;
            this.rdb_chontatca.Text = "chọn tất cả";
            this.rdb_chontatca.UseVisualStyleBackColor = true;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(706, 79);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 52);
            this.btn_check.TabIndex = 5;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // dt_ngay
            // 
            this.dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngay.Location = new System.Drawing.Point(119, 49);
            this.dt_ngay.Name = "dt_ngay";
            this.dt_ngay.Size = new System.Drawing.Size(108, 20);
            this.dt_ngay.TabIndex = 6;
            // 
            // rdb_chonngay
            // 
            this.rdb_chonngay.AutoSize = true;
            this.rdb_chonngay.Checked = true;
            this.rdb_chonngay.Location = new System.Drawing.Point(9, 49);
            this.rdb_chonngay.Name = "rdb_chonngay";
            this.rdb_chonngay.Size = new System.Drawing.Size(75, 17);
            this.rdb_chonngay.TabIndex = 4;
            this.rdb_chonngay.TabStop = true;
            this.rdb_chonngay.Text = "chọn ngày";
            this.rdb_chonngay.UseVisualStyleBackColor = true;
            // 
            // rdb_chonkhoang
            // 
            this.rdb_chonkhoang.AutoSize = true;
            this.rdb_chonkhoang.Location = new System.Drawing.Point(9, 94);
            this.rdb_chonkhoang.Name = "rdb_chonkhoang";
            this.rdb_chonkhoang.Size = new System.Drawing.Size(88, 17);
            this.rdb_chonkhoang.TabIndex = 7;
            this.rdb_chonkhoang.Text = "chọn khoảng";
            this.rdb_chonkhoang.UseVisualStyleBackColor = true;
            // 
            // dt_dau
            // 
            this.dt_dau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dau.Location = new System.Drawing.Point(119, 91);
            this.dt_dau.Name = "dt_dau";
            this.dt_dau.Size = new System.Drawing.Size(108, 20);
            this.dt_dau.TabIndex = 8;
            // 
            // dt_sau
            // 
            this.dt_sau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_sau.Location = new System.Drawing.Point(310, 91);
            this.dt_sau.Name = "dt_sau";
            this.dt_sau.Size = new System.Drawing.Size(126, 20);
            this.dt_sau.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dt_ngay);
            this.panel2.Controls.Add(this.dt_sau);
            this.panel2.Controls.Add(this.rdb_chonkhoang);
            this.panel2.Controls.Add(this.rdb_chonngay);
            this.panel2.Controls.Add(this.dt_dau);
            this.panel2.Location = new System.Drawing.Point(227, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 131);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.rdb_khong);
            this.panel4.Controls.Add(this.rdb_co);
            this.panel4.Location = new System.Drawing.Point(310, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 58);
            this.panel4.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "chọn bàn";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(54, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // rdb_khong
            // 
            this.rdb_khong.AutoSize = true;
            this.rdb_khong.Checked = true;
            this.rdb_khong.Location = new System.Drawing.Point(50, 9);
            this.rdb_khong.Name = "rdb_khong";
            this.rdb_khong.Size = new System.Drawing.Size(37, 17);
            this.rdb_khong.TabIndex = 12;
            this.rdb_khong.TabStop = true;
            this.rdb_khong.Text = "no";
            this.rdb_khong.UseVisualStyleBackColor = true;
            // 
            // rdb_co
            // 
            this.rdb_co.AutoSize = true;
            this.rdb_co.Location = new System.Drawing.Point(3, 9);
            this.rdb_co.Name = "rdb_co";
            this.rdb_co.Size = new System.Drawing.Size(41, 17);
            this.rdb_co.TabIndex = 11;
            this.rdb_co.Text = "yes";
            this.rdb_co.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdb_no);
            this.panel3.Controls.Add(this.rdb_yes);
            this.panel3.Location = new System.Drawing.Point(9, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 35);
            this.panel3.TabIndex = 12;
            // 
            // rdb_no
            // 
            this.rdb_no.AutoSize = true;
            this.rdb_no.Checked = true;
            this.rdb_no.Location = new System.Drawing.Point(50, 9);
            this.rdb_no.Name = "rdb_no";
            this.rdb_no.Size = new System.Drawing.Size(37, 17);
            this.rdb_no.TabIndex = 12;
            this.rdb_no.TabStop = true;
            this.rdb_no.Text = "no";
            this.rdb_no.UseVisualStyleBackColor = true;
            // 
            // rdb_yes
            // 
            this.rdb_yes.AutoSize = true;
            this.rdb_yes.Location = new System.Drawing.Point(3, 9);
            this.rdb_yes.Name = "rdb_yes";
            this.rdb_yes.Size = new System.Drawing.Size(41, 17);
            this.rdb_yes.TabIndex = 11;
            this.rdb_yes.Text = "yes";
            this.rdb_yes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "đến";
            // 
            // frmdanhsachdonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.dtg_chitiet_hoa_don);
            this.Controls.Add(this.dtg_hoadon);
            this.Name = "frmdanhsachdonhang";
            this.Text = "frmdanhsachdonhang";
            this.Load += new System.EventHandler(this.frmdanhsachdonhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_chitiet_hoa_don)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_hoadon;
        private System.Windows.Forms.DataGridView dtg_chitiet_hoa_don;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_chuathanhtoan;
        private System.Windows.Forms.RadioButton rdb_dathanhtoan;
        private System.Windows.Forms.RadioButton rdb_chontatca;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.DateTimePicker dt_ngay;
        private System.Windows.Forms.RadioButton rdb_chonngay;
        private System.Windows.Forms.RadioButton rdb_chonkhoang;
        private System.Windows.Forms.DateTimePicker dt_dau;
        private System.Windows.Forms.DateTimePicker dt_sau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdb_no;
        private System.Windows.Forms.RadioButton rdb_yes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdb_khong;
        private System.Windows.Forms.RadioButton rdb_co;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}