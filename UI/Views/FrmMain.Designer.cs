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
            productsBtn = new Button();
            FilterText = new TextBox();
            button1 = new Button();
            CreateProduct = new Button();
            titlePage = new Label();
            Load_Products_Label = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            load_products = new Label();
            sidebarApp.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // sidebarApp
            // 
            sidebarApp.Controls.Add(StockControl);
            sidebarApp.Controls.Add(salesBtn);
            sidebarApp.Controls.Add(label1);
            sidebarApp.Controls.Add(productsBtn);
            sidebarApp.Location = new Point(12, 12);
            sidebarApp.Name = "sidebarApp";
            sidebarApp.Size = new Size(400, 822);
            sidebarApp.TabIndex = 0;
            sidebarApp.Paint += sidebarApp_Paint;
            // 
            // StockControl
            // 
            StockControl.Location = new Point(18, 224);
            StockControl.Name = "StockControl";
            StockControl.Size = new Size(359, 46);
            StockControl.TabIndex = 3;
            StockControl.Text = "Stock Control";
            StockControl.UseVisualStyleBackColor = true;
            StockControl.Click += StockControl_Click;
            // 
            // salesBtn
            // 
            salesBtn.Location = new Point(18, 161);
            salesBtn.Name = "salesBtn";
            salesBtn.Size = new Size(359, 46);
            salesBtn.TabIndex = 2;
            salesBtn.Text = "Ventas";
            salesBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 34);
            label1.Name = "label1";
            label1.Size = new Size(245, 32);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Inventario";
            label1.Click += label1_Click;
            // 
            // productsBtn
            // 
            productsBtn.Location = new Point(18, 97);
            productsBtn.Name = "productsBtn";
            productsBtn.Size = new Size(359, 46);
            productsBtn.TabIndex = 0;
            productsBtn.Text = "Productos";
            productsBtn.UseVisualStyleBackColor = true;
            productsBtn.Click += productsBtn_Click;
            // 
            // FilterText
            // 
            FilterText.Location = new Point(450, 113);
            FilterText.Name = "FilterText";
            FilterText.PlaceholderText = "Filtrar por productos";
            FilterText.Size = new Size(310, 39);
            FilterText.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(766, 109);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 3;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // CreateProduct
            // 
            CreateProduct.Location = new Point(1742, 106);
            CreateProduct.Name = "CreateProduct";
            CreateProduct.Size = new Size(201, 46);
            CreateProduct.TabIndex = 4;
            CreateProduct.Text = "Nuevo Producto";
            CreateProduct.UseVisualStyleBackColor = true;
            CreateProduct.Click += CreateProduct_Click;
            // 
            // titlePage
            // 
            titlePage.AutoSize = true;
            titlePage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titlePage.Location = new Point(442, 46);
            titlePage.Name = "titlePage";
            titlePage.Size = new Size(326, 65);
            titlePage.TabIndex = 5;
            titlePage.Text = "Tus Productos";
            titlePage.Click += titlePage_Click;
            // 
            // Load_Products_Label
            // 
            Load_Products_Label.AutoSize = true;
            Load_Products_Label.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Load_Products_Label.Location = new Point(821, 500);
            Load_Products_Label.Name = "Load_Products_Label";
            Load_Products_Label.Size = new Size(440, 59);
            Load_Products_Label.TabIndex = 6;
            Load_Products_Label.Text = "Cargando Productos...";
            Load_Products_Label.Click += Load_Products_Label_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(load_products);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(450, 184);
            panel1.Name = "panel1";
            panel1.Size = new Size(1493, 650);
            panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1455, 624);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // load_products
            // 
            load_products.AutoSize = true;
            load_products.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            load_products.Location = new Point(470, 293);
            load_products.Name = "load_products";
            load_products.Size = new Size(491, 65);
            load_products.TabIndex = 1;
            load_products.Text = "Cargando productos...";
            load_products.Click += load_products_Click;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel sidebarApp;
        private Label label1;
        private Button productsBtn;
        private Button salesBtn;
        private Button StockControl;
        private TextBox FilterText;
        private Button button1;
        private Button CreateProduct;
        private Label titlePage;
        private Label Load_Products_Label;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label load_products;
    }
}