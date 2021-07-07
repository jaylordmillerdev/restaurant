using Restaurant.App.Service;
using Restaurant.Business;
using Restaurant.Business.Product.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Restaurant.App.Shared;
using System.Collections.Generic;

namespace Restaurant.App.View
{
    public partial class ProductItem : Form
    {
        private Color _FocusColor = ColorTranslator.FromHtml("#ebfaff");
        private Color _UnfocusColor = Color.White;
        private Product _Product;
        private ViewAllProduct _Main;
        public ProductItem(Product product, ViewAllProduct main)
        {
            this._Product = product;
            this._Main = main;
            InitializeComponent();
            SetHoverContent();
            ProductNameLB.Text = product.Name+ " (₱" + product.Price.ToString("0.00")+")";
            ProductNameLB.Font = CustomFont.Get.BoldFont(8);
            QuantityLeftLB.Text = "Quantity Left ("+ product.Quantity+")";
            QuantityLeftLB.Font = CustomFont.Get.LightFont(8);
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
                component.MouseDown += (sender, eventArgs) =>
                {
                    ShowDetails();
                };
            }
        }
        private void ShowDetails()
        {
            Dictionary<string, string> data = new Dictionary<string, string>(){
                {"Product Name", _Product.Name },
                {"Price", _Product.Price.ToString("0.00") },
                {"Quantity Left", _Product.Quantity.ToString() }
            };
            new ShowPopUp(
                title: $"Product Id#-{_Product.ProductId}",
                messageData: data);
        }
        private void FocusItem(bool isFocus)
        {
            MainPanel.BackColor = isFocus? _FocusColor : _UnfocusColor;
            Splitter.Visible = isFocus;
        }

        private void DeleteItem(object sender, EventArgs e)
        {
            RequestResult requestStatus = new ProductService().Delete(id: _Product.ProductId);
            _Main.ShowAllProduct();
        }

        private void UpdateItem(object sender, EventArgs e)
        {
            _Main.UpdateItem(_Product);
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
            _Main.OrderItem(_Product);
        }

        private void ShowDetails(object sender, MouseEventArgs e)
        {
            ShowDetails();
        }
    }
}
