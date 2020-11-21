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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dt_ngay = new System.Windows.Forms.DateTimePicker();
            this.rdb_tatca = new System.Windows.Forms.RadioButton();
            this.rdb_chonngay = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_check = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_dau = new System.Windows.Forms.DateTimePicker();
            this.rdb_chonkhoang = new System.Windows.Forms.RadioButton();
            this.dt_sau = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.bn_capnhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 180);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(927, 433);
            this.dataGridView1.TabIndex = 0;
            // 
            // dt_ngay
            // 
            this.dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngay.Location = new System.Drawing.Point(146, 48);
            this.dt_ngay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_ngay.Name = "dt_ngay";
            this.dt_ngay.Size = new System.Drawing.Size(164, 22);
            this.dt_ngay.TabIndex = 1;
            // 
            // rdb_tatca
            // 
            this.rdb_tatca.AutoSize = true;
            this.rdb_tatca.Checked = true;
            this.rdb_tatca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_tatca.Location = new System.Drawing.Point(8, 14);
            this.rdb_tatca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_tatca.Name = "rdb_tatca";
            this.rdb_tatca.Size = new System.Drawing.Size(67, 24);
            this.rdb_tatca.TabIndex = 4;
            this.rdb_tatca.TabStop = true;
            this.rdb_tatca.Text = "tất cả";
            this.rdb_tatca.UseVisualStyleBackColor = true;
            // 
            // rdb_chonngay
            // 
            this.rdb_chonngay.AutoSize = true;
            this.rdb_chonngay.Location = new System.Drawing.Point(8, 48);
            this.rdb_chonngay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_chonngay.Name = "rdb_chonngay";
            this.rdb_chonngay.Size = new System.Drawing.Size(88, 20);
            this.rdb_chonngay.TabIndex = 5;
            this.rdb_chonngay.Text = "chọn ngày";
            this.rdb_chonngay.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_check);
            this.panel1.Controls.Add(this.dt_ngay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdb_chonngay);
            this.panel1.Controls.Add(this.rdb_tatca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dt_dau);
            this.panel1.Controls.Add(this.rdb_chonkhoang);
            this.panel1.Controls.Add(this.dt_sau);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 136);
            this.panel1.TabIndex = 6;
            // 
            // btn_check
            // 
            this.btn_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_check.ForeColor = System.Drawing.Color.Black;
            this.btn_check.Location = new System.Drawing.Point(449, 48);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(146, 40);
            this.btn_check.TabIndex = 11;
            this.btn_check.Text = "Check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "từ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "đến";
            // 
            // dt_dau
            // 
            this.dt_dau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dau.Location = new System.Drawing.Point(146, 94);
            this.dt_dau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_dau.Name = "dt_dau";
            this.dt_dau.Size = new System.Drawing.Size(164, 22);
            this.dt_dau.TabIndex = 6;
            // 
            // rdb_chonkhoang
            // 
            this.rdb_chonkhoang.AutoSize = true;
            this.rdb_chonkhoang.Location = new System.Drawing.Point(8, 94);
            this.rdb_chonkhoang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdb_chonkhoang.Name = "rdb_chonkhoang";
            this.rdb_chonkhoang.Size = new System.Drawing.Size(14, 13);
            this.rdb_chonkhoang.TabIndex = 7;
            this.rdb_chonkhoang.UseVisualStyleBackColor = true;
            // 
            // dt_sau
            // 
            this.dt_sau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_sau.Location = new System.Drawing.Point(445, 94);
            this.dt_sau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_sau.Name = "dt_sau";
            this.dt_sau.Size = new System.Drawing.Size(164, 22);
            this.dt_sau.TabIndex = 8;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(209, 148);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(197, 31);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search by id";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(2, 153);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(183, 26);
            this.txt_search.TabIndex = 12;
            // 
            // bn_capnhat
            // 
            this.bn_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bn_capnhat.ForeColor = System.Drawing.Color.Black;
            this.bn_capnhat.Location = new System.Drawing.Point(724, 18);
            this.bn_capnhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bn_capnhat.Name = "bn_capnhat";
            this.bn_capnhat.Size = new System.Drawing.Size(190, 112);
            this.bn_capnhat.TabIndex = 7;
            this.bn_capnhat.Text = "Cập nhật ca nhân viên";
            this.bn_capnhat.UseVisualStyleBackColor = true;
            this.bn_capnhat.Click += new System.EventHandler(this.bn_capnhat_Click);
            // 
            // frmdanhsachca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(923, 731);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.bn_capnhat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmdanhsachca";
            this.Text = "danh sách ca";
            this.Load += new System.EventHandler(this.frmchiaca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dt_ngay;
        private System.Windows.Forms.RadioButton rdb_tatca;
        private System.Windows.Forms.RadioButton rdb_chonngay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dt_dau;
        private System.Windows.Forms.Button bn_capnhat;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdb_chonkhoang;
        private System.Windows.Forms.DateTimePicker dt_sau;
    }
}