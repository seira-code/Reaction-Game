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

namespace TIMER
{
    public partial class LeaderBoards : Form
    {
        public LeaderBoards()
        {
            InitializeComponent();
        }

        private void LeaderBoards_Load(object sender, EventArgs e)
        {
            Form1 start = Owner as Form1;
            this.Location = new Point(start.Location.X + start.Width, start.Location.Y);

            FileStream file = new FileStream("Leaderboards.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(file);

            int i = 0;
            while (!reader.EndOfStream)
            {
                Label lbl = new Label();
                lbl.Location = new Point(10, 5 + i);
                lbl.AutoSize = true;
                string[] np = reader.ReadLine().Split('`');
                lbl.Text = np[0] + ":" + np[1];
                i += 15;
                Controls.Add(lbl);
            }

            reader.Close(); file.Close();

        }
    }
}
