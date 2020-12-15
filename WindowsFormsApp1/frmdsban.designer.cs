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
            this.ban1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAddTabel = new System.Windows.Forms.Button();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ban1)).BeginInit();
            this.SuspendLayout();
            // 
            // ban1
            // 
            this.ban1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(57)))), ((int)(((byte)(248)))));
            this.ban1.Image = ((System.Drawing.Image)(resources.GetObject("ban1.Image")));
            this.ban1.ImageActive = null;
            this.ban1.Location = new System.Drawing.Point(682, 355);
            this.ban1.Margin = new System.Windows.Forms.Padding(2);
            this.ban1.Name = "ban1";
            this.ban1.Size = new System.Drawing.Size(75, 81);
            this.ban1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ban1.TabIndex = 1;
            this.ban1.TabStop = false;
            this.ban1.Zoom = 5;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(701, 452);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(47, 21);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Bàn 1";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(621, 99);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(82, 29);
            this.btRefresh.TabIndex = 14;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDelete.Location = new System.Drawing.Point(621, 52);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(82, 29);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "Delete Table ";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAddTabel
            // 
            this.btAddTabel.BackColor = System.Drawing.Color.PeachPuff;
            this.btAddTabel.Location = new System.Drawing.Point(621, 9);
            this.btAddTabel.Margin = new System.Windows.Forms.Padding(2);
            this.btAddTabel.Name = "btAddTabel";
            this.btAddTabel.Size = new System.Drawing.Size(82, 29);
            this.btAddTabel.TabIndex = 12;
            this.btAddTabel.Text = "Add Table";
            this.btAddTabel.UseVisualStyleBackColor = false;
            this.btAddTabel.Click += new System.EventHandler(this.btAddTabel_Click);
            // 
            // flp
            // 
            this.flp.Location = new System.Drawing.Point(-3, 1);
            this.flp.Margin = new System.Windows.Forms.Padding(2);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(611, 435);
            this.flp.TabIndex = 11;
            // 
            // frmdsban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 493);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddTabel);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.ban1);
            this.Name = "frmdsban";
            this.Text = "frmgiaodienchinh";
            this.Load += new System.EventHandler(this.frmgiaodienchinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ban1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton ban1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAddTabel;
        public System.Windows.Forms.FlowLayoutPanel flp;
    }
}