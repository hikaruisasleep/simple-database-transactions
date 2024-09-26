namespace databaseTransactions
{
    partial class ConnectToDatabase
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
            connStrLabel = new Label();
            dbTypeLabel = new Label();
            titleText = new Label();
            dbTypeSel = new ComboBox();
            connStrTB = new TextBox();
            connectButton = new Button();
            SuspendLayout();
            // 
            // connStrLabel
            // 
            connStrLabel.AutoSize = true;
            connStrLabel.ForeColor = SystemColors.ButtonHighlight;
            connStrLabel.Location = new Point(12, 94);
            connStrLabel.Name = "connStrLabel";
            connStrLabel.Size = new Size(100, 15);
            connStrLabel.TabIndex = 0;
            connStrLabel.Text = "connection string";
            // 
            // dbTypeLabel
            // 
            dbTypeLabel.AutoSize = true;
            dbTypeLabel.ForeColor = SystemColors.ButtonHighlight;
            dbTypeLabel.Location = new Point(12, 38);
            dbTypeLabel.Name = "dbTypeLabel";
            dbTypeLabel.Size = new Size(80, 15);
            dbTypeLabel.TabIndex = 1;
            dbTypeLabel.Text = "database type";
            // 
            // titleText
            // 
            titleText.AutoSize = true;
            titleText.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleText.ForeColor = SystemColors.HighlightText;
            titleText.Location = new Point(59, 9);
            titleText.Name = "titleText";
            titleText.Size = new Size(177, 19);
            titleText.TabIndex = 2;
            titleText.Text = "connect to a database";
            // 
            // dbTypeSel
            // 
            dbTypeSel.DropDownStyle = ComboBoxStyle.DropDownList;
            dbTypeSel.FormattingEnabled = true;
            dbTypeSel.Items.AddRange(new object[] { "SQL Server", "MySQL", "SQLite (Memory)" });
            dbTypeSel.Location = new Point(12, 56);
            dbTypeSel.Name = "dbTypeSel";
            dbTypeSel.Size = new Size(263, 23);
            dbTypeSel.TabIndex = 3;
            dbTypeSel.SelectedIndexChanged += dbTypeSel_SelectedIndexChanged;
            // 
            // connStrTB
            // 
            connStrTB.Location = new Point(15, 112);
            connStrTB.Name = "connStrTB";
            connStrTB.Size = new Size(260, 23);
            connStrTB.TabIndex = 4;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(200, 151);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(75, 23);
            connectButton.TabIndex = 5;
            connectButton.Text = "connect";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // ConnectToDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(291, 190);
            Controls.Add(connectButton);
            Controls.Add(connStrTB);
            Controls.Add(dbTypeSel);
            Controls.Add(titleText);
            Controls.Add(dbTypeLabel);
            Controls.Add(connStrLabel);
            Name = "ConnectToDatabase";
            Text = "database transactions";
            Load += ConnectToDatabase_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label connStrLabel;
        private Label dbTypeLabel;
        private Label titleText;
        private ComboBox dbTypeSel;
        private TextBox connStrTB;
        private Button connectButton;
    }
}
