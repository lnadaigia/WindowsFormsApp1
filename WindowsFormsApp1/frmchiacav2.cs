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
using WindowsFormsApp1.DAO;

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
                DAOCa ca = new DAOCa();
                DataTable DanhSachCa=ca.getDanhSachCaDeChiaCa();
                DanhSachCa.Columns.Add("Check", typeof(bool));
                dataGridView3.DataSource = DanhSachCa;
                DAONhanVien nv = new DAONhanVien();
                DataTable DanhSachNhanVien = nv.getNhanVienDeChiaCa();
                DanhSachNhanVien.Columns.Add("Check", typeof(bool));
                dataGridView1.DataSource= DanhSachNhanVien;
                DAOChiaca cc = new DAOChiaca();
                dataGridView2.DataSource = cc.getDanhSachChiaCaFrmChiaCa();
            }
            catch { }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (rd_ngay.Checked == true)
                {
                    List<int> manv = new List<int>();
                    int a = dataGridView1.Rows.Count;
                    for (int i = 0; i < a; i++)
                    {
                        //MessageBox.Show(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        if (dataGridView1.Rows[i].Cells[4].Value.ToString() != "" && Boolean.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) == true)
                        {
                            manv.Add(int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                        }

                    }

                    int b = dataGridView3.Rows.Count;
                    List<int> danhsachca = new List<int>();
                    for (int i = 0; i < b; i++)
                    {
                        //MessageBox.Show(dataGridView3.Rows[i].Cells[4].Value.ToString());
                        if (dataGridView3.Rows[i].Cells[4].Value.ToString() != "" && Boolean.Parse(dataGridView3.Rows[i].Cells[4].Value.ToString()) == true)
                        {
                            danhsachca.Add(int.Parse(dataGridView3.Rows[i].Cells[0].Value.ToString()));
                        }
                    }
                    DateTime date = DateTime.Parse(dt_ngay.Value.ToString());
                    DAOChiaca chiaca = new DAOChiaca();
                    bool success = false;
                    for (int j = 0; j < manv.Count; j++)
                    {
                        //MessageBox.Show(manv[j].ToString());
                        for (int k = 0; k < danhsachca.Count; k++)
                        {
                            //MessageBox.Show(danhsachca[k].ToString());
                            if (chiaca.ThemVaoChiaCa(manv[j], danhsachca[k], date))
                            {
                                success = true;
                            }
                        }
                    }
                    if (success == true)

                    {
                        MessageBox.Show("Them thanh cong");
                        DAOChiaca cc = new DAOChiaca();
                        dataGridView2.DataSource = cc.getDanhSachChiaCaFrmChiaCa();
                    }
                    else
                    {
                        MessageBox.Show("Them khong thanh cong !");
                    }
                }
                if (rd_khoang.Checked == true)
                {

                    List<int> manv = new List<int>();
                    int a = dataGridView1.Rows.Count;
                    for (int i = 0; i < a; i++)
                    {
                        //MessageBox.Show(dataGridView1.Rows[i].Cells[4].Value.ToString());
                        if (dataGridView1.Rows[i].Cells[4].Value.ToString() != "" && Boolean.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) == true)
                        {
                            manv.Add(int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString()));
                        }

                    }

                    int b = dataGridView3.Rows.Count;
                    List<int> danhsachca = new List<int>();
                    for (int i = 0; i < b; i++)
                    {
                        //MessageBox.Show(dataGridView3.Rows[i].Cells[4].Value.ToString());
                        if (dataGridView3.Rows[i].Cells[4].Value.ToString() != "" && Boolean.Parse(dataGridView3.Rows[i].Cells[4].Value.ToString()) == true)
                        {
                            danhsachca.Add(int.Parse(dataGridView3.Rows[i].Cells[0].Value.ToString()));
                        }
                    }
                    DateTime dateS = DateTime.Parse(dt_dau.Value.ToString());
                    DateTime dateE = DateTime.Parse(dt_sau.Value.ToString());
                    DAOChiaca chiaca = new DAOChiaca();
                    bool success = false;
                    for (DateTime x = dateS; x <= dateE; x = x.AddDays(1))
                    {
                        for (int j = 0; j < manv.Count; j++)
                        {
                            //MessageBox.Show(manv[j].ToString());
                            for (int k = 0; k < danhsachca.Count; k++)
                            {
                                //MessageBox.Show(danhsachca[k].ToString());
                                if (chiaca.ThemVaoChiaCa(manv[j], danhsachca[k], x))
                                {
                                    success = true;
                                }
                            }
                        }
                    }
                    if (success == true)

                    {
                        MessageBox.Show("Them thanh cong");
                        DAOChiaca cc = new DAOChiaca();
                        dataGridView2.DataSource = cc.getDanhSachChiaCaFrmChiaCa();
                    }
                    else
                    {
                        MessageBox.Show("Them khong thanh cong !");
                    }
                }
            }
            catch
            {

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                int manv = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                DateTime date = DateTime.Parse(dataGridView2.CurrentRow.Cells[5].Value.ToString());
                DAOChiaca sua = new DAOChiaca();
                if (sua.SuaChiaCa(manv,date))
                {
                    MessageBox.Show("sua thanh cong ");
                    DAOChiaca cc = new DAOChiaca();
                    dataGridView2.DataSource = cc.getDanhSachChiaCaFrmChiaCa();
                }
                else
                {
                    MessageBox.Show("sua khong thanh cong");
                }
            }
            catch
            {

                MessageBox.Show("Failed");
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int manv = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
                int maca = int.Parse(dataGridView2.CurrentRow.Cells[6].Value.ToString());
                DateTime date = DateTime.Parse(dataGridView2.CurrentRow.Cells[5].Value.ToString());
                DAOChiaca xoa = new DAOChiaca();
                if (xoa.xoaChiaCa(manv, maca, date))
                {
                    MessageBox.Show("xoa thanh cong ");
                    DAOChiaca cc = new DAOChiaca();
                    dataGridView2.DataSource = cc.getDanhSachChiaCaFrmChiaCa();
                }
                else
                {
                    MessageBox.Show("xoa khong thanh cong");
                }
            }
            catch
            {
                
                MessageBox.Show("Failed");
            }
         
        }
    }
}
