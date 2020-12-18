namespace WindowsFormsApp1
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_pass = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_login = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(108, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_user.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.White;
            this.txt_user.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_user.Location = new System.Drawing.Point(105, 241);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(243, 31);
            this.txt_user.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.panel2.Location = new System.Drawing.Point(105, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 1);
            this.panel2.TabIndex = 70;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.White;
            this.txt_pass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_pass.Location = new System.Drawing.Point(105, 324);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(243, 31);
            this.txt_pass.TabIndex = 73;
            //this.txt_pass.Enter += new System.EventHandler(this.btn_login_Click_1);
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.panel3.Location = new System.Drawing.Point(105, 357);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 1);
            this.panel3.TabIndex = 72;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 167);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancer
            // 
            this.btn_cancer.ActiveBorderThickness = 1;
            this.btn_cancer.ActiveCornerRadius = 40;
            this.btn_cancer.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cancer.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_cancer.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_cancer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_cancer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancer.BackgroundImage")));
            this.btn_cancer.ButtonText = "Cancel";
            this.btn_cancer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancer.ForeColor = System.Drawing.Color.White;
            this.btn_cancer.IdleBorderThickness = 1;
            this.btn_cancer.IdleCornerRadius = 40;
            this.btn_cancer.IdleFillColor = System.Drawing.Color.White;
            this.btn_cancer.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_cancer.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_cancer.Location = new System.Drawing.Point(241, 396);
            this.btn_cancer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cancer.Name = "btn_cancer";
            this.btn_cancer.Size = new System.Drawing.Size(131, 60);
            this.btn_cancer.TabIndex = 105;
            this.btn_cancer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancer.Click += new System.EventHandler(this.btn_cancer_Click_1);
            // 
            // btn_login
            // 
            this.btn_login.ActiveBorderThickness = 1;
            this.btn_login.ActiveCornerRadius = 40;
            this.btn_login.ActiveFillColor = System.Drawing.Color.White;
            this.btn_login.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_login.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleCornerRadius = 40;
            this.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_login.IdleForecolor = System.Drawing.Color.White;
            this.btn_login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_login.Location = new System.Drawing.Point(82, 396);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(131, 60);
            this.btn_login.TabIndex = 104;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            this.btn_login.Enter += new System.EventHandler(this.btn_cancer_Click_1);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(450, 536);
            this.Controls.Add(this.btn_cancer);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_user;
        private System.Windows.Forms.Panel panel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_pass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_cancer;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_login;
    }
}