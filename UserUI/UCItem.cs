using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Models;


namespace AdminUIForm
{
    public partial class UCItem : UserControl
    {
        public UCItem()
        {
            InitializeComponent();
        }

        FindControl findControl = new FindControl();

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
            UCCart item = new UCCart();
            item.ItemName = this.ItemName;
            item.ItemPrice = this.ItemPrice;
            ((FlowLayoutPanel)findControl.Ctrl(findControl.TheForm("UserForm"), "cartItemsPanel")).Controls.Add(item);
        }
    }
}
