namespace WindowsFormsApp1
{
    partial class frmdsdoan
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.btn_themdoan = new System.Windows.Forms.Button();
			this.btn_xoadoan = new System.Windows.Forms.Button();
			this.btn_suadoan = new System.Windows.Forms.Button();
			this.txt_tendoan = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_giadoan = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_gianl = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_tennl = new System.Windows.Forms.TextBox();
			this.btn_suanl = new System.Windows.Forms.Button();
			this.btn_xoanl = new System.Windows.Forms.Button();
			this.btn_themnl = new System.Windows.Forms.Button();
			this.btn_chinhsua = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(0, 1);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(360, 194);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(395, 1);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(549, 194);
			this.dataGridView2.TabIndex = 1;
			this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
			// 
			// btn_themdoan
			// 
			this.btn_themdoan.Location = new System.Drawing.Point(220, 330);
			this.btn_themdoan.Name = "btn_themdoan";
			this.btn_themdoan.Size = new System.Drawing.Size(87, 23);
			this.btn_themdoan.TabIndex = 2;
			this.btn_themdoan.Text = "thêm đồ ăn";
			this.btn_themdoan.UseVisualStyleBackColor = true;
			this.btn_themdoan.Click += new System.EventHandler(this.btn_themdoan_Click);
			// 
			// btn_xoadoan
			// 
			this.btn_xoadoan.Location = new System.Drawing.Point(115, 330);
			this.btn_xoadoan.Name = "btn_xoadoan";
			this.btn_xoadoan.Size = new System.Drawing.Size(87, 23);
			this.btn_xoadoan.TabIndex = 4;
			this.btn_xoadoan.Text = "xóa đồ ăn";
			this.btn_xoadoan.UseVisualStyleBackColor = true;
			this.btn_xoadoan.Click += new System.EventHandler(this.btn_xoadoan_Click);
			// 
			// btn_suadoan
			// 
			this.btn_suadoan.Location = new System.Drawing.Point(10, 330);
			this.btn_suadoan.Name = "btn_suadoan";
			this.btn_suadoan.Size = new System.Drawing.Size(87, 23);
			this.btn_suadoan.TabIndex = 5;
			this.btn_suadoan.Text = "sửa đồ ăn";
			this.btn_suadoan.UseVisualStyleBackColor = true;
			this.btn_suadoan.Click += new System.EventHandler(this.btn_suadoan_Click);
			// 
			// txt_tendoan
			// 
			this.txt_tendoan.Location = new System.Drawing.Point(101, 216);
			this.txt_tendoan.Name = "txt_tendoan";
			this.txt_tendoan.Size = new System.Drawing.Size(100, 20);
			this.txt_tendoan.TabIndex = 6;
			this.txt_tendoan.Validating += new System.ComponentModel.CancelEventHandler(this.txt_tennl_Validating);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 221);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "tên đồ ăn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 265);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "giá";
			// 
			// txt_giadoan
			// 
			this.txt_giadoan.Location = new System.Drawing.Point(101, 260);
			this.txt_giadoan.Name = "txt_giadoan";
			this.txt_giadoan.Size = new System.Drawing.Size(100, 20);
			this.txt_giadoan.TabIndex = 8;
			this.txt_giadoan.Validating += new System.ComponentModel.CancelEventHandler(this.txt_tennl_Validating);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(595, 260);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "giá";
			// 
			// txt_gianl
			// 
			this.txt_gianl.Location = new System.Drawing.Point(709, 253);
			this.txt_gianl.Name = "txt_gianl";
			this.txt_gianl.Size = new System.Drawing.Size(100, 20);
			this.txt_gianl.TabIndex = 15;
			this.txt_gianl.Validating += new System.ComponentModel.CancelEventHandler(this.txt_tennl_Validating);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(595, 216);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "tên nguyên liệu";
			// 
			// txt_tennl
			// 
			this.txt_tennl.Location = new System.Drawing.Point(709, 213);
			this.txt_tennl.Name = "txt_tennl";
			this.txt_tennl.Size = new System.Drawing.Size(100, 20);
			this.txt_tennl.TabIndex = 13;
			this.txt_tennl.Validating += new System.ComponentModel.CancelEventHandler(this.txt_tennl_Validating);
			// 
			// btn_suanl
			// 
			this.btn_suanl.Location = new System.Drawing.Point(563, 325);
			this.btn_suanl.Name = "btn_suanl";
			this.btn_suanl.Size = new System.Drawing.Size(87, 23);
			this.btn_suanl.TabIndex = 12;
			this.btn_suanl.Text = "sửa nguyên liệu";
			this.btn_suanl.UseVisualStyleBackColor = true;
			this.btn_suanl.Click += new System.EventHandler(this.btn_suanl_Click);
			// 
			// btn_xoanl
			// 
			this.btn_xoanl.Location = new System.Drawing.Point(668, 325);
			this.btn_xoanl.Name = "btn_xoanl";
			this.btn_xoanl.Size = new System.Drawing.Size(87, 23);
			this.btn_xoanl.TabIndex = 11;
			this.btn_xoanl.Text = "xóa nguyên liêu";
			this.btn_xoanl.UseVisualStyleBackColor = true;
			this.btn_xoanl.Click += new System.EventHandler(this.btn_xoanl_Click);
			// 
			// btn_themnl
			// 
			this.btn_themnl.Location = new System.Drawing.Point(773, 325);
			this.btn_themnl.Name = "btn_themnl";
			this.btn_themnl.Size = new System.Drawing.Size(87, 23);
			this.btn_themnl.TabIndex = 10;
			this.btn_themnl.Text = "thêm nguyên liệu";
			this.btn_themnl.UseVisualStyleBackColor = true;
			this.btn_themnl.Click += new System.EventHandler(this.txt_themnl_Click);
			// 
			// btn_chinhsua
			// 
			this.btn_chinhsua.Location = new System.Drawing.Point(347, 395);
			this.btn_chinhsua.Name = "btn_chinhsua";
			this.btn_chinhsua.Size = new System.Drawing.Size(175, 23);
			this.btn_chinhsua.TabIndex = 17;
			this.btn_chinhsua.Text = "chỉnh sủa công thức";
			this.btn_chinhsua.UseVisualStyleBackColor = true;
			this.btn_chinhsua.Click += new System.EventHandler(this.btn_chinhsua_Click);
			// 
			// frmdsdoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(946, 450);
			this.Controls.Add(this.btn_chinhsua);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_gianl);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt_tennl);
			this.Controls.Add(this.btn_suanl);
			this.Controls.Add(this.btn_xoanl);
			this.Controls.Add(this.btn_themnl);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_giadoan);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_tendoan);
			this.Controls.Add(this.btn_suadoan);
			this.Controls.Add(this.btn_xoadoan);
			this.Controls.Add(this.btn_themdoan);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Name = "frmdsdoan";
			this.Text = "frmthemdoan_nguyenlieu";
			this.Load += new System.EventHandler(this.frmthemdoan_nguyenlieu_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_themdoan;
        private System.Windows.Forms.Button btn_xoadoan;
        private System.Windows.Forms.Button btn_suadoan;
        private System.Windows.Forms.TextBox txt_tendoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_giadoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_gianl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tennl;
        private System.Windows.Forms.Button btn_suanl;
        private System.Windows.Forms.Button btn_xoanl;
        private System.Windows.Forms.Button btn_themnl;
        private System.Windows.Forms.Button btn_chinhsua;
    }
}