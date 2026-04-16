using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace indiv1
{
    public class NeonMenuStrip : MenuStrip
    {
        public NeonMenuStrip()
        {
            this.Renderer = new NeonRenderer();
            this.BackColor = Color.FromArgb(20, 20, 20);
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        private class NeonRenderer : ToolStripProfessionalRenderer
        {
            public NeonRenderer() : base(new NeonColorTable()) { }

            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (e.Item.Selected)
                {
                    Rectangle rect = new Rectangle(Point.Empty, e.Item.Size);
                    using (LinearGradientBrush brush = new LinearGradientBrush(rect,
                           Color.FromArgb(80, 0, 80), Color.FromArgb(30, 0, 30), 90f))
                    {
                        e.Graphics.FillRectangle(brush, rect);
                    }
                    using (Pen pen = new Pen(Color.FromArgb(255, 0, 255)))
                    {
                        e.Graphics.DrawRectangle(pen, 0, 0, rect.Width - 1, rect.Height - 1);
                    }
                }
                else if (e.Item.Pressed)
                {
                    base.OnRenderMenuItemBackground(e);
                }
            }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                e.TextColor = Color.White;
                base.OnRenderItemText(e);
            }

            protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
            {
                e.ArrowColor = Color.FromArgb(255, 0, 255);
                base.OnRenderArrow(e);
            }
        }

        private class NeonColorTable : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground => Color.FromArgb(25, 25, 25);
            public override Color MenuBorder => Color.FromArgb(100, 0, 100);
            public override Color MenuItemBorder => Color.Transparent;
            public override Color MenuItemSelected => Color.FromArgb(60, 0, 60);
            public override Color ImageMarginGradientBegin => Color.FromArgb(30, 30, 30);
            public override Color ImageMarginGradientMiddle => Color.FromArgb(35, 35, 35);
            public override Color ImageMarginGradientEnd => Color.FromArgb(40, 40, 40);
            public override Color SeparatorDark => Color.FromArgb(80, 0, 80);
        }
    }
}