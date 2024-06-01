using QuanLiQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafe.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }


        // hàm đăng nhập 
        public bool Login (string username, string password)
        {
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query,new object[] {username,password});
            return result.Rows.Count>0;
        }
        public bool UpdateAccount(string username, string displayname, string pass, string newpass)
        {
            int rs = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAccount '" + username + "','" + displayname + "','" + pass + "','" + newpass + "'");
            return rs > 0;
        }

        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("insert dbo.Account (UserName, DisplayName,Type) values(N'{0}',N'{1}',{2})", name, displayName, type);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }

        public bool UpdateAccount2(string name, string displayName, int type)
        {
            string query = string.Format("update dbo.Account set  DisplayName = N'{1}',type = {2} where UserName = N'{0}'", name, displayName, type);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }

        public bool DeleteAccount(string name)
        {

            string query = string.Format("delete Account where UserName = N'{0}'", name);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select DisplayName, UserName, type from dbo.Account");
        }

        public Account GetAccountByUsername (string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from account where UserName = '" + username+"'");
            foreach(DataRow item  in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}
