using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business.Customer.Model
{
    public class CustomerModel
    {
        public int Id { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public string Address { get; }
        public DateTime DateCreated { get; }
        public CustomerModel(int id, string firstname, string lastname, string address, DateTime dateCreated)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            DateCreated = dateCreated;
        }
    }
}
