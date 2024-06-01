using QuanLiQuanCafe.DAO;
using QuanLiQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Reporting.WinForms;

namespace QuanLiQuanCafe
{
    public partial class fAdmin : Form
    {

        BindingSource foodList = new BindingSource();

        BindingSource accountList = new BindingSource();

        BindingSource categoryList = new BindingSource();

        BindingSource tableList = new BindingSource();
        public fAdmin()
        {
            InitializeComponent();
            load();
        }

        #region methods

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;
        }

        void load()
        {
            dgvFood.DataSource = foodList;
            dgvTK.DataSource = accountList;
            dgvDanhMuc.DataSource = categoryList;
            dgvBan.DataSource = tableList;
            LoadListBill();
            LoadCategoryIntoCombobox(cbbDanhMucMon);
            LoadListFood();
            LoadAccount();
            LoadCategory();
            LoadTable();
            AddFoodBinding();
            AddAccountBinding();
            AddCategoryBinding();
            AddTableBinding();
        }


        // ban an

        void AddTableBinding()
        {
            txtIDBan.DataBindings.Add(new Binding("Text", dgvBan.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenBan.DataBindings.Add(new Binding("Text", dgvBan.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtTrangThaiBan.DataBindings.Add(new Binding("Text", dgvBan.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }

        void LoadTable()
        {
            tableList.DataSource = TableDAO.Instance.GetListTable();
        }


        //danh muc mon an category
        void AddCategoryBinding()
        {
            txtIDDanhMuc.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenDanhMuc.DataBindings.Add(new Binding("Text", dgvDanhMuc.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        void LoadCategory()
        {
            categoryList.DataSource = CategoryDAO.Instance.GetListCate();
        }


        // account tai khoan

        void AddAccountBinding()
        {
            txtTenTK.DataBindings.Add(new Binding("Text", dgvTK.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtTenHienThi.DataBindings.Add(new Binding("Text", dgvTK.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Text", dgvTK.DataSource, "type", true,DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount2(userName, displayName, type))
            {
                MessageBox.Show("Sửa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }




        void LoadListBill()
        {
            dgvBill.DataSource = BillDAO.Instance.GetListBill();
        }

        // food mon an
        void AddFoodBinding()
        {
            txtTenMon.DataBindings.Add(new Binding("Text",dgvFood.DataSource,"Name"));
            txtIDMon.DataBindings.Add(new Binding("Text",dgvFood.DataSource,"ID"));
            nmGiaMon.DataBindings.Add(new Binding("Value", dgvFood.DataSource, "Price"));
            txtSoLuong.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Quantity"));
        }


        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }


        void LoadCategoryIntoCombobox(System.Windows.Forms.ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        #endregion



        #region Events

        private void btThemTK_Click(object sender, EventArgs e)
        {
            string userName = txtTenTK.Text;
            string displayName = txtTenHienThi.Text;
            int type = (int)numericUpDown1.Value;
            AddAccount(userName,displayName,type);
        }

        private void btXoaTK_Click(object sender, EventArgs e)
        {
            string userName = txtTenTK.Text;
            DeleteAccount(userName);

        }

        private void btSuaTK_Click(object sender, EventArgs e)
        {
            string userName = txtTenTK.Text;
            string displayName = txtTenHienThi.Text;
            int type = (int)numericUpDown1.Value;
            EditAccount(userName, displayName, type);
        }

        private void btTimMon_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txtSearchFoodName.Text);
        }

        private void btXemMon_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txtIDMon_TextChanged(object sender, EventArgs e)
        {
            if (dgvFood.SelectedCells.Count > 0)
            {
                int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                Category category = CategoryDAO.Instance.GetCategoryById(id);
                cbbDanhMucMon.SelectedItem = category;
                int index = -1;
                int i = 0;
                foreach (Category item in cbbDanhMucMon.Items)
                {
                    if (item.ID == category.ID)
                    {
                        index = i;
                        break;
                    }
                    i++;
                }
                cbbDanhMucMon.SelectedIndex = index;
            }


        }
        // them sua xoa mon an
        private void btThemMon_Click(object sender, EventArgs e)
        {
            string name = txtTenMon.Text;
            int categoryID = (cbbDanhMucMon.SelectedItem as Category).ID;
            float price = (float)nmGiaMon.Value;
            int quantity = Convert.ToInt32(txtSoLuong.Text);

            if (FoodDAO.Instance.InsertFood(name, categoryID, price,quantity))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                {
                    insertFood(this,new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }
        }

        private void btSuaMon_Click(object sender, EventArgs e)
        {
            string name = txtTenMon.Text;
            int categoryID = (cbbDanhMucMon.SelectedItem as Category).ID;
            float price = (float)nmGiaMon.Value;
            int idFood = Convert.ToInt32(txtIDMon.Text);
            int quantity = Convert.ToInt32(txtSoLuong.Text);
            if (FoodDAO.Instance.Updatefood(idFood, name, categoryID, price,quantity))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if(updateFood != null)
                {
                    updateFood(this,new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void btXoaMon_Click(object sender, EventArgs e)
        {
            int idFood = Convert.ToInt32(txtIDMon.Text);
            if (FoodDAO.Instance.DeleteFood(idFood))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                if (deleteFood != null)
                {
                    deleteFood(this,new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món ăn");
            }
        }
        //
        private void btXemTK_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }

        private void btXemDanhMuc_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void btXemBan_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        //them sua xoa ban
        private void btThemBan_Click(object sender, EventArgs e)
        {
            string name = txtTenBan.Text;
            string status = txtTrangThaiBan.Text;

            if (TableDAO.Instance.InsertTable(name, status))
            {
                MessageBox.Show("Thêm thông tin bàn thành công");
                LoadTable();
            }
            else
            {
                MessageBox.Show("Thêm thông tin bàn thất bại");
            }


        }

        private void btXoaBan_Click(object sender, EventArgs e)
        {
            string name = txtTenBan.Text;
            string status = txtTrangThaiBan.Text;


            if (TableDAO.Instance.DeleteTable(name))
            {
                MessageBox.Show("Xóa thông tin bàn thành công");
                LoadTable();
            }
            else
            {
                MessageBox.Show("Xóa thông tin bàn thất bại");
            }

        }

        private void btSuaBan_Click(object sender, EventArgs e)
        {
            string name = txtTenBan.Text;
            string status = txtTrangThaiBan.Text;
            int id = Convert.ToInt32(txtIDBan.Text);
            if (TableDAO.Instance.UpdateTable(name, status, id))
            {
                MessageBox.Show("Sửa thông tin bàn thành công");
                LoadTable();
            }
            else
            {
                MessageBox.Show("Sửa thông tin bàn thất bại");
            }

        }
        // them sua xoa danh muc thuc an
        private void btThemDanhMuc_Click(object sender, EventArgs e)
        {
            string name = txtTenDanhMuc.Text;

            if (CategoryDAO.Instance.InsertCate(name))
            {
                MessageBox.Show("Thêm thông tin danh mục thành công");
                LoadCategory();
            }
            else
            {
                MessageBox.Show("Thêm thông tin danh mục thất bại");
            }
        }

        private void btXoaDanhMuc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDanhMuc.Text);
            string name = txtTenDanhMuc.Text;


            if (CategoryDAO.Instance.DeleteCate (name))
            {
                MessageBox.Show("Xóa thông tin danh mục thành công");
                LoadCategory();
            }
            else
            {
                MessageBox.Show("Xóa thông tin danh mục thất bại");
            }
        }

        private void btSuaDanhMuc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIDDanhMuc.Text);
            string name = txtTenDanhMuc.Text;

            if (CategoryDAO.Instance.UpdateCate(id, name ))
            {
                MessageBox.Show("Sửa thông tin danh mục thành công");
                LoadCategory();
            }
            else
            {
                MessageBox.Show("Sửa thông tin danh mục thất bại");
            }
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {

        }




        #endregion
        /*
        private void fAdmin_Load(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            string sql = "select * from Bill";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"Bill");


            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLiQuanCafe.ReportBill.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["Bill"];

            this.reportViewer2.LocalReport.DataSources.Add(rds);

            this.reportViewer2.RefreshReport();
        }
        */


    }

}

