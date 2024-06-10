using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Horse1.Left += rnd.Next(5, 15);
            Horse2.Left += rnd.Next(5, 15);
            Horse3.Left += rnd.Next(5, 15);

            // Bitiş çizgisine ulaşıp ulaşmadıklarını kontrol edin
            if (Horse1.Left >= label4.Left - Horse1.Width ||
                Horse2.Left >= label4.Left - Horse2.Width ||
                Horse3.Left >= label4.Left - Horse3.Width)
            {
                timer1.Stop();
                string winner = "";
                if (Horse1.Left >= label4.Left - Horse1.Width)
                {
                    winner = "Horse 1";
                }
                else if (Horse2.Left >= label4.Left - Horse2.Width)
                {
                    winner = "Horse 2";
                }
                else if (Horse3.Left >= label4.Left - Horse3.Width)
                {
                    winner = "Horse 3";
                }
                MessageBox.Show($"{winner} wins!");
            }
        }
    }
}
