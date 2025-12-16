using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLive
{
    public class AlwaysEnabledLabel : Label
    {
        public AlwaysEnabledLabel()
        {
            // Let Windows repaint the label
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Use the normal color even when Enabled = false
            TextRenderer.DrawText(e.Graphics, this.Text, this.Font,
            e.ClipRectangle, this.ForeColor, this.BackColor,
            TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
        }
    }
}
