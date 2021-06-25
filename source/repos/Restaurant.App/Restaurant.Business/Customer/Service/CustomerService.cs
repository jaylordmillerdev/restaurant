using Restaurant.Business.Customer.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business.Customer.Service
{
    class CustomerService : IDatabaseConnection
    {
        SqlConnection Connection;
        public void Connect(string url)
        {
            Connection = new SqlConnection(url);
            Connection.Open();
        }
        public void SaveCustomer(CustomerModel customer)
        {
            using (SqlCommand myCommand = new SqlCommand("", Connection))
            {
                myCommand.ExecuteNonQuery();
            }
        }
        public void Disconnect()
        {
            Connection.Close();
        }
    }
}
