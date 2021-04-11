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
    public partial class SRegistration : UserControl
    {
        public SRegistration()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        public string ID5;
        int A = 1;
        //Fazool Hai
        private void cr3_Click(object sender, EventArgs e){}

        private void SRegistration_Load(object sender, EventArgs e)
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
            string str = sr.ReadLine();

            // to close the stream 
            sr.Close();

            if(str == "1")
            {
                Registor1.Enabled = true;
                label1.Text = "Registration is Open.";
            }
            else
            {
                Registor1.Enabled = false;
                label1.Text = "Registration is Close.";
            }
            if(str == "1")
            {
                Registor1.Enabled = true;
                string s1 = ID5;
                // Takinga a new input stream i.e.  
                // geeksforgeeks.txt and opens it 
                StreamReader sr1 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Bio\\" + s1 + ".txt");

                // This is use to specify from where  
                // to start reading input stream 
                sr1.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string str2;

                // To read the whole file line by line 
                for(int i=0; i<11; i++)
                {
                    str2 = sr1.ReadLine();
                }
                str2 = sr1.ReadLine();
                // to close the stream 
                sr1.Close();
                x = Convert.ToInt32(str2);

                table.Columns.Add("SNo", typeof(int));
                table.Columns.Add("Course Name", typeof(string));
                table.Columns.Add("Course Code", typeof(string));
                table.Columns.Add("Course Credit Hours", typeof(string));
                table.Columns["SNo"].ReadOnly = true;
                table.Columns["Course Name"].ReadOnly = true;
                table.Columns["Course Code"].ReadOnly = true;
                table.Columns["Course Credit Hours"].ReadOnly = true;

                // Takinga a new input stream i.e.  
                // geeksforgeeks.txt and opens it 
                StreamReader sr2 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Admin\\Courses\\" + x + ".txt");

                // This is use to specify from where  
                // to start reading input stream 
                sr2.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string c1 = sr2.ReadLine(); ;
                string c2;
                string c3;


                // To read the whole file line by line 
                do
                {
                    c2 = sr2.ReadLine();
                    c3 = sr2.ReadLine();
                    table.Rows.Add(A, c1, c2, c3);
                    A++;
                    c1 = sr2.ReadLine();
                } while (c1 != null);

                // to close the stream 
                sr2.Close();
                dataGridView1.DataSource = table;
            }
        }
        string p;
        private void Registor1_Click(object sender, EventArgs e)
        {
            StreamReader sr0 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Bio\\" + ID5 + ".txt");
            for(int i=0; i<17; i++)
            {
                p = sr0.ReadLine();
            }
            sr0.Close();

            string s = ID5;
            File.Delete("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s + ".txt");
            File.Delete("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s + ".txt");

            StreamWriter sw = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Semester\\" + s + ".txt", true);
            StreamWriter sw1 = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s + ".txt", true);

            A--;
            for(int i=0; i<A;i++)
            {
                if(Convert.ToBoolean(dataGridView1.Rows[i].Cells["Column4"].Value))
                {
                    sw.WriteLine(dataGridView1.Rows[i].Cells["Course Name"].Value.ToString());
                    sw.Flush();
                    sw.WriteLine(dataGridView1.Rows[i].Cells["Course Code"].Value.ToString());
                    sw.Flush();
                    for (int k=0; k<8; k++)
                    {
                        sw.WriteLine("-");
                        sw.Flush();
                    }
                    sw1.WriteLine(dataGridView1.Rows[i].Cells["Course Name"].Value.ToString());
                    sw1.Flush();
                    sw1.WriteLine("stop");
                    sw1.Flush();

                    StreamWriter sw3 = new StreamWriter("D:\\Semester-03\\OOP\\Project\\Files\\Teacher\\Faculty\\" + dataGridView1.Rows[i].Cells["Course Name"].Value.ToString() + "\\" + p + ".txt", true);
                    sw3.WriteLine(s);
                    sw3.Flush();
                    sw3.Close();
                }
                
            }
            // To close the stream 
            sw.Close();
            sw1.Close();
            dataGridView1.DataSource = table;
            MessageBox.Show("You have successfully registered your courses.");

        }
    }
}
