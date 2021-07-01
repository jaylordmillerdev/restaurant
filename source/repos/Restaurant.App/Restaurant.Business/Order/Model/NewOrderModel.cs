using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business.Order.Model
{
    public class NewOrderModel
    {
        public int Id { get; }
        public int CustomerId { get; }
        public int ProductId { get; }
        public int Quantity { get; }
        public int IsDelivered { get; }
        public DateTime DateCreated { get; }
        public NewOrderModel(
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
