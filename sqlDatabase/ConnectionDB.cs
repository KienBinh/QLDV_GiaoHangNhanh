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
        public int MyProperty2 { get; set; } //Commit All - Thất bại
        public int MyProperty3 { get; set; } //Commit All and Push
    }
}
