using Restaurant.App.View;
using Restaurant.Business.Customer.Model;
using Restaurant.Business.Product.Model;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Restaurant.App
{
    public partial class Main : Form
    {
        ViewAllCustomer ShowAllCustomer;
        ViewAllProduct ShowAllProduct;
        ViewAllOrder ShowAllOrder;
        enum Page
        {
            Main,
            Customer,
            Product,
            Order
        }
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
            HeaderIcon.Image = Image.FromFile("../../assets/image/icon_small_white.png");
            IconLarge.Image = Image.FromFile("../../assets/image/icon_large.png");
        }
        private void SetFont()
        {
            CustomerLabel.Font = new UseCustomFont().LightFont(8);
            OrderLabel.Font = new UseCustomFont().LightFont(8);
            ProductLabel.Font = new UseCustomFont().LightFont(8);
            AppTitleLabel.Font = new UseCustomFont().BoldFont(20);
            AppDescriptionLabel.Font = new UseCustomFont().LightFont(8); ;
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
        Bitmap Gradient2D(Rectangle r, Color c1, Color c2, Color c3, Color c4)
        {
            Bitmap bmp = new Bitmap(r.Width, r.Height);

            float delta12R = 1f * (c2.R - c1.R) / r.Height;
            float delta12G = 1f * (c2.G - c1.G) / r.Height;
            float delta12B = 1f * (c2.B - c1.B) / r.Height;
            float delta34R = 1f * (c4.R - c3.R) / r.Height;
            float delta34G = 1f * (c4.G - c3.G) / r.Height;
            float delta34B = 1f * (c4.B - c3.B) / r.Height;
            using (Graphics G = Graphics.FromImage(bmp))
                for (int y = 0; y < r.Height; y++)
                {
                    Color c12 = Color.FromArgb(255, c1.R + (int)(y * delta12R),
                          c1.G + (int)(y * delta12G), c1.B + (int)(y * delta12B));
                    Color c34 = Color.FromArgb(255, c3.R + (int)(y * delta34R),
                          c3.G + (int)(y * delta34G), c3.B + (int)(y * delta34B));
                    using (LinearGradientBrush lgBrush = new LinearGradientBrush(
                          new Rectangle(0, y, r.Width, 1), c12, c34, 0f))
                    { G.FillRectangle(lgBrush, 0, y, r.Width, 1); }
                }
            return bmp;
        }
        private void SetMenuBarFocus(Page page)
        {
            CustomerSplitter.Visible = Page.Customer == page ? true : false;
            ProductSplitter.Visible = Page.Product == page ? true : false;
            OrderSplitter.Visible = Page.Order == page ? true : false;

            CustomerLabel.Font = Page.Customer == page ? new UseCustomFont().BoldFont(8) : new UseCustomFont().LightFont(8);
            ProductLabel.Font = Page.Product == page ? new UseCustomFont().BoldFont(8) : new UseCustomFont().LightFont(8);
            OrderLabel.Font = Page.Order == page ? new UseCustomFont().BoldFont(8) : new UseCustomFont().LightFont(8);

            CustomerLabel.ForeColor = Page.Customer == page ? Color.White : ColorTranslator.FromHtml("#ABABAB");
            ProductLabel.ForeColor = Page.Product == page ? Color.White : ColorTranslator.FromHtml("#ABABAB");
            OrderLabel.ForeColor = Page.Order == page ? Color.White : ColorTranslator.FromHtml("#ABABAB");
        }
        private void SetCustomSkin()
        {
            this.SetStyle(ControlStyles.Selectable, false);
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
        public void GoToUpdateProductPage(ProductModel product)
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
        public void GoToUpdateCustomerPage(CustomerModel customer)
        {
            FunctionsView.Controls.Clear();
            NewCustomer newCustomerView = new NewCustomer(this, customer);
            FunctionsView.Controls.Add(newCustomerView.CustomerLayoutView);
        }
        public void GoToCustomersList()
        {
            FunctionsView.Controls.Clear();
            ShowAllCustomer = new ViewAllCustomer(this);
            FunctionsView.Controls.Add(ShowAllCustomer.CustomerViewLayout);
            SetMenuBarFocus(Page.Customer);
        }
        public void GoToProductsList()
        {
            FunctionsView.Controls.Clear();
            ShowAllProduct = new ViewAllProduct(this);
            FunctionsView.Controls.Add(ShowAllProduct.ProductViewLayout);
            SetMenuBarFocus(Page.Product);
        }
        public void GoToNewOrderPage(ProductModel product)
        {
            FunctionsView.Controls.Clear();
            NewAndUpdateOrder newOrder = new NewAndUpdateOrder(this, product, null);
            FunctionsView.Controls.Add(newOrder.OrderLayoutView);
        }
        public void GoToOrdersList()
        {
            FunctionsView.Controls.Clear();
            ShowAllOrder = new ViewAllOrder();
            FunctionsView.Controls.Add(ShowAllOrder.OrderViewLayout);
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
