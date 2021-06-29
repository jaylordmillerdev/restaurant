using Restaurant.App.Service;
using Restaurant.Business.Customer.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class ViewAllCustomer : Form
    {
        List<CustomerModel> Customers;
        Main mainView;
        public ViewAllCustomer(Main mainView)
        {
            this.mainView = mainView;
            InitializeComponent();
            ShowAllCustomer();
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
                layout.Controls.Add(new CustomerItem(customer, this).panel);
            }
        }

        public void UpdateItem(CustomerModel customer)
        {
            mainView.GoToUpdateCustomerPage(customer);
        }

        private void NewCustomerBT(object sender, EventArgs e)
        {
            mainView.GoToNewCustomerPage();
        }
        private void FetchCustomer() { Customers = new CustomerService().GetAllCustomer(); }
    }
}
