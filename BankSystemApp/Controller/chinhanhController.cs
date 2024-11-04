using BankSystem.Databasehelper;
using BankSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankSystem.Controller
{
    internal class chinhanhController : IController
    {
        private List<IModel> _items;
        public List<IModel> Items => this._items;

        public chinhanhController()
        {
            _items = new List<IModel>();
        }

        public bool Create(IModel model)
        {
            BRANCH branch = model as BRANCH;
			if (branch == null) return false;
			if (!branch.isValidate(branch))
            {
                MessageBox.Show("Nhập đầy đủ thông tin !");
                return false;
            }

            if (IsExist(branch.id))
            {
                MessageBox.Show("ID đã tồn tại");
                return false;
            }

            SqlConnection con = DatabaseHelper.getConnection();
            try
            {
                con.Open();
                string query = "INSERT INTO BRANCH (id, name, house_no, city) " +
                    "VALUES (@id, @name, @house_no, @city)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", branch.id);
                cmd.Parameters.AddWithValue("@name", branch.name);
                cmd.Parameters.AddWithValue("@house_no", branch.houseNo);
                cmd.Parameters.AddWithValue("@city", branch.city);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đã thêm chi nhánh mới!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Lỗi!!!");
                    return false;
                }
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
                string query = "SELECT * FROM BRANCH WHERE id = @id";
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
                string query = "SELECT * FROM BRANCH";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BRANCH branch = new BRANCH(
                        reader["id"].ToString(),
                        reader["name"].ToString(),
                        reader["house_no"].ToString(),
                        reader["city"].ToString()
                    );

                    _items.Add(branch);
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
            if (keyWork.Equals(""))
            {
                Load();
            }else
            {
                SqlConnection con = DatabaseHelper.getConnection();
                try
                {
                    con.Open();
                    string query = "SELECT * FROM BRANCH WHERE name = @name";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@name", keyWork);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        BRANCH branch = new BRANCH(
                            reader["id"].ToString(),
                            reader["name"].ToString(),
                            reader["house_no"].ToString(),
                            reader["city"].ToString()
                        );
                        _items.Add(branch);
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

        public bool Update(IModel model)
        {
            BRANCH branch = model as BRANCH;

            if (!branch.isValidate(branch))
            {
                MessageBox.Show("Nhập đầy đủ thông tin");
                return false;
            }

            if (!IsExist(branch.id))
            {
                MessageBox.Show("ID không tồn tại");
                return false;
            }

            SqlConnection con = DatabaseHelper.getConnection();

            try
            {
                con.Open();
                string query = "UPDATE BRANCH SET name = @name, house_no = @house_no, city = @city WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", branch.id);
                cmd.Parameters.AddWithValue("@name", branch.name);
                cmd.Parameters.AddWithValue("@house_no", branch.houseNo);
                cmd.Parameters.AddWithValue("@city", branch.city);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Lỗi!!!");
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
