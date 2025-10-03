using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ScottPlot;
using ScottPlot.WinForms;



namespace real_time_logger
{
    public partial class Form1 : Form
    {

        private MySqlConnection conn; // MySQL connection object
        private SerialPort Serial = new SerialPort();// Serial port object
        // Supported baudrates
        private readonly int[] baudrate = { 9600, 19200, 38400, 115200, 230400, 460800, 921600, 3860000 }; // Supported baudrates
        bool receiver = false;// Flag to control data receiving
        private string activeTable = "";  // Currently active database table
        private ScottPlot.WinForms.FormsPlot formsPlot; // ScottPlot plot object

        public Form1()
        {
            InitializeComponent();
            /*
            formsPlot = new ScottPlot.WinForms.FormsPlot();
            formsPlot.Location = new Point(506, 111);
            formsPlot.Size = new Size(600, 461);
            this.Controls.Add(formsPlot);
            */
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            conn.Close();// Close database connection
            this.Close();// Close the form
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateComPortList();  // Populate COM port and baudrate lists
            DatabaseConnection(); // Open database connection
            LoadTableNames();     // Load table names into combo box
            //PlotData();
        }

        private void DatabaseConnection()
        {
            try
            {
                if (conn == null)
                {
                    // MySQL connection string
                    string mySqlConnection = $"Server=localhost;Database=real_time_logger;User Id=root;Password=159357;Port=3306;";
                    conn = new MySqlConnection(mySqlConnection);
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();// Open connection if not already open
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTableNames()
        {
            DataTable tables = GetTables(); // Get list of tables
            if (tables == null) return;

            cmb_table.Items.Clear();
            cmb_write.Items.Clear();
            foreach (DataRow row in tables.Rows)
            {
                string tableName = row[0].ToString();
                cmb_table.Items.Add(tableName);// Populate table selection combo box
                cmb_write.Items.Add(tableName);// Populate write table combo box
            }
        }
        // Get list of tables
        public DataTable GetTables()
        {
            try
            {
                string query = "SHOW TABLES;"; // SQL query to get all tables
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);// Fill DataTable with results
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            if (cmb_table.SelectedItem == null) return;

            string tableName = cmb_table.Text;
            string query = $"SELECT * FROM `{tableName}`";// Select all data from selected table

            DataTable dt = getData(query);// Execute query and get results

            if (dt != null)
            {
                dgv_table.DataSource = dt;// Bind data to DataGridView
                dgv_table.RowHeadersVisible = false;
                dgv_table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_table.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                if(dt.Rows.Count > 0)
                {
                    double[] dataX = new double[dt.Rows.Count];
                    double[] dataY1 = new double[dt.Rows.Count];
                    double[] dataY2 = new double[dt.Rows.Count];

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataX[i] = Convert.ToDouble(dt.Rows[i]["id"]);       // X-axis = id column
                        dataY1[i] = Convert.ToDouble(dt.Rows[i]["sensor1"]); // Y1-axis = sensor1 column
                        dataY2[i] = Convert.ToDouble(dt.Rows[i]["sensor2"]); // Y2-axis = sensor2 column
                    }

                    PlotDataTable(dataX, dataY1, dataY2);// Plot the data
                }
            }
            else
            {
                dgv_table.DataSource = null;// Clear DataGridView if no data
            }

        }

        private void PlotDataTable(double[] dataX, double[] dataY1, double[] dataY2)
        {
            formsPlot1.Plot.Clear(); // Clear previous plots

            // Plot sensor1 data
            var scatter1 = formsPlot1.Plot.Add.Scatter(dataX, dataY1);
            scatter1.Color = Colors.Red;   // Set color
            scatter1.LineWidth = 2;

            // Plot sensor2 data
            var scatter2 = formsPlot1.Plot.Add.Scatter(dataX, dataY2);
            scatter2.Color = Colors.Blue;  // Set color
            scatter2.LineWidth = 2;

            formsPlot1.Refresh(); // Refresh the plot
        }

        private void PlotData()
        {
            // Sample data for testing
            double[] dataX = { 1, 2, 3, 4, 5 };
            double[] dataY1 = { 10, 20, 15, 25, 30 };
            double[] dataY2 = { 5, 15, 10, 20, 25 };

            // Plot sensor1
            var scatter1 = formsPlot1.Plot.Add.Scatter(dataX, dataY1);
            scatter1.Color = Colors.Red;
            scatter1.LineWidth = 2;

            // Plot sensor2
            var scatter2 = formsPlot1.Plot.Add.Scatter(dataX, dataY2);
            scatter2.Color = Colors.Blue;
            scatter2.LineWidth = 2;

            formsPlot1.Refresh(); // Refresh the plot
        }

        public DataTable getData(string query)
        {
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);  // Fill DataTable with query results
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return null;
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            // Disconnect if already connected
            if ("Disconnect" == btn_connect.Text.ToString())
            {
                if (true == Serial.IsOpen) Serial.Close(); // Close serial port

                if (btn_writeDatabase.Text == "Stop Writing")
                {
                    activeTable = "";
                    receiver = false;
                    btn_writeDatabase.Text = "Write";
                }

                btn_connect.Text = "Connect";
                cmb_comport.Enabled = true;
                cmb_baundrate.Enabled = true;
                btn_refresh.Enabled = true;
                btn_writeDatabase.Enabled = false;
                cmb_write.Enabled = false;

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
                MessageBox.Show("Error! No BaudRate selected");
                return;
            }

            // Serial port configuration
            Serial.Parity = Parity.None;
            Serial.DataBits = 8;
            Serial.ReceivedBytesThreshold = 1;
            Serial.StopBits = StopBits.One;
            Serial.Handshake = Handshake.None;
            Serial.WriteTimeout = 3000;

            if (!Serial.IsOpen)
            {
                try
                {
                    Serial.Open(); // Open serial port
                }
                catch
                {
                    MessageBox.Show("The COM Port is not accessible", "Error");
                    return;
                }

                if (Serial.IsOpen)
                {
                    if (btn_writeDatabase.Text == "Stop Writing") receiver = false;

                    btn_writeDatabase.Text = "Write";
                    btn_connect.Text = "Disconnect";
                    cmb_comport.Enabled = false;
                    cmb_baundrate.Enabled = false;
                    btn_refresh.Enabled = false;
                    btn_writeDatabase.Enabled = true;
                    cmb_write.Enabled = true;
                    Serial.DataReceived += new SerialDataReceivedEventHandler(SerialOnReceivedHandler); // Event handler for incoming data
                }
            }
        }

        void SerialOnReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (receiver)
            {
                try
                {
                    string line = Serial.ReadLine(); // Read one line from serial
                    this.Invoke(new Action(() =>
                    {
                        ProcessSerialData(line);   // Process and insert into database
                    }));
                }
                catch (Exception) { }
            }
        }

