namespace QuanLiQuanCafe
{
    partial class fAccountProfile
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReEnterPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btcapNhat = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(134, 37);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(337, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hiển thị";
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(134, 77);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(337, 22);
            this.txtDisplayName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(33, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(134, 124);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(337, 22);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(42, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập lại";
            // 
            // txtReEnterPassword
            // 
            this.txtReEnterPassword.Location = new System.Drawing.Point(134, 227);
            this.txtReEnterPassword.Name = "txtReEnterPassword";
            this.txtReEnterPassword.Size = new System.Drawing.Size(337, 22);
            this.txtReEnterPassword.TabIndex = 1;
            this.txtReEnterPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(23, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật khẩu mới";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(134, 174);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(337, 22);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // btcapNhat
            // 
            this.btcapNhat.BackColor = System.Drawing.Color.Tomato;
            this.btcapNhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btcapNhat.Location = new System.Drawing.Point(272, 304);
            this.btcapNhat.Name = "btcapNhat";
            this.btcapNhat.Size = new System.Drawing.Size(94, 32);
            this.btcapNhat.TabIndex = 2;
            this.btcapNhat.Text = "Cập nhật";
            this.btcapNhat.UseVisualStyleBackColor = false;
            this.btcapNhat.Click += new System.EventHandler(this.btcapNhat_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Tomato;
            this.btThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThoat.Location = new System.Drawing.Point(406, 304);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(94, 32);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // fAccountProfile
            // 
            this.AcceptButton = this.btcapNhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.CancelButton = this.btThoat;
            this.ClientSize = new System.Drawing.Size(565, 370);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btcapNhat);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtReEnterPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtDisplayName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.Name = "fAccountProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReEnterPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btcapNhat;
        private System.Windows.Forms.Button btThoat;
    }
}