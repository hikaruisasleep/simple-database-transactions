namespace databaseTransactions
{
    partial class DatabaseManagement
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
            dbType = new Label();
            dataGrid = new DataGridView();
            editDataBtn = new Button();
            addDataBtn = new Button();
            editGroup = new GroupBox();
            editEmployeeId = new Label();
            editDeleteBtn = new Button();
            editConfirmBtn = new Button();
            editGenderF = new RadioButton();
            editGenderM = new RadioButton();
            editDepartmentTB = new TextBox();
            editLastNameTB = new TextBox();
            editFirstNameTB = new TextBox();
            editDepartmentLabel = new Label();
            editGenderLabel = new Label();
            editLastNameLabel = new Label();
            editFirstNameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            editGroup.SuspendLayout();
            SuspendLayout();
            // 
            // dbType
            // 
            dbType.AutoSize = true;
            dbType.Font = new Font("Segoe UI", 10F);
            dbType.Location = new Point(12, 9);
            dbType.Name = "dbType";
            dbType.Size = new Size(95, 19);
            dbType.TabIndex = 0;
            dbType.Text = "database type";
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid.Location = new Point(12, 38);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(580, 366);
            dataGrid.TabIndex = 2;
            // 
            // editDataBtn
            // 
            editDataBtn.Location = new Point(474, 410);
            editDataBtn.Name = "editDataBtn";
            editDataBtn.Size = new Size(118, 28);
            editDataBtn.TabIndex = 3;
            editDataBtn.Text = "edit";
            editDataBtn.UseVisualStyleBackColor = true;
            editDataBtn.Click += editDataBtn_Click;
            // 
            // addDataBtn
            // 
            addDataBtn.Location = new Point(474, 4);
            addDataBtn.Name = "addDataBtn";
            addDataBtn.Size = new Size(118, 28);
            addDataBtn.TabIndex = 4;
            addDataBtn.Text = "add data";
            addDataBtn.UseVisualStyleBackColor = true;
            addDataBtn.Click += addDataBtn_Click;
            // 
            // editGroup
            // 
            editGroup.Controls.Add(editEmployeeId);
            editGroup.Controls.Add(editDeleteBtn);
            editGroup.Controls.Add(editConfirmBtn);
            editGroup.Controls.Add(editGenderF);
            editGroup.Controls.Add(editGenderM);
            editGroup.Controls.Add(editDepartmentTB);
            editGroup.Controls.Add(editLastNameTB);
            editGroup.Controls.Add(editFirstNameTB);
            editGroup.Controls.Add(editDepartmentLabel);
            editGroup.Controls.Add(editGenderLabel);
            editGroup.Controls.Add(editLastNameLabel);
            editGroup.Controls.Add(editFirstNameLabel);
            editGroup.Location = new Point(12, 444);
            editGroup.Name = "editGroup";
            editGroup.Size = new Size(580, 194);
            editGroup.TabIndex = 5;
            editGroup.TabStop = false;
            editGroup.Text = "editing employee 0";
            // 
            // editEmployeeId
            // 
            editEmployeeId.AutoSize = true;
            editEmployeeId.Enabled = false;
            editEmployeeId.Location = new Point(132, 155);
            editEmployeeId.Name = "editEmployeeId";
            editEmployeeId.Size = new Size(13, 15);
            editEmployeeId.TabIndex = 10;
            editEmployeeId.Text = "0";
            editEmployeeId.Visible = false;
            // 
            // editDeleteBtn
            // 
            editDeleteBtn.BackColor = Color.DarkRed;
            editDeleteBtn.BackgroundImageLayout = ImageLayout.None;
            editDeleteBtn.FlatAppearance.BorderColor = Color.Red;
            editDeleteBtn.FlatStyle = FlatStyle.Popup;
            editDeleteBtn.ForeColor = SystemColors.Control;
            editDeleteBtn.Location = new Point(8, 148);
            editDeleteBtn.Name = "editDeleteBtn";
            editDeleteBtn.Size = new Size(118, 28);
            editDeleteBtn.TabIndex = 9;
            editDeleteBtn.Text = "delete row";
            editDeleteBtn.UseVisualStyleBackColor = false;
            editDeleteBtn.Click += editDeleteBtn_Click;
            // 
            // editConfirmBtn
            // 
            editConfirmBtn.Location = new Point(456, 148);
            editConfirmBtn.Name = "editConfirmBtn";
            editConfirmBtn.Size = new Size(118, 28);
            editConfirmBtn.TabIndex = 6;
            editConfirmBtn.Text = "confirm";
            editConfirmBtn.UseVisualStyleBackColor = true;
            editConfirmBtn.Click += editConfirmBtn_Click;
            // 
            // editGenderF
            // 
            editGenderF.AutoSize = true;
            editGenderF.Location = new Point(65, 95);
            editGenderF.Name = "editGenderF";
            editGenderF.Size = new Size(61, 19);
            editGenderF.TabIndex = 8;
            editGenderF.TabStop = true;
            editGenderF.Text = "female";
            editGenderF.UseVisualStyleBackColor = true;
            // 
            // editGenderM
            // 
            editGenderM.AutoSize = true;
            editGenderM.Location = new Point(8, 95);
            editGenderM.Name = "editGenderM";
            editGenderM.Size = new Size(51, 19);
            editGenderM.TabIndex = 7;
            editGenderM.TabStop = true;
            editGenderM.Text = "male";
            editGenderM.UseVisualStyleBackColor = true;
            // 
            // editDepartmentTB
            // 
            editDepartmentTB.Location = new Point(132, 95);
            editDepartmentTB.Name = "editDepartmentTB";
            editDepartmentTB.Size = new Size(442, 23);
            editDepartmentTB.TabIndex = 6;
            // 
            // editLastNameTB
            // 
            editLastNameTB.Location = new Point(294, 46);
            editLastNameTB.Name = "editLastNameTB";
            editLastNameTB.Size = new Size(280, 23);
            editLastNameTB.TabIndex = 5;
            // 
            // editFirstNameTB
            // 
            editFirstNameTB.Location = new Point(8, 46);
            editFirstNameTB.Name = "editFirstNameTB";
            editFirstNameTB.Size = new Size(280, 23);
            editFirstNameTB.TabIndex = 4;
            // 
            // editDepartmentLabel
            // 
            editDepartmentLabel.AutoSize = true;
            editDepartmentLabel.Location = new Point(132, 77);
            editDepartmentLabel.Name = "editDepartmentLabel";
            editDepartmentLabel.Size = new Size(69, 15);
            editDepartmentLabel.TabIndex = 3;
            editDepartmentLabel.Text = "department";
            // 
            // editGenderLabel
            // 
            editGenderLabel.AutoSize = true;
            editGenderLabel.Location = new Point(8, 77);
            editGenderLabel.Name = "editGenderLabel";
            editGenderLabel.Size = new Size(44, 15);
            editGenderLabel.TabIndex = 2;
            editGenderLabel.Text = "gender";
            // 
            // editLastNameLabel
            // 
            editLastNameLabel.AutoSize = true;
            editLastNameLabel.Location = new Point(294, 28);
            editLastNameLabel.Name = "editLastNameLabel";
            editLastNameLabel.Size = new Size(58, 15);
            editLastNameLabel.TabIndex = 1;
            editLastNameLabel.Text = "last name";
            // 
            // editFirstNameLabel
            // 
            editFirstNameLabel.AutoSize = true;
            editFirstNameLabel.Location = new Point(6, 28);
            editFirstNameLabel.Name = "editFirstNameLabel";
            editFirstNameLabel.Size = new Size(60, 15);
            editFirstNameLabel.TabIndex = 0;
            editFirstNameLabel.Text = "first name";
            // 
            // DatabaseManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 651);
            Controls.Add(editGroup);
            Controls.Add(addDataBtn);
            Controls.Add(editDataBtn);
            Controls.Add(dataGrid);
            Controls.Add(dbType);
            Name = "DatabaseManagement";
            Text = "DatabaseManagement";
            Load += DatabaseManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            editGroup.ResumeLayout(false);
            editGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dbType;
        private DataGridView dataGrid;
        private Button editDataBtn;
        private Button addDataBtn;
        private GroupBox editGroup;
        private Label editDepartmentLabel;
        private Label editGenderLabel;
        private Label editLastNameLabel;
        private Label editFirstNameLabel;
        private RadioButton editGenderF;
        private RadioButton editGenderM;
        private TextBox editDepartmentTB;
        private TextBox editLastNameTB;
        private TextBox editFirstNameTB;
        private Button editDeleteBtn;
        private Button editConfirmBtn;
        private Label editEmployeeId;
    }
}