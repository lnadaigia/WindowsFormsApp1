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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdsban));
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_them = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_xoa = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btn_refr = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.Location = new System.Drawing.Point(-4, 1);
            this.flp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(815, 535);
            this.flp.TabIndex = 11;
            // 
            // btn_them
            // 
            this.btn_them.ActiveBorderThickness = 1;
            this.btn_them.ActiveCornerRadius = 40;
            this.btn_them.ActiveFillColor = System.Drawing.Color.White;
            this.btn_them.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_them.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_them.BackgroundImage")));
            this.btn_them.ButtonText = "Thêm";
            this.btn_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.IdleBorderThickness = 1;
            this.btn_them.IdleCornerRadius = 40;
            this.btn_them.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.IdleForecolor = System.Drawing.Color.White;
            this.btn_them.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_them.Location = new System.Drawing.Point(818, 1);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(160, 60);
            this.btn_them.TabIndex = 78;
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.ActiveBorderThickness = 1;
            this.btn_xoa.ActiveCornerRadius = 40;
            this.btn_xoa.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_xoa.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_xoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_xoa.BackgroundImage")));
            this.btn_xoa.ButtonText = "Xóa";
            this.btn_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.IdleBorderThickness = 1;
            this.btn_xoa.IdleCornerRadius = 40;
            this.btn_xoa.IdleFillColor = System.Drawing.Color.White;
            this.btn_xoa.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_xoa.Location = new System.Drawing.Point(818, 71);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(160, 60);
            this.btn_xoa.TabIndex = 79;
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_refr
            // 
            this.btn_refr.ActiveBorderThickness = 1;
            this.btn_refr.ActiveCornerRadius = 40;
            this.btn_refr.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_refr.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_refr.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_refr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btn_refr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refr.BackgroundImage")));
            this.btn_refr.ButtonText = "Refresh";
            this.btn_refr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refr.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refr.ForeColor = System.Drawing.Color.White;
            this.btn_refr.IdleBorderThickness = 1;
            this.btn_refr.IdleCornerRadius = 40;
            this.btn_refr.IdleFillColor = System.Drawing.Color.White;
            this.btn_refr.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_refr.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.btn_refr.Location = new System.Drawing.Point(818, 141);
            this.btn_refr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_refr.Name = "btn_refr";
            this.btn_refr.Size = new System.Drawing.Size(160, 60);
            this.btn_refr.TabIndex = 80;
            this.btn_refr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_refr.Click += new System.EventHandler(this.btn_refr_Click);
            // 
            // frmdsban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 607);
            this.Controls.Add(this.btn_refr);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.flp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmdsban";
            this.Text = "frmgiaodienchinh";
            this.Load += new System.EventHandler(this.frmgiaodienchinh_Load);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.FlowLayoutPanel flp;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_them;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_xoa;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_refr;
    }
}