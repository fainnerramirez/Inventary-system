using InventarySystem.Application.Services;
using InventarySystem.Infraestructure.ApiClients;
using InventarySystem.UI.Theme;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace InventarySystem.presentation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            AppTheme.Apply(this);
            this.Load += FrmMain_Load;
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                load_products.Visible = true;
                gridProducts.Visible = false;

                var products = await ApiService.GetProducts();
                gridProducts.DataSource = null;
                gridProducts.DataSource = products;
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