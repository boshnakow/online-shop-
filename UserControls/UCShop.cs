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

namespace UserControls
{
    public partial class UCShop : UserControl
    {
        public UCShop()
        {
            InitializeComponent();
        }
        public string ItemName
        {
            get
            {
                return lblName.Text;
            }
            set
            {
                lblName.Text = value;
            }
        }
        public string ItemDescription
        {
            get
            {
                return lblDescription.Text;
            }
            set
            {
                lblDescription.Text = value;
            }
        }
        public string ItemQuantity
        {
            get
            {
                return lblQuantity.Text;
            }
            set
            {
                lblQuantity.Text = value.ToString();
            }
        }
        public string ItemPrice
        {
            get
            {
                return lblPrice.Text;
            }
            set
            {
                lblPrice.Text = value.ToString();
            }
        }
        public string ItemPicture
        {
            get
            {
                return picItemFrame.ImageLocation;
            }
            set
            {
                picItemFrame.ImageLocation = value;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = this.ItemName;
            product.Price = decimal.Parse(this.ItemPrice);
            product.Description = this.ItemDescription;
            product.Quantity = int.Parse(this.ItemQuantity);
            product.PictureLink = this.ItemPicture;

        }

        public void Modify(FlowLayoutPanel flowLayoutPanel, UCCart item)
        {
            flowLayoutPanel.Controls.Add(item);
        }
    }
}
