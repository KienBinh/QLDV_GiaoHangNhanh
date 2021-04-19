using HeThongQLDVGiaoHangNhanh.objects;
using SqlQuery;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh.sqlQuery
{
    class KhachHangGuiDAL : ConnectionDB
    {
        #region Design Pattern Singleton
        private static KhachHangGuiDAL instance;
        public static KhachHangGuiDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangGuiDAL();
                return KhachHangGuiDAL.instance;
            }
            private set => instance = value;
        }
        private KhachHangGuiDAL()
        {
            DataProvider.Instance.connectionString = connectDB;
        }
        #endregion

        public KhachHangGui GetKhachHangGuiByMaKHG(string maKHG)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SP_GetKhachHangGuiByMaKHG @maKHG", new object[] { maKHG });
            foreach (DataRow row in dt.Rows)
                return new KhachHangGui(row);
            return null;
        }

        public DataTable GetListMaSoKHG()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM View_GetListMaSoKHG");
        }
    }
}
