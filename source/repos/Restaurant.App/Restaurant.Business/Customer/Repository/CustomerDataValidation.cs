using Restaurant.Business.Customer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Business.Repository
{
    public static class CustomerDataValidation
    {
        public static RequestResult isDataValid(CustomerModel data)
        {
            if (data.Firstname == "")
            {
                return new RequestResult("*Firstname is empty", false);
            }
            if (data.Lastname == "")
            {
                return new RequestResult("*Lastname is empty", false);
            }
            if (data.Address == "")
            {
                return new RequestResult("*Address is empty", false);
            }

            return new RequestResult("Valid", true);
        }
    }
}
