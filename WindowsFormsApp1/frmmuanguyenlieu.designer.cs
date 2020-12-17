namespace WindowsFormsApp1
{
    partial class frmmuanguyenlieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmuanguyenlieu));
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_doan = new System.Windows.Forms.DataGridView();
            this.dtg_nguyenlieu_theongay = new System.Windows.Forms.DataGridView();
            this.txt_tongtien = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_xoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_them = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_sua = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_luugia = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nguyenlieu_theongay)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(546, 90);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 25);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(362, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng tiền: ";
            // 
            // dtg_doan
            // 
            this.dtg_doan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtg_doan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dtg_doan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_doan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_doan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_doan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_doan.Location = new System.Drawing.Point(20, 26);
            this.dtg_doan.Name = "dtg_doan";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_doan.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_doan.RowHeadersWidth = 51;
            this.dtg_doan.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtg_doan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dtg_doan.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_doan.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dtg_doan.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dtg_doan.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_doan.Size = new System.Drawing.Size(462, 154);
            this.dtg_doan.TabIndex = 56;
            this.dtg_doan.Click += new System.EventHandler(this.dtg_doan_Click_1);
            // 
            // dtg_nguyenlieu_theongay
            // 
            this.dtg_nguyenlieu_theongay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtg_nguyenlieu_theongay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dtg_nguyenlieu_theongay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_nguyenlieu_theongay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_nguyenlieu_theongay.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_nguyenlieu_theongay.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_nguyenlieu_theongay.Location = new System.Drawing.Point(20, 197);
            this.dtg_nguyenlieu_theongay.Name = "dtg_nguyenlieu_theongay";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_nguyenlieu_theongay.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_nguyenlieu_theongay.RowHeadersWidth = 51;
            this.dtg_nguyenlieu_theongay.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dtg_nguyenlieu_theongay.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dtg_nguyenlieu_theongay.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtg_nguyenlieu_theongay.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dtg_nguyenlieu_theongay.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dtg_nguyenlieu_theongay.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_nguyenlieu_theongay.Size = new System.Drawing.Size(462, 154);
            this.dtg_nguyenlieu_theongay.TabIndex = 57;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.txt_tongtien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_tongtien.BackgroundImage")));
            this.txt_tongtien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_tongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.txt_tongtien.Icon = ((System.Drawing.Image)(resources.GetObject("txt_tongtien.Icon")));
            this.txt_tongtien.Location = new System.Drawing.Point(520, 386);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(250, 42);
            this.txt_tongtien.TabIndex = 58;
            this.txt_tongtien.text = "Tổng tiền";
            // 
            // btn_xoa
            // 
            this.btn_xoa.ActiveBorderThickness = 1;
            this.btn_xoa.ActiveCornerRadius = 45;
            this.btn_xoa.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoa.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_xoa.BackgroundImage")));
            this.btn_xoa.ButtonText = "Xóa";
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.IdleBorderThickness = 1;
            this.btn_xoa.IdleCornerRadius = 45;
            this.btn_xoa.IdleFillColor = System.Drawing.Color.White;
            this.btn_xoa.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.Location = new System.Drawing.Point(604, 84);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(142, 57);
            this.btn_xoa.TabIndex = 59;
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.ActiveBorderThickness = 1;
            this.btn_them.ActiveCornerRadius = 45;
            this.btn_them.ActiveFillColor = System.Drawing.Color.White;
            this.btn_them.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_them.BackgroundImage")));
            this.btn_them.ButtonText = "Thêm";
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.IdleBorderThickness = 1;
            this.btn_them.IdleCornerRadius = 45;
            this.btn_them.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.IdleForecolor = System.Drawing.Color.White;
            this.btn_them.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.Location = new System.Drawing.Point(604, 26);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(142, 57);
            this.btn_them.TabIndex = 60;
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ActiveBorderThickness = 1;
            this.btn_sua.ActiveCornerRadius = 45;
            this.btn_sua.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_sua.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_sua.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_sua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sua.BackgroundImage")));
            this.btn_sua.ButtonText = "Sửa";
            this.btn_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.IdleBorderThickness = 1;
            this.btn_sua.IdleCornerRadius = 45;
            this.btn_sua.IdleFillColor = System.Drawing.Color.White;
            this.btn_sua.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_sua.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_sua.Location = new System.Drawing.Point(604, 149);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(142, 57);
            this.btn_sua.TabIndex = 61;
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luugia
            // 
            this.btn_luugia.ActiveBorderThickness = 1;
            this.btn_luugia.ActiveCornerRadius = 45;
            this.btn_luugia.ActiveFillColor = System.Drawing.Color.White;
            this.btn_luugia.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_luugia.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_luugia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_luugia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_luugia.BackgroundImage")));
            this.btn_luugia.ButtonText = "Lưu giá nguyên liêu";
            this.btn_luugia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luugia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luugia.ForeColor = System.Drawing.Color.White;
            this.btn_luugia.IdleBorderThickness = 1;
            this.btn_luugia.IdleCornerRadius = 45;
            this.btn_luugia.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_luugia.IdleForecolor = System.Drawing.Color.White;
            this.btn_luugia.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_luugia.Location = new System.Drawing.Point(604, 214);
            this.btn_luugia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_luugia.Name = "btn_luugia";
            this.btn_luugia.Size = new System.Drawing.Size(166, 57);
            this.btn_luugia.TabIndex = 62;
            this.btn_luugia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_luugia.Click += new System.EventHandler(this.btn_luugia_Click);
            // 
            // frmmuanguyenlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(805, 474);
            this.Controls.Add(this.btn_luugia);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.dtg_nguyenlieu_theongay);
            this.Controls.Add(this.dtg_doan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "frmmuanguyenlieu";
            this.Text = "frmmuanguyenlieu";
            this.Load += new System.EventHandler(this.frmmuanguyenlieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nguyenlieu_theongay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_doan;
        private System.Windows.Forms.DataGridView dtg_nguyenlieu_theongay;
        private Bunifu.Framework.UI.BunifuTextbox txt_tongtien;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_xoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_them;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_sua;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_luugia;
    }
}