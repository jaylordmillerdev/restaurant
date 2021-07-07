using Restaurant.Business.Order.Model;
using Restaurant.Business.Order.Repository;
using System;
using System.Collections.Generic;

namespace Restaurant.Business.Order.Service
{
    public class OrderService : DatabaseConnection
    {
        public OrderService(string connectionString)
        {
            Connect(connectionString);
        }
        public RequestResult Save(NewOrder order)
        {
            RequestResult result = new OrderRepository().Save(order, Connection);
            Disconnect();
            return result;
        }
        public RequestResult Update(NewOrder order)
        {
            RequestResult result = new OrderRepository().Update(order, Connection);
            Disconnect();
            return result;

        }
        public RequestResult Delete(int id)
        {
            RequestResult result = new OrderRepository().Delete(id, Connection);
            Disconnect();
            return result;
        }
        public List<Model.Order> FetchAll()
        {
            List<Model.Order> Products = new OrderRepository().FetchAll(Connection);
            Disconnect();
            return Products;

        }
        public List<Model.Order> FetchAllByDateFilter(string start, string end)
        {
            List<Model.Order> Orders = new OrderRepository().FetchAllByDateFilter(start, end, Connection);
            Disconnect();
            return Orders;
        }
        public int GetUndeliveredCount()
        {
            int count = new OrderRepository().GetUndeliveredCount(Connection);
            Disconnect();
            return count;
        }
        public RequestResult DeliverOrder(int orderId, int quantity)
        {
            RequestResult result = new OrderRepository().DeliverOrder(orderId, quantity, Connection);
            Disconnect();
            return result;
        }
    }
}
