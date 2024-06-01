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
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(LoginAccount); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangeAccount(Account acc)
        {
            txtUsername.Text = LoginAccount.UserName;
            txtDisplayName.Text = LoginAccount.DisplayName;
        }
        void UpdateAccount()
        {
            string displayName = txtDisplayName.Text;
            string passWord = txtPassword.Text;
            string newpass = txtNewPassword.Text;
            string reenterpass = txtReEnterPassword.Text;
            string userName = txtUsername.Text;

            if (!newpass.Equals(reenterpass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, passWord, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                    {
                        updateAccount(this,new AccountEvent(AccountDAO.Instance.GetAccountByUsername(userName)));
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccountEvent
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btcapNhat_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

    }

    public class AccountEvent : EventArgs
    {
        private Account acc;
        public Account Acc 
        { 
        get { return acc; }
        set { acc = value; }
        }
        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
