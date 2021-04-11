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
    public partial class THomeHome : UserControl
    {
        public THomeHome()
        {
            InitializeComponent();
        }
        public string ID1;

        private void THomeHome_Load(object sender, EventArgs e){}

        private void button1_Click(object sender, EventArgs e)
        {
            string s = ID1;
            // Takinga a new input stream i.e.  
            // geeksforgeeks.txt and opens it 
            StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Teacher\\Bio\\" + s + ".txt");

            // This is use to specify from where  
            // to start reading input stream 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            string str;

            // To read the whole file line by line 
            str = sr.ReadLine();
            Fname2.Text = str;

            str = sr.ReadLine();
            Lname2.Text = str;

            str = sr.ReadLine();
            Eaddress2.Text = str;

            str = sr.ReadLine();
            cnic2.Text = str;

            str = sr.ReadLine();
            dob2.Text = str;

            str = sr.ReadLine();
            cno2.Text = str;

            str = sr.ReadLine();
            Haddress2.Text = str;

            str = sr.ReadLine();
            nation2.Text = str;

            str = sr.ReadLine();
            qua2.Text = str;

            str = sr.ReadLine();
            pos2.Text = str;

            str = sr.ReadLine();
            degree2.Text = str;

            str = sr.ReadLine();
            campus2.Text = str;

            // to close the stream 
            sr.Close();
        }
    }
}
