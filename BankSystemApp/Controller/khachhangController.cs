using BankSystem.Databasehelper;
using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BankSystem.Controller
{
    internal class khachhangController : IController
    {
        private List<IModel> _items;
        public List<IModel> Items => this._items;

        public khachhangController()
        {
            _items = new List<IModel>();
        }

		public bool Create(IModel model)
		{
			CUSTOMER customer = model as CUSTOMER;
			if (customer == null) return false;

			if (!customer.isValidate(customer))
			{
				MessageBox.Show("Vui lòng nhập đầy đủ !");
				return false;
			}

			if (IsExist(customer.id) || IsExist(customer.phone) || IsExist(customer.email))
			{
				MessageBox.Show("Đã tồn tại ID hoặc phone hoặc email này trong customer");
				return false;
			}

			customer.pin = hash(customer.pin);

			SqlConnection con = DatabaseHelper.getConnection();
			try
			{
				con.Open();
				string query = "INSERT INTO CUSTOMER (id, name, phone, email, house_no, city, pin) " +
					"VALUES (@id, @name, @phone, @email, @house_no, @city, @pin)";
				SqlCommand cmd = new SqlCommand(query, con);

				cmd.Parameters.AddWithValue("@id", customer.id);
				cmd.Parameters.AddWithValue("@name", customer.name);
				cmd.Parameters.AddWithValue("@phone", customer.phone);
				cmd.Parameters.AddWithValue("@email", customer.email);
				cmd.Parameters.AddWithValue("@house_no", customer.houseNo);
				cmd.Parameters.AddWithValue("@city", customer.city);
				cmd.Parameters.AddWithValue("@pin", customer.pin);
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
				string query = "SELECT * FROM CUSTOMER WHERE id = @id OR phone = @phone or email = @email";
				SqlCommand cmd = new SqlCommand(query, con);

				cmd.Parameters.AddWithValue("@id", id);
				cmd.Parameters.AddWithValue("@phone", id);
				cmd.Parameters.AddWithValue("@email", id);

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
		public string hash(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        

        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        

        public bool Load()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "SELECT * FROM CUSTOMER";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CUSTOMER customer = new CUSTOMER(
                        reader["id"].ToString(),
                        reader["name"].ToString(),
                        reader["phone"].ToString(),
                        reader["email"].ToString(),
                        reader["house_no"].ToString(),
                        reader["city"].ToString(),
                        reader["pin"].ToString()
                    );

                    _items.Add(customer);
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
                string query = "SELECT * FROM CUSTOMER WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CUSTOMER customer = new CUSTOMER(
                        reader["id"].ToString(),
                        reader["name"].ToString(),
                        reader["phone"].ToString(),
                        reader["email"].ToString(),
                        reader["house_no"].ToString(),
                        reader["city"].ToString(),
                        reader["pin"].ToString()
                    );

                    return customer;
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
                    string query = "SELECT * FROM CUSTOMER WHERE phone = @phone";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@phone", keyWork);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CUSTOMER customer = new CUSTOMER(
                        reader["id"].ToString(),
                        reader["name"].ToString(),
                        reader["phone"].ToString(),
                        reader["email"].ToString(),
                        reader["house_no"].ToString(),
                        reader["city"].ToString(),
                        reader["pin"].ToString()
                    );
                        _items.Add(customer);
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

        public CUSTOMER SearchByPhone(object keyWork)
        {
            if (keyWork.Equals(""))
            {
                return null;
            }
            else
            {
                SqlConnection con = DatabaseHelper.getConnection();
                try
                {
                    con.Open();
                    string query = "SELECT * FROM CUSTOMER WHERE phone = @phone";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@phone", keyWork);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CUSTOMER customer = new CUSTOMER(
                        reader["id"].ToString(),
                        reader["name"].ToString(),
                        reader["phone"].ToString(),
                        reader["email"].ToString(),
                        reader["house_no"].ToString(),
                        reader["city"].ToString(),
                        reader["pin"].ToString()
                    );

                        return customer;
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
        }

        public bool Update(IModel model)
        {
            CUSTOMER customer = model as CUSTOMER;

            bool checkChangePin = false;

            if(customer.pin.Equals(""))
            {
                customer.pin = "temporaryPassword";
            }else
            {
                customer.pin = hash(customer.pin);
                checkChangePin = true;
            }

            if (!customer.isValidate(customer))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ !");
                return false;
            }

            if (!IsExist(customer.id))
            {
                MessageBox.Show("Không tồn tại id này trong customer");
                return false;
            }

            SqlConnection con = DatabaseHelper.getConnection();

            if (checkChangePin)
            {
                try
                {
                    con.Open();
                    string query = "UPDATE CUSTOMER SET name = @name, phone = @phone" +
                        ", email = @email, house_no = @house_no, city = @city, pin = @pin WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", customer.id);
                    cmd.Parameters.AddWithValue("@name", customer.name);
                    cmd.Parameters.AddWithValue("@phone", customer.phone);
                    cmd.Parameters.AddWithValue("@email", customer.email);
                    cmd.Parameters.AddWithValue("@house_no", customer.houseNo);
                    cmd.Parameters.AddWithValue("@city", customer.city);
                    cmd.Parameters.AddWithValue("@pin", customer.pin);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.");
                        return false;
                    }

                }
                
                finally
                {
                    con.Close();
                }
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE CUSTOMER SET name = @name, phone = @phone" +
                        ", email = @email, house_no = @house_no, city = @city WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", customer.id);
                    cmd.Parameters.AddWithValue("@name", customer.name);
                    cmd.Parameters.AddWithValue("@phone", customer.phone);
                    cmd.Parameters.AddWithValue("@email", customer.email);
                    cmd.Parameters.AddWithValue("@house_no", customer.houseNo);
                    cmd.Parameters.AddWithValue("@city", customer.city);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.");
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công.");
                    return false;
                }
                finally
                {
                    con.Close();
                }
            }

            
        }
    }
}
