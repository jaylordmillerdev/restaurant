using Restaurant.Business.Order.Model;
using Restaurant.Business.Order.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Restaurant.Business.Order.Service
{
    public class OrderService : IDatabaseConnection
    {
        SqlConnection Connection;
        public OrderService(String connectionString)
        {
            Connect(connectionString);
        }
        public void Connect(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }
        public RequestResult Save(NewOrderModel order)
        {
            RequestResult validate = NewOrderDataValidation.isDataValid(order);
            if (!validate.isSuccess)
            {
                return validate;
            }
            try
            {
                string query = "EXEC StoreOrder @CustomerId = "+ order.CustomerId +", @ProductId = "+ order.ProductId +", @Quantity = "+ order.Quantity + ", @IsDelivered = "+ order.IsDelivered + ";";
                using (SqlCommand myCommand = new SqlCommand(query, Connection))
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
        public RequestResult Update(NewOrderModel order)
        {
            RequestResult validate = NewOrderDataValidation.isDataValid(order);
            if (!validate.isSuccess)
            {
                return validate;
            }
            try
            {
                string query = "EXEC UpdateOrder @CustomerId = "+ order.CustomerId +", @ProductId = "+ order.ProductId +", @Quantity = "+ order.Quantity +", @IsDelivered = "+ order.IsDelivered +", @Id = "+ order.Id +";";
                using (SqlCommand myCommand = new SqlCommand(query, Connection))
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
                using (SqlCommand myCommand = new SqlCommand(query, Connection))
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
        public List<OrderModel> FetchAll()
        {
            List<OrderModel> Products = new List<OrderModel>();
            string query = "EXEC FetchAllOrder;";
            using (SqlCommand oCmd = new SqlCommand(query, Connection))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Products.Add(new OrderModel(
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
        public List<OrderModel> FetchAllByDateFilter(string start, string end)
        {
            List<OrderModel> Products = new List<OrderModel>();
            string query = "EXEC FilterByDate @StartDate = '" + start + "', @EndDate = '" + end + "';";
            using (SqlCommand oCmd = new SqlCommand(query, Connection))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Products.Add(new OrderModel(
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
            List<OrderModel> Products = new List<OrderModel>();
            string query = "EXEC GetUndeliverCount;";
            using (SqlCommand oCmd = new SqlCommand(query, Connection))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    return int.Parse(oReader["Undelivered"].ToString());
                }
            }
        }
        public RequestResult DeliverOrder(int orderId, int quantity)
        {
            try
            {
                string query = "EXEC DeliverOrder @Id = "+ orderId + ", @Quantity = " + quantity + ";";
                using (SqlCommand myCommand = new SqlCommand(query, Connection))
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
        public void Disconnect()
        {
            Connection.Close();
        }
    }
}
