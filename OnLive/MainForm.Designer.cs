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
            sidePanel = new Panel();
            panel1 = new Panel();
            topPanel = new Panel();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(96, 159, 151);
            sidePanel.Location = new Point(25, 90);
            sidePanel.Margin = new Padding(0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(162, 590);
            sidePanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 48, 79);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 61);
            panel1.TabIndex = 2;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(96, 136, 159);
            topPanel.Location = new Point(157, 12);
            topPanel.Margin = new Padding(0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1262, 61);
            topPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1428, 698);
            Controls.Add(panel1);
            Controls.Add(topPanel);
            Controls.Add(sidePanel);
            Name = "MainForm";
            Text = "OnLive";
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel topPanel;
        private Panel panel1;
    }
}
