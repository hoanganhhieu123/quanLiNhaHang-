namespace QuanLiQuanCafe
{
    partial class fLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(54, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(185, 87);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(256, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(185, 129);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(256, 22);
            this.txtPassWord.TabIndex = 3;
            this.txtPassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(73, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.Tomato;
            this.btDangNhap.ForeColor = System.Drawing.Color.Firebrick;
            this.btDangNhap.Location = new System.Drawing.Point(134, 182);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(119, 40);
            this.btDangNhap.TabIndex = 4;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Tomato;
            this.btThoat.ForeColor = System.Drawing.Color.Firebrick;
            this.btThoat.Location = new System.Drawing.Point(271, 182);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 40);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(107, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Restaurant Management";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fLogin
            // 
            this.AcceptButton = this.btDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(541, 243);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.Load += new System.EventHandler(this.fLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label3;
    }
}

