using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowFormsSqlSample
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                lblStatus.Text = "Please enter both username and password.";
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Users WHERE Username=@username AND UserPassword=@password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Close();
                        // ✅ Open Dashboard
                        Form2 dashboard = new Form2(username);
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblStatus.ForeColor = System.Drawing.Color.Red;
                        lblStatus.Text = "Invalid username or password.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }
    }
}
