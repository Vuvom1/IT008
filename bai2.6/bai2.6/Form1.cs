using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2._6
{
    public partial class Form1 : Form
    {
        SinhvienBLL bllsv;
        public Form1()
        {
            InitializeComponent();
            bllsv = new SinhvienBLL();
        }

        public void ShowAllSinhvien()
        {
            DataTable dataTable = bllsv.getlistSinhvien();
            dataGridViewSinhVien.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowAllSinhvien();
        }

        public bool checkdata()
        {
            if (string.IsNullOrEmpty(tb_mssv.Text))
            {
                MessageBox.Show("bạn chưa nhập mssv.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_mssv.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_name.Text))
            {
                MessageBox.Show("bạn chưa nhập tên sinh viên.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_mssv.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(tb_birthday.Text))
            {
                MessageBox.Show("bạn chưa nhập ngày sinh.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_mssv.Focus();
                return false;
            }
            return true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {
                Sinhvien sinhvien = new Sinhvien();
                sinhvien.MSSV = tb_mssv.Text;
                sinhvien.Ten = tb_name.Text;
                sinhvien.Birthday = tb_birthday.Text;
                if (bllsv.InserSinhvien(sinhvien))
                {
                    ShowAllSinhvien();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        int ID;
        private void dataGridViewSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                ID = Int32.Parse(dataGridViewSinhVien.Rows[index].Cells["ld"].Value.ToString());
                tb_mssv.Text = dataGridViewSinhVien.Rows[index].Cells["MSSV"].Value.ToString();
                tb_name.Text = dataGridViewSinhVien.Rows[index].Cells["name"].Value.ToString();
                tb_birthday.Text = dataGridViewSinhVien.Rows[index].Cells["birthday"].Value.ToString();
            }
        }

        private void btb_edit_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {
                Sinhvien sinhvien = new Sinhvien();
                sinhvien.ID = ID;
                sinhvien.MSSV = tb_mssv.Text;
                sinhvien.Ten = tb_name.Text;
                sinhvien.Birthday = tb_birthday.Text;
                if (bllsv.UpdateSinhvien(sinhvien))
                {
                    ShowAllSinhvien();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                Sinhvien sv = new Sinhvien();
                sv.ID = ID;
                if (bllsv.DeleteSinhvien(sv))
                {
                    ShowAllSinhvien();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin thử lại", "thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
