namespace login_page
{
    
    public partial class Form1 : Form
    {
        public static string l;
        string[] line, line1, line2;
        string adpass = "karthikadmin";
        int number=0;
        public Form1()
        {
        InitializeComponent();
            textBox2.PasswordChar = '*';

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check=false,check1=false ;
            try 
            {
                if ((textBox1.Text == null) || (textBox2.Text == null))
                {
                    label1.Text = "enter all details.";
                }
                else
                {
                    number = 0;
                    line = File.ReadAllLines("username1.txt");
                    string s = textBox1.Text;
                    for (int i = 0; i < line.Length; i++)
                    {
                        number++;
                        if (line[i] == s)
                        {
                            check = true;
                            break;
                        }
                    }
                    line1 = File.ReadAllLines("password1.txt");
                    string q = textBox2.Text;

                    if (line1[number - 1] == q)
                    {
                        check1 = true;
                    }
                    line2 = File.ReadAllLines("name1.txt");
                    l = line2[number - 1];
                    if ((check == true) && (check1 == true))
                    {
                        label1.Text = string.Format("{0} login successful!!!!!", l);
                        if (!File.Exists(l + ".txt"))
                        {
                            FileStream file = File.Create(l + ".txt");
                            file.Close();
                        }

                        timer1.Start();
                    }
                    else
                    {
                        label1.Text = "check the details entered";
                    }
                }
            }
            catch
            {
                label1.Text = "sign up first there are no active users";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Form3 fr3 = new Form3();
            fr3.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Location = Cursor.Position;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string adp = textBox2.Text;
            label1.Text = "enter admin password";
           
            if (adp == adpass)
            {
                Form2 form = new Form2();
                form.Show();
            }
            else
            {
                label1.Text = "wrong password. access denied";
                label2.Visible = true;
                textBox1.Visible = true;
            }
        }
        public string filename
        {
            get { return l; }
        }

    }
}