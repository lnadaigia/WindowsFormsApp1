using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmmaunhanvien : Form
    {
        private int imgNumber = 1;
        private void loadNextImage()
        {
            if (imgNumber == 1)
            {
                //slidePic.ImageLocation = string.Format(@"Images\1.jpg");
                slidePic.Image = Properties.Resources._1;
                slidePic.BackgroundImageLayout = ImageLayout.Stretch;
                imgNumber = 2;
                img_1.Checked = true;
            }
            else if (imgNumber == 2)
            {
                //slidePic.ImageLocation = string.Format(@"Images\2.jpg");
                slidePic.Image = Properties.Resources._2;
                slidePic.BackgroundImageLayout = ImageLayout.Stretch;
                imgNumber = 3;
                img_2.Checked = true;
            }
            else
            {
                //slidePic.ImageLocation = string.Format(@"Images\3.jpg");
                slidePic.Image = Properties.Resources._3;
                slidePic.BackgroundImageLayout = ImageLayout.Stretch;
                imgNumber = 1;
                img_3.Checked = true;
            }
            //imgNumber++;
        }
        public frmmaunhanvien()
        {
            InitializeComponent();
        }
        private string id;
        public string setid
        {
            set { id = value; }
        }
        private Form activeform = null;
        private void openchildform(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pn_childform.Controls.Add(childform);
            pn_childform.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void frmmaunhanvien_Load(object sender, EventArgs e)
        {
           
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.pn_menu.Visible = !this.pn_menu.Visible; 
        }

        private void pn_childform_Paint(object sender, PaintEventArgs e)
        {
            loadNextImage();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            openchildform(new frmnhanvien());
            MoveIndicator((Control)sender);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            openchildform(new frmdscanhanvien());
            MoveIndicator((Control)sender);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            openchildform(new frmdsban());
            MoveIndicator((Control)sender);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            openchildform(new frmdshoadon());
            MoveIndicator((Control)sender);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            openchildform(new frmmuanguyenlieu());
            MoveIndicator((Control)sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openchildform(new frmthongtin());
        }

        void MoveIndicator(Control control)
        {
            indicator.Top = control.Top;
            indicator.Height = control.Height;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openchildform(new frmthongtin());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void img_1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            slidePic.Image = Properties.Resources._1;
            slidePic.BackgroundImageLayout = ImageLayout.Stretch;
            imgNumber = 2;
            timer1.Start();
        }

        private void img_2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            slidePic.Image = Properties.Resources._2;
            slidePic.BackgroundImageLayout = ImageLayout.Stretch;
            imgNumber = 3;
            timer1.Start();
        }

        private void img_3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            slidePic.Image = Properties.Resources._3;
            slidePic.BackgroundImageLayout = ImageLayout.Stretch;
            imgNumber = 1;
            timer1.Start();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (activeform != null)
                activeform.Close();
        }
    }
}
