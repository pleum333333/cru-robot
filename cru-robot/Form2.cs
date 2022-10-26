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
 
namespace cru_robot
{
    public partial class Form2 : Form
    {
        //SerialPort serial1;
        
        
        private Form1 form1 = null; 
        public Form2(Form1 form1)
        {
            // this.serial1 = serial;
            this.form1 = form1;
            
     
            InitializeComponent();
        }
        
            
        private void label18_Click(object sender, EventArgs e)
        {
         
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void writebutton_Click(object sender, EventArgs e)
        {
            form1.dc1  = Int32.Parse(Duty1.Text);
            form1.dc2  = Int32.Parse(Duty2.Text);
            form1.rpm1 = Int32.Parse(speed_motor_R.Text);
            form1.rpm2 = Int32.Parse(speed_motor_R.Text);
            form1.mode = Int32.Parse(comboBox1.Text);
            // listBox1.Items.Add("#" + "" + dC1 + "" + dC2 + "" rpM1 + "" + rpM2);
            string show;
            show = ("#" +" "+ form1.dc1 + " "+ form1.dc2 + " "+" "+ form1.rpm1 + " "+ form1.rpm2);
            listBox1.Items.Add(show);
        }
    }
}
