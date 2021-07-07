using FontAwesome.Sharp;
using Restaurant.App.Service;
using Restaurant.App.Shared;
using Restaurant.Business;
using Restaurant.Business.Order.Model;
using Restaurant.Business.Product.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class NewAndUpdateOrder : Form
    {
        private List<string> _Customers;
        private Product _Product;
        private Main _MainView;
        public NewAndUpdateOrder(Main mainView, Product product)
        {
            this._MainView = mainView;
            _Customers = new CustomerService().GetAllCustomerNameAndID();
            this._Product = product;
            InitializeComponent();
            ShowAllCustomers();
            CreateComboboxFilter();
            ErrorMessageLabel.Visible = false;
            GenerateIcons();
        }
        private void GenerateIcons()
        {
            BackBT.Image = IconChar.Backspace.ToBitmap(iconFont: IconFont.Auto, size: 40, color: CONFIG.Instance.MAIN_COLOR);
        }
        private void ShowAllCustomers()
        {
            CustomerCB.Items.AddRange(_Customers.ToArray());
        }
        private void CreateComboboxFilter()
        {
            string columnName = "Customer";
            CustomerCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CustomerCB.AutoCompleteSource = AutoCompleteSource.ListItems;

            CustomerCB.DataSource = ConvertListOfStringToDataTable.Parse(data: _Customers, ColumnName: columnName);
            CustomerCB.ValueMember = columnName;
            CustomerCB.DisplayMember = columnName;
        }
        private void Back(object sender, EventArgs e)
        {
            _MainView.GoToProductsList();
        }
        private int GetIdFromCustomerCBdata(string customer)
        {
            string[] split = customer.Split('-');
            return IntParse.Parse(split[split.Length - 1].Replace("#", "").Trim(), 0);
        }
        private RequestResult ValidateInputField()
        {
            if (CustomerCB.Text.ToString() == string.Empty)
            {
                return new RequestResult("Customer is required", false);
            }
            if (QuantityTB.Text == string.Empty)
            {
                return new RequestResult("Quantity is required", false);
            }
            return new RequestResult("Inputs is valid", true);
        }
        private void SaveOrderBTN(object sender, EventArgs e)
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
                GetIdFromCustomerCBdata(CustomerCB.Text.ToString());
                RequestResult requestStatus = new OrderService().Save(
                        customerId: GetIdFromCustomerCBdata(CustomerCB.Text.ToString()),
                        productId: _Product.ProductId,
                        quantity: QuantityTB.Text == string.Empty ? 0 : IntParse.Parse(QuantityTB.Text, 0),
                        isDelivered: 0);

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
        public void ClearFormText()
        {
            QuantityTB.Text = "0";
            ErrorMessageLabel.Visible = false;
        }

        private void CalculateTotalTB(object sender, EventArgs e)
        {
            TotalTB.Text = new OrderTotal(
                price: _Product.Price,
                quantity: QuantityTB.Text == String.Empty? 0: IntParse.Parse(QuantityTB.Text, 0)
            ).Total.ToString("0.00");
        }

        private void ValidateNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
