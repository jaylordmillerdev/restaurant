using Restaurant.Business.Order.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business.Order.Repository
{
    public class NewOrderDataValidation
    {
        public static RequestResult isDataValid(NewOrderModel data)
        {
            if (data.Quantity == 0)
            {
                return new RequestResult("*Quantity is empty", false);
            }

            return new RequestResult("Valid", true);
        }
    }
}
