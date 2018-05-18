namespace VIKO_Communication_Protocol_DEMO
{
    partial class BTForm
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
            this.components = new System.ComponentModel.Container();
            this.myserialPort = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelSicaklik = new System.Windows.Forms.Label();
            this.slider = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelKademe = new System.Windows.Forms.Label();
            this.butonPompa = new System.Windows.Forms.Button();
            this.butonFan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // myserialPort
            // 
            this.myserialPort.PortName = "COM7";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(25, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sıcaklık: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSicaklik
            // 
            this.labelSicaklik.Location = new System.Drawing.Point(81, 50);
            this.labelSicaklik.Name = "labelSicaklik";
            this.labelSicaklik.Size = new System.Drawing.Size(50, 25);
            this.labelSicaklik.TabIndex = 1;
            // 
            // slider
            // 
            this.slider.Location = new System.Drawing.Point(30, 110);
            this.slider.Maximum = 4;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(315, 45);
            this.slider.TabIndex = 2;
            this.slider.Scroll += new System.EventHandler(this.slider_Scroll);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(30, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kademe: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelKademe
            // 
            this.labelKademe.Location = new System.Drawing.Point(85, 160);
            this.labelKademe.Name = "labelKademe";
            this.labelKademe.Size = new System.Drawing.Size(30, 25);
            this.labelKademe.TabIndex = 4;
            this.labelKademe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // butonPompa
            // 
            this.butonPompa.Location = new System.Drawing.Point(352, 110);
            this.butonPompa.Name = "butonPompa";
            this.butonPompa.Size = new System.Drawing.Size(115, 25);
            this.butonPompa.TabIndex = 5;
            this.butonPompa.Text = "Pompa Çalıştır";
            this.butonPompa.UseVisualStyleBackColor = true;
            this.butonPompa.Click += new System.EventHandler(this.butonPompa_Click);
            // 
            // butonFan
            // 
            this.butonFan.AutoSize = true;
            this.butonFan.Location = new System.Drawing.Point(334, 49);
            this.butonFan.Name = "butonFan";
            this.butonFan.Size = new System.Drawing.Size(135, 25);
            this.butonFan.TabIndex = 6;
            this.butonFan.Text = "Havalandırma Aktif Değil";
            this.butonFan.UseVisualStyleBackColor = true;
            this.butonFan.Click += new System.EventHandler(this.butonFan_Click);
            // 
            // BTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 531);
            this.Controls.Add(this.butonFan);
            this.Controls.Add(this.butonPompa);
            this.Controls.Add(this.labelKademe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.labelSicaklik);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BTForm";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hide);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BTForm_FormClosed);
            this.Load += new System.EventHandler(this.BTForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort myserialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSicaklik;
        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelKademe;
        private System.Windows.Forms.Button butonPompa;
        private System.Windows.Forms.Button butonFan;
    }
}