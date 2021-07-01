using FontAwesome.Sharp;
using Restaurant.App.Service;
using Restaurant.Business;
using Restaurant.Business.Customer.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class CustomerItem : Form
    {
        Color FocusColor = ColorTranslator.FromHtml("#ebfaff");
        Color UnfocusColor = Color.White;
        CustomerModel Customer;
        ViewAllCustomer Main;
        public CustomerItem(CustomerModel customer, ViewAllCustomer main)
        {
            this.Customer = customer;
            this.Main = main;
            InitializeComponent();
            SetHoverContent();
            CustomerNameLB.Font = new UseCustomFont().LightFont(8);
            CustomerNameLB.Text = $"Customer Name: {Customer.Firstname} {Customer.Lastname} / Customer Address: {Customer.Address}";
            MainPanel.BackColor = Color.White;
            Splitter.Visible = false;
            GenerateIcons();
        }
        private void GenerateIcons()
        {
            DeleteBT.Image = IconChar.Trash.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Red);
            EditBT.Image = IconChar.Edit.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Gray);
            CustomerIcon.Image = Image.FromFile("../../assets/image/user.png");
        }
        private void SetHoverContent()
        {
            var getAllPanelComponents = MainPanel.Controls;
            foreach (Control component in getAllPanelComponents)
            {
                component.MouseEnter += (sender, eventArgs) =>
                {
                    FocusItem(true);
                };
                component.MouseLeave += (sender, eventArgs) =>
                {
                    FocusItem(false);
                };
            }
        }
        private void FocusItem(bool isFocus)
        {
            MainPanel.BackColor = isFocus ? FocusColor : UnfocusColor;
            Splitter.Visible = isFocus;
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

        private void MainPanelEnter(object sender, EventArgs e)
        {
            FocusItem(true);
        }

        private void MainPanelLeave(object sender, EventArgs e)
        {
            FocusItem(false);
        }
    }
}
