namespace WindowsFormsApp1
{
    partial class frmquanli
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lb_ca = new System.Windows.Forms.Label();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.lb_quanli = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_gio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(90, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(772, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // lb_ca
            // 
            this.lb_ca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ca.AutoSize = true;
            this.lb_ca.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ca.Location = new System.Drawing.Point(73, 36);
            this.lb_ca.Name = "lb_ca";
            this.lb_ca.Size = new System.Drawing.Size(68, 31);
            this.lb_ca.TabIndex = 30;
            this.lb_ca.Text = "Ca: ";
            // 
            // lb_ngay
            // 
            this.lb_ngay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_ngay.AutoSize = true;
            this.lb_ngay.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngay.Location = new System.Drawing.Point(77, 25);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(122, 42);
            this.lb_ngay.TabIndex = 29;
            this.lb_ngay.Text = "Ngày: ";
            // 
            // lb_quanli
            // 
            this.lb_quanli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_quanli.AutoSize = true;
            this.lb_quanli.BackColor = System.Drawing.Color.LimeGreen;
            this.lb_quanli.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quanli.Location = new System.Drawing.Point(14, 31);
            this.lb_quanli.Name = "lb_quanli";
            this.lb_quanli.Size = new System.Drawing.Size(464, 31);
            this.lb_quanli.TabIndex = 33;
            this.lb_quanli.Text = "Danh sách nhân viên trong ca làm:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_gio
            // 
            this.lb_gio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_gio.AutoSize = true;
            this.lb_gio.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_gio.Location = new System.Drawing.Point(73, 25);
            this.lb_gio.Name = "lb_gio";
            this.lb_gio.Size = new System.Drawing.Size(88, 42);
            this.lb_gio.TabIndex = 34;
            this.lb_gio.Text = "giờ: ";
            this.lb_gio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb_gio);
            this.panel1.Location = new System.Drawing.Point(377, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 74);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lb_ngay);
            this.panel2.Location = new System.Drawing.Point(26, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 74);
            this.panel2.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lb_ca);
            this.panel3.Location = new System.Drawing.Point(583, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(319, 74);
            this.panel3.TabIndex = 37;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lb_quanli);
            this.panel4.Location = new System.Drawing.Point(90, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(495, 74);
            this.panel4.TabIndex = 38;
            // 
            // frmquanli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(971, 457);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmquanli";
            this.Text = "frmquanli";
            this.Load += new System.EventHandler(this.frmquanli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_ca;
        private System.Windows.Forms.Label lb_ngay;
        private System.Windows.Forms.Label lb_quanli;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_gio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
    }
}