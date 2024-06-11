using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static List<string> songs = new List<string>();

        private void btnStop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if(browser.ShowDialog() == DialogResult.OK)
            {
                var path = browser.SelectedPath;
                var file = Directory.GetFiles(path);

                foreach (var item in file)
                {
                    songs.Add(item);
                }

                foreach (var item in songs)
                {
                    listMusic.Items.Add(item.Split('\\').LastOrDefault());
                }
            }

            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            foreach ( var item in songs)
            {
                if(item.Contains(listMusic.SelectedItem.ToString()))
                {

                    axWindowsMediaPlayer1.URL = item;
                    break;
                }

                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            listMusic.Items.Clear();
            Random rnd = new Random();

            for (int i = 0; i < songs.Count; i++)
            {
                int j = rnd.Next(i, songs.Count);
                string temp = songs[i];

                songs[i] = songs[j];
                songs[j] = temp;

            }

            foreach( var item in songs)
            {
                listMusic.Items.Add(item.Split('\\').LastOrDefault());
            }

        }
    }
}
