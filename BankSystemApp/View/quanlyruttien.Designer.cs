﻿namespace BankSystem.View
{
	partial class quanlyruttien
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlyruttien));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.branchCombobox = new System.Windows.Forms.ComboBox();
			this.branchLabel = new System.Windows.Forms.Label();
			this.employeeTextbox = new System.Windows.Forms.TextBox();
			this.pinTextbox = new System.Windows.Forms.TextBox();
			this.employeeLabel = new System.Windows.Forms.Label();
			this.pinLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.amountTextbox = new System.Windows.Forms.TextBox();
			this.fromAccountTextbox = new System.Windows.Forms.TextBox();
			this.amountLabel = new System.Windows.Forms.Label();
			this.fromAccountLabel = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.transactionDataGridView = new System.Windows.Forms.DataGridView();
			this.withdrawButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.branchCombobox);
			this.groupBox1.Controls.Add(this.branchLabel);
			this.groupBox1.Controls.Add(this.employeeTextbox);
			this.groupBox1.Controls.Add(this.pinTextbox);
			this.groupBox1.Controls.Add(this.employeeLabel);
			this.groupBox1.Controls.Add(this.pinLabel);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.amountTextbox);
			this.groupBox1.Controls.Add(this.fromAccountTextbox);
			this.groupBox1.Controls.Add(this.amountLabel);
			this.groupBox1.Controls.Add(this.fromAccountLabel);
			this.groupBox1.Location = new System.Drawing.Point(31, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1042, 203);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// branchCombobox
			// 
			this.branchCombobox.DisplayMember = "Value";
			this.branchCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.branchCombobox.FormattingEnabled = true;
			this.branchCombobox.Items.AddRange(new object[] {
            ((object)(resources.GetObject("branchCombobox.Items"))),
            ((object)(resources.GetObject("branchCombobox.Items1"))),
            ((object)(resources.GetObject("branchCombobox.Items2")))});
			this.branchCombobox.Location = new System.Drawing.Point(696, 160);
			this.branchCombobox.Name = "branchCombobox";
			this.branchCombobox.Size = new System.Drawing.Size(230, 30);
			this.branchCombobox.TabIndex = 19;
			this.branchCombobox.ValueMember = "Key";
			// 
			// branchLabel
			// 
			this.branchLabel.AutoSize = true;
			this.branchLabel.Location = new System.Drawing.Point(537, 167);
			this.branchLabel.Name = "branchLabel";
			this.branchLabel.Size = new System.Drawing.Size(94, 23);
			this.branchLabel.TabIndex = 15;
			this.branchLabel.Text = "Chi nhánh";
			// 
			// employeeTextbox
			// 
			this.employeeTextbox.Location = new System.Drawing.Point(696, 130);
			this.employeeTextbox.Name = "employeeTextbox";
			this.employeeTextbox.ReadOnly = true;
			this.employeeTextbox.Size = new System.Drawing.Size(230, 31);
			this.employeeTextbox.TabIndex = 12;
			// 
			// pinTextbox
			// 
			this.pinTextbox.Location = new System.Drawing.Point(696, 98);
			this.pinTextbox.Name = "pinTextbox";
			this.pinTextbox.Size = new System.Drawing.Size(230, 31);
			this.pinTextbox.TabIndex = 11;
			this.pinTextbox.UseSystemPasswordChar = true;
			// 
			// employeeLabel
			// 
			this.employeeLabel.AutoSize = true;
			this.employeeLabel.Location = new System.Drawing.Point(537, 134);
			this.employeeLabel.Name = "employeeLabel";
			this.employeeLabel.Size = new System.Drawing.Size(202, 23);
			this.employeeLabel.TabIndex = 10;
			this.employeeLabel.Text = "Mã nhân viên thực hiện";
			// 
			// pinLabel
			// 
			this.pinLabel.AutoSize = true;
			this.pinLabel.Location = new System.Drawing.Point(537, 101);
			this.pinLabel.Name = "pinLabel";
			this.pinLabel.Size = new System.Drawing.Size(38, 23);
			this.pinLabel.TabIndex = 9;
			this.pinLabel.Text = "Pin";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(383, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(258, 45);
			this.label3.TabIndex = 4;
			this.label3.Text = "Rút tiền";
			// 
			// amountTextbox
			// 
			this.amountTextbox.Location = new System.Drawing.Point(247, 130);
			this.amountTextbox.Name = "amountTextbox";
			this.amountTextbox.Size = new System.Drawing.Size(230, 31);
			this.amountTextbox.TabIndex = 3;
			// 
			// fromAccountTextbox
			// 
			this.fromAccountTextbox.Location = new System.Drawing.Point(247, 98);
			this.fromAccountTextbox.Name = "fromAccountTextbox";
			this.fromAccountTextbox.Size = new System.Drawing.Size(230, 31);
			this.fromAccountTextbox.TabIndex = 2;
			// 
			// amountLabel
			// 
			this.amountLabel.AutoSize = true;
			this.amountLabel.Location = new System.Drawing.Point(112, 134);
			this.amountLabel.Name = "amountLabel";
			this.amountLabel.Size = new System.Drawing.Size(68, 23);
			this.amountLabel.TabIndex = 1;
			this.amountLabel.Text = "Số tiền";
			// 
			// fromAccountLabel
			// 
			this.fromAccountLabel.AutoSize = true;
			this.fromAccountLabel.Location = new System.Drawing.Point(112, 101);
			this.fromAccountLabel.Name = "fromAccountLabel";
			this.fromAccountLabel.Size = new System.Drawing.Size(149, 23);
			this.fromAccountLabel.TabIndex = 0;
			this.fromAccountLabel.Text = "Tài khoản nguồn";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// transactionDataGridView
			// 
			this.transactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.transactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.transactionDataGridView.Location = new System.Drawing.Point(22, 237);
			this.transactionDataGridView.Name = "transactionDataGridView";
			this.transactionDataGridView.RowHeadersWidth = 51;
			this.transactionDataGridView.RowTemplate.Height = 24;
			this.transactionDataGridView.Size = new System.Drawing.Size(1042, 192);
			this.transactionDataGridView.TabIndex = 17;
			// 
			// withdrawButton
			// 
			this.withdrawButton.Location = new System.Drawing.Point(477, 435);
			this.withdrawButton.Name = "withdrawButton";
			this.withdrawButton.Size = new System.Drawing.Size(118, 50);
			this.withdrawButton.TabIndex = 15;
			this.withdrawButton.Text = "Rút tiền";
			this.withdrawButton.UseVisualStyleBackColor = true;
			this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
			// 
			// quanlyruttien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1102, 505);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.transactionDataGridView);
			this.Controls.Add(this.withdrawButton);
			this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "quanlyruttien";
			this.Text = "Quản lý rút tiền";
			this.Load += new System.EventHandler(this.WithdrawAmountView_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox branchCombobox;
		private System.Windows.Forms.Label branchLabel;
		private System.Windows.Forms.TextBox employeeTextbox;
		private System.Windows.Forms.TextBox pinTextbox;
		private System.Windows.Forms.Label employeeLabel;
		private System.Windows.Forms.Label pinLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox amountTextbox;
		private System.Windows.Forms.TextBox fromAccountTextbox;
		private System.Windows.Forms.Label amountLabel;
		private System.Windows.Forms.Label fromAccountLabel;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.DataGridView transactionDataGridView;
		private System.Windows.Forms.Button withdrawButton;
	}
}