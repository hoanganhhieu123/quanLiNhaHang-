using QuanLiQuanCafe.DAO;
using QuanLiQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafe
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }


        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương tình?","Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassWord.Text;
            if (Login(username,password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUsername(username);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
            
        }

        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username,password);
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
