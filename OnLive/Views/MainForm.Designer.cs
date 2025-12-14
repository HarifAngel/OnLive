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
            panelSales = new PanelRoundCorner();
            label1 = new Label();
            panelClient = new PanelRoundCorner();
            label2 = new Label();
            panelCreateTicket = new PanelRoundCorner();
            label3 = new Label();
            panelReports = new PanelRoundCorner();
            label4 = new Label();
            panelConfig = new PanelRoundCorner();
            label5 = new Label();
            panelContainer = new Panel();
            panelRoundCorner1.SuspendLayout();
            panelSide.SuspendLayout();
            panelSales.SuspendLayout();
            panelClient.SuspendLayout();
            panelCreateTicket.SuspendLayout();
            panelReports.SuspendLayout();
            panelConfig.SuspendLayout();
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
            panelSide.BackColor = SystemColors.ActiveCaption;
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
            // panelSales
            // 
            panelSales.BackColor = Color.Transparent;
            panelSales.BorderColor = Color.Transparent;
            panelSales.BorderRadius = 0;
            panelSales.BorderSize = 0;
            panelSales.Controls.Add(label1);
            panelSales.FillColor = Color.FromArgb(40, 40, 40);
            panelSales.Location = new Point(0, 92);
            panelSales.Margin = new Padding(0);
            panelSales.Name = "panelSales";
            panelSales.Size = new Size(187, 57);
            panelSales.TabIndex = 14;
            panelSales.Click += panelSales_Click;
            panelSales.Paint += panelSales_Paint;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.StaticText;
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Arial", 11F, FontStyle.Bold);
            label1.Location = new Point(41, 20);
            label1.Name = "label1";
            label1.Size = new Size(109, 18);
            label1.TabIndex = 14;
            label1.Text = "Zona De Venta";
            // 
            // panelClient
            // 
            panelClient.BackColor = Color.Transparent;
            panelClient.BorderColor = Color.Transparent;
            panelClient.BorderRadius = 0;
            panelClient.BorderSize = 0;
            panelClient.Controls.Add(label2);
            panelClient.FillColor = Color.FromArgb(40, 40, 40);
            panelClient.Location = new Point(1, 158);
            panelClient.Margin = new Padding(0);
            panelClient.Name = "panelClient";
            panelClient.Size = new Size(186, 57);
            panelClient.TabIndex = 14;
            panelClient.Click += panelClient_Click;
            panelClient.Paint += panelClient_Paint;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.StaticText;
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Arial", 11F, FontStyle.Bold);
            label2.Location = new Point(23, 20);
            label2.Name = "label2";
            label2.Size = new Size(144, 18);
            label2.TabIndex = 15;
            label2.Text = "Historial de Cliente";
            // 
            // panelCreateTicket
            // 
            panelCreateTicket.BackColor = Color.Transparent;
            panelCreateTicket.BorderColor = Color.Transparent;
            panelCreateTicket.BorderRadius = 0;
            panelCreateTicket.BorderSize = 0;
            panelCreateTicket.Controls.Add(label3);
            panelCreateTicket.FillColor = Color.FromArgb(40, 40, 40);
            panelCreateTicket.Location = new Point(1, 224);
            panelCreateTicket.Margin = new Padding(0);
            panelCreateTicket.Name = "panelCreateTicket";
            panelCreateTicket.Size = new Size(186, 57);
            panelCreateTicket.TabIndex = 14;
            panelCreateTicket.Click += panelCreateTicket_Click;
            panelCreateTicket.Paint += panelCreateTicket_Paint;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.StaticText;
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Arial", 11F, FontStyle.Bold);
            label3.Location = new Point(41, 11);
            label3.Name = "label3";
            label3.Size = new Size(106, 36);
            label3.TabIndex = 15;
            label3.Text = "Crear Recibo \r\n  de Compra";
            // 
            // panelReports
            // 
            panelReports.BackColor = Color.Transparent;
            panelReports.BorderColor = Color.Transparent;
            panelReports.BorderRadius = 0;
            panelReports.BorderSize = 0;
            panelReports.Controls.Add(label4);
            panelReports.FillColor = Color.FromArgb(40, 40, 40);
            panelReports.Location = new Point(1, 290);
            panelReports.Margin = new Padding(0);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(186, 57);
            panelReports.TabIndex = 14;
            panelReports.Click += panelReports_Click;
            panelReports.Paint += panelReports_Paint;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.StaticText;
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Arial", 11F, FontStyle.Bold);
            label4.Location = new Point(58, 18);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 15;
            label4.Text = "Reportes";
            // 
            // panelConfig
            // 
            panelConfig.BackColor = Color.Transparent;
            panelConfig.BorderColor = Color.Transparent;
            panelConfig.BorderRadius = 0;
            panelConfig.BorderSize = 0;
            panelConfig.Controls.Add(label5);
            panelConfig.FillColor = Color.FromArgb(40, 40, 40);
            panelConfig.Location = new Point(0, 488);
            panelConfig.Margin = new Padding(0);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(187, 57);
            panelConfig.TabIndex = 14;
            panelConfig.Click += panelConfig_Click;
            panelConfig.Paint += panelConfig_Paint;
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.StaticText;
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Font = new Font("Arial", 11F, FontStyle.Bold);
            label5.Location = new Point(41, 20);
            label5.Name = "label5";
            label5.Size = new Size(108, 18);
            label5.TabIndex = 15;
            label5.Text = "Configuracion";
            label5.Click += label5_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.AppWorkspace;
            panelContainer.Location = new Point(187, 98);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1245, 600);
            panelContainer.TabIndex = 20;
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
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Panel panelContainer;
    }
}
