using HeThongQLDVGiaoHangNhanh.objects;
using SqlQuery;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh.sqlQuery
{
    class KhachHangNhanDAL : ConnectionDB
    {
        #region Design Pattern Singleton
        private static KhachHangNhanDAL instance;
        public static KhachHangNhanDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangNhanDAL();
                return KhachHangNhanDAL.instance;
            }
            private set => instance = value;
        }
        private KhachHangNhanDAL()
        {
            DataProvider.Instance.connectionString = connectDB;
        }
        #endregion

        public KhachHangNhan GetKhachHangNhanByMaKHN(string maKHN)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SP_GetKhachHangNhanByMaKHN @maKHN", new object[] { maKHN });
            foreach (DataRow row in dt.Rows)
                return new KhachHangNhan(row);
            return null;
        }

        public DataTable GetListMaSoKHN()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM View_GetListMaSoKHN");
        }
    }
}
