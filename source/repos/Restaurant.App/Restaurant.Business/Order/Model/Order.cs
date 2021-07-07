using System;

namespace Restaurant.Business.Order.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int IsDelivered { get; set; }
        public DateTime DateCreated { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public string CustomerFirstname { get; set; }
        public string CustomerLastname { get; set; }
        public string CustomerAddress { get; set; }
        public Order(
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
