using System;

namespace Restaurant.Business.Customer.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public DateTime DateCreated { get; set; }
        public Customer(int id, string firstname, string lastname, string address, DateTime dateCreated)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            DateCreated = dateCreated;
        }
    }
}
