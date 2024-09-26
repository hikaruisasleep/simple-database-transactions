namespace databaseTransactions
{
    public partial class ConnectToDatabase : System.Windows.Forms.Form
    {
        public ConnectToDatabase()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = connStrTB.Text;

                switch (dbTypeSel.Text)
                {
                    case "MySQL":
                        {
                            ChangeForm("MySQL", connectionString);
                        }
                        break;
                    case "SQL Server":
                        throw new Exception("MSSQLS compat in progress");
                    default:
                        throw new Exception("Invalid database type");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ChangeForm(string dbT, string connStr)
        {
            Form databaseManagement = new DatabaseManagement(dbT, connStr);
            databaseManagement.Name = this.Name;
            databaseManagement.Location = this.Location;
            databaseManagement.StartPosition = FormStartPosition.Manual;
            databaseManagement.FormClosing += delegate { this.Show(); };
            databaseManagement.Show();
            this.Hide();
        }

        private void ConnectToDatabase_Load(object sender, EventArgs e)
        {
            dbTypeSel.SelectedItem = "MySQL";
        }
    }
}
