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
    public partial class AHOME : Form
    {
        public AHOME()
        {
            InitializeComponent();
        }

        private void AHOME_Load(object sender, EventArgs e)
        {
            //Show
            aHomeHome1.Show();
            //Hide
            asRegistration1.Hide();
            atRegistration1.Hide();
            acRegistration1.Hide();
            aFee1.Hide();
        }

        private void adHome_Click(object sender, EventArgs e)
        {
            //Show
            aHomeHome1.Show();
            //Hide
            asRegistration1.Hide();
            atRegistration1.Hide();
            acRegistration1.Hide();
            aFee1.Hide();
        }

        private void SRegistration_Click(object sender, EventArgs e)
        {
            //Show
            asRegistration1.Show();
            //Hide
            aHomeHome1.Hide();
            atRegistration1.Hide();
            acRegistration1.Hide();
            aFee1.Hide();
        }

        private void TRegistrtion_Click(object sender, EventArgs e)
        {
            //Show
            atRegistration1.Show();
            //Hide
            aHomeHome1.Hide();
            asRegistration1.Hide();
            acRegistration1.Hide();
            aFee1.Hide();
        }

        private void CRegistration_Click(object sender, EventArgs e)
        {
            //Show
            acRegistration1.Show();
            //Hide
            aHomeHome1.Hide();
            asRegistration1.Hide();
            atRegistration1.Hide();
            aFee1.Hide();
        }

        private void fee_Click(object sender, EventArgs e)
        {
            //Show
            aFee1.Show();
            //Hide
            aHomeHome1.Hide();
            asRegistration1.Hide();
            atRegistration1.Hide();
            acRegistration1.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
