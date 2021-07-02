using Restaurant.Business;
using Restaurant.Business.Order.Model;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Restaurant.App.Service
{
    public class OrderService : IService<Restaurant.Business.Order.Service.OrderService>
    {
        public OrderService()
        {
            Service = new Restaurant.Business.Order.Service.OrderService(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString);
        }
        public RequestResult Save(int customerId, int productId, int quantity, int isDelivered)
        {
            NewOrderModel data = new NewOrderModel(
                    id: 0,
                    customerId: customerId,
                    productId: productId,
                    quantity: quantity,
                    isDelivered: isDelivered,
                    dateCreated: DateTime.Now
                );
            return Service.Save(data);
        }
        public RequestResult Delete(int id)
        {
            return Service.Delete(id);
        }
        public RequestResult DeliverOrder(int orderId, int quantity)
        {
            return Service.DeliverOrder(orderId: orderId, quantity: quantity);
        }
        public RequestResult Update(int id, int customerId, int productId, int quantity, int isDelivered)
        {
            NewOrderModel data = new NewOrderModel(
                    id: id,
                    customerId: customerId,
                    productId: productId,
                    quantity: quantity,
                    isDelivered: isDelivered,
                    dateCreated: DateTime.Now
                );
            return Service.Update(data);
        }
        public List<OrderModel> GetAllOrder() { 
            return Service.FetchAll(); 
        }
        public List<OrderModel> GetAllOrderFromDateFilter(string startDate, string endDate) {
            return Service.FetchAllByDateFilter(start: startDate, end: endDate);
        }
        public Restaurant.Business.Order.Service.OrderService Service { get; }
    }
}
