namespace WindowsFormsApp1
{
    partial class frmmaunhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmaunhanvien));
            this.button1 = new System.Windows.Forms.Button();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.PictureBox();
            this.btn_dsmon = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_dsbill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_dsban = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_dsca = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_thongtincanhan = new System.Windows.Forms.PictureBox();
            this.pn_childform = new System.Windows.Forms.Panel();
            this.slidePic = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.img_3 = new System.Windows.Forms.RadioButton();
            this.img_2 = new System.Windows.Forms.RadioButton();
            this.img_1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pn_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_thongtincanhan)).BeginInit();
            this.pn_childform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 60);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.pn_menu.Controls.Add(this.indicator);
            this.pn_menu.Controls.Add(this.btn_dsmon);
            this.pn_menu.Controls.Add(this.btn_dsbill);
            this.pn_menu.Controls.Add(this.btn_dsban);
            this.pn_menu.Controls.Add(this.btn_dsca);
            this.pn_menu.Controls.Add(this.btn_home);
            this.pn_menu.Controls.Add(this.panel1);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Margin = new System.Windows.Forms.Padding(4);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(341, 733);
            this.pn_menu.TabIndex = 11;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(121)))), ((int)(((byte)(254)))));
            this.indicator.Location = new System.Drawing.Point(0, 111);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(4, 59);
            this.indicator.TabIndex = 2;
            this.indicator.TabStop = false;
            // 
            // btn_dsmon
            // 
            this.btn_dsmon.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsmon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsmon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dsmon.BorderRadius = 0;
            this.btn_dsmon.ButtonText = "           Danh sách món ăn hôm nay";
            this.btn_dsmon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dsmon.DisabledColor = System.Drawing.Color.Gray;
            this.btn_dsmon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsmon.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dsmon.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_dsmon.Iconimage")));
            this.btn_dsmon.Iconimage_right = null;
            this.btn_dsmon.Iconimage_right_Selected = null;
            this.btn_dsmon.Iconimage_Selected = null;
            this.btn_dsmon.IconMarginLeft = 0;
            this.btn_dsmon.IconMarginRight = 0;
            this.btn_dsmon.IconRightVisible = true;
            this.btn_dsmon.IconRightZoom = 0D;
            this.btn_dsmon.IconVisible = true;
            this.btn_dsmon.IconZoom = 40D;
            this.btn_dsmon.IsTab = false;
            this.btn_dsmon.Location = new System.Drawing.Point(0, 347);
            this.btn_dsmon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dsmon.Name = "btn_dsmon";
            this.btn_dsmon.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsmon.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsmon.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_dsmon.selected = false;
            this.btn_dsmon.Size = new System.Drawing.Size(341, 59);
            this.btn_dsmon.TabIndex = 18;
            this.btn_dsmon.Text = "           Danh sách món ăn hôm nay";
            this.btn_dsmon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dsmon.Textcolor = System.Drawing.Color.White;
            this.btn_dsmon.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsmon.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // btn_dsbill
            // 
            this.btn_dsbill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsbill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsbill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dsbill.BorderRadius = 0;
            this.btn_dsbill.ButtonText = "           Danh sách hóa đơn";
            this.btn_dsbill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dsbill.DisabledColor = System.Drawing.Color.Gray;
            this.btn_dsbill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsbill.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dsbill.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_dsbill.Iconimage")));
            this.btn_dsbill.Iconimage_right = null;
            this.btn_dsbill.Iconimage_right_Selected = null;
            this.btn_dsbill.Iconimage_Selected = null;
            this.btn_dsbill.IconMarginLeft = 0;
            this.btn_dsbill.IconMarginRight = 0;
            this.btn_dsbill.IconRightVisible = true;
            this.btn_dsbill.IconRightZoom = 0D;
            this.btn_dsbill.IconVisible = true;
            this.btn_dsbill.IconZoom = 40D;
            this.btn_dsbill.IsTab = false;
            this.btn_dsbill.Location = new System.Drawing.Point(0, 288);
            this.btn_dsbill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dsbill.Name = "btn_dsbill";
            this.btn_dsbill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsbill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsbill.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_dsbill.selected = false;
            this.btn_dsbill.Size = new System.Drawing.Size(341, 59);
            this.btn_dsbill.TabIndex = 17;
            this.btn_dsbill.Text = "           Danh sách hóa đơn";
            this.btn_dsbill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dsbill.Textcolor = System.Drawing.Color.White;
            this.btn_dsbill.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsbill.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // btn_dsban
            // 
            this.btn_dsban.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dsban.BorderRadius = 0;
            this.btn_dsban.ButtonText = "           Danh sách bàn ăn";
            this.btn_dsban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dsban.DisabledColor = System.Drawing.Color.Gray;
            this.btn_dsban.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsban.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dsban.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_dsban.Iconimage")));
            this.btn_dsban.Iconimage_right = null;
            this.btn_dsban.Iconimage_right_Selected = null;
            this.btn_dsban.Iconimage_Selected = null;
            this.btn_dsban.IconMarginLeft = 0;
            this.btn_dsban.IconMarginRight = 0;
            this.btn_dsban.IconRightVisible = true;
            this.btn_dsban.IconRightZoom = 0D;
            this.btn_dsban.IconVisible = true;
            this.btn_dsban.IconZoom = 43D;
            this.btn_dsban.IsTab = false;
            this.btn_dsban.Location = new System.Drawing.Point(0, 229);
            this.btn_dsban.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dsban.Name = "btn_dsban";
            this.btn_dsban.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsban.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsban.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_dsban.selected = false;
            this.btn_dsban.Size = new System.Drawing.Size(341, 59);
            this.btn_dsban.TabIndex = 16;
            this.btn_dsban.Text = "           Danh sách bàn ăn";
            this.btn_dsban.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dsban.Textcolor = System.Drawing.Color.White;
            this.btn_dsban.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsban.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // btn_dsca
            // 
            this.btn_dsca.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dsca.BorderRadius = 0;
            this.btn_dsca.ButtonText = "           Danh sách ca";
            this.btn_dsca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dsca.DisabledColor = System.Drawing.Color.Gray;
            this.btn_dsca.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dsca.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dsca.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_dsca.Iconimage")));
            this.btn_dsca.Iconimage_right = null;
            this.btn_dsca.Iconimage_right_Selected = null;
            this.btn_dsca.Iconimage_Selected = null;
            this.btn_dsca.IconMarginLeft = 0;
            this.btn_dsca.IconMarginRight = 0;
            this.btn_dsca.IconRightVisible = true;
            this.btn_dsca.IconRightZoom = 0D;
            this.btn_dsca.IconVisible = true;
            this.btn_dsca.IconZoom = 40D;
            this.btn_dsca.IsTab = false;
            this.btn_dsca.Location = new System.Drawing.Point(0, 170);
            this.btn_dsca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dsca.Name = "btn_dsca";
            this.btn_dsca.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsca.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_dsca.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_dsca.selected = false;
            this.btn_dsca.Size = new System.Drawing.Size(341, 59);
            this.btn_dsca.TabIndex = 15;
            this.btn_dsca.Text = "           Danh sách ca";
            this.btn_dsca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dsca.Textcolor = System.Drawing.Color.White;
            this.btn_dsca.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dsca.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btn_home
            // 
            this.btn_home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.BorderRadius = 0;
            this.btn_home.ButtonText = "           Home";
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.DisabledColor = System.Drawing.Color.Gray;
            this.btn_home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_home.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_home.Iconimage")));
            this.btn_home.Iconimage_right = null;
            this.btn_home.Iconimage_right_Selected = null;
            this.btn_home.Iconimage_Selected = null;
            this.btn_home.IconMarginLeft = 0;
            this.btn_home.IconMarginRight = 0;
            this.btn_home.IconRightVisible = true;
            this.btn_home.IconRightZoom = 0D;
            this.btn_home.IconVisible = true;
            this.btn_home.IconZoom = 40D;
            this.btn_home.IsTab = false;
            this.btn_home.Location = new System.Drawing.Point(0, 111);
            this.btn_home.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_home.Name = "btn_home";
            this.btn_home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.btn_home.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_home.selected = false;
            this.btn_home.Size = new System.Drawing.Size(341, 59);
            this.btn_home.TabIndex = 14;
            this.btn_home.Text = "           Home";
            this.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Textcolor = System.Drawing.Color.White;
            this.btn_home.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 111);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 111);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.btn_thongtincanhan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(341, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 60);
            this.panel2.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(887, 17);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(150, 23);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Thông tin cá nhân";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_thongtincanhan
            // 
            this.btn_thongtincanhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_thongtincanhan.BackgroundImage")));
            this.btn_thongtincanhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_thongtincanhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thongtincanhan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_thongtincanhan.Location = new System.Drawing.Point(1022, 0);
            this.btn_thongtincanhan.Name = "btn_thongtincanhan";
            this.btn_thongtincanhan.Size = new System.Drawing.Size(69, 60);
            this.btn_thongtincanhan.TabIndex = 1;
            this.btn_thongtincanhan.TabStop = false;
            this.btn_thongtincanhan.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pn_childform
            // 
            this.pn_childform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.pn_childform.Controls.Add(this.slidePic);
            this.pn_childform.Controls.Add(this.panel3);
            this.pn_childform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_childform.Location = new System.Drawing.Point(341, 60);
            this.pn_childform.Margin = new System.Windows.Forms.Padding(4);
            this.pn_childform.Name = "pn_childform";
            this.pn_childform.Size = new System.Drawing.Size(1091, 673);
            this.pn_childform.TabIndex = 13;
            this.pn_childform.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_childform_Paint);
            // 
            // slidePic
            // 
            this.slidePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.slidePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slidePic.BackgroundImage")));
            this.slidePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slidePic.Location = new System.Drawing.Point(0, 96);
            this.slidePic.Name = "slidePic";
            this.slidePic.Size = new System.Drawing.Size(1091, 455);
            this.slidePic.TabIndex = 2;
            this.slidePic.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.img_3);
            this.panel3.Controls.Add(this.img_2);
            this.panel3.Controls.Add(this.img_1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 624);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1091, 49);
            this.panel3.TabIndex = 1;
            // 
            // img_3
            // 
            this.img_3.AutoSize = true;
            this.img_3.Location = new System.Drawing.Point(542, 12);
            this.img_3.Name = "img_3";
            this.img_3.Size = new System.Drawing.Size(17, 16);
            this.img_3.TabIndex = 2;
            this.img_3.TabStop = true;
            this.img_3.UseVisualStyleBackColor = true;
            this.img_3.Click += new System.EventHandler(this.img_3_Click);
            // 
            // img_2
            // 
            this.img_2.AutoSize = true;
            this.img_2.Location = new System.Drawing.Point(503, 12);
            this.img_2.Name = "img_2";
            this.img_2.Size = new System.Drawing.Size(17, 16);
            this.img_2.TabIndex = 1;
            this.img_2.TabStop = true;
            this.img_2.UseVisualStyleBackColor = true;
            this.img_2.Click += new System.EventHandler(this.img_2_Click);
            // 
            // img_1
            // 
            this.img_1.AutoSize = true;
            this.img_1.BackColor = System.Drawing.Color.Transparent;
            this.img_1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ScrollBar;
            this.img_1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.img_1.Location = new System.Drawing.Point(460, 12);
            this.img_1.Name = "img_1";
            this.img_1.Size = new System.Drawing.Size(17, 16);
            this.img_1.TabIndex = 0;
            this.img_1.TabStop = true;
            this.img_1.UseVisualStyleBackColor = false;
            this.img_1.Click += new System.EventHandler(this.img_1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmmaunhanvien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1432, 733);
            this.Controls.Add(this.pn_childform);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pn_menu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmmaunhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmaunhanvien";
            this.Load += new System.EventHandler(this.frmmaunhanvien_Load);
            this.pn_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_thongtincanhan)).EndInit();
            this.pn_childform.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slidePic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_childform;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_home;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dsmon;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dsbill;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dsban;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dsca;
        private System.Windows.Forms.PictureBox btn_thongtincanhan;
        private System.Windows.Forms.PictureBox indicator;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox slidePic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton img_3;
        private System.Windows.Forms.RadioButton img_2;
        private System.Windows.Forms.RadioButton img_1;
    }
}