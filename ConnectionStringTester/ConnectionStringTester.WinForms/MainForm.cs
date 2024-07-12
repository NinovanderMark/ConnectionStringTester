using Microsoft.Data.SqlClient;

namespace ConnectionStringTester.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Log("Application initialized");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            Connect(txtConnectionString.Text);
            btnConnect.Enabled = true;
        }

        private void Log(string text)
        {
            txtConsoleOutput.AppendText($"[{DateTime.Now.ToString("HH:mm:ss.fff")}] {text}\r\n");
        }

        private void Connect(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    Log($"Connecting to data source '{connection.DataSource}'...");
                    
                    connection.Open();
                    Log("Connection opened!");

                    string sql = "SELECT 1";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Log("Query executed!");
                            }
                        }
                    }

                    connection.Close();
                    Log("Connection terminated!");
                }
            }
            catch (Exception ex)
            {
                Log($"ERROR: {ex.Message}");
            }
        }
    }
}
