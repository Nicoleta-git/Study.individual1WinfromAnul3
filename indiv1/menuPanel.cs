using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class menuPanel : Panel
{
    public int BorderRadius { get; set; } = 30; // raza colturilor

    public menuPanel()
    {
        this.BackColor = Color.LightBlue; // culoarea implicita
        this.ResizeRedraw = true;          // redraw la resize
        this.BorderStyle = BorderStyle.None; // elimina border-ul standard

    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // linii netede

        int inset = 1; // evita linia fina
        int r = BorderRadius;

        using (GraphicsPath path = new GraphicsPath())
        {
            path.StartFigure();

            // Linie top + colt dreapta-sus
            path.AddLine(inset, inset, Width - r - inset, inset);
            path.AddArc(Width - r - inset, inset, r, r, 270, 90);

            // Linie dreapta + colt dreapta-jos
            path.AddLine(Width - inset, r + inset, Width - inset, Height - r - inset);
            path.AddArc(Width - r - inset, Height - r - inset, r, r, 0, 90);

            // Linie jos + linie stanga
            path.AddLine(Width - r - inset, Height - inset, inset, Height - inset);
            path.AddLine(inset, Height - inset, inset, inset);

            path.CloseFigure();

            // definim forma vizibila si clickable
            this.Region = new Region(path);
        }
    }
}
