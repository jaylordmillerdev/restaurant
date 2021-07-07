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
        private List<Customer> _Customers;
        private Main _MainView;
        public ViewAllCustomer(Main MainView)
        {
            this._MainView = MainView;
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
            if (_Customers != null)
            {
                _Customers.Clear();
                layout.Controls.Clear();
            }
            FetchCustomer();
            foreach (Customer customer in _Customers)
            {
                layout.Controls.Add(new CustomerItem(customer, this).MainPanel);
            }
        }

        public void UpdateItem(Customer customer)
        {
            _MainView.GoToUpdateCustomerPage(customer);
        }

        private void NewCustomerBT(object sender, EventArgs e)
        {
            _MainView.GoToNewCustomerPage();
        }
        private void FetchCustomer() { _Customers = new CustomerService().GetAllCustomer(); }
    }
}
