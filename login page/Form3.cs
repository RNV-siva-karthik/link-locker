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
   
    public partial class Form3 : Form
    {//RNV SIVA KARTHIK.
        string[] url;
        int number=0,number1=0,i=0;
        string s;
        string L = "";
        LinkLabel[] txtbox = new LinkLabel[10];
        public Form3()
        {
            InitializeComponent();
            L=Form1.l.ToString();
            timer1.Start();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int top = 50, bottom = 61;
            url = File.ReadAllLines(L+".txt");
            if (url.Length == 0)
            {
                label3.Visible = true;
                button3.Visible = false;
                label3.Text = "no links to display:(";
            }
            else
            {
                number = 0;
                button3.Visible = false;
                for ( i = 0; i < url.Length; i++)
                {
                    number++;
                    LinkLabel linkLabel1 = new LinkLabel();
                    linkLabel1.Text = url[i];
                    s = linkLabel1.Text;
                    linkLabel1.AutoSize = true;
                    linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    linkLabel1.Location = new System.Drawing.Point(top, bottom);
                    linkLabel1.Name = string.Format("linkLabel{0}", number);
                    linkLabel1.Size = new System.Drawing.Size(90, 25);
                    linkLabel1.TabIndex = 5;
                    linkLabel1.BringToFront();
                    bottom = bottom + 37;
                    linkLabel1.Tag = number;
                    linkLabel1.Click += new EventHandler(linkLabel1_Click);
                    this.Controls.Add(linkLabel1);
                    linkLabel1.Visible = true;
                }
                void linkLabel1_Click(object sender, EventArgs e)
                {
                    LinkLabel number = sender as LinkLabel;
                    string p = "";
                    System.Diagnostics.Process.Start("explorer", number.Text);
                }
                label3.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string link = textBox1.Text;
            StreamWriter file1=File.AppendText(L+".txt");
            file1.WriteLine(link);
            file1.Close();
            string[] nolin = File.ReadAllLines(L + ".txt");
            button3.Visible = true;
            textBox1.Clear();
        }
       
    }
}
