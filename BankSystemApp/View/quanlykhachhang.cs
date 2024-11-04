using BankSystem.Controller;
using BankSystem.Model;
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
using System.Xml.Linq;


namespace BankSystem
{
    public partial class quanlykhachhang : Form, IView
    {
        khachhangController controller;
        private CUSTOMER customer = new CUSTOMER();

        public quanlykhachhang()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public void GetDataFromText()
        {
            customer.id = idTextBox.Text;
            customer.name = nameTextBox.Text;
            customer.phone = phoneTextBox.Text;
            customer.email = emailTextbox.Text;
            customer.houseNo = houseNoTextbox.Text;
            customer.city = cityTextbox.Text;
            customer.pin = pinTextbox.Text;
        }

        public void SetDataToText()
        {
            idTextBox.Text= customer.id;
            nameTextBox.Text= customer.name;
            phoneTextBox.Text= customer.phone;
            emailTextbox.Text= customer.email;
            houseNoTextbox.Text= customer.houseNo;
            cityTextbox.Text= customer.city;
            //pinTextbox.Text= customer.pin;
        }

        public void resetForm()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            phoneTextBox.Text = "";
            emailTextbox.Text = "";
            houseNoTextbox.Text = "";
            cityTextbox.Text = "";
            pinTextbox.Text = "";
            controller.Load();
            customerDataGridView.DataSource = controller.Items.OfType<CUSTOMER>().ToList();
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            controller = new khachhangController();
            controller.Load();
            customerDataGridView.DataSource = controller.Items.OfType<CUSTOMER>().ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            controller = new khachhangController();
            GetDataFromText();
            bool successful = controller.Create(customer);
            if (successful)
            {
                resetForm();
            }
        }

        private void customerDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            customer.id = customerDataGridView.Rows[e.RowIndex].Cells[0].Value == DBNull.Value ?
                "" : customerDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            customer.name = customerDataGridView.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ?
                "" : customerDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            customer.phone = customerDataGridView.Rows[e.RowIndex].Cells[2].Value == DBNull.Value ?
                "" : customerDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            customer.email = customerDataGridView.Rows[e.RowIndex].Cells[3].Value == DBNull.Value ?
                "" : customerDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            customer.houseNo = customerDataGridView.Rows[e.RowIndex].Cells[4].Value == DBNull.Value ?
                "" : customerDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            customer.city = customerDataGridView.Rows[e.RowIndex].Cells[5].Value == DBNull.Value ?
                "" : customerDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            //customer.pin = customerDataGridView.Rows[e.RowIndex].Cells[6].Value == DBNull.Value ?
            //    "" : customerDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            SetDataToText();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            controller = new khachhangController();
            GetDataFromText();
            bool successful = controller.Update(customer);
            if (successful)
            {
                resetForm();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            controller = new khachhangController();
            string phone = this.phonesearchTextBox.Text;
            controller.Search(phone);
            customerDataGridView.DataSource = controller.Items.OfType<CUSTOMER>().ToList();
        }

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void nameLabel_Click(object sender, EventArgs e)
		{

		}
	}
}
