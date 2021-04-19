using System;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh.objects
{
    class KhachHangNhan
    {
        public KhachHangNhan(DataRow row)
        {
            MaSoKHN = row["MaSoKHN"].ToString();
            HoTenKHN = row["HoTenKHN"].ToString();
            SdtKHN = row["SdtKHN"].ToString();
            DiaChiKHN = row["DiaChiKHN"].ToString();
        }

        public string MaSoKHN { get; set; }
        public string HoTenKHN { get; set; }
        public string SdtKHN { get; set; }
        public string DiaChiKHN { get; set; }
    }
}
