using Restaurant.Business.Product.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Restaurant.Business.Product.Service
{
    public class ProductService : DatabaseConnection, IServiceRepository<Model.Product>
    {
        public ProductService(String connectionString)
        {
            Connect(connectionString);
        }
        public void Connect(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }
        public RequestResult Save(Model.Product product)
        {
            RequestResult result = new ProductRepository().Save(product, Connection);
            Disconnect();
            return result;
        }
        public RequestResult Update(Model.Product product)
        {
            RequestResult result = new ProductRepository().Update(product, Connection);
            Disconnect();
            return result;
        }
        public RequestResult Delete(int id)
        {
            RequestResult result = new ProductRepository().Delete(id, Connection);
            Disconnect();
            return result;
        }
        public List<Model.Product> FetchAll()
        {
            List<Model.Product> Products = new ProductRepository().FetchAll(Connection);
            Disconnect();
            return Products;
        }
        public List<Model.Product> Filter(string filter)
        {
            List<Model.Product> Products = new ProductRepository().Filter(filter, Connection);
            Disconnect();
            return Products;

        }
    }
}
