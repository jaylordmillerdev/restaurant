using Restaurant.Business.Order.Model;
using Restaurant.Business.Order.Repository;
using System;
using System.Collections.Generic;

namespace Restaurant.Business.Order.Service
{
    public class OrderService
    {
        public RequestResult Save(NewOrder order)
        {
            RequestResult result = new OrderRepository().Save(order);
            return result;
        }
        public RequestResult Update(NewOrder order)
        {
            RequestResult result = new OrderRepository().Update(order);
            return result;

        }
        public RequestResult Delete(int id)
        {
            RequestResult result = new OrderRepository().Delete(id);
            return result;
        }
        public List<Model.Order> FetchAll()
        {
            List<Model.Order> Products = new OrderRepository().FetchAll();
            return Products;

        }
        public List<Model.Order> FetchAllByDateFilter(string start, string end)
        {
            List<Model.Order> Orders = new OrderRepository().FetchAllByDateFilter(start, end);
            return Orders;
        }
        public int GetUndeliveredCount()
        {
            int count = new OrderRepository().GetUndeliveredCount();
            return count;
        }
        public RequestResult DeliverOrder(int orderId, int quantity)
        {
            RequestResult result = new OrderRepository().DeliverOrder(orderId, quantity);
            return result;
        }
    }
}
