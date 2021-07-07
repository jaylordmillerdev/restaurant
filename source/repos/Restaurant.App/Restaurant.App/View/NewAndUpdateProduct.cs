using FontAwesome.Sharp;
using Restaurant.App.Service;
using Restaurant.App.Shared;
using Restaurant.Business;
using Restaurant.Business.Product.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class NewAndUpdateProduct : Form
    {
        private Product _Product;
        private Main _MainView;
        public NewAndUpdateProduct(Main mainView, Product product)
        {
            this._MainView = mainView;
            this._Product = product;
            InitializeComponent();
            ErrorMessageLabel.Visible = false;
            if (_Product != null)
            {
                ShowCustomerData();
            }
            SaveBTN.Text = product != null ? "Update" : "Save";
            GenerateIcons();
        }
        private void GenerateIcons()
        {
            BackBT.Image = IconChar.Backspace.ToBitmap(iconFont: IconFont.Auto, size: 40, color: CONFIG.Instance.MAIN_COLOR);
        }
        private RequestResult ValidateInputField()
        {
            if (NameTB.Text == string.Empty)
            {
                return new RequestResult("Name is required", false);
            }
            if (QuantityTB.Text == string.Empty)
            {
                return new RequestResult("Quantity is required", false);
            }
            if (PriceTB.Text == string.Empty)
            {
                return new RequestResult("Price is required", false);
            }
            return new RequestResult("Inputs is valid", true);
        }
        private void SaveProduct(object sender, EventArgs e)
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
                if (_Product == null)
                {
                    requestStatus = new ProductService().Save(
                            name: NameTB.Text,
                            quantity: QuantityTB.Text == string.Empty ? 0 : IntParse.Parse(QuantityTB.Text, 0),
                            price: QuantityTB.Text == string.Empty ? 0 : float.Parse(PriceTB.Text));
                }
                else
                {
                    requestStatus = new ProductService().Update(
                            id: _Product.ProductId,
                            name: NameTB.Text,
                            quantity: IntParse.Parse(QuantityTB.Text, 0),
                            price: float.Parse(PriceTB.Text)
                        );
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
        public void ClearFormText()
        {
            NameTB.Text = string.Empty;
            QuantityTB.Text = "0";
            PriceTB.Text = "0.0";
            ErrorMessageLabel.Visible = false;
        }
        private void ShowCustomerData()
        {
            NameTB.Text = _Product.Name;
            QuantityTB.Text = _Product.Quantity.ToString();
            PriceTB.Text = _Product.Price.ToString();
        }
        private void GoBack(object sender, EventArgs e)
        {
            _MainView.GoToProductsList();
        }

        private void ValidateQuantity(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void ValidatePrice(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
