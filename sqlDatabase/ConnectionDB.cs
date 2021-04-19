namespace HeThongQLDVGiaoHangNhanh.sqlQuery
{
    class ConnectionDB
    {
        protected string connectDB = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                        Initial Catalog = HeThong_QLDV_GiaoHangNhanh;
                                        Integrated Security = True";

        // Hello world
        public int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
    }
}
