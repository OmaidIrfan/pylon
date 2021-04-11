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
    public partial class LogIn : Form
    {
        signup obj = new signup();
        public LogIn(int x)
        {
            InitializeComponent();
            obj.set(x);
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            string id = username.Text;
            string passw = password.Text;
            obj.setter(id,passw);
            obj.check();
            int result = obj.getter();
            int y = obj.get();
            if (result==1)
            {
                if (y==1)
                {
                    this.Hide();
                    SHOME F1 = new SHOME(id);
                    F1.Show();
                }
                else if(y==2)
                {
                    this.Hide();
                    THOME F2 = new THOME(id);
                    F2.Show();
                }
                else if(y==3)
                {
                    this.Hide();
                    AHOME F3 = new AHOME();
                    F3.Show();
                }
            }
            else
            {
                string msg = "Entered id or password is invalid";
                MessageBox.Show(msg);
            }
        }

        //Fazool Hai
        private void username_TextChanged(object sender, EventArgs e){}
        //Fazool Hai
        private void password_TextChanged(object sender, EventArgs e){}
        //Fazool Hai
        private void LogIn_Load(object sender, EventArgs e){}
        private void password_MaskInputRejected(object sender, MaskInputRejectedEventArgs e){}
        //Fazool Hai
        private void username_TextChanged_1(object sender, EventArgs e){}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }
    }
}
