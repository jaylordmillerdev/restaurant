using Restaurant.App.Service;
using Restaurant.Business;
using Restaurant.Business.Customer.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App
{
    public partial class NewCustomer : Form
    {
        CustomerModel Customer;
        Main Main;
        public NewCustomer(Main main, CustomerModel customer)
        {
            this.Main = main;
            this.Customer = customer;
            InitializeComponent();
            ErrorMessageLabel.Visible = false;
            if (customer != null)
            {
                ShowCustomerData();
            }
            SaveBTN.Text = customer != null ? "Update" : "Save";
        }

        private void ShowCustomerData()
        {
            FirstnameTB.Text = Customer.Firstname;
            LastnameTB.Text = Customer.Lastname;
            AddressTB.Text = Customer.Address;
        }

        public void ClearFormText()
        {
            FirstnameTB.Text = String.Empty;
            LastnameTB.Text = String.Empty;
            AddressTB.Text = String.Empty;
            ErrorMessageLabel.Visible = false;
        }
        private void SaveCustomerBTN(object sender, EventArgs e)
        {
            RequestResult requestStatus;
            if (Customer == null)
            {
                requestStatus = new CustomerService().Save(
                        firstname: FirstnameTB.Text,
                        lastname: LastnameTB.Text,
                        address: AddressTB.Text);
            }
            else
            {
                requestStatus = new CustomerService().Update(
                        id: Customer.Id,
                        firstname: FirstnameTB.Text,
                        lastname: LastnameTB.Text,
                        address: AddressTB.Text);
            }

            if (requestStatus.isSuccess)
            {
                ClearFormText();
                this.ErrorMessageLabel.ForeColor = Color.Green;
            }
            else
            {
                this.ErrorMessageLabel.ForeColor = Color.Red;
            }
            ErrorMessageLabel.Text = requestStatus.message;
            ErrorMessageLabel.Visible = true;
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void NewCustomerLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GoBack(object sender, EventArgs e)
        {
            Main.GoToCustomersList();
        }
    }
}
