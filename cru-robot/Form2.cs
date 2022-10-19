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
        SerialPort serial1;
        private Form1 mainForm = null; 
        public Form2(SerialPort serial)
        {
            this.serial1 = serial;
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
            
        }
    }
}
