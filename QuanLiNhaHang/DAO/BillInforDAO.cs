using QuanLiQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafe.DAO
{
    public class BillInforDAO
    {
        private static BillInforDAO instance;
        public static BillInforDAO Instance
        {
            get { if (instance == null) instance = new BillInforDAO(); return BillInforDAO.instance; }
            private set { BillInforDAO.instance = value; }
        }

        private BillInforDAO() { }

        public void DeleteBillInfoByFoodID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.BillInfor where idFood = " + id);
        }

        public List<BillInfor> GetListBillInfor(int id)
        {
            List<BillInfor> listBillInfor = new List<BillInfor>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.BillInfor where idBill = " + id);
            
            foreach (DataRow item in data.Rows)
            {
                BillInfor info = new BillInfor(item);
                listBillInfor.Add(info);
            }
            return listBillInfor;
        }
        public void InsertBillInfor(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfor " + idBill +","+ idFood+"," + count );
        }
    }
}
