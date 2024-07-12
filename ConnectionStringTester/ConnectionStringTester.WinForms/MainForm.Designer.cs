namespace ConnectionStringTester.WinForms
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
            panel1 = new Panel();
            panel4 = new Panel();
            txtConnectionString = new TextBox();
            panel3 = new Panel();
            btnConnect = new Button();
            panel2 = new Panel();
            txtConsoleOutput = new TextBox();
            panel5 = new Panel();
            panel7 = new Panel();
            txtQuery = new TextBox();
            panel6 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtConnectionString);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(654, 25);
            panel4.TabIndex = 1;
            // 
            // txtConnectionString
            // 
            txtConnectionString.Dock = DockStyle.Fill;
            txtConnectionString.Location = new Point(0, 0);
            txtConnectionString.Name = "txtConnectionString";
            txtConnectionString.Size = new Size(654, 23);
            txtConnectionString.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnConnect);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(654, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(146, 25);
            panel3.TabIndex = 0;
            // 
            // btnConnect
            // 
            btnConnect.Dock = DockStyle.Fill;
            btnConnect.Location = new Point(0, 0);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(146, 25);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtConsoleOutput);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 425);
            panel2.TabIndex = 1;
            // 
            // txtConsoleOutput
            // 
            txtConsoleOutput.Dock = DockStyle.Fill;
            txtConsoleOutput.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConsoleOutput.ForeColor = SystemColors.WindowText;
            txtConsoleOutput.Location = new Point(0, 0);
            txtConsoleOutput.Multiline = true;
            txtConsoleOutput.Name = "txtConsoleOutput";
            txtConsoleOutput.ReadOnly = true;
            txtConsoleOutput.ScrollBars = ScrollBars.Both;
            txtConsoleOutput.Size = new Size(800, 425);
            txtConsoleOutput.TabIndex = 0;
            txtConsoleOutput.WordWrap = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 428);
            panel5.Name = "panel5";
            panel5.Size = new Size(800, 22);
            panel5.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtQuery);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(109, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(691, 22);
            panel7.TabIndex = 3;
            // 
            // txtQuery
            // 
            txtQuery.Dock = DockStyle.Fill;
            txtQuery.Location = new Point(0, 0);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(691, 23);
            txtQuery.TabIndex = 0;
            txtQuery.Text = "SELECT 'Success!'";
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(109, 22);
            panel6.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 22);
            label1.TabIndex = 1;
            label1.Text = "Query to execute:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AcceptButton = btnConnect;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "ConnectionString Tester";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private TextBox txtConnectionString;
        private Panel panel3;
        private Button btnConnect;
        private Panel panel2;
        private TextBox txtConsoleOutput;
        private Panel panel5;
        private TextBox txtQuery;
        private Panel panel7;
        private Panel panel6;
        private Label label1;
    }
}
