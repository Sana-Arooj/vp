using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace appp
{
    public partial class Form1 : Form
    {
        private double start=0;
        private double stop = 0;
        private string songg;
        public Form1()
        {
            InitializeComponent();

        }
        


        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Add Audio Files";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
           
            {

                Uri ifile = new Uri(openFileDialog1.FileName);
                vlc.playlist.add(ifile.ToString());
                songg = openFileDialog1.FileName;
                

            }
        }
        private void button1_Click(object sender, EventArgs e)
        
          
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
         //   startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = Environment.CurrentDirectory + @"\ffmpeg.exe";
            
            startInfo.Arguments = @" -ss 10 -i d:/song.mp3 -t 20 d:/song1.mp3";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String startt = Convert.ToString(start);
            String durationn = Convert.ToString(stop);
            string arg = " -ss " + startt + " -i "+songg+" -t " + durationn + " d:/song2.mp3";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //   startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            
            startInfo.FileName = Environment.CurrentDirectory + @"\ffmpeg.exe";
            startInfo.Arguments = arg;
            process.StartInfo = startInfo;
            process.Start();
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            double a = vlc.input.position; // in milliseconds
            start = a*100;
            MessageBox.Show(Convert.ToString(a));
        }

        private void vlc_Enter(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            double b = vlc.input.position;
            stop = b * 100;
            
        }

    }
    }

