using System;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh.objects
{
    class KhachHangGui
    {
        public KhachHangGui(DataRow row)
        {
            MaSoKHG = row["MaSoKHG"].ToString();
            HoTenKHG = row["HoTenKHG"].ToString();
            SdtKHG = row["SdtKHG"].ToString();
            DiaChiKHG = row["DiaChiKHG"].ToString();
        }

        public string MaSoKHG { get; set; }
        public string HoTenKHG { get; set; }
        public string SdtKHG { get; set; }
        public string DiaChiKHG { get; set; }
    }
}
