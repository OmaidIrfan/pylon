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
    public partial class STranscript : UserControl
    {
        public STranscript()
        {
            InitializeComponent();
        }
        public string ID7;
        DataTable table = new DataTable();

        private void STranscript_Load(object sender, EventArgs e)
        {
            int A = 1;
            string str1, str2, str3, str4;
            table.Columns.Add("SNo", typeof(int));
            table.Columns.Add("Course Name", typeof(string));
            table.Columns.Add("Course Code", typeof(string));
            table.Columns.Add("Course Grade", typeof(string));
            table.Columns.Add("Course SGPA", typeof(string));
            dataGridViewA.DataSource = table;
            dataGridViewB.DataSource = table;
            dataGridViewC.DataSource = table;
            dataGridViewD.DataSource = table;
            dataGridViewE.DataSource = table;
            dataGridViewF.DataSource = table;
            dataGridViewG.DataSource = table;
            dataGridViewH.DataSource = table;

            string s = ID7;
            // Takinga a new input stream i.e.  
            // geeksforgeeks.txt and opens it 
            StreamReader sr1 = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Student\\Transcript\\" + s + ".txt");

            // This is use to specify from where  
            // to start reading input stream 
            sr1.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream 
            str1 = sr1.ReadLine();
            str2 = sr1.ReadLine();
            str3 = sr1.ReadLine();
            str4 = sr1.ReadLine();
            // To read the whole file line by line 
            if(str1!=null)
            {
                for (int i = 0; i < 1; i++)
                {
                    table.Rows.Add(A, str1, str2, str3, str4);
                    str1 = sr1.ReadLine();
                    str2 = sr1.ReadLine();
                    str3 = sr1.ReadLine();
                    str4 = sr1.ReadLine();
                    A++;
                    dataGridViewA.DataSource = table;
                }
                //} while (str1 != "Semester-02");
            }
            // to close the stream 
            sr1.Close();
            //dataGridViewA.DataSource = table;
            A = 1;


        }
    }
}
