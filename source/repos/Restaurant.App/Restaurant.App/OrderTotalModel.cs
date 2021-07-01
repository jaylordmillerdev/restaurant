using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.App
{
    public class OrderTotalModel
    {
        public float Price { get; }
        public int Quantity { get; }

        public OrderTotalModel(float price, int quantity)
        {
            Total = price * quantity;
        }

        public float Total { get; }
    }
}
