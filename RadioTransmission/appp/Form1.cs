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
        private double l = 0;
        private double start = 0;
        private double duration = 0;
        private string songg;
        public Form1()
        {
            InitializeComponent();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog filedialoge1 = new OpenFileDialog();


            if (filedialoge1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                Uri ifile = new Uri(filedialoge1.FileName);
                vlc.playlist.add(ifile.ToString());
                songg = filedialoge1.FileName;
            }

            textBox1.Text = filedialoge1.FileName;

        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            String startt = Convert.ToString(start);
            String durationn = Convert.ToString(duration);
            string arg = " -ss " + startt + " -i " + songg + " -t " + durationn + " d:/song2.mp3";
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
          
            startInfo.FileName = Environment.CurrentDirectory + @"\ffmpeg.exe";
            
            startInfo.Arguments = arg;
            process.StartInfo = startInfo;
            process.Start();

        }

        private void Start_Click(object sender, EventArgs e)
        {
            double length = ((Convert.ToDouble(vlc.input.length)) / 1000) / 60;
            //MessageBox.Show(Convert.ToString(length));
            double a = vlc.input.position; // in milliseconds
            start = a * length * 60;
            //MessageBox.Show(Convert.ToString(start));
            l = length;
        }

        private void vlc_Enter(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            double b = vlc.input.position * l * 60;
           // MessageBox.Show(Convert.ToString(b));
            duration = b - start;
            //MessageBox.Show(Convert.ToString(duration));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DatabaseOperation.Insert();

        }
    }
}