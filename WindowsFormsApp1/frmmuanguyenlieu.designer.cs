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
            this.btn_xemdonhang = new Bunifu.Framework.UI.BunifuThinButton2();
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
            this.numericUpDown1.Location = new System.Drawing.Point(644, 40);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(69, 30);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 451);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 38);
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
            this.dtg_doan.Location = new System.Drawing.Point(27, 32);
            this.dtg_doan.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_doan.Name = "dtg_doan";
            this.dtg_doan.ReadOnly = true;
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
            this.dtg_doan.Size = new System.Drawing.Size(592, 190);
            this.dtg_doan.TabIndex = 56;
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
            this.dtg_nguyenlieu_theongay.Location = new System.Drawing.Point(27, 243);
            this.dtg_nguyenlieu_theongay.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_nguyenlieu_theongay.Name = "dtg_nguyenlieu_theongay";
            this.dtg_nguyenlieu_theongay.ReadOnly = true;
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
            this.dtg_nguyenlieu_theongay.Size = new System.Drawing.Size(592, 190);
            this.dtg_nguyenlieu_theongay.TabIndex = 57;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.txt_tongtien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_tongtien.BackgroundImage")));
            this.txt_tongtien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_tongtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.txt_tongtien.Icon = ((System.Drawing.Image)(resources.GetObject("txt_tongtien.Icon")));
            this.txt_tongtien.Location = new System.Drawing.Point(508, 437);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(333, 52);
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
            this.btn_xoa.Location = new System.Drawing.Point(757, 23);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(189, 70);
            this.btn_xoa.TabIndex = 59;
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_xemdonhang
            // 
            this.btn_xemdonhang.ActiveBorderThickness = 1;
            this.btn_xemdonhang.ActiveCornerRadius = 45;
            this.btn_xemdonhang.ActiveFillColor = System.Drawing.Color.White;
            this.btn_xemdonhang.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xemdonhang.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xemdonhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_xemdonhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_xemdonhang.BackgroundImage")));
            this.btn_xemdonhang.ButtonText = "Xem đơn hàng";
            this.btn_xemdonhang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xemdonhang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemdonhang.ForeColor = System.Drawing.Color.White;
            this.btn_xemdonhang.IdleBorderThickness = 1;
            this.btn_xemdonhang.IdleCornerRadius = 45;
            this.btn_xemdonhang.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xemdonhang.IdleForecolor = System.Drawing.Color.White;
            this.btn_xemdonhang.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xemdonhang.Location = new System.Drawing.Point(757, 103);
            this.btn_xemdonhang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xemdonhang.Name = "btn_xemdonhang";
            this.btn_xemdonhang.Size = new System.Drawing.Size(189, 70);
            this.btn_xemdonhang.TabIndex = 60;
            this.btn_xemdonhang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmmuanguyenlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1073, 583);
            this.Controls.Add(this.btn_xemdonhang);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.dtg_nguyenlieu_theongay);
            this.Controls.Add(this.dtg_doan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private Bunifu.Framework.UI.BunifuThinButton2 btn_xemdonhang;
    }
}