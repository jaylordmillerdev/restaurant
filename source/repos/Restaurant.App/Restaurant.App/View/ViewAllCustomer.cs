using FontAwesome.Sharp;
using Restaurant.App.Service;
using Restaurant.Business.Customer.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class ViewAllCustomer : Form
    {
        List<CustomerModel> Customers;
        Main MainView;
        public ViewAllCustomer(Main MainView)
        {
            this.MainView = MainView;
            InitializeComponent();
            ShowAllCustomer();
            GenerateIcons();
        }
        private void GenerateIcons()
        {
            AddCustomerBT.Image = IconChar.PlusCircle.ToBitmap(iconFont: IconFont.Auto, size: 30, color: Color.Green);
        }
        public void ShowAllCustomer()
        {
            if (Customers != null)
            {
                Customers.Clear();
                layout.Controls.Clear();
            }
            FetchCustomer();
            foreach (CustomerModel customer in Customers)
            {
                layout.Controls.Add(new CustomerItem(customer, this).MainPanel);
            }
        }

        public void UpdateItem(CustomerModel customer)
        {
            MainView.GoToUpdateCustomerPage(customer);
        }

        private void NewCustomerBT(object sender, EventArgs e)
        {
            MainView.GoToNewCustomerPage();
        }
        private void FetchCustomer() { Customers = new CustomerService().GetAllCustomer(); }
    }
}
