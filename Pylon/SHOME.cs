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
    public partial class SHOME : Form
    {
        public SHOME(string ID1)
        {
            InitializeComponent();
            sHomeHome1.ID2 = ID1;
            sAttendence1.ID3 = ID1;
            sMarks1.ID4 = ID1;
            sRegistration1.ID5 = ID1;
            sTranscript1.ID7 = ID1;
        }

        private void p1_Click(object sender, EventArgs e)
        {
            //show
            sHomeHome1.Show();
            //hide
            sMarks1.Hide();
            sAttendence1.Hide();
            sTranscript1.Hide();
            sRegistration1.Hide();
        }

        private void p2_Click(object sender, EventArgs e)
        {
            //show
            sMarks1.Show();
            //hide
            sHomeHome1.Hide();
            sAttendence1.Hide();
            sTranscript1.Hide();
            sRegistration1.Hide();
        }

        private void sHomeHome1_Load(object sender, EventArgs e)
        {
            //show
            sHomeHome1.Show();
            //hide
            sMarks1.Hide();
            sAttendence1.Hide();
            sTranscript1.Hide();
            sRegistration1.Hide();
        }

        private void p3_Click(object sender, EventArgs e)
        {
            //show
            sAttendence1.Show();
            //hide
            sMarks1.Hide();
            sHomeHome1.Hide();
            sTranscript1.Hide();
            sRegistration1.Hide();
        }

        private void p4_Click(object sender, EventArgs e)
        {
            //Show
            sTranscript1.Show();
            //Hide
            sAttendence1.Hide();
            sMarks1.Hide();
            sHomeHome1.Hide();
            sRegistration1.Hide();
        }

        private void p5_Click(object sender, EventArgs e)
        {
            //Show
            sRegistration1.Show();
            //Hide
            sTranscript1.Show();
            sAttendence1.Hide();
            sMarks1.Hide();
            sHomeHome1.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
