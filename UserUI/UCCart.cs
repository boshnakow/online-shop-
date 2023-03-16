using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminUIForm
{
    public partial class UCCart : UserControl
    {
        public UCCart()
        {
            InitializeComponent();
        }

        private FindControl findControl = new FindControl();

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            var form = findControl.TheForm("UserForm");
            var panel = (FlowLayoutPanel)findControl.Ctrl(form, "cartItemsPanel");
            panel.Controls.Remove(this);
        }
    }
}
