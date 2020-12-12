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
            this.btRefresh = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAddTabel = new System.Windows.Forms.Button();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(846, 136);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(110, 36);
            this.btRefresh.TabIndex = 10;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDelete.Location = new System.Drawing.Point(846, 78);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(110, 36);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Delete Table ";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAddTabel
            // 
            this.btAddTabel.BackColor = System.Drawing.Color.PeachPuff;
            this.btAddTabel.Location = new System.Drawing.Point(846, 24);
            this.btAddTabel.Name = "btAddTabel";
            this.btAddTabel.Size = new System.Drawing.Size(110, 36);
            this.btAddTabel.TabIndex = 8;
            this.btAddTabel.Text = "Add Table";
            this.btAddTabel.UseVisualStyleBackColor = false;
            this.btAddTabel.Click += new System.EventHandler(this.btAddTabel_Click);
            // 
            // flp
            // 
            this.flp.Location = new System.Drawing.Point(13, 15);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(797, 522);
            this.flp.TabIndex = 7;
            // 
            // frmdsban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(992, 563);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAddTabel);
            this.Controls.Add(this.flp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmdsban";
            this.Text = "frmgiaodienchinh";
            this.Load += new System.EventHandler(this.frmgiaodienchinh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAddTabel;
        public System.Windows.Forms.FlowLayoutPanel flp;
    }
}