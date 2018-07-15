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

namespace ArduinoRGB
{
 
    public partial class Form1 : Form
    {
        bool checkr = true;
        bool checkb = true;
        bool checkg = true;

        public SerialPort myport;

        public Form1()
        {
            InitializeComponent();
            initPorts();
        }

        private void initPorts()
        {
            myport = new SerialPort();
            myport.BaudRate = 9600;
            myport.PortName = "COM7";
            myport.Open();


            red.Enabled = true;
            green.Enabled = true;
            blue.Enabled = true;
            off.Enabled = false;
        }


        private void green_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Enabled = true;
            if (checkg == true)
            {
                myport.WriteLine("g");
                checkg = false;
                clickedButton.BackColor = Color.LightGreen;
                off.Enabled = true;
            }
            else if(checkg == false)
            {
                myport.WriteLine("o");
                checkg = true;
                clickedButton.BackColor = Color.Gainsboro;
            }
        }

        private void blue_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Enabled = true;
            
            if (checkb == true)
            {
                myport.WriteLine("b");
                checkb = false;
                clickedButton.BackColor = Color.LightSkyBlue;
                off.Enabled = true;
            }
            else if (checkb == false)
            {
                myport.WriteLine("o");
                checkb = true;
                clickedButton.BackColor = Color.Gainsboro;
            }
        }

        private void off_Click(object sender, EventArgs e)
        {
            checkr = true;
            checkg = true;
            checkb = true;
            myport.WriteLine("o");
            red.Enabled = true;
            red.BackColor = Color.Gainsboro;
            green.Enabled = true;
            green.BackColor = Color.Gainsboro;
            blue.Enabled = true;
            blue.BackColor = Color.Gainsboro;
            off.Enabled = false;
        }

        private void red_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Enabled = true;

            if (checkr == true)
            {
                myport.WriteLine("r");
                checkr = false;
                clickedButton.BackColor = Color.LightCoral;
                off.Enabled = true;
            }
            else if (checkr == false)
            {
                myport.WriteLine("o");
                checkr = true;
                clickedButton.BackColor = Color.Gainsboro;
            }
        }
    }
}
