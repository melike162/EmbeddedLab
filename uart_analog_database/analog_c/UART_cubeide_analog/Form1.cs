using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UART_cubeide_analog
{
    public partial class Form1 : Form
    {
        // Database connection info
        string server;
        string database;
        string userName;
        string password;

        // Constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Form load event
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Login button click
        private void btn_login_Click(object sender, EventArgs e)
        {
            // Get user input
            server = txtb_server.Text;
            database = txtb_database.Text;
            userName = txtb_name.Text;
            password = txtb_password.Text;

            string mySqlConnection = $"SERVER={server}; DATABASE={database};UID={userName};PWD={password}";

            // Check for empty fields
            if (string.IsNullOrEmpty(txtb_database.Text) || string.IsNullOrEmpty(txtb_name.Text) || string.IsNullOrEmpty(txtb_password.Text) || string.IsNullOrEmpty(txtb_password.Text))
            {
                MessageBox.Show("Fields cannot be left blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DatabaseConnection(); // Attempt database connection
            }
        }

        // Database connection method
        private void DatabaseConnection()
        {
            string mySqlConnection = $"SERVER={server}; DATABASE={database};UID={userName};PWD={password}";
            using (MySqlConnection conn = new MySqlConnection(mySqlConnection))
            {
                try
                {
                    conn.Open(); // Open connection
                    //MessageBox.Show("Connection is successful!");
                    conn.Close();

                    // Open Form2 and pass login info
                    Form2 form2 = new Form2(userName, server, database, password);
                    form2.Show();

                    // Hide Form1 instead of closing
                    this.Hide();

                    // When Form2 closes, close Form1 to exit app
                    form2.FormClosed += (s, args) => this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Cancel button click - clear all fields
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txtb_server.Text = "";
            txtb_database.Text = "";
            txtb_name.Text = "";
            txtb_password.Text = "";
        }

        // Exit button click
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
