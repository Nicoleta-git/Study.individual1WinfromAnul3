using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedPanel : Panel
{
    public int BorderRadius { get; set; } = 30; // raza colturilor

    public RoundedPanel()
    {
        this.BackColor = Color.LightBlue; // culoarea implicita
        this.ResizeRedraw = true;          // redraw la resize
        this.BorderStyle = BorderStyle.None; // elimina border-ul standard

    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // linii netede

        int inset = 1; // mic inset pentru a evita linia
        int r = BorderRadius;

        // creeaza path-ul pentru colturi rotunjite
        using (GraphicsPath path = new GraphicsPath())
        {
            path.StartFigure();
            path.AddArc(inset, inset, r, r, 180, 90); // colt stanga-sus
            path.AddArc(Width - r - inset, inset, r, r, 270, 90); // colt dreapta-sus
            path.AddArc(Width - r - inset, Height - r - inset, r, r, 0, 90); // colt dreapta-jos
            path.AddArc(inset, Height - r - inset, r, r, 90, 90); // colt stanga-jos
            path.CloseFigure();

            // definim zona vizibila si clickable
            this.Region = new Region(path);
        }
    }
}
