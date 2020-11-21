using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmchiacav2 : Form
    {
        public frmchiacav2()
        {
            InitializeComponent();
        }

     

        private void frmchiacav2_Load(object sender, EventArgs e)
        {
           try
            {
               
            }
            catch { }
        }
        void chiatheokhoang(List<string> id)
        {
          

        }
        void chiaca(List<string> id)
        {
           
     
        }
        private void btn_themca_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void btn_chiadeu_Click(object sender, EventArgs e)
        {
            try
            {
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bttn_luu_Click(object sender, EventArgs e)
        {
           
            try
            {
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
          
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {

        }

        private void btn_xóa_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"\n ca không tồn tại");
            }
        }

        
    }
}
