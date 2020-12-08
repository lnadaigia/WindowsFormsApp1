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
            this.dtg_nguyenlieu_theongay = new System.Windows.Forms.DataGridView();
            this.btn_xemdonhang = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dtg_doan = new System.Windows.Forms.DataGridView();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nguyenlieu_theongay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doan)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_nguyenlieu_theongay
            // 
            this.dtg_nguyenlieu_theongay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_nguyenlieu_theongay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_nguyenlieu_theongay.Location = new System.Drawing.Point(-5, 183);
            this.dtg_nguyenlieu_theongay.Name = "dtg_nguyenlieu_theongay";
            this.dtg_nguyenlieu_theongay.Size = new System.Drawing.Size(552, 152);
            this.dtg_nguyenlieu_theongay.TabIndex = 2;
            // 
            // btn_xemdonhang
            // 
            this.btn_xemdonhang.Location = new System.Drawing.Point(554, 19);
            this.btn_xemdonhang.Name = "btn_xemdonhang";
            this.btn_xemdonhang.Size = new System.Drawing.Size(163, 23);
            this.btn_xemdonhang.TabIndex = 7;
            this.btn_xemdonhang.Text = "Thêm món ăn trong ngày";
            this.btn_xemdonhang.UseVisualStyleBackColor = true;
            this.btn_xemdonhang.Click += new System.EventHandler(this.btn_xemdonhang_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(471, 22);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dtg_doan
            // 
            this.dtg_doan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_doan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_doan.Location = new System.Drawing.Point(0, 0);
            this.dtg_doan.Name = "dtg_doan";
            this.dtg_doan.RowTemplate.Height = 20;
            this.dtg_doan.Size = new System.Drawing.Size(465, 120);
            this.dtg_doan.TabIndex = 5;
            this.dtg_doan.Click += new System.EventHandler(this.dtg_doan_Click);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(390, 363);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(159, 20);
            this.txt_tongtien.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng tiền: ";
            // 
            // btn_xoa
            // 
            this.btn_xoa.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_xoa.Location = new System.Drawing.Point(554, 57);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(163, 23);
            this.btn_xoa.TabIndex = 11;
            this.btn_xoa.Text = "Xóa món ăn trong ngày";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(554, 97);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(163, 23);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = "Sửa món ăn trong ngày";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // frmmuanguyenlieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 427);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_xemdonhang);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dtg_doan);
            this.Controls.Add(this.dtg_nguyenlieu_theongay);
            this.Name = "frmmuanguyenlieu";
            this.Text = "frmmuanguyenlieu";
            this.Load += new System.EventHandler(this.frmmuanguyenlieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_nguyenlieu_theongay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_nguyenlieu_theongay;
        private System.Windows.Forms.Button btn_xemdonhang;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dtg_doan;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
    }
}