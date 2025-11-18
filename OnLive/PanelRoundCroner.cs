using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLive
{
    class PanelRoundCroner: Panel
    {
        //Fields
        private int borderRadius = 30;
        private float gradientAngle = 90F;
        private Color gradientTopColor = Color.DodgerBlue;
        private Color gradientBottomColor = Color.CadetBlue;
        //Constructor
        public PanelRoundCroner(){
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.Size = new Size(350, 200);
        }
        //Propities
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
        public float GradientAngle { get => gradientAngle; set { gradientAngle = value; this.Invalidate(); } }
        public Color GradientTopColor { get => gradientTopColor; set { gradientTopColor = value; this.Invalidate(); } }
        public Color GradientBottomColor { get => gradientTopColor; set { gradientTopColor = value; this.Invalidate(); } }
        //Methods
        private GraphicsPath GetPath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            graphicsPath.CloseFigure();
            return graphicsPath;
        }
        //Overridden Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Gradient
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush brushPanel = new LinearGradientBrush(this.ClientRectangle, this.GradientTopColor, this.gradientBottomColor, this.gradientAngle); ;
            Graphics graphicsPanel = e.Graphics;
            graphicsPanel.FillRectangle(brushPanel, ClientRectangle);
            //BorderRadius
            RectangleF rectangleF = new Rectangle(0, 0, this.Width, this.Height);
            if (borderRadius > 2)
            {
                using (GraphicsPath graphicsPath = GetPath(rectangleF, borderRadius))
                using (Pen pen = new Pen(this.Parent.BackColor, 2))
                {
                    this.Region = new Region(graphicsPath);
                    e.Graphics.DrawPath(pen, graphicsPath);
                }
            }
            else this.Region = new Region(rectangleF);
        }
    }
}
