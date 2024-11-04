using BankSystem.Controller;
using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BankSystem.View
{
    public partial class quanlynaptien : Form, IView
    {

        private naptienController depositAmountController;
        private TRANSACTION transaction = new TRANSACTION();

        private chinhanhController branchController;

        public quanlynaptien()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public void GetDataFromText()
        {
            var fromAccountId = fromAccountTextbox.Text;
            if (fromAccountId != null && !fromAccountId.Equals(""))
            {
                transaction.fromAccount = int.Parse(fromAccountId);
            }
            else
            {
                transaction.fromAccount = 0;
            }

            var amount = amountTextbox.Text;
            if (amount != null && !amount.Equals(""))
            {
                transaction.amount = float.Parse(amount, CultureInfo.InvariantCulture);
            }
            else
            {
                transaction.amount = 0;
            }

            transaction.pin = pinTextbox.Text;

            transaction.employeeId = employeeTextbox.Text;

            string branchId = "";
            if (this.branchCombobox != null && this.branchCombobox.SelectedItem != null)
            {
                BRANCH selectedBranch = (BRANCH)branchCombobox.SelectedItem;
                branchId = selectedBranch.id.ToString();
            }
            transaction.branchId = branchId;
        }

        public void SetDataToText()
        {
            throw new NotImplementedException();
        }

        public void resetForm()
        {
            fromAccountTextbox.Text = "";
            amountTextbox.Text = "";
            pinTextbox.Text = "";
            branchCombobox.SelectedIndex = -1;
            depositAmountController.Load();
            transactionDataGridView.DataSource = depositAmountController.Items.OfType<TRANSACTION>().ToList();
        }

        private void DepositAmountView_Load(object sender, EventArgs e)
        {
            depositAmountController = new naptienController();
            depositAmountController.Load();
            transactionDataGridView.DataSource = depositAmountController.Items.OfType<TRANSACTION>().ToList();

            branchController = new chinhanhController();
            branchController.Load();
            branchCombobox.DataSource = branchController.Items.OfType<BRANCH>().ToList();
            branchCombobox.DisplayMember = "name";
            branchCombobox.ValueMember = "id";

            employeeTextbox.Text = phien.employeeId;
        }



        private void depositButton_Click(object sender, EventArgs e)
        {
            depositAmountController = new naptienController();
            GetDataFromText();
            bool successful = depositAmountController.Create(transaction);
            if (successful)
            {
                resetForm();
            }
        }

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
