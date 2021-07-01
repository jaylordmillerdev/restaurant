using FontAwesome.Sharp;
using Restaurant.App.Service;
using Restaurant.Business.Product.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class ViewAllProduct : Form
    {
        List<ProductModel> Products;
        Main MainView;
        public ViewAllProduct(Main main)
        {
            MainView = main;
            InitializeComponent();
            ShowAllProduct();
            GenerateIcons();
        }
        private void GenerateIcons()
        {
            SearchIcon.Image = IconChar.Search.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Black);
            AddProductBT.Image = IconChar.PlusCircle.ToBitmap(iconFont: IconFont.Auto, size: 30, color: Color.Green);
        }
        private void NewProductBTN(object sender, EventArgs e)
        {
            MainView.GoToNewProductPage();
        }
        public void ShowAllProduct()
        {
            ClearProducList();
            FetchProduct();
            AddFetchProduct();
        }
        private void ClearProducList()
        {
            if (Products != null)
            {
                Products.Clear();
                layout.Controls.Clear();
            }
        }
        private void AddFetchProduct()
        {
            foreach (ProductModel product in Products)
            {
                layout.Controls.Add(new ProductItem(product, this).MainPanel);
            }
        }
        public void UpdateItem(ProductModel product)
        {
            MainView.GoToUpdateProductPage(product);
        }

        public void OrderItem(ProductModel product)
        {
            MainView.GoToNewOrderPage(product);
        }

        private void FetchProduct() { Products = new ProductService().GetAllProduct(); }

        private void FilterProduct(object sender, EventArgs e)
        {
            ClearProducList();
            Products = new ProductService().FilterProduct(FilterProductNameTB.Text);
            AddFetchProduct();
        }
    }
}
