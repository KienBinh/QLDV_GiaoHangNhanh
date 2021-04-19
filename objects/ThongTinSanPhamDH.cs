using System;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh.objects
{
    class ThongTinSanPhamDH
    {
        public ThongTinSanPhamDH(DataRow row)
        {
            MaSP = row["MaSP"].ToString();
            TenSP = row["TenSP"].ToString();
            GiaSP = Convert.ToDouble(row["GiaSP"]);
            SoLuongSP = Convert.ToInt32(row["SoLuongSP"]);
            ThanhTienSP = Convert.ToDouble(row["ThanhTienSP"]);
            MaVanDon = row["MaVanDon"].ToString();
        }

        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public double GiaSP { get; set; }
        public int SoLuongSP { get; set; }
        public double ThanhTienSP { get; set; }
        public string MaVanDon { get; set; }

    }
}
