using HeThongQLDVGiaoHangNhanh.objects;
using SqlQuery;
using System.Data;

namespace HeThongQLDVGiaoHangNhanh.sqlQuery
{
    class NV_GiaoHangDAL : ConnectionDB
    {
        #region Design Pattern Singleton
        private static NV_GiaoHangDAL instance;
        public static NV_GiaoHangDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new NV_GiaoHangDAL();
                return NV_GiaoHangDAL.instance;
            }
            private set => instance = value;
        }
        private NV_GiaoHangDAL()
        {
            DataProvider.Instance.connectionString = connectDB;
        }
        #endregion

        public NV_GiaoHang GetNVGiaoHangByMaNV(string maNV)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery("SP_GetNVGiaoHangByMaNV @maNV", new object[] { maNV });
            foreach (DataRow row in dt.Rows)
                return new NV_GiaoHang(row);
            return null;
        }

        public DataTable GetListMaSoNV()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM View_GetListMaSoNV");
        }
    }
}
