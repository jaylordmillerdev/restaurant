using FontAwesome.Sharp;
using Restaurant.App.Service;
using Restaurant.Business.Product.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class ViewAllProduct : Form
    {
        private List<Product> _Products;
        private Main _MainView;
        public ViewAllProduct(Main main)
        {
            _MainView = main;
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
            _MainView.GoToNewProductPage();
        }
        public void ShowAllProduct()
        {
            ClearProducList();
            FetchProduct();
            AddFetchProduct();
        }
        private void ClearProducList()
        {
            if (_Products != null)
            {
                _Products.Clear();
                layout.Controls.Clear();
            }
        }
        private void AddFetchProduct()
        {
            foreach (Product product in _Products)
            {
                layout.Controls.Add(new ProductItem(product, this).MainPanel);
            }
        }
        public void UpdateItem(Product product)
        {
            _MainView.GoToUpdateProductPage(product);
        }

        public void OrderItem(Product product)
        {
            _MainView.GoToNewOrderPage(product);
        }

        private void FetchProduct() { _Products = new ProductService().GetAllProduct(); }

        private void FilterProduct(object sender, EventArgs e)
        {
            ClearProducList();
            _Products = new ProductService().FilterProduct(FilterProductNameTB.Text);
            AddFetchProduct();
        }
    }
}
