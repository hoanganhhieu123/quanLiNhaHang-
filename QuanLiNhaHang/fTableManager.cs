using QuanLiQuanCafe.DAO;
using QuanLiQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCafe
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(LoginAccount.Type); }
        }

        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadComboBoxTable(cbSwapTable);
            
        }

        #region Method
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinCáToolStripMenuItem.Text += " (" + loginAccount.DisplayName + ") ";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategory(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }
        void LoadTable()
        { 
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                flpTable.Controls.Add(btn);
                
            }
        }
        void ShowBill(int id)
        {
           lsvBill.Items.Clear();
            List<QuanLiQuanCafe.DTO.Menu> listBillInfor = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (QuanLiQuanCafe.DTO.Menu item in listBillInfor)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());      
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txtTotalPrice.Text = totalPrice.ToString("c",culture);
        }

        void LoadComboBoxTable(ComboBox comboBox)
        {
            comboBox.DataSource = TableDAO.Instance.LoadTableList();
            comboBox.DisplayMember = "Name";
        }
        #endregion

        #region Events
        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(LoginAccount);
            f.UpdateAccountEvent += F_UpdateAccountEvent;
            f.ShowDialog(); 
        }

        private void F_UpdateAccountEvent(object sender, AccountEvent e)
        {
            thôngTinCáToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.InsertFood += F_InsertFood;
            f.DeleteFood += F_DeleteFood;
            f.UpdateFood += F_UpdateFood;
            f.ShowDialog();
        }

        private void F_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        private void F_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

        private void F_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if(lsvBill.Tag != null)
            {
                ShowBill((lsvBill.Tag as Table).ID);
            }

        }

        private void cbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }

        private void btThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                Table table = lsvBill.Tag as Table;

                if (table == null)
                {
                    MessageBox.Show("Hãy chọn bàn");
                    return;
                }

                int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);

                int foodID = (cbFood.SelectedItem as Food).ID;

                int count = (int)nmFoodCount.Value;
                if (idBill == -1)
                {
                    BillDAO.Instance.InsertBill(table.ID);
                    BillInforDAO.Instance.InsertBillInfor(BillDAO.Instance.GetMaxIDBill(), foodID, count);
                }
                else
                {
                    BillInforDAO.Instance.InsertBillInfor(idBill, foodID, count);
                }
                ShowBill(table.ID);
                LoadTable();
            }
            catch
            {
                MessageBox.Show("Số lượng không đủ");
            }
            
        }
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nmDiscount.Value;
            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
            double result = (totalPrice - (totalPrice/100)*discount);
            if(idBill != -1)
            {
                if(MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho {0}\n Tổng tiền = {1}", table.Name,result),"Thông báo",MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill,discount,(float)result);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }          

        }

        private void btChuyenBan_Click(object sender, EventArgs e)
        {

            int id1 = (lsvBill.Tag as Table).ID;
            int id2 = (cbSwapTable.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} sang bàn {1}", (lsvBill.Tag as Table).Name, (cbSwapTable.SelectedItem as Table).Name),"Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.swapTable(id1, id2);
                LoadTable();
            }
            
        }


        #endregion

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
