using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomRoundedComboBox : ComboBox
{
    private int borderRadius = 15;
    private int borderSize = 2;
    private Color borderColor = Color.MediumSlateBlue;
    private Color backgroundColor = Color.White;
    private Color iconColor = Color.MediumSlateBlue;

    public CustomRoundedComboBox()
    {
        this.DrawMode = DrawMode.OwnerDrawFixed;
        this.DropDownStyle = ComboBoxStyle.DropDownList;
        this.FlatStyle = FlatStyle.Flat;
        this.BackColor = backgroundColor;
        this.ForeColor = Color.Black;
        this.ItemHeight = 30;
    }

    public int BorderRadius
    {
        get => borderRadius;
        set { borderRadius = value; Invalidate(); }
    }

    public int BorderSize
    {
        get => borderSize;
        set { borderSize = value; Invalidate(); }
    }

    public Color BorderColor
    {
        get => borderColor;
        set { borderColor = value; Invalidate(); }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
    }

    protected override void OnDrawItem(DrawItemEventArgs e)
    {
        if (e.Index < 0) return;

        e.DrawBackground();

        string text = GetItemText(Items[e.Index]);

        using (SolidBrush brush = new SolidBrush(ForeColor))
        {
            e.Graphics.DrawString(text, e.Font, brush, e.Bounds);
        }

        e.DrawFocusRectangle();
    }

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);

        if (m.Msg == 0x000F)
        {
            using (Graphics g = CreateGraphics())
            using (GraphicsPath path = GetRoundedPath(ClientRectangle, borderRadius))
            using (Pen pen = new Pen(borderColor, borderSize))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                this.Region = new Region(path);
                g.DrawPath(pen, path);
            }
        }
    }

    private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        float curveSize = radius * 2F;

        path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();

        return path;
    }
}
