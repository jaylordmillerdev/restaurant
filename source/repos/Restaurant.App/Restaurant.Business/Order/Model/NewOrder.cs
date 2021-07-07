using System;

namespace Restaurant.Business.Order.Model
{
    public class NewOrder
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int IsDelivered { get; set; }
        public DateTime DateCreated { get; set; }
        public NewOrder(
            int id,
            int customerId,
            int productId,
            int quantity,
            int isDelivered,
            DateTime dateCreated)
        {
            Id = id;
            CustomerId = customerId;
            ProductId = productId;
            Quantity = quantity;
            IsDelivered = isDelivered;
            DateCreated = dateCreated;
        }
    }
}
