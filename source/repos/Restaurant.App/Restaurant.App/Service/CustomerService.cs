using Restaurant.Business;
using Restaurant.Business.Customer.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.App.Service
{
    public class CustomerService : IService<Restaurant.Business.Customer.Service.CustomerService>
    {
        public CustomerService()
        {
            Service = new Business.Customer.Service.CustomerService();
        }
        public RequestResult Save(string firstname, string lastname, string address)
        {
            Customer data = new Customer(
                    id: 0,
                    firstname: firstname,
                    lastname: lastname,
                    address: address,
                    dateCreated: DateTime.Now
                );
            return Service.Save(data);
        }
        public RequestResult Delete(int id)
        {
            return Service.Delete(id);
        }
        public RequestResult Update(string firstname, string lastname, string address, int id)
        {
            Customer data = new Customer(
                    id: id,
                    firstname: firstname,
                    lastname: lastname,
                    address: address,
                    dateCreated: DateTime.Now
                );
            return Service.Update(data);
        }
        public List<Customer> GetAllCustomer() {
            return Service.FetchAll();
        }
        public List<string> GetAllCustomerNameAndID() {
            return Service.FetchAllCustomerNameAndId();
        }
        public Restaurant.Business.Customer.Service.CustomerService Service { get; }
    }
}
