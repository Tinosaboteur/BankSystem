using System.Collections.Generic;
using System.Windows.Forms;


namespace BankSystem
{
    partial class quanlygiaodich
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlygiaodich));
			this.label3 = new System.Windows.Forms.Label();
			this.toAccountTextbox = new System.Windows.Forms.TextBox();
			this.fromAccountTextbox = new System.Windows.Forms.TextBox();
			this.toAccountLabel = new System.Windows.Forms.Label();
			this.fromAccountLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.branchCombobox = new System.Windows.Forms.ComboBox();
			this.branchLabel = new System.Windows.Forms.Label();
			this.amountTextbox = new System.Windows.Forms.TextBox();
			this.amountLabel = new System.Windows.Forms.Label();
			this.employeeTextbox = new System.Windows.Forms.TextBox();
			this.pinTextbox = new System.Windows.Forms.TextBox();
			this.employeeLabel = new System.Windows.Forms.Label();
			this.pinLabel = new System.Windows.Forms.Label();
			this.transferButton = new System.Windows.Forms.Button();
			this.transactionDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(433, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(440, 45);
			this.label3.TabIndex = 4;
			this.label3.Text = "Quản lý giao dịch";
			// 
			// toAccountTextbox
			// 
			this.toAccountTextbox.Location = new System.Drawing.Point(275, 129);
			this.toAccountTextbox.Name = "toAccountTextbox";
			this.toAccountTextbox.Size = new System.Drawing.Size(230, 31);
			this.toAccountTextbox.TabIndex = 3;
			// 
			// fromAccountTextbox
			// 
			this.fromAccountTextbox.Location = new System.Drawing.Point(275, 97);
			this.fromAccountTextbox.Name = "fromAccountTextbox";
			this.fromAccountTextbox.Size = new System.Drawing.Size(230, 31);
			this.fromAccountTextbox.TabIndex = 2;
			// 
			// toAccountLabel
			// 
			this.toAccountLabel.AutoSize = true;
			this.toAccountLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.toAccountLabel.Location = new System.Drawing.Point(140, 133);
			this.toAccountLabel.Name = "toAccountLabel";
			this.toAccountLabel.Size = new System.Drawing.Size(133, 23);
			this.toAccountLabel.TabIndex = 1;
			this.toAccountLabel.Text = "Tài khoản đích";
			// 
			// fromAccountLabel
			// 
			this.fromAccountLabel.AutoSize = true;
			this.fromAccountLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.fromAccountLabel.Location = new System.Drawing.Point(140, 100);
			this.fromAccountLabel.Name = "fromAccountLabel";
			this.fromAccountLabel.Size = new System.Drawing.Size(149, 23);
			this.fromAccountLabel.TabIndex = 0;
			this.fromAccountLabel.Text = "Tài khoản nguồn";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.branchCombobox);
			this.groupBox1.Controls.Add(this.branchLabel);
			this.groupBox1.Controls.Add(this.amountTextbox);
			this.groupBox1.Controls.Add(this.amountLabel);
			this.groupBox1.Controls.Add(this.employeeTextbox);
			this.groupBox1.Controls.Add(this.pinTextbox);
			this.groupBox1.Controls.Add(this.employeeLabel);
			this.groupBox1.Controls.Add(this.pinLabel);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.toAccountTextbox);
			this.groupBox1.Controls.Add(this.fromAccountTextbox);
			this.groupBox1.Controls.Add(this.toAccountLabel);
			this.groupBox1.Controls.Add(this.fromAccountLabel);
			this.groupBox1.Location = new System.Drawing.Point(42, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1038, 213);
			this.groupBox1.TabIndex = 4;
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
			this.branchCombobox.Location = new System.Drawing.Point(755, 158);
			this.branchCombobox.Name = "branchCombobox";
			this.branchCombobox.Size = new System.Drawing.Size(230, 33);
			this.branchCombobox.TabIndex = 19;
			this.branchCombobox.ValueMember = "Key";
			// 
			// branchLabel
			// 
			this.branchLabel.AutoSize = true;
			this.branchLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.branchLabel.Location = new System.Drawing.Point(565, 166);
			this.branchLabel.Name = "branchLabel";
			this.branchLabel.Size = new System.Drawing.Size(94, 23);
			this.branchLabel.TabIndex = 15;
			this.branchLabel.Text = "Chi nhánh";
			// 
			// amountTextbox
			// 
			this.amountTextbox.Location = new System.Drawing.Point(275, 161);
			this.amountTextbox.Name = "amountTextbox";
			this.amountTextbox.Size = new System.Drawing.Size(230, 31);
			this.amountTextbox.TabIndex = 14;
			// 
			// amountLabel
			// 
			this.amountLabel.AutoSize = true;
			this.amountLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.amountLabel.Location = new System.Drawing.Point(140, 166);
			this.amountLabel.Name = "amountLabel";
			this.amountLabel.Size = new System.Drawing.Size(68, 23);
			this.amountLabel.TabIndex = 13;
			this.amountLabel.Text = "Số tiền";
			// 
			// employeeTextbox
			// 
			this.employeeTextbox.Location = new System.Drawing.Point(755, 130);
			this.employeeTextbox.Name = "employeeTextbox";
			this.employeeTextbox.ReadOnly = true;
			this.employeeTextbox.Size = new System.Drawing.Size(230, 31);
			this.employeeTextbox.TabIndex = 12;
			// 
			// pinTextbox
			// 
			this.pinTextbox.Location = new System.Drawing.Point(755, 94);
			this.pinTextbox.Name = "pinTextbox";
			this.pinTextbox.Size = new System.Drawing.Size(230, 31);
			this.pinTextbox.TabIndex = 11;
			this.pinTextbox.UseSystemPasswordChar = true;
			// 
			// employeeLabel
			// 
			this.employeeLabel.AutoSize = true;
			this.employeeLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.employeeLabel.Location = new System.Drawing.Point(565, 133);
			this.employeeLabel.Name = "employeeLabel";
			this.employeeLabel.Size = new System.Drawing.Size(202, 23);
			this.employeeLabel.TabIndex = 10;
			this.employeeLabel.Text = "Mã nhân viên thực hiện";
			// 
			// pinLabel
			// 
			this.pinLabel.AutoSize = true;
			this.pinLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.pinLabel.Location = new System.Drawing.Point(565, 100);
			this.pinLabel.Name = "pinLabel";
			this.pinLabel.Size = new System.Drawing.Size(38, 23);
			this.pinLabel.TabIndex = 9;
			this.pinLabel.Text = "Pin";
			// 
			// transferButton
			// 
			this.transferButton.Location = new System.Drawing.Point(496, 435);
			this.transferButton.Name = "transferButton";
			this.transferButton.Size = new System.Drawing.Size(154, 50);
			this.transferButton.TabIndex = 5;
			this.transferButton.Text = "Chuyển tiền";
			this.transferButton.UseVisualStyleBackColor = true;
			this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
			// 
			// transactionDataGridView
			// 
			this.transactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.transactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.transactionDataGridView.Location = new System.Drawing.Point(38, 275);
			this.transactionDataGridView.Name = "transactionDataGridView";
			this.transactionDataGridView.RowHeadersWidth = 51;
			this.transactionDataGridView.RowTemplate.Height = 24;
			this.transactionDataGridView.Size = new System.Drawing.Size(1042, 151);
			this.transactionDataGridView.TabIndex = 5;
			// 
			// quanlygiaodich
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1102, 497);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.transactionDataGridView);
			this.Controls.Add(this.transferButton);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "quanlygiaodich";
			this.Text = "Quản lý giao dịch";
			this.Load += new System.EventHandler(this.TransactionView_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.transactionDataGridView)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox toAccountTextbox;
        private System.Windows.Forms.TextBox fromAccountTextbox;
        private System.Windows.Forms.Label toAccountLabel;
        private System.Windows.Forms.Label fromAccountLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.DataGridView transactionDataGridView;
        private System.Windows.Forms.TextBox employeeTextbox;
        private System.Windows.Forms.TextBox pinTextbox;
        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.ComboBox branchCombobox;
    }
}