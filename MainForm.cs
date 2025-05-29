using ProductManager.Context;
using ProductManager.Models;
using ProductManager.Repositories;
using ProductManager.Services;

namespace ProductManager
{
    public partial class MainForm : Form
    {
        public readonly AppService _appService;
        public MainForm()
        {
            InitializeComponent();

            AppDbContext appDbContext = new AppDbContext();

            _appService = new AppService(new ProductRepository(appDbContext));
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await RefreshDataGrid();
        }

        private async void searchProduct_Click(object sender, EventArgs e)
        {
            var products = await _appService.GetAllProductsAsync(p => p.Name.ToLower().Contains(textBoxSearchProducts.Text.ToLower()));
            if (products.Count() == 0)
            {
                MessageBox.Show("�������� �� �������!", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await RefreshDataGrid(products.OrderBy(p => p.Id).ToList());
            }
        }

        private async void addProduct_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var product = form.Product;

                await _appService.AddProductAsync(product);
                MessageBox.Show("������� ������� ��������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await RefreshDataGrid();
            }
        }

        private async void updateProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewProducts.SelectedRows[0];
                var product = (Product)selectedRow.DataBoundItem;
                var form = new ProductForm(product);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    product = form.Product;
                    await _appService.UpdateProductAsync(product);
                    MessageBox.Show("������� ������� ��������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefreshDataGrid();
                }
            }
            else
            {
                MessageBox.Show("�������� ���-�� �� ������!", "�� �������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewProducts.SelectedRows[0];
                var product = (Product)selectedRow.DataBoundItem;
                var result = MessageBox.Show($"�� ������������� ������ ������� {product.Name}?", "��������", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    await _appService.DeleteProductAsync(product.Id);
                    MessageBox.Show("������� ������� ������!", "�������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await RefreshDataGrid();
                }
            }
            else
            {
                MessageBox.Show("�������� ���-�� �� ������!", "�� �������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private async Task RefreshDataGrid()
        {
            var products = await _appService.GetAllProductsAsync();
            dataGridViewProducts.DataSource = products.OrderBy(p => p.Id).ToList();
        }
        private async Task RefreshDataGrid(List<Product> products)
        {
            dataGridViewProducts.DataSource = products;
        }
        
    }
}
