namespace WindowsFormsApp1
{
    partial class frmchiacav2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmchiacav2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rd_khoang = new System.Windows.Forms.RadioButton();
            this.rd_ngay = new System.Windows.Forms.RadioButton();
            this.btn_check = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_themca = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_chiadeu = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_xoa = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_luu = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_sua = new Bunifu.Framework.UI.BunifuThinButton2();
            dt_sau = new Bunifu.Framework.UI.BunifuDatepicker();
            dt_dau = new Bunifu.Framework.UI.BunifuDatepicker();
            dt_ngay = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_sau
            // 
            dt_sau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            dt_sau.BorderRadius = 45;
            dt_sau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_sau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dt_sau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dt_sau.FormatCustom = null;
            dt_sau.Location = new System.Drawing.Point(321, 66);
            dt_sau.Margin = new System.Windows.Forms.Padding(5);
            dt_sau.Name = "dt_sau";
            dt_sau.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_sau.Size = new System.Drawing.Size(115, 40);
            dt_sau.TabIndex = 56;
            dt_sau.Value = new System.DateTime(2020, 12, 6, 18, 53, 56, 232);
            // 
            // dt_dau
            // 
            dt_dau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            dt_dau.BorderRadius = 45;
            dt_dau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_dau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dt_dau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dt_dau.FormatCustom = null;
            dt_dau.Location = new System.Drawing.Point(160, 66);
            dt_dau.Margin = new System.Windows.Forms.Padding(5);
            dt_dau.Name = "dt_dau";
            dt_dau.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_dau.Size = new System.Drawing.Size(109, 40);
            dt_dau.TabIndex = 55;
            dt_dau.Value = new System.DateTime(2020, 12, 6, 18, 53, 56, 232);
            // 
            // dt_ngay
            // 
            dt_ngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            dt_ngay.BorderRadius = 45;
            dt_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_ngay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dt_ngay.FormatCustom = null;
            dt_ngay.Location = new System.Drawing.Point(160, 14);
            dt_ngay.Margin = new System.Windows.Forms.Padding(5);
            dt_ngay.Name = "dt_ngay";
            dt_ngay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_ngay.Size = new System.Drawing.Size(109, 40);
            dt_ngay.TabIndex = 52;
            dt_ngay.Value = new System.DateTime(2020, 12, 6, 18, 53, 56, 232);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(16, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(446, 296);
            this.dataGridView1.TabIndex = 36;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.Location = new System.Drawing.Point(497, 137);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dataGridView2.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView2.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dataGridView2.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.Size = new System.Drawing.Size(708, 387);
            this.dataGridView2.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "đến";
            // 
            // rd_khoang
            // 
            this.rd_khoang.AutoSize = true;
            this.rd_khoang.Location = new System.Drawing.Point(14, 79);
            this.rd_khoang.Name = "rd_khoang";
            this.rd_khoang.Size = new System.Drawing.Size(142, 24);
            this.rd_khoang.TabIndex = 54;
            this.rd_khoang.TabStop = true;
            this.rd_khoang.Text = "   Chọn khoảng";
            this.rd_khoang.UseVisualStyleBackColor = true;
            // 
            // rd_ngay
            // 
            this.rd_ngay.AutoSize = true;
            this.rd_ngay.Location = new System.Drawing.Point(14, 27);
            this.rd_ngay.Name = "rd_ngay";
            this.rd_ngay.Size = new System.Drawing.Size(124, 24);
            this.rd_ngay.TabIndex = 53;
            this.rd_ngay.TabStop = true;
            this.rd_ngay.Text = "   Chọn ngày";
            this.rd_ngay.UseVisualStyleBackColor = true;
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
            this.btn_check.Location = new System.Drawing.Point(315, 0);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(121, 56);
            this.btn_check.TabIndex = 58;
            this.btn_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_themca
            // 
            this.btn_themca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_themca.color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_themca.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_themca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themca.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themca.ForeColor = System.Drawing.Color.White;
            this.btn_themca.Image = ((System.Drawing.Image)(resources.GetObject("btn_themca.Image")));
            this.btn_themca.ImagePosition = 14;
            this.btn_themca.ImageZoom = 50;
            this.btn_themca.LabelPosition = 30;
            this.btn_themca.LabelText = "Thêm ca";
            this.btn_themca.Location = new System.Drawing.Point(465, 14);
            this.btn_themca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_themca.Name = "btn_themca";
            this.btn_themca.Size = new System.Drawing.Size(100, 99);
            this.btn_themca.TabIndex = 59;
            // 
            // btn_chiadeu
            // 
            this.btn_chiadeu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_chiadeu.color = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_chiadeu.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_chiadeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chiadeu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chiadeu.ForeColor = System.Drawing.Color.White;
            this.btn_chiadeu.Image = ((System.Drawing.Image)(resources.GetObject("btn_chiadeu.Image")));
            this.btn_chiadeu.ImagePosition = 14;
            this.btn_chiadeu.ImageZoom = 50;
            this.btn_chiadeu.LabelPosition = 30;
            this.btn_chiadeu.LabelText = "Chia đều";
            this.btn_chiadeu.Location = new System.Drawing.Point(583, 14);
            this.btn_chiadeu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_chiadeu.Name = "btn_chiadeu";
            this.btn_chiadeu.Size = new System.Drawing.Size(100, 99);
            this.btn_chiadeu.TabIndex = 60;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.color = System.Drawing.Color.White;
            this.btn_xoa.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImagePosition = 14;
            this.btn_xoa.ImageZoom = 50;
            this.btn_xoa.LabelPosition = 0;
            this.btn_xoa.LabelText = "";
            this.btn_xoa.Location = new System.Drawing.Point(1095, 31);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(72, 66);
            this.btn_xoa.TabIndex = 61;
            // 
            // btn_luu
            // 
            this.btn_luu.ActiveBorderThickness = 1;
            this.btn_luu.ActiveCornerRadius = 40;
            this.btn_luu.ActiveFillColor = System.Drawing.Color.White;
            this.btn_luu.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_luu.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_luu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_luu.BackgroundImage")));
            this.btn_luu.ButtonText = "Thêm";
            this.btn_luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.White;
            this.btn_luu.IdleBorderThickness = 1;
            this.btn_luu.IdleCornerRadius = 40;
            this.btn_luu.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_luu.IdleForecolor = System.Drawing.Color.White;
            this.btn_luu.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_luu.Location = new System.Drawing.Point(711, 17);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(160, 60);
            this.btn_luu.TabIndex = 76;
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_sua
            // 
            this.btn_sua.ActiveBorderThickness = 1;
            this.btn_sua.ActiveCornerRadius = 40;
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
            this.btn_sua.IdleCornerRadius = 40;
            this.btn_sua.IdleFillColor = System.Drawing.Color.White;
            this.btn_sua.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_sua.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_sua.Location = new System.Drawing.Point(893, 17);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(160, 60);
            this.btn_sua.TabIndex = 77;
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmchiacav2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1232, 599);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_chiadeu);
            this.Controls.Add(this.btn_themca);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(dt_sau);
            this.Controls.Add(dt_dau);
            this.Controls.Add(this.rd_khoang);
            this.Controls.Add(this.rd_ngay);
            this.Controls.Add(dt_ngay);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmchiacav2";
            this.Text = "frmchiacav2";
            this.Load += new System.EventHandler(this.frmchiacav2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rd_khoang;
        private System.Windows.Forms.RadioButton rd_ngay;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_check;
        private Bunifu.Framework.UI.BunifuTileButton btn_themca;
        private Bunifu.Framework.UI.BunifuTileButton btn_chiadeu;
        private Bunifu.Framework.UI.BunifuTileButton btn_xoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_luu;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_sua;
    }
}