namespace WindowsFormsApp1
{
    partial class frmmau
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
            this.pn_menu = new System.Windows.Forms.Panel();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_muanguyenlieu = new System.Windows.Forms.Button();
            this.btn_Voucher = new System.Windows.Forms.Button();
            this.btn_dsca = new System.Windows.Forms.Button();
            this.btn_dsnhanvien = new System.Windows.Forms.Button();
            this.btn_dsmonan = new System.Windows.Forms.Button();
            this.btn_dshoadon = new System.Windows.Forms.Button();
            this.btn_dsbanan = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_childform = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_thongtin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pn_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pn_menu.Controls.Add(this.btn_thongke);
            this.pn_menu.Controls.Add(this.btn_muanguyenlieu);
            this.pn_menu.Controls.Add(this.btn_Voucher);
            this.pn_menu.Controls.Add(this.btn_dsca);
            this.pn_menu.Controls.Add(this.btn_dsnhanvien);
            this.pn_menu.Controls.Add(this.btn_dsmonan);
            this.pn_menu.Controls.Add(this.btn_dshoadon);
            this.pn_menu.Controls.Add(this.btn_dsbanan);
            this.pn_menu.Controls.Add(this.btn_home);
            this.pn_menu.Controls.Add(this.panel1);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(233, 513);
            this.pn_menu.TabIndex = 0;
            // 
            // btn_thongke
            // 
            this.btn_thongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.Color.White;
            this.btn_thongke.Location = new System.Drawing.Point(0, 440);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(233, 43);
            this.btn_thongke.TabIndex = 8;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // btn_muanguyenlieu
            // 
            this.btn_muanguyenlieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_muanguyenlieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muanguyenlieu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_muanguyenlieu.ForeColor = System.Drawing.Color.White;
            this.btn_muanguyenlieu.Location = new System.Drawing.Point(0, 397);
            this.btn_muanguyenlieu.Name = "btn_muanguyenlieu";
            this.btn_muanguyenlieu.Size = new System.Drawing.Size(233, 43);
            this.btn_muanguyenlieu.TabIndex = 6;
            this.btn_muanguyenlieu.Text = "Mua nguyên liệu";
            this.btn_muanguyenlieu.UseVisualStyleBackColor = true;
            this.btn_muanguyenlieu.Click += new System.EventHandler(this.btn_muanguyenlieu_Click);
            // 
            // btn_Voucher
            // 
            this.btn_Voucher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Voucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voucher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voucher.ForeColor = System.Drawing.Color.White;
            this.btn_Voucher.Location = new System.Drawing.Point(0, 354);
            this.btn_Voucher.Name = "btn_Voucher";
            this.btn_Voucher.Size = new System.Drawing.Size(233, 43);
            this.btn_Voucher.TabIndex = 10;
            this.btn_Voucher.Text = "Danh dách Voucher";
            this.btn_Voucher.UseVisualStyleBackColor = true;
            this.btn_Voucher.Click += new System.EventHandler(this.btn_Voucher_Click);
            // 
            // btn_dsca
            // 
            this.btn_dsca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsca.ForeColor = System.Drawing.Color.White;
            this.btn_dsca.Location = new System.Drawing.Point(0, 311);
            this.btn_dsca.Name = "btn_dsca";
            this.btn_dsca.Size = new System.Drawing.Size(233, 43);
            this.btn_dsca.TabIndex = 9;
            this.btn_dsca.Text = "Danh sách ca";
            this.btn_dsca.UseVisualStyleBackColor = true;
            this.btn_dsca.Click += new System.EventHandler(this.btn_dsca_Click);
            // 
            // btn_dsnhanvien
            // 
            this.btn_dsnhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsnhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsnhanvien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsnhanvien.ForeColor = System.Drawing.Color.White;
            this.btn_dsnhanvien.Location = new System.Drawing.Point(0, 268);
            this.btn_dsnhanvien.Name = "btn_dsnhanvien";
            this.btn_dsnhanvien.Size = new System.Drawing.Size(233, 43);
            this.btn_dsnhanvien.TabIndex = 5;
            this.btn_dsnhanvien.Text = "Danh sách nhân viên";
            this.btn_dsnhanvien.UseVisualStyleBackColor = true;
            this.btn_dsnhanvien.Click += new System.EventHandler(this.btn_dsnhanvien_Click_1);
            // 
            // btn_dsmonan
            // 
            this.btn_dsmonan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsmonan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsmonan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsmonan.ForeColor = System.Drawing.Color.White;
            this.btn_dsmonan.Location = new System.Drawing.Point(0, 225);
            this.btn_dsmonan.Name = "btn_dsmonan";
            this.btn_dsmonan.Size = new System.Drawing.Size(233, 43);
            this.btn_dsmonan.TabIndex = 4;
            this.btn_dsmonan.Text = "Danh sách món ăn";
            this.btn_dsmonan.UseVisualStyleBackColor = true;
            this.btn_dsmonan.Click += new System.EventHandler(this.btn_dsmonan_Click);
            // 
            // btn_dshoadon
            // 
            this.btn_dshoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dshoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dshoadon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dshoadon.ForeColor = System.Drawing.Color.White;
            this.btn_dshoadon.Location = new System.Drawing.Point(0, 182);
            this.btn_dshoadon.Name = "btn_dshoadon";
            this.btn_dshoadon.Size = new System.Drawing.Size(233, 43);
            this.btn_dshoadon.TabIndex = 3;
            this.btn_dshoadon.Text = "Danh sách hóa đơn";
            this.btn_dshoadon.UseVisualStyleBackColor = true;
            this.btn_dshoadon.Click += new System.EventHandler(this.btn_dshoadon_Click);
            // 
            // btn_dsbanan
            // 
            this.btn_dsbanan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsbanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsbanan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsbanan.ForeColor = System.Drawing.Color.White;
            this.btn_dsbanan.Location = new System.Drawing.Point(0, 139);
            this.btn_dsbanan.Name = "btn_dsbanan";
            this.btn_dsbanan.Size = new System.Drawing.Size(233, 43);
            this.btn_dsbanan.TabIndex = 2;
            this.btn_dsbanan.Text = "Danh sách bàn ăn";
            this.btn_dsbanan.UseVisualStyleBackColor = true;
            this.btn_dsbanan.Click += new System.EventHandler(this.btn_dsbanan_Click);
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(0, 96);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(233, 43);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 96);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.btn_thongtin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(233, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 48);
            this.panel2.TabIndex = 1;
            // 
            // pn_childform
            // 
            this.pn_childform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_childform.Location = new System.Drawing.Point(233, 48);
            this.pn_childform.Name = "pn_childform";
            this.pn_childform.Size = new System.Drawing.Size(867, 465);
            this.pn_childform.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_thongtin
            // 
            this.btn_thongtin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_thongtin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongtin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongtin.ForeColor = System.Drawing.Color.White;
            this.btn_thongtin.Location = new System.Drawing.Point(664, 0);
            this.btn_thongtin.Name = "btn_thongtin";
            this.btn_thongtin.Size = new System.Drawing.Size(203, 48);
            this.btn_thongtin.TabIndex = 0;
            this.btn_thongtin.Text = "Thông tin cá nhân";
            this.btn_thongtin.UseVisualStyleBackColor = true;
            this.btn_thongtin.Click += new System.EventHandler(this.btn_thongtin_Click);
            // 
            // frmmau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 513);
            this.Controls.Add(this.pn_childform);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_menu);
            this.Name = "frmmau";
            this.Text = "frmmau";
            this.pn_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn_childform;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_muanguyenlieu;
        private System.Windows.Forms.Button btn_dsnhanvien;
        private System.Windows.Forms.Button btn_dsmonan;
        private System.Windows.Forms.Button btn_dshoadon;
        private System.Windows.Forms.Button btn_dsbanan;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dsca;
        private System.Windows.Forms.Button btn_Voucher;
        private System.Windows.Forms.Button btn_thongtin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}