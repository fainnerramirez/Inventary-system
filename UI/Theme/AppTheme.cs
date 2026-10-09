using System;
using System.Collections.Generic;
using System.Text;

namespace InventarySystem.UI.Theme
{
    public static class AppTheme
    {
        public static readonly Color Primary = Color.FromArgb(52, 152, 219); // Blue
        public static readonly Color Background = Color.FromArgb(236, 240, 241); // Light Gray
        public static readonly Font BodyFont = new("Segoe UI", 10);

        public static void ApplyTheme(Control root)
        {
            root.BackColor = Background;
            root.Font = BodyFont;
            ApplyThemeToChildren(root);
        }

        public static void ApplyThemeToChildren(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                ApplyThemeToControl(control);
                if (control is DataGridView) continue;
                if(control.HasChildren) ApplyThemeToChildren(control);
            }
        }

        public static void ApplyThemeToControl(Control control)
        {
            switch (control)
            {
                case Button button:
                    button.BackColor = Primary;
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    break;
                case Label label:
                    label.ForeColor = Color.Black;
                    break;
                case TextBox textBox:
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = Color.Black;
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case ComboBox comboBox:
                    comboBox.BackColor = Color.White;
                    comboBox.ForeColor = Color.Black;
                    comboBox.FlatStyle = FlatStyle.Flat;
                    break;
                case DataGridView dataGridView:
                    dataGridView.BackgroundColor = Background;
                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.DefaultCellStyle.BackColor = Color.White;
                    dataGridView.DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Primary;
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView.EnableHeadersVisualStyles = false;
                    break;
            }
        }
    }
}