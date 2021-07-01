using Restaurant.App.Service;
using Restaurant.Business;
using Restaurant.Business.Product.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Restaurant.App.View
{
    public partial class ProductItem : Form
    {
        Color FocusColor = ColorTranslator.FromHtml("#ebfaff");
        Color UnfocusColor = Color.White;
        ProductModel Product;
        ViewAllProduct Main;
        public ProductItem(ProductModel product, ViewAllProduct main)
        {
            this.Product = product;
            this.Main = main;
            InitializeComponent();
            SetHoverContent();
            ProductNameLB.Text = product.Name+ " (₱" + product.Price.ToString("0.00")+")";
            ProductNameLB.Font = new UseCustomFont().BoldFont(8);
            QuantityLeftLB.Text = "Quantity Left ("+ product.Quantity+")";
            QuantityLeftLB.Font = new UseCustomFont().LightFont(8);
            Splitter.Visible = false;
            MainPanel.BackColor = Color.White;
            GenerateIcons();
        }
        private void GenerateIcons()
        {
            DeleteBT.Image = IconChar.Trash.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Red);
            EditBT.Image = IconChar.Edit.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Gray);
            OrderNowBT.Image = IconChar.CartPlus.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Green);
        }
        private void SetHoverContent()
        {
            var getAllPanelComponents = MainPanel.Controls;
            foreach (Control component in getAllPanelComponents)
            {
                component.MouseEnter += (sender, eventArgs) =>
                {
                    FocusItem(true);
                };
                component.MouseLeave += (sender, eventArgs) =>
                {
                    FocusItem(false);
                };
            }
        }

        private void FocusItem(bool isFocus)
        {
            MainPanel.BackColor = isFocus? FocusColor:UnfocusColor;
            Splitter.Visible = isFocus;
        }

        private void DeleteItem(object sender, EventArgs e)
        {
            RequestResult requestStatus = new ProductService().Delete(id: Product.ProductId);
            Main.ShowAllProduct();
        }

        private void UpdateItem(object sender, EventArgs e)
        {
            Main.UpdateItem(Product);
        }
        private void MainPanelEnter(object sender, EventArgs e)
        {
            FocusItem(true);
        }
        private void MainPanelLeave(object sender, EventArgs e)
        {
            FocusItem(false);
        }

        private void OrderItem(object sender, EventArgs e)
        {
            Main.OrderItem(Product);
        }
    }
}
