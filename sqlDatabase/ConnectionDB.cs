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
        public int MyProperty3 { get; set; } //Commit All and Push - Thành công
        public int MyProperty4 { get; set; } //Commit All and Sync
        public int Hello { get; set; } //Load về Pull Thành công
        public int World { get; set; } //Load về Fetch
    }
}
