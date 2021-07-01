using FontAwesome.Sharp;
using Restaurant.App.Service;
using Restaurant.Business;
using Restaurant.Business.Product.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class NewAndUpdateProduct : Form
    {
        ProductModel Product;
        Main MainView;
        public NewAndUpdateProduct(Main mainView, ProductModel product)
        {
            this.MainView = mainView;
            this.Product = product;
            InitializeComponent();
            ErrorMessageLabel.Visible = false;
            if (Product != null)
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
        private void SaveProduct(object sender, EventArgs e)
        {
            RequestResult requestStatus;
            if (Product == null)
            {
                requestStatus = new ProductService().Save(
                        name: NameTB.Text,
                        quantity: QuantityTB.Text == String.Empty? 0:int.Parse(QuantityTB.Text),
                        price: QuantityTB.Text == String.Empty ? 0:float.Parse(PriceTB.Text));
            }
            else
            {
                requestStatus = new ProductService().Update(
                        id: Product.ProductId,
                        name: NameTB.Text,
                        quantity: int.Parse(QuantityTB.Text),
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
        public void ClearFormText()
        {
            NameTB.Text = String.Empty;
            QuantityTB.Text = "0";
            PriceTB.Text = "0.0";
            ErrorMessageLabel.Visible = false;
        }
        private void ShowCustomerData()
        {
            NameTB.Text = Product.Name;
            QuantityTB.Text = Product.Quantity.ToString();
            PriceTB.Text = Product.Price.ToString();
        }

        private void GoBack(object sender, EventArgs e)
        {
            MainView.GoToProductsList();
        }
    }
}
