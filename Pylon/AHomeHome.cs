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
    public partial class AHomeHome : UserControl
    {
        public AHomeHome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}
        private void month_SelectedIndexChanged(object sender, EventArgs e){}
        private void Aupdate_Click(object sender, EventArgs e){}
        private void AHomeHome_Load(object sender, EventArgs e){}
        
        private void search1_Click(object sender, EventArgs e)
        {
            //tHomeHome2.ID = ID1.Text;
            if (ID1.Text == "") 
            {
                MessageBox.Show("Please enter the ID.");
            }
            else
            {
                if (select.Text == "Teacher")
                {
                    tHomeHome2.ID1 = ID1.Text;
                    tHomeHome2.Show();
                    sHomeHome2.Hide();
                }
                else if (select.Text == "Student")
                {
                    sHomeHome2.ID2 = ID1.Text;
                    sHomeHome2.Show();
                    tHomeHome2.Hide();
                }
                else
                {
                    MessageBox.Show("Please select the category.");
                }
            }
                        
        }

        private void sHomeHome2_Load(object sender, EventArgs e){}
    }
}
