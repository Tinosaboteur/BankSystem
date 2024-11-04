using System.Collections.Generic;

using System.Windows.Forms;
using System.Linq;

namespace BankSystem
{
	partial class quanlynhanvien
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being usedUpdateButton_Click
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
			this.userIdLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.userIdTextbox = new System.Windows.Forms.TextBox();
			this.passwordTextbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.roleComboBox = new System.Windows.Forms.ComboBox();
			this.roleLabel = new System.Windows.Forms.Label();
			this.searchButton = new System.Windows.Forms.Button();
			this.employeeDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.addButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.usersearchIdTextbox = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// userIdLabel
			// 
			this.userIdLabel.AutoSize = true;
			this.userIdLabel.Location = new System.Drawing.Point(24, 90);
			this.userIdLabel.Name = "userIdLabel";
			this.userIdLabel.Size = new System.Drawing.Size(121, 23);
			this.userIdLabel.TabIndex = 0;
			this.userIdLabel.Text = "Mã nhân viên";
			this.userIdLabel.Click += new System.EventHandler(this.userIdLabel_Click);
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(24, 123);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(90, 23);
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "Password";
			// 
			// userIdTextbox
			// 
			this.userIdTextbox.Location = new System.Drawing.Point(109, 87);
			this.userIdTextbox.Name = "userIdTextbox";
			this.userIdTextbox.Size = new System.Drawing.Size(230, 31);
			this.userIdTextbox.TabIndex = 2;
			// 
			// passwordTextbox
			// 
			this.passwordTextbox.Location = new System.Drawing.Point(109, 119);
			this.passwordTextbox.Name = "passwordTextbox";
			this.passwordTextbox.Size = new System.Drawing.Size(230, 31);
			this.passwordTextbox.TabIndex = 3;
			this.passwordTextbox.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Location = new System.Drawing.Point(75, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(362, 45);
			this.label3.TabIndex = 4;
			this.label3.Text = "Quản lý nhân viên";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.roleComboBox);
			this.groupBox1.Controls.Add(this.roleLabel);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.passwordTextbox);
			this.groupBox1.Controls.Add(this.userIdTextbox);
			this.groupBox1.Controls.Add(this.passwordLabel);
			this.groupBox1.Controls.Add(this.userIdLabel);
			this.groupBox1.Location = new System.Drawing.Point(355, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(466, 241);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// roleComboBox
			// 
			this.roleComboBox.DisplayMember = "Value";
			this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.roleComboBox.FormattingEnabled = true;
			this.roleComboBox.Items.AddRange(new object[] {
            "ADMIN",
            "USER"});
			this.roleComboBox.Location = new System.Drawing.Point(109, 151);
			this.roleComboBox.Name = "roleComboBox";
			this.roleComboBox.Size = new System.Drawing.Size(228, 30);
			this.roleComboBox.TabIndex = 8;
			this.roleComboBox.ValueMember = "Key";
			// 
			// roleLabel
			// 
			this.roleLabel.AutoSize = true;
			this.roleLabel.Location = new System.Drawing.Point(24, 154);
			this.roleLabel.Name = "roleLabel";
			this.roleLabel.Size = new System.Drawing.Size(50, 23);
			this.roleLabel.TabIndex = 7;
			this.roleLabel.Text = "Role";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(158, 69);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(98, 35);
			this.searchButton.TabIndex = 5;
			this.searchButton.Text = "Tìm kiếm";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// employeeDataGridView
			// 
			this.employeeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.employeeDataGridView.Location = new System.Drawing.Point(53, 291);
			this.employeeDataGridView.Name = "employeeDataGridView";
			this.employeeDataGridView.RowHeadersWidth = 51;
			this.employeeDataGridView.RowTemplate.Height = 24;
			this.employeeDataGridView.Size = new System.Drawing.Size(1008, 206);
			this.employeeDataGridView.TabIndex = 2;
			this.employeeDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.employeeDataGridView_RowHeaderMouseClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.addButton);
			this.groupBox3.Controls.Add(this.updateButton);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox3.Location = new System.Drawing.Point(0, 488);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1102, 100);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(463, 30);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(89, 41);
			this.addButton.TabIndex = 9;
			this.addButton.Text = "Thêm";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(558, 30);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(104, 41);
			this.updateButton.TabIndex = 6;
			this.updateButton.Text = "Cập nhập";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.usersearchIdTextbox);
			this.groupBox2.Controls.Add(this.searchButton);
			this.groupBox2.Location = new System.Drawing.Point(21, 74);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(256, 104);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Nhập mã nhân viên cần tìm kiếm";
			// 
			// usersearchIdTextbox
			// 
			this.usersearchIdTextbox.Location = new System.Drawing.Point(35, 30);
			this.usersearchIdTextbox.Name = "usersearchIdTextbox";
			this.usersearchIdTextbox.Size = new System.Drawing.Size(221, 31);
			this.usersearchIdTextbox.TabIndex = 12;
			// 
			// quanlynhanvien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1102, 588);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.employeeDataGridView);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "quanlynhanvien";
			this.Text = "Quản lý nhân viên";
			this.Load += new System.EventHandler(this.Employee_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label userIdLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox userIdTextbox;
		private System.Windows.Forms.TextBox passwordTextbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView employeeDataGridView;
		private System.Windows.Forms.ComboBox roleComboBox;
		private System.Windows.Forms.Label roleLabel;
		private GroupBox groupBox3;
		private Button addButton;
		private Button updateButton;
		private Button searchButton;
		private GroupBox groupBox2;
		private TextBox usersearchIdTextbox;
	}


}