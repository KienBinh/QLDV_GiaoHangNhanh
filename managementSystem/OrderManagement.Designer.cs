
namespace HeThongQLDVGiaoHangNhanh
{
    partial class OrderManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagement));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblMaVanDon = new System.Windows.Forms.Label();
            this.txtMaVanDon = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTongDonHang = new System.Windows.Forms.Label();
            this.lblPhiVanChuyen = new System.Windows.Forms.Label();
            this.numTongDonHang = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numPhiVanChuyen = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.dtpNgayNhapKho = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayNhapKho = new System.Windows.Forms.Label();
            this.lblNgayGui = new System.Windows.Forms.Label();
            this.dtpNgayGui = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gbxTrangThaiDH = new System.Windows.Forms.GroupBox();
            this.rtxtNguyenNhanHoanTra = new System.Windows.Forms.RichTextBox();
            this.lblNguyenNhanHoanTra = new System.Windows.Forms.Label();
            this.cboKhachHangGui = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblKhachHangGui = new System.Windows.Forms.Label();
            this.lblKhachHangNhan = new System.Windows.Forms.Label();
            this.cboKhachHangNhan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNVGiaoHang = new System.Windows.Forms.Label();
            this.cboNVGiaoHang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnTTDonHang = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.rdbGiaoThanhCong = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbHoanTra = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbTonKho = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTongDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiVanChuyen)).BeginInit();
            this.gbxTrangThaiDH.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(182)))), ((int)(((byte)(152)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(933, 46);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(385, 10);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 27);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Quản lý đơn hàng";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDonHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDonHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonHang.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonHang.EnableHeadersVisualStyles = false;
            this.dgvDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonHang.Location = new System.Drawing.Point(23, 54);
            this.dgvDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            this.dgvDonHang.RowHeadersVisible = false;
            this.dgvDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonHang.Size = new System.Drawing.Size(591, 488);
            this.dgvDonHang.TabIndex = 1;
            this.dgvDonHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDonHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDonHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDonHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDonHang.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvDonHang.ThemeStyle.ReadOnly = true;
            this.dgvDonHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDonHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonHang.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDonHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonHang.DataSourceChanged += new System.EventHandler(this.dgvDonHang_DataSourceChanged);
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // lblMaVanDon
            // 
            this.lblMaVanDon.AutoSize = true;
            this.lblMaVanDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVanDon.Location = new System.Drawing.Point(622, 61);
            this.lblMaVanDon.Name = "lblMaVanDon";
            this.lblMaVanDon.Size = new System.Drawing.Size(85, 17);
            this.lblMaVanDon.TabIndex = 2;
            this.lblMaVanDon.Text = "Mã vận đơn: ";
            // 
            // txtMaVanDon
            // 
            this.txtMaVanDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaVanDon.DefaultText = "";
            this.txtMaVanDon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaVanDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaVanDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaVanDon.DisabledState.Parent = this.txtMaVanDon;
            this.txtMaVanDon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaVanDon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaVanDon.FocusedState.Parent = this.txtMaVanDon;
            this.txtMaVanDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVanDon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaVanDon.HoverState.Parent = this.txtMaVanDon;
            this.txtMaVanDon.Location = new System.Drawing.Point(747, 54);
            this.txtMaVanDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaVanDon.Name = "txtMaVanDon";
            this.txtMaVanDon.PasswordChar = '\0';
            this.txtMaVanDon.PlaceholderText = "";
            this.txtMaVanDon.ReadOnly = true;
            this.txtMaVanDon.SelectedText = "";
            this.txtMaVanDon.ShadowDecoration.Parent = this.txtMaVanDon;
            this.txtMaVanDon.Size = new System.Drawing.Size(173, 31);
            this.txtMaVanDon.TabIndex = 3;
            // 
            // lblTongDonHang
            // 
            this.lblTongDonHang.AutoSize = true;
            this.lblTongDonHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDonHang.Location = new System.Drawing.Point(622, 100);
            this.lblTongDonHang.Name = "lblTongDonHang";
            this.lblTongDonHang.Size = new System.Drawing.Size(105, 17);
            this.lblTongDonHang.TabIndex = 2;
            this.lblTongDonHang.Text = "Tổng đơn hàng: ";
            // 
            // lblPhiVanChuyen
            // 
            this.lblPhiVanChuyen.AutoSize = true;
            this.lblPhiVanChuyen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhiVanChuyen.Location = new System.Drawing.Point(622, 139);
            this.lblPhiVanChuyen.Name = "lblPhiVanChuyen";
            this.lblPhiVanChuyen.Size = new System.Drawing.Size(100, 17);
            this.lblPhiVanChuyen.TabIndex = 2;
            this.lblPhiVanChuyen.Text = "Phí vận chuyển: ";
            // 
            // numTongDonHang
            // 
            this.numTongDonHang.BackColor = System.Drawing.Color.Transparent;
            this.numTongDonHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numTongDonHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numTongDonHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numTongDonHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numTongDonHang.DisabledState.Parent = this.numTongDonHang;
            this.numTongDonHang.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numTongDonHang.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numTongDonHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numTongDonHang.FocusedState.Parent = this.numTongDonHang;
            this.numTongDonHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTongDonHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numTongDonHang.Location = new System.Drawing.Point(747, 93);
            this.numTongDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTongDonHang.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTongDonHang.Name = "numTongDonHang";
            this.numTongDonHang.ShadowDecoration.Parent = this.numTongDonHang;
            this.numTongDonHang.Size = new System.Drawing.Size(173, 31);
            this.numTongDonHang.TabIndex = 4;
            this.numTongDonHang.ThousandsSeparator = true;
            // 
            // numPhiVanChuyen
            // 
            this.numPhiVanChuyen.BackColor = System.Drawing.Color.Transparent;
            this.numPhiVanChuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numPhiVanChuyen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numPhiVanChuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numPhiVanChuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numPhiVanChuyen.DisabledState.Parent = this.numPhiVanChuyen;
            this.numPhiVanChuyen.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numPhiVanChuyen.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numPhiVanChuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numPhiVanChuyen.FocusedState.Parent = this.numPhiVanChuyen;
            this.numPhiVanChuyen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPhiVanChuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numPhiVanChuyen.Location = new System.Drawing.Point(747, 132);
            this.numPhiVanChuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPhiVanChuyen.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numPhiVanChuyen.Name = "numPhiVanChuyen";
            this.numPhiVanChuyen.ShadowDecoration.Parent = this.numPhiVanChuyen;
            this.numPhiVanChuyen.Size = new System.Drawing.Size(173, 31);
            this.numPhiVanChuyen.TabIndex = 4;
            this.numPhiVanChuyen.ThousandsSeparator = true;
            // 
            // dtpNgayNhapKho
            // 
            this.dtpNgayNhapKho.CheckedState.Parent = this.dtpNgayNhapKho;
            this.dtpNgayNhapKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayNhapKho.ForeColor = System.Drawing.Color.White;
            this.dtpNgayNhapKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhapKho.HoverState.Parent = this.dtpNgayNhapKho;
            this.dtpNgayNhapKho.Location = new System.Drawing.Point(747, 171);
            this.dtpNgayNhapKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayNhapKho.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayNhapKho.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayNhapKho.Name = "dtpNgayNhapKho";
            this.dtpNgayNhapKho.ShadowDecoration.Parent = this.dtpNgayNhapKho;
            this.dtpNgayNhapKho.Size = new System.Drawing.Size(173, 31);
            this.dtpNgayNhapKho.TabIndex = 5;
            this.dtpNgayNhapKho.Value = new System.DateTime(2021, 4, 11, 18, 7, 48, 642);
            // 
            // lblNgayNhapKho
            // 
            this.lblNgayNhapKho.AutoSize = true;
            this.lblNgayNhapKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhapKho.Location = new System.Drawing.Point(622, 178);
            this.lblNgayNhapKho.Name = "lblNgayNhapKho";
            this.lblNgayNhapKho.Size = new System.Drawing.Size(104, 17);
            this.lblNgayNhapKho.TabIndex = 2;
            this.lblNgayNhapKho.Text = "Ngày nhập kho: ";
            // 
            // lblNgayGui
            // 
            this.lblNgayGui.AutoSize = true;
            this.lblNgayGui.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayGui.Location = new System.Drawing.Point(622, 385);
            this.lblNgayGui.Name = "lblNgayGui";
            this.lblNgayGui.Size = new System.Drawing.Size(102, 17);
            this.lblNgayGui.TabIndex = 2;
            this.lblNgayGui.Text = "Ngày gửi hàng: ";
            // 
            // dtpNgayGui
            // 
            this.dtpNgayGui.CheckedState.Parent = this.dtpNgayGui;
            this.dtpNgayGui.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayGui.ForeColor = System.Drawing.Color.White;
            this.dtpNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayGui.HoverState.Parent = this.dtpNgayGui;
            this.dtpNgayGui.Location = new System.Drawing.Point(747, 378);
            this.dtpNgayGui.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayGui.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayGui.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayGui.Name = "dtpNgayGui";
            this.dtpNgayGui.ShadowDecoration.Parent = this.dtpNgayGui;
            this.dtpNgayGui.Size = new System.Drawing.Size(173, 31);
            this.dtpNgayGui.TabIndex = 5;
            this.dtpNgayGui.Value = new System.DateTime(2021, 4, 11, 18, 7, 48, 642);
            // 
            // gbxTrangThaiDH
            // 
            this.gbxTrangThaiDH.Controls.Add(this.rdbTonKho);
            this.gbxTrangThaiDH.Controls.Add(this.rdbHoanTra);
            this.gbxTrangThaiDH.Controls.Add(this.rdbGiaoThanhCong);
            this.gbxTrangThaiDH.Controls.Add(this.rtxtNguyenNhanHoanTra);
            this.gbxTrangThaiDH.Controls.Add(this.lblNguyenNhanHoanTra);
            this.gbxTrangThaiDH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTrangThaiDH.Location = new System.Drawing.Point(623, 210);
            this.gbxTrangThaiDH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTrangThaiDH.Name = "gbxTrangThaiDH";
            this.gbxTrangThaiDH.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxTrangThaiDH.Size = new System.Drawing.Size(297, 160);
            this.gbxTrangThaiDH.TabIndex = 6;
            this.gbxTrangThaiDH.TabStop = false;
            this.gbxTrangThaiDH.Text = "Trạng thái đơn hàng";
            // 
            // rtxtNguyenNhanHoanTra
            // 
            this.rtxtNguyenNhanHoanTra.Location = new System.Drawing.Point(100, 67);
            this.rtxtNguyenNhanHoanTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtNguyenNhanHoanTra.Name = "rtxtNguyenNhanHoanTra";
            this.rtxtNguyenNhanHoanTra.Size = new System.Drawing.Size(190, 84);
            this.rtxtNguyenNhanHoanTra.TabIndex = 8;
            this.rtxtNguyenNhanHoanTra.Text = "";
            // 
            // lblNguyenNhanHoanTra
            // 
            this.lblNguyenNhanHoanTra.Location = new System.Drawing.Point(7, 67);
            this.lblNguyenNhanHoanTra.Name = "lblNguyenNhanHoanTra";
            this.lblNguyenNhanHoanTra.Size = new System.Drawing.Size(98, 35);
            this.lblNguyenNhanHoanTra.TabIndex = 7;
            this.lblNguyenNhanHoanTra.Text = "Nguyên nhân hoàn trả: ";
            // 
            // cboKhachHangGui
            // 
            this.cboKhachHangGui.BackColor = System.Drawing.Color.Transparent;
            this.cboKhachHangGui.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhachHangGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHangGui.FocusedColor = System.Drawing.Color.Empty;
            this.cboKhachHangGui.FocusedState.Parent = this.cboKhachHangGui;
            this.cboKhachHangGui.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhachHangGui.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKhachHangGui.FormattingEnabled = true;
            this.cboKhachHangGui.HoverState.Parent = this.cboKhachHangGui;
            this.cboKhachHangGui.ItemHeight = 30;
            this.cboKhachHangGui.ItemsAppearance.Parent = this.cboKhachHangGui;
            this.cboKhachHangGui.Location = new System.Drawing.Point(747, 417);
            this.cboKhachHangGui.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboKhachHangGui.Name = "cboKhachHangGui";
            this.cboKhachHangGui.ShadowDecoration.Parent = this.cboKhachHangGui;
            this.cboKhachHangGui.Size = new System.Drawing.Size(173, 36);
            this.cboKhachHangGui.TabIndex = 7;
            // 
            // lblKhachHangGui
            // 
            this.lblKhachHangGui.AutoSize = true;
            this.lblKhachHangGui.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHangGui.Location = new System.Drawing.Point(622, 427);
            this.lblKhachHangGui.Name = "lblKhachHangGui";
            this.lblKhachHangGui.Size = new System.Drawing.Size(106, 17);
            this.lblKhachHangGui.TabIndex = 2;
            this.lblKhachHangGui.Text = "Khách hàng gửi: ";
            // 
            // lblKhachHangNhan
            // 
            this.lblKhachHangNhan.AutoSize = true;
            this.lblKhachHangNhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHangNhan.Location = new System.Drawing.Point(622, 471);
            this.lblKhachHangNhan.Name = "lblKhachHangNhan";
            this.lblKhachHangNhan.Size = new System.Drawing.Size(115, 17);
            this.lblKhachHangNhan.TabIndex = 2;
            this.lblKhachHangNhan.Text = "Khách hàng nhận: ";
            // 
            // cboKhachHangNhan
            // 
            this.cboKhachHangNhan.BackColor = System.Drawing.Color.Transparent;
            this.cboKhachHangNhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboKhachHangNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHangNhan.FocusedColor = System.Drawing.Color.Empty;
            this.cboKhachHangNhan.FocusedState.Parent = this.cboKhachHangNhan;
            this.cboKhachHangNhan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhachHangNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboKhachHangNhan.FormattingEnabled = true;
            this.cboKhachHangNhan.HoverState.Parent = this.cboKhachHangNhan;
            this.cboKhachHangNhan.ItemHeight = 30;
            this.cboKhachHangNhan.ItemsAppearance.Parent = this.cboKhachHangNhan;
            this.cboKhachHangNhan.Location = new System.Drawing.Point(747, 461);
            this.cboKhachHangNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboKhachHangNhan.Name = "cboKhachHangNhan";
            this.cboKhachHangNhan.ShadowDecoration.Parent = this.cboKhachHangNhan;
            this.cboKhachHangNhan.Size = new System.Drawing.Size(173, 36);
            this.cboKhachHangNhan.TabIndex = 7;
            // 
            // lblNVGiaoHang
            // 
            this.lblNVGiaoHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNVGiaoHang.Location = new System.Drawing.Point(623, 504);
            this.lblNVGiaoHang.Name = "lblNVGiaoHang";
            this.lblNVGiaoHang.Size = new System.Drawing.Size(134, 38);
            this.lblNVGiaoHang.TabIndex = 2;
            this.lblNVGiaoHang.Text = "Nhân viên phụ trách giao hàng: ";
            // 
            // cboNVGiaoHang
            // 
            this.cboNVGiaoHang.BackColor = System.Drawing.Color.Transparent;
            this.cboNVGiaoHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNVGiaoHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVGiaoHang.FocusedColor = System.Drawing.Color.Empty;
            this.cboNVGiaoHang.FocusedState.Parent = this.cboNVGiaoHang;
            this.cboNVGiaoHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNVGiaoHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboNVGiaoHang.FormattingEnabled = true;
            this.cboNVGiaoHang.HoverState.Parent = this.cboNVGiaoHang;
            this.cboNVGiaoHang.ItemHeight = 30;
            this.cboNVGiaoHang.ItemsAppearance.Parent = this.cboNVGiaoHang;
            this.cboNVGiaoHang.Location = new System.Drawing.Point(747, 505);
            this.cboNVGiaoHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboNVGiaoHang.Name = "cboNVGiaoHang";
            this.cboNVGiaoHang.ShadowDecoration.Parent = this.cboNVGiaoHang;
            this.cboNVGiaoHang.Size = new System.Drawing.Size(173, 36);
            this.cboNVGiaoHang.TabIndex = 7;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlTitle;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Location = new System.Drawing.Point(23, 549);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 15);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "0 đơn hàng";
            // 
            // btnXoa
            // 
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.Recycle_Bin;
            this.btnXoa.Location = new System.Drawing.Point(681, 547);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(117, 39);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.Home;
            this.btnBack.Location = new System.Drawing.Point(804, 547);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(117, 39);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Trở về";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.CheckedState.Parent = this.btnCapNhat;
            this.btnCapNhat.CustomImages.Parent = this.btnCapNhat;
            this.btnCapNhat.FillColor = System.Drawing.Color.Lime;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.HoverState.Parent = this.btnCapNhat;
            this.btnCapNhat.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.Edit;
            this.btnCapNhat.Location = new System.Drawing.Point(558, 547);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ShadowDecoration.Parent = this.btnCapNhat;
            this.btnCapNhat.Size = new System.Drawing.Size(117, 39);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTTDonHang
            // 
            this.btnTTDonHang.CheckedState.Parent = this.btnTTDonHang;
            this.btnTTDonHang.CustomImages.Parent = this.btnTTDonHang;
            this.btnTTDonHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTTDonHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTDonHang.ForeColor = System.Drawing.Color.Black;
            this.btnTTDonHang.HoverState.Parent = this.btnTTDonHang;
            this.btnTTDonHang.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.List;
            this.btnTTDonHang.Location = new System.Drawing.Point(312, 547);
            this.btnTTDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTTDonHang.Name = "btnTTDonHang";
            this.btnTTDonHang.ShadowDecoration.Parent = this.btnTTDonHang;
            this.btnTTDonHang.Size = new System.Drawing.Size(117, 39);
            this.btnTTDonHang.TabIndex = 8;
            this.btnTTDonHang.Text = "Sản phẩm";
            this.btnTTDonHang.Click += new System.EventHandler(this.btnTTDonHang_Click);
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = global::HeThongQLDVGiaoHangNhanh.Properties.Resources.Add;
            this.btnThem.Location = new System.Drawing.Point(435, 547);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(117, 39);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rdbGiaoThanhCong
            // 
            this.rdbGiaoThanhCong.AutoSize = true;
            this.rdbGiaoThanhCong.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbGiaoThanhCong.CheckedState.BorderThickness = 0;
            this.rdbGiaoThanhCong.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbGiaoThanhCong.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbGiaoThanhCong.CheckedState.InnerOffset = -4;
            this.rdbGiaoThanhCong.Location = new System.Drawing.Point(85, 25);
            this.rdbGiaoThanhCong.Name = "rdbGiaoThanhCong";
            this.rdbGiaoThanhCong.Size = new System.Drawing.Size(122, 21);
            this.rdbGiaoThanhCong.TabIndex = 9;
            this.rdbGiaoThanhCong.TabStop = true;
            this.rdbGiaoThanhCong.Text = "Giao thành công";
            this.rdbGiaoThanhCong.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbGiaoThanhCong.UncheckedState.BorderThickness = 2;
            this.rdbGiaoThanhCong.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbGiaoThanhCong.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbGiaoThanhCong.UseVisualStyleBackColor = true;
            // 
            // rdbHoanTra
            // 
            this.rdbHoanTra.AutoSize = true;
            this.rdbHoanTra.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbHoanTra.CheckedState.BorderThickness = 0;
            this.rdbHoanTra.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbHoanTra.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbHoanTra.CheckedState.InnerOffset = -4;
            this.rdbHoanTra.Location = new System.Drawing.Point(213, 25);
            this.rdbHoanTra.Name = "rdbHoanTra";
            this.rdbHoanTra.Size = new System.Drawing.Size(77, 21);
            this.rdbHoanTra.TabIndex = 9;
            this.rdbHoanTra.TabStop = true;
            this.rdbHoanTra.Text = "Hoàn trả";
            this.rdbHoanTra.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbHoanTra.UncheckedState.BorderThickness = 2;
            this.rdbHoanTra.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbHoanTra.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbHoanTra.UseVisualStyleBackColor = true;
            this.rdbHoanTra.CheckedChanged += new System.EventHandler(this.rdbHoanTra_CheckedChanged);
            // 
            // rdbTonKho
            // 
            this.rdbTonKho.AutoSize = true;
            this.rdbTonKho.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbTonKho.CheckedState.BorderThickness = 0;
            this.rdbTonKho.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbTonKho.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbTonKho.CheckedState.InnerOffset = -4;
            this.rdbTonKho.Location = new System.Drawing.Point(6, 25);
            this.rdbTonKho.Name = "rdbTonKho";
            this.rdbTonKho.Size = new System.Drawing.Size(73, 21);
            this.rdbTonKho.TabIndex = 9;
            this.rdbTonKho.TabStop = true;
            this.rdbTonKho.Text = "Tồn kho";
            this.rdbTonKho.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbTonKho.UncheckedState.BorderThickness = 2;
            this.rdbTonKho.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbTonKho.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdbTonKho.UseVisualStyleBackColor = true;
            this.rdbTonKho.CheckedChanged += new System.EventHandler(this.rdbTonKho_CheckedChanged);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 599);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnTTDonHang);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboNVGiaoHang);
            this.Controls.Add(this.cboKhachHangNhan);
            this.Controls.Add(this.cboKhachHangGui);
            this.Controls.Add(this.gbxTrangThaiDH);
            this.Controls.Add(this.dtpNgayGui);
            this.Controls.Add(this.lblNVGiaoHang);
            this.Controls.Add(this.dtpNgayNhapKho);
            this.Controls.Add(this.lblKhachHangNhan);
            this.Controls.Add(this.numPhiVanChuyen);
            this.Controls.Add(this.lblKhachHangGui);
            this.Controls.Add(this.lblNgayGui);
            this.Controls.Add(this.numTongDonHang);
            this.Controls.Add(this.lblNgayNhapKho);
            this.Controls.Add(this.lblPhiVanChuyen);
            this.Controls.Add(this.lblTongDonHang);
            this.Controls.Add(this.txtMaVanDon);
            this.Controls.Add(this.lblMaVanDon);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.pnlTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đơn hàng";
            this.Load += new System.EventHandler(this.OrderManagement_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTongDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhiVanChuyen)).EndInit();
            this.gbxTrangThaiDH.ResumeLayout(false);
            this.gbxTrangThaiDH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonHang;
        private System.Windows.Forms.Label lblMaVanDon;
        private Guna.UI2.WinForms.Guna2TextBox txtMaVanDon;
        private System.Windows.Forms.Label lblTongDonHang;
        private System.Windows.Forms.Label lblPhiVanChuyen;
        private Guna.UI2.WinForms.Guna2NumericUpDown numTongDonHang;
        private Guna.UI2.WinForms.Guna2NumericUpDown numPhiVanChuyen;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayNhapKho;
        private System.Windows.Forms.Label lblNgayNhapKho;
        private System.Windows.Forms.Label lblNgayGui;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayGui;
        private System.Windows.Forms.GroupBox gbxTrangThaiDH;
        private System.Windows.Forms.Label lblNguyenNhanHoanTra;
        private Guna.UI2.WinForms.Guna2ComboBox cboKhachHangGui;
        private System.Windows.Forms.Label lblKhachHangGui;
        private System.Windows.Forms.RichTextBox rtxtNguyenNhanHoanTra;
        private System.Windows.Forms.Label lblKhachHangNhan;
        private Guna.UI2.WinForms.Guna2ComboBox cboKhachHangNhan;
        private System.Windows.Forms.Label lblNVGiaoHang;
        private Guna.UI2.WinForms.Guna2ComboBox cboNVGiaoHang;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
        private Guna.UI2.WinForms.Guna2Button btnTTDonHang;
        private Guna.UI2.WinForms.Guna2RadioButton rdbHoanTra;
        private Guna.UI2.WinForms.Guna2RadioButton rdbGiaoThanhCong;
        private Guna.UI2.WinForms.Guna2RadioButton rdbTonKho;
    }
}