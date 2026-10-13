using InventarySystem.Application.Services;
using InventarySystem.Infraestructure.ApiClients;
using InventarySystem.UI.Theme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
                dataGridView1.Visible = false;

                var products = await ApiService.GetProducts();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dataGridView1.Visible = true;
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