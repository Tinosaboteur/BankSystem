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
    internal class nhanvienController: IController
    {
        private List<IModel> _items;
        public List<IModel> Items => this._items;

        public nhanvienController()
        {
            _items = new List<IModel>();
        }
		public bool Create(IModel model)
		{

			EMPLOYEE employee = model as EMPLOYEE;
			if (!employee.isValidate(employee))
			{
				MessageBox.Show("Nhập thiếu cột ID hoặc Role");
				return false;
			}

			if (IsExist(employee.id))
			{
				MessageBox.Show("Đã tồn tại ID này trong nhân viên");
				return false;
			}

			SqlConnection con = DatabaseHelper.getConnection();
			try
			{
				con.Open();
				string query = "INSERT INTO EMPLOYEE (id, password, role) VALUES (@id, @password, @role)";
				SqlCommand cmd = new SqlCommand(query, con);

				employee.password = hash(employee.password);

				cmd.Parameters.AddWithValue("@id", employee.id);
				cmd.Parameters.AddWithValue("@password", employee.password);
				cmd.Parameters.AddWithValue("@role", employee.role);
				int rowsAffected = cmd.ExecuteNonQuery();

				if (rowsAffected > 0)
				{
					MessageBox.Show("Thêm nhân viên thành công!");
					return true;
				}
				else
				{
					MessageBox.Show("Thêm nhân viên không thành công.");
					return false;
				}
			}
			
			finally
			{
				con.Close();
			}
		}

		public bool Update(IModel model)
		{
			EMPLOYEE employee = model as EMPLOYEE;

			if (!employee.isValidate(employee))
			{
				MessageBox.Show("Nhập thiếu cột ID hoặc Role");
				return false;
			}

			if (!IsExist(employee.id))
			{
				MessageBox.Show("Không tòn tại id này");
				return false;
			}

			SqlConnection con = DatabaseHelper.getConnection();

			try
			{
				con.Open();
				int rowsAffected = 0;
				if (employee.password != "")
				{
					string query = "UPDATE EMPLOYEE SET password = @password, role = @role WHERE id = @id";
					SqlCommand cmd = new SqlCommand(query, con);

					employee.password = hash(employee.password);
					cmd.Parameters.AddWithValue("@id", employee.id);
					cmd.Parameters.AddWithValue("@password", employee.password);
					cmd.Parameters.AddWithValue("@role", employee.role);

					rowsAffected = cmd.ExecuteNonQuery();
				}
				else
				{
					string query = "UPDATE EMPLOYEE SET role = @role WHERE id = @id";
					SqlCommand cmd = new SqlCommand(query, con);

					cmd.Parameters.AddWithValue("@id", employee.id);
					cmd.Parameters.AddWithValue("@role", employee.role);

					rowsAffected = cmd.ExecuteNonQuery();
				}

				if (rowsAffected > 0)
				{
					MessageBox.Show("Sửa nhân viên thành công!");
					return true;
				}
				else
				{
					MessageBox.Show("Sửa nhân viên không thành công.");
					return false;
				}

			}
			
			finally
			{
				con.Close();
			}
		}
		public string hash(string password)
        {
            using(SHA256 sha256 = SHA256.Create())
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
   

        public bool Load()
        {
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "SELECT * FROM EMPLOYEE";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EMPLOYEE employee = new EMPLOYEE(
                        reader["id"].ToString(),
                        reader["password"].ToString(),
                        reader["role"].ToString()
                    );

                    _items.Add(employee);
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

        

        public bool Delete(object id)
        {
            throw new NotImplementedException();
        }

        public IModel Read(object id)
        {
            throw new NotImplementedException();
        }

        public bool IsExist(object id)
        {
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "SELECT * FROM EMPLOYEE WHERE id = @id";
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

        public void Search(object keyWork)
        {
            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "SELECT * FROM EMPLOYEE WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", keyWork);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EMPLOYEE employee = new EMPLOYEE(
                        reader["id"].ToString(),
                        reader["password"].ToString(),
                        reader["role"].ToString()
                    );
                    _items.Add(employee);
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

        public bool login(string userId, string password)
        {
            password = hash(password);

            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "SELECT * FROM EMPLOYEE WHERE id = @id AND password = @password";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", userId);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //lưu vào phiên
                    phien.employeeId = reader["id"].ToString();
                    phien.role = reader["role"].ToString();

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
    }
}
