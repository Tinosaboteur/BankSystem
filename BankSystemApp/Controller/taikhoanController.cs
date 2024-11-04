using BankSystem.Databasehelper;
using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankSystem.Controller
{
    internal class taikhoanController : IController
    {
        private List<IModel> _items;
        public List<IModel> Items => this._items;


        public taikhoanController() {
            _items = new List<IModel>();
        }

        public bool Create(IModel model)
        {
            ACCOUNT account = model as ACCOUNT;

            account.dateOpen = DateTime.Now;

            if (!account.isValidate(account))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và tài khoản tạo phải lớn hơn hoặc bằng 50k !");
                return false;
            }

            if (IsExist(account.custommerId))
            {
                MessageBox.Show("Đã tồn tại customer id này trong account");
                return false;
            }

            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "INSERT INTO ACCOUNT (customerid, date_opened, balance) " +
                    "VALUES (@customerid, @date_opened, @balance)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@customerid", account.custommerId);
                cmd.Parameters.AddWithValue("@date_opened", account.dateOpen);
                cmd.Parameters.AddWithValue("@balance", account.balance);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm không thành công.");
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
            if(id.Equals("")) {
                MessageBox.Show("id tài khoản rỗng");
                return false;
            }

            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query1 = "DELETE FROM [TRANSACTION] WHERE from_account_id = @id OR to_account_id = @id";
                SqlCommand cmd1 = new SqlCommand(query1, con);

                cmd1.Parameters.AddWithValue("@id", id);

                int rowsAffected1 = cmd1.ExecuteNonQuery();

                if (rowsAffected1 > 0)
                {
                    MessageBox.Show("Xóa giao dịch cũ của tài khoản thành công!: " + rowsAffected1 + " lần giao dịch");
                }

                string query2 = "DELETE FROM ACCOUNT WHERE id = @id";
                SqlCommand cmd2 = new SqlCommand(query2, con);

                cmd2.Parameters.AddWithValue("@id", id);

                int rowsAffected2 = cmd2.ExecuteNonQuery();

                if (rowsAffected2 > 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản không thành công.");
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

        public bool IsExist(object id)
        {
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "SELECT * FROM ACCOUNT WHERE customerid = @customerid";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@customerid", id);

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
                string query = "SELECT * FROM ACCOUNT";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ACCOUNT account = new ACCOUNT(
                        Int32.Parse(reader["id"].ToString()),
                        reader["customerid"].ToString(),
                        DateTime.Parse(reader["date_opened"].ToString()),
                        float.Parse(reader["balance"].ToString())
                    );

                    _items.Add(account);
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
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "SELECT * FROM ACCOUNT WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ACCOUNT account = new ACCOUNT(
                        Int32.Parse(reader["id"].ToString()),
                        reader["customerid"].ToString(),
                        DateTime.Parse(reader["date_opened"].ToString()),
                        float.Parse(reader["balance"].ToString())
                    );

                    return account;
                }

                return null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public void Search(object keyWork)
        {
            if (keyWork.Equals(""))
            {
                Load();
            }
            else
            {
                SqlConnection con = DatabaseHelper.getConnection();
                try
                {
                    con.Open();
                    string query = "SELECT * FROM ACCOUNT WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", keyWork);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ACCOUNT account = new ACCOUNT(
                        Int32.Parse(reader["id"].ToString()),
                        reader["customerid"].ToString(),
                        DateTime.Parse(reader["date_opened"].ToString()),
                        float.Parse(reader["balance"].ToString())
                        );

                        _items.Add(account);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        public string SearchAccountByPhone(object keyWork)
        {
            SqlConnection con = DatabaseHelper.getConnection();
            khachhangController customerController = new khachhangController();
            var customer = customerController.SearchByPhone(keyWork);
            if (customer == null) {
                return "Chưa có số tài khoản";
            }

            try
            {
                con.Open();
                string query = "SELECT * FROM ACCOUNT WHERE customerid = @customerid";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@customerid", customer.id);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return "Số tài khoản: " + reader["id"].ToString();
                }

                return "Chưa có số tài khoản";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public bool Update(IModel model)
        {
            ACCOUNT account = model as ACCOUNT;

            if (!account.isValidate(account))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ !");
                return false;
            }

            if (!IsExist(account.custommerId))
            {
                MessageBox.Show("Không tồn tại customer id này trong account");
                return false;
            }

            SqlConnection con = DatabaseHelper.getConnection();

            try
            {
                con.Open();
                string query = "UPDATE ACCOUNT SET balance = @balance WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", account.id);
                cmd.Parameters.AddWithValue("@balance", account.balance);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
          
            finally
            {
                con.Close();
            }
        }
    }
}
