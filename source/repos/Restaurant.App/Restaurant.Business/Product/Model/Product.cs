using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business.Product.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public float Price{ get; set; }
        public DateTime DateCreated { get; set; }
        public Product(int id, string name, int quantity, float price, DateTime dateCreated)
        {
            ProductId = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            DateCreated = dateCreated;
        }
    }
}
