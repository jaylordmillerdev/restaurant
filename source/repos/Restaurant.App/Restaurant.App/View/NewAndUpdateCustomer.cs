using FontAwesome.Sharp;
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
        private Customer _Customer;
        private Main _MainView;
        public NewCustomer(Main main, Customer customer)
        {
            this._MainView = main;
            this._Customer = customer;
            InitializeComponent();
            ErrorMessageLabel.Visible = false;
            if (customer != null)
            {
                ShowCustomerData();
            }
            SaveBTN.Text = customer != null ? "Update" : "Save";
            GenerateIcons();
        }
        private void GenerateIcons()
        {
            BackBT.Image = IconChar.Backspace.ToBitmap(iconFont: IconFont.Auto, size: 40, color: CONFIG.Instance.MAIN_COLOR);
        }
        private void ShowCustomerData()
        {
            FirstnameTB.Text = _Customer.Firstname;
            LastnameTB.Text = _Customer.Lastname;
            AddressTB.Text = _Customer.Address;
        }

        public void ClearFormText()
        {
            FirstnameTB.Text = string.Empty;
            LastnameTB.Text = string.Empty;
            AddressTB.Text = string.Empty;
            ErrorMessageLabel.Visible = false;
        }
        private RequestResult ValidateInputField()
        {
            if (FirstnameTB.Text == string.Empty)
            {
                return new RequestResult("Firstname is required", false);
            }
            if (LastnameTB.Text == string.Empty)
            {
                return new RequestResult("Lastname is required", false);
            }
            if (AddressTB.Text == string.Empty)
            {
                return new RequestResult("Address is required", false);
            }
            return new RequestResult("Inputs is valid", true);
        }
        private void SaveCustomerBTN(object sender, EventArgs e)
        {
            RequestResult validate = ValidateInputField();
            if (!validate.isSuccess)
            {
                ErrorMessageLabel.Visible = true;
                this.ErrorMessageLabel.ForeColor = Color.Red;
                ErrorMessageLabel.Text = validate.message;
            }
            else
            {
                RequestResult requestStatus;
                if (_Customer == null)
                {
                    requestStatus = new CustomerService().Save(
                            firstname: FirstnameTB.Text,
                            lastname: LastnameTB.Text,
                            address: AddressTB.Text);
                }
                else
                {
                    requestStatus = new CustomerService().Update(
                            id: _Customer.Id,
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
        }
        private void GoBack(object sender, EventArgs e)
        {
            _MainView.GoToCustomersList();
        }
    }
}
