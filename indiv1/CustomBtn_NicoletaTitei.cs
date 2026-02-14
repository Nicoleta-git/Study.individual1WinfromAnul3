using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace NicoletaCustomBtn
{
    public class CustomBtn_NicoletaTitei : Button
    {
        // Fields
        private int borderSize = 0;
        private int borderRadius = 50;
        private Color borderColor = Color.FromArgb(69, 69, 74); // culoarea bordurii

        // Properties

        // setters & getters
        public int BorderSize
        {
            get => borderSize; // lambda function
            set { borderSize = value; Invalidate(); } // actualizeaza aspectul vizual; necesita redraw
        }

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); } // actualizeaza aspectul vizual
        }

        public Color BackgroundColor
        {
            get => BackColor;
            set { BackColor = value; } // seteaza culoarea de fundal
        }
        public Color TextColor
        {
            get => ForeColor;
            set { ForeColor = value; } // seteaza culoarea textului
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }


        // Constructor
        public CustomBtn_NicoletaTitei()
        {
            Size = new Size(200, 100); // dimensiunea implicita a butonului
            FlatAppearance.BorderSize = 0; // fara bordura standard
            FlatStyle = FlatStyle.Flat; // stil plat
            BackColor = Color.DodgerBlue; // culoare fundal implicit
            ForeColor = Color.White; // culoare text implicit

            Resize += new EventHandler(Button_Resize); // conecteaza evenimentul Resize
        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > Height) // daca raza colturilor e mai mare decat inaltimea
                borderRadius = Height; // limiteaza raza colturilor
        }

        // Metoda pentru crearea unui GraphicsPath
        private GraphicsPath GetFigurepath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath(); // creeaza un path gol
            graphicsPath.StartFigure(); // incepe o figura noua
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            // coltul stanga-sus: incepe de la stanga si face sweep 90° clockwise
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            // coltul dreapta-sus: incepe de sus si face sweep 90° clockwise
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            // coltul dreapta-jos
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            // inchide figura
            graphicsPath.CloseFigure();

            return graphicsPath; // returneaza path-ul
        }

        // OnPaint controleaza cum se deseneaza controlul
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent); // se asigura ca se face desenarea standard
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias; // face liniile netede

            RectangleF rectangleSurface = new RectangleF(0, 0, Width, Height); // zona completa a controlului
            RectangleF rectangleBorder = new RectangleF(1, 1, Width - 0.5F, Height - 1); // putin mai mic pentru bordura

            if (borderRadius > 1) // are colturi rotunjite
            {
                using (GraphicsPath graphicsPathSurface = GetFigurepath(rectangleSurface, borderRadius)) // creeaza buton cu colturi rotunjite
                using (GraphicsPath graphicsPathBorder = GetFigurepath(rectangleBorder, borderRadius - 1F)) // bordura putin mai mica
                using (Pen penSurface = new Pen(Parent.BackColor, 2)) // pen pentru a acoperi eventuale margini anti-alias
                using (Pen penBorder = new Pen(borderColor, borderSize)) // pen pentru bordura vizibila
                {
                    penBorder.Alignment = PenAlignment.Inset; // pen-ul se va desena in interiorul formei
                    Region = new Region(graphicsPathSurface); // definesc zona clickabila si vizibila
                    pevent.Graphics.DrawPath(penBorder, graphicsPathSurface); // deseneaza marginea externa

                    if (borderSize >= 1) // daca bordura exista
                        pevent.Graphics.DrawPath(penBorder, graphicsPathBorder); // deseneaza bordura
                }
            }
            else // fara colturi rotunjite
            {
                Region = new Region(rectangleSurface); // zona clickabila = dreptunghi complet
                if (borderSize >= 1)
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset; // bordura desenata in interior
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1); // deseneaza dreptunghiul
                    }
            }
        }

        // OnHandleCreated se executa dupa ce controlul primeste Windows handle (ID)
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e); // apeleaza implementarea standard
            // de fiecare data cand culoarea de fundal a parintelui se schimba
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged); // conecteaza metoda mea la eveniment
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (DesignMode) Invalidate(); // spune controlului sa se redeseneze
        }
    }
}
