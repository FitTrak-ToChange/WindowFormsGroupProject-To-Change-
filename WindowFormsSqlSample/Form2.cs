using System;
using System.Windows.Forms;
using WindowFormsSqlSample;

namespace WindowFormsSqlSample
{
    public partial class Form2 : Form
    {
        private string _username;

        public Form2(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {_username}!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Return to login screen
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
    }
}
