
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
            this.dataGridView1.Location = new System.Drawing.Point(-2, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(100, 249);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 1;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(209, 249);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(324, 249);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã giảm giá:";
            // 
            // txt_ma
            // 
            this.txt_ma.Location = new System.Drawing.Point(525, 6);
            this.txt_ma.Name = "txt_ma";
            this.txt_ma.ReadOnly = true;
            this.txt_ma.Size = new System.Drawing.Size(100, 20);
            this.txt_ma.TabIndex = 5;
            // 
            // txt_tenma
            // 
            this.txt_tenma.Location = new System.Drawing.Point(525, 49);
            this.txt_tenma.Name = "txt_tenma";
            this.txt_tenma.Size = new System.Drawing.Size(100, 20);
            this.txt_tenma.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên mã :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày bắt đầu:";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(525, 246);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(100, 20);
            this.txt_discount.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Discount";
            // 
            // txt_chitiet
            // 
            this.txt_chitiet.Location = new System.Drawing.Point(525, 176);
            this.txt_chitiet.Multiline = true;
            this.txt_chitiet.Name = "txt_chitiet";
            this.txt_chitiet.Size = new System.Drawing.Size(100, 49);
            this.txt_chitiet.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(439, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Chi tiết:";
            // 
            // dt_ngaybatdau
            // 
            this.dt_ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaybatdau.Location = new System.Drawing.Point(523, 94);
            this.dt_ngaybatdau.Name = "dt_ngaybatdau";
            this.dt_ngaybatdau.Size = new System.Drawing.Size(102, 20);
            this.dt_ngaybatdau.TabIndex = 16;
            // 
            // dt_ngaykt
            // 
            this.dt_ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaykt.Location = new System.Drawing.Point(523, 136);
            this.dt_ngaykt.Name = "dt_ngaykt";
            this.dt_ngaykt.Size = new System.Drawing.Size(102, 20);
            this.dt_ngaykt.TabIndex = 17;
            // 
            // frmVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 350);
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
            this.Name = "frmVoucher";
            this.Text = "frmVoucher";
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