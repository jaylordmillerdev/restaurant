using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business.Order.Model
{
    public class OrderModel
    {
        public int Id { get; }
        public int CustomerId { get; }
        public int ProductId { get; }
        public int Quantity { get; }
        public int IsDelivered { get; }
        public DateTime DateCreated { get; }
        public string ProductName { get; }
        public float ProductPrice { get; }
        public string CustomerFirstname { get; }
        public string CustomerLastname { get; }
        public string CustomerAddress { get; }
        public OrderModel(
            int id,
            int customerId,
            int productId,
            int quantity,
            int isDelivered,
            DateTime dateCreated,
            string productName,
            float productPrice,
            string customerFirstname,
            string customerLastname,
            string customerAddress)
        {
            Id = id;
            CustomerId = customerId;
            ProductId = productId;
            Quantity = quantity;
            IsDelivered = isDelivered;
            DateCreated = dateCreated;
            ProductName = productName;
            ProductPrice = productPrice;
            CustomerFirstname = customerFirstname;
            CustomerLastname = customerLastname;
            CustomerAddress = customerAddress;
        }
    }
}
