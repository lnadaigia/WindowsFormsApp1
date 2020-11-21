namespace WindowsFormsApp1
{
    partial class frmdoimk
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mkcu = new System.Windows.Forms.TextBox();
            this.btn_doimk = new System.Windows.Forms.Button();
            this.txt_mkmoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mkmoi2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cancer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txt_mkcu
            // 
            this.txt_mkcu.Location = new System.Drawing.Point(212, 38);
            this.txt_mkcu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mkcu.Name = "txt_mkcu";
            this.txt_mkcu.Size = new System.Drawing.Size(148, 26);
            this.txt_mkcu.TabIndex = 1;
            this.txt_mkcu.UseSystemPasswordChar = true;
            // 
            // btn_doimk
            // 
            this.btn_doimk.ForeColor = System.Drawing.Color.Black;
            this.btn_doimk.Location = new System.Drawing.Point(36, 225);
            this.btn_doimk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(141, 35);
            this.btn_doimk.TabIndex = 2;
            this.btn_doimk.Text = "Đổi mật khẩu";
            this.btn_doimk.UseVisualStyleBackColor = true;
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // txt_mkmoi
            // 
            this.txt_mkmoi.Location = new System.Drawing.Point(212, 94);
            this.txt_mkmoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mkmoi.Name = "txt_mkmoi";
            this.txt_mkmoi.Size = new System.Drawing.Size(148, 26);
            this.txt_mkmoi.TabIndex = 4;
            this.txt_mkmoi.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txt_mkmoi2
            // 
            this.txt_mkmoi2.Location = new System.Drawing.Point(212, 146);
            this.txt_mkmoi2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_mkmoi2.Name = "txt_mkmoi2";
            this.txt_mkmoi2.Size = new System.Drawing.Size(148, 26);
            this.txt_mkmoi2.TabIndex = 6;
            this.txt_mkmoi2.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // btn_cancer
            // 
            this.btn_cancer.ForeColor = System.Drawing.Color.Black;
            this.btn_cancer.Location = new System.Drawing.Point(249, 225);
            this.btn_cancer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancer.Name = "btn_cancer";
            this.btn_cancer.Size = new System.Drawing.Size(112, 35);
            this.btn_cancer.TabIndex = 7;
            this.btn_cancer.Text = "Cancer";
            this.btn_cancer.UseVisualStyleBackColor = true;
            this.btn_cancer.Click += new System.EventHandler(this.btn_cancer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 8;
            // 
            // frmdoimk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(435, 289);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancer);
            this.Controls.Add(this.txt_mkmoi2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mkmoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_doimk);
            this.Controls.Add(this.txt_mkcu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmdoimk";
            this.Text = "frmdoimk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mkcu;
        private System.Windows.Forms.Button btn_doimk;
        private System.Windows.Forms.TextBox txt_mkmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mkmoi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cancer;
        private System.Windows.Forms.Label label4;
    }
}