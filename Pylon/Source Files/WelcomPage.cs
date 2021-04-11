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
    public partial class WelcomPage : Form
    {
        public WelcomPage()
        {
            InitializeComponent();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn L = new LogIn(1);
            L.Show();
        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn L = new LogIn(2);
            L.Show();
        }
       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn L = new LogIn(3);
            L.Show();
        }

        //Fazool Hai
        private void WelcomPage_Load(object sender, EventArgs e){}

        private void Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn L = new LogIn(1);
            L.Show();
        }

        private void Teacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn L = new LogIn(2);
            L.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn L = new LogIn(3);
            L.Show();
        }
    }
}
