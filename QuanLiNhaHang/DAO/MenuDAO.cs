using QuanLiQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }

        public List<DTO.Menu> GetListMenuByTable(int id)
        {
            List<DTO.Menu> listMenu = new List<DTO.Menu>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select Food.name,BillInfor.count,Food.price,Food.price*BillInfor.count as totalPrice from dbo.BillInfor,dbo.Bill,dbo.Food where BillInfor.idBill = Bill.id and BillInfor.idFood = Food.id and Bill.status = 0 and Bill.idTable = " + id);
            foreach (DataRow item in data.Rows)
            {
                DTO.Menu menu = new DTO.Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
