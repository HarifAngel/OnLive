using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnLive.Views
{
    public partial class ReportsForm : Form
    {
        MainForm mainForm;
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            mainForm = new MainForm();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((mainForm.ClientSize.Width - this.Width) / 2, (this.ClientSize.Height - this.Height) / 2);
        }
    }
}
