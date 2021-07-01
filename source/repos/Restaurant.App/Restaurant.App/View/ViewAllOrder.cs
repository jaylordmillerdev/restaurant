using FontAwesome.Sharp;
using Restaurant.App.Service;
using Restaurant.Business.Order.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class ViewAllOrder : Form
    {
        List<OrderModel> Orders;
        public ViewAllOrder()
        {
            InitializeComponent();
            ShowAllOrder(null, null);
            GenerateIcons();
        }
        private void GenerateIcons()
        {
            ExitFilter.Image = IconChar.Times.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Black);
            RefreshBT.Image = IconChar.Redo.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Black);
        }
        public void ShowAllOrder(string startDate, string endDate)
        {
            if (Orders != null)
            {
                Orders.Clear();
                layout.Controls.Clear();
            }
            if (startDate == null && endDate == null)
            {
                FetchOrder();
            }
            else
            {
                FetchOrderByDateFilter(startDate, endDate);
            }
            foreach (OrderModel order in Orders)
            {
                layout.Controls.Add(new OrderItem(order, this).MainPanel);
            }
        }
        private void FetchOrder() { Orders = new OrderService().GetAllOrder(); }
        private void FetchOrderByDateFilter(string startDate, string endDate) { Orders = new OrderService().GetAllOrderFromDateFilter(startDate, endDate); }

        private void StartDateChangeValue(object sender, System.EventArgs e)
        {
            ShowAllOrder(
                FilterStartDate.Value.ToString("yyyy-MM-dd"),
                FilterEndDate.Value.ToString("yyyy-MM-dd"));
        }

        private void RefetchAllData(object sender, EventArgs e)
        {
            ShowAllOrder(null, null);
        }

        private void EndDateChangeValue(object sender, EventArgs e)
        {
            ShowAllOrder(
                FilterStartDate.Value.ToString("yyyy-MM-dd"),
                FilterEndDate.Value.ToString("yyyy-MM-dd"));
        }

        private void Refresh(object sender, EventArgs e)
        {
            ShowAllOrder(
                FilterStartDate.Value.ToString("yyyy-MM-dd"),
                FilterEndDate.Value.ToString("yyyy-MM-dd"));
        }
    }
}
