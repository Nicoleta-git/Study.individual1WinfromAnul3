using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomProgressBar : ProgressBar
{
    public Color ProgressColor { get; set; } = Color.MediumPurple;
    public Color BackgroundBarColor { get; set; } = ColorTranslator.FromHtml("#0F0727");

    public CustomProgressBar()
    {
        this.SetStyle(ControlStyles.UserPaint, true);
        this.ForeColor = ProgressColor;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Rectangle rect = this.ClientRectangle;
        Graphics g = e.Graphics;

        using (SolidBrush backgroundBrush = new SolidBrush(BackgroundBarColor))
        {
            g.FillRectangle(backgroundBrush, rect);
        }

        rect.Width = (int)((float)this.Value / this.Maximum * rect.Width);

        using (SolidBrush progressBrush = new SolidBrush(ProgressColor))
        {
            g.FillRectangle(progressBrush, 0, 0, rect.Width, rect.Height);
        }
    }
}
