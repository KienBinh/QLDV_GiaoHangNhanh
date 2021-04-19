using HeThongQLDVGiaoHangNhanh.objects;
using HeThongQLDVGiaoHangNhanh.sqlQuery;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void HeaderTextDonHang()
        {
            dgvDonHang.Columns[0].HeaderText = "Mã vận đơn";
            dgvDonHang.Columns[1].HeaderText = "Tổng đơn hàng";
            dgvDonHang.Columns[2].HeaderText = "Phí vận chuyển";
            dgvDonHang.Columns[3].HeaderText = "Ngày nhập kho";
            dgvDonHang.Columns[4].HeaderText = "Ngày giao hàng";
            dgvDonHang.Columns[5].HeaderText = "Giao thành công";
            dgvDonHang.Columns[6].HeaderText = "Bị hoàn trả";
            dgvDonHang.Columns[7].HeaderText = "Nguyên nhân bị hoàn trả";
            dgvDonHang.Columns[8].HeaderText = "Mã nhân viên giao hàng";
            dgvDonHang.Columns[9].HeaderText = "Mã khách hàng gửi";
            dgvDonHang.Columns[10].HeaderText = "Mã khách hàng nhận";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = DonHangDAL.Instance.GetListDonHang();
            HeaderTextDonHang();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnRefresh, "Tải lại danh sách đơn hàng");
            toolTip.SetToolTip(txtSearch, "Nhấn enter để tìm kiếm");
        }

        #region Event tạo chữ chìm trong textbox tìm kiếm
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Mã vận đơn";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Mã vận đơn")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        #endregion

        private void DefaultRichTextBox()
        {
            rtxtKhachHangGui.Text = "Mã khách hàng: \nHọ tên: \nSố điện thoại: \nĐịa chỉ: ";
            rtxtKhachHangNhan.Text = "Mã khách hàng: \nHọ tên: \nSố điện thoại: \nĐịa chỉ: ";
            rtxtNhanVienGiaoHang.Text = "Mã nhân viên giao hàng: \nHọ tên: \nGiới tính: \nSố điện thoại: \nĐịa chỉ: ";
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count == 1)
            {
                DataGridViewRow data = dgvDonHang.SelectedRows[0];

                KhachHangGui khg = KhachHangGuiDAL.Instance.GetKhachHangGuiByMaKHG(data.Cells["MaSoKHG"].Value.ToString());
                rtxtKhachHangGui.Text = "Mã khách hàng: " + khg.MaSoKHG +
                                        "\nHọ tên: " + khg.HoTenKHG +
                                        "\nSố điện thoại: " + khg.MaSoKHG +
                                        "\nĐịa chỉ: " + khg.DiaChiKHG;

                KhachHangNhan khn = KhachHangNhanDAL.Instance.GetKhachHangNhanByMaKHN(data.Cells["MaSoKHN"].Value.ToString());
                rtxtKhachHangNhan.Text = "Mã khách hàng: " + khn.MaSoKHN +
                                        "\nHọ tên: " + khn.HoTenKHN +
                                        "\nSố điện thoại: " + khn.MaSoKHN +
                                        "\nĐịa chỉ: " + khn.DiaChiKHN;

                NV_GiaoHang ghn = NV_GiaoHangDAL.Instance.GetNVGiaoHangByMaNV(data.Cells["MaSoNV"].Value.ToString());
                rtxtNhanVienGiaoHang.Text = "Mã nhân viên giao hàng: " + ghn.MaSoNV +
                                        "\nHọ tên: " + ghn.HoTenNV +
                                        "\nGiới tính: " + ghn.GioiTinhNV +
                                        "\nSố điện thoại: " + ghn.SdtNV +
                                        "\nĐịa chỉ: " + ghn.DiaChiNV;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dgvDonHang.DataSource = DonHangDAL.Instance.GetDonHangByMaVanDon(txtSearch.Text);
        }

        private void dgvDonHang_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvDonHang.RowCount + " đơn hàng";
        }

        private void btnThongTinSanPham_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                DisplayProductInformation dpi = new DisplayProductInformation(dgvDonHang.SelectedRows[0].Cells["MaVanDon"].Value.ToString());
                this.Hide();
                dpi.ShowDialog();
                this.Show();
            }
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderManagement order = new OrderManagement();
            this.Hide();
            order.ShowDialog();
            this.Show();
        }

        private void nhânViênGiaoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShipperManagement shipper = new ShipperManagement();
            shipper.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerManagement customer = new CustomerManagement();
            customer.ShowDialog();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountManagement account = new AccountManagement();
            account.ShowDialog();
        }

        private void đơnHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderStatistics orderStatistics = new OrderStatistics();
            orderStatistics.ShowDialog();
        }

        private void tổngDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TotalRevenueStatistics totalRevenue = new TotalRevenueStatistics();
            totalRevenue.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCustomersAndShippers search = new SearchCustomersAndShippers();
            search.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = DonHangDAL.Instance.GetListDonHang();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
