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
    public partial class SAttendence : UserControl
    {
        public SAttendence()
        {
            InitializeComponent();
        }
        public string ID3;
        DataTable table = new DataTable();
        private void SAttendence_Load(object sender, EventArgs e)
        {
            string s = ID3;
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
                for(int i=0; i<9; i++)
                {
                    str = sr.ReadLine();
                }
                str = sr.ReadLine();
            } while (str != null);

            // to close the stream 
            sr.Close();
            table.Columns.Add("SNo", typeof(int));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Status", typeof(string));
        }
        int A = 1;
        private void Search1_Click(object sender, EventArgs e)
        {
            string s = ID3;
            // Takinga a new input stream i.e.  
            // geeksforgeeks.txt and opens it 
            StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Attendence\\" + s + ".txt");

            // This is use to specify from where  
            // to start reading input stream 
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            string str = sr.ReadLine();
            string str1;
            string str2;

            // To read the whole file line by line 
            do
            {
                if (str == course2.Text)
                {
                    str1 = sr.ReadLine();
                    str2 = sr.ReadLine();
                    do
                    {
                        table.Rows.Add(A, str1, str2);
                        A++;
                        str1 = sr.ReadLine();
                        str2 = sr.ReadLine();
                    } while (str1 != "stop");
                }
                str = sr.ReadLine();
            } while (str!= null);
            
            // to close the stream 
            sr.Close();
            dataGridView1.DataSource = table;
        }

        private void course2_SelectedIndexChanged(object sender, EventArgs e)
        {
            while (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            A = 1;
        }
    }
}
