using Restaurant.Business.Product.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Restaurant.Business.Product.Service
{
    public class ProductService : IServiceRepository<Model.Product>
    {
        public RequestResult Save(Model.Product product)
        {
            RequestResult result = new ProductRepository().Save(product);
            return result;
        }
        public RequestResult Update(Model.Product product)
        {
            RequestResult result = new ProductRepository().Update(product);
            return result;
        }
        public RequestResult Delete(int id)
        {
            RequestResult result = new ProductRepository().Delete(id);
            return result;
        }
        public List<Model.Product> FetchAll()
        {
            List<Model.Product> Products = new ProductRepository().FetchAll();
            return Products;
        }
        public List<Model.Product> Filter(string filter)
        {
            List<Model.Product> Products = new ProductRepository().Filter(filter);
            return Products;

        }
    }
}
