namespace databaseTransactions
{
    public partial class AddDataModal : Form
    {

        private readonly DatabaseManagement databaseManagement;

        List<Employee> currentSessionEntries = new();

        public AddDataModal(DatabaseManagement form)
        {
            InitializeComponent();
            databaseManagement = form;
        }

        private void addColBtn_Click(object sender, EventArgs e)
        {
            Employee entry = new()
            {
                firstName = firstNameTB.Text,
                lastName = lastNameTB.Text,
                gender = genderRadioM.Checked ? "M" : (genderRadioF.Checked ? "F" : ""),
                department = departmentTB.Text
            };

            databaseManagement.Employees.Add(entry);
            currentSessionEntries.Add(entry);

            databaseManagement.RefreshDataGrid();

            firstNameTB.Text = string.Empty;
            lastNameTB.Text = string.Empty;
            genderRadioM.Checked = false;
            genderRadioF.Checked = false;
            departmentTB.Text = string.Empty;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (databaseManagement.transactWrite(currentSessionEntries))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                throw new Exception("Unable to transact into database");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            foreach (var entry in currentSessionEntries)
            {
                databaseManagement.Employees.Remove(entry);
                databaseManagement.RefreshDataGrid();
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
