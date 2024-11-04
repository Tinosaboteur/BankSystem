using BankSystem.Databasehelper;
using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankSystem.Controller
{
    internal class chuyenkhoanController : IController
    {
        private List<IModel> _items;
        public List<IModel> Items => this._items;
        private static string CHUYEN_KHOAN = "CHUYEN-KHOAN";

        private taikhoanController taikhoanController = new taikhoanController();
        private khachhangController khachhangController = new khachhangController();

        public chuyenkhoanController()
        {
            _items = new List<IModel>();
        }

        public bool Create(IModel model)
        {
            TRANSACTION transaction = model as TRANSACTION;
			if (transaction == null) return false;
			transaction.dateOfTrans = DateTime.Now;

            if (!transaction.isValidate(transaction))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ !");
                return false;
            }

            var fromAccount = taikhoanController.Read(transaction.fromAccount);
            var toAccount = taikhoanController.Read(transaction.toAccountId);
            if (fromAccount == null)
            {
                MessageBox.Show("Tài khoản chuyển không đúng");
                return false;
            } else if (toAccount == null)
            {
                MessageBox.Show("Tài khoản nhận không đúng");
                return false;
            }
            else
            {
                ACCOUNT newAccount = fromAccount as ACCOUNT;
                var customer = khachhangController.Read(newAccount.custommerId);
                CUSTOMER newCustomer = customer as CUSTOMER;
                if (!newCustomer.pin.Equals(khachhangController.hash(transaction.pin)))
                {
                    MessageBox.Show("Sai mã pin !");
                    return false;
                }
                else
                {
                    transaction.pin = khachhangController.hash(transaction.pin);
                }
            }

            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                ACCOUNT newFromAccount = fromAccount as ACCOUNT;
                if (newFromAccount.balance - transaction.amount < 50000)
                {
                    MessageBox.Show("Tài khoản bạn có " + newFromAccount.balance + " VNĐ tài khoản phải còn tối thiểu 50k");
                    return false;
                }

                con.Open();
                string query = "INSERT INTO [TRANSACTION] (from_account_id, branch_id, date_of_trans, amount, pin, to_account_id, " +
                    "employee_id, type) " +
                    "VALUES (@from_account_id, @branch_id, @date_of_trans, @amount, @pin" +
                    ", @to_account_id, @employee_id, @type)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@from_account_id", transaction.fromAccount);
                cmd.Parameters.AddWithValue("@branch_id", transaction.branchId);
                cmd.Parameters.AddWithValue("@date_of_trans", transaction.dateOfTrans);
                cmd.Parameters.AddWithValue("@amount", transaction.amount);
                cmd.Parameters.AddWithValue("@pin", transaction.pin);
                cmd.Parameters.AddWithValue("@to_account_id", transaction.toAccountId);
                cmd.Parameters.AddWithValue("@employee_id", transaction.employeeId);
                cmd.Parameters.AddWithValue("@type", CHUYEN_KHOAN);
                int rowsAffected = cmd.ExecuteNonQuery();

                //trừ tiền
                newFromAccount.balance = newFromAccount.balance - transaction.amount;
				taikhoanController.Update(newFromAccount);

                ACCOUNT newToAccount = toAccount as ACCOUNT;
                //cộng tiền
                newToAccount.balance = newToAccount.balance + transaction.amount;
				taikhoanController.Update(newToAccount);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Chuyển thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Lỗi");
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

                cmd.Parameters.AddWithValue("@type", CHUYEN_KHOAN);

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
