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


namespace BankSystem
{
    public partial class quanlytaikhoan : Form, IView
    {


        taikhoanController controller;
        private ACCOUNT account = new ACCOUNT();
        public quanlytaikhoan()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public void GetDataFromText()
        {
            account.custommerId = customerIdTextBox.Text;

            var balance = balanceTextbox.Text;
            if(balance != null && !balance.Equals(""))
            {
                account.balance = float.Parse(balance);
            }else
            {
                account.balance = 0;
            }
        }

        public void SetDataToText()
        {
            customerIdTextBox.Text = account.custommerId;
            balanceTextbox.Text = account.balance.ToString();
			dateOpen.Text = account.dateOpen.ToString();
        }

        public void resetForm()
        {
            customerIdTextBox.Text = "";
            balanceTextbox.Text = "";
            controller.Load();
            accountDataGridView.DataSource = controller.Items.OfType<ACCOUNT>().ToList();
        }

        private void AccountView_Load(object sender, EventArgs e)
        {
            controller = new taikhoanController();
            controller.Load();
            accountDataGridView.DataSource = controller.Items.OfType<ACCOUNT>().ToList();
        }


		private void customerDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			account.balance = accountDataGridView.Rows[e.RowIndex].Cells[3].Value == DBNull.Value ?
				0f : Convert.ToSingle(accountDataGridView.Rows[e.RowIndex].Cells[3].Value);

			account.custommerId = accountDataGridView.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ?
				"" : accountDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();

			account.dateOpen = accountDataGridView.Rows[e.RowIndex].Cells[2].Value == DBNull.Value ?
				DateTime.MinValue : Convert.ToDateTime(accountDataGridView.Rows[e.RowIndex].Cells[2].Value);

			SetDataToText();
		}




		private void addButton_Click(object sender, EventArgs e)
        {
            controller = new taikhoanController();
            GetDataFromText();
            bool successful = controller.Create(account);
            if (successful)
            {
                resetForm();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            controller = new taikhoanController();
            string id = this.accountIdTextBox.Text;
            controller.Search(id);
            accountDataGridView.DataSource = controller.Items.OfType<ACCOUNT>().ToList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            controller = new taikhoanController();
            string id = this.accountIdTextBox.Text;
            bool successful = controller.Delete(id);
            if (successful)
            {
                resetForm();
            }
        }

        

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void accountIdTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void groupBox3_Enter(object sender, EventArgs e)
		{

		}

		private void Date_open_Click(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}
	}
}
