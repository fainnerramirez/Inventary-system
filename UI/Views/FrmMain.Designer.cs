namespace InventarySystem.presentation
{
    partial class FrmMain: Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebarApp = new Panel();
            StockControl = new Button();
            salesBtn = new Button();
            label1 = new Label();
            FilterText = new TextBox();
            button1 = new Button();
            CreateProduct = new Button();
            titlePage = new Label();
            Load_Products_Label = new Label();
            panel1 = new Panel();
            load_products = new Label();
            gridProducts = new DataGridView();
            sidebarApp.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridProducts).BeginInit();
            SuspendLayout();
            // 
            // sidebarApp
            // 
            sidebarApp.Controls.Add(StockControl);
            sidebarApp.Controls.Add(salesBtn);
            sidebarApp.Controls.Add(label1);
            sidebarApp.Location = new Point(12, 12);
            sidebarApp.Name = "sidebarApp";
            sidebarApp.Size = new Size(220, 822);
            sidebarApp.TabIndex = 0;
            sidebarApp.Paint += sidebarApp_Paint;
            // 
            // StockControl
            // 
            StockControl.Location = new Point(8, 172);
            StockControl.Name = "StockControl";
            StockControl.Padding = new Padding(10, 0, 10, 0);
            StockControl.Size = new Size(197, 70);
            StockControl.TabIndex = 3;
            StockControl.Text = "Stock Control";
            StockControl.UseVisualStyleBackColor = true;
            StockControl.Click += StockControl_Click;
            // 
            // salesBtn
            // 
            salesBtn.Location = new Point(7, 84);
            salesBtn.Name = "salesBtn";
            salesBtn.Padding = new Padding(10, 0, 10, 0);
            salesBtn.Size = new Size(197, 75);
            salesBtn.TabIndex = 2;
            salesBtn.Text = "Ventas";
            salesBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 1;
            label1.Text = "Inventario";
            label1.Click += label1_Click;
            // 
            // FilterText
            // 
            FilterText.Location = new Point(275, 121);
            FilterText.Name = "FilterText";
            FilterText.PlaceholderText = "  Filtrar productos";
            FilterText.Size = new Size(360, 39);
            FilterText.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(655, 110);
            button1.Name = "button1";
            button1.Size = new Size(128, 61);
            button1.TabIndex = 3;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // CreateProduct
            // 
            CreateProduct.Location = new Point(798, 110);
            CreateProduct.Name = "CreateProduct";
            CreateProduct.Size = new Size(184, 61);
            CreateProduct.TabIndex = 4;
            CreateProduct.Text = "Nuevo Producto";
            CreateProduct.UseVisualStyleBackColor = true;
            CreateProduct.Click += CreateProduct_Click;
            // 
            // titlePage
            // 
            titlePage.AutoSize = true;
            titlePage.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titlePage.Location = new Point(260, 46);
            titlePage.Name = "titlePage";
            titlePage.Size = new Size(375, 72);
            titlePage.TabIndex = 5;
            titlePage.Text = "Tus Productos";
            titlePage.Click += titlePage_Click;
            // 
            // Load_Products_Label
            // 
            Load_Products_Label.AutoSize = true;
            Load_Products_Label.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Load_Products_Label.Location = new Point(740, 360);
            Load_Products_Label.Name = "Load_Products_Label";
            Load_Products_Label.Size = new Size(389, 51);
            Load_Products_Label.TabIndex = 6;
            Load_Products_Label.Text = "Cargando productos...";
            Load_Products_Label.Click += Load_Products_Label_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(load_products);
            panel1.Controls.Add(gridProducts);
            panel1.Location = new Point(260, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(1683, 650);
            panel1.TabIndex = 7;
            // 
            // load_products
            // 
            load_products.AutoSize = true;
            load_products.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            load_products.Location = new Point(420, 260);
            load_products.Name = "load_products";
            load_products.Size = new Size(441, 59);
            load_products.TabIndex = 1;
            load_products.Text = "Cargando productos...";
            load_products.Click += load_products_Click;
            // 
            // gridProducts
            // 
            gridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProducts.Location = new Point(21, 23);
            gridProducts.Name = "gridProducts";
            gridProducts.RowHeadersWidth = 82;
            gridProducts.Size = new Size(1645, 604);
            gridProducts.TabIndex = 0;
            gridProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1955, 846);
            Controls.Add(panel1);
            Controls.Add(Load_Products_Label);
            Controls.Add(titlePage);
            Controls.Add(CreateProduct);
            Controls.Add(button1);
            Controls.Add(FilterText);
            Controls.Add(sidebarApp);
            Name = "FrmMain";
            Text = "FrmMain";
            sidebarApp.ResumeLayout(false);
            sidebarApp.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidebarApp;
        private Label label1;
        private Button salesBtn;
        private Button StockControl;
        private TextBox FilterText;
        private Button button1;
        private Button CreateProduct;
        private Label titlePage;
        private Label Load_Products_Label;
        private Panel panel1;
        private DataGridView gridProductsdataGridView1;
        private Label load_products;
        private DataGridView gridProducts;
    }
}