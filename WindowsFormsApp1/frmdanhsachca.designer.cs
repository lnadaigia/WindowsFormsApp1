namespace WindowsFormsApp1
{
    partial class frmdanhsachca
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
            Bunifu.Framework.UI.BunifuDatepicker dt_sau;
            Bunifu.Framework.UI.BunifuDatepicker dt_dau;
            Bunifu.Framework.UI.BunifuDatepicker dt_ngay;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdanhsachca));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_check = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_all = new System.Windows.Forms.RadioButton();
            this.rdb_ngay = new System.Windows.Forms.RadioButton();
            this.rdb_khoang = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_search = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_capnhat = new Bunifu.Framework.UI.BunifuTileButton();
            dt_sau = new Bunifu.Framework.UI.BunifuDatepicker();
            dt_dau = new Bunifu.Framework.UI.BunifuDatepicker();
            dt_ngay = new Bunifu.Framework.UI.BunifuDatepicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_sau
            // 
            dt_sau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            dt_sau.BorderRadius = 45;
            dt_sau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_sau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dt_sau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dt_sau.FormatCustom = null;
            dt_sau.Location = new System.Drawing.Point(468, 113);
            dt_sau.Margin = new System.Windows.Forms.Padding(6);
            dt_sau.Name = "dt_sau";
            dt_sau.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_sau.Size = new System.Drawing.Size(199, 44);
            dt_sau.TabIndex = 58;
            dt_sau.Value = new System.DateTime(2020, 12, 6, 18, 53, 56, 232);
            // 
            // dt_dau
            // 
            dt_dau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            dt_dau.BorderRadius = 45;
            dt_dau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_dau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dt_dau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dt_dau.FormatCustom = null;
            dt_dau.Location = new System.Drawing.Point(194, 113);
            dt_dau.Margin = new System.Windows.Forms.Padding(6);
            dt_dau.Name = "dt_dau";
            dt_dau.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_dau.Size = new System.Drawing.Size(192, 44);
            dt_dau.TabIndex = 57;
            dt_dau.Value = new System.DateTime(2020, 12, 6, 18, 53, 56, 232);
            // 
            // dt_ngay
            // 
            dt_ngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            dt_ngay.BorderRadius = 45;
            dt_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_ngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dt_ngay.FormatCustom = null;
            dt_ngay.Location = new System.Drawing.Point(282, 57);
            dt_ngay.Margin = new System.Windows.Forms.Padding(6);
            dt_ngay.Name = "dt_ngay";
            dt_ngay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_ngay.Size = new System.Drawing.Size(278, 44);
            dt_ngay.TabIndex = 53;
            dt_ngay.Value = new System.DateTime(2020, 12, 6, 18, 53, 56, 232);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(dt_ngay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rdb_all);
            this.panel1.Controls.Add(dt_sau);
            this.panel1.Controls.Add(this.rdb_ngay);
            this.panel1.Controls.Add(dt_dau);
            this.panel1.Controls.Add(this.rdb_khoang);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 178);
            this.panel1.TabIndex = 6;
            // 
            // btn_check
            // 
            this.btn_check.ActiveBorderThickness = 1;
            this.btn_check.ActiveCornerRadius = 45;
            this.btn_check.ActiveFillColor = System.Drawing.Color.White;
            this.btn_check.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_check.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_check.BackgroundImage")));
            this.btn_check.ButtonText = "Check";
            this.btn_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_check.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.White;
            this.btn_check.IdleBorderThickness = 1;
            this.btn_check.IdleCornerRadius = 45;
            this.btn_check.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_check.IdleForecolor = System.Drawing.Color.White;
            this.btn_check.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_check.Location = new System.Drawing.Point(579, 40);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(121, 56);
            this.btn_check.TabIndex = 60;
            this.btn_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "đến";
            // 
            // rdb_all
            // 
            this.rdb_all.AutoSize = true;
            this.rdb_all.Location = new System.Drawing.Point(20, 26);
            this.rdb_all.Name = "rdb_all";
            this.rdb_all.Size = new System.Drawing.Size(64, 24);
            this.rdb_all.TabIndex = 54;
            this.rdb_all.TabStop = true;
            this.rdb_all.Text = "   All";
            this.rdb_all.UseVisualStyleBackColor = true;
            // 
            // rdb_ngay
            // 
            this.rdb_ngay.AutoSize = true;
            this.rdb_ngay.Location = new System.Drawing.Point(20, 72);
            this.rdb_ngay.Name = "rdb_ngay";
            this.rdb_ngay.Size = new System.Drawing.Size(124, 24);
            this.rdb_ngay.TabIndex = 55;
            this.rdb_ngay.TabStop = true;
            this.rdb_ngay.Text = "   Chọn ngày";
            this.rdb_ngay.UseVisualStyleBackColor = true;
            // 
            // rdb_khoang
            // 
            this.rdb_khoang.AutoSize = true;
            this.rdb_khoang.Location = new System.Drawing.Point(20, 124);
            this.rdb_khoang.Name = "rdb_khoang";
            this.rdb_khoang.Size = new System.Drawing.Size(142, 24);
            this.rdb_khoang.TabIndex = 56;
            this.rdb_khoang.TabStop = true;
            this.rdb_khoang.Text = "   Chọn khoảng";
            this.rdb_khoang.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(69, 260);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(768, 379);
            this.dataGridView1.TabIndex = 41;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_search.Location = new System.Drawing.Point(20, 190);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(157, 31);
            this.txt_search.TabIndex = 69;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.panel2.Location = new System.Drawing.Point(20, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 1);
            this.panel2.TabIndex = 68;
            // 
            // btn_search
            // 
            this.btn_search.ActiveBorderThickness = 1;
            this.btn_search.ActiveCornerRadius = 40;
            this.btn_search.ActiveFillColor = System.Drawing.Color.White;
            this.btn_search.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_search.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.ButtonText = "Search";
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.IdleBorderThickness = 1;
            this.btn_search.IdleCornerRadius = 40;
            this.btn_search.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_search.IdleForecolor = System.Drawing.Color.White;
            this.btn_search.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_search.Location = new System.Drawing.Point(210, 180);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(160, 60);
            this.btn_search.TabIndex = 77;
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_capnhat.color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_capnhat.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_capnhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_capnhat.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.White;
            this.btn_capnhat.Image = ((System.Drawing.Image)(resources.GetObject("btn_capnhat.Image")));
            this.btn_capnhat.ImagePosition = 14;
            this.btn_capnhat.ImageZoom = 50;
            this.btn_capnhat.LabelPosition = 30;
            this.btn_capnhat.LabelText = "Cập nhật";
            this.btn_capnhat.Location = new System.Drawing.Point(773, 42);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(100, 99);
            this.btn_capnhat.TabIndex = 78;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // frmdanhsachca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(923, 731);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmdanhsachca";
            this.Text = "danh sách ca";
            this.Load += new System.EventHandler(this.frmchiaca_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_all;
        private System.Windows.Forms.RadioButton rdb_ngay;
        private System.Windows.Forms.RadioButton rdb_khoang;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_search;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_search;
        private Bunifu.Framework.UI.BunifuTileButton btn_capnhat;
    }
}