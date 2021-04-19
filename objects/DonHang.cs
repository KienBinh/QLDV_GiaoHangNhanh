using System;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh.objects
{
    class DonHang
    {
        public DonHang(DataRow row)
        {
            MaVanDon = row["MaVanDon"].ToString();
            TongDonHang = Convert.ToDouble(row["TongDonHang"]);
            PhiVanChuyen = Convert.ToDouble(row["PhiVanChuyen"]);
            NgayNhapKho = Convert.ToDateTime(row["NgayNhapKho"]);
            NgayGui = Convert.ToDateTime(row["NgayGui"]);
            GiaoThanhCong = Convert.ToBoolean(row["GiaoThanhCong"]);
            HoanTra = Convert.ToBoolean(row["HoanTra"]);
            NguyenNhanHoanTra = row["NguyenNhanHoanTra"].ToString();
            MaSoNV = row["MaSoNV"].ToString();
            MaSoKHG = row["MaSoKHG"].ToString();
            MaSoKHN = row["MaSoKHN"].ToString();
        }

        public string MaVanDon { get; set; }
        public double TongDonHang { get; set; }
        public double PhiVanChuyen { get; set; }
        public DateTime NgayNhapKho { get; set; }
        public DateTime? NgayGui { get; set; }
        public bool GiaoThanhCong { get; set; }
        public bool HoanTra { get; set; }
        public string NguyenNhanHoanTra { get; set; }
        public string MaSoNV { get; set; }
        public string MaSoKHG { get; set; }
        public string MaSoKHN { get; set; }
    }
}
