using Restaurant.Business.Customer.Model;
using Restaurant.Business.Customer.Repository;
using System;
using System.Collections.Generic;

namespace Restaurant.Business.Customer.Service
{
    public class CustomerService : DatabaseConnection, IServiceRepository<Model.Customer>
    {
        public CustomerService(string connectionString)
        {
            Connect(connectionString);
        }
        public RequestResult Save(Model.Customer customer)
        {
            RequestResult result = new CustomerRepository().Save(customer, Connection);
            Disconnect();
            return result;
        }

        public RequestResult Update(Model.Customer customer)
        {
            RequestResult result = new CustomerRepository().Update(customer, Connection);
            Disconnect();
            return result;
        }
        public RequestResult Delete(int id)
        {
            RequestResult result = new CustomerRepository().Delete(id, Connection);
            Disconnect();
            return result;
        }
        public List<Model.Customer> FetchAll()
        {
            List<Model.Customer> Customers = new CustomerRepository().FetchAll(Connection);
            Disconnect();
            return Customers;
        }
        public List<string> FetchAllCustomerNameAndId()
        {
            List<string> Customers = new CustomerRepository().FetchAllCustomerNameAndId(Connection);
            Disconnect();
            return Customers;
        }
    }
}
