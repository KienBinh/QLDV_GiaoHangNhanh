using SqlQuery;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh.sqlQuery
{
    class DonHangDAL : ConnectionDB
    {

        #region Design Pattern Singleton
        private static DonHangDAL instance;
        public static DonHangDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonHangDAL();
                return DonHangDAL.instance;
            }
            private set => instance = value;
        }
        private DonHangDAL()
        {
            DataProvider.Instance.connectionString = connectDB;
        }
        #endregion 

        public DataTable GetListDonHang()
        {
            return DataProvider.Instance.ExecuteQuery("select * from DONHANG");
        }

        public DataTable GetDonHangByMaVanDon(string maVanDon)
        {
            return DataProvider.Instance.ExecuteQuery("SP_GetDonHangByMaVanDon @maVanDon", new object[] { maVanDon });
        }

        public int AddDonHang(string maVanDon)
        {
            return 0;
        }
    }
}
