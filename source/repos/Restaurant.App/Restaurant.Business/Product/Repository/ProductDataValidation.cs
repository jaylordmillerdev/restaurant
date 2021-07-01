using Restaurant.Business.Product.Model;

namespace Restaurant.Business.Product.Repository
{
    public static class ProductDataValidation
    {
        public static RequestResult isDataValid(ProductModel data)
        {
            if (data.Name == "")
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
