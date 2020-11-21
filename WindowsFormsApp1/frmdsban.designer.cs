namespace WindowsFormsApp1
{
    partial class frmdsban
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(-2, 37);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(100, 40);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "bàn số 1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(164, 128);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(100, 40);
            this.btn_5.TabIndex = 1;
            this.btn_5.Text = "bàn số 5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(-2, 128);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(100, 40);
            this.btn_4.TabIndex = 2;
            this.btn_4.Text = "bàn số 4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(348, 37);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(100, 40);
            this.btn_3.TabIndex = 3;
            this.btn_3.Text = "bàn số 3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(164, 37);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(100, 40);
            this.btn_2.TabIndex = 4;
            this.btn_2.Text = "bàn số 2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // frmgiaodienchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 302);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_1);
            this.Name = "frmgiaodienchinh";
            this.Text = "frmgiaodienchinh";
            this.Load += new System.EventHandler(this.frmgiaodienchinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
    }
}