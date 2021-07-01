using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business.Product.Model
{
    public class ProductModel
    {
        public int ProductId { get; }
        public string Name { get; }
        public int Quantity { get; }
        public float Price{ get; }
        public DateTime DateCreated { get; }
        public ProductModel(int id, string name, int quantity, float price, DateTime dateCreated)
        {
            ProductId = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            DateCreated = dateCreated;
        }
    }
}
