using FontAwesome.Sharp;
using Restaurant.App.Service;
using Restaurant.Business;
using Restaurant.Business.Order.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class OrderItem : Form
    {
        Color FocusColor = ColorTranslator.FromHtml("#ebfaff");
        Color UnfocusColor = Color.White;
        OrderModel Order;
        RequestResult requestStatus;
        ViewAllOrder Main;
        public OrderItem(OrderModel order, ViewAllOrder main)
        {
            this.Order = order;
            this.Main = main;
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
            CustomerInfoLB.Text = "Customer Name: " + Order.CustomerFirstname + " " + Order.CustomerLastname + " / Customer Address: " + Order.CustomerAddress;
            CustomerInfoLB.Font = new UseCustomFont().BoldFont(8);
            ProductInfoLB.Text = "Product: " + Order.ProductName + " / " + "Quantity: " + Order.Quantity + " / Price: " + Order.ProductPrice.ToString("0.00") + " / Total: " + (Order.Quantity * Order.ProductPrice).ToString("0.00");
            ProductInfoLB.Font = new UseCustomFont().LightFont(8);
            DeliverBT.Visible = Order.IsDelivered == 1 ? false : true;
            DeleteBT.Visible = Order.IsDelivered == 1 ? false : true;
            if (Order.IsDelivered == 1)
            {
                FocusColor = ColorTranslator.FromHtml("#99f0b1");
                UnfocusColor = ColorTranslator.FromHtml("#b5ffc9");
            }
            else
            {
                FocusColor = ColorTranslator.FromHtml("#e0535a");
                UnfocusColor = ColorTranslator.FromHtml("#ff9ea3");
            }
            MainPanel.BackColor = UnfocusColor;
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
            MainPanel.BackColor = isFocus ? FocusColor : UnfocusColor;
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
            requestStatus = new OrderService().DeliverOrder(
                        orderId: Order.Id,
                        quantity: Order.Quantity);
            Main.ShowAllOrder(null, null);
        }

        private void Cancel(object sender, EventArgs e)
        {
            requestStatus = new OrderService().Delete(id: Order.Id);
            Main.ShowAllOrder(null, null);
        }
    }
}
