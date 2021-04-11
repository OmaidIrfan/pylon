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
    public partial class TMarks : UserControl
    {
        public TMarks()
        {
            InitializeComponent();
        }
        public string ID2;
        DataTable table = new DataTable();
        private void TMarks_Load(object sender, EventArgs e)
        {
            string s = ID2;
            // Takinga a new input stream i.e.  
            // geeksforgeeks.txt and opens it 
            StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Teacher\\Course\\" + s + ".txt");

            // This is use to specify from where  
            // to start reading input stream 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            string str = sr.ReadLine();

            // To read the whole file line by line 
            do
            {
                course1.Items.Add(str);
                str = sr.ReadLine();
            } while (str != null);

            // to close the stream 
            sr.Close();
            table.Columns.Add("SNo", typeof(int));
            table.Columns.Add("Roll Number", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Marks Obtained", typeof(int));
            table.Columns.Add("Total Marks", typeof(int));
            table.Columns["SNo"].ReadOnly = true;
            table.Columns["Roll Number"].ReadOnly = true;
            table.Columns["Name"].ReadOnly = true;
            table.Columns["Total Marks"].ReadOnly = true;
        }

        int p, A = 1;
        string c;
        private void Search1_Click(object sender, EventArgs e)
        {
            int j;
            string s1 = ID2;  //Teacher ID
            string s2 = course1.Text;  //Course Name
            string s3 = section1.Text;  //Section
            string s4 = category1.Text;// Category
            
            StreamReader sr1 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Teacher\\Faculty\\" + s2 + "\\" + s3 + ".txt");

            // This is use to specify from where  
            // to start reading input stream 
            sr1.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            string SID = sr1.ReadLine();

            // To read the whole file line by line 
            do
            {
                StreamReader sr2 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Bio\\" + SID + ".txt");

                // This is use to specify from where  
                // to start reading input stream 
                sr2.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string name1 = sr2.ReadLine();
                string name2 = sr2.ReadLine();

                sr2.Close();

                StreamReader sr3 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + SID + ".txt");

                // This is use to specify from where  
                // to start reading input stream 
                sr3.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string CName = sr3.ReadLine();

                // To read the whole file line by line 
                do
                {
                    if(CName==s2)
                    {
                        if(s4=="Quiz 01")
                        {
                            j = 1;
                            p = 5;
                        }
                        else if(s4 == "Assignment 01")
                        {
                            j = 2;
                            p = 5;
                        }
                        else if (s4 == "Mid 01")
                        {
                            j = 3;
                            p = 15;
                        }
                        else if (s4 == "Quiz 02")
                        {
                            j = 4;
                            p = 5;
                        }
                        else if (s4 == "Assignment 02")
                        {
                            j = 5;
                            p = 5;
                        }
                        else if (s4 == "Mid 02")
                        {
                            j = 6;
                            p = 15;
                        }
                        else if (s4 == "Project")
                        {
                            j = 7;
                            p = 10;
                        }
                        else 
                        {
                            j = 8;
                            p = 40;
                        }
                        c = sr3.ReadLine();
                        for (int i=0; i<j; i++)
                        {
                            c = sr3.ReadLine();
                        }
                    }
                    CName = sr3.ReadLine();
                } while (CName != null);

                // to close the stream 
                sr3.Close();
                table.Rows.Add(A, SID, name1 + " " + name2, c, p);
                A++;

                SID = sr1.ReadLine();
            } while (SID != null);
            // to close the stream 
            sr1.Close();
            dataGridView1.DataSource = table;
        }

        private void category1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void section1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }
        private void course1_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void Aupdate_Click(object sender, EventArgs e)
        {
            string str1 = course1.Text;
            string str2 = category1.Text;
            int j;
            A--;
            for (int i=0; i<A; i++)
            {
                string s1 = "Temp";
                string s2 = dataGridView1.Rows[i].Cells["Roll Number"].Value.ToString();
                // This will create a file named sample.txt 
                // at the specified location  
                StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s2 + ".txt");

                StreamWriter sw = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s1 + ".txt", true);
                               
                // This is use to specify from where  
                // to start reading input stream 
                //sr.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string str;

                // To read the whole file line by line 
                do
                {
                    str = sr.ReadLine();
                    if(str==str1)
                    {
                        sw.WriteLine(str);
                        sw.Flush();
                        str = sr.ReadLine();
                        sw.WriteLine(str);
                        sw.Flush();
                        if (str2 == "Quiz 01")
                        {
                            j = 0;
                        }
                        else if (str2 == "Assignment 01")
                        {
                            j = 1;
                        }
                        else if (str2 == "Mid 01")
                        {
                            j = 2;
                        }
                        else if (str2 == "Quiz 02")
                        {
                            j = 3;
                        }
                        else if (str2 == "Assignment 02")
                        {
                            j = 4;
                        }
                        else if (str2 == "Mid 02")
                        {
                            j = 5;
                        }
                        else if (str2 == "Project")
                        {
                            j = 6;
                        }
                        else
                        {
                            j = 7;
                        }
                        for(int k=0; k<j; k++)
                        {
                            str = sr.ReadLine();
                            sw.WriteLine(str);
                            sw.Flush();
                        }
                        sw.WriteLine(dataGridView1.Rows[i].Cells["Marks Obtained"].Value.ToString());
                        sw.Flush();
                        str = sr.ReadLine();
                        str = sr.ReadLine();
                    }
                    sw.WriteLine(str);
                    sw.Flush();
                } while (str != null);
                // to close the stream 
                sr.Close();
                // To close the stream 
                sw.Close();
                File.Delete("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s2 + ".txt");
                File.Move("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s1 + ".txt", "D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s2 + ".txt");
            }
            MessageBox.Show("Marks have been Updated Successfully");
        }
    }
}