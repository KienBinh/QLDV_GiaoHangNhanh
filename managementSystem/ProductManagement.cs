using HeThongQLDVGiaoHangNhanh.objects;
using HeThongQLDVGiaoHangNhanh.sqlQuery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh.managementSystem
{
    public partial class ProductManagement : Form
    {
        public string MaVanDon { get; set; }

        public ProductManagement(string maVanDon)
        {
            InitializeComponent();
            MaVanDon = maVanDon;
        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            lblMaVanDon.Text = "Đơn hàng: " + MaVanDon;
            dgvThongTinSanPhamDH.DataSource = ThongTinSanPhamDHDAL.Instance.GetListThongTinSanPhamByMaVanDon(MaVanDon);
        }

        private void dgvThongTinSanPhamDH_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvThongTinSanPhamDH.RowCount + " sản phẩm";
        }

        private void dgvThongTinSanPhamDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvThongTinSanPhamDH.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dgvThongTinSanPhamDH.SelectedRows[0];
                txtMaSP.Text = row.Cells["Mã sản phẩm"].Value.ToString();
                txtTenSP.Text = row.Cells["Tên sản phẩm"].Value.ToString();
                numGiaSP.Value = Convert.ToInt32(row.Cells["Giá"].Value);
                numSoLuong.Value = Convert.ToInt32(row.Cells["Số lượng"].Value);
                txtThanhTien.Text = row.Cells["Thành tiền"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (ThongTinSanPhamDHDAL.Instance.AddThongTinSanPhamDH(txtTenSP.Text, (double)numGiaSP.Value, (int)numSoLuong.Value, MaVanDon))
                MessageBox.Show("Thêm sản phẩm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Thêm sản phẩm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductManagement_Load(null, new EventArgs());
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ThongTinSanPhamDHDAL.Instance.UpdateThongTinSanPhamDH(txtMaSP.Text, txtTenSP.Text, (double)numGiaSP.Value, (int)numSoLuong.Value, MaVanDon))
                MessageBox.Show("Cập nhật sản phẩm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Cập nhật sản phẩm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductManagement_Load(null, new EventArgs());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ThongTinSanPhamDHDAL.Instance.DeleteThongTinSanPhamDH(txtMaSP.Text, MaVanDon))
                MessageBox.Show("Xoá sản phẩm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Xoá sản phẩm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ProductManagement_Load(null, new EventArgs());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numGiaSP_ValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (numGiaSP.Value * numSoLuong.Value).ToString();
        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {
            txtThanhTien.Text = (numGiaSP.Value * numSoLuong.Value).ToString();
        }
    }
}
