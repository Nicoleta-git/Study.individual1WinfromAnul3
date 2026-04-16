using System;
using System.Drawing;
using System.Windows.Forms;

namespace indiv1
{
    public class DarwinTabControl : TabControl
    {
        // Culori din schema ta de design (Negru & Violet)
        private Color _backColor = Color.FromArgb(15, 15, 15);
        private Color _tabColor = Color.FromArgb(30, 30, 30);
        private Color _selectedTabColor = Color.FromArgb(64, 0, 64);
        private Color _accentColor = Color.MediumPurple;

        public DarwinTabControl()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.SizeMode = TabSizeMode.Fixed;
            this.ItemSize = new Size(130, 35);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
        }

        // Aceasta metoda elimina marginea alba/gri din jurul tab-urilor
        protected override void OnPaint(PaintEventArgs e)
        {
            // Vopsim fundalul complet in negru
            e.Graphics.Clear(_backColor);

            // Desenam paginile (tab-urile propriu-zise)
            for (int i = 0; i < this.TabCount; i++)
            {
                Rectangle rect = this.GetTabRect(i);
                bool isSelected = (this.SelectedIndex == i);

                // Alegem culorile in functie de stare
                Color currentBackColor = isSelected ? _selectedTabColor : _tabColor;
                Color currentTextColor = isSelected ? Color.White : Color.Gray;

                // Desenam fundalul tab-ului
                using (SolidBrush br = new SolidBrush(currentBackColor))
                {
                    e.Graphics.FillRectangle(br, rect);
                }

                // Daca e selectat, desenam linia de accent violet dedesubt
                if (isSelected)
                {
                    using (Pen p = new Pen(_accentColor, 3))
                    {
                        e.Graphics.DrawLine(p, rect.X, rect.Bottom - 1, rect.Right, rect.Bottom - 1);
                    }
                }

                // Desenam textul
                TextRenderer.DrawText(e.Graphics, this.TabPages[i].Text, this.Font, rect, currentTextColor,
                                     TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }

            // Desenam o bordura violet subtila in jurul zonei de continut
            using (Pen p = new Pen(_selectedTabColor, 1))
            {
                Rectangle contentRect = this.DisplayRectangle;
                contentRect.Inflate(1, 1);
                e.Graphics.DrawRectangle(p, contentRect);
            }
        }

        // Prevenim "licarirea" (flicker) cand schimbi tab-urile
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Nu apelam base pentru a evita redesenarea fundalului standard Windows
        }
    }
}