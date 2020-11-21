namespace WindowsFormsApp1
{
    partial class frmmaunhanvien
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
            this.button1 = new System.Windows.Forms.Button();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_childform = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_dsca = new System.Windows.Forms.Button();
            this.btn_dsbanan = new System.Windows.Forms.Button();
            this.btn_dshoadon = new System.Windows.Forms.Button();
            this.btn_dsmonan = new System.Windows.Forms.Button();
            this.btn_thongtin = new System.Windows.Forms.Button();
            this.pn_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(-1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pn_menu.Controls.Add(this.btn_dsmonan);
            this.pn_menu.Controls.Add(this.btn_dshoadon);
            this.pn_menu.Controls.Add(this.btn_dsbanan);
            this.pn_menu.Controls.Add(this.btn_dsca);
            this.pn_menu.Controls.Add(this.btn_home);
            this.pn_menu.Controls.Add(this.panel1);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(256, 509);
            this.pn_menu.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.btn_thongtin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(256, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 49);
            this.panel2.TabIndex = 12;
            // 
            // pn_childform
            // 
            this.pn_childform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_childform.Location = new System.Drawing.Point(256, 49);
            this.pn_childform.Name = "pn_childform";
            this.pn_childform.Size = new System.Drawing.Size(652, 460);
            this.pn_childform.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Location = new System.Drawing.Point(0, 100);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(256, 35);
            this.btn_home.TabIndex = 1;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_dsca
            // 
            this.btn_dsca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsca.ForeColor = System.Drawing.Color.White;
            this.btn_dsca.Location = new System.Drawing.Point(0, 135);
            this.btn_dsca.Name = "btn_dsca";
            this.btn_dsca.Size = new System.Drawing.Size(256, 35);
            this.btn_dsca.TabIndex = 2;
            this.btn_dsca.Text = "Danh sách ca";
            this.btn_dsca.UseVisualStyleBackColor = true;
            this.btn_dsca.Click += new System.EventHandler(this.btn_dsca_Click);
            // 
            // btn_dsbanan
            // 
            this.btn_dsbanan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsbanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsbanan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsbanan.ForeColor = System.Drawing.Color.White;
            this.btn_dsbanan.Location = new System.Drawing.Point(0, 170);
            this.btn_dsbanan.Name = "btn_dsbanan";
            this.btn_dsbanan.Size = new System.Drawing.Size(256, 35);
            this.btn_dsbanan.TabIndex = 3;
            this.btn_dsbanan.Text = "Danh sách bàn ăn";
            this.btn_dsbanan.UseVisualStyleBackColor = true;
            this.btn_dsbanan.Click += new System.EventHandler(this.btn_dsbanan_Click);
            // 
            // btn_dshoadon
            // 
            this.btn_dshoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dshoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dshoadon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dshoadon.ForeColor = System.Drawing.Color.White;
            this.btn_dshoadon.Location = new System.Drawing.Point(0, 205);
            this.btn_dshoadon.Name = "btn_dshoadon";
            this.btn_dshoadon.Size = new System.Drawing.Size(256, 35);
            this.btn_dshoadon.TabIndex = 4;
            this.btn_dshoadon.Text = "Danh sách hóa đơn";
            this.btn_dshoadon.UseVisualStyleBackColor = true;
            this.btn_dshoadon.Click += new System.EventHandler(this.btn_dshoadon_Click);
            // 
            // btn_dsmonan
            // 
            this.btn_dsmonan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsmonan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dsmonan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsmonan.ForeColor = System.Drawing.Color.White;
            this.btn_dsmonan.Location = new System.Drawing.Point(0, 240);
            this.btn_dsmonan.Name = "btn_dsmonan";
            this.btn_dsmonan.Size = new System.Drawing.Size(256, 35);
            this.btn_dsmonan.TabIndex = 5;
            this.btn_dsmonan.Text = "Danh sách món ăn hôm nay";
            this.btn_dsmonan.UseVisualStyleBackColor = true;
            this.btn_dsmonan.Click += new System.EventHandler(this.btn_dsmonan_Click);
            // 
            // btn_thongtin
            // 
            this.btn_thongtin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_thongtin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongtin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongtin.ForeColor = System.Drawing.Color.White;
            this.btn_thongtin.Location = new System.Drawing.Point(484, 0);
            this.btn_thongtin.Name = "btn_thongtin";
            this.btn_thongtin.Size = new System.Drawing.Size(168, 49);
            this.btn_thongtin.TabIndex = 0;
            this.btn_thongtin.Text = "Thông tin cá nhân";
            this.btn_thongtin.UseVisualStyleBackColor = true;
            this.btn_thongtin.Click += new System.EventHandler(this.btn_thongtin_Click);
            // 
            // frmmaunhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pn_childform);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_menu);
            this.Name = "frmmaunhanvien";
            this.Text = "frmmaunhanvien";
            this.Load += new System.EventHandler(this.frmmaunhanvien_Load);
            this.pn_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_childform;
        private System.Windows.Forms.Button btn_dsmonan;
        private System.Windows.Forms.Button btn_dshoadon;
        private System.Windows.Forms.Button btn_dsbanan;
        private System.Windows.Forms.Button btn_dsca;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_thongtin;
    }
}