using OnLive.Views;

namespace OnLive
{
    public partial class MainForm : Form
    {
        //Declaring forms
        SaleZoneForm salesZone;
        UserHistoryForm userHistory;
        CreateTicketForm createTicket;
        ReportsForm reports;
        ConfigForm config;
        public MainForm()
        {
            InitializeComponent();
        }
        //load form function
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (panelContainer == null)
                MessageBox.Show("panelContainer es NULL");
        }
        private void LoadForm(Form form)
        {
            if (form == null)
                throw new ArgumentNullException(nameof(form));

            panelContainer.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(form);
            form.Show();
        }
        //some componets empty functions
        private void panelRoundCorner1_Paint(object sender, PaintEventArgs e){ }
        private void labelOnLive_Click(object sender, EventArgs e){ }
        private void labelTitle_Click(object sender, EventArgs e){ }
        private void labelCreator_Click(object sender, EventArgs e){ }
        private void panelConfig_Paint(object sender, PaintEventArgs e){ }
        private void panelSales_Paint(object sender, PaintEventArgs e){ }
        private void panelSide_Paint(object sender, PaintEventArgs e){ }
        private void panelClient_Paint(object sender, PaintEventArgs e){ }
        private void panelCreateTicket_Paint(object sender, PaintEventArgs e){ }
        private void panelReports_Paint(object sender, PaintEventArgs e){ }
        private void label5_Click(object sender, EventArgs e){ }
        //Click panels action
        private void panelSales_Click(object sender, EventArgs e)
        {
            if (salesZone == null || salesZone.IsDisposed)
                salesZone = new SaleZoneForm();

            LoadForm(salesZone);
        }
        private void panelClient_Click(object sender, EventArgs e)
        {
            if (userHistory == null || userHistory.IsDisposed)
                userHistory = new UserHistoryForm();

            LoadForm(userHistory);
        }
        private void panelCreateTicket_Click(object sender, EventArgs e)
        {
            if (createTicket == null || createTicket.IsDisposed)
                createTicket = new CreateTicketForm();

            LoadForm(createTicket);
        }
        private void panelReports_Click(object sender, EventArgs e)
        {
            if (reports == null || reports.IsDisposed)
                reports = new ReportsForm();

            LoadForm(reports);
        }
        private void panelConfig_Click(object sender, EventArgs e)
        {
            if (config == null || config.IsDisposed)
                config = new ConfigForm();

            LoadForm(config);
        }
        
    }
}
