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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rdb_soluong = new System.Windows.Forms.RadioButton();
            this.rdb_gia = new System.Windows.Forms.RadioButton();
            this.btn_check = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rdb_chonthang = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_ngay = new System.Windows.Forms.DateTimePicker();
            this.dt_sau = new System.Windows.Forms.DateTimePicker();
            this.rdb_chonkhoang = new System.Windows.Forms.RadioButton();
            this.rdb_chonngay = new System.Windows.Forms.RadioButton();
            this.dt_dau = new System.Windows.Forms.DateTimePicker();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 110);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Salary";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(446, 272);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(466, 110);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Salary";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(304, 217);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // rdb_soluong
            // 
            this.rdb_soluong.AutoSize = true;
            this.rdb_soluong.Location = new System.Drawing.Point(3, 38);
            this.rdb_soluong.Name = "rdb_soluong";
            this.rdb_soluong.Size = new System.Drawing.Size(89, 17);
            this.rdb_soluong.TabIndex = 2;
            this.rdb_soluong.Text = "theo số lượng";
            this.rdb_soluong.UseVisualStyleBackColor = true;
            // 
            // rdb_gia
            // 
            this.rdb_gia.AutoSize = true;
            this.rdb_gia.Checked = true;
            this.rdb_gia.Location = new System.Drawing.Point(3, 4);
            this.rdb_gia.Name = "rdb_gia";
            this.rdb_gia.Size = new System.Drawing.Size(63, 17);
            this.rdb_gia.TabIndex = 3;
            this.rdb_gia.TabStop = true;
            this.rdb_gia.Text = "theo giá";
            this.rdb_gia.UseVisualStyleBackColor = true;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(651, 23);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 23);
            this.btn_check.TabIndex = 4;
            this.btn_check.Text = "check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.rdb_chonthang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dt_ngay);
            this.panel2.Controls.Add(this.dt_sau);
            this.panel2.Controls.Add(this.rdb_chonkhoang);
            this.panel2.Controls.Add(this.rdb_chonngay);
            this.panel2.Controls.Add(this.dt_dau);
            this.panel2.Location = new System.Drawing.Point(129, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 95);
            this.panel2.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // rdb_chonthang
            // 
            this.rdb_chonthang.AutoSize = true;
            this.rdb_chonthang.Location = new System.Drawing.Point(13, 75);
            this.rdb_chonthang.Name = "rdb_chonthang";
            this.rdb_chonthang.Size = new System.Drawing.Size(79, 17);
            this.rdb_chonthang.TabIndex = 11;
            this.rdb_chonthang.Text = "chọn tháng";
            this.rdb_chonthang.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "đến";
            // 
            // dt_ngay
            // 
            this.dt_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngay.Location = new System.Drawing.Point(123, 3);
            this.dt_ngay.Name = "dt_ngay";
            this.dt_ngay.Size = new System.Drawing.Size(108, 20);
            this.dt_ngay.TabIndex = 6;
            // 
            // dt_sau
            // 
            this.dt_sau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_sau.Location = new System.Drawing.Point(314, 40);
            this.dt_sau.Name = "dt_sau";
            this.dt_sau.Size = new System.Drawing.Size(126, 20);
            this.dt_sau.TabIndex = 9;
            // 
            // rdb_chonkhoang
            // 
            this.rdb_chonkhoang.AutoSize = true;
            this.rdb_chonkhoang.Location = new System.Drawing.Point(13, 43);
            this.rdb_chonkhoang.Name = "rdb_chonkhoang";
            this.rdb_chonkhoang.Size = new System.Drawing.Size(88, 17);
            this.rdb_chonkhoang.TabIndex = 7;
            this.rdb_chonkhoang.Text = "chọn khoảng";
            this.rdb_chonkhoang.UseVisualStyleBackColor = true;
            // 
            // rdb_chonngay
            // 
            this.rdb_chonngay.AutoSize = true;
            this.rdb_chonngay.Checked = true;
            this.rdb_chonngay.Location = new System.Drawing.Point(13, 3);
            this.rdb_chonngay.Name = "rdb_chonngay";
            this.rdb_chonngay.Size = new System.Drawing.Size(75, 17);
            this.rdb_chonngay.TabIndex = 4;
            this.rdb_chonngay.TabStop = true;
            this.rdb_chonngay.Text = "chọn ngày";
            this.rdb_chonngay.UseVisualStyleBackColor = true;
            // 
            // dt_dau
            // 
            this.dt_dau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dau.Location = new System.Drawing.Point(123, 40);
            this.dt_dau.Name = "dt_dau";
            this.dt_dau.Size = new System.Drawing.Size(108, 20);
            this.dt_dau.TabIndex = 8;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(466, 333);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Salary";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(304, 195);
            this.chart3.TabIndex = 12;
            this.chart3.Text = "chart3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 388);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(275, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // frmthongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.rdb_gia);
            this.Controls.Add(this.rdb_soluong);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
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
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_ngay;
        private System.Windows.Forms.DateTimePicker dt_sau;
        private System.Windows.Forms.RadioButton rdb_chonkhoang;
        private System.Windows.Forms.RadioButton rdb_chonngay;
        private System.Windows.Forms.DateTimePicker dt_dau;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rdb_chonthang;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}