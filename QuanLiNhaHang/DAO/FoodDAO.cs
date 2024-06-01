using QuanLiQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCafe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;
        public static FoodDAO Instance
        {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }

        public List<DTO.Food> GetFoodByCategory(int id)
        {
            List<DTO.Food> list = new List<DTO.Food>();
            string query = "select * from Food where idCategory = "+ id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public List<DTO.Food> GetListFood()
        {
            List<DTO.Food> list = new List<DTO.Food>();
            string query = "select * from Food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public List<Food> SearchFoodByName(string name)
        {
            List<DTO.Food> list = new List<DTO.Food>();
            string query = string.Format("select * from Food where name LIKE N'%{0}%'",name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public bool InsertFood(string name,int id, float price, int quantity)
        {
            string query = string.Format("insert dbo.Food (name, idCategory,price,quantity) values(N'{0}',{1},{2},{3})", name, id, price,quantity);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }

        public bool Updatefood(int idFood, string name, int id, float price,int quantity)
        {
            string query = string.Format("update dbo.Food set name = N'{0}', idCategory = {1},price = {2},quantity = {4} where id = {3}", name, id, price,idFood,quantity);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }

        public bool DeleteFood(int idFood)
        {
            BillInforDAO.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("delete Food where id = {0}",idFood);
            int rs = DataProvider.Instance.ExecuteNonQuery(query);
            return rs > 0;
        }
    }
}
