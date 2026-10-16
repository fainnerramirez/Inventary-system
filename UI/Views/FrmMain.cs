using InventarySystem.Application.Services;
using InventarySystem.Application.Services.ProductsService;
using InventarySystem.Infraestructure.ApiClients;
using InventarySystem.Infraestructure.Repositories;
using InventarySystem.UI.Theme;
using System.Text.Json;
using System.Linq;
using System.Windows.Forms;
using InventarySystem.Infraestructure.DTOs.ProductsDTO;

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

                var products = (await _productService.GetAllProductsAsync()).ToList();

                gridProducts.DataSource = null;
                if (products != null && products.Any())
                {
                    var bs = new BindingSource { DataSource = products };
                    gridProducts.DataSource = bs;
                    ConfigColumns();
                    //customColumns();
                    gridProducts.Refresh();
                }
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

        private void ConfigColumns()
        {
            // header text
            gridProducts.Columns[nameof(ProductResponse.ProductId)]?.HeaderText = "ID";       
            gridProducts.Columns[nameof(ProductResponse.ProductName)]?.HeaderText = "Nombre";
            gridProducts.Columns[nameof(ProductResponse.ProductDescription)]?.HeaderText = "Descripción";
            gridProducts.Columns[nameof(ProductResponse.ProductPrice)]?.HeaderText = "Precio";
            gridProducts.Columns[nameof(ProductResponse.ProductStock)]?.HeaderText = "Stock";
            gridProducts.Columns[nameof(ProductResponse.ProductCategory)]?.HeaderText = "Categoría";
            gridProducts.Columns[nameof(ProductResponse.ProductCreatedAt)]?.HeaderText = "Creado el";
            gridProducts.Columns[nameof(ProductResponse.ProductUpdatedAt)]?.HeaderText = "Actualizado el";

            // column width
            gridProducts.Columns[nameof(ProductResponse.ProductId)]?.Width = 100;
            gridProducts.Columns[nameof(ProductResponse.ProductDescription)]?.Width = 500;
            gridProducts.Columns[nameof(ProductResponse.ProductPrice)]?.Width = 200;
            gridProducts.Columns[nameof(ProductResponse.ProductStock)]?.Width = 100;
            gridProducts.Columns[nameof(ProductResponse.ProductCategory)]?.Width = 200;

            // formats
            gridProducts.Columns[nameof(ProductResponse.ProductPrice)]?.DefaultCellStyle.Format = "C2";
            gridProducts.Columns[nameof(ProductResponse.ProductCreatedAt)]?.DefaultCellStyle.Format = "ddd/MM HH:mm";
            gridProducts.Columns[nameof(ProductResponse.ProductUpdatedAt)]?.DefaultCellStyle.Format = "ddd/MM HH:mm";
        }

        //private void customColumns()
        //{
        //    gridProducts.AutoGenerateColumns = true;

        //    if (gridProducts.Columns.Contains("Edit"))
        //        return;

        //    var editColumn = new DataGridViewButtonColumn
        //    {
        //        Name = "Edit",
        //        HeaderText = "Acciones",
        //        Text = "✏ Editar",
        //        UseColumnTextForButtonValue = true,
        //        Width = 90,
        //        FlatStyle = FlatStyle.Popup
        //    };

        //    var deleteColumn = new DataGridViewButtonColumn
        //    {
        //        Name = "Delete",
        //        HeaderText = "",
        //        Text = "🗑 Eliminar",
        //        UseColumnTextForButtonValue = true,
        //        Width = 100,
        //        FlatStyle = FlatStyle.Popup
        //    };

        //    gridProducts.Columns.Add(editColumn);
        //    gridProducts.Columns.Add(deleteColumn);
        //}

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