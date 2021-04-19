using System;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh.objects
{
    class NV_GiaoHang
    {
        public NV_GiaoHang(DataRow row)
        {
            MaSoNV = row["MaSoNV"].ToString();
            HoTenNV = row["HoTenNV"].ToString();
            GioiTinhNV = row["GioiTinhNV"].ToString();
            SdtNV = row["SdtNV"].ToString();
            DiaChiNV = row["DiaChiNV"].ToString();
            NgaySinhNV = Convert.ToDateTime(row["NgaySinhNV"]);
            LuongNV = Convert.ToDouble(row["LuongNV"]);
            GhiChuNV = row["GhiChuNV"].ToString();
        }

        public string MaSoNV { get; set; }
        public string HoTenNV { get; set; }
        public string GioiTinhNV { get; set; }
        public string SdtNV { get; set; }
        public string DiaChiNV { get; set; }
        public DateTime NgaySinhNV { get; set; }
        public double LuongNV { get; set; }
        public string GhiChuNV { get; set; }
    }
}
