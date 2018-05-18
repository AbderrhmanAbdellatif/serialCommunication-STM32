using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VIKO_Communication_Protocol_DEMO
{
    public partial class BTForm : Form
    {

        int data = 0;
        Thread childThread;

        public void CallToChildThread()
        {
            while (true)
            {
                try
                {
                    myserialPort.Write("C");
                    Thread.Sleep(500);
                    data = myserialPort.ReadByte();
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.labelSicaklik.Text = data.ToString();
                    });

                    Thread.Sleep(1000);
                    Console.WriteLine(data);
                }
                catch(ThreadInterruptedException ex)
                {
                    Thread.Sleep(2000);
                }
                
                
            }
        }
        

        public BTForm()
        {
            InitializeComponent();
        }

        private void Hide(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
        
        private void BTForm_Load(object sender, EventArgs e)
        {
            try
            {
                myserialPort.PortName = "COM7";
                myserialPort.Open();
                Console.WriteLine("Opened");

                labelKademe.Text = "0";

                ThreadStart childref = new ThreadStart(CallToChildThread);
                childThread = new Thread(childref);
                childThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myserialPort.IsOpen)
            {
                myserialPort.Close();
            }
        }

        private void butonFan_Click(object sender, EventArgs e)
        {
            childThread.Interrupt();
            if(butonFan.Text == "Havalandırma Aktif Değil")
            {
                myserialPort.Write("A");
                butonFan.Text = "Havalandırma Aktif";
            }
            else if(butonFan.Text == "Havalandırma Aktif")
            {
                myserialPort.Write("B");
                butonFan.Text = "Havalandırma Aktif Değil";
            }
        }

        private void slider_Scroll(object sender, EventArgs e)
        {
            labelKademe.Text = slider.Value + "";
        }

        private void butonPompa_Click(object sender, EventArgs e)
        {
            childThread.Interrupt();
            string value = slider.Value.ToString();
            myserialPort.Write(value);
        }
    }
}
