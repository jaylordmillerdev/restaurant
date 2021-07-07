using Restaurant.Business.Customer.Model;

namespace Restaurant.Business
{
    public static class CustomerDataValidation
    {
        public static RequestResult isDataValid(Customer.Model.Customer data)
        {
            if (data.Firstname == string.Empty)
            {
                return new RequestResult("*Firstname is empty", false);
            }
            if (data.Lastname == string.Empty)
            {
                return new RequestResult("*Lastname is empty", false);
            }
            if (data.Address == string.Empty)
            {
                return new RequestResult("*Address is empty", false);
            }

            return new RequestResult("Valid", true);
        }
    }
}
