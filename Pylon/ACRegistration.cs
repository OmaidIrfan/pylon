using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pylon
{
    public partial class ACRegistration : UserControl
    {
        public ACRegistration()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e){}

        private void ACRegistration_Load(object sender, EventArgs e)
        {
            int x;

            string s = "sta";
            // Takinga a new input stream i.e.  
            // geeksforgeeks.txt and opens it 
            StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Admin\\Status\\" + s + ".txt");

            // This is use to specify from where  
            // to start reading input stream 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            x = Convert.ToInt32(sr.ReadLine());

            // to close the stream 
            sr.Close();

            if (x==0)
            {
                radioButton2.Checked = true;
            }
            else if(x==1)
            {
                radioButton1.Checked = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {   
            int x = 1;

            string s = "sta";
            // This will create a file named sample.txt 
            // at the specified location  
            StreamWriter sw = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Admin\\Status\\" + s + ".txt");
                                   
            // To write a line in buffer 
            sw.WriteLine(x);

            // To write in output stream 
            sw.Flush();

            // To close the stream 
            sw.Close();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int x = 0;

            string s = "sta";
            // This will create a file named sample.txt 
            // at the specified location  
            StreamWriter sw = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Admin\\Status\\" + s + ".txt");

            // To write a line in buffer 
            sw.WriteLine(x);

            // To write in output stream 
            sw.Flush();

            // To close the stream 
            sw.Close();

        }
    }
}
