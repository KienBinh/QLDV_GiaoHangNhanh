using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh.sqlQuery
{
    public partial class DisplayProductInformation : Form
    {
        private string MaVanDon = "";
        public DisplayProductInformation(string maVanDon)
        {
            InitializeComponent();
            MaVanDon = maVanDon;
        }

        private void DisplayProductInformation_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin sản phẩm của đơn hàng";
            lblMaVanDon.Text = "Đơn hàng: " + MaVanDon;
            dgvThongTinSanPham.DataSource = ThongTinSanPhamDHDAL.Instance.GetListThongTinSanPhamByMaVanDon(MaVanDon);
        }

        private void dgvThongTinSanPham_DataSourceChanged(object sender, EventArgs e)
        {
            lblStatus.Text = dgvThongTinSanPham.RowCount + " sản phẩm";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
