using QuanLiQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }
        // size button TableFood
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        private TableDAO() { }

        public void swapTable(int id1 ,int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_ChuyenBan " + id1+"," +id2);
        }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }

        public bool InsertTable(string name, string status)
        {
            string query = string.Format("insert dbo.TableFood (name, status) values(N'{0}',N'{1}')", name, status);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }

        public bool UpdateTable(string name, string status,int id)
        {
            string query = string.Format("update dbo.TableFood set  name = N'{1}',status = N'{2}' where id = {0}", id, name, status);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }

        public bool DeleteTable(string name)
        {

            string query = string.Format("delete TableFood where name = N'{0}'", name);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }


        public DataTable GetListTable()
        {
            return DataProvider.Instance.ExecuteQuery("select * from dbo.TableFood");
        }
    }
}
