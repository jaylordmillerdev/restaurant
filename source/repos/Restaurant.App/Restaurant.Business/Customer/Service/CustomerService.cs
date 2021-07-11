using Restaurant.Business.Customer.Model;
using Restaurant.Business.Customer.Repository;
using System;
using System.Collections.Generic;

namespace Restaurant.Business.Customer.Service
{
    public class CustomerService : IServiceRepository<Model.Customer>
    {
        public RequestResult Save(Model.Customer customer)
        {
            RequestResult result = new CustomerRepository().Save(customer);
            return result;
        }

        public RequestResult Update(Model.Customer customer)
        {
            RequestResult result = new CustomerRepository().Update(customer);
            return result;
        }
        public RequestResult Delete(int id)
        {
            RequestResult result = new CustomerRepository().Delete(id);
            return result;
        }
        public List<Model.Customer> FetchAll()
        {
            List<Model.Customer> Customers = new CustomerRepository().FetchAll();
            return Customers;
        }
        public List<string> FetchAllCustomerNameAndId()
        {
            List<string> Customers = new CustomerRepository().FetchAllCustomerNameAndId();
            return Customers;
        }
    }
}
