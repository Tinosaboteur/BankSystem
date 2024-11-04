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
    public partial class quanlychinhanh : Form, IView
    {
        chinhanhController controller;
        private BRANCH branch = new BRANCH();

        public quanlychinhanh()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public void GetDataFromText()
        {
            branch.id = idTextBox.Text;
            branch.name = nameTextbox.Text;
            branch.houseNo = houseNoTextbox.Text;
            branch.city = cityTextbox.Text;
        }

        public void SetDataToText()
        {
            idTextBox.Text = branch.id;
            nameTextbox.Text = branch.name;
            houseNoTextbox.Text = branch.houseNo;
            cityTextbox.Text = branch.city;
        }

        public void resetForm()
        {
            idTextBox.Text = "";
            nameTextbox.Text = "";
            houseNoTextbox.Text = "";
            cityTextbox.Text = "";
            controller.Load();
            branchDataGridView.DataSource = controller.Items.OfType<BRANCH>().ToList();
        }

        private void BranchView_Load(object sender, EventArgs e)
        {
            controller = new chinhanhController();
            controller.Load();
            branchDataGridView.DataSource = controller.Items.OfType<BRANCH>().ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            controller = new chinhanhController();
            GetDataFromText();
            bool successful = controller.Create(branch);
            if (successful) {
                resetForm();
            }
        }

        private void branchDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            branch.id = branchDataGridView.Rows[e.RowIndex].Cells[0].Value == DBNull.Value ?
                "" : branchDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            branch.name = branchDataGridView.Rows[e.RowIndex].Cells[1].Value == DBNull.Value ?
                "" : branchDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            branch.houseNo = branchDataGridView.Rows[e.RowIndex].Cells[2].Value == DBNull.Value ?
                "" : branchDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            branch.city = branchDataGridView.Rows[e.RowIndex].Cells[3].Value == DBNull.Value ?
                "" : branchDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            SetDataToText();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            controller = new chinhanhController();
            GetDataFromText();
            bool successful = controller.Update(branch);
            if (successful)
            {
                resetForm();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            controller = new chinhanhController();
            string name = this.namesearchTextbox.Text;
            controller.Search(name);
            branchDataGridView.DataSource = controller.Items.OfType<BRANCH>().ToList();
        }

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
