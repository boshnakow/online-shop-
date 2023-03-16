using Business;
using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AdminUIForm
{
    public partial class UserForm : Form
    {
        private CustomerBusiness customerBusiness = new CustomerBusiness();
        private ProductBusiness productBusiness = new ProductBusiness();
        private List<Product> products;
        private List<UCItem> shopItems = new List<UCItem>();
        public decimal total;

        public UserForm()
        {
            InitializeComponent();
        }


        private void PopulateShop()
        {
            products = productBusiness.GetAll();
            UCItem item;
            foreach (var product in products)
            {
                item = new UCItem();
                item.ItemName = product.Name;
                item.ItemPrice = $"{product.Price} BGN";
                item.ItemDescription = product.Description;
                item.ItemQuantity = $"{product.Quantity}";
                item.ItemPicture = product.PictureLink;
                shopItems.Add(item);
            }
            itemsPanel.Controls.Clear();
            foreach (var shopItem in shopItems)
            {
                itemsPanel.Controls.Add(shopItem);
            }
        }

        private void UserUIForm_Load(object sender, EventArgs e)
        {
            PopulateShop();
            cartItemsPanel.Controls.Clear();
        }

        #region ControlButtons

        private void btnShop_Click(object sender, EventArgs e)
        {
            tabShop.Show();
            tabCart.Hide();
            tabCheckout.Hide();
            PopulateShop();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            tabShop.Hide();
            tabCart.Show();
            tabCheckout.Hide();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            tabShop.Hide();
            tabCart.Hide();
            tabCheckout.Show();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void topBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        #endregion

        private void ClearTextBoxes()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            dateBirthday.Value = DateTime.Now;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.Name = txtName.Text;
            customer.Number = txtPhone.Text;
            customer.Address = txtAddress.Text;
            customer.Email = txtEmail.Text;
            customer.BirthDate = dateBirthday.Text;
            customerBusiness.Add(customer);
            ClearTextBoxes();
            cartItemsPanel.Controls.Clear();
            ChangeTotal();
            MessageBox.Show("Thank you for purchasing from our shop!", "Enjoy your goods.");
        }

        private void btnBackToCart_Click(object sender, EventArgs e)
        {
            tabShop.Hide();
            tabCart.Show();
            tabCheckout.Hide();
        }

        //Unwanted
        private void iconButton2_Click(object sender, EventArgs e) { }

        private void btnProceedToCheckout_Click(object sender, EventArgs e)
        {
            tabShop.Hide();
            tabCart.Hide();
            tabCheckout.Show();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            cartItemsPanel.Controls.Clear();
            lblTotal.Text = "0.00 BGN";
        }

        private void ChangeTotal()
        {
            decimal total = 0;
            foreach (UCCart item in cartItemsPanel.Controls)
            {
                total += decimal.Parse(item.ItemPrice.Remove(item.ItemPrice.IndexOf(" BGN"), 4));
            }
            lblTotal.Text = $"{total:F2} BGN";
            lblTotalCheckout.Text = $"{total:F2} BGN";
        }

        private void cartItemsPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            ChangeTotal();
        }

        private void cartItemsPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            ChangeTotal();
        }
    }
}
