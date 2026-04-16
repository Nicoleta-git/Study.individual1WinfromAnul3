using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CirclePanel : Panel
{
    private Color _borderColor = Color.RoyalBlue;
    private float _borderSize = 2;
    private Image _image = null;

    // Custom properties to show in the Designer
    public Color BorderColor
    {
        get => _borderColor;
        set { _borderColor = value; Invalidate(); }
    }

    public float BorderSize
    {
        get => _borderSize;
        set { _borderSize = value; Invalidate(); }
    }

    public Image Image
    {
        get => _image;
        set { _image = value; Invalidate(); }
    }

    public CirclePanel()
    {
        this.DoubleBuffered = true;
        this.Size = new Size(150, 150);
        this.BackColor = Color.Transparent;
    }

    protected override void OnResize(EventArgs eventargs)
    {
        base.OnResize(eventargs);
        // Force square shape
        this.Height = this.Width;

        // Apply the circular mask to the panel itself
        using (GraphicsPath gp = new GraphicsPath())
        {
            gp.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(gp);
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;

        // 1. Fill the circle background
        using (SolidBrush brush = new SolidBrush(this.BackColor))
        {
            g.FillEllipse(brush, 0, 0, this.Width, this.Height);
        }

        // 2. Draw the image IF it exists (This replaces your PictureBox)
        if (_image != null)
        {
            // This draws the image to fit the circle perfectly
            g.DrawImage(_image, 0, 0, this.Width, this.Height);
        }

        // 3. Draw the border ON TOP of the image
        if (_borderSize > 0)
        {
            float offset = _borderSize / 2;
            using (Pen penBorder = new Pen(_borderColor, _borderSize))
            {
                penBorder.Alignment = PenAlignment.Inset;
                g.DrawEllipse(penBorder, offset, offset, this.Width - _borderSize, this.Height - _borderSize);
            }
        }
    }
}