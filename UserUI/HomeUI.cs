using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserUIForm;

namespace AdminUIForm
{
    public partial class HomeUI : Form
    {

        AdminForm adminForm;
        public UserForm userForm;
        public HomeUI()
        {
            InitializeComponent();
            CheckTime();
        }
        private void btnOpenAdmin_Click(object sender, EventArgs e)
        {
            adminForm = new AdminForm();
            adminForm.ShowDialog();
        }

        private void btnOpenCustomer_Click(object sender, EventArgs e)
        {
            userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckTime()
        {
            int hours = DateTime.Now.Hour;
            if (hours > 16)
            {
                lblWelcoming.Text = "Good, Evening";
            }
            else if (hours > 11)
            {
                lblWelcoming.Text = "Good, Afternoon";
            }
            else
            {
                lblWelcoming.Text = "Good, Morning";
            }
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
