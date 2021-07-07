using FontAwesome.Sharp;
using Restaurant.App.Service;
using Restaurant.App.Shared;
using Restaurant.Business;
using Restaurant.Business.Order.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class OrderItem : Form
    {
        private Color _FocusColor = ColorTranslator.FromHtml("#ebfaff");
        private Color _UnfocusColor = Color.White;
        private Order _Order;
        private RequestResult _RequestStatus;
        private ViewAllOrder _Main;
        public OrderItem(Order order, ViewAllOrder main)
        {
            this._Order = order;
            this._Main = main;
            InitializeComponent();
            SetHoverContent();
            SetItemDetails();
            Splitter.Visible = false;
            GenerateIcons();
        }
        private void GenerateIcons()
        {
            DeleteBT.Image = IconChar.Trash.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Red);
            DeliverBT.Image = IconChar.Taxi.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Green);
        }
        private void SetItemDetails()
        {
            CustomerInfoLB.Text = "Customer Name: " + _Order.CustomerFirstname + " " + _Order.CustomerLastname + " / Customer Address: " + _Order.CustomerAddress;
            CustomerInfoLB.Font = CustomFont.Get.BoldFont(8);
            ProductInfoLB.Text = "Product: " + _Order.ProductName + " / " + "Quantity: " + _Order.Quantity + " / Price: " + _Order.ProductPrice.ToString("0.00") + " / Total: " + (_Order.Quantity * _Order.ProductPrice).ToString("0.00");
            ProductInfoLB.Font = CustomFont.Get.LightFont(8);
            DeliverBT.Visible = _Order.IsDelivered == 1 ? false : true;
            DeleteBT.Visible = _Order.IsDelivered == 1 ? false : true;
            if (_Order.IsDelivered == 1)
            {
                _FocusColor = ColorTranslator.FromHtml("#99f0b1");
                _UnfocusColor = ColorTranslator.FromHtml("#b5ffc9");
            }
            else
            {
                _FocusColor = ColorTranslator.FromHtml("#e0535a");
                _UnfocusColor = ColorTranslator.FromHtml("#ff9ea3");
            }
            MainPanel.BackColor = _UnfocusColor;
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
                {"Order By", _Order.CustomerFirstname+" "+_Order.CustomerFirstname },
                {"Product Name", _Order.ProductName },
                {"Product Price", _Order.ProductPrice.ToString("0.00") },
                {"Quantity Order", _Order.Quantity.ToString() },
                {"Total", (_Order.Quantity*_Order.ProductPrice).ToString() },
            };
            new ShowPopUp(
                title: $"Order#-{_Order.Id}",
                messageData: data);
        }
        private void FocusItem(bool isFocus)
        {
            MainPanel.BackColor = isFocus ? _FocusColor : _UnfocusColor;
            Splitter.Visible = isFocus;
        }

        private void MainPanelEnter(object sender, EventArgs e)
        {
            FocusItem(true);
        }

        private void MainPanelLeave(object sender, EventArgs e)
        {
            FocusItem(false);
        }

        private void DeliverItem(object sender, EventArgs e)
        {
            _RequestStatus = new OrderService().DeliverOrder(
                        orderId: _Order.Id,
                        quantity: _Order.Quantity);
            _Main.ShowAllOrder(null, null);
        }

        private void Cancel(object sender, EventArgs e)
        {
            _RequestStatus = new OrderService().Delete(id: _Order.Id);
            _Main.ShowAllOrder(null, null);
        }

        private void ShowDetails(object sender, MouseEventArgs e)
        {
            ShowDetails();
        }
    }
}
