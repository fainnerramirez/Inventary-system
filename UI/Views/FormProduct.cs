using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventarySystem.presentation
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        private void titleProducts_Click(object sender, EventArgs e)
        {
            titleProducts.Text = "Tus Productos";
            
        }
    }
}