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
    public partial class CreateTicketForm : Form
    {
        public CreateTicketForm()
        {
            InitializeComponent();
        }

        private void CreateTicketForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
