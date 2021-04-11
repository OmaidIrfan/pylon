using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pylon
{
    class signup
    {
        string id,password;
        int v,result;

        public void set(int x)
        {
            v = x;
        }
        public void setter(string s1, string s2)
        {
            id = s1;
            password = s2;
        }
        public void check()
        {
            if(v==1)
            {
                string s = "Student";
                // Takinga a new input stream i.e.  
                // geeksforgeeks.txt and opens it 
                StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Admin\\Red Zone\\" + s + ".txt");

                // This is use to specify from where  
                // to start reading input stream 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string str;

                // To read the whole file line by line 
                do
                {
                    str = sr.ReadLine();
                    if(str == null)
                    {
                        break;
                    }
                } while (str != id);

                if (str== id)
                {
                    str = sr.ReadLine();
                    if(str==password)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                }
                else
                {
                    result = 0;
                }
                sr.Close();

            }
            else if(v==2)
            {
                string s = "Teacher";
                // Takinga a new input stream i.e.  
                // geeksforgeeks.txt and opens it 
                StreamReader sr = new StreamReader("D:\\Semester-03\\OOP\\Project\\Files\\Admin\\Red Zone\\" + s + ".txt");

                // This is use to specify from where  
                // to start reading input stream 
                sr.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read line from input stream 
                string str;

                // To read the whole file line by line 
                do
                {
                    str = sr.ReadLine();
                    if (str == null)
                    {
                        break;
                    }
                } while (str != id);

                if (str == id)
                {
                    str = sr.ReadLine();
                    if (str == password)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = 0;
                    }
                }
                else
                {
                    result = 0;
                }
                sr.Close();
            }
            else if(v==3)
            {
                if (password == "admin" && id == "admin")
                {
                    result = 1;
                }
                else
                {
                    result = 0;
                }
            }
        }
        public int getter()
        {
            return result;
        }
        public int get()
        {
            return v;
        }
    };
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomPage());
        }
    }
}
