namespace WindowsFormsApp1
{
    partial class frmthongke
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmthongke));
            Bunifu.Framework.UI.BunifuDatepicker dt_sau;
            Bunifu.Framework.UI.BunifuDatepicker dt_dau;
            Bunifu.Framework.UI.BunifuDatepicker dt_ngay;
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rdb_soluong = new System.Windows.Forms.RadioButton();
            this.rdb_gia = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdb_chonthang = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_chonkhoang = new System.Windows.Forms.RadioButton();
            this.rdb_chonngay = new System.Windows.Forms.RadioButton();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_check = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            dt_sau = new Bunifu.Framework.UI.BunifuDatepicker();
            dt_dau = new Bunifu.Framework.UI.BunifuDatepicker();
            dt_ngay = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 152);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Salary";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(595, 335);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(621, 152);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Salary";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(405, 267);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // rdb_soluong
            // 
            this.rdb_soluong.AutoSize = true;
            this.rdb_soluong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_soluong.ForeColor = System.Drawing.Color.White;
            this.rdb_soluong.Location = new System.Drawing.Point(4, 47);
            this.rdb_soluong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_soluong.Name = "rdb_soluong";
            this.rdb_soluong.Size = new System.Drawing.Size(138, 27);
            this.rdb_soluong.TabIndex = 2;
            this.rdb_soluong.Text = "theo số lượng";
            this.rdb_soluong.UseVisualStyleBackColor = true;
            // 
            // rdb_gia
            // 
            this.rdb_gia.AutoSize = true;
            this.rdb_gia.Checked = true;
            this.rdb_gia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_gia.ForeColor = System.Drawing.Color.White;
            this.rdb_gia.Location = new System.Drawing.Point(4, 5);
            this.rdb_gia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_gia.Name = "rdb_gia";
            this.rdb_gia.Size = new System.Drawing.Size(94, 27);
            this.rdb_gia.TabIndex = 3;
            this.rdb_gia.TabStop = true;
            this.rdb_gia.Text = "theo giá";
            this.rdb_gia.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuDropdown1);
            this.panel2.Controls.Add(dt_sau);
            this.panel2.Controls.Add(dt_dau);
            this.panel2.Controls.Add(dt_ngay);
            this.panel2.Controls.Add(this.rdb_chonthang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rdb_chonkhoang);
            this.panel2.Controls.Add(this.rdb_chonngay);
            this.panel2.Location = new System.Drawing.Point(172, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 149);
            this.panel2.TabIndex = 11;
            // 
            // rdb_chonthang
            // 
            this.rdb_chonthang.AutoSize = true;
            this.rdb_chonthang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_chonthang.ForeColor = System.Drawing.Color.White;
            this.rdb_chonthang.Location = new System.Drawing.Point(17, 100);
            this.rdb_chonthang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_chonthang.Name = "rdb_chonthang";
            this.rdb_chonthang.Size = new System.Drawing.Size(119, 27);
            this.rdb_chonthang.TabIndex = 11;
            this.rdb_chonthang.Text = "chọn tháng";
            this.rdb_chonthang.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(347, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "đến";
            // 
            // rdb_chonkhoang
            // 
            this.rdb_chonkhoang.AutoSize = true;
            this.rdb_chonkhoang.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_chonkhoang.ForeColor = System.Drawing.Color.White;
            this.rdb_chonkhoang.Location = new System.Drawing.Point(17, 53);
            this.rdb_chonkhoang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_chonkhoang.Name = "rdb_chonkhoang";
            this.rdb_chonkhoang.Size = new System.Drawing.Size(132, 27);
            this.rdb_chonkhoang.TabIndex = 7;
            this.rdb_chonkhoang.Text = "chọn khoảng";
            this.rdb_chonkhoang.UseVisualStyleBackColor = true;
            // 
            // rdb_chonngay
            // 
            this.rdb_chonngay.AutoSize = true;
            this.rdb_chonngay.Checked = true;
            this.rdb_chonngay.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_chonngay.ForeColor = System.Drawing.Color.White;
            this.rdb_chonngay.Location = new System.Drawing.Point(17, 4);
            this.rdb_chonngay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdb_chonngay.Name = "rdb_chonngay";
            this.rdb_chonngay.Size = new System.Drawing.Size(112, 27);
            this.rdb_chonngay.TabIndex = 4;
            this.rdb_chonngay.TabStop = true;
            this.rdb_chonngay.Text = "chọn ngày";
            this.rdb_chonngay.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(621, 427);
            this.chart3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Salary";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(405, 240);
            this.chart3.TabIndex = 12;
            this.chart3.Text = "chart3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(232, 495);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(367, 185);
            this.dataGridView1.TabIndex = 13;
            // 
            // btn_check
            // 
            this.btn_check.ActiveBorderThickness = 1;
            this.btn_check.ActiveCornerRadius = 35;
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
            this.btn_check.IdleCornerRadius = 35;
            this.btn_check.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_check.IdleForecolor = System.Drawing.Color.White;
            this.btn_check.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_check.Location = new System.Drawing.Point(873, 29);
            this.btn_check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(121, 56);
            this.btn_check.TabIndex = 59;
            this.btn_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dt_sau
            // 
            dt_sau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            dt_sau.BorderRadius = 45;
            dt_sau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dt_sau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            dt_sau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dt_sau.FormatCustom = null;
            dt_sau.Location = new System.Drawing.Point(405, 52);
            dt_sau.Margin = new System.Windows.Forms.Padding(5);
            dt_sau.Name = "dt_sau";
            dt_sau.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_sau.Size = new System.Drawing.Size(170, 40);
            dt_sau.TabIndex = 59;
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
            dt_dau.Location = new System.Drawing.Point(158, 52);
            dt_dau.Margin = new System.Windows.Forms.Padding(5);
            dt_dau.Name = "dt_dau";
            dt_dau.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_dau.Size = new System.Drawing.Size(170, 40);
            dt_dau.TabIndex = 58;
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
            dt_ngay.Location = new System.Drawing.Point(196, 0);
            dt_ngay.Margin = new System.Windows.Forms.Padding(5);
            dt_ngay.Name = "dt_ngay";
            dt_ngay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dt_ngay.Size = new System.Drawing.Size(170, 40);
            dt_ngay.TabIndex = 57;
            dt_ngay.Value = new System.DateTime(2020, 12, 6, 18, 53, 56, 232);
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.bunifuDropdown1.BorderRadius = 45;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.bunifuDropdown1.Items = new string[0];
            this.bunifuDropdown1.Location = new System.Drawing.Point(172, 96);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(70, 43);
            this.bunifuDropdown1.TabIndex = 60;
            // 
            // frmthongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1091, 706);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rdb_gia);
            this.Controls.Add(this.rdb_soluong);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmthongke";
            this.Text = "frmthongke";
            this.Load += new System.EventHandler(this.frmthongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.RadioButton rdb_soluong;
        private System.Windows.Forms.RadioButton rdb_gia;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_chonkhoang;
        private System.Windows.Forms.RadioButton rdb_chonngay;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.RadioButton rdb_chonthang;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_check;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
    }
}