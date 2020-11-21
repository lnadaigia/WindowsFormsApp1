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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_check = new System.Windows.Forms.Button();
            this.rdb_chonkhoang = new System.Windows.Forms.RadioButton();
            this.rdb_chonngay = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_sau = new System.Windows.Forms.DateTimePicker();
            this.dt_dau = new System.Windows.Forms.DateTimePicker();
            this.dt_ngay = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_themca = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_chiadeu = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.bttn_luu = new System.Windows.Forms.Button();
            this.btn_xóa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_check
            // 
            this.btn_check.ForeColor = System.Drawing.Color.Black;
            this.btn_check.Location = new System.Drawing.Point(291, 9);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(123, 38);
            this.btn_check.TabIndex = 27;
            this.btn_check.Text = "Tìm kiếm";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // rdb_chonkhoang
            // 
            this.rdb_chonkhoang.AutoSize = true;
            this.rdb_chonkhoang.Location = new System.Drawing.Point(14, 60);
            this.rdb_chonkhoang.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_chonkhoang.Name = "rdb_chonkhoang";
            this.rdb_chonkhoang.Size = new System.Drawing.Size(14, 13);
            this.rdb_chonkhoang.TabIndex = 26;
            this.rdb_chonkhoang.TabStop = true;
            this.rdb_chonkhoang.UseVisualStyleBackColor = true;
            // 
            // rdb_chonngay
            // 
            this.rdb_chonngay.AutoSize = true;
            this.rdb_chonngay.Checked = true;
            this.rdb_chonngay.Location = new System.Drawing.Point(16, 14);
            this.rdb_chonngay.Margin = new System.Windows.Forms.Padding(4);
            this.rdb_chonngay.Name = "rdb_chonngay";
            this.rdb_chonngay.Size = new System.Drawing.Size(14, 13);
            this.rdb_chonngay.TabIndex = 25;
            this.rdb_chonngay.TabStop = true;
            this.rdb_chonngay.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "từ";
            // 
            // dt_sau
            // 
            this.dt_sau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_sau.Location = new System.Drawing.Point(291, 62);
            this.dt_sau.Margin = new System.Windows.Forms.Padding(4);
            this.dt_sau.Name = "dt_sau";
            this.dt_sau.Size = new System.Drawing.Size(121, 22);
            this.dt_sau.TabIndex = 22;
            // 
            // dt_dau
            // 
            this.dt_dau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dau.Location = new System.Drawing.Point(89, 62);
            this.dt_dau.Margin = new System.Windows.Forms.Padding(4);
            this.dt_dau.Name = "dt_dau";
            this.dt_dau.Size = new System.Drawing.Size(121, 22);
            this.dt_dau.TabIndex = 21;
            // 
            // dt_ngay
            // 
            this.dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngay.Location = new System.Drawing.Point(89, 12);
            this.dt_ngay.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngay.Name = "dt_ngay";
            this.dt_ngay.Size = new System.Drawing.Size(121, 22);
            this.dt_ngay.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 174);
            this.dataGridView1.TabIndex = 28;
            // 
            // btn_themca
            // 
            this.btn_themca.ForeColor = System.Drawing.Color.Black;
            this.btn_themca.Location = new System.Drawing.Point(530, 14);
            this.btn_themca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themca.Name = "btn_themca";
            this.btn_themca.Size = new System.Drawing.Size(123, 38);
            this.btn_themca.TabIndex = 29;
            this.btn_themca.Text = "Thêm ca";
            this.btn_themca.UseVisualStyleBackColor = true;
            this.btn_themca.Click += new System.EventHandler(this.btn_themca_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(508, 137);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(697, 336);
            this.dataGridView2.TabIndex = 30;
            // 
            // btn_chiadeu
            // 
            this.btn_chiadeu.ForeColor = System.Drawing.Color.Black;
            this.btn_chiadeu.Location = new System.Drawing.Point(530, 66);
            this.btn_chiadeu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chiadeu.Name = "btn_chiadeu";
            this.btn_chiadeu.Size = new System.Drawing.Size(123, 38);
            this.btn_chiadeu.TabIndex = 32;
            this.btn_chiadeu.Text = "Chia đều";
            this.btn_chiadeu.UseVisualStyleBackColor = true;
            this.btn_chiadeu.Click += new System.EventHandler(this.btn_chiadeu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(859, 17);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(148, 64);
            this.btn_sua.TabIndex = 34;
            this.btn_sua.Text = "sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // bttn_luu
            // 
            this.bttn_luu.ForeColor = System.Drawing.Color.Black;
            this.bttn_luu.Location = new System.Drawing.Point(701, 14);
            this.bttn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.bttn_luu.Name = "bttn_luu";
            this.bttn_luu.Size = new System.Drawing.Size(146, 64);
            this.bttn_luu.TabIndex = 33;
            this.bttn_luu.Text = "Thêm";
            this.bttn_luu.UseVisualStyleBackColor = true;
            this.bttn_luu.Click += new System.EventHandler(this.bttn_luu_Click);
            // 
            // btn_xóa
            // 
            this.btn_xóa.ForeColor = System.Drawing.Color.Black;
            this.btn_xóa.Location = new System.Drawing.Point(1060, 43);
            this.btn_xóa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xóa.Name = "btn_xóa";
            this.btn_xóa.Size = new System.Drawing.Size(123, 38);
            this.btn_xóa.TabIndex = 35;
            this.btn_xóa.Text = "xóa";
            this.btn_xóa.UseVisualStyleBackColor = true;
            this.btn_xóa.Click += new System.EventHandler(this.btn_xóa_Click);
            // 
            // frmchiacav2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1218, 599);
            this.Controls.Add(this.btn_xóa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.bttn_luu);
            this.Controls.Add(this.btn_chiadeu);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_themca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.rdb_chonkhoang);
            this.Controls.Add(this.rdb_chonngay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_sau);
            this.Controls.Add(this.dt_dau);
            this.Controls.Add(this.dt_ngay);
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

        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.RadioButton rdb_chonkhoang;
        private System.Windows.Forms.RadioButton rdb_chonngay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_sau;
        private System.Windows.Forms.DateTimePicker dt_dau;
        private System.Windows.Forms.DateTimePicker dt_ngay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_themca;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_chiadeu;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button bttn_luu;
        private System.Windows.Forms.Button btn_xóa;
    }
}