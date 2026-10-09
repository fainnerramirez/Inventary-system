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
            dataGridView1 = new DataGridView();
            FilterText = new TextBox();
            button1 = new Button();
            CreateProduct = new Button();
            titlePage = new Label();
            sidebarApp.SuspendLayout();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(430, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(943, 589);
            dataGridView1.TabIndex = 1;
            // 
            // FilterText
            // 
            FilterText.Location = new Point(430, 191);
            FilterText.Name = "FilterText";
            FilterText.PlaceholderText = "Filtrar por productos";
            FilterText.Size = new Size(310, 39);
            FilterText.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(746, 187);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 3;
            button1.Text = "Filtrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // CreateProduct
            // 
            CreateProduct.Location = new Point(1162, 184);
            CreateProduct.Name = "CreateProduct";
            CreateProduct.Size = new Size(201, 46);
            CreateProduct.TabIndex = 4;
            CreateProduct.Text = "Nuevo Producto";
            CreateProduct.UseVisualStyleBackColor = true;
            // 
            // titlePage
            // 
            titlePage.AutoSize = true;
            titlePage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titlePage.Location = new Point(442, 46);
            titlePage.Name = "titlePage";
            titlePage.Size = new Size(241, 65);
            titlePage.TabIndex = 5;
            titlePage.Text = "Productos";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1399, 846);
            Controls.Add(titlePage);
            Controls.Add(CreateProduct);
            Controls.Add(button1);
            Controls.Add(FilterText);
            Controls.Add(dataGridView1);
            Controls.Add(sidebarApp);
            Name = "FrmMain";
            Text = "FrmMain";
            sidebarApp.ResumeLayout(false);
            sidebarApp.PerformLayout();
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
        private DataGridView dataGridView1;
        private TextBox FilterText;
        private Button button1;
        private Button CreateProduct;
        private Label titlePage;
    }
}