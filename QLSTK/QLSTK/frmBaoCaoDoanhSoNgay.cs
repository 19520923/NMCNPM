using QLSTKBUS;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSTK
{
    public partial class frmBaoCaoDoanhSoNgay : Form
    {
        private BaoCaoDoanhSoNgayBUS bcBUS;
        public frmBaoCaoDoanhSoNgay()
        {
            InitializeComponent();
        }
        private void frmBaoCaoDoanhSoNgay_Load(object sender, EventArgs e)
        {
            bcBUS = new BaoCaoDoanhSoNgayBUS();
            LoadData();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTaoBaoCao_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhSoNgayBUS bcBUS = new BaoCaoDoanhSoNgayBUS();
            bool kq = bcBUS.createBaoCao();
            if (kq == false)
            {
                MessageBox.Show("Không thể hoàn thành thao tác. Vui lòng kiểm tra lại dũ liệu");
            }
            else
            {
                MessageBox.Show("Báo cáo ngày được tạo thành công");
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhSoNgayBUS bcBUS = new BaoCaoDoanhSoNgayBUS();
            bool kq = bcBUS.updateBaoCao();
            if (kq == false)
            {
                MessageBox.Show("Không thể hoàn thành thao tác. Vui lòng kiểm tra lại dũ liệu");
            }
            else
            {
                MessageBox.Show("Báo cáo ngày được cập nhật thành công");
            }
        }

        //Xuất báo cáo
        private void BtnXuatFile_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            List<BaoCaoDoanhSoNgayDTO> listData;
            try
            {
                listData = bcBUS.getListBaoCao(dtpNgayBaoCao.Value);
            }
            catch
            {
                listData = bcBUS.getListBaoCao(DateTime.Today);
                dtpNgayBaoCao.Value = DateTime.Today;
            }
            if (listData == null)
            {
                MessageBox.Show("Lỗi khi load dữ liệu");
                return;
            }

            dgvBaoCao.Columns.Clear();
            dgvBaoCao.DataSource = null;

            dgvBaoCao.AutoGenerateColumns = false;
            dgvBaoCao.AllowUserToAddRows = false;
            dgvBaoCao.DataSource = listData;

            DataGridViewTextBoxColumn clSTT = new DataGridViewTextBoxColumn();
            clSTT.Name = "STT";
            clSTT.HeaderText = "STT";
            //clSTT.DataPropertyName = "STT";
            dgvBaoCao.Columns.Add(clSTT);

            DataGridViewTextBoxColumn clNgayBaoCao = new DataGridViewTextBoxColumn();
            clNgayBaoCao.Name = "clNgayBaoCao";
            clNgayBaoCao.HeaderText = "Ngay";
            clNgayBaoCao.DataPropertyName = "StrNgayBCDS";
            dgvBaoCao.Columns.Add(clNgayBaoCao);

            DataGridViewTextBoxColumn clLoaiTietKiem = new DataGridViewTextBoxColumn();
            clLoaiTietKiem.Name = "clLoaiTietKiem";
            clLoaiTietKiem.HeaderText = "Loại Tiết Kiệm";
            clLoaiTietKiem.DataPropertyName = "StrMaLTK";
            dgvBaoCao.Columns.Add(clLoaiTietKiem);

            DataGridViewTextBoxColumn clTongThu = new DataGridViewTextBoxColumn();
            clTongThu.Name = "clTongThu";
            clTongThu.HeaderText = "Tổng thu";
            clTongThu.DataPropertyName = "DTongThu";
            dgvBaoCao.Columns.Add(clTongThu);

            DataGridViewTextBoxColumn clTongChi = new DataGridViewTextBoxColumn();
            clTongChi.Name = "clTongChi";
            clTongChi.HeaderText = "Tổng chi";
            clTongChi.DataPropertyName = "DTongChi";
            dgvBaoCao.Columns.Add(clTongChi);

            DataGridViewTextBoxColumn clChenhLech = new DataGridViewTextBoxColumn();
            clChenhLech.Name = "clChenhLech";
            clChenhLech.HeaderText = "Chênh lệch";
            clChenhLech.DataPropertyName = "DChenhLech";
            dgvBaoCao.Columns.Add(clChenhLech);

            int sum = 0;
            for (int i = 0; i < dgvBaoCao.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvBaoCao.Rows[i].Cells[3].Value);
            }
            txtTongThuNgay.Text = sum.ToString();

            for (int i = 0; i < dgvBaoCao.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvBaoCao.Rows[i].Cells[4].Value);
            }
            txtTongChiNgay.Text = sum.ToString();

            txtChenhLech.Text = (int.Parse(txtTongChiNgay.Text) - int.Parse(txtTongThuNgay.Text)).ToString();


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvBaoCao.DataSource];// ho tro binding du lieu
            myCurrencyManager.Refresh();
        }
    }
}
