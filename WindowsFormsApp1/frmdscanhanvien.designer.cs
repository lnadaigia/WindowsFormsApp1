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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dt_ngay = new System.Windows.Forms.DateTimePicker();
            this.rdb_chonngay = new System.Windows.Forms.RadioButton();
            this.rdb_chonkhoang = new System.Windows.Forms.RadioButton();
            this.dt_dau = new System.Windows.Forms.DateTimePicker();
            this.dt_sau = new System.Windows.Forms.DateTimePicker();
            this.rdb_tatca = new System.Windows.Forms.RadioButton();
            this.btn_check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 228);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // dt_ngay
            // 
            this.dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngay.Location = new System.Drawing.Point(72, 95);
            this.dt_ngay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_ngay.Name = "dt_ngay";
            this.dt_ngay.Size = new System.Drawing.Size(163, 26);
            this.dt_ngay.TabIndex = 1;
            // 
            // rdb_chonngay
            // 
            this.rdb_chonngay.AutoSize = true;
            this.rdb_chonngay.Location = new System.Drawing.Point(18, 102);
            this.rdb_chonngay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_chonngay.Name = "rdb_chonngay";
            this.rdb_chonngay.Size = new System.Drawing.Size(14, 13);
            this.rdb_chonngay.TabIndex = 2;
            this.rdb_chonngay.UseVisualStyleBackColor = true;
            // 
            // rdb_chonkhoang
            // 
            this.rdb_chonkhoang.AutoSize = true;
            this.rdb_chonkhoang.Location = new System.Drawing.Point(18, 163);
            this.rdb_chonkhoang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_chonkhoang.Name = "rdb_chonkhoang";
            this.rdb_chonkhoang.Size = new System.Drawing.Size(14, 13);
            this.rdb_chonkhoang.TabIndex = 4;
            this.rdb_chonkhoang.UseVisualStyleBackColor = true;
            // 
            // dt_dau
            // 
            this.dt_dau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dau.Location = new System.Drawing.Point(72, 157);
            this.dt_dau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_dau.Name = "dt_dau";
            this.dt_dau.Size = new System.Drawing.Size(163, 26);
            this.dt_dau.TabIndex = 3;
            // 
            // dt_sau
            // 
            this.dt_sau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_sau.Location = new System.Drawing.Point(292, 157);
            this.dt_sau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_sau.Name = "dt_sau";
            this.dt_sau.Size = new System.Drawing.Size(163, 26);
            this.dt_sau.TabIndex = 5;
            // 
            // rdb_tatca
            // 
            this.rdb_tatca.AutoSize = true;
            this.rdb_tatca.Checked = true;
            this.rdb_tatca.Location = new System.Drawing.Point(18, 40);
            this.rdb_tatca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_tatca.Name = "rdb_tatca";
            this.rdb_tatca.Size = new System.Drawing.Size(71, 24);
            this.rdb_tatca.TabIndex = 6;
            this.rdb_tatca.TabStop = true;
            this.rdb_tatca.Text = "Tất cả";
            this.rdb_tatca.UseVisualStyleBackColor = true;
            // 
            // btn_check
            // 
            this.btn_check.ForeColor = System.Drawing.Color.Black;
            this.btn_check.Location = new System.Drawing.Point(524, 157);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(112, 35);
            this.btn_check.TabIndex = 7;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // frmdscanhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(661, 514);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.rdb_tatca);
            this.Controls.Add(this.dt_sau);
            this.Controls.Add(this.rdb_chonkhoang);
            this.Controls.Add(this.dt_dau);
            this.Controls.Add(this.rdb_chonngay);
            this.Controls.Add(this.dt_ngay);
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
        private System.Windows.Forms.DateTimePicker dt_ngay;
        private System.Windows.Forms.RadioButton rdb_chonngay;
        private System.Windows.Forms.RadioButton rdb_chonkhoang;
        private System.Windows.Forms.DateTimePicker dt_dau;
        private System.Windows.Forms.DateTimePicker dt_sau;
        private System.Windows.Forms.RadioButton rdb_tatca;
        private System.Windows.Forms.Button btn_check;
    }
}