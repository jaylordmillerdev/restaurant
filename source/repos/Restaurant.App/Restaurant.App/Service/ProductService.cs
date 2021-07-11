using Restaurant.Business;
using Restaurant.Business.Product.Model;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Restaurant.App.Service
{
    class ProductService : IService<Restaurant.Business.Product.Service.ProductService>
    {
        public ProductService()
        {
            Service = new Restaurant.Business.Product.Service.ProductService();
        }
        public RequestResult Save(string name, int quantity, float price)
        {
            Product data = new Product(
                    id: 0,
                    name: name,
                    quantity: quantity,
                    price: price,
                    dateCreated: DateTime.Now
                );
            return Service.Save(data);
        }
        public RequestResult Delete(int id)
        {
            return Service.Delete(id);
        }
        public RequestResult Update(string name, int quantity, float price, int id)
        {
            Product data = new Product(
                    id: id,
                    name: name,
                    quantity: quantity,
                    price: price,
                    dateCreated: DateTime.Now
                );
            return Service.Update(data);
        }
        public List<Product> GetAllProduct() {
            return Service.FetchAll();
        }
        public List<Product> FilterProduct(string filter) {
            return Service.Filter(filter);
        }
        public Restaurant.Business.Product.Service.ProductService Service { get; }
    }
}
