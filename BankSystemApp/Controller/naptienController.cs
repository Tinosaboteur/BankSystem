using BankSystem.Databasehelper;
using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankSystem.Controller
{
    internal class naptienController : IController
    {
        private List<IModel> _items;
        public List<IModel> Items => this._items;

        private taikhoanController taikhoanController = new taikhoanController();
        private khachhangController khachhangController = new khachhangController();

        private static string NAP_TIEN = "NAP_TIEN";

        public naptienController()
        {
            _items = new List<IModel>();
        }

        public bool Create(IModel model)
        {
            TRANSACTION transaction = model as TRANSACTION;

            transaction.dateOfTrans = DateTime.Now;
            transaction.toAccountId = transaction.fromAccount;

            if (!transaction.isValidate(transaction))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ !");
                return false;
            }

            var account = taikhoanController.Read(transaction.fromAccount);
            if(account == null)
            {
                MessageBox.Show("Tài khoản nạp không tồn tại !");
                return false;
            }else
            {
                ACCOUNT newAccount = account as ACCOUNT;
                var customer = khachhangController.Read(newAccount.custommerId);
                CUSTOMER newCustomer = customer as CUSTOMER;
                if (!newCustomer.pin.Equals(khachhangController.hash(transaction.pin)))
                {
					MessageBox.Show(newCustomer.pin);
					MessageBox.Show(transaction.pin);
					MessageBox.Show("Sai mã pin !");
                    return false;
                }else
                {
                    transaction.pin = khachhangController.hash(transaction.pin);
                }
                
        }

            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "INSERT INTO [TRANSACTION] (from_account_id, branch_id, date_of_trans, amount, pin, to_account_id, " +
                    "employee_id, type) " +
                    "VALUES (@from_account_id, @branch_id, @date_of_trans, @amount, @pin" + ", @to_account_id, @employee_id, @type)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@from_account_id", transaction.fromAccount);
                cmd.Parameters.AddWithValue("@branch_id", transaction.branchId);
                cmd.Parameters.AddWithValue("@date_of_trans", transaction.dateOfTrans);
                cmd.Parameters.AddWithValue("@amount", transaction.amount);
                cmd.Parameters.AddWithValue("@pin", transaction.pin);
                cmd.Parameters.AddWithValue("@to_account_id", transaction.toAccountId);
                cmd.Parameters.AddWithValue("@employee_id", transaction.employeeId);
                cmd.Parameters.AddWithValue("@type", NAP_TIEN);
                int rowsAffected = cmd.ExecuteNonQuery();

                ACCOUNT newAccount = account as ACCOUNT;
                //cộng tiền
                newAccount.balance = newAccount.balance + transaction.amount;
                bool depositToAccount = taikhoanController.Update(newAccount);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Nạp tiền thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Nạp tiền không thành công.");
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(object id)
        {
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "SELECT * FROM [TRANSACTION] WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return true;
                }

                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool Load()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "SELECT * FROM [TRANSACTION] WHERE type = @type ORDER BY (ID) DESC";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@type", NAP_TIEN);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TRANSACTION transaction = new TRANSACTION(
                        Int32.Parse(reader["id"].ToString()),
                        Int32.Parse(reader["from_account_id"].ToString()),
                        reader["branch_id"].ToString(),
                        DateTime.Parse(reader["date_of_trans"].ToString()),
                        float.Parse(reader["amount"].ToString()),
                        reader["pin"].ToString(),
                        Int32.Parse(reader["to_account_id"].ToString()),
                        reader["employee_id"].ToString(),
                        reader["type"].ToString()
                    );

                    _items.Add(transaction);
                }

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                con.Close();

            }
        }

        public IModel Read(object id)
        {
            throw new NotImplementedException();
        }

        public void Search(object keyWork)
        {
            throw new NotImplementedException();
        }

        public bool Update(IModel model)
        {
            throw new NotImplementedException();
        }
    }
}
