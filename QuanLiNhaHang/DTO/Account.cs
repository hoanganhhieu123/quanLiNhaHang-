using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafe.DTO
{
    public class Account
    {
        public Account(string userName, string displayName, int type, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.type = type;
            this.password = password;
            
        }

        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.type = (int)row["type"];
            this.password = row["password"].ToString();
        }
        private string userName;
        public string UserName { get => userName; set => userName = value; }      

        private string displayName;
        public string DisplayName { get => displayName; set => displayName = value; }
        
        private string password;
        public string Password { get => password; set => password = value; }
        private int type;
        public int Type { get => type; set => type = value; }
    }
}
