namespace WindowsFormsApp1
{
    partial class frmdscanhanvien
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
            Bunifu.Framework.UI.BunifuDatepicker dt_ngay;
            Bunifu.Framework.UI.BunifuDatepicker dt_dau;
            Bunifu.Framework.UI.BunifuDatepicker dt_sau;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdscanhanvien));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rdb_all = new System.Windows.Forms.RadioButton();
            this.rdb_ngay = new System.Windows.Forms.RadioButton();
            this.rdb_khoang = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_check = new Bunifu.Framework.UI.BunifuThinButton2();
            dt_ngay = new Bunifu.Framework.UI.BunifuDatepicker();
            dt_dau = new Bunifu.Framework.UI.BunifuDatepicker();
            dt_sau = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_ngay
            // 
            dt_ngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            dt_ngay.BorderRadius = 45;
            dt_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_ngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dt_ngay.FormatCustom = null;
            dt_ngay.Location = new System.Drawing.Point(291, 64);
            dt_ngay.Margin = new System.Windows.Forms.Padding(6);
            dt_ngay.Name = "dt_ngay";
            dt_ngay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_ngay.Size = new System.Drawing.Size(278, 44);
            dt_ngay.TabIndex = 45;
            dt_ngay.Value = new System.DateTime(2020, 12, 6, 18, 53, 56, 232);
            // 
            // dt_dau
            // 
            dt_dau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            dt_dau.BorderRadius = 45;
            dt_dau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_dau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dt_dau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dt_dau.FormatCustom = null;
            dt_dau.Location = new System.Drawing.Point(203, 120);
            dt_dau.Margin = new System.Windows.Forms.Padding(6);
            dt_dau.Name = "dt_dau";
            dt_dau.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_dau.Size = new System.Drawing.Size(192, 44);
            dt_dau.TabIndex = 49;
            dt_dau.Value = new System.DateTime(2020, 12, 6, 18, 53, 56, 232);
            // 
            // dt_sau
            // 
            dt_sau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            dt_sau.BorderRadius = 45;
            dt_sau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_sau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dt_sau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dt_sau.FormatCustom = null;
            dt_sau.Location = new System.Drawing.Point(477, 120);
            dt_sau.Margin = new System.Windows.Forms.Padding(6);
            dt_sau.Name = "dt_sau";
            dt_sau.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_sau.Size = new System.Drawing.Size(199, 44);
            dt_sau.TabIndex = 50;
            dt_sau.Value = new System.DateTime(2020, 12, 6, 18, 53, 56, 232);
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
            this.dataGridView1.Location = new System.Drawing.Point(29, 224);
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
            this.dataGridView1.Size = new System.Drawing.Size(907, 425);
            this.dataGridView1.TabIndex = 40;
            // 
            // rdb_all
            // 
            this.rdb_all.AutoSize = true;
            this.rdb_all.Location = new System.Drawing.Point(29, 33);
            this.rdb_all.Name = "rdb_all";
            this.rdb_all.Size = new System.Drawing.Size(70, 29);
            this.rdb_all.TabIndex = 46;
            this.rdb_all.TabStop = true;
            this.rdb_all.Text = "   All";
            this.rdb_all.UseVisualStyleBackColor = true;
            // 
            // rdb_ngay
            // 
            this.rdb_ngay.AutoSize = true;
            this.rdb_ngay.Location = new System.Drawing.Point(29, 79);
            this.rdb_ngay.Name = "rdb_ngay";
            this.rdb_ngay.Size = new System.Drawing.Size(144, 29);
            this.rdb_ngay.TabIndex = 47;
            this.rdb_ngay.TabStop = true;
            this.rdb_ngay.Text = "   Chọn ngày";
            this.rdb_ngay.UseVisualStyleBackColor = true;
            // 
            // rdb_khoang
            // 
            this.rdb_khoang.AutoSize = true;
            this.rdb_khoang.Location = new System.Drawing.Point(29, 131);
            this.rdb_khoang.Name = "rdb_khoang";
            this.rdb_khoang.Size = new System.Drawing.Size(166, 29);
            this.rdb_khoang.TabIndex = 48;
            this.rdb_khoang.TabStop = true;
            this.rdb_khoang.Text = "   Chọn khoảng";
            this.rdb_khoang.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(413, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "đến";
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
            this.btn_check.Location = new System.Drawing.Point(753, 79);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(121, 56);
            this.btn_check.TabIndex = 52;
            this.btn_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmdscanhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1071, 675);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(dt_sau);
            this.Controls.Add(dt_dau);
            this.Controls.Add(this.rdb_khoang);
            this.Controls.Add(this.rdb_ngay);
            this.Controls.Add(this.rdb_all);
            this.Controls.Add(dt_ngay);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmdscanhanvien";
            this.Text = "frmdscanhanvien";
            this.Load += new System.EventHandler(this.frmdscanhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdb_all;
        private System.Windows.Forms.RadioButton rdb_ngay;
        private System.Windows.Forms.RadioButton rdb_khoang;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_check;
    }
}