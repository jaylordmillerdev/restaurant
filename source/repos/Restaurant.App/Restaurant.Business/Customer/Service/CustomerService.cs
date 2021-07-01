using Restaurant.Business.Customer.Model;
using Restaurant.Business.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Restaurant.Business.Customer.Service
{
    public class CustomerService : IDatabaseConnection, IServiceRepository<CustomerModel>
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
                return new RequestResult("Encounter an error saving customer, please contact admin", false);
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
                return new RequestResult("Encounter an error updated customer, please contact admin", false);
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
                return new RequestResult("Encounter an error deleting customer, please contact admin", false);
            }
        }
        public List<CustomerModel> FetchAll()
        {
            List<CustomerModel> Customers = new List<CustomerModel>();
            string query = "EXEC FetchAllCustomer;";
            using (SqlCommand oCmd = new SqlCommand(query, Connection))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
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
        public List<string> FetchAllCustomerNameAndId()
        {
            List<string> Customers = new List<string>();
            string query = "EXEC FetchAllCustomer;";
            using (SqlCommand oCmd = new SqlCommand(query, Connection))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Customers.Add(oReader["Firstname"].ToString() + " " + oReader["Lastname"].ToString()+ " - #" + oReader["ID"].ToString());
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
