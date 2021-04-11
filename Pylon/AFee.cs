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
    public partial class AFee : UserControl
    {
        public AFee()
        {
            InitializeComponent();
        }

        private void AFee_Load(object sender, EventArgs e){}

        private void Freeze_Click(object sender, EventArgs e)
        {
            int x;
            int[] a = new int[8];
            for (int i = 0; i < 8; i++)
            {
                a[i] = 0;
            }
            double sgpa;

            ////////////////////////////Transcript//////////////////////////////////////////////////////

            string s1 = "Student";
            // Takinga a new input stream i.e.  
            // geeksforgeeks.txt and opens it 
            StreamReader sr1 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Admin\\Red Zone\\" + s1 + ".txt");

            // This is use to specify from where  
            // to start reading input stream 
            sr1.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            string str = sr1.ReadLine();

            // To read the whole file line by line 
            do
            {
                string s3 = str;
                // Takinga a new input stream i.e.  
                // geeksforgeeks.txt and opens it 
                StreamReader sr2 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s3 + ".txt");

                StreamWriter sw1 = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Transcript\\" + s3 + ".txt", true);

                StreamReader bio = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Bio\\" + s3 + ".txt");

                // This is use to specify from where  
                // to start reading input stream 
                bio.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string semester;

                // To read the whole file line by line 
                for (int i = 0; i < 11; i++)
                {
                    semester = bio.ReadLine();
                }
                semester = bio.ReadLine();
                // to close the stream 
                bio.Close();

                // To write a line in buffer 
                sw1.WriteLine("Semester-0" + semester);
                // To write in output stream 
                sw1.Flush();

                x = Convert.ToInt32(semester);
                x++;

                string u1 = "Temp";
                string u2 = s3;
                // This will create a file named sample.txt 
                // at the specified location  
                StreamReader sr90 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Bio\\" + u2 + ".txt");

                StreamWriter sw91 = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Bio\\" + u1 + ".txt", true);

                // To read line from input stream 
                string umer;

                for(int k=0; k<11; k++)
                {
                    umer = sr90.ReadLine();
                    sw91.WriteLine(umer);
                    sw91.Flush();
                }
                sw91.WriteLine(x);
                sw91.Flush();
                sr90.ReadLine();
                for (int k = 0; k < 6; k++)
                {
                    umer = sr90.ReadLine();
                    sw91.WriteLine(umer);
                    sw91.Flush();
                }

                // to close the stream 
                sr90.Close();
                // To close the stream 
                sw91.Close();
                File.Delete("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Bio\\" + u2 + ".txt");
                File.Move("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Bio\\" + u1 + ".txt", "D:\\Semester-03\\OOP\\Project\\Files\\Student\\Bio\\" + u2 + ".txt");


                // This is use to specify from where  
                // to start reading input stream 
                sr2.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string str1 = sr2.ReadLine();

                // To read the whole file line by line 
                do
                {
                    // To write a line in buffer 
                    sw1.WriteLine(str1);
                    // To write in output stream 
                    sw1.Flush();

                    str1 = sr2.ReadLine();
                    // To write a line in buffer 
                    sw1.WriteLine(str1);
                    // To write in output stream 
                    sw1.Flush();

                    str1 = sr2.ReadLine();
                    if (str1 != "-")
                    {
                        a[0] = Convert.ToInt32(str1);
                    }

                    str1 = sr2.ReadLine();
                    if (str1 != "-")
                    {
                        a[1] = Convert.ToInt32(str1);
                    }

                    str1 = sr2.ReadLine();
                    if (str1 != "-")
                    {
                        a[2] = Convert.ToInt32(str1);
                    }

                    str1 = sr2.ReadLine();
                    if (str1 != "-")
                    {
                        a[3] = Convert.ToInt32(str1);
                    }

                    str1 = sr2.ReadLine();
                    if (str1 != "-")
                    {
                        a[4] = Convert.ToInt32(str1);
                    }

                    str1 = sr2.ReadLine();
                    if (str1 != "-")
                    {
                        a[5] = Convert.ToInt32(str1);
                    }

                    str1 = sr2.ReadLine();
                    if (str1 != "-")
                    {
                        a[6] = Convert.ToInt32(str1);
                    }

                    str1 = sr2.ReadLine();
                    if (str1 != "-")
                    {
                        a[7] = Convert.ToInt32(str1);
                    }

                    x = a[0] + a[1] + a[2] + a[3] + a[4] + a[5] + a[6] + a[7];
                    if (x >= 90)
                    {
                        str1 = "A+";
                        sgpa = 4;
                    }
                    else if (x>=86)
                    {
                        str1 = "A";
                        sgpa = 4;
                    }
                    else if (x>=82)
                    {
                        str1 = "A-";
                        sgpa = 3.67;
                    }
                    else if (x>=78)
                    {
                        str1 = "B+";
                        sgpa = 3.33;
                    }
                    else if (x>=74)
                    {
                        str1 = "B";
                        sgpa = 3;
                    }
                    else if (x>=70)
                    {
                        str1 = "B-";
                        sgpa = 2.67;
                    }
                    else if (x>=66)
                    {
                        str1 = "C+";
                        sgpa = 2.33;
                    }
                    else if (x>=62)
                    {
                        str1 = "C";
                        sgpa = 2;
                    }
                    else if (x>=58)
                    {
                        str1 = "C-";
                        sgpa = 1.67;
                    }
                    else if (x>=54)
                    {
                        str1 = "D";
                        sgpa = 1.33;
                    }
                    else
                    {
                        str1 = "F";
                        sgpa = 0;
                    }
                    // To write a line in buffer 
                    sw1.WriteLine(str1);
                    // To write in output stream 
                    sw1.Flush();
                    // To close the stream 
                    // To write a line in buffer 
                    sw1.WriteLine(sgpa);
                    // To write in output stream 
                    sw1.Flush();
                    // To close the stream 

                    str1 = sr2.ReadLine();
                } while (str1 != null);
                sw1.Close();

                // to close the stream 
                sr2.Close();
                str = sr1.ReadLine();
                str = sr1.ReadLine();
            } while (str != null);

            // to close the stream 
            sr1.Close();
        }
    }
}
