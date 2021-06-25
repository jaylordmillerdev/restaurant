using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business.Customer.Repository
{
    class CustomerModel
    {
        public int Id { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public string Address { get; }
        public DateTime DateAdded { get; }
        public int Active { get; }
        public CustomerModel(int id, string firstname, string lastname, string address, DateTime dateAdded, int active)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            DateAdded = dateAdded;
            Active = active;
        }
    }
}
