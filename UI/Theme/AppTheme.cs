using System.Drawing.Drawing2D;
using System.Reflection;

namespace InventarySystem.UI.Theme
{
    public static class AppTheme
    {
        private static readonly Color Primary = Color.FromArgb(52, 152, 219);
        private static readonly Color PrimaryDark = Color.FromArgb(33, 47, 60);
        private static readonly Color PrimaryAccent = Color.FromArgb(41, 128, 185);
        private static readonly Color Background = Color.FromArgb(246, 247, 249);
        private static readonly Color Card = Color.FromArgb(255, 255, 255);
        private static readonly Font BodyFont = new("Segoe UI", 10F);
        private static readonly Font TitleFont = new("Segoe UI Semibold", 18F);

        public static void Apply(Control root)
        {
            if (root is Form form)
            {
                // DoubleBuffered is protected; set via reflection to improve rendering
                var prop = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
                prop?.SetValue(form, true);
            }

            root.BackColor = Background;
            root.Font = BodyFont;
            ApplyThemeToChildren(root);
        }

        private static void ApplyThemeToChildren(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                ApplyThemeToControl(control);
                if (control.HasChildren && !(control is DataGridView)) ApplyThemeToChildren(control);
            }
        }

        private static void ApplyThemeToControl(Control control)
        {
            switch (control)
            {
                case Panel panel:
                    // Sidebar style or card containers
                    if (panel.Name.ToLower().Contains("sidebar"))
                    {
                        panel.BackColor = PrimaryDark;
                        panel.Padding = new Padding(12);
                    }
                    else
                    {
                        panel.BackColor = Card;
                        panel.Padding = new Padding(10);
                    }
                    break;
                case Button button:
                    styleButton(button);
                    break;
                case Label label:
                    label.ForeColor = Color.FromArgb(44, 62, 80);
                    if (label.Name.ToLower().Contains("title") || label.Font.Size >= 16F)
                    {
                        label.Font = TitleFont;
                        label.ForeColor = Color.FromArgb(33, 47, 60);
                    }
                    break;
                case TextBox textBox:
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = Color.FromArgb(33, 47, 60);
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Padding = new Padding(6);
                    break;
                case ComboBox comboBox:
                    comboBox.BackColor = Color.White;
                    comboBox.ForeColor = Color.FromArgb(33, 47, 60);
                    comboBox.FlatStyle = FlatStyle.Flat;
                    break;
                case DataGridView dataGridView:
                    dataGridView.BackgroundColor = Card;
                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.BorderStyle = BorderStyle.None;
                    dataGridView.DefaultCellStyle.BackColor = Color.White;
                    dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(33, 47, 60);
                    dataGridView.DefaultCellStyle.SelectionBackColor = PrimaryAccent;
                    dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
                    dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Primary;
                    dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
                    dataGridView.RowHeadersVisible = false;
                    dataGridView.EnableHeadersVisualStyles = false;
                    dataGridView.Dock = DockStyle.Fill;
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                    dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    break;
            }
        }

        private static void styleButton(Button button)
        {
            button.BackColor = Color.FromArgb(41, 128, 185);
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Padding = new Padding(8, 6, 8, 6);
            button.Font = new Font(button.Font.FontFamily, 10F, FontStyle.Bold);
            // Rounded corners
            try
            {
                var r = CreateRoundedRegion(button.Width, button.Height, 8);
                button.Region = r;
            }
            catch { }

            // Hover
            button.MouseEnter -= Button_MouseEnter;
            button.MouseLeave -= Button_MouseLeave;
            button.MouseEnter += Button_MouseEnter;
            button.MouseLeave += Button_MouseLeave;
        }

        private static void Button_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is Button b)
            {
                b.BackColor = PrimaryAccent;
                Cursor.Current = Cursors.Hand;
            }
        }

        private static void Button_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button b)
            {
                b.BackColor = Color.FromArgb(41, 128, 185);
                Cursor.Current = Cursors.Default;
            }
        }

        private static Region CreateRoundedRegion(int width, int height, int radius)
        {
            var path = new GraphicsPath();
            var r = radius;
            path.StartFigure();
            path.AddArc(0, 0, r, r, 180, 90);
            path.AddArc(width - r, 0, r, r, 270, 90);
            path.AddArc(width - r, height - r, r, r, 0, 90);
            path.AddArc(0, height - r, r, r, 90, 90);
            path.CloseFigure();
            return new Region(path);
        }
    }
}