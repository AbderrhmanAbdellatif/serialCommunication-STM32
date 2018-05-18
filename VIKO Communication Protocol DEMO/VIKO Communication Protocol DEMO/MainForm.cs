using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIKO_Communication_Protocol_DEMO
{
    public partial class MainForm : Form
    {
        enum encoding { bin , hex, ascii};
        encoding currentEncoding = encoding.bin;
        SerialPort port;
        int leds;
        int gpios;
        int relays;
        int buzzers;

        BTForm btForm;
        
        public MainForm()
        {
            InitializeComponent();
        }
        void writeLog(string message, bool isError)
        {
            logManager(this.richTextBox1, message, isError);
        }

        void logManager(RichTextBox box, string message, bool isError)
        {
            int start = box.TextLength;
            box.AppendText(DateTime.Now.ToString() + ":\t" + message + "\n");
            int end = box.TextLength;

            box.Select(start, end - start);
            {
                box.SelectionColor = isError ? Color.Firebrick : Color.SeaGreen;
                box.SelectionFont = new Font(box.Font, FontStyle.Bold);
            }

            box.SelectionLength = 0;
        }

        private void drawTabControl(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
        }

        private void switchBin(object sender, EventArgs e)
        {
            if (currentEncoding == encoding.bin) return;
            else
            {
                string transmitString = transmitText.Text.Replace(" ", string.Empty);
                string lastSentString = lastSentText.Text.Replace(" ", string.Empty);
                string lastReceivedString = lastReceivedText.Text.Replace(" ", string.Empty);

                switch (currentEncoding)
                {
                    case encoding.hex:
                        {
                            transmitString = Regex.Replace(HexStringToBinaryString(transmitString), @"(.{8})", "$1 ");
                            transmitText.Text = transmitString;

                            lastSentString = Regex.Replace(HexStringToBinaryString(lastSentString), @"(.{8})", "$1 ");
                            lastSentText.Text = lastSentString;

                            lastReceivedString = Regex.Replace(HexStringToBinaryString(lastReceivedString), @"(.{8})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            break;
                        }
                    case encoding.ascii:
                        {
                            transmitString = Regex.Replace(AsciiStringToBinaryString(transmitString), @"(.{8})", "$1 ");
                            transmitText.Text = transmitString;

                            lastSentString = Regex.Replace(AsciiStringToBinaryString(lastSentString), @"(.{8})", "$1 ");
                            lastSentText.Text = lastSentString;

                            lastReceivedString = Regex.Replace(AsciiStringToBinaryString(lastReceivedString), @"(.{8})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            break;
                        }
                }

                binRadio1.Checked = true;
                binRadio2.Checked = true;
                currentEncoding = encoding.bin;
            }
        }

        private void switchBin()
        {
            if (currentEncoding == encoding.bin) return;
            else
            {
                string transmitString = transmitText.Text.Replace(" ", string.Empty);
                string lastSentString = lastSentText.Text.Replace(" ", string.Empty);
                string lastReceivedString = lastReceivedText.Text.Replace(" ", string.Empty);

                switch (currentEncoding)
                {
                    case encoding.hex:
                        {
                            transmitString = Regex.Replace(HexStringToBinaryString(transmitString), @"(.{8})", "$1 ");
                            transmitText.Text = transmitString;

                            lastSentString = Regex.Replace(HexStringToBinaryString(lastSentString), @"(.{8})", "$1 ");
                            lastSentText.Text = lastSentString;

                            lastReceivedString = Regex.Replace(HexStringToBinaryString(lastReceivedString), @"(.{8})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            break;
                        }
                    case encoding.ascii:
                        {
                            transmitString = Regex.Replace(AsciiStringToBinaryString(transmitString), @"(.{8})", "$1 ");
                            transmitText.Text = transmitString;

                            lastSentString = Regex.Replace(AsciiStringToBinaryString(lastSentString), @"(.{8})", "$1 ");
                            lastSentText.Text = lastSentString;

                            lastReceivedString = Regex.Replace(AsciiStringToBinaryString(lastReceivedString), @"(.{8})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            break;
                        }
                }

                binRadio1.Checked = true;
                binRadio2.Checked = true;
                currentEncoding = encoding.bin;
            }
        }

        private void switchHex(object sender, EventArgs e)
        {
            if (currentEncoding == encoding.hex) return;
            else
            {
                string transmitString = transmitText.Text.Replace(" ", string.Empty);
                string lastSentString = lastSentText.Text.Replace(" ", string.Empty);
                string lastReceivedString = lastReceivedText.Text.Replace(" ", string.Empty);

                switch (currentEncoding)
                {
                    case encoding.bin:
                        {
                            transmitString = Regex.Replace(BinaryStringToHexString(transmitString), @"(.{2})", "$1 ");
                            transmitText.Text = transmitString;

                            lastSentString = Regex.Replace(BinaryStringToHexString(lastSentString), @"(.{2})", "$1 ");
                            lastSentText.Text = lastSentString;

                            lastReceivedString = Regex.Replace(BinaryStringToHexString(lastReceivedString), @"(.{2})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            break;
                        }
                    case encoding.ascii:
                        {

                            transmitString = Regex.Replace(AsciiStringToHexString(transmitString), @"(.{2})", "$1 ");
                            transmitText.Text = transmitString;

                            lastSentString = Regex.Replace(AsciiStringToHexString(lastSentString), @"(.{2})", "$1 ");
                            lastSentText.Text = lastSentString;

                            lastReceivedString = Regex.Replace(AsciiStringToHexString(lastReceivedString), @"(.{2})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            break;
                        }
                }

                hexRadio1.Checked = true;
                hexRadio2.Checked = true;
                currentEncoding = encoding.hex;
            }
        }

        private void switchHex()
        {
            if (currentEncoding == encoding.hex) return;
            else
            {
                string transmitString = transmitText.Text.Replace(" ", string.Empty);
                string lastSentString = lastSentText.Text.Replace(" ", string.Empty);
                string lastReceivedString = lastReceivedText.Text.Replace(" ", string.Empty);

                switch (currentEncoding)
                {
                    case encoding.bin:
                        {
                            transmitString = Regex.Replace(BinaryStringToHexString(transmitString), @"(.{2})", "$1 ");
                            transmitText.Text = transmitString;

                            lastSentString = Regex.Replace(BinaryStringToHexString(lastSentString), @"(.{2})", "$1 ");
                            lastSentText.Text = lastSentString;

                            lastReceivedString = Regex.Replace(BinaryStringToHexString(lastReceivedString), @"(.{2})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            break;
                        }
                    case encoding.ascii:
                        {

                            transmitString = Regex.Replace(AsciiStringToHexString(transmitString), @"(.{2})", "$1 ");
                            transmitText.Text = transmitString;

                            lastSentString = Regex.Replace(AsciiStringToHexString(lastSentString), @"(.{2})", "$1 ");
                            lastSentText.Text = lastSentString;

                            lastReceivedString = Regex.Replace(AsciiStringToHexString(lastReceivedString), @"(.{2})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            break;
                        }
                }

                hexRadio1.Checked = true;
                hexRadio2.Checked = true;
                currentEncoding = encoding.hex;
            }
        }

        private void switchAscii(object sender, EventArgs e)
        {
            if (currentEncoding == encoding.ascii) return;
            else
            {
                string transmitString = transmitText.Text.Replace(" " , string.Empty);
                string lastSentString = lastSentText.Text.Replace(" ", string.Empty);
                string lastReceivedString = lastReceivedText.Text.Replace(" ", string.Empty);

                switch (currentEncoding)
                {
                    case encoding.hex:
                        {
                            transmitString = Regex.Replace(HexStringToAsciiString(transmitString), @"(.{1})", "$1 ");
                            transmitText.Text = transmitString;

                            lastSentString = Regex.Replace(HexStringToAsciiString(lastSentString), @"(.{1})", "$1 ");
                            lastSentText.Text = lastSentString;

                            lastReceivedString = Regex.Replace(HexStringToAsciiString(lastReceivedString), @"(.{1})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            break;
                        }
                    case encoding.bin:
                        {
                            transmitString = Regex.Replace(BinaryStringToAsciiString(transmitString), @"(.{1})", "$1 ");
                            transmitText.Text = transmitString;

                            lastReceivedString = Regex.Replace(BinaryStringToAsciiString(lastReceivedString), @"(.{1})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            lastSentString = Regex.Replace(BinaryStringToAsciiString(lastSentString), @"(.{1})", "$1 ");
                            lastSentText.Text = lastSentString;

                            break;
                        }
                }

                asciiRadio1.Checked = true;
                asciiRadio2.Checked = true;
                currentEncoding = encoding.ascii;
            }
        }

        private void switchAscii()
        {
            if (currentEncoding == encoding.ascii) return;
            else
            {
                string transmitString = transmitText.Text.Replace(" ", string.Empty);
                string lastSentString = lastSentText.Text.Replace(" ", string.Empty);
                string lastReceivedString = lastReceivedText.Text.Replace(" ", string.Empty);

                switch (currentEncoding)
                {
                    case encoding.hex:
                        {
                            transmitString = Regex.Replace(HexStringToAsciiString(transmitString), @"(.{1})", "$1 ");
                            transmitText.Text = transmitString;

                            lastSentString = Regex.Replace(HexStringToAsciiString(lastSentString), @"(.{1})", "$1 ");
                            lastSentText.Text = lastSentString;

                            lastReceivedString = Regex.Replace(HexStringToAsciiString(lastReceivedString), @"(.{1})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            break;
                        }
                    case encoding.bin:
                        {
                            transmitString = Regex.Replace(BinaryStringToAsciiString(transmitString), @"(.{1})", "$1 ");
                            transmitText.Text = transmitString;

                            lastReceivedString = Regex.Replace(BinaryStringToAsciiString(lastReceivedString), @"(.{1})", "$1 ");
                            lastReceivedText.Text = lastReceivedString;

                            lastSentString = Regex.Replace(BinaryStringToAsciiString(lastSentString), @"(.{1})", "$1 ");
                            lastSentText.Text = lastSentString;

                            break;
                        }
                }

                asciiRadio1.Checked = true;
                asciiRadio2.Checked = true;
                currentEncoding = encoding.ascii;
            }
        }

        public static string BinaryStringToHexString(string binary)
        {
            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }

        public static string AsciiStringToHexString(string ascii)
        {
            StringBuilder sb = new StringBuilder();

            byte[] inputBytes = Encoding.UTF8.GetBytes(ascii);

            foreach (byte b in inputBytes)

            {

                sb.Append(string.Format("{0:x2}", b));

            }

            return sb.ToString();

        }

        public static string HexStringToBinaryString(string hex)
        {
            string binaryString = String.Join(String.Empty,
             hex.Select(
               c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
             )
           );

            return binaryString;
        }

        public static string AsciiStringToBinaryString(string ascii)
        {
            StringBuilder binaryString = new StringBuilder();
            foreach(byte b in ascii)
            {
                binaryString.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }

            return binaryString.ToString();       
        }

        public static string BinaryStringToAsciiString(string binary)
        {
            var list = new List<Byte>();

            for (int i = 0; i < binary.Length; i += 8)
            {
                String t = binary.Substring(i, 8);

                list.Add(Convert.ToByte(t, 2));
            }

            var bytes = list.ToArray();
            return Encoding.ASCII.GetString(bytes);
        }

        public static string HexStringToAsciiString(string hex)
        {
            StringBuilder asciiString = new StringBuilder();
            for (int i = 0; i < hex.Length; i += 2)
            {
                string hs = hex.Substring(i, 2);
                asciiString.Append(Convert.ToChar(Convert.ToUInt32(hs, 16)));
            }

            return asciiString.ToString();
        }

        public static byte[] StringHexToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }

        public static string ByteArrayToStringHex(byte[] bytes)
        {
            StringBuilder hex = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
            hex.AppendFormat("{0:x2}", b);

            return hex.ToString();
        }

        public static string getBCC(byte[] bytes)
        {
            byte bcc = 0;

            if (bytes != null && bytes.Length > 0)
            {
                for (int i = 5; i < bytes.Length; i++)
                {
                    bcc ^= bytes[i];
                }
            }
            string bccStr = Convert.ToString(bcc, 2).PadLeft(8, '0');
            return bccStr;
        }

        private void openBT(object sender, EventArgs e)
        {
            if(btForm == null) btForm = new BTForm(this);
            btForm.Visible = true;
        }

        private void setLED(object sender, MouseEventArgs e)
        {
            string address = string.Empty;
            int padding;
            switchBin();

            StringBuilder command = new StringBuilder();

            // Appending starting characters "VK16"
            command.Append("01010110010010110011000100110110");

            // Appending length
            command.Append("00000111");

            // Appending packet type REQUEST character "REQ"
            command.Append("010100100100010101010001");

            // Appending command SET character "S"
            command.Append("01010011");

            // Appending group one (LEDs group)
            command.Append("00000001");


            // Appending module address
            for (int i = 0; i < ledList.Items.Count; i++)
            {
                if (ledList.GetItemChecked(i)) address = "1" + address;
                else address = "0" + address;
            }

            padding = (1 + address.Length / 16) * 16;
            address = address.PadLeft(padding, '0');

            command.Append(address);

            // Appending BCC

            byte[] bytes = BinaryStringToBytesArray(command.ToString());

            string bcc = getBCC(bytes);

            command.Append(bcc);

            string commandString = Regex.Replace(command.ToString(), @"(.{8})", "$1 ");

            transmitText.Text = commandString;
        }

        private void setGPIO(object sender, MouseEventArgs e)
        {
            string address = string.Empty;
            int padding;
            switchBin();

            StringBuilder command = new StringBuilder();

            // Appending starting characters "VK16"
            command.Append("01010110010010110011000100110110");

            // Appending length
            command.Append("00000111");

            // Appending packet type REQUEST character "REQ"
            command.Append("010100100100010101010001");

            // Appending command SET character "S"
            command.Append("01010011");

            // Appending group two (GPIOs group)
            command.Append("00000010");

            for (int i = 0; i < gpioList.Items.Count; i++)
            {
                if (gpioList.GetItemChecked(i)) address = "1" + address;
                else address = "0" + address;
            }

            padding = (1 + address.Length / 16) * 16;
            address = address.PadLeft(padding, '0');

            command.Append(address);

            // Appending BCC

            byte[] bytes = BinaryStringToBytesArray(command.ToString());

            string bcc = getBCC(bytes);

            command.Append(bcc);

            string commandString = Regex.Replace(command.ToString(), @"(.{8})", "$1 ");

            transmitText.Text = commandString;
        }

        private void setBUZZER(object sender, MouseEventArgs e)
        {
            string address = string.Empty;
            int padding;
            switchBin();

            StringBuilder command = new StringBuilder();

            // Appending starting characters "VK16"
            command.Append("01010110010010110011000100110110");

            // Appending length
            command.Append("00000111");

            // Appending packet type REQUEST character "REQ"
            command.Append("010100100100010101010001");

            // Appending command SET character "S"
            command.Append("01010011");

            // Appending group three (GPIOs group)
            command.Append("00000011");

            for (int i = 0; i < buzzerList.Items.Count; i++)
            {
                if (buzzerList.GetItemChecked(i)) address = "1" + address;
                else address = "0" + address;
            }

            padding = (1 + address.Length / 16) * 16;
            address = address.PadLeft(padding, '0');

            command.Append(address);

            // Appending BCC

            byte[] bytes = BinaryStringToBytesArray(command.ToString());

            string bcc = getBCC(bytes);

            command.Append(bcc);

            string commandString = Regex.Replace(command.ToString(), @"(.{8})", "$1 ");

            transmitText.Text = commandString;
        }

        private void setRELAY(object sender, MouseEventArgs e)
        {
            string address = string.Empty;
            int padding;
            switchBin();

            StringBuilder command = new StringBuilder();

            // Appending starting characters "VK16"
            command.Append("01010110010010110011000100110110");

            // Appending length
            command.Append("00000111");

            // Appending packet type REQUEST character "REQ"
            command.Append("010100100100010101010001");

            // Appending command SET character "S"
            command.Append("01010011");

            // Appending group four (GPIOs group)
            command.Append("00000100");

            for (int i = 0; i < relayList.Items.Count; i++)
            {
                if (relayList.GetItemChecked(i)) address = "1" + address;
                else address = "0" + address;
            }

            padding = (1 + address.Length / 16) * 16;
            address = address.PadLeft(padding, '0');

            command.Append(address);

            // Appending BCC

            byte[] bytes = BinaryStringToBytesArray(command.ToString());

            string bcc = getBCC(bytes);

            command.Append(bcc);

            string commandString = Regex.Replace(command.ToString(), @"(.{8})", "$1 ");

            transmitText.Text = commandString;
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            portsBox.DataSource = ports;
        }

        private void connectRS232(object sender, EventArgs e)
        {
            port = new SerialPort(portsBox.Text, 9600, Parity.None, 8, StopBits.One);
            writeLog("Connected to " + port.PortName + ", Baud Rate: " + port.BaudRate + ".",false);
            //port.DtrEnable = true;
            port.Open();
            //port.DataReceived += new SerialDataReceivedEventHandler(interruptHandler);
        }

        //private void interruptHandler(object sender, SerialDataReceivedEventArgs e)
        //{
        //    int dataLength = port.BytesToRead;
        //    byte[] data = new byte[dataLength];
        //    int nbrDataRead = port.Read(data, 0, dataLength);

        //    if (nbrDataRead == 0)
        //    {
        //        return;
        //    }
        //    // Send data to whom ever interested
        //    parser(data);
        //}

        //private void parser(byte[] packet)
        //{
        //    // Add packet to last recieved box
        //    lastReceivedText.Text = Regex.Replace(string.Concat(packet.Select(b => Convert.ToString(b, 2).PadLeft(8, '0'))).ToString(), @"(.{8})", "$1 ");

        //    // Parse
        //    if(packet[8] == 0x21)
        //    {
        //        MessageBox.Show("Negative ACK recieved. Something is not right.");
        //    }
        //}

        private string seperator(string str , encoding usedEncoding)
        {
            string seperated;

            switch (usedEncoding)
            {
                case encoding.bin:
                    {
                        seperated = Regex.Replace(AsciiStringToBinaryString(str), @"(.{8})", "$1 ");
                        break;
                    }
                case encoding.hex:
                    {
                        seperated = Regex.Replace(AsciiStringToBinaryString(str), @"(.{2})", "$1 ");
                        break;
                    }
                case encoding.ascii:
                    {
                        seperated = Regex.Replace(AsciiStringToBinaryString(str), @"(.{1})", "$1 ");
                        break;
                    }
                default:
                    {
                        seperated = string.Empty;
                        break;
                    }

            }

            return seperated;
        }

        private string deSeperator(string str)
        {
            return str.Replace(" ", string.Empty);
        }

        private byte[] BinaryStringToBytesArray(string binary)
        {
            int numOfBytes = binary.Length / 8;
            byte[] bytes = new byte[numOfBytes];
            for (int i = 0; i < numOfBytes; ++i)
            {
                bytes[i] = Convert.ToByte(binary.Substring(8 * i, 8), 2);
            }

            return bytes;
        }

        private void onClick(object sender, EventArgs e)
        {
            StringBuilder commandStr = new StringBuilder();

            commandStr.Append("010101100100101100110001001101100000010001010010010001010101000101001111");
            byte[] bytes = BinaryStringToBytesArray(commandStr.ToString());

            string bcc = getBCC(bytes);

            commandStr.Append(bcc);
            byte[] packet = BinaryStringToBytesArray(commandStr.ToString());


            port.Write(packet , 0 , packet.Length);

            switchBin();
            lastSentText.Text = Regex.Replace(commandStr.ToString(), @"(.{8})", "$1 ");

        }

        private void testBCC(object sender, EventArgs e)
        {
            var str = testBox.Text.Replace(" ", string.Empty);

            byte[] bytes = BinaryStringToBytesArray(str.ToString());

            string bcc = getBCC(bytes);

            bccBox.Text = bcc;
        }

        private void sendCommand(object sender, EventArgs e)
        {
            string commandStr = deSeperator(transmitText.Text);

            byte[] packet = BinaryStringToBytesArray(commandStr.ToString());

            port.Write(packet, 0, packet.Length);

            switchBin();
            lastSentText.Text = Regex.Replace(commandStr.ToString(), @"(.{8})", "$1 ");
        }

        private void resetClick(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                StringBuilder commandStr = new StringBuilder();

                commandStr.Append("010101100100101100110001001101100000010001010010010001010101000101010010");
                byte[] bytes = BinaryStringToBytesArray(commandStr.ToString());

                string bcc = getBCC(bytes);

                commandStr.Append(bcc);
                byte[] packet = BinaryStringToBytesArray(commandStr.ToString());

                port.Write(packet, 0, packet.Length);

                switchBin();
                lastSentText.Text = Regex.Replace(commandStr.ToString(), @"(.{8})", "$1 ");
            }
        }

        private void formClose(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Close();
                }
            }
            catch (Exception) { }
        }


    }
}
