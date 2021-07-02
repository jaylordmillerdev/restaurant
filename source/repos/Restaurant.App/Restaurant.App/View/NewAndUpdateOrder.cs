using FontAwesome.Sharp;
using Restaurant.App.Service;
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
        List<string> Customers;
        ProductModel Product;
        Main MainView;
        public NewAndUpdateOrder(Main mainView, ProductModel product)
        {
            this.MainView = mainView;
            Customers = new CustomerService().GetAllCustomerNameAndID();
            this.Product = product;
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
            foreach (string customer in Customers)
            {
                CustomerCB.Items.Add(customer);
            }
        }
        private void CreateComboboxFilter()
        {
            string columnName = "Customer";
            CustomerCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CustomerCB.AutoCompleteSource = AutoCompleteSource.ListItems;

            CustomerCB.DataSource = ConvertListOfStringToDataTable.Parse(data: Customers, ColumnName: columnName);
            CustomerCB.ValueMember = columnName;
            CustomerCB.DisplayMember = columnName;
        }
        private void Back(object sender, EventArgs e)
        {
            MainView.GoToProductsList();
        }
        private int GetIdFromCustomerCBdata(string customer)
        {
            string[] split = customer.Split('-');
            Console.WriteLine(split[split.Length - 1].Replace("#", "").Trim());
            return int.Parse(split[split.Length - 1].Replace("#", "").Trim());
        }
        private void SaveOrderBTN(object sender, EventArgs e)
        {
            GetIdFromCustomerCBdata(CustomerCB.Text.ToString());
            RequestResult requestStatus = new OrderService().Save(
                    customerId: GetIdFromCustomerCBdata(CustomerCB.Text.ToString()),
                    productId: Product.ProductId,
                    quantity: QuantityTB.Text == String.Empty ? 0 : int.Parse(QuantityTB.Text),
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
        public void ClearFormText()
        {
            QuantityTB.Text = "0";
            ErrorMessageLabel.Visible = false;
        }

        private void CalculateTotalTB(object sender, EventArgs e)
        {
            TotalTB.Text = new OrderTotalModel(
                price: Product.Price,
                quantity: QuantityTB.Text == String.Empty? 0:int.Parse(QuantityTB.Text)
            ).Total.ToString("0.00");
        }
    }
}
