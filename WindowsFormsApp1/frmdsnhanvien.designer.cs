namespace WindowsFormsApp1
{
    partial class frmdsnhanvien
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_sua = new System.Windows.Forms.Button();
			this.btn_xoa = new System.Windows.Forms.Button();
			this.btn_them = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.dt_namsinh = new System.Windows.Forms.DateTimePicker();
			this.txt_cmnd = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_sdt = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_idnv = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_hovaten = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btn_reset = new System.Windows.Forms.Button();
			this.btn_refresh = new System.Windows.Forms.Button();
			this.btn_timid = new System.Windows.Forms.Button();
			this.txt_timkiem = new System.Windows.Forms.TextBox();
			this.btn_dilam = new System.Windows.Forms.Button();
			this.txt_searh = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_quenmk = new System.Windows.Forms.Button();
			this.txt_user = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Location = new System.Drawing.Point(3, 291);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dataGridView1.Size = new System.Drawing.Size(1194, 380);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// btn_sua
			// 
			this.btn_sua.Location = new System.Drawing.Point(898, 246);
			this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(112, 35);
			this.btn_sua.TabIndex = 1;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = true;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// btn_xoa
			// 
			this.btn_xoa.Location = new System.Drawing.Point(1070, 246);
			this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_xoa.Name = "btn_xoa";
			this.btn_xoa.Size = new System.Drawing.Size(112, 35);
			this.btn_xoa.TabIndex = 2;
			this.btn_xoa.Text = "Xóa";
			this.btn_xoa.UseVisualStyleBackColor = true;
			this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
			// 
			// btn_them
			// 
			this.btn_them.Location = new System.Drawing.Point(740, 246);
			this.btn_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_them.Name = "btn_them";
			this.btn_them.Size = new System.Drawing.Size(112, 35);
			this.btn_them.TabIndex = 3;
			this.btn_them.Text = "Thêm";
			this.btn_them.UseVisualStyleBackColor = true;
			this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(36, 74);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(118, 25);
			this.label7.TabIndex = 24;
			this.label7.Text = "Id nhân viên";
			// 
			// dt_namsinh
			// 
			this.dt_namsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dt_namsinh.Location = new System.Drawing.Point(184, 192);
			this.dt_namsinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dt_namsinh.Name = "dt_namsinh";
			this.dt_namsinh.Size = new System.Drawing.Size(148, 30);
			this.dt_namsinh.TabIndex = 23;
			// 
			// txt_cmnd
			// 
			this.txt_cmnd.Location = new System.Drawing.Point(676, 135);
			this.txt_cmnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_cmnd.Name = "txt_cmnd";
			this.txt_cmnd.Size = new System.Drawing.Size(148, 30);
			this.txt_cmnd.TabIndex = 22;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(557, 141);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 25);
			this.label6.TabIndex = 21;
			this.label6.Text = "Cmnd";
			// 
			// txt_sdt
			// 
			this.txt_sdt.Location = new System.Drawing.Point(676, 69);
			this.txt_sdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_sdt.Name = "txt_sdt";
			this.txt_sdt.Size = new System.Drawing.Size(148, 30);
			this.txt_sdt.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(560, 72);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 25);
			this.label5.TabIndex = 19;
			this.label5.Text = "Sdt";
			// 
			// txt_idnv
			// 
			this.txt_idnv.Location = new System.Drawing.Point(184, 77);
			this.txt_idnv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_idnv.Name = "txt_idnv";
			this.txt_idnv.ReadOnly = true;
			this.txt_idnv.Size = new System.Drawing.Size(96, 30);
			this.txt_idnv.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(36, 186);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 25);
			this.label4.TabIndex = 17;
			this.label4.Text = "Năm sinh";
			// 
			// txt_hovaten
			// 
			this.txt_hovaten.Location = new System.Drawing.Point(184, 125);
			this.txt_hovaten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_hovaten.Name = "txt_hovaten";
			this.txt_hovaten.Size = new System.Drawing.Size(284, 30);
			this.txt_hovaten.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(33, 125);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 25);
			this.label3.TabIndex = 15;
			this.label3.Text = "Họ và tên";
			// 
			// btn_reset
			// 
			this.btn_reset.Location = new System.Drawing.Point(561, 246);
			this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(112, 35);
			this.btn_reset.TabIndex = 25;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// btn_refresh
			// 
			this.btn_refresh.Location = new System.Drawing.Point(39, 246);
			this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_refresh.Name = "btn_refresh";
			this.btn_refresh.Size = new System.Drawing.Size(112, 35);
			this.btn_refresh.TabIndex = 26;
			this.btn_refresh.Text = "Refresh";
			this.btn_refresh.UseVisualStyleBackColor = true;
			this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
			// 
			// btn_timid
			// 
			this.btn_timid.Location = new System.Drawing.Point(39, 15);
			this.btn_timid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_timid.Name = "btn_timid";
			this.btn_timid.Size = new System.Drawing.Size(112, 35);
			this.btn_timid.TabIndex = 27;
			this.btn_timid.Text = "Tìm theo id";
			this.btn_timid.UseVisualStyleBackColor = true;
			this.btn_timid.Click += new System.EventHandler(this.btn_timid_Click);
			// 
			// txt_timkiem
			// 
			this.txt_timkiem.Location = new System.Drawing.Point(171, 18);
			this.txt_timkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_timkiem.Name = "txt_timkiem";
			this.txt_timkiem.Size = new System.Drawing.Size(97, 30);
			this.txt_timkiem.TabIndex = 28;
			// 
			// btn_dilam
			// 
			this.btn_dilam.Location = new System.Drawing.Point(1052, 40);
			this.btn_dilam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_dilam.Name = "btn_dilam";
			this.btn_dilam.Size = new System.Drawing.Size(146, 77);
			this.btn_dilam.TabIndex = 29;
			this.btn_dilam.Text = "Set đi làm";
			this.btn_dilam.UseVisualStyleBackColor = true;
			this.btn_dilam.Click += new System.EventHandler(this.btn_dilam_Click);
			// 
			// txt_searh
			// 
			this.txt_searh.Location = new System.Drawing.Point(676, 20);
			this.txt_searh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_searh.Name = "txt_searh";
			this.txt_searh.Size = new System.Drawing.Size(284, 30);
			this.txt_searh.TabIndex = 30;
			this.txt_searh.TextChanged += new System.EventHandler(this.txt_searh_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(560, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 25);
			this.label1.TabIndex = 31;
			this.label1.Text = "Tìm kiếm";
			// 
			// btn_quenmk
			// 
			this.btn_quenmk.Location = new System.Drawing.Point(837, 188);
			this.btn_quenmk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btn_quenmk.Name = "btn_quenmk";
			this.btn_quenmk.Size = new System.Drawing.Size(252, 35);
			this.btn_quenmk.TabIndex = 32;
			this.btn_quenmk.Text = "Mật khẩu  theo user name";
			this.btn_quenmk.UseVisualStyleBackColor = true;
			this.btn_quenmk.Click += new System.EventHandler(this.btn_quenmk_Click);
			// 
			// txt_user
			// 
			this.txt_user.Location = new System.Drawing.Point(678, 186);
			this.txt_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_user.Name = "txt_user";
			this.txt_user.Size = new System.Drawing.Size(148, 30);
			this.txt_user.TabIndex = 33;
			// 
			// frmdsnhanvien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LimeGreen;
			this.ClientSize = new System.Drawing.Size(1200, 665);
			this.Controls.Add(this.txt_user);
			this.Controls.Add(this.btn_quenmk);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_searh);
			this.Controls.Add(this.btn_dilam);
			this.Controls.Add(this.txt_timkiem);
			this.Controls.Add(this.btn_timid);
			this.Controls.Add(this.btn_refresh);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dt_namsinh);
			this.Controls.Add(this.txt_cmnd);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_sdt);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_idnv);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_hovaten);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_them);
			this.Controls.Add(this.btn_xoa);
			this.Controls.Add(this.btn_sua);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmdsnhanvien";
			this.Text = "frmdsnhanvien";
			this.Load += new System.EventHandler(this.frmdsnhanvien_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_namsinh;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idnv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hovaten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_timid;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Button btn_dilam;
        private System.Windows.Forms.TextBox txt_searh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quenmk;
        private System.Windows.Forms.TextBox txt_user;
    }
}