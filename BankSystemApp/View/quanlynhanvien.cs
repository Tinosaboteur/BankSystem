using BankSystem.Controller;
using BankSystem.Model;
using BankSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class quanlynhanvien : Form, IView
    {
        nhanvienController employeeController;
        private EMPLOYEE employee = new EMPLOYEE();

        public quanlynhanvien()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public void GetDataFromText()
        {
          
            string userId = this.userIdTextbox.Text;
            string password = this.passwordTextbox.Text;
            string role = "";
            if (this.roleComboBox != null && this.roleComboBox.SelectedItem != null)
            {
                role = this.roleComboBox.SelectedItem.ToString();
            }

            
            employee.id = userId;
            employee.password = password;
            employee.role = role;
        }

        public void SetDataToText()
        {
            userIdTextbox.Text = employee.id;
            roleComboBox.Text = employee.role;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            employeeController = new nhanvienController();
            employeeController.Load();
            employeeDataGridView.DataSource = employeeController.Items.OfType<EMPLOYEE>().ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            employeeController = new nhanvienController();
            GetDataFromText();
            bool successful = employeeController.Create(employee);
            if (successful)
            {
                this.userIdTextbox.Text = "";
                this.passwordTextbox.Text = "";
                this.roleComboBox.SelectedIndex = -1;
                employeeController.Load();
                employeeDataGridView.DataSource = employeeController.Items.OfType<EMPLOYEE>().ToList();
            }
        }

        private void employeeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            employee.id = employeeDataGridView.Rows[e.RowIndex].Cells[0].Value == DBNull.Value ?
                "" : employeeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            employee.role = employeeDataGridView.Rows[e.RowIndex].Cells[2].Value == DBNull.Value ?
                "" : employeeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            SetDataToText();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            nhanvienController employeeController = new nhanvienController();
            GetDataFromText();
            bool successful = employeeController.Update(employee);
            if (successful)
            {
                this.userIdTextbox.Text = "";
                this.passwordTextbox.Text = "";
                this.roleComboBox.SelectedIndex = -1;
                employeeController.Load();
                employeeDataGridView.DataSource = employeeController.Items.OfType<EMPLOYEE>().ToList();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            nhanvienController employeeController = new nhanvienController();
            string userId = this.usersearchIdTextbox.Text;
            if (!userId.Equals(""))
            {
                employeeController.Search(userId);
                employeeDataGridView.DataSource = employeeController.Items.OfType<EMPLOYEE>().ToList();
            }
            else
            {
                employeeController.Load();
                employeeDataGridView.DataSource = employeeController.Items.OfType<EMPLOYEE>().ToList();
            }
            
        }

		private void userIdLabel_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
