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
        string dC1, dC2;
        string rpM1, rpM2;
        string modE;
        
        private Form1 mainForm = null; 
        public Form2(string dC1, string dC2,string rpM1,string rpM2,string modE)
        {
           // this.serial1 = serial;
            this.dC1 = dC1;  
            this.dC2 = dC2;
            this.rpM1 = rpM1;
            this.rpM2 = rpM2;
            this.modE = modE;
     
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
            dC1  = Duty1.Text;
            dC2 =  Duty2.Text;
            rpM1 = speed_motor_R.Text;
            rpM2 = speed_motor_R.Text;
            // listBox1.Items.Add("#" + "" + dC1 + "" + dC2 + "" rpM1 + "" + rpM2);
            string show;
            show = ("#" +" "+dC1+" "+dC2+" "+" "+rpM2+" "+rpM2);
            listBox1.Items.Add(show);
        }
    }
}
