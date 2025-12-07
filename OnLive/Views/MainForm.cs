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
            this.MinimumSize = new Size(1448, 737);
            this.MaximumSize = new Size(1448, 737);
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
            if (salesZone == null)
            {
                salesZone = new SaleZoneForm();
                salesZone.FormClosed += SalesZone_FormClosed;
                salesZone.MdiParent = this;
                salesZone.Show();
            }
            else { salesZone.Activate(); }
        }
        private void SalesZone_FormClosed(object? sender, FormClosedEventArgs e)
        {
            salesZone = null;
        }
        private void panelClient_Click(object sender, EventArgs e)
        {
            if (userHistory == null)
            {
                userHistory = new UserHistoryForm();
                userHistory.FormClosed += UserHistory_FormClosed;
                userHistory.MdiParent = this;
                userHistory.Show();
            }
            else { userHistory.Activate(); }
        }
        private void UserHistory_FormClosed(object? sender, FormClosedEventArgs e)
        {
            userHistory = null;
        }
        private void panelCreateTicket_Click(object sender, EventArgs e)
        {
            if (createTicket == null)
            {
                createTicket = new CreateTicketForm();
                createTicket.FormClosed += CreateTicket_FormClosed;
                createTicket.MdiParent = this;
                createTicket.Show();
            }
            else { createTicket.Activate(); }
        }
        private void CreateTicket_FormClosed(object? sender, FormClosedEventArgs e)
        {
            createTicket = null;
        }
        private void panelReports_Click(object sender, EventArgs e)
        {
            if (reports == null)
            {
                reports = new ReportsForm();
                reports.FormClosed += Reports_FormClosed;
                reports.MdiParent = this;
                reports.Show();
            }
            else { reports.Activate(); }
        }
        private void Reports_FormClosed(object? sender, FormClosedEventArgs e)
        {
            reports = null;
        }
        private void panelConfig_Click(object sender, EventArgs e)
        {
            if(config == null)
            {
                config = new ConfigForm();
                config.FormClosed += Config_FormClosed;
                config.MdiParent = this;
                config.Show();
            }
            else { config.Activate(); }
        }
        private void Config_FormClosed(object? sender, FormClosedEventArgs e)
        {
            config = null;
        }
    }
}
