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
            button3 = new Button();
            panelClient = new PanelRoundCorner();
            button4 = new Button();
            panelCreateTicket = new PanelRoundCorner();
            button1 = new Button();
            panelReports = new PanelRoundCorner();
            button5 = new Button();
            panelConfig = new PanelRoundCorner();
            button6 = new Button();
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
            labelTitle.Location = new Point(290, 27);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(213, 33);
            labelTitle.TabIndex = 14;
            labelTitle.Text = "Gestor De Ventas";
            labelTitle.Click += labelTitle_Click;
            // 
            // labelOnLive
            // 
            labelOnLive.AutoSize = true;
            labelOnLive.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOnLive.ForeColor = Color.White;
            labelOnLive.Location = new Point(23, 18);
            labelOnLive.Name = "labelOnLive";
            labelOnLive.Size = new Size(177, 55);
            labelOnLive.TabIndex = 14;
            labelOnLive.Text = "OnLive";
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
            panelSales.Controls.Add(button3);
            panelSales.FillColor = Color.FromArgb(40, 40, 40);
            panelSales.Location = new Point(0, 52);
            panelSales.Margin = new Padding(0);
            panelSales.Name = "panelSales";
            panelSales.Size = new Size(186, 57);
            panelSales.TabIndex = 14;
            panelSales.Paint += panelSales_Paint;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(23, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(139, 57);
            button3.TabIndex = 4;
            button3.Text = "Zona de Venta";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panelClient
            // 
            panelClient.BackColor = Color.Transparent;
            panelClient.BorderColor = Color.Transparent;
            panelClient.BorderRadius = 0;
            panelClient.BorderSize = 0;
            panelClient.Controls.Add(button4);
            panelClient.FillColor = Color.FromArgb(40, 40, 40);
            panelClient.Location = new Point(0, 147);
            panelClient.Margin = new Padding(0);
            panelClient.Name = "panelClient";
            panelClient.Size = new Size(186, 57);
            panelClient.TabIndex = 14;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(23, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Padding = new Padding(5, 0, 0, 0);
            button4.Size = new Size(139, 57);
            button4.TabIndex = 4;
            button4.Text = "Historial de Cliente";
            button4.UseVisualStyleBackColor = false;
            // 
            // panelCreateTicket
            // 
            panelCreateTicket.BackColor = Color.Transparent;
            panelCreateTicket.BorderColor = Color.Transparent;
            panelCreateTicket.BorderRadius = 0;
            panelCreateTicket.BorderSize = 0;
            panelCreateTicket.Controls.Add(button1);
            panelCreateTicket.FillColor = Color.FromArgb(40, 40, 40);
            panelCreateTicket.Location = new Point(0, 221);
            panelCreateTicket.Margin = new Padding(0);
            panelCreateTicket.Name = "panelCreateTicket";
            panelCreateTicket.Size = new Size(186, 57);
            panelCreateTicket.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(139, 57);
            button1.TabIndex = 4;
            button1.Text = "Crear Recibo   de Compra";
            button1.UseVisualStyleBackColor = false;
            // 
            // panelReports
            // 
            panelReports.BackColor = Color.Transparent;
            panelReports.BorderColor = Color.Transparent;
            panelReports.BorderRadius = 0;
            panelReports.BorderSize = 0;
            panelReports.Controls.Add(button5);
            panelReports.FillColor = Color.FromArgb(40, 40, 40);
            panelReports.Location = new Point(0, 297);
            panelReports.Margin = new Padding(0);
            panelReports.Name = "panelReports";
            panelReports.Size = new Size(186, 57);
            panelReports.TabIndex = 14;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(23, 0);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(139, 57);
            button5.TabIndex = 4;
            button5.Text = "Reportes";
            button5.UseVisualStyleBackColor = false;
            // 
            // panelConfig
            // 
            panelConfig.BackColor = Color.Transparent;
            panelConfig.BorderColor = Color.Transparent;
            panelConfig.BorderRadius = 0;
            panelConfig.BorderSize = 0;
            panelConfig.Controls.Add(button6);
            panelConfig.FillColor = Color.FromArgb(40, 40, 40);
            panelConfig.Location = new Point(0, 450);
            panelConfig.Margin = new Padding(0);
            panelConfig.Name = "panelConfig";
            panelConfig.Size = new Size(186, 57);
            panelConfig.TabIndex = 14;
            panelConfig.Paint += panelConfig_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(23, 0);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(139, 57);
            button6.TabIndex = 4;
            button6.Text = "Configuracion";
            button6.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 698);
            Controls.Add(panelSide);
            Controls.Add(panelRoundCorner1);
            ForeColor = Color.White;
            IsMdiContainer = true;
            Name = "MainForm";
            Text = "On Live";
            Load += MainForm_Load;
            panelRoundCorner1.ResumeLayout(false);
            panelRoundCorner1.PerformLayout();
            panelSide.ResumeLayout(false);
            panelSales.ResumeLayout(false);
            panelClient.ResumeLayout(false);
            panelCreateTicket.ResumeLayout(false);
            panelReports.ResumeLayout(false);
            panelConfig.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PanelRoundCorner panelRoundCorner1;
        private Panel panelSide;
        private Label labelOnLive;
        private Label labelTitle;
        private Label labelCreator;
        private PanelRoundCorner panelConfig;
        private Button button6;
        private PanelRoundCorner panelReports;
        private Button button5;
        private PanelRoundCorner panelCreateTicket;
        private Button button1;
        private PanelRoundCorner panelSales;
        private Button button3;
        private PanelRoundCorner panelClient;
        private Button button4;
    }
}
