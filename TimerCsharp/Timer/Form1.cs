using System;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        private int seconds = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            seconds = 0;
            label1.Text = "00";
            label2.Text = "00";
            label3.Text = "00";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            TimeSpan time = TimeSpan.FromSeconds(seconds);

            label1.Text = time.Hours.ToString("D2");
            label2.Text = time.Minutes.ToString("D2");
            label3.Text = time.Seconds.ToString("D2");
        }
    }
}
