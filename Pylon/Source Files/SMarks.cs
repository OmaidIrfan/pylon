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
    public partial class SMarks : UserControl
    {
        public SMarks()
        {
            InitializeComponent();
        }
        public string ID4;
        //Fazool Hai
        private void label1_Click(object sender, EventArgs e){}
        //Fazool Hai
        private void panel5_Paint(object sender, PaintEventArgs e){}
        //Fazool Hai
        private void panel6_Paint(object sender, PaintEventArgs e){}
        //Fazool Hai
        private void button1_Click(object sender, EventArgs e){}
        //Fazool Hai
        private void label2_Click(object sender, EventArgs e){}

        private void cr4_Click(object sender, EventArgs e)
        {}

        private void SMarks_Load(object sender, EventArgs e)
        {
            string s = ID4;
            // Takinga a new input stream i.e.  
            // geeksforgeeks.txt and opens it 
            StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s + ".txt");

            // This is use to specify from where  
            // to start reading input stream 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            string str = sr.ReadLine();

            // To read the whole file line by line 
            do
            {
                course2.Items.Add(str);
                for (int i = 0; i < 9; i++)
                {
                    str = sr.ReadLine();
                }
                str = sr.ReadLine();
            } while (str != null);
        }

        private void Search1_Click(object sender, EventArgs e)
        {
            int x;
            int[] a = new int[8];
            for(int i=0; i<8; i++)
            {
                a[i] = 0;
            }
            string s = ID4;
            // Takinga a new input stream i.e.  
            // geeksforgeeks.txt and opens it
            StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s + ".txt");

            // This is use to specify from where  
            // to start reading input stream
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream
            string str;

            // To read the whole file line by line
            str = sr.ReadLine();
            do
            {
                if (str == course2.Text)
                {
                    str = sr.ReadLine();
                    
                    str = sr.ReadLine();
                    m1.Text = str;
                    if(str!="-")
                    {
                        a[0] = Convert.ToInt32(m1.Text);
                    }

                    str = sr.ReadLine();
                    m2.Text = str;
                    if (str != "-")
                    {
                        a[1] = Convert.ToInt32(m2.Text);
                    }

                    str = sr.ReadLine();
                    m3.Text = str;
                    if (str != "-")
                    {
                        a[2] = Convert.ToInt32(m3.Text);
                    }

                    str = sr.ReadLine();
                    m4.Text = str;
                    if (str != "-")
                    {
                        a[3] = Convert.ToInt32(m4.Text);
                    }

                    str = sr.ReadLine();
                    m5.Text = str;
                    if (str != "-")
                    {
                        a[4] = Convert.ToInt32(m5.Text);
                    }

                    str = sr.ReadLine();
                    m6.Text = str;
                    if (str != "-")
                    {
                        a[5] = Convert.ToInt32(m6.Text);
                    }

                    str = sr.ReadLine();
                    m7.Text = str;
                    if (str != "-")
                    {
                        a[6] = Convert.ToInt32(m7.Text);
                    }

                    str = sr.ReadLine();
                    m8.Text = str;
                    if (str != "-")
                    {
                        a[7] = Convert.ToInt32(m8.Text);
                    }


                    x = a[0]+ a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7];
                    m9.Text = "" + x;
                }
                str = sr.ReadLine();
            } while (str != null);
            
            // to close the stream
            sr.Close();
        }
    }
}
