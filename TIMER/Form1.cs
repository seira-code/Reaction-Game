using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            easy.Checked = true;

        }
        DateTime secondmer = new DateTime();
        int secnds;
        int points2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            secnds += 1;
            if (secnds == 1)
            {
                timer1.Start();
                timer2.Start();
                button1.Text = "Stop";
                point.Visible = true;
                point.Enabled = true;
            }
            if (secnds == 2)
            {
                timer1.Stop();
                timer2.Stop();
                point.Enabled = false;
                button1.Text = "Reset";
                point.Visible = false;
                point.Enabled = false;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondmer = secondmer.AddSeconds(1);
            mmss.Text = secondmer.ToString("mm:ss");

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
    }
}
