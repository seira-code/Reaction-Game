using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;

namespace TIMER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            mmss.Text = "00:00";

            point.Visible = false;
            point.Enabled = false;
            points1.Text = "0";

            easy.Checked = true;
        }
        DateTime secondmer = new DateTime();
        int secnds;
        int points2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            secnds += 1;
            if (nickname.Text == "")
            {
                secnds = 0;
                button1.Text = "Start";
                MessageBox.Show("Введите ник");
            }

            if (secnds == 1)
            {
                timer1.Start();
                timer2.Start();
                button1.Text = "Stop";

                point.Visible = true;
                point.Enabled = true;

                easy.Enabled = false;
                medium.Enabled = false;
                hard.Enabled = false;

                nickname.Enabled = false;
            }
            if (secnds == 2)
            {
                timer1.Stop();
                timer2.Stop();
                point.Enabled = false;
                button1.Text = "Reset";

                point.Visible = false;
                point.Enabled = false;
                
                easy.Enabled = true;
                medium.Enabled = true;
                hard.Enabled = true;

                nickname.Enabled = true;
            }
            if (secnds == 3)
            {
                secnds = 0;
                points2 = 0;

                points1.Text = "0";
                button1.Text = "Start";
                mmss.Text = "00:00";
                secondmer = new DateTime(0, 0);
            }


        }
        void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
        void Swap(ref string a, ref string b)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            secondmer = secondmer.AddSeconds(1);
            mmss.Text = secondmer.ToString("mm:ss");

            if (secondmer.Second == 10)
            {
                timer1.Stop();
                timer2.Stop();
                point.Enabled = false;

                FileStream file = new FileStream("Leaderboards.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamReader reader = new StreamReader(file);
                string[] Nick = new string[10];
                int[] Point = new int[10];
                int hmm = 0;
                while (!reader.EndOfStream)
                {

                    string[] tmp = reader.ReadLine().Split('`');
                    Nick[hmm] = tmp[0];
                    Point[hmm] = int.Parse(tmp[1]);
                    hmm++;

                }

                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (Point[j] < Point[j + 1]) { Swap(ref Point[j], ref Point[j + 1]); Swap(ref Nick[j], ref Nick[j + 1]); }
                    }

                }
                reader.Close();
                file.Close();

                FileStream leaderboards1 = new FileStream("Leaderboards.txt", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter str = new StreamWriter(leaderboards1);
                int Position = -1;
                for (int i = 0; i < 10; i++)
                {
                    if (Point[i] < int.Parse(points1.Text)) { Position = i; break; }

                }
                if (Position != -1)
                {
                    for (int i = 9; i > Position; i--)
                    {
                        Point[i] = Point[i - 1];
                        Nick[i] = Nick[i - 1];
                    }
                    Point[Position] = int.Parse(points1.Text);
                    Nick[Position] = nickname.Text;
                    

                }
                for (int i = 0; i < 10; i++)
                {
                    str.WriteLine(Nick[i] + '`' + Point[i]);
                }

                str.Close();
                leaderboards1.Close();

                    
               

            } 


        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            point.Location = new Point(rand.Next(-14, 598), rand.Next(-61, 174));
        }

        private void point_Click(object sender, EventArgs e)
        {
            points2 += 1;
            points1.Text = points2 + "";

            timer2.Stop();
            timer2.Start();

            Random rand = new Random();
            point.Location = new Point(rand.Next(-14, 598), rand.Next(-61, 174));
        }

        private void hard_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Interval = 499;
        }
 
        private void medium_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Interval = 650;
        }

        private void easy_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
        }

        private void leaderbord_Click(object sender, EventArgs e)
        {
            LeaderBoards lb = new LeaderBoards();
            lb.Owner = this;
            lb.Show();
        }

    }
}
