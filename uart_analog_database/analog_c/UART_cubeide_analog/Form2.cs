using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO.Ports;

using System.Windows.Forms;

namespace UART_cubeide_analog
{
    public partial class Form2 : Form
    {
        // Database connection info
        string server;
        string database;
        string userName;
        string password;
        private MySqlConnection conn;

        // Flag to control data receiving
        bool receiver = false;

        // Constructor
        public Form2(string userNameParam, string serverParam, string databaseParam, string passwordParam)
        {
            InitializeComponent();
            this.server = serverParam;
            this.database = databaseParam;
            this.userName = userNameParam;
            this.password = passwordParam;
        }

        // Form load event
        private void Form2_Load_1(object sender, EventArgs e)
        {
            UpdateComPortList();  // Populate COM port and baudrate lists
            DatabaseConnection(); // Open database connection
            LoadTableNames();     // Load table names into combo box
        }

        #region Constrant
        // Supported baudrates
        private readonly int[] baudrate = { 9600, 19200, 38400, 115200, 230400, 460800, 921600, 3860000 };
        #endregion

        // Serial port object
        private SerialPort Serial = new SerialPort();

        #region Local Helpers
        // Update COM port and baudrate combo boxes
        private void UpdateComPortList()
        {
            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            cmb_comport.Items.Clear();
            cmb_baundrate.Items.Clear();
            foreach (var item in Ports)
            {
                cmb_comport.Items.Add(item);
            }
            foreach (var baund in baudrate)
            {
                cmb_baundrate.Items.Add(baund.ToString());
            }
        }
        #endregion

        // Connect/Disconnect button click
        private void btn_connect_Click(object sender, EventArgs e)
        {
            // Disconnect if already connected
            if ("Disconnect" == btn_connect.Text.ToString())
            {
                if (true == Serial.IsOpen)
                {
                    Serial.Close();
                }

                btn_connect.Text = "Connect";
                cmb_comport.Enabled = true;
                cmb_baundrate.Enabled = true;
                btn_reflesh.Enabled = true;
                btn_writeDatabase.Enabled = false;

                return;
            }

            // Open selected COM port
            try
            {
                Serial.PortName = cmb_comport.Text;
            }
            catch
            {
                MessageBox.Show("Error! No COM Port selected");
                return;
            }

            // Set baudrate
            try
            {
                Serial.BaudRate = int.Parse(cmb_baundrate.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Error! No BundRate selected");
                return;
            }

            // Serial configuration
            Serial.Parity = Parity.None;
            Serial.DataBits = 8;
            Serial.ReceivedBytesThreshold = 1;
            Serial.StopBits = StopBits.One;
            Serial.Handshake = Handshake.None;
            Serial.WriteTimeout = 3000;

            if (false == Serial.IsOpen)
            {
                try
                {
                    Serial.Open();
                }
                catch
                {
                    MessageBox.Show("The COM Port is not accessible", "Error");
                    return;
                }

                if (true == Serial.IsOpen)
                {
                    btn_connect.Text = "Disconnect";
                    cmb_comport.Enabled = false;
                    cmb_baundrate.Enabled = false;
                    btn_reflesh.Enabled = false;
                    btn_writeDatabase.Enabled = true;
                    Serial.DataReceived += new SerialDataReceivedEventHandler(SerialOnReceivedHandler);
                }
            }
        }

        // Refresh COM ports list
        private void btn_reflesh_Click(object sender, EventArgs e)
        {
            UpdateComPortList();
        }

        #region Handlers
        // Serial data received event
        void SerialOnReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (receiver)
            {
                try
                {
                    string line = Serial.ReadLine(); // Read until newline
                    this.Invoke(new Action(() =>
                    {
                        ProcessSerialData(line);   // Process and write to database
                    }));
                }
                catch (Exception) { }
            }
        }
        #endregion

        // Parse serial data and insert into database
        private void ProcessSerialData(string data)
        {
            try
            {
                string[] parts = data.Split(new string[] { "Light:", "Pot:" }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length >= 2)
                {
                    int lightValue = int.Parse(parts[0].Trim());
                    int potValue = int.Parse(parts[1].Trim());

                    InsertIntoTable("light", lightValue);
                    InsertIntoTable("pot", potValue);
                }
            }
            catch (Exception) { }
        }

        // Insert single value into table
        private void InsertIntoTable(string tableName, int value)
        {
            try
            {
                string query = $"INSERT INTO `{tableName}` (value, time) VALUES (@value, NOW())";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception) { }
        }

        // Open database connection
        private void DatabaseConnection()
        {
            try
            {
                if (conn == null)
                {
                    string mySqlConnection = $"Server={server};Database={database};User Id={userName};Password={password};Port=3306;";
                    conn = new MySqlConnection(mySqlConnection);
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Get list of tables
        public DataTable GetTables()
        {
            try
            {
                string query = "SHOW TABLES;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        // Execute query and return data
        public DataTable getData(string query)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return null;
            }
        }

        // Load table names into combo box
        private void LoadTableNames()
        {
            DataTable tables = GetTables();
            if (tables == null) return;

            cmb_table.Items.Clear();
            foreach (DataRow row in tables.Rows)
            {
                string tableName = row[0].ToString();
                cmb_table.Items.Add(tableName);
            }
        }

        // Show selected table in DataGridView
        private void btn_show_Click_1(object sender, EventArgs e)
        {
            if (cmb_table.SelectedItem == null) return;

            string tableName = cmb_table.Text;
            string query = $"SELECT * FROM `{tableName}`";

            DataTable dt = getData(query);
            if (dt != null)
            {
                dgv_table.DataSource = dt;
                dgv_table.RowHeadersVisible = false;
                dgv_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_table.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            else
                dgv_table.DataSource = null;
        }

        // Toggle writing data to database
        private void btn_writeDatabase_Click(object sender, EventArgs e)
        {
            if (btn_writeDatabase.Text == "Write The Database")
            {
                btn_writeDatabase.Text = "Stop Writing Database";
                receiver = true;
            }
            else
            {
                btn_writeDatabase.Text = "Write The Database";
                receiver = false;
            }
        }

        // Exit button
        private void btn_exit_Click(object sender, EventArgs e)
        {
            conn.Close();
            this.Close();
        }

        // Form closing cleanup
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
