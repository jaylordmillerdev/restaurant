using FontAwesome.Sharp;
using Restaurant.App.Service;
using Restaurant.App.Shared;
using Restaurant.Business;
using Restaurant.Business.Customer.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant.App.View
{
    public partial class CustomerItem : Form
    {
        private Color _FocusColor = ColorTranslator.FromHtml("#ebfaff");
        private Color _UnfocusColor = Color.White;
        private Customer _Customer;
        private ViewAllCustomer _Main;
        public CustomerItem(Customer customer, ViewAllCustomer main)
        {
            this._Customer = customer;
            this._Main = main;
            InitializeComponent();
            SetHoverContent();
            CustomerNameLB.Font = CustomFont.Get.LightFont(8);
            CustomerNameLB.Text = $"Customer Name: {_Customer.Firstname} {_Customer.Lastname} / Customer Address: {_Customer.Address}";
            MainPanel.BackColor = Color.White;
            Splitter.Visible = false;
            GenerateIcons();
        }
        private void GenerateIcons()
        {
            DeleteBT.Image = IconChar.Trash.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Red);
            EditBT.Image = IconChar.Edit.ToBitmap(iconFont: IconFont.Auto, size: 20, color: Color.Gray);
            CustomerIcon.Image = Image.FromFile("../../Utilities/assets/image/user.png");
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
                component.MouseClick += (sender, eventArgs) =>
                {
                    ShowDetails();
                };

            }
        }
        private void ShowDetails()
        {
            Dictionary<string, string> data = new Dictionary<string, string>(){
                {"Firstname", _Customer.Firstname },
                {"Lastname", _Customer.Lastname },
                {"Address", _Customer.Address },
                {"Date Added", _Customer.DateCreated.ToString("MM/dd/yyyy") }
            };
            new ShowPopUp(
                title: $"{_Customer.Firstname} {_Customer.Lastname}",
                messageData: data);
        }
        private void FocusItem(bool isFocus)
        {
            MainPanel.BackColor = isFocus ? _FocusColor : _UnfocusColor;
            Splitter.Visible = isFocus;
        }
        private void DeleteItem(object sender, EventArgs e)
        {
            RequestResult requestStatus = new CustomerService().Delete(id: _Customer.Id);
            _Main.ShowAllCustomer();
        }

        private void UpdateItem(object sender, EventArgs e)
        {
            _Main.UpdateItem(_Customer);
        }

        private void MainPanelEnter(object sender, EventArgs e)
        {
            FocusItem(true);
        }

        private void MainPanelLeave(object sender, EventArgs e)
        {
            FocusItem(false);
        }

        private void ShowDetails(object sender, MouseEventArgs e)
        {
            ShowDetails();
        }
    }
}
