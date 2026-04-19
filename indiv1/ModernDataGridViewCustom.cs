using System;
using System.Drawing;
using System.Windows.Forms;

public class ModerDataGridViewCustom : DataGridView
{
    private Color primaryColor = ColorTranslator.FromHtml("#800080"); // purple
    private Color darkBackground = Color.Black;
    private Color rowAltColor = Color.FromArgb(30, 0, 30);
    private Color gridColorCustom = Color.FromArgb(60, 0, 60);

    public ModerDataGridViewCustom()
    {
        InitializeStyle();
    }

    private void InitializeStyle()
    {
        // General
        this.EnableHeadersVisualStyles = false;
        this.BackgroundColor = darkBackground;
        this.BorderStyle = BorderStyle.None;
        this.GridColor = gridColorCustom;
        this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        this.RowHeadersVisible = false;
        this.AllowUserToAddRows = false;
        this.AllowUserToResizeRows = false;
        this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        this.MultiSelect = false;

        // Header style
        this.ColumnHeadersHeight = 40;
        this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        this.ColumnHeadersDefaultCellStyle.BackColor = primaryColor;
        this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        this.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        // Rows
        this.DefaultCellStyle.BackColor = darkBackground;
        this.DefaultCellStyle.ForeColor = Color.White;
        this.DefaultCellStyle.SelectionBackColor = primaryColor;
        this.DefaultCellStyle.SelectionForeColor = Color.White;
        this.DefaultCellStyle.Font = new Font("Segoe UI", 10);
        this.DefaultCellStyle.Padding = new Padding(5);

        // Alternating rows
        this.AlternatingRowsDefaultCellStyle.BackColor = rowAltColor;

        this.RowTemplate.Height = 35;

        this.SetDoubleBuffered(true);

        this.DefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 0, 120);
    }

    private void SetDoubleBuffered(bool setting)
    {
        typeof(DataGridView)
            .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
            .SetValue(this, setting, null);
    }

    protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
    {
        base.OnCellPainting(e);

        if (e.RowIndex == -1 && e.ColumnIndex >= 0)
        {
            e.Graphics.FillRectangle(new SolidBrush(primaryColor), e.CellBounds);
            TextRenderer.DrawText(
                e.Graphics,
                e.FormattedValue?.ToString(),
                e.CellStyle.Font,
                e.CellBounds,
                Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
            e.Handled = true;
        }
    }
}