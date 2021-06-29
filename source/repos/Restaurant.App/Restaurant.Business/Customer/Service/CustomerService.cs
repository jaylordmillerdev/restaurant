using Restaurant.Business.Customer.Model;
using Restaurant.Business.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Restaurant.Business.Customer.Service
{
    public class CustomerService : IDatabaseConnection, IService<CustomerModel>
    {
        SqlConnection Connection;
        public CustomerService(String connectionString)
        {
            Connect(connectionString);
        }
        public void Connect(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }
        public RequestResult Save(CustomerModel customer)
        {
            RequestResult validate = CustomerDataValidation.isDataValid(customer);
            if (!validate.isSuccess)
            {
                return validate;
            }
            try
            {
                string query = "EXEC StoreCustomer @Firstname = '" + customer.Firstname + "', @Lastname = '" + customer.Lastname + "', @Address = '" + customer.Address + "';";
                using (SqlCommand myCommand = new SqlCommand(query, Connection))
                {
                    myCommand.ExecuteNonQuery();
                    Disconnect();
                    return new RequestResult("Customer successfully save", true);
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                return new RequestResult("Encounter an error saving customer: " + ex.Message, false);
            }
        }

        public RequestResult Update(CustomerModel customer)
        {
            RequestResult validate = CustomerDataValidation.isDataValid(customer);
            if (!validate.isSuccess)
            {
                return validate;
            }
            try
            {
                string query = "EXEC UpdateCustomer @Firstname = '" + customer.Firstname + "', @Lastname = '" + customer.Lastname + "', @Address = '" + customer.Address + "', @id = '" + customer.Id+ "';";
                using (SqlCommand myCommand = new SqlCommand(query, Connection))
                {
                    myCommand.ExecuteNonQuery();
                    Disconnect();
                    return new RequestResult("Customer successfully updated", true);
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                return new RequestResult("Encounter an error updated customer: " + ex.Message, false);
            }
        }
        public RequestResult Delete(int id)
        {
            try
            {
                string query = $"EXEC DeleteCustomer @id = {id}";
                using (SqlCommand myCommand = new SqlCommand(query, Connection))
                {
                    myCommand.ExecuteNonQuery();
                    Disconnect();
                    return new RequestResult("Customer successfully deleted", true);
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                return new RequestResult("Encounter an error deleting customer: " + ex.Message, false);
            }
        }
        public List<CustomerModel> GetAllCustomer()
        {
            List<CustomerModel> Customers = new List<CustomerModel>();
            string query = "EXEC FetchAllCustomer;";
            using (SqlCommand oCmd = new SqlCommand(query, Connection))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Console.WriteLine("First "+oReader["Firstname"].ToString());
                        Customers.Add(new CustomerModel(
                            id: Int32.Parse(oReader["ID"].ToString()),
                            firstname: oReader["Firstname"].ToString(),
                            lastname: oReader["Lastname"].ToString(),
                            address: oReader["Address"].ToString(),
                            dateCreated: Convert.ToDateTime(oReader["DateCreated"].ToString())
                        ));
                    }
                }
            }
            Disconnect();
            return Customers;
        }
        public void Disconnect()
        {
            Connection.Close();
        }
    }
}
