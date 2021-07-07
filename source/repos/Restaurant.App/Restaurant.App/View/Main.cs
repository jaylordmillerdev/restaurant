using Restaurant.App.View;
using Restaurant.Business.Customer.Model;
using Restaurant.Business.Product.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Restaurant.App.Enum.PageTracker;

namespace Restaurant.App
{
    public partial class Main : Form
    {
        private ViewAllCustomer _ShowAllCustomer;
        private ViewAllProduct _ShowAllProduct;
        private ViewAllOrder _ShowAllOrder;
        public Main()
        {
            InitializeComponent();
            SetFont();
            SetOnClickControls(CustomerMenuBar, Page.Customer);
            SetOnClickControls(ProductMenuBar, Page.Product);
            SetOnClickControls(OrderMenuBar, Page.Order);
            SetMenuBarFocus(Page.Main);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            AppDescriptionLabel.Text = CONFIG.Instance.APP_DESCRIPTION;

            HeaderIcon.Image = Image.FromFile("../../Utilities/assets/image/icon_small_white.png");
            IconLarge.Image = Image.FromFile("../../Utilities/assets/image/icon_large.png");
        }
        private void SetFont()
        {
            CustomerLabel.Font = CustomFont.Get.LightFont(8);
            OrderLabel.Font = CustomFont.Get.LightFont(8);
            ProductLabel.Font = CustomFont.Get.LightFont(8);
            AppTitleLabel.Font = CustomFont.Get.BoldFont(20);
            AppDescriptionLabel.Font = CustomFont.Get.LightFont(8); ;
        }
        private void SetOnClickControls(Control item, Page page)
        {
            var getAllPanelComponents = item.Controls;
            foreach (Control component in getAllPanelComponents)
            {
                component.MouseUp += (sender, eventArgs) =>
                {
                    SetMenuBarClickGoTo(page);
                };
            }
        }
        private void SetMenuBarClickGoTo(Page page)
        {
            switch (page)
            {
                case Page.Customer:
                    GoToCustomersList();
                    break;
                case Page.Product:
                    GoToProductsList();
                    break;
                case Page.Order:
                    GoToOrdersList();
                    break;
                default:
                    GoToCustomersList();
                    break;
            }
        }
        private void SetMenuBarFocus(Page page)
        {

            CustomerSplitter.Visible = Page.Customer == page ? true : false;
            ProductSplitter.Visible = Page.Product == page ? true : false;
            OrderSplitter.Visible = Page.Order == page ? true : false;

            CustomerLabel.Font = Page.Customer == page ? CustomFont.Get.BoldFont(8) : CustomFont.Get.LightFont(8);
            ProductLabel.Font = Page.Product == page ? CustomFont.Get.BoldFont(8) : CustomFont.Get.LightFont(8);
            OrderLabel.Font = Page.Order == page ? CustomFont.Get.BoldFont(8) : CustomFont.Get.LightFont(8);

            CustomerLabel.ForeColor = Page.Customer == page ? Color.White : ColorTranslator.FromHtml("#ABABAB");
            ProductLabel.ForeColor = Page.Product == page ? Color.White : ColorTranslator.FromHtml("#ABABAB");
            OrderLabel.ForeColor = Page.Order == page ? Color.White : ColorTranslator.FromHtml("#ABABAB");

            CustomerMenuBar.BackColor = Page.Customer == page ? CONFIG.Instance.MAIN_COLOR_DARK : Color.Transparent;
            ProductMenuBar.BackColor = Page.Product == page ? CONFIG.Instance.MAIN_COLOR_DARK : Color.Transparent;
            OrderMenuBar.BackColor = Page.Order == page ? CONFIG.Instance.MAIN_COLOR_DARK : Color.Transparent;
        }
        private void CustomerBTNClick(object sender, EventArgs e)
        {
            GoToCustomersList();
        }
        private void ProductBTNClick(object sender, EventArgs e)
        {
            GoToProductsList();
        }
        private void OrderBTNClick(object sender, EventArgs e)
        {
            GoToOrdersList();
        }
        public void GoToNewProductPage()
        {
            FunctionsView.Controls.Clear();
            NewAndUpdateProduct NewProduct = new NewAndUpdateProduct(this, null);
            FunctionsView.Controls.Add(NewProduct.NewProductLayoutView);
        }
        public void GoToUpdateProductPage(Product product)
        {
            FunctionsView.Controls.Clear();
            NewAndUpdateProduct UpdateProduct = new NewAndUpdateProduct(this, product);
            FunctionsView.Controls.Add(UpdateProduct.NewProductLayoutView);
        }
        public void GoToNewCustomerPage()
        {
            FunctionsView.Controls.Clear();
            NewCustomer newCustomerView = new NewCustomer(this, null);
            FunctionsView.Controls.Add(newCustomerView.CustomerLayoutView);
        }
        public void GoToUpdateCustomerPage(Customer customer)
        {
            FunctionsView.Controls.Clear();
            NewCustomer newCustomerView = new NewCustomer(this, customer);
            FunctionsView.Controls.Add(newCustomerView.CustomerLayoutView);
        }
        public void GoToCustomersList()
        {
            FunctionsView.Controls.Clear();
            _ShowAllCustomer = new ViewAllCustomer(this);
            FunctionsView.Controls.Add(_ShowAllCustomer.CustomerViewLayout);
            SetMenuBarFocus(Page.Customer);
        }
        public void GoToProductsList()
        {
            FunctionsView.Controls.Clear();
            _ShowAllProduct = new ViewAllProduct(this);
            FunctionsView.Controls.Add(_ShowAllProduct.ProductViewLayout);
            SetMenuBarFocus(Page.Product);
        }
        public void GoToNewOrderPage(Product product)
        {
            FunctionsView.Controls.Clear();
            NewAndUpdateOrder newOrder = new NewAndUpdateOrder(this, product);
            FunctionsView.Controls.Add(newOrder.OrderLayoutView);
        }
        public void GoToOrdersList()
        {
            FunctionsView.Controls.Clear();
            _ShowAllOrder = new ViewAllOrder();
            FunctionsView.Controls.Add(_ShowAllOrder.OrderViewLayout);
            SetMenuBarFocus(Page.Order);
        }

        private void CustomerBTNClick(object sender, MouseEventArgs e)
        {
            GoToCustomersList();
        }

        private void ProductBTNClick(object sender, MouseEventArgs e)
        {
            GoToProductsList();
        }

        private void OrderBTNClick(object sender, MouseEventArgs e)
        {
            GoToOrdersList();
        }
    }
}
