using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace cru_robot
{
    public partial class Form1 : Form
    {   
        public int dc1, dc2;
        public int rpm1, rpm2;
        public int mode;


        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        public static int adan = 10;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //----------------camera---------------------------
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            comboBox2.Items.Add(filterInfo.Name);
            comboBox2.SelectedIndex = 0;
            videoCaptureDevice =  new VideoCaptureDevice();
            //------------------------serialPort1------------
            string[] ports=SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            comboBox1.SelectedIndex = 0;
            offsp.Enabled = false;
            comboBox3.Text = "115200";
            


        }
        

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox2.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning) { videoCaptureDevice.Stop(); }
            serialPort1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Connectsp.Enabled = false;
            button1.Enabled = true;
            offsp.Enabled = true;
            try 
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox3.Text);
                serialPort1.Open();
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Connectsp.Enabled = true;
            offsp.Enabled = false;
            try
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(this);
            form.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
          
                
                string show;
                show = ("#" + " " + "0" + " " + "0" + " " + "0" + " " + "0" + " " + "0" + "\n");
                serialPort1.Write(show);
                listBox1.Items.Add(show);
                   
                
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button1.Focus();
               
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //serialPort1.ReadTo(listBox1.Text.a);
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.W://F
                    string show1;
                   // show1 = ("#" + " " + dc1 + " " + dc2 + " " + rpm2 + " " + rpm2 +" "+ mode);
                  // show1 = ("#" + " " + "-" + dc1 + " " + "-" + dc2 + " " + rpm2 + " " + rpm2 + " " + mode +"\n");
                   show1 = ("# -" + dc1 + " " + "-" + rpm1 + " " + dc2 + " " + rpm2 + " " + mode + "\n");
                    serialPort1.Write(show1);
                    listBox1.Items.Add(show1);  

                    break;
                case Keys.A://R
                    string show2;
                   // show2 = ("#" + " " + "-" + dc1 + " " + dc2 + " " + rpm2 + " " + rpm2 +" "+ mode + "\n");
                    show2 = ("# -" + dc1 + " " + rpm1 + " " + dc2 + " " + rpm2 + " " + mode + "\n");
                    serialPort1.Write(show2);
                    listBox1.Items.Add(show2);
                        

                    break;
                case Keys.S://B
                    string show3;
                    //show3 = ("#" + " " + "-" + dc1 + " " + "-" + dc2 + " " + rpm2 + " " + rpm2 +" "+ mode);
                   // show3 = ("#" + " " + dc1 + " " + dc2 + " " + rpm2 + " " + rpm2 + " " + mode + "\n");
                    show3 = ("# " + dc1 + " " + rpm1 + " " + dc2 + " " + rpm2 + " " + mode + "\n");
                    serialPort1.Write(show3);
                    listBox1.Items.Add(show3);

                    break;
                case Keys.D://L
                    string show4;
                   // show4 = ("#" + " " + dc1 + " " + "-" + dc2 + " " + rpm2 + " " + rpm2 +" "+ mode + "\n");
                    show4 = ("# " + dc1 + " " + "-" + rpm1 + " " + dc2 + " " + rpm2 + " " + mode + "\n");
                    serialPort1.Write(show4);
                    listBox1.Items.Add(show4);

                    break;
            }
        }
    }
}
