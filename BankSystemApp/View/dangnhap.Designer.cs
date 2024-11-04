using System.Windows.Forms;

namespace BankSystem
{
    partial class dangnhap
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
			this.employeeIdLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.employeeIdTextbox = new System.Windows.Forms.TextBox();
			this.passwordTextbox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// employeeIdLabel
			// 
			this.employeeIdLabel.AutoSize = true;
			this.employeeIdLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.employeeIdLabel.Location = new System.Drawing.Point(57, 73);
			this.employeeIdLabel.Name = "employeeIdLabel";
			this.employeeIdLabel.Size = new System.Drawing.Size(121, 23);
			this.employeeIdLabel.TabIndex = 7;
			this.employeeIdLabel.Text = "Mã nhân viên";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.label3.Location = new System.Drawing.Point(57, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Password";
			// 
			// employeeIdTextbox
			// 
			this.employeeIdTextbox.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.employeeIdTextbox.Location = new System.Drawing.Point(147, 70);
			this.employeeIdTextbox.Margin = new System.Windows.Forms.Padding(5);
			this.employeeIdTextbox.Name = "employeeIdTextbox";
			this.employeeIdTextbox.Size = new System.Drawing.Size(284, 31);
			this.employeeIdTextbox.TabIndex = 9;
			this.employeeIdTextbox.TextChanged += new System.EventHandler(this.employeeIdTextbox_TextChanged);
			// 
			// passwordTextbox
			// 
			this.passwordTextbox.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.passwordTextbox.Location = new System.Drawing.Point(147, 102);
			this.passwordTextbox.Name = "passwordTextbox";
			this.passwordTextbox.Size = new System.Drawing.Size(284, 31);
			this.passwordTextbox.TabIndex = 10;
			this.passwordTextbox.UseSystemPasswordChar = true;
			// 
			// loginButton
			// 
			this.loginButton.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.loginButton.Location = new System.Drawing.Point(335, 139);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(110, 38);
			this.loginButton.TabIndex = 11;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.loginButton);
			this.groupBox1.Controls.Add(this.passwordTextbox);
			this.groupBox1.Controls.Add(this.employeeIdTextbox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.employeeIdLabel);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.groupBox1.Location = new System.Drawing.Point(164, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(445, 177);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ĐĂNG NHẬP";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
			this.button1.Location = new System.Drawing.Point(219, 139);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 38);
			this.button1.TabIndex = 12;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// dangnhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 329);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "dangnhap";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.LoginView_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion
		private Label employeeIdLabel;
		private Label label3;
		private TextBox employeeIdTextbox;
		private TextBox passwordTextbox;
		private Button loginButton;
		private Button button1;
		private GroupBox groupBox1;
	}
}

