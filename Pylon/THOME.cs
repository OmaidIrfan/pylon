using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pylon
{
    public partial class THOME : Form
    {
        public THOME(string ID1)
        {
            InitializeComponent();
            tHomeHome1.ID1 = ID1;
            tMarks1.ID2 = ID1;
            tAttendence1.ID3 = ID1;
        }
  
        private void p7_Click(object sender, EventArgs e)
        {
            //Show
            tHomeHome1.Show();
            //Hide
            tAttendence1.Hide();
            tMarks1.Hide();
        }

        private void p9_Click(object sender, EventArgs e)
        {
            //Show
            tAttendence1.Show();
            //Hide
            tHomeHome1.Hide();
            tMarks1.Hide();
        }

        private void THOME_Load(object sender, EventArgs e)
        {
            //Show
            tHomeHome1.Show();
            //Hide
            tAttendence1.Hide();
            tMarks1.Hide();
        }

        private void p8_Click(object sender, EventArgs e)
        {
            //Show
            tMarks1.Show();
            //Hide
            tHomeHome1.Show();
            tAttendence1.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
