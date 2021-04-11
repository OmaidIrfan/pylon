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
    public partial class ASRegistration : UserControl
    {
        public ASRegistration()
        {
            InitializeComponent();
        }

        private void SReg_Click(object sender, EventArgs e)
        {
            string s = rno3.Text;
            StreamWriter sw = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Bio\\" + s + ".txt", true);


            sw.WriteLine(Fname3.Text);
            sw.Flush();

            sw.WriteLine(Lname3.Text);
            sw.Flush();

            sw.WriteLine(Eaddress3.Text);
            sw.Flush();

            sw.WriteLine(cnic3.Text);
            sw.Flush();

            sw.WriteLine(dob3.Text);
            sw.Flush();

            sw.WriteLine(cno3.Text);
            sw.Flush();

            sw.WriteLine(Haddress3.Text);
            sw.Flush();

            sw.WriteLine(nation3.Text);
            sw.Flush();

            sw.WriteLine(rno3.Text);
            sw.Flush();

            sw.WriteLine(cgpa3.Text);
            sw.Flush();

            sw.WriteLine(degree1.Text);
            sw.Flush();

            sw.WriteLine(semester1.Text);
            sw.Flush();

            sw.WriteLine(campus3.Text);
            sw.Flush();

            sw.WriteLine(batch3.Text);
            sw.Flush();

            sw.WriteLine(dc3.Text);
            sw.Flush();

            sw.WriteLine(warning3.Text);
            sw.Flush();

            sw.WriteLine(sec3.Text);
            sw.Flush();

            sw.WriteLine(password1.Text);
            sw.Flush();

            s = "Student";
            // This will create a file named ID4 
            // at the specified location  
            StreamWriter sy = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Admin\\Red Zone\\" + s + ".txt", true);
            // To write a line in buffer 

            sy.WriteLine(rno3.Text);
            sy.Flush();

            sy.WriteLine(password1.Text);
            sy.Flush();

            // To close the stream 
            sy.Close();

            sw.Close();

            s = rno3.Text;

            StreamWriter st = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s + ".txt", true);

            st.Close();

            // Takinga a new input stream i.e.  
            // geeksforgeeks.txt and opens it
            StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Admin\\Courses\\" + 1 + ".txt");

            // This is use to specify from where  
            // to start reading input stream
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // This will create a file named sample.txt
            // at the specified location  
            StreamWriter sx = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s + ".txt", true);



            // To read line from input stream
            string str1, str2;

            // To read the whole file line by line
            for (int i = 0; i < 8; i++)
            {
                str1 = sr.ReadLine();
                
                StreamWriter sz = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Teacher\\Faculty\\"+ str1 +"\\" + sec3.Text + ".txt", true);
                sz.WriteLine(rno3.Text);
                sz.Flush();
                sz.Close();

                str2 = sr.ReadLine();
                sx.WriteLine(str1);
                sx.Flush();
                sx.WriteLine(str2);
                sx.Flush();
                for (int j = 0; j < 8; j++)
                {
                    sx.WriteLine("-");
                    sx.Flush();
                }
                str2 = sr.ReadLine();
            }
            sx.Close();
            sr.Close();
            StreamReader sr40 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Admin\\Courses\\" + 1 + ".txt");
            StreamWriter sw40 = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s + ".txt", true);
            
            for (int i = 0; i < 8; i++)
            {
                sw40.WriteLine(sr40.ReadLine());
                sw40.Flush();
                sw40.WriteLine("stop");
                sw40.Flush();
                sr40.ReadLine();
                sr40.ReadLine();
            }
            sr40.Close();
            sw40.Close();

            StreamWriter sa = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Transcript\\" + s + ".txt", true);
            sa.Close();

            string message = "Student has been registered successfully....";
            MessageBox.Show(message);

            Fname3.Clear();

            Lname3.Clear();

            Eaddress3.Clear();

            cnic3.Clear();

            dob3.Clear();

            cno3.Clear();

            Haddress3.Clear();

            nation3.Clear();

            rno3.Clear();

            cgpa3.Clear();

            degree1.Clear();

            campus3.Clear();

            batch3.Clear();

            dc3.Clear();

            warning3.Clear();

            sec3.Clear();

            password1.Clear();
        }
    }
}
