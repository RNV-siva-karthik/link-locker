using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_page
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            string name = textBox1.Text;
            if ((textBox2.Text != string.Empty) && (textBox3.Text != String.Empty)&&(textBox3.Text!=String.Empty))
            {
                string username = textBox2.Text;
                string file1 = "username1.txt";
                if (!File.Exists(file1))
                {
                    StreamWriter file = new StreamWriter(file1);
                    file.WriteLine(username);
                    file.Close();

                }
                else
                {
                    StreamWriter file2 = File.AppendText(file1);
                    file2.WriteLine(username);
                    file2.Close();

                }
                string password = textBox3.Text;
                string file0 = "password1.txt";
                if (!File.Exists(file1))
                {
                    StreamWriter file = new StreamWriter(file0);
                    file.WriteLine(password);
                    file.Close();

                }
                else
                {
                    StreamWriter file2 = File.AppendText(file0);
                    file2.WriteLine(password);
                    file2.Close();

                }


                string file3 = "name1.txt";
                if (!File.Exists(file3))
                {
                    StreamWriter file = new StreamWriter(file3);
                    file.WriteLine(name);
                    file.Close();

                }
                else
                {
                    StreamWriter file2 = File.AppendText(file3);
                    file2.WriteLine(name);
                    file2.Close();

                }
                label5.Text = "entered successfully";
                button1.Enabled = false;
            }
            else
            {
                label5.Text = "enter all the details";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.TopMost=true;
            this.Close();
        }
    }
}