        private void ProcessSerialData(string data)
        {
            try
            {
                string[] values = data.Split(';'); // Split sensor data
                int lux = int.Parse(values[0]);
                int pot = int.Parse(values[1]);
                InsertSensorData(lux, pot);        // Insert into database
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial parse error: " + ex.Message);
            }
        }

        private void InsertSensorData(int lux, int pot)
        {
            if (cmb_table.SelectedItem == null) return;
            string tableName = cmb_table.SelectedItem.ToString();
            string query = $"INSERT INTO `{activeTable}` (sensor1, sensor2, time) VALUES (@lux, @pot, @time)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@lux", lux);
                cmd.Parameters.AddWithValue("@pot", pot);
                cmd.Parameters.AddWithValue("@time", DateTime.Now);

                try
                {
                    cmd.ExecuteNonQuery(); // Execute insert query
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database insert error: " + ex.Message);
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            UpdateComPortList(); // Refresh COM port list
        }

        private void UpdateComPortList()
        {
            string[] Ports = System.IO.Ports.SerialPort.GetPortNames();
            cmb_comport.Items.Clear();
            cmb_baundrate.Items.Clear();
            foreach (var item in Ports) cmb_comport.Items.Add(item); // Add available COM ports
            foreach (var baund in baudrate) cmb_baundrate.Items.Add(baund.ToString()); // Add baudrates
        }

        private void btn_writeDatabase_Click(object sender, EventArgs e)
        {
            if (btn_writeDatabase.Text == "Write")
            {
                if (cmb_write.SelectedItem == null) return;
                activeTable = cmb_write.SelectedItem.ToString();
                receiver = true;               // Enable receiving
                btn_writeDatabase.Text = "Stop Writing";
            }
            else
            {
                activeTable = "";
                receiver = false;              // Stop receiving
                btn_writeDatabase.Text = "Write";
            }
        }

        private void btn_creat_Click(object sender, EventArgs e)
        {
            if (txt_creat.Text == "") return;
            string tableName = txt_creat.Text; // Get table name from textbox

            try
            {
                // SQL query to create new table
                string query = $@"
                CREATE TABLE `{tableName}`(
                id INT AUTO_INCREMENT PRIMARY KEY,
                sensor1 INT,
                sensor2 INT,
                time TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                )";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery(); // Execute create table
                }
                LoadTableNames(); // Reload table list
                txt_creat.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
