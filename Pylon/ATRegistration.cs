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
    public partial class ATRegistration : UserControl
    {
        public ATRegistration()
        {
            InitializeComponent();
        }

        private void TReg_Click(object sender, EventArgs e)
        {
            string s = ID4.Text;
            // This will create a file named ID4 
            // at the specified location  
            StreamWriter sw = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Teacher\\Bio\\" + s + ".txt", true);

            // To write a line in buffer 
            sw.WriteLine(Fname4.Text);
            // To write in output stream 
            sw.Flush();
         
            // To write a line in buffer 
            sw.WriteLine(Lname4.Text);
            // To write in output stream 
            sw.Flush();
      
            // To write a line in buffer 
            sw.WriteLine(Eaddress4.Text);
            // To write in output stream 
            sw.Flush();
            
            // To write a line in buffer 
            sw.WriteLine(cnic4.Text);
            // To write in output stream 
            sw.Flush();
            
            // To write a line in buffer 
            sw.WriteLine(dob4.Text);
            // To write in output stream 
            sw.Flush();
           
            // To write a line in buffer 
            sw.WriteLine(cno4.Text);
            // To write in output stream 
            sw.Flush();
            
            // To write a line in buffer 
            sw.WriteLine(Haddress4.Text);
            // To write in output stream 
            sw.Flush();
            
            // To write a line in buffer 
            sw.WriteLine(nation4.Text);
            // To write in output stream 
            sw.Flush();
            
            // To write a line in buffer 
            sw.WriteLine(qua4.Text);
            // To write in output stream 
            sw.Flush();
           
            // To write a line in buffer 
            sw.WriteLine(pos4.Text);
            // To write in output stream 
            sw.Flush();
            
            // To write a line in buffer 
            sw.WriteLine(degree4.Text);
            // To write in output stream 
            sw.Flush();
            
            // To write a line in buffer 
            sw.WriteLine(campus4.Text);
            // To write in output stream 
            sw.Flush();
            
            // To write a line in buffer 
            sw.WriteLine(ID4.Text);
            // To write in output stream 
            sw.Flush();

            // To write a line in buffer 
            sw.WriteLine(password4.Text);
            // To write in output stream 
            sw.Flush();

            // To close the stream 
            sw.Close();

            s = "Teacher";
            // This will create a file named ID4 
            // at the specified location  
            StreamWriter sx = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Admin\\Red Zone\\" + s + ".txt", true);
            // To write a line in buffer 
            sx.WriteLine(ID4.Text);
            // To write in output stream 
            sx.Flush();

            // To write a line in buffer 
            sx.WriteLine(password4.Text);
            // To write in output stream 
            sx.Flush();

            // To close the stream 
            sx.Close();

            string message = "Teacher has been registered successfully";
            MessageBox.Show(message);

            Fname4.Clear();
            Lname4.Clear();
            Eaddress4.Clear();
            cnic4.Clear();
            dob4.Clear();
            cno4.Clear();
            Haddress4.Clear();
            nation4.Clear();
            qua4.Clear();
            pos4.Clear();
            degree4.Clear();
            campus4.Clear();
            ID4.Clear();
            password4.Clear();

        }
    }
}
