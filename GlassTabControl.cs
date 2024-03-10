using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnForms1
{
    public class GlassTabControl : TabControl
    {
        private TextureBrush backgroundBrush;

        public GlassTabControl()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SizeMode = TabSizeMode.Fixed;
            this.ItemSize = new Size(0, 1);
            SetBackground();
        }

        private void SetBackground()
        {
            if (Parent != null)
            {
                Bitmap bmp = new Bitmap(Parent.Width, Parent.Height);
                Parent.DrawToBitmap(bmp, Parent.ClientRectangle);
                RectangleF bmpRect = new RectangleF(0, 0, bmp.Width, bmp.Height);
                backgroundBrush = new TextureBrush(bmp);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (backgroundBrush != null)
            {
                e.Graphics.FillRectangle(backgroundBrush, ClientRectangle);
            }

            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Переопределяем метод, чтобы ничего не делать.
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x000F)
            {
                SetBackground();
                Invalidate();
            }
        }
    }
}
