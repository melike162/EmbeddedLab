using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace UART_cubeide
{
    public partial class MainForm : Form
    {
        #region Constrant
        private readonly int[] baudrate = { 9600, 19200, 38400, 115200, 230400, 460800, 921600, 3860000 };
        #endregion

        private SerialPort Serial = new SerialPort();
        #region Local Helpers
        private void UpdateComPortList()
        {
            //get all existing com port names
            string[] Ports=System.IO.Ports.SerialPort.GetPortNames();
            cmb_comport.Items.Clear();
            cmb_baudrate.Items.Clear();
            //append to the cmb s
            foreach(var item in Ports)
            {
                cmb_comport.Items.Add(item);
            }
            foreach (var baund in baudrate)
            {
                cmb_baudrate.Items.Add(baund.ToString());
            }
        }
        #endregion

        #region Delegates
        public delegate void Update_output_text(String Str);
        public  void UpdateOutputText(String Str)
        {
            txtb_receive.Text += Str;
            txtb_receive.ScrollToCaret();
        }
        #endregion

        #region Handlers
        void SerialOnReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            String str = Serial.ReadExisting();
            Invoke(new Update_output_text(UpdateOutputText), str);
        }

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //populate the lists during mainform is loading
            UpdateComPortList();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            //disconnect
            if ("Disconnect" == btn_connect.Text.ToString())
            {
                if(Serial.IsOpen)
                {
                    Serial.Close();
                }

                btn_connect.Text = "Connect";
                cmb_comport.Enabled = true;
                cmb_baudrate.Enabled = true;
                btn_reflesh.Enabled = true;
                btn_led1.Enabled = false;
                btn_led2.Enabled = false;
                btn_led3.Enabled = false;
                btn_led4.Enabled = false;
                txtb_receive.Enabled = false;

                return;
            }

            //else open the desired COM port
            //get comport from cmb
            try
            {
                Serial.PortName = cmb_comport.Text;
            }
            catch
            {
                MessageBox.Show("Error! No COM Port selected");
                return;
            }

            //GET BAUNDRATE FROM CMB
            try
            {
                Serial.BaudRate=int.Parse(cmb_baudrate.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Error! No BundRate selected");
                return;
            }

            Serial.Parity=Parity.None;
            Serial.DataBits = 8;
            Serial.ReceivedBytesThreshold = 1;
            Serial.StopBits = StopBits.One;
            Serial.Handshake = Handshake.None;
            Serial.WriteTimeout = 3000;

            //serial port configuration
            if(!Serial.IsOpen)
            {
                try
                {
                    Serial.Open();
                }
                catch
                {
                    MessageBox.Show("The COM Port is accessible", "Error");
                    return;
                }


                if(Serial.IsOpen)
                {
                    btn_connect.Text = "Disconnect";
                    cmb_comport.Enabled = false;
                    cmb_baudrate.Enabled = false;
                    btn_reflesh.Enabled = false;
                    btn_led1.Enabled = true;
                    btn_led2.Enabled = true;
                    btn_led3.Enabled = true;
                    btn_led4.Enabled = true;
                    txtb_receive.Enabled = true;

                    //add callback handler for receiving
                    Serial.DataReceived += new SerialDataReceivedEventHandler(SerialOnReceivedHandler);
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            // update all list again if user requested
            UpdateComPortList();
        }



        private void SendLedCommand(string cmd)
        {
            if (Serial != null && Serial.IsOpen)
            {
                txtb_receive.Text = "";
                Serial.Write(cmd);
            }
            else
            {
                MessageBox.Show("COM Port açık değil");
            }
        }

        private void btn_led1_Click(object sender, EventArgs e) => SendLedCommand("1");
        private void btn_led2_Click(object sender, EventArgs e) => SendLedCommand("3");
        private void btn_led3_Click(object sender, EventArgs e) => SendLedCommand("5");
        private void btn_led4_Click(object sender, EventArgs e) => SendLedCommand("7");

    }
}
