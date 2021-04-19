using HeThongQLDVGiaoHangNhanh.managementSystem;
using HeThongQLDVGiaoHangNhanh.sqlQuery;
using System;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class OrderManagement : Form
    {
        public OrderManagement()
        {
            InitializeComponent();
        }

        private void HeaderTextDonHang()
        {
            dgvDonHang.Columns[0].HeaderText = "Mã vận đơn";
            dgvDonHang.Columns[1].HeaderText = "Tổng đơn hàng";
            dgvDonHang.Columns[2].HeaderText = "Phí vận chuyển";
            dgvDonHang.Columns[3].HeaderText = "Ngày nhập kho";
            dgvDonHang.Columns[4].HeaderText = "Ngày gửi hàng";
            dgvDonHang.Columns[5].HeaderText = "Giao thành công";
            dgvDonHang.Columns[6].HeaderText = "Bị hoàn trả";
            dgvDonHang.Columns[7].HeaderText = "Nguyên nhân bị hoàn trả";
            dgvDonHang.Columns[8].HeaderText = "Mã nhân viên giao hàng";
            dgvDonHang.Columns[9].HeaderText = "Mã khách hàng gửi";
            dgvDonHang.Columns[10].HeaderText = "Mã khách hàng nhận";
        }

        private void LoadListDonHang()
        {
            dgvDonHang.DataSource = DonHangDAL.Instance.GetListDonHang();
            HeaderTextDonHang();
        }

        private void OrderManagement_Load(object sender, EventArgs e)
        {
            LoadListDonHang();
            cboKhachHangGui.DataSource = KhachHangGuiDAL.Instance.GetListMaSoKHG();
            cboKhachHangGui.DisplayMember = "MaSoKHG";
            cboKhachHangNhan.DataSource = KhachHangNhanDAL.Instance.GetListMaSoKHN();
            cboKhachHangNhan.DisplayMember = "MaSoKHN";
            cboNVGiaoHang.DataSource = NV_GiaoHangDAL.Instance.GetListMaSoNV();
            cboNVGiaoHang.DisplayMember = "MaSoNV";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDonHang_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvDonHang.RowCount + " đơn hàng";
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvDonHang.SelectedRows[0];
                txtMaVanDon.Text = row.Cells["MaVanDon"].Value.ToString();
                numTongDonHang.Value = Convert.ToInt32(row.Cells["TongDonHang"].Value);
                numPhiVanChuyen.Value = Convert.ToInt32(row.Cells["PhiVanChuyen"].Value);
                dtpNgayNhapKho.Value = Convert.ToDateTime(row.Cells["NgayNhapKho"].Value);
                var ngayGuiTmp = Convert.ToDateTime(row.Cells["NgayGui"].Value);
                if (ngayGuiTmp != null)
                    dtpNgayGui.Value = (DateTime)ngayGuiTmp;
                rdbGiaoThanhCong.Checked = Convert.ToBoolean(row.Cells["GiaoThanhCong"].Value);
                rdbHoanTra.Checked = Convert.ToBoolean(row.Cells["HoanTra"].Value);
                rtxtNguyenNhanHoanTra.Text = row.Cells["NguyenNhanHoanTra"].Value.ToString();
                cboKhachHangGui.Text = row.Cells["MaSoKHG"].Value.ToString();
                cboKhachHangNhan.Text = row.Cells["MaSoKHN"].Value.ToString();
                cboNVGiaoHang.Text = row.Cells["MaSoNV"].Value.ToString();
                btnTTDonHang.Enabled = true;
            }
            else btnTTDonHang.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnTTDonHang_Click(object sender, EventArgs e)
        {
            ProductManagement product = new ProductManagement(dgvDonHang.SelectedRows[0].Cells["MaVanDon"].Value.ToString());
            this.Hide();
            product.ShowDialog();
            this.Show();
            LoadListDonHang();
        }

        private void rdbTonKho_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTonKho.Checked)
                dtpNgayGui.Enabled = false;
            else
                dtpNgayGui.Enabled = true;
        }

        private void rdbHoanTra_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbHoanTra.Checked)
                rtxtNguyenNhanHoanTra.Enabled = true;
            else
                rtxtNguyenNhanHoanTra.Enabled = false;
        }
    }
}
