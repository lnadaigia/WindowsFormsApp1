namespace WindowsFormsApp1
{
    partial class frmthongtin
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
            this.btn_doimk = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_namsinh = new System.Windows.Forms.DateTimePicker();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idql = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hovaten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_quanli = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_doimk
            // 
            this.btn_doimk.ForeColor = System.Drawing.Color.Black;
            this.btn_doimk.Location = new System.Drawing.Point(195, 415);
            this.btn_doimk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(111, 63);
            this.btn_doimk.TabIndex = 40;
            this.btn_doimk.Text = "Đổi mật khẩu";
            this.btn_doimk.UseVisualStyleBackColor = true;
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(364, 69);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(112, 35);
            this.btn_sua.TabIndex = 39;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "id ";
            // 
            // dt_namsinh
            // 
            this.dt_namsinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_namsinh.Location = new System.Drawing.Point(177, 188);
            this.dt_namsinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dt_namsinh.Name = "dt_namsinh";
            this.dt_namsinh.Size = new System.Drawing.Size(182, 26);
            this.dt_namsinh.TabIndex = 37;
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(177, 312);
            this.txt_cmnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(148, 26);
            this.txt_cmnd.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 317);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cmnd";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(174, 248);
            this.txt_sdt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(148, 26);
            this.txt_sdt.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Sdt";
            // 
            // txt_idql
            // 
            this.txt_idql.Location = new System.Drawing.Point(177, 69);
            this.txt_idql.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_idql.Name = "txt_idql";
            this.txt_idql.ReadOnly = true;
            this.txt_idql.Size = new System.Drawing.Size(148, 26);
            this.txt_idql.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Năm sinh";
            // 
            // txt_hovaten
            // 
            this.txt_hovaten.Location = new System.Drawing.Point(177, 129);
            this.txt_hovaten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_hovaten.Name = "txt_hovaten";
            this.txt_hovaten.Size = new System.Drawing.Size(284, 26);
            this.txt_hovaten.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Họ và tên";
            // 
            // lb_quanli
            // 
            this.lb_quanli.AutoSize = true;
            this.lb_quanli.Location = new System.Drawing.Point(57, 20);
            this.lb_quanli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_quanli.Name = "lb_quanli";
            this.lb_quanli.Size = new System.Drawing.Size(74, 20);
            this.lb_quanli.TabIndex = 41;
            this.lb_quanli.Text = "Chức vụ: ";
            // 
            // frmthongtin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(566, 505);
            this.Controls.Add(this.lb_quanli);
            this.Controls.Add(this.btn_doimk);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dt_namsinh);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_idql);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_hovaten);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmthongtin";
            this.Text = "frmthongtin";
            this.Load += new System.EventHandler(this.frmthongtin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_doimk;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_namsinh;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idql;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_hovaten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_quanli;
    }
}