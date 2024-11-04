using BankSystem.Controller;
using BankSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class dangnhap : Form
    {

        private nhanvienController nhanvienController = new nhanvienController();

        private trangchu trangchu;

        public dangnhap()
        {
           this.trangchu = trangchu;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            string userId = employeeIdTextbox.Text;
            string password = passwordTextbox.Text;
            bool successful = nhanvienController.login(userId, password);
            if(successful)
            {
				new trangchu().Show();
				this.Hide();
			}
            else
            {
                MessageBox.Show("Sai tài khoản mật khẩu");
            }
        }

		private void LoginView_Load(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void employeeIdTextbox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
