using Microsoft.Data.SqlClient;
using System.Text;

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
            txtQuery.Enabled = false;
            Connect(txtConnectionString.Text, txtQuery.Text);
            txtQuery.Enabled = true;
            btnConnect.Enabled = true;
        }

        private void Log(string text)
        {
            txtConsoleOutput.AppendText($"[{DateTime.Now.ToString("HH:mm:ss.fff")}] {text}\r\n");
        }

        private void Connect(string connectionString, string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    Log($"Connecting to data source '{connection.DataSource}'...");
                    
                    connection.Open();
                    Log("Connection opened!");

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Log("Query result:");
                            while (reader.Read())
                            {
                                var result = new StringBuilder();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    result.Append(reader[i].ToString());
                                    if ( i < reader.FieldCount - 1)
                                    {
                                        result.Append(",");
                                    }
                                }

                                txtConsoleOutput.AppendText($" {result.ToString()}\r\n");
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
