using System.Data.SqlClient;

namespace Restaurant.Business
{
    public class DatabaseConnection
    {
        public SqlConnection Connection;
        public SqlConnection Connect()
        {
            Connection = new SqlConnection("server=DESKTOP-CHM8OKV;Database=restaurant;Trusted_Connection=True;");
            Connection.Open();
            return Connection;
        }
        public void Disconnect()
        {
            Connection.Close();
        }
    }
}
