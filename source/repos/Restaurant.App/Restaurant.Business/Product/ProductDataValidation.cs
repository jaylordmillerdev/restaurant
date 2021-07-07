using Restaurant.Business.Product.Model;

namespace Restaurant.Business.Product
{
    public static class ProductDataValidation
    {
        public static RequestResult isDataValid(Model.Product data)
        {
            if (data.Name == string.Empty)
            {
                return new RequestResult("*Name is empty", false);
            }
            if (data.Quantity == 0)
            {
                return new RequestResult("*Quantity is empty", false);
            }

            return new RequestResult("Valid", true);
        }
    }
}
