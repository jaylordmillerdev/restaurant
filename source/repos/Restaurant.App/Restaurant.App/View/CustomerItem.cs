using Restaurant.App.Service;
using Restaurant.Business;
using Restaurant.Business.Customer.Model;
using System;
using System.Windows.Forms;
using static Restaurant.App.View.ViewAllCustomer;

namespace Restaurant.App.View
{
    public partial class CustomerItem : Form
    {
        CustomerModel Customer;
        ViewAllCustomer Main;
        public CustomerItem(CustomerModel customer, ViewAllCustomer main)
        {
            this.Customer = customer;
            this.Main = main;
            InitializeComponent();
            CustomerNameLB.Text = $"{Customer.Firstname} {Customer.Lastname}";
        }

        private void DeleteItem(object sender, EventArgs e)
        {
            RequestResult requestStatus = new CustomerService().Delete(id: Customer.Id);
            Main.ShowAllCustomer();
        }

        private void UpdateItem(object sender, EventArgs e)
        {
            Main.UpdateItem(Customer);
        }
    }
}
