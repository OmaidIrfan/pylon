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
    public partial class TAttendence : UserControl
    {
        public TAttendence()
        {
            InitializeComponent();
        }
        public string ID3;
        DataTable table = new DataTable();
        private void TAttendence_Load(object sender, EventArgs e)
        {
            string s = ID3;
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
                course2.Items.Add(str);
                str = sr.ReadLine();
            } while (str != null);

            // to close the stream 
            sr.Close();
            string u1 = month.Text;
            string u2 = date.Text;
            table.Columns.Add("SNo", typeof(int));
            table.Columns.Add("Roll Number", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Status", typeof(string));
            table.Columns["SNo"].ReadOnly = true;
            table.Columns["Roll Number"].ReadOnly = true;
            table.Columns["Name"].ReadOnly = true;
        }
        int p, A = 1;
        string c;

        private void Aupdate_Click(object sender, EventArgs e)
        {
            string str1 = course2.Text;
            int j;
            A--;
            for (int i = 0; i < A; i++)
            {
                string s1 = "Temp";
                string s2 = dataGridView1.Rows[i].Cells["Roll Number"].Value.ToString();
                // This will create a file named sample.txt 
                // at the specified location  
                StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s2 + ".txt");

                StreamWriter sw = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s1 + ".txt", true);

                // This is use to specify from where  
                // to start reading input stream 
                //sr.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string str;

                // To read the whole file line by line 
                do
                {
                    str = sr.ReadLine();
                    if (str == str1)
                    {
                        sw.WriteLine(str);
                        sw.Flush();
                        str = sr.ReadLine();
                        while (str!="stop")
                        {
                            if(str==month.Text + "/" + date.Text)
                            {
                                sw.WriteLine(str);
                                sw.Flush();
                                sw.WriteLine(dataGridView1.Rows[i].Cells["Status"].Value.ToString());
                                sw.Flush();
                                str = sr.ReadLine();
                            }
                            else
                            {
                                sw.WriteLine(str);
                                sw.Flush();
                            }
                            str = sr.ReadLine();
                        }
                    }
                    sw.WriteLine(str);
                    sw.Flush();
                } while (str != null);
                // to close the stream 
                sr.Close();
                // To close the stream 
                sw.Close();
                File.Delete("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s2 + ".txt");
                File.Move("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s1 + ".txt", "D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s2 + ".txt");
            }
            MessageBox.Show("Attendence have been Updated Successfully");
        }

        private void Create1_Click(object sender, EventArgs e)
        {
            int j;
            string s1 = ID3;  //Teacher ID
            string s2 = course2.Text;  //Course Name
            string s3 = section2.Text;  //Section

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
                table.Rows.Add(A, SID, name1 + " " + name2, "-");
                A++;

                SID = sr1.ReadLine();
            } while (SID != null);
            // to close the stream 
            sr1.Close();
            dataGridView1.DataSource = table;
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            string str1 = course2.Text;
            int j;
            A--;
            for (int i = 0; i < A; i++)
            {
                string s1 = "Temp";
                string s2 = dataGridView1.Rows[i].Cells["Roll Number"].Value.ToString();
                // This will create a file named sample.txt 
                // at the specified location  
                StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s2 + ".txt");

                StreamWriter sw = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s1 + ".txt", true);

                // This is use to specify from where  
                // to start reading input stream 
                //sr.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string str;

                // To read the whole file line by line 
                do
                {
                    str = sr.ReadLine();
                    if (str == str1)
                    {
                        sw.WriteLine(str);
                        sw.Flush();
                        str = sr.ReadLine();
                        while (str != "stop")
                        {
                            sw.WriteLine(str);
                            sw.Flush();
                            str = sr.ReadLine();
                        }
                        sw.WriteLine(month.Text+"/"+date.Text);
                        sw.Flush();
                        sw.WriteLine(dataGridView1.Rows[i].Cells["Status"].Value.ToString());
                        sw.Flush();
                    }
                    sw.WriteLine(str);
                    sw.Flush();
                } while (str != null);
                // to close the stream 
                sr.Close();
                // To close the stream 
                sw.Close();
                File.Delete("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s2 + ".txt");
                File.Move("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s1 + ".txt", "D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s2 + ".txt");
            }
            MessageBox.Show("Attendence has been Added Successfully");
        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void date_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void section2_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void course2_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }

        private void Search1_Click(object sender, EventArgs e)
        {
            int j;
            string s1 = ID3;  //Teacher ID
            string s2 = course2.Text;  //Course Name
            string s3 = section2.Text;  //Section
            A = 1;
            StreamReader sr1 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Teacher\\Faculty\\" + s1 + "\\" + s2 + "\\" + s3 + ".txt");

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

                StreamReader sr3 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + SID + ".txt");

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
                        while (sr3.ReadLine()!=month.Text+"/"+date.Text)
                        {

                        }
                        c = sr3.ReadLine();
                   }
                    CName = sr3.ReadLine();
                } while (CName != null);

                // to close the stream 
                sr3.Close();
                table.Rows.Add(A, SID, name1 + " " + name2, c);
                A++;

                SID = sr1.ReadLine();
            } while (SID != null);
            // to close the stream 
            sr1.Close();
            dataGridView1.DataSource = table;
        }
    }
}
