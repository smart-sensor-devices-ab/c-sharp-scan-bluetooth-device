using System;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scan_BLE_devices
{
    public partial class Form1 : Form
    {
        SerialPort mySerialPort = new SerialPort("COM18", 57600, Parity.None, 8, StopBits.One);
        public Form1()
        {
            InitializeComponent();
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(mySerialPort_DataReceived);
            mySerialPort.Open();

        }

        //print response from the dongle
        private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string s = sp.ReadExisting();
            output_data.Invoke(new EventHandler(delegate { output_data.Text += s + "\r\n"; }));
            //lbl_output.Invoke(this.myDelegate, new Object[] { s });
        }





   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_disconnect_Click_1(object sender, EventArgs e)
        {
            mySerialPort.Close();
            Environment.Exit(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lbl_test.Text = "Connected";
        }

        private void submit_cmd_Click_1(object sender, EventArgs e)
        {
            output_data.Text = "";
            byte[] bytes = Encoding.UTF8.GetBytes("AT+CENTRAL");
            var inputByte = new byte[] { 13 };
            bytes = bytes.Concat(inputByte).ToArray();
            mySerialPort.Write(bytes, 0, bytes.Length);

            System.Threading.Thread.Sleep(1000);
            output_data.Text = "";
            byte[] bytes2 = Encoding.UTF8.GetBytes("AT+GAPSCAN=3");
            var inputByte2 = new byte[] { 13 };
            bytes2 = bytes2.Concat(inputByte2).ToArray();
            mySerialPort.Write(bytes2, 0, bytes2.Length);
            //System.Threading.Thread.Sleep(3000);
        }

        private void output_data_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
