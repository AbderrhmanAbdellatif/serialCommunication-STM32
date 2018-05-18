using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        int[] seri = {
            0001,0010,0011,0100,0101,0110,
            0111,1000,1001,1010,1011,1100,1111
        };
        int[] values = {
            1,0,1,0,1,1,1,0,0
        };
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) { serialPort1.Close(); }
            foreach (String portNames in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(portNames);
            }

            comboBox2.Items.Add(115200);
            comboBox2.Items.Add(9600);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.BaudRate = (int)comboBox2.SelectedItem;

            serialPort1.Open();

            //richTextBox1.Text += serialPort1.ReadLine();
        }
        int counter = 0;
        public void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            //richTextBox1.Text += serialPort1.ReadLine();
            label1.Text = serialPort1.ReadLine();



        }

        private void button2_Click(object sender, EventArgs e)
        {


            chart1.Series["test1"].Color = Color.Red;

            chart1.Series["test2"].Color = Color.Blue;
        }
        
    }
}