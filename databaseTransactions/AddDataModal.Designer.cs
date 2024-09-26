namespace databaseTransactions
{
    partial class AddDataModal
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            firstNameTB = new TextBox();
            lastNameTB = new TextBox();
            genderLabel = new Label();
            genderRadioM = new RadioButton();
            genderRadioF = new RadioButton();
            departmentLabel = new Label();
            departmentTB = new TextBox();
            addColBtn = new Button();
            confirmBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 9);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(60, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "first name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(12, 53);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(58, 15);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "last name";
            // 
            // firstNameTB
            // 
            firstNameTB.Location = new Point(12, 27);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.Size = new Size(205, 23);
            firstNameTB.TabIndex = 2;
            // 
            // lastNameTB
            // 
            lastNameTB.Location = new Point(12, 71);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.Size = new Size(205, 23);
            lastNameTB.TabIndex = 3;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new Point(12, 97);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(44, 15);
            genderLabel.TabIndex = 4;
            genderLabel.Text = "gender";
            // 
            // genderRadioM
            // 
            genderRadioM.AutoSize = true;
            genderRadioM.Location = new Point(12, 115);
            genderRadioM.Name = "genderRadioM";
            genderRadioM.Size = new Size(51, 19);
            genderRadioM.TabIndex = 5;
            genderRadioM.TabStop = true;
            genderRadioM.Text = "male";
            genderRadioM.UseVisualStyleBackColor = true;
            // 
            // genderRadioF
            // 
            genderRadioF.AutoSize = true;
            genderRadioF.Location = new Point(112, 115);
            genderRadioF.Name = "genderRadioF";
            genderRadioF.Size = new Size(61, 19);
            genderRadioF.TabIndex = 6;
            genderRadioF.TabStop = true;
            genderRadioF.Text = "female";
            genderRadioF.UseVisualStyleBackColor = true;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new Point(12, 137);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(69, 15);
            departmentLabel.TabIndex = 7;
            departmentLabel.Text = "department";
            // 
            // departmentTB
            // 
            departmentTB.Location = new Point(12, 155);
            departmentTB.Name = "departmentTB";
            departmentTB.Size = new Size(205, 23);
            departmentTB.TabIndex = 8;
            // 
            // addColBtn
            // 
            addColBtn.Location = new Point(168, 184);
            addColBtn.Name = "addColBtn";
            addColBtn.Size = new Size(49, 23);
            addColBtn.TabIndex = 9;
            addColBtn.Text = "add";
            addColBtn.UseVisualStyleBackColor = true;
            addColBtn.Click += addColBtn_Click;
            // 
            // confirmBtn
            // 
            confirmBtn.Location = new Point(157, 224);
            confirmBtn.Name = "confirmBtn";
            confirmBtn.Size = new Size(60, 23);
            confirmBtn.TabIndex = 10;
            confirmBtn.Text = "confirm";
            confirmBtn.UseVisualStyleBackColor = true;
            confirmBtn.Click += confirmBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(91, 224);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(60, 23);
            cancelBtn.TabIndex = 11;
            cancelBtn.Text = "cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AddDataModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 259);
            Controls.Add(cancelBtn);
            Controls.Add(confirmBtn);
            Controls.Add(addColBtn);
            Controls.Add(departmentTB);
            Controls.Add(departmentLabel);
            Controls.Add(genderRadioF);
            Controls.Add(genderRadioM);
            Controls.Add(genderLabel);
            Controls.Add(lastNameTB);
            Controls.Add(firstNameTB);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "AddDataModal";
            Text = "AddDataModal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox firstNameTB;
        private TextBox lastNameTB;
        private Label genderLabel;
        private RadioButton genderRadioM;
        private RadioButton genderRadioF;
        private Label departmentLabel;
        private TextBox departmentTB;
        private Button addColBtn;
        private Button confirmBtn;
        private Button cancelBtn;
    }
}