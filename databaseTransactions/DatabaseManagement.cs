using Dapper;
using MySql.Data.MySqlClient;

namespace databaseTransactions
{
    public partial class DatabaseManagement : Form
    {
        public List<Employee>? Employees { get; set; }
        private string databaseType;
        private string connectionString;
        private int wHeight = 490;

        public DatabaseManagement(string databaseType, string connectionString)
        {
            InitializeComponent();

            this.Height = wHeight;

            this.connectionString = connectionString;
            this.databaseType = databaseType;
            dbType.Text = this.databaseType;

            switch (this.databaseType)
            {
                case "MySQL":
                    {
                        var connection = new MySqlConnection(this.connectionString);

                        string tableCreation = """
                            CREATE TABLE IF NOT EXISTS employees (
                                EmployeeID INT NOT NULL AUTO_INCREMENT,
                                FirstName VARCHAR(255) NOT NULL,
                                LastName VARCHAR(255) NOT NULL,
                                Gender VARCHAR(1) NOT NULL,
                                Department VARCHAR(255) NOT NULL,
                                PRIMARY KEY (EmployeeID)
                            )
                        """;
                        var create = connection.Execute(tableCreation);

                        using (connection)
                        {
                            var query = "SELECT * FROM Employees";
                            var list = connection.Query<Employee>(query).ToList();
                            Employees = list;
                        }
                    }
                    break;
            }
        }

        private void DatabaseManagement_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = this.Employees;
            editGroup.Visible = editMode;
        }

        private void addDataBtn_Click(object sender, EventArgs e)
        {
            using (AddDataModal addDataModal = new AddDataModal(this))
            {
                addDataModal.ShowDialog();
            }
        }

        public void RefreshDataGrid()
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = this.Employees;
        }

        public bool transactWrite(List<Employee> entries)
        {
            switch (this.databaseType)
            {
                case "MySQL":
                    {
                        var connection = new MySqlConnection(this.connectionString);

                        using (connection)
                        {
                            foreach (Employee entry in entries)
                            {
                                string tx = $"INSERT INTO employees(FirstName, LastName, Gender, Department) VALUES (\"{entry.firstName}\", \"{entry.lastName}\", \"{entry.gender}\", \"{entry.department}\")";
                                connection.Execute(tx);

                                var query = "SELECT * FROM Employees";
                                var list = connection.Query<Employee>(query).ToList();
                                Employees = list;

                                RefreshDataGrid();
                            }
                        }
                        break;
                    }
            }
            return true;
        }

        private bool editMode = false;
        private void switchEditModeAndResize()
        {
            if (editMode)
            {
                editMode = false;
                this.Height = wHeight;
                editGroup.Hide();
            }
            else if (!editMode)
            {
                editMode = true;
                this.Height = wHeight + 200;
                editGroup.Show();
            }
        }
        private void editDataBtn_Click(object sender, EventArgs e)
        {
            switchEditModeAndResize();

        }
    }
}
