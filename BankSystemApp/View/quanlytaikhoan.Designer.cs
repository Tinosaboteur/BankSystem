using System;

namespace BankSystem
{
	partial class quanlytaikhoan
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
		/// 

		private void InitializeComponent()
		{
			this.label3 = new System.Windows.Forms.Label();
			this.balanceTextbox = new System.Windows.Forms.TextBox();
			this.balanceLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dateOpen = new System.Windows.Forms.TextBox();
			this.Date_open = new System.Windows.Forms.Label();
			this.customerIdTextBox = new System.Windows.Forms.TextBox();
			this.customerLabel = new System.Windows.Forms.Label();
			this.addButton = new System.Windows.Forms.Button();
			this.searchButton = new System.Windows.Forms.Button();
			this.accountDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.a = new System.Windows.Forms.Label();
			this.accountIdTextBox = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(136, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(348, 41);
			this.label3.TabIndex = 4;
			this.label3.Text = "Quản lý tài khoản ";
			// 
			// balanceTextbox
			// 
			this.balanceTextbox.Location = new System.Drawing.Point(217, 157);
			this.balanceTextbox.Name = "balanceTextbox";
			this.balanceTextbox.Size = new System.Drawing.Size(230, 31);
			this.balanceTextbox.TabIndex = 3;
			// 
			// balanceLabel
			// 
			this.balanceLabel.AutoSize = true;
			this.balanceLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.balanceLabel.Location = new System.Drawing.Point(112, 160);
			this.balanceLabel.Name = "balanceLabel";
			this.balanceLabel.Size = new System.Drawing.Size(58, 23);
			this.balanceLabel.TabIndex = 1;
			this.balanceLabel.Text = "Số dư";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dateOpen);
			this.groupBox1.Controls.Add(this.Date_open);
			this.groupBox1.Controls.Add(this.customerIdTextBox);
			this.groupBox1.Controls.Add(this.customerLabel);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.balanceTextbox);
			this.groupBox1.Controls.Add(this.balanceLabel);
			this.groupBox1.Location = new System.Drawing.Point(298, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(582, 320);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// dateOpen
			// 
			this.dateOpen.Location = new System.Drawing.Point(217, 231);
			this.dateOpen.Name = "dateOpen";
			this.dateOpen.Size = new System.Drawing.Size(230, 31);
			this.dateOpen.TabIndex = 10;
			// 
			// Date_open
			// 
			this.Date_open.AutoSize = true;
			this.Date_open.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.Date_open.Location = new System.Drawing.Point(112, 228);
			this.Date_open.Name = "Date_open";
			this.Date_open.Size = new System.Drawing.Size(85, 23);
			this.Date_open.TabIndex = 9;
			this.Date_open.Text = "Ngày mở";
			this.Date_open.Click += new System.EventHandler(this.Date_open_Click);
			// 
			// customerIdTextBox
			// 
			this.customerIdTextBox.Location = new System.Drawing.Point(217, 194);
			this.customerIdTextBox.Name = "customerIdTextBox";
			this.customerIdTextBox.Size = new System.Drawing.Size(230, 31);
			this.customerIdTextBox.TabIndex = 8;
			// 
			// customerLabel
			// 
			this.customerLabel.AutoSize = true;
			this.customerLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.customerLabel.Location = new System.Drawing.Point(112, 194);
			this.customerLabel.Name = "customerLabel";
			this.customerLabel.Size = new System.Drawing.Size(134, 23);
			this.customerLabel.TabIndex = 7;
			this.customerLabel.Text = "Mã khách hàng";
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(442, 36);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(89, 41);
			this.addButton.TabIndex = 9;
			this.addButton.Text = "Thêm";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchButton.Location = new System.Drawing.Point(168, 65);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(97, 31);
			this.searchButton.TabIndex = 5;
			this.searchButton.Text = "Tìm kiếm";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// accountDataGridView
			// 
			this.accountDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.accountDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.accountDataGridView.Location = new System.Drawing.Point(43, 358);
			this.accountDataGridView.Name = "accountDataGridView";
			this.accountDataGridView.RowHeadersWidth = 51;
			this.accountDataGridView.RowTemplate.Height = 24;
			this.accountDataGridView.Size = new System.Drawing.Size(1008, 200);
			this.accountDataGridView.TabIndex = 5;
			this.accountDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerDataGridView_RowHeaderMouseClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.a);
			this.groupBox3.Controls.Add(this.addButton);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox3.Location = new System.Drawing.Point(0, 518);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1102, 100);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// a
			// 
			this.a.AutoSize = true;
			this.a.Location = new System.Drawing.Point(256, 19);
			this.a.Name = "a";
			this.a.Size = new System.Drawing.Size(0, 25);
			this.a.TabIndex = 9;
			// 
			// accountIdTextBox
			// 
			this.accountIdTextBox.Location = new System.Drawing.Point(35, 29);
			this.accountIdTextBox.Name = "accountIdTextBox";
			this.accountIdTextBox.Size = new System.Drawing.Size(221, 30);
			this.accountIdTextBox.TabIndex = 10;
			this.accountIdTextBox.TextChanged += new System.EventHandler(this.accountIdTextBox_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.accountIdTextBox);
			this.groupBox2.Controls.Add(this.searchButton);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(0, 50);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(265, 97);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Nhập IDAccount cần tìm kiếm";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// quanlytaikhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1102, 618);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.accountDataGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "quanlytaikhoan";
			this.Text = "Quản lý tài khoản";
			this.Load += new System.EventHandler(this.AccountView_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.accountDataGridView)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox balanceTextbox;
		private System.Windows.Forms.Label balanceLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label customerLabel;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.DataGridView accountDataGridView;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox accountIdTextBox;
		private System.Windows.Forms.Label a;
		private System.Windows.Forms.TextBox customerIdTextBox;
		private System.Windows.Forms.Label Date_open;
		private System.Windows.Forms.TextBox dateOpen;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}