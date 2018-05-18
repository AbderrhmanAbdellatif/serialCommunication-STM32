namespace VIKO_Communication_Protocol_DEMO
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.transmitText = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.relayList = new System.Windows.Forms.CheckedListBox();
            this.gpioList = new System.Windows.Forms.CheckedListBox();
            this.ledList = new System.Windows.Forms.CheckedListBox();
            this.buzzerList = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lastSentText = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.asciiRadio1 = new System.Windows.Forms.RadioButton();
            this.hexRadio1 = new System.Windows.Forms.RadioButton();
            this.binRadio1 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buzzerMonitorList = new System.Windows.Forms.CheckedListBox();
            this.relayMonitorList = new System.Windows.Forms.CheckedListBox();
            this.ledMonitorList = new System.Windows.Forms.CheckedListBox();
            this.gpioMonitorList = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lastReceivedText = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.asciiRadio2 = new System.Windows.Forms.RadioButton();
            this.hexRadio2 = new System.Windows.Forms.RadioButton();
            this.binRadio2 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.portsBox = new System.Windows.Forms.ComboBox();
            this.bccBox = new System.Windows.Forms.TextBox();
            this.bccButton = new System.Windows.Forms.Button();
            this.testBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox7.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 584);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1294, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.transmitText);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(506, 229);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Bytes to transmit";
            // 
            // transmitText
            // 
            this.transmitText.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.transmitText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmitText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.transmitText.Location = new System.Drawing.Point(6, 14);
            this.transmitText.Name = "transmitText";
            this.transmitText.Size = new System.Drawing.Size(494, 209);
            this.transmitText.TabIndex = 7;
            this.transmitText.Text = "01010110 01001011 00110001 00110110";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(1150, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 478);
            this.button3.TabIndex = 5;
            this.button3.Text = "Send Command";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.sendCommand);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(1150, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 478);
            this.button4.TabIndex = 7;
            this.button4.Text = "Refresh Status";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(139, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Connect";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.connectRS232);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(12, 62);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1294, 516);
            this.tabControl.TabIndex = 9;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.drawTabControl);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1286, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Request";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.relayList, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.gpioList, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ledList, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buzzerList, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 248);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1138, 235);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // relayList
            // 
            this.relayList.FormattingEnabled = true;
            this.relayList.Items.AddRange(new object[] {
            "RELAY1"});
            this.relayList.Location = new System.Drawing.Point(855, 3);
            this.relayList.Name = "relayList";
            this.relayList.Size = new System.Drawing.Size(280, 229);
            this.relayList.TabIndex = 3;
            this.relayList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.setRELAY);
            // 
            // gpioList
            // 
            this.gpioList.FormattingEnabled = true;
            this.gpioList.Items.AddRange(new object[] {
            "GPIO1",
            "GPIO2",
            "GPIO3",
            "GPIO4",
            "GPIO5",
            "GPIO6",
            "GPIO7",
            "GPIO8",
            "GPIO9"});
            this.gpioList.Location = new System.Drawing.Point(287, 3);
            this.gpioList.Name = "gpioList";
            this.gpioList.Size = new System.Drawing.Size(278, 229);
            this.gpioList.TabIndex = 1;
            this.gpioList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.setGPIO);
            // 
            // ledList
            // 
            this.ledList.FormattingEnabled = true;
            this.ledList.Items.AddRange(new object[] {
            "LED1",
            "LED2",
            "LED3"});
            this.ledList.Location = new System.Drawing.Point(3, 3);
            this.ledList.Name = "ledList";
            this.ledList.Size = new System.Drawing.Size(278, 229);
            this.ledList.TabIndex = 0;
            this.ledList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.setLED);
            // 
            // buzzerList
            // 
            this.buzzerList.FormattingEnabled = true;
            this.buzzerList.Items.AddRange(new object[] {
            "BUZZER1"});
            this.buzzerList.Location = new System.Drawing.Point(571, 3);
            this.buzzerList.Name = "buzzerList";
            this.buzzerList.Size = new System.Drawing.Size(278, 229);
            this.buzzerList.TabIndex = 2;
            this.buzzerList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.setBUZZER);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1138, 235);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lastSentText);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(515, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 229);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Sent Request";
            // 
            // lastSentText
            // 
            this.lastSentText.BackColor = System.Drawing.Color.BlueViolet;
            this.lastSentText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastSentText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lastSentText.Location = new System.Drawing.Point(6, 14);
            this.lastSentText.Name = "lastSentText";
            this.lastSentText.ReadOnly = true;
            this.lastSentText.Size = new System.Drawing.Size(494, 209);
            this.lastSentText.TabIndex = 7;
            this.lastSentText.Text = "01010110 01001011 00110001 00110110";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bccBox);
            this.groupBox2.Controls.Add(this.bccButton);
            this.groupBox2.Controls.Add(this.testBox);
            this.groupBox2.Controls.Add(this.asciiRadio1);
            this.groupBox2.Controls.Add(this.hexRadio1);
            this.groupBox2.Controls.Add(this.binRadio1);
            this.groupBox2.Location = new System.Drawing.Point(1027, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 229);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "encoding";
            // 
            // asciiRadio1
            // 
            this.asciiRadio1.AutoSize = true;
            this.asciiRadio1.Location = new System.Drawing.Point(6, 65);
            this.asciiRadio1.Name = "asciiRadio1";
            this.asciiRadio1.Size = new System.Drawing.Size(52, 17);
            this.asciiRadio1.TabIndex = 2;
            this.asciiRadio1.Text = "ASCII";
            this.asciiRadio1.UseVisualStyleBackColor = true;
            this.asciiRadio1.Click += new System.EventHandler(this.switchAscii);
            // 
            // hexRadio1
            // 
            this.hexRadio1.AutoSize = true;
            this.hexRadio1.Location = new System.Drawing.Point(6, 42);
            this.hexRadio1.Name = "hexRadio1";
            this.hexRadio1.Size = new System.Drawing.Size(86, 17);
            this.hexRadio1.TabIndex = 1;
            this.hexRadio1.Text = "Hexadecimal";
            this.hexRadio1.UseVisualStyleBackColor = true;
            this.hexRadio1.Click += new System.EventHandler(this.switchHex);
            // 
            // binRadio1
            // 
            this.binRadio1.AutoSize = true;
            this.binRadio1.Checked = true;
            this.binRadio1.Location = new System.Drawing.Point(6, 19);
            this.binRadio1.Name = "binRadio1";
            this.binRadio1.Size = new System.Drawing.Size(54, 17);
            this.binRadio1.TabIndex = 0;
            this.binRadio1.TabStop = true;
            this.binRadio1.Text = "Binary";
            this.binRadio1.UseVisualStyleBackColor = true;
            this.binRadio1.Click += new System.EventHandler(this.switchBin);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1286, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Response";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.buzzerMonitorList, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.relayMonitorList, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.ledMonitorList, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.gpioMonitorList, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 248);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1138, 240);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // buzzerMonitorList
            // 
            this.buzzerMonitorList.FormattingEnabled = true;
            this.buzzerMonitorList.Location = new System.Drawing.Point(855, 3);
            this.buzzerMonitorList.Name = "buzzerMonitorList";
            this.buzzerMonitorList.Size = new System.Drawing.Size(280, 229);
            this.buzzerMonitorList.TabIndex = 3;
            // 
            // relayMonitorList
            // 
            this.relayMonitorList.FormattingEnabled = true;
            this.relayMonitorList.Location = new System.Drawing.Point(571, 3);
            this.relayMonitorList.Name = "relayMonitorList";
            this.relayMonitorList.Size = new System.Drawing.Size(278, 229);
            this.relayMonitorList.TabIndex = 2;
            // 
            // ledMonitorList
            // 
            this.ledMonitorList.FormattingEnabled = true;
            this.ledMonitorList.Location = new System.Drawing.Point(287, 3);
            this.ledMonitorList.Name = "ledMonitorList";
            this.ledMonitorList.Size = new System.Drawing.Size(278, 229);
            this.ledMonitorList.TabIndex = 1;
            // 
            // gpioMonitorList
            // 
            this.gpioMonitorList.FormattingEnabled = true;
            this.gpioMonitorList.Location = new System.Drawing.Point(3, 3);
            this.gpioMonitorList.Name = "gpioMonitorList";
            this.gpioMonitorList.Size = new System.Drawing.Size(278, 229);
            this.gpioMonitorList.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox9, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1138, 235);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lastReceivedText);
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1018, 229);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Last Response";
            // 
            // lastReceivedText
            // 
            this.lastReceivedText.BackColor = System.Drawing.Color.SeaGreen;
            this.lastReceivedText.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastReceivedText.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lastReceivedText.Location = new System.Drawing.Point(6, 14);
            this.lastReceivedText.Name = "lastReceivedText";
            this.lastReceivedText.Size = new System.Drawing.Size(1006, 209);
            this.lastReceivedText.TabIndex = 7;
            this.lastReceivedText.Text = "01010110 01001011 00110001 00110110";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.asciiRadio2);
            this.groupBox9.Controls.Add(this.hexRadio2);
            this.groupBox9.Controls.Add(this.binRadio2);
            this.groupBox9.Location = new System.Drawing.Point(1027, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(108, 229);
            this.groupBox9.TabIndex = 13;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "encoding";
            // 
            // asciiRadio2
            // 
            this.asciiRadio2.AutoSize = true;
            this.asciiRadio2.Location = new System.Drawing.Point(6, 65);
            this.asciiRadio2.Name = "asciiRadio2";
            this.asciiRadio2.Size = new System.Drawing.Size(52, 17);
            this.asciiRadio2.TabIndex = 2;
            this.asciiRadio2.Text = "ASCII";
            this.asciiRadio2.UseVisualStyleBackColor = true;
            this.asciiRadio2.Click += new System.EventHandler(this.switchAscii);
            // 
            // hexRadio2
            // 
            this.hexRadio2.AutoSize = true;
            this.hexRadio2.Location = new System.Drawing.Point(6, 42);
            this.hexRadio2.Name = "hexRadio2";
            this.hexRadio2.Size = new System.Drawing.Size(86, 17);
            this.hexRadio2.TabIndex = 1;
            this.hexRadio2.Text = "Hexadecimal";
            this.hexRadio2.UseVisualStyleBackColor = true;
            this.hexRadio2.Click += new System.EventHandler(this.switchHex);
            // 
            // binRadio2
            // 
            this.binRadio2.AutoSize = true;
            this.binRadio2.Checked = true;
            this.binRadio2.Location = new System.Drawing.Point(6, 19);
            this.binRadio2.Name = "binRadio2";
            this.binRadio2.Size = new System.Drawing.Size(54, 17);
            this.binRadio2.TabIndex = 0;
            this.binRadio2.TabStop = true;
            this.binRadio2.Text = "Binary";
            this.binRadio2.UseVisualStyleBackColor = true;
            this.binRadio2.Click += new System.EventHandler(this.switchBin);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(1205, 11);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 45);
            this.button5.TabIndex = 10;
            this.button5.Text = "ON";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.onClick);
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(1098, 11);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 45);
            this.button6.TabIndex = 11;
            this.button6.Text = "Reset";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.resetClick);
            // 
            // portsBox
            // 
            this.portsBox.FormattingEnabled = true;
            this.portsBox.Location = new System.Drawing.Point(12, 24);
            this.portsBox.Name = "portsBox";
            this.portsBox.Size = new System.Drawing.Size(121, 21);
            this.portsBox.TabIndex = 12;
            // 
            // bccBox
            // 
            this.bccBox.Location = new System.Drawing.Point(6, 158);
            this.bccBox.Name = "bccBox";
            this.bccBox.Size = new System.Drawing.Size(96, 20);
            this.bccBox.TabIndex = 15;
            // 
            // bccButton
            // 
            this.bccButton.Image = ((System.Drawing.Image)(resources.GetObject("bccButton.Image")));
            this.bccButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bccButton.Location = new System.Drawing.Point(6, 184);
            this.bccButton.Name = "bccButton";
            this.bccButton.Size = new System.Drawing.Size(96, 45);
            this.bccButton.TabIndex = 16;
            this.bccButton.Text = "BCC";
            this.bccButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bccButton.UseVisualStyleBackColor = true;
            this.bccButton.Click += new System.EventHandler(this.testBCC);
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(6, 88);
            this.testBox.Multiline = true;
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(96, 64);
            this.testBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 83);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 692);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.portsBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "VİKO STAJ 2016";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClose);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.groupBox7.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox transmitText;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox lastSentText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckedListBox relayList;
        private System.Windows.Forms.CheckedListBox buzzerList;
        private System.Windows.Forms.CheckedListBox gpioList;
        private System.Windows.Forms.CheckedListBox ledList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton asciiRadio1;
        private System.Windows.Forms.RadioButton hexRadio1;
        private System.Windows.Forms.RadioButton binRadio1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.CheckedListBox buzzerMonitorList;
        private System.Windows.Forms.CheckedListBox relayMonitorList;
        private System.Windows.Forms.CheckedListBox ledMonitorList;
        private System.Windows.Forms.CheckedListBox gpioMonitorList;
        private System.Windows.Forms.RichTextBox lastReceivedText;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton asciiRadio2;
        private System.Windows.Forms.RadioButton hexRadio2;
        private System.Windows.Forms.RadioButton binRadio2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox portsBox;
        private System.Windows.Forms.TextBox bccBox;
        private System.Windows.Forms.Button bccButton;
        private System.Windows.Forms.TextBox testBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

