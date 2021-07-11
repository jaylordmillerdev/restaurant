using Restaurant.App.Shared;
using Restaurant.Business.Order.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Restaurant.Business.Order.Repository
{
    public class OrderRepository : DatabaseConnection
    {
        public RequestResult Save(NewOrder order)
        {
            RequestResult validate = NewOrderDataValidation.isDataValid(order);
            if (!validate.isSuccess)
            {
                return validate;
            }
            try
            {
                string query = $"EXEC StoreOrder @CustomerId = {order.CustomerId}, @ProductId = {order.ProductId}, @Quantity = {order.Quantity}, @IsDelivered = {order.IsDelivered};";
                using (SqlCommand myCommand = new SqlCommand(query, Connect()))
                {
                    myCommand.ExecuteNonQuery();
                    Disconnect();
                    return new RequestResult("Order successfully save", true);
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                return new RequestResult("Encounter an error saving order, please contact admin", false);
            }
        }
        public RequestResult Update(NewOrder order)
        {
            RequestResult validate = NewOrderDataValidation.isDataValid(order);
            if (!validate.isSuccess)
            {
                return validate;
            }
            try
            {
                string query = $"EXEC UpdateOrder @CustomerId = {order.CustomerId}, @ProductId = {order.ProductId}, @Quantity = {order.Quantity}, @IsDelivered = {order.IsDelivered}, @Id = {order.Id};";
                using (SqlCommand myCommand = new SqlCommand(query, Connect()))
                {
                    myCommand.ExecuteNonQuery();
                    Disconnect();
                    return new RequestResult("Order successfully updated", true);
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                return new RequestResult("Encounter an error updated order, please contact admin", false);
            }
        }
        public RequestResult Delete(int id)
        {
            try
            {
                string query = $"EXEC DeleteOrder @Id = {id}";
                using (SqlCommand myCommand = new SqlCommand(query, Connect()))
                {
                    myCommand.ExecuteNonQuery();
                    Disconnect();
                    return new RequestResult("Order successfully deleted", true);
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                return new RequestResult("Encounter an error deleting customer, please contact admin", false);
            }
        }
        public List<Model.Order> FetchAll()
        {
            List<Model.Order> Products = new List<Model.Order>();
            string query = "EXEC FetchAllOrder;";
            using (SqlCommand oCmd = new SqlCommand(query, Connect()))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Products.Add(new Model.Order(
                            id: Int32.Parse(oReader["ID"].ToString()),
                            customerId: Int32.Parse(oReader["CustomerID"].ToString()),
                            productId: Int32.Parse(oReader["ProductID"].ToString()),
                            dateCreated: Convert.ToDateTime(oReader["OrderCreated"].ToString()),
                            quantity: Int32.Parse(oReader["OrderQuantity"].ToString()),
                            isDelivered: Int32.Parse(oReader["IsDelivered"].ToString()),
                            productName: oReader["ProductName"].ToString(),
                            productPrice: float.Parse(oReader["Price"].ToString()),
                            customerFirstname: oReader["CustomerFirstname"].ToString(),
                            customerLastname: oReader["CustomerLastname"].ToString(),
                            customerAddress: oReader["CustomerAddress"].ToString()
                        ));
                    }
                }
            }
            Disconnect();
            return Products;
        }
        public List<Model.Order> FetchAllByDateFilter(string start, string end)
        {
            List<Model.Order> Products = new List<Model.Order>();
            string query = $"EXEC FilterByDate @StartDate = '{start}', @EndDate = '{end}';";
            using (SqlCommand oCmd = new SqlCommand(query, Connect()))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Products.Add(new Model.Order(
                            id: Int32.Parse(oReader["ID"].ToString()),
                            customerId: Int32.Parse(oReader["CustomerID"].ToString()),
                            productId: Int32.Parse(oReader["ProductID"].ToString()),
                            dateCreated: Convert.ToDateTime(oReader["OrderCreated"].ToString()),
                            quantity: Int32.Parse(oReader["OrderQuantity"].ToString()),
                            isDelivered: Int32.Parse(oReader["IsDelivered"].ToString()),
                            productName: oReader["ProductName"].ToString(),
                            productPrice: float.Parse(oReader["Price"].ToString()),
                            customerFirstname: oReader["CustomerFirstname"].ToString(),
                            customerLastname: oReader["CustomerLastname"].ToString(),
                            customerAddress: oReader["CustomerAddress"].ToString()
                        ));
                    }
                }
            }
            Disconnect();
            return Products;
        }
        public int GetUndeliveredCount()
        {
            List<Model.Order> Products = new List<Model.Order>();
            string query = "EXEC GetUndeliverCount;";
            using (SqlCommand oCmd = new SqlCommand(query, Connect()))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    Disconnect();
                    return IntParse.Parse(oReader["Undelivered"].ToString(), 0);
                }
            }
        }
        public RequestResult DeliverOrder(int orderId, int quantity)
        {
            try
            {
                string query = $"EXEC DeliverOrder @Id = {orderId}, @Quantity = {quantity};";
                using (SqlCommand myCommand = new SqlCommand(query, Connect()))
                {
                    myCommand.ExecuteNonQuery();
                    Disconnect();
                    return new RequestResult("Order successfully delivered", true);
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                return new RequestResult("Encounter an error updated order, please contact admin", false);
            }
        }
    }
}
