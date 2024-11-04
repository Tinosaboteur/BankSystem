namespace BankSystem
{
	partial class quanlychinhanh
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
			this.houseNoTextbox = new System.Windows.Forms.TextBox();
			this.nameTextbox = new System.Windows.Forms.TextBox();
			this.houseNoLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cityTextbox = new System.Windows.Forms.TextBox();
			this.cityLabel = new System.Windows.Forms.Label();
			this.searchButton = new System.Windows.Forms.Button();
			this.branchDataGridView = new System.Windows.Forms.DataGridView();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.addButton = new System.Windows.Forms.Button();
			this.updateButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.namesearchTextbox = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// houseNoTextbox
			// 
			this.houseNoTextbox.Location = new System.Drawing.Point(217, 157);
			this.houseNoTextbox.Name = "houseNoTextbox";
			this.houseNoTextbox.Size = new System.Drawing.Size(230, 31);
			this.houseNoTextbox.TabIndex = 3;
			// 
			// nameTextbox
			// 
			this.nameTextbox.Location = new System.Drawing.Point(217, 125);
			this.nameTextbox.Name = "nameTextbox";
			this.nameTextbox.Size = new System.Drawing.Size(230, 31);
			this.nameTextbox.TabIndex = 2;
			// 
			// houseNoLabel
			// 
			this.houseNoLabel.AutoSize = true;
			this.houseNoLabel.Location = new System.Drawing.Point(132, 161);
			this.houseNoLabel.Name = "houseNoLabel";
			this.houseNoLabel.Size = new System.Drawing.Size(70, 23);
			this.houseNoLabel.TabIndex = 1;
			this.houseNoLabel.Text = "Địa chỉ";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(132, 128);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(41, 23);
			this.nameLabel.TabIndex = 0;
			this.nameLabel.Text = "Tên";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.idTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cityTextbox);
			this.groupBox1.Controls.Add(this.cityLabel);
			this.groupBox1.Controls.Add(this.houseNoTextbox);
			this.groupBox1.Controls.Add(this.nameTextbox);
			this.groupBox1.Controls.Add(this.houseNoLabel);
			this.groupBox1.Controls.Add(this.nameLabel);
			this.groupBox1.Location = new System.Drawing.Point(252, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(622, 262);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(159, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(328, 45);
			this.label2.TabIndex = 11;
			this.label2.Text = "Quản lý chi nhánh";
			// 
			// idTextBox
			// 
			this.idTextBox.Location = new System.Drawing.Point(217, 92);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(230, 31);
			this.idTextBox.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(132, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "ID";
			// 
			// cityTextbox
			// 
			this.cityTextbox.Location = new System.Drawing.Point(217, 189);
			this.cityTextbox.Name = "cityTextbox";
			this.cityTextbox.Size = new System.Drawing.Size(230, 31);
			this.cityTextbox.TabIndex = 8;
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(132, 192);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(97, 23);
			this.cityLabel.TabIndex = 7;
			this.cityLabel.Text = "Thành phố";
			// 
			// searchButton
			// 
			this.searchButton.Location = new System.Drawing.Point(129, 67);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(108, 31);
			this.searchButton.TabIndex = 5;
			this.searchButton.Text = "Tìm kiếm";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
			// 
			// branchDataGridView
			// 
			this.branchDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.branchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.branchDataGridView.Location = new System.Drawing.Point(48, 291);
			this.branchDataGridView.Name = "branchDataGridView";
			this.branchDataGridView.RowHeadersWidth = 51;
			this.branchDataGridView.RowTemplate.Height = 24;
			this.branchDataGridView.Size = new System.Drawing.Size(1008, 182);
			this.branchDataGridView.TabIndex = 5;
			this.branchDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.branchDataGridView_RowHeaderMouseClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.addButton);
			this.groupBox3.Controls.Add(this.updateButton);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox3.Location = new System.Drawing.Point(0, 457);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1102, 100);
			this.groupBox3.TabIndex = 9;
			this.groupBox3.TabStop = false;
			// 
			// addButton
			// 
			this.addButton.Location = new System.Drawing.Point(419, 30);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(89, 41);
			this.addButton.TabIndex = 9;
			this.addButton.Text = "Thêm";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(528, 30);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(108, 41);
			this.updateButton.TabIndex = 6;
			this.updateButton.Text = "Cập nhập";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.namesearchTextbox);
			this.groupBox2.Controls.Add(this.searchButton);
			this.groupBox2.Location = new System.Drawing.Point(0, 59);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(237, 99);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Nhập tên chi nhánh cần tìm kiếm";
			// 
			// namesearchTextbox
			// 
			this.namesearchTextbox.Location = new System.Drawing.Point(16, 30);
			this.namesearchTextbox.Name = "namesearchTextbox";
			this.namesearchTextbox.Size = new System.Drawing.Size(221, 31);
			this.namesearchTextbox.TabIndex = 12;
			// 
			// quanlychinhanh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1102, 557);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.branchDataGridView);
			this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "quanlychinhanh";
			this.Text = "Quản lý chi nhánh";
			this.Load += new System.EventHandler(this.BranchView_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.branchDataGridView)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox houseNoTextbox;
		private System.Windows.Forms.TextBox nameTextbox;
		private System.Windows.Forms.Label houseNoLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label cityLabel;
		private System.Windows.Forms.DataGridView branchDataGridView;
		private System.Windows.Forms.TextBox cityTextbox;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox namesearchTextbox;
	}
}