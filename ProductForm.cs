using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm(Product product)
        {
            InitializeComponent();

            if (product != null)
            {
                Product = product;
                textBoxProductName.Text = product.Name;
                textBoxProductDescription.Text = product.Description;
                textBoxProductPrice.Text = product.Price.ToString();
            }
        }
        public ProductForm()
        {
            InitializeComponent();
        }

        private void buttonAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProductName.Text) ||
                string.IsNullOrEmpty(textBoxProductDescription.Text) ||
                string.IsNullOrEmpty(textBoxProductPrice.Text) ||
                !decimal.TryParse(textBoxProductPrice.Text, out decimal price))
            {
                MessageBox.Show("Пожалуйста, заполните все боксы верно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Product == null)
            {
                Product = new Product
                {
                    Name = textBoxProductName.Text,
                    Description = textBoxProductDescription.Text,
                    Price = price
                };
            }
            else
            {
                Product.Name = textBoxProductName.Text;
                Product.Description = textBoxProductDescription.Text;
                Product.Price = price;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
