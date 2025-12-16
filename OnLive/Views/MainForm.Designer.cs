namespace OnLive
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelRoundCorner1 = new PanelRoundCorner();
            labelCreator = new Label();
            labelTitle = new Label();
            labelOnLive = new Label();
            panelSide = new Panel();
            panel1 = new Panel();
            panelSales = new PanelRoundCorner();
            alwaysEnabledLabel1 = new AlwaysEnabledLabel();
            panelClient = new PanelRoundCorner();
            alwaysEnabledLabel2 = new AlwaysEnabledLabel();
            panelCreateTicket = new PanelRoundCorner();
            alwaysEnabledLabel3 = new AlwaysEnabledLabel();
            panelReports = new PanelRoundCorner();
            alwaysEnabledLabel4 = new AlwaysEnabledLabel();
            panelConfig = new PanelRoundCorner();
            alwaysEnabledLabel5 = new AlwaysEnabledLabel();
            panelContainer = new Panel();
            pictureBox1 = new PictureBox();
            panelRoundCorner1.SuspendLayout();
            panelSide.SuspendLayout();
            panelSales.SuspendLayout();
            panelClient.SuspendLayout();
            panelCreateTicket.SuspendLayout();
            panelReports.SuspendLayout();
            panelConfig.SuspendLayout();
            panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelRoundCorner1
            // 
            panelRoundCorner1.BackColor = Color.Transparent;
            panelRoundCorner1.BorderColor = Color.Transparent;
            panelRoundCorner1.BorderRadius = 1;
            panelRoundCorner1.BorderSize = 0;
            panelRoundCorner1.Controls.Add(labelCreator);
            panelRoundCorner1.Controls.Add(labelTitle);
            panelRoundCorner1.Controls.Add(labelOnLive);
            panelRoundCorner1.FillColor = Color.FromArgb(96, 136, 159);
            panelRoundCorner1.Location = new Point(0, 1);
            panelRoundCorner1.Name = "panelRoundCorner1";
            panelRoundCorner1.Size = new Size(1432, 98);
            panelRoundCorner1.TabIndex = 10;
            panelRoundCorner1.Paint += panelRoundCorner1_Paint;
            // 
            // labelCreator
            // 
            labelCreator.AutoSize = true;
            labelCreator.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCreator.ForeColor = Color.White;
            labelCreator.Location = new Point(1189, 18);
            labelCreator.Name = "labelCreator";
            labelCreator.Size = new Size(191, 21);
            labelCreator.TabIndex = 14;
            labelCreator.Text = "Created By Angel Baena";
            labelCreator.Click += labelCreator_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(335, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(343, 33);
            labelTitle.TabIndex = 14;
            labelTitle.Text = "Sales Manager Administrator";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelOnLive
            // 
            labelOnLive.AutoSize = true;
            labelOnLive.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOnLive.ForeColor = Color.White;
            labelOnLive.Location = new Point(23, 18);
            labelOnLive.Name = "labelOnLive";
            labelOnLive.Size = new Size(233, 55);
            labelOnLive.TabIndex = 14;
            labelOnLive.Text = "CheckOut";
            labelOnLive.Click += labelOnLive_Click;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.FromArgb(184, 216, 255);
            panelSide.Controls.Add(panel1);
            panelSide.Controls.Add(panelSales);
            panelSide.Controls.Add(panelClient);
            panelSide.Controls.Add(panelCreateTicket);
            panelSide.Controls.Add(panelReports);
            panelSide.Controls.Add(panelConfig);
            panelSide.Location = new Point(0, 98);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(187, 600);
            panelSide.TabIndex = 12;
            panelSide.Paint += panelSide_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(149, 165, 198);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 77);
            panel1.TabIndex = 0;
            // 
            // panelSales
            // 
            panelSales.BackColor = Color.Transparent;
            panelSales.BorderColor = Color.Transparent;
            panelSales.BorderRadius = 0;
            panelSales.BorderSize = 0;
            panelSales.Controls.Add(alwaysEnabledLabel1);
            panelSales.FillColor = Color.FromArgb(40, 40, 40);
            panelSales.Location = new Point(0, 163);
            panelSales.Margin = new Padding(0);
            panelSales.Name = "panelSales";
            panelSales.Size = new Size(187, 57);
            panelSales.TabIndex = 14;
            panelSales.Click += panelSales_Click;
            panelSales.Paint += panelSales_Paint;
            // 
            // alwaysEnabledLabel1
            // 
            alwaysEnabledLabel1.AutoSize = true;
            alwaysEnabledLabel1.Enabled = false;
            alwaysEnabledLabel1.Font = new Font("Arial", 11F, FontStyle.Bold);
            alwaysEnabledLabel1.Location = new Point(41, 19);
            alwaysEnabledLabel1.Name = "alwaysEnabledLabel1";
            alwaysEnabledLabel1.Size = new Size(109, 18);
            alwaysEnabledLabel1.TabIndex = 0;
            alwaysEnabledLabel1.Text = "Zona De Venta";
            // 
            // panelClient
            // 
            panelClient.BackColor = Color.Transparent;
            panelClient.BorderColor = Color.Transparent;
            panelClient.BorderRadius = 0;
            panelClient.BorderSize = 0;
            panelClient.Controls.Add(alwaysEnabledLabel2);
            panelClient.FillColor = Color.FromArgb(40, 40, 40);
            panelClient.Location = new Point(0, 229);
            panelClient.Margin = new Padding(0);
            panelClient.Name = "panelClient";
            panelClient.Size = new Size(187, 57);
            panelClient.TabIndex = 14;
            panelClient.Click += panelClient_Click;
            panelClient.Paint += panelClient_Paint;
            // 
            // alwaysEnabledLabel2
            // 
            alwaysEnabledLabel2.AutoSize = true;
            alwaysEnabledLabel2.Enabled = false;
            alwaysEnabledLabel2.Font = new Font("Arial", 11F, FontStyle.Bold);
            alwaysEnabledLabel2.Location = new Point(22, 20);
            alwaysEnabledLabel2.Name = "alwaysEnabledLabel2";
            alwaysEnabledLabel2.Size = new Size(144, 18);
            alwaysEnabledLabel2.TabIndex = 15;
            alwaysEnabledLabel2.Text = "Historial de Cliente";
            // 
            // panelCreateTicket
            // 
            panelCreateTicket.BackColor = Color.Transparent;
            panelCreateTicket.BorderColor = Color.Transparent;
            panelCreateTicket.BorderRadius = 0;
            panelCreateTicket.BorderSize = 0;
            panelCreateTicket.Controls.Add(alwaysEnabledLabel3);
            panelCreateTicket.FillColor = Color.FromArgb(40, 40, 40);
            panelCreateTicket.Location = new Point(0, 295);
            panelCreateTicket.Margin = new Padding(0);
            panelCreateTicket.Name = "panelCreateTicket";
            panelCreateTicket.Size = new Size(187, 57);
            panelCreateTicket.TabIndex = 14;
            panelCreateTicket.Click += panelCreateTicket_Click;
            panelCreateTicket.Paint += panelCreateTicket_Paint;
            // 
            // alwaysEnabledLabel3
            // 
            alwaysEnabledLabel3.AutoSize = true;
            alwaysEnabledLabel3.Enabled = false;
            alwaysEnabledLabel3.Font = new Font("Arial", 11F, FontStyle.Bold);
            alwaysEnabledLabel3.Location = new Point(43, 10);
            alwaysEnabledLabel3.Name = "alwaysEnabledLabel3";
            alwaysEnabledLabel3.Size = new Size(106, 36);
            alwaysEnabledLabel3.TabIndex = 15;
            alwaysEnabledLabel3.Text = "Crear Recibo \r\n  De Compra";
            // 
            // panelReports
            // 
            panelReports.BackColor = Color.Transparent;
            panelReports.BorderColor = Color.Transparent;
            panelReports.BorderRadius = 0;
            panelReports.BorderSize = 0;
            panelReports.Controls.Add(alwaysEnabledLabel4);
            panelReports.FillColor = Color.FromArgb(40, 40, 40);
            panelReports.Location = new Point(1, 361);
            panelReports.Margin = new Padding(0);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(187, 57);
            panelReports.TabIndex = 14;
            panelReports.Click += panelReports_Click;
            panelReports.Paint += panelReports_Paint;
            // 
            // alwaysEnabledLabel4
            // 
            alwaysEnabledLabel4.AutoSize = true;
            alwaysEnabledLabel4.Enabled = false;
            alwaysEnabledLabel4.Font = new Font("Arial", 11F, FontStyle.Bold);
            alwaysEnabledLabel4.Location = new Point(59, 19);
            alwaysEnabledLabel4.Name = "alwaysEnabledLabel4";
            alwaysEnabledLabel4.Size = new Size(74, 18);
            alwaysEnabledLabel4.TabIndex = 15;
            alwaysEnabledLabel4.Text = "Reportes";
            // 
            // panelConfig
            // 
            panelConfig.BackColor = Color.Transparent;
            panelConfig.BorderColor = Color.Transparent;
            panelConfig.BorderRadius = 0;
            panelConfig.BorderSize = 0;
            panelConfig.Controls.Add(alwaysEnabledLabel5);
            panelConfig.FillColor = Color.FromArgb(40, 40, 40);
            panelConfig.Location = new Point(0, 502);
            panelConfig.Margin = new Padding(0);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(187, 57);
            panelConfig.TabIndex = 14;
            panelConfig.Click += panelConfig_Click;
            panelConfig.Paint += panelConfig_Paint;
            // 
            // alwaysEnabledLabel5
            // 
            alwaysEnabledLabel5.AutoSize = true;
            alwaysEnabledLabel5.Enabled = false;
            alwaysEnabledLabel5.Font = new Font("Arial", 11F, FontStyle.Bold);
            alwaysEnabledLabel5.Location = new Point(41, 20);
            alwaysEnabledLabel5.Name = "alwaysEnabledLabel5";
            alwaysEnabledLabel5.Size = new Size(108, 18);
            alwaysEnabledLabel5.TabIndex = 15;
            alwaysEnabledLabel5.Text = "Configuracion";
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.Control;
            panelContainer.Controls.Add(pictureBox1);
            panelContainer.Location = new Point(187, 98);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1245, 600);
            panelContainer.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(77, 150);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(1432, 698);
            Controls.Add(panelContainer);
            Controls.Add(panelSide);
            Controls.Add(panelRoundCorner1);
            ForeColor = Color.White;
            MaximizeBox = false;
            MaximumSize = new Size(1448, 737);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "On Live";
            Load += MainForm_Load;
            panelRoundCorner1.ResumeLayout(false);
            panelRoundCorner1.PerformLayout();
            panelSide.ResumeLayout(false);
            panelSales.ResumeLayout(false);
            panelSales.PerformLayout();
            panelClient.ResumeLayout(false);
            panelClient.PerformLayout();
            panelCreateTicket.ResumeLayout(false);
            panelCreateTicket.PerformLayout();
            panelReports.ResumeLayout(false);
            panelReports.PerformLayout();
            panelConfig.ResumeLayout(false);
            panelConfig.PerformLayout();
            panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PanelRoundCorner panelRoundCorner1;
        private Panel panelSide;
        private Label labelOnLive;
        private Label labelTitle;
        private Label labelCreator;
        private PanelRoundCorner panelConfig;
        private PanelRoundCorner panelReports;
        private PanelRoundCorner panelCreateTicket;
        private PanelRoundCorner panelSales;
        private PanelRoundCorner panelClient;
        private Panel panelContainer;
        private Panel panel1;
        private AlwaysEnabledLabel alwaysEnabledLabel1;
        private AlwaysEnabledLabel alwaysEnabledLabel5;
        private AlwaysEnabledLabel alwaysEnabledLabel2;
        private AlwaysEnabledLabel alwaysEnabledLabel3;
        private AlwaysEnabledLabel alwaysEnabledLabel4;
        private PictureBox pictureBox1;
    }
}
