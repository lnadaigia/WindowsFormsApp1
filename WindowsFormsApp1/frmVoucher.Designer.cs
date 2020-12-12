
namespace WindowsFormsApp1
{
    partial class frmVoucher
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ma = new System.Windows.Forms.TextBox();
            this.txt_tenma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_chitiet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dt_ngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.dt_ngaykt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, -2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(565, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(133, 306);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(279, 306);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 28);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(432, 306);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã giảm giá:";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(700, 7);
            this.txt_ma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.ReadOnly = true;
            this.txt_ma.Size = new System.Drawing.Size(132, 22);
            this.txt_ma.TabIndex = 5;
            // 
            // txt_tenma
            // 
            this.txt_tenma.Location = new System.Drawing.Point(700, 60);
            this.txt_tenma.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenma.Name = "txt_tenma";
            this.txt_tenma.Size = new System.Drawing.Size(132, 22);
            this.txt_tenma.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên mã :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(700, 303);
            this.txt_discount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(132, 22);
            this.txt_discount.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 306);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Discount";
            // 
            // txt_chitiet
            // 
            this.txt_chitiet.Location = new System.Drawing.Point(700, 217);
            this.txt_chitiet.Margin = new System.Windows.Forms.Padding(4);
            this.txt_chitiet.Multiline = true;
            this.txt_chitiet.Name = "txt_chitiet";
            this.txt_chitiet.Size = new System.Drawing.Size(132, 59);
            this.txt_chitiet.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(585, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Chi tiết:";
            // 
            // dt_ngaybatdau
            // 
            this.dt_ngaybatdau.CustomFormat = "";
            this.dt_ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaybatdau.Location = new System.Drawing.Point(697, 116);
            this.dt_ngaybatdau.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaybatdau.Name = "dt_ngaybatdau";
            this.dt_ngaybatdau.Size = new System.Drawing.Size(135, 22);
            this.dt_ngaybatdau.TabIndex = 16;
            // 
            // dt_ngaykt
            // 
            this.dt_ngaykt.CustomFormat = "";
            this.dt_ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaykt.Location = new System.Drawing.Point(697, 167);
            this.dt_ngaykt.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaykt.Name = "dt_ngaykt";
            this.dt_ngaykt.Size = new System.Drawing.Size(135, 22);
            this.dt_ngaykt.TabIndex = 17;
            // 
            // frmVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 387);
            this.Controls.Add(this.dt_ngaykt);
            this.Controls.Add(this.dt_ngaybatdau);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_chitiet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tenma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVoucher";
            this.Text = "frmVoucher";
            this.Load += new System.EventHandler(this.frmVoucher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ma;
        private System.Windows.Forms.TextBox txt_tenma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_chitiet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dt_ngaybatdau;
        private System.Windows.Forms.DateTimePicker dt_ngaykt;
    }
}