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


            }
        }
        private void button1_Click(object sender, EventArgs e)
        
          
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "ffplay.exe";
            startInfo.Arguments = @"d:/1.mp3";
            process.StartInfo = startInfo;
            process.Start();
        }
       
    }
    }

