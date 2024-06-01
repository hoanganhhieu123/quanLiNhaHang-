namespace QuanLiQuanCafe
{
    partial class fTableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSwapTable = new System.Windows.Forms.ComboBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btChuyenBan = new System.Windows.Forms.Button();
            this.btGiamGia = new System.Windows.Forms.Button();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btThemMon = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Coral;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinCáToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinCáToolStripMenuItem
            // 
            this.thôngTinCáToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinCáToolStripMenuItem.Name = "thôngTinCáToolStripMenuItem";
            this.thôngTinCáToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinCáToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.BackColor = System.Drawing.Color.Coral;
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.BackColor = System.Drawing.Color.Coral;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(630, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 338);
            this.panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            this.lsvBill.BackColor = System.Drawing.Color.Coral;
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 6);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(449, 326);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            this.lsvBill.SelectedIndexChanged += new System.EventHandler(this.lsvBill_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 103;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.cbSwapTable);
            this.panel3.Controls.Add(this.txtTotalPrice);
            this.panel3.Controls.Add(this.btThanhToan);
            this.panel3.Controls.Add(this.nmDiscount);
            this.panel3.Controls.Add(this.btChuyenBan);
            this.panel3.Controls.Add(this.btGiamGia);
            this.panel3.Location = new System.Drawing.Point(630, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 116);
            this.panel3.TabIndex = 3;
            // 
            // cbSwapTable
            // 
            this.cbSwapTable.BackColor = System.Drawing.Color.Snow;
            this.cbSwapTable.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbSwapTable.FormattingEnabled = true;
            this.cbSwapTable.Location = new System.Drawing.Point(4, 71);
            this.cbSwapTable.Name = "cbSwapTable";
            this.cbSwapTable.Size = new System.Drawing.Size(89, 24);
            this.cbSwapTable.TabIndex = 4;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Firebrick;
            this.txtTotalPrice.Location = new System.Drawing.Point(206, 19);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(218, 28);
            this.txtTotalPrice.TabIndex = 3;
            this.txtTotalPrice.Text = "0";
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.Tomato;
            this.btThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThanhToan.Location = new System.Drawing.Point(206, 57);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(218, 36);
            this.btThanhToan.TabIndex = 1;
            this.btThanhToan.Text = "Thanh toán";
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // nmDiscount
            // 
            this.nmDiscount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nmDiscount.Location = new System.Drawing.Point(99, 71);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(86, 22);
            this.nmDiscount.TabIndex = 2;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btChuyenBan
            // 
            this.btChuyenBan.BackColor = System.Drawing.Color.Tomato;
            this.btChuyenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChuyenBan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btChuyenBan.Location = new System.Drawing.Point(4, 7);
            this.btChuyenBan.Name = "btChuyenBan";
            this.btChuyenBan.Size = new System.Drawing.Size(89, 54);
            this.btChuyenBan.TabIndex = 1;
            this.btChuyenBan.Text = "Chuyển bàn";
            this.btChuyenBan.UseVisualStyleBackColor = false;
            this.btChuyenBan.Click += new System.EventHandler(this.btChuyenBan_Click);
            // 
            // btGiamGia
            // 
            this.btGiamGia.BackColor = System.Drawing.Color.Tomato;
            this.btGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGiamGia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btGiamGia.Location = new System.Drawing.Point(99, 7);
            this.btGiamGia.Name = "btGiamGia";
            this.btGiamGia.Size = new System.Drawing.Size(86, 54);
            this.btGiamGia.TabIndex = 1;
            this.btGiamGia.Text = "Giảm giá";
            this.btGiamGia.UseVisualStyleBackColor = false;
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.ForeColor = System.Drawing.SystemColors.InfoText;
            this.nmFoodCount.Location = new System.Drawing.Point(356, 17);
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(47, 22);
            this.nmFoodCount.TabIndex = 2;
            this.nmFoodCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Coral;
            this.panel4.Controls.Add(this.btThemMon);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.nmFoodCount);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(630, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(452, 82);
            this.panel4.TabIndex = 4;
            // 
            // btThemMon
            // 
            this.btThemMon.BackColor = System.Drawing.Color.Tomato;
            this.btThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemMon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThemMon.Location = new System.Drawing.Point(332, 40);
            this.btThemMon.Name = "btThemMon";
            this.btThemMon.Size = new System.Drawing.Size(102, 39);
            this.btThemMon.TabIndex = 1;
            this.btThemMon.Text = "Thêm món";
            this.btThemMon.UseVisualStyleBackColor = false;
            this.btThemMon.Click += new System.EventHandler(this.btThemMon_Click);
            // 
            // cbFood
            // 
            this.cbFood.BackColor = System.Drawing.SystemColors.Window;
            this.cbFood.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(4, 47);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(312, 24);
            this.cbFood.TabIndex = 0;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.SystemColors.Window;
            this.cbCategory.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(4, 17);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(312, 24);
            this.cbCategory.TabIndex = 0;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged_1);
            // 
            // flpTable
            // 
            this.flpTable.BackColor = System.Drawing.Color.Coral;
            this.flpTable.Location = new System.Drawing.Point(0, 32);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(624, 545);
            this.flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 579);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fTableManager";
            this.Text = "HoangAnhRestaurant";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btThemMon;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Button btGiamGia;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private System.Windows.Forms.Button btChuyenBan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.ComboBox cbSwapTable;
    }
}