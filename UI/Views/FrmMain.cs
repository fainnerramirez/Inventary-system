using InventarySystem.Application.Services;
using InventarySystem.Application.Services.ProductsService;
using InventarySystem.Infraestructure.ApiClients;
using InventarySystem.Infraestructure.Repositories;
using InventarySystem.UI.Theme;
using System.Text.Json;

namespace InventarySystem.presentation
{
    public partial class FrmMain : Form
    {
        private readonly IProductService _productService;

        public FrmMain(IProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            AppTheme.Apply(this);
            this.Load += FrmMain_Load;
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                load_products.Visible = true;
                gridProducts.Visible = false;

                var products = await _productService.GetAllProductsAsync();
                gridProducts.DataSource = null;
                gridProducts.DataSource = products;
                customColumns();
            }
            catch (HttpRequestException httpEx)
            {
                MessageBox.Show($"HTTP error occurred: {httpEx.Message}");
            }
            catch (JsonException jsonEx)
            {
                MessageBox.Show($"JSON error occurred: {jsonEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error making request to {ExternalApiClient.BaseUrl}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                gridProducts.Visible = true;
                load_products.Visible = false;
            }
        }

        private void customColumns()
        {
            gridProducts.AutoGenerateColumns = true;

            if (gridProducts.Columns.Contains("Edit"))
                return;

            var editColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "Acciones",
                Text = "✏ Editar",
                UseColumnTextForButtonValue = true,
                Width = 90,
                FlatStyle = FlatStyle.Popup
            };

            var deleteColumn = new DataGridViewButtonColumn
            {
                Name = "Delete",
                HeaderText = "",
                Text = "🗑 Eliminar",
                UseColumnTextForButtonValue = true,
                Width = 100,
                FlatStyle = FlatStyle.Popup
            };

            gridProducts.Columns.Add(editColumn);
            gridProducts.Columns.Add(deleteColumn);
        }

        private void sidebarApp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productsBtn_Click(object sender, EventArgs e)
        {

        }

        private void StockControl_Click(object sender, EventArgs e)
        {

        }

        private async void CreateProduct_Click(object sender, EventArgs e)
        {
            // handle method
        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void Load_Products_Label_Click(object sender, EventArgs e)
        {

        }

        private void titlePage_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void load_products_Click(object sender, EventArgs e)
        {

        }
    }
}