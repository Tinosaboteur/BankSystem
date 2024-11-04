using BankSystem.Controller;
using BankSystem.Databasehelper;
using BankSystem.Model;
using BankSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;

namespace BankSystem.View
{
    public partial class trangchu : Form
    {
        public trangchu()
        {         
            InitializeComponent();
            UpdateMenu();
        }
		private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			phien.employeeId = "";
			phien.role = "";
			UpdateMenu();
			this.Hide();
			new dangnhap().Show();
		}
		private void SetDataToText()
		{
				label1.Text = phien.employeeId; 
				label2.Text = phien.role; 
		}

		public void UpdateMenu()
        {
            if (!phien.employeeId.Equals(""))
            {
				systemToolStripMenuItem.Enabled = true;
				bankingToolStripMenuItem.Enabled = true;
				logoutToolStripMenuItem.Enabled = true;
				createCustomerToolStripButton2.Enabled = true;
				createAccountToolStripButton.Enabled = true;
				depositAmounttoolStripButton.Enabled = true;
				transactionAmounttoolStripButton.Enabled = true;
				withdrawToolStripButton.Enabled = true;
			}
        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new quanlynhanvien().Show();
        }

        private void chinhanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new quanlychinhanh().Show();
        }

        private void taokhachhangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new quanlykhachhang().Show();
        }

        private void taotaikhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new quanlytaikhoan().Show();
        }

        private void naptienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new quanlynaptien().Show();
        }

        private void ruttienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new quanlyruttien().Show();
        }

        private void chuyentienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new quanlygiaodich().Show();
        }

        private void taokhachhangToolStripButton2_Click(object sender, EventArgs e)
        {
            new quanlykhachhang().Show();
        }

        private void taotaikhoanToolStripButton_Click(object sender, EventArgs e)
        {
            new quanlytaikhoan().Show();
        }

        private void naptientoolStripButton_Click(object sender, EventArgs e)
        {
            new quanlynaptien().Show();
        }

        private void ruttienToolStripButton_Click(object sender, EventArgs e)
        {
            new quanlyruttien().Show();
        }

        private void chuyentientoolStripButton_Click(object sender, EventArgs e)
        {
            new quanlygiaodich().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void trangchuView_Load(object sender, EventArgs e)
		{

		}
	}

	internal class nhanvien
	{
	}
}
