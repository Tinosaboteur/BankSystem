using BankSystem.Controller;

namespace BankSystem.View
{
    partial class trangchu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trangchu));
			this.transactionAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.withdrawAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.depositAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.branchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.createCustomerToolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.createAccountToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.depositAmounttoolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.withdrawToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.transactionAmounttoolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// transactionAmountToolStripMenuItem
			// 
			this.transactionAmountToolStripMenuItem.Name = "transactionAmountToolStripMenuItem";
			this.transactionAmountToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
			this.transactionAmountToolStripMenuItem.Text = "Chuyển khoản";
			this.transactionAmountToolStripMenuItem.Click += new System.EventHandler(this.chuyentienToolStripMenuItem_Click);
			// 
			// withdrawAmountToolStripMenuItem
			// 
			this.withdrawAmountToolStripMenuItem.Name = "withdrawAmountToolStripMenuItem";
			this.withdrawAmountToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
			this.withdrawAmountToolStripMenuItem.Text = "Rút tiền";
			this.withdrawAmountToolStripMenuItem.Click += new System.EventHandler(this.ruttienToolStripMenuItem_Click);
			// 
			// depositAmountToolStripMenuItem
			// 
			this.depositAmountToolStripMenuItem.Name = "depositAmountToolStripMenuItem";
			this.depositAmountToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
			this.depositAmountToolStripMenuItem.Text = "Nạp tiền";
			this.depositAmountToolStripMenuItem.Click += new System.EventHandler(this.naptienToolStripMenuItem_Click);
			// 
			// createAccountToolStripMenuItem
			// 
			this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
			this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
			this.createAccountToolStripMenuItem.Text = "Quản lý tài khoản";
			this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.taotaikhoanToolStripMenuItem_Click);
			// 
			// createCustomerToolStripMenuItem
			// 
			this.createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
			this.createCustomerToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
			this.createCustomerToolStripMenuItem.Text = "Quản lý khách hàng";
			this.createCustomerToolStripMenuItem.Click += new System.EventHandler(this.taokhachhangToolStripMenuItem_Click);
			// 
			// branchToolStripMenuItem
			// 
			this.branchToolStripMenuItem.Name = "branchToolStripMenuItem";
			this.branchToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
			this.branchToolStripMenuItem.Text = "Quản lý chi nhánh";
			this.branchToolStripMenuItem.Click += new System.EventHandler(this.chinhanhToolStripMenuItem_Click);
			// 
			// employeeToolStripMenuItem
			// 
			this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
			this.employeeToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
			this.employeeToolStripMenuItem.Text = "Quản lý nhân viên";
			this.employeeToolStripMenuItem.Click += new System.EventHandler(this.nhanvienToolStripMenuItem_Click);
			// 
			// systemToolStripMenuItem
			// 
			this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.branchToolStripMenuItem});
			this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
			this.systemToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
			this.systemToolStripMenuItem.Text = "System";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
			this.exitToolStripMenuItem.Text = "Thoát chương trình";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// logoutToolStripMenuItem
			// 
			this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
			this.logoutToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
			this.logoutToolStripMenuItem.Text = "Đăng xuất";
			this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// bankingToolStripMenuItem
			// 
			this.bankingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerToolStripMenuItem,
            this.createAccountToolStripMenuItem,
            this.depositAmountToolStripMenuItem,
            this.withdrawAmountToolStripMenuItem,
            this.transactionAmountToolStripMenuItem});
			this.bankingToolStripMenuItem.Name = "bankingToolStripMenuItem";
			this.bankingToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
			this.bankingToolStripMenuItem.Text = "Banking";
			// 
			// menuStrip1
			// 
			this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.bankingToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(900, 33);
			this.menuStrip1.TabIndex = 13;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerToolStripButton2,
            this.toolStripLabel1,
            this.toolStripSeparator4,
            this.createAccountToolStripButton,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.depositAmounttoolStripButton,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.withdrawToolStripButton,
            this.toolStripLabel4,
            this.toolStripSeparator2,
            this.transactionAmounttoolStripButton,
            this.toolStripLabel5});
			this.toolStrip1.Location = new System.Drawing.Point(0, 33);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(900, 39);
			this.toolStrip1.TabIndex = 15;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// createCustomerToolStripButton2
			// 
			this.createCustomerToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.createCustomerToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("createCustomerToolStripButton2.Image")));
			this.createCustomerToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.createCustomerToolStripButton2.Name = "createCustomerToolStripButton2";
			this.createCustomerToolStripButton2.Size = new System.Drawing.Size(34, 34);
			this.createCustomerToolStripButton2.Text = "Create Customer";
			this.createCustomerToolStripButton2.Click += new System.EventHandler(this.taokhachhangToolStripButton2_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(169, 34);
			this.toolStripLabel1.Text = "Quản lý khách hàng";
			this.toolStripLabel1.Click += new System.EventHandler(this.taokhachhangToolStripButton2_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
			// 
			// createAccountToolStripButton
			// 
			this.createAccountToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.createAccountToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("createAccountToolStripButton.Image")));
			this.createAccountToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.createAccountToolStripButton.Name = "createAccountToolStripButton";
			this.createAccountToolStripButton.Size = new System.Drawing.Size(34, 34);
			this.createAccountToolStripButton.Text = "Create Account";
			this.createAccountToolStripButton.Click += new System.EventHandler(this.taotaikhoanToolStripButton_Click);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(151, 34);
			this.toolStripLabel2.Text = "Quản lý tài khoản";
			this.toolStripLabel2.Click += new System.EventHandler(this.taotaikhoanToolStripButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
			// 
			// depositAmounttoolStripButton
			// 
			this.depositAmounttoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.depositAmounttoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("depositAmounttoolStripButton.Image")));
			this.depositAmounttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.depositAmounttoolStripButton.Name = "depositAmounttoolStripButton";
			this.depositAmounttoolStripButton.Size = new System.Drawing.Size(34, 34);
			this.depositAmounttoolStripButton.Text = "Deposit Amount";
			this.depositAmounttoolStripButton.Click += new System.EventHandler(this.naptientoolStripButton_Click);
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(79, 34);
			this.toolStripLabel3.Text = "Nạp tiền";
			this.toolStripLabel3.Click += new System.EventHandler(this.naptientoolStripButton_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
			// 
			// withdrawToolStripButton
			// 
			this.withdrawToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.withdrawToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("withdrawToolStripButton.Image")));
			this.withdrawToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.withdrawToolStripButton.Name = "withdrawToolStripButton";
			this.withdrawToolStripButton.Size = new System.Drawing.Size(34, 34);
			this.withdrawToolStripButton.Text = "Withdraw Amount";
			this.withdrawToolStripButton.Click += new System.EventHandler(this.ruttienToolStripButton_Click);
			// 
			// toolStripLabel4
			// 
			this.toolStripLabel4.Name = "toolStripLabel4";
			this.toolStripLabel4.Size = new System.Drawing.Size(73, 34);
			this.toolStripLabel4.Text = "Rút tiền";
			this.toolStripLabel4.Click += new System.EventHandler(this.ruttienToolStripButton_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
			// 
			// transactionAmounttoolStripButton
			// 
			this.transactionAmounttoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.transactionAmounttoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("transactionAmounttoolStripButton.Image")));
			this.transactionAmounttoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.transactionAmounttoolStripButton.Name = "transactionAmounttoolStripButton";
			this.transactionAmounttoolStripButton.Size = new System.Drawing.Size(34, 34);
			this.transactionAmounttoolStripButton.Text = "Transaction Amount";
			this.transactionAmounttoolStripButton.Click += new System.EventHandler(this.chuyentientoolStripButton_Click);
			// 
			// toolStripLabel5
			// 
			this.toolStripLabel5.Name = "toolStripLabel5";
			this.toolStripLabel5.Size = new System.Drawing.Size(105, 34);
			this.toolStripLabel5.Text = "Chuyển tiền";
			this.toolStripLabel5.Click += new System.EventHandler(this.chuyentientoolStripButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.label1.Location = new System.Drawing.Point(621, 255);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(301, 46);
			this.label1.TabIndex = 22;
			this.label1.Text = phien.employeeId;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.label2.Location = new System.Drawing.Point(621, 301);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(178, 46);
			this.label2.TabIndex = 23;
			this.label2.Text = phien.role;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.label3.Location = new System.Drawing.Point(524, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(443, 46);
			this.label3.TabIndex = 25;
			this.label3.Text = "XIN CHÀO NHÂN VIÊN";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.label4.Location = new System.Drawing.Point(524, 255);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 46);
			this.label4.TabIndex = 26;
			this.label4.Text = "ID:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.label5.Location = new System.Drawing.Point(524, 301);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(134, 46);
			this.label5.TabIndex = 27;
			this.label5.Text = "ROLE:";
			// 
			// trangchu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(900, 534);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "trangchu";
			this.Text = "Trang chủ";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.trangchuView_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem transactionAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositAmountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankingToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton createCustomerToolStripButton2;
        private System.Windows.Forms.ToolStripButton createAccountToolStripButton;
        private System.Windows.Forms.ToolStripButton depositAmounttoolStripButton;
        private System.Windows.Forms.ToolStripButton withdrawToolStripButton;
        private System.Windows.Forms.ToolStripButton transactionAmounttoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripLabel toolStripLabel4;
		private System.Windows.Forms.ToolStripLabel toolStripLabel5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}