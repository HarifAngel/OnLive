using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLive
{
    public class PanelRoundCorner : Panel
    {
        // Fields
        private int borderRadius = 30;
        private Color fillColor = Color.DodgerBlue;
        private Color borderColor = Color.Transparent;
        private int borderSize = 0;

        // Constructor
        public PanelRoundCorner()
        {
            this.BackColor = Color.Transparent; // mantiene fondo del padre si quieres ver el region
            this.Size = new Size(350, 200);
            this.DoubleBuffered = true;
        }

        // Properties
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = Math.Max(0, value); Invalidate(); }
        }

        public Color FillColor
        {
            get => fillColor;
            set { fillColor = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        public int BorderSize
        {
            get => borderSize;
            set { borderSize = Math.Max(0, value); Invalidate(); }
        }

        // Create rounded path
        private GraphicsPath GetRoundedPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0f)
            {
                path.AddRectangle(rect);
                path.CloseFigure();
                return path;
            }

            float diameter = radius * 2f;
            // Ensure diameter does not exceed rect size
            if (diameter > rect.Width) diameter = rect.Width;
            if (diameter > rect.Height) diameter = rect.Height;
            float rx = rect.X;
            float ry = rect.Y;
            float rw = rect.Width;
            float rh = rect.Height;

            path.StartFigure();
            path.AddArc(rx, ry, diameter, diameter, 180, 90);                             // top-left
            path.AddArc(rx + rw - diameter, ry, diameter, diameter, 270, 90);             // top-right
            path.AddArc(rx + rw - diameter, ry + rh - diameter, diameter, diameter, 0, 90); // bottom-right
            path.AddArc(rx, ry + rh - diameter, diameter, diameter, 90, 90);             // bottom-left
            path.CloseFigure();

            return path;
        }

        // Paint
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);

            using (GraphicsPath path = GetRoundedPath(rect, borderRadius))
            {
                // Fill
                using (SolidBrush brush = new SolidBrush(fillColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Optional border
                if (borderSize > 0)
                {
                    using (Pen pen = new Pen(borderColor, borderSize))
                    {
                        // Ajustar el trazado del borde para que quede dentro del control
                        pen.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawPath(pen, path);
                    }
                }

                // Set region so control clicks/hit-test follow rounded shape
                this.Region = new Region(path);
            }
        }

        // Ensure region updates on resize
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }
    }
}
