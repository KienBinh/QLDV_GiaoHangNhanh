using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeThongQLDVGiaoHangNhanh
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region Tạo chữ chìm
        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername_Leave(null, new EventArgs());
            txtPassword_Leave(null, new EventArgs());
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tên đăng nhập")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Tên đăng nhập";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mật khẩu";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                Application.Exit();
        }

        #region Hiển thị / Ẩn mật khẩu
        private void btnEyePass_Click(object sender, EventArgs e)
        {
            btnEyeClosePass.BringToFront();
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnEyeClosePass_Click(object sender, EventArgs e)
        {
            btnEyePass.BringToFront();
            txtPassword.UseSystemPasswordChar = true;
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
