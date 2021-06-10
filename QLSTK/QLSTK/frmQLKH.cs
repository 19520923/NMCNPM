using QLSTKBUS;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSTK
{
    public partial class frmQLKH : Form
    {
        KhachHangBUS khBUS;
        public frmQLKH()
        {
            InitializeComponent();
            khBUS = new KhachHangBUS();
            materialTextBox2.Text = khBUS.getNewMaSo();
        }

        private void frmQLKH_Load(object sender, EventArgs e)
        {
            khBUS = new KhachHangBUS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            KhachHangDTO kh = new KhachHangDTO();

            if(materialTextBox1.Text.Length == 0)
            {
                MessageBox.Show("Nhập họ tên");
                return;
            }

            if (materialTextBox3.Text.Length == 0)
            {
                MessageBox.Show("Nhập CMND");
                return;
            }

            if (materialTextBox4.Text.Length == 0)
            {
                MessageBox.Show("Nhập địa chỉ");
                return;
            }

            if (materialTextBox5.Text.Length == 0)
            {
                MessageBox.Show("Nhập số điện thoại");
                return;
            }

            if (materialTextBox6.Text.Length == 0)
            {
                MessageBox.Show("Nhập họ tên");
                return;
            }
            kh.StrMaKH = materialTextBox2.Text;
            kh.StrHoTenKH = materialTextBox1.Text;
            kh.StrDiaChi = txtDiaChi.Text;
            kh.StrCMND = materialTextBox3.Text;
            //----------------------------------------

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = khBUS.them(kh);
            if (kq == false)
                MessageBox.Show("Thêm Khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thêm Khách hàng thành công");
            //--------------------------------------------
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //1. Map key primary from GUI
            KhachHangDTO kh = new KhachHangDTO();
            kh.StrMaKH = materialTextBox2.Text;
            //2. Kiểm tra data hợp lệ

            //3. Xóa khỏi DB
            bool kq = khBUS.xoa(kh);
            if (kq == false)
                MessageBox.Show("Xóa khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Xóa khách hàng thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            KhachHangDTO kh = new KhachHangDTO();
            kh.StrMaKH = materialTextBox2.Text;
            kh.StrHoTenKH = materialTextBox1.Text;
            kh.StrDiaChi = txtDiaChi.Text;
            kh.StrCMND = materialTextBox3.Text;

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = khBUS.sua(kh);
            if (kq == false)
                MessageBox.Show("Sửa khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Sửa khách hàng thành công");
        }

        private void TxtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || e.KeyChar == 8);
        }

        private void TxtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            string patten = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z]*@[0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(materialTextBox6.Text, patten))
                    errorProvider1.Clear();
           else
                errorProvider1.SetError(this.materialTextBox6, "Email không hợp lệ");
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
