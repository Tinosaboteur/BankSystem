using System.Data.SqlClient;

namespace BankSystem.Databasehelper
{
    internal class DatabaseHelper
    {
        public static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=TINO;Initial Catalog=BankSystem;Persist Security Info=True;User ID=phamducthong;Password=phamducthong;TrustServerCertificate=True");
            return con;
        }
    }
}
