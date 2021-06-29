using Restaurant.App.View;
using Restaurant.Business.Customer.Model;
using System;
using System.Windows.Forms;

namespace Restaurant.App
{
    public partial class Main : Form
    {
        ViewAllCustomer ShowAllCustomer;
        public Main()
        {
            InitializeComponent();
        }
        private void CustomerBTNClick(object sender, EventArgs e)
        {
            GoToCustomersList();
        }
        private void ProductBTNClick(object sender, EventArgs e)
        {
        }
        private void OrderBTNClick(object sender, EventArgs e)
        {
        }
        public void GoToNewCustomerPage()
        {
            FunctionsView.Controls.Clear();
            NewCustomer newCustomerView = new NewCustomer(this, null);
            FunctionsView.Controls.Add(newCustomerView.CustomerLayoutView);
        }
        public void GoToUpdateCustomerPage(CustomerModel customer)
        {
            FunctionsView.Controls.Clear();
            NewCustomer newCustomerView = new NewCustomer(this, customer);
            FunctionsView.Controls.Add(newCustomerView.CustomerLayoutView);
        }
        public void GoToCustomersList()
        {
            ShowAllCustomer = new ViewAllCustomer(this);
            FunctionsView.Controls.Clear();
            FunctionsView.Controls.Add(ShowAllCustomer.CustomerViewLayout);
        }
    }
}
