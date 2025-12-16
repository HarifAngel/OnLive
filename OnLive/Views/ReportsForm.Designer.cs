namespace OnLive.Views
{
    partial class ReportsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            alwaysEnabledLabel2 = new AlwaysEnabledLabel();
            panel2 = new Panel();
            alwaysEnabledLabel1 = new AlwaysEnabledLabel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(79, 104, 146);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1245, 77);
            panel1.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 31, 56);
            panel3.Controls.Add(alwaysEnabledLabel2);
            panel3.Location = new Point(591, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 57);
            panel3.TabIndex = 19;
            // 
            // alwaysEnabledLabel2
            // 
            alwaysEnabledLabel2.AutoSize = true;
            alwaysEnabledLabel2.Enabled = false;
            alwaysEnabledLabel2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            alwaysEnabledLabel2.ForeColor = Color.White;
            alwaysEnabledLabel2.Location = new Point(52, 18);
            alwaysEnabledLabel2.Name = "alwaysEnabledLabel2";
            alwaysEnabledLabel2.Size = new Size(136, 20);
            alwaysEnabledLabel2.TabIndex = 20;
            alwaysEnabledLabel2.Text = "Ventas Por Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 31, 56);
            panel2.Controls.Add(alwaysEnabledLabel1);
            panel2.Location = new Point(342, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 57);
            panel2.TabIndex = 18;
            // 
            // alwaysEnabledLabel1
            // 
            alwaysEnabledLabel1.AutoSize = true;
            alwaysEnabledLabel1.Enabled = false;
            alwaysEnabledLabel1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            alwaysEnabledLabel1.ForeColor = Color.White;
            alwaysEnabledLabel1.Location = new Point(57, 18);
            alwaysEnabledLabel1.Name = "alwaysEnabledLabel1";
            alwaysEnabledLabel1.Size = new Size(129, 20);
            alwaysEnabledLabel1.TabIndex = 18;
            alwaysEnabledLabel1.Text = "Ventas Generales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(116, 19);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 18;
            label3.Text = "Reportes";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1245, 600);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1245, 600);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ReportsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Reportes";
            Load += ReportsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private AlwaysEnabledLabel alwaysEnabledLabel2;
        private AlwaysEnabledLabel alwaysEnabledLabel1;
    }
}