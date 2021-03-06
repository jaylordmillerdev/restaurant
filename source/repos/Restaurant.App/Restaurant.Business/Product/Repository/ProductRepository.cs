using Restaurant.Business.Product.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Restaurant.Business.Product.Repository
{
    public class ProductRepository : DatabaseConnection
    {
        public RequestResult Save(Model.Product product)
        {
            RequestResult validate = ProductDataValidation.isDataValid(product);
            if (!validate.isSuccess)
            {
                return validate;
            }
            try
            {
                string query = $"EXEC StoreProduct @Name = '{product.Name}', @Quantity = {product.Quantity}, @Price = {product.Price}";
                using (SqlCommand myCommand = new SqlCommand(query, Connect()))
                {
                    myCommand.ExecuteNonQuery();
                    Disconnect();
                    return new RequestResult("Product successfully save", true);
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                return new RequestResult("Encounter an error saving product, please contact admin", false);
            }
        }
        public RequestResult Update(Model.Product product)
        {
            RequestResult validate = ProductDataValidation.isDataValid(product);
            if (!validate.isSuccess)
            {
                return validate;
            }
            try
            {
                string query = $"EXEC UpdateProduct @Name = '{product.Name}', @Quantity = {product.Quantity}, @Price = {product.Price}, @Id = {product.ProductId}";
                using (SqlCommand myCommand = new SqlCommand(query, Connect()))
                {
                    myCommand.ExecuteNonQuery();
                    Disconnect();
                    return new RequestResult("Product successfully updated", true);
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                return new RequestResult("Encounter an error updated product, please contact admin", false);
            }
        }
        public RequestResult Delete(int id)
        {
            try
            {
                string query = $"EXEC DeleteProduct @id = {id}";
                using (SqlCommand myCommand = new SqlCommand(query, Connect()))
                {
                    myCommand.ExecuteNonQuery();
                    Disconnect();
                    return new RequestResult("Product successfully deleted", true);
                }
            }
            catch (Exception ex)
            {
                Disconnect();
                return new RequestResult("Encounter an error deleting product, please contact admin", false);
            }
        }
        public List<Model.Product> FetchAll()
        {
            List<Model.Product> Product = new List<Model.Product>();
            string query = "EXEC FetchAllProduct;";
            using (SqlCommand oCmd = new SqlCommand(query, Connect()))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Product.Add(new Model.Product(
                            id: Int32.Parse(oReader["ProductID"].ToString()),
                            name: oReader["Name"].ToString(),
                            price: float.Parse(oReader["Price"].ToString()),
                            quantity: Int32.Parse(oReader["Quantity"].ToString()),
                            dateCreated: Convert.ToDateTime(oReader["DateCreated"].ToString())
                        ));
                    }
                }
            }
            Disconnect();
            return Product;
        }
        public List<Model.Product> Filter(string filter)
        {
            List<Model.Product> Product = new List<Model.Product>();
            string query = "EXEC FilterProductByName @ProductName = '" + filter + "';";
            using (SqlCommand oCmd = new SqlCommand(query, Connect()))
            {
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        Product.Add(new Model.Product(
                            id: Int32.Parse(oReader["ProductID"].ToString()),
                            name: oReader["Name"].ToString(),
                            price: float.Parse(oReader["Price"].ToString()),
                            quantity: Int32.Parse(oReader["Quantity"].ToString()),
                            dateCreated: Convert.ToDateTime(oReader["DateCreated"].ToString())
                        ));
                    }
                }
            }
            Disconnect();
            return Product;
        }
    }
}
