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

namespace Pylon.Source_Files
{
    public partial class SHomeHome : UserControl
    {
        public SHomeHome()
        {
            InitializeComponent();
        }
        ///Fazool Hai
        private void panel2_Paint(object sender, PaintEventArgs e){}
        private void SHomeHome_Load(object sender, EventArgs e){}
       
        public string ID2;
        private void button1_Click(object sender, EventArgs e)
        {
            string s = ID2;
            // Takinga a new input stream i.e.  
            // geeksforgeeks.txt and opens it 
            StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Bio\\" + s + ".txt");

            // This is use to specify from where  
            // to start reading input stream 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            string str;

            // To read the whole file line by line 
            str = sr.ReadLine();
            Fname1.Text = str;

            str = sr.ReadLine();
            Lname1.Text = str;

            str = sr.ReadLine();
            Eaddress1.Text = str;

            str = sr.ReadLine();
            cnic1.Text = str;

            str = sr.ReadLine();
            dob1.Text = str;

            str = sr.ReadLine();
            cno1.Text = str;

            str = sr.ReadLine();
            Haddress1.Text = str;

            str = sr.ReadLine();
            nation1.Text = str;

            str = sr.ReadLine();
            rno1.Text = str;

            str = sr.ReadLine();
            cgpa1.Text = str;

            str = sr.ReadLine();
            degree1.Text = str;

            str = sr.ReadLine();
            semester1.Text = str;

            str = sr.ReadLine();
            campus1.Text = str;

            str = sr.ReadLine();
            batch1.Text = str;

            str = sr.ReadLine();
            dc1.Text = str;

            str = sr.ReadLine();
            warning1.Text = str;
            
            str = sr.ReadLine();
            sce1.Text = str;

            // to close the stream 
            sr.Close();
        }
    }
}
