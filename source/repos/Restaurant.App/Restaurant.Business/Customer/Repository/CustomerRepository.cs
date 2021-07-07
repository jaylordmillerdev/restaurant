using Restaurant.Business.Customer.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Restaurant.Business.Customer.Repository
{
    public class CustomerRepository
    {
        public RequestResult Save(Model.Customer customer, SqlConnection connection)
        {
            RequestResult validate = CustomerDataValidation.isDataValid(customer);
            if (!validate.isSuccess)
            {
                return validate;
            }
            try
            {
                string query = $"EXEC StoreCustomer @Firstname = '{customer.Firstname}', @Lastname = '{customer.Lastname}', @Address = '{customer.Address}';";
                using (SqlCommand myCommand = new SqlCommand(query, connection))
                {
                    myCommand.ExecuteNonQuery();
                    return new RequestResult("Customer successfully save", true);
                }
            }
            catch (Exception ex)
            {
                return new RequestResult("Encounter an error saving customer, please contact admin", false);
            }
        }
        public RequestResult Update(Model.Customer customer, SqlConnection connection)
        {
            RequestResult validate = CustomerDataValidation.isDataValid(customer);
            if (!validate.isSuccess)
            {
                return validate;
            }
            try
            {
                string query = $"EXEC UpdateCustomer @Firstname = '{customer.Firstname}', @Lastname = '{customer.Lastname}', @Address = '{customer.Address}', @id = '{customer.Id}';";
                using (SqlCommand myCommand = new SqlCommand(query, connection))
                {
                    myCommand.ExecuteNonQuery();
                    return new RequestResult("Customer successfully updated", true);
                }
            }
            catch (Exception ex)
            {
                return new RequestResult("Encounter an error updated customer, please contact admin", false);
            }
        }
        public RequestResult Delete(int id, SqlConnection connection)
        {
            try
            {
                string query = $"EXEC DeleteCustomer @id = {id}";
                using (SqlCommand myCommand = new SqlCommand(query, connection))
                {
                    myCommand.ExecuteNonQuery();
                    return new RequestResult("Customer successfully deleted", true);
                }
            }
            catch (Exception ex)
            {
                return new RequestResult("Encounter an error deleting customer, please contact admin", false);
            }
        }
        public List<Model.Customer> FetchAll(SqlConnection connection)
        {
            List<Model.Customer> Customers = new List<Model.Customer>();
            string query = "EXEC FetchAllCustomer;";
            using (SqlCommand oCmd = new SqlCommand(query, connection))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Customers.Add(new Model.Customer(
                            id: Int32.Parse(oReader["ID"].ToString()),
                            firstname: oReader["Firstname"].ToString(),
                            lastname: oReader["Lastname"].ToString(),
                            address: oReader["Address"].ToString(),
                            dateCreated: Convert.ToDateTime(oReader["DateCreated"].ToString())
                        ));
                    }
                }
            }
            return Customers;
        }
        public List<string> FetchAllCustomerNameAndId(SqlConnection connection)
        {
            List<string> Customers = new List<string>();
            string query = "EXEC FetchAllCustomer;";
            using (SqlCommand oCmd = new SqlCommand(query, connection))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Customers.Add(oReader["Firstname"].ToString() + " " + oReader["Lastname"].ToString() + " - #" + oReader["ID"].ToString());
                    }
                }
            }
            return Customers;
        }
    }
}
