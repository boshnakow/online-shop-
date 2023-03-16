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

namespace UserUIForm
{
    public partial class AdminForm : Form
    {

        private ProductBusiness productBusiness = new ProductBusiness();
        private OpenFileDialog fileDialog = new OpenFileDialog();
        private int editId = 0;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineShopDbDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.onlineShopDbDataSet.Products);
            fileDialog.Title = "Open picture for product";
        }

        private void ClearTextBoxes()
        {
            txtName.Clear();
            txtDescription.Clear();
            txtPrice.Clear();
            nudQuantity.Value = 0;
            txtPicLink.Clear();
        }

        private void UpdateGrid()
        {
            dataGrid.DataSource = productBusiness.GetAll();
            dataGrid.ReadOnly = true;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void UpdateTextBoxes(int id)
        {
            Product update = productBusiness.Get(id);
            txtName.Text = update.Name;
            txtDescription.Text = update.Description;
            txtPrice.Text = update.Price.ToString();
            nudQuantity.Text = update.Quantity.ToString();
            txtPicLink.Text = update.PictureLink;
        }

        private void ToggleSaveUpdate()
        {
            if (btnUpdate.Visible)
            {
                btnSave.Visible = true;
                btnUpdate.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
            }
        }

        private void DisableSelect()
        {
            dataGrid.Enabled = false;
        }

        private Product GetEditedProduct()
        {
            Product product = new Product();
            product.Id = editId;

            string name = txtName.Text;
            string description = txtDescription.Text;
            decimal price = 0;
            decimal.TryParse(txtPrice.Text, out price);
            int stock = 0;
            int.TryParse(nudQuantity.Text, out stock);
            string picLink = txtPicLink.Text;
            product.Name = name;
            product.Description = description;
            product.Price = price;
            product.Quantity = stock;
            product.PictureLink = picLink;
            return product;
        }

        private void ResetSelect()
        {
            dataGrid.ClearSelection();
            dataGrid.Enabled = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Name = txtName.Text;
            product.Description = txtDescription.Text;
            product.Price = decimal.Parse(txtPrice.Text);
            product.Quantity = (int)nudQuantity.Value;
            product.PictureLink = txtPicLink.Text;
            productBusiness.Add(product);
            UpdateGrid();
            ClearTextBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product editedProduct = GetEditedProduct();
            productBusiness.Update(editedProduct);
            UpdateGrid();
            ResetSelect();
            ToggleSaveUpdate();
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                var item = dataGrid.SelectedRows[0].Cells;
                var id = int.Parse(item[0].Value.ToString());
                productBusiness.Delete(id);
                UpdateGrid();
                ResetSelect();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                var product = dataGrid.SelectedRows[0].Cells;
                int id = int.Parse(product[0].Value.ToString());
                editId = id;
                UpdateTextBoxes(id);
                ToggleSaveUpdate();
                DisableSelect();
            }
            else
            {
                MessageBox.Show("Item not found...");
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
            txtPicLink.Text = fileDialog.FileName;
        }
    }
}
