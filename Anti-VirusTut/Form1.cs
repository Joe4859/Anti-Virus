using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anti_VirusTut
{
    public partial class Form1 : Form
    {
        int viruses;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPick.Hide();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            MessageBox.Show("" + folderBrowserDialog1.SelectedPath);
            viruses = 0;
            metroLabel2.Text = "Viruses: " + viruses.ToString();
            metroProgressBar1.Value = 0;
            listView1.Items.Clear();
            btnPick.Show();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            string[] search = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*");
            metroProgressBar1.Maximum = search.Length;
            foreach(string item in search)
            {
                try
                {
                    StreamReader stream = new StreamReader(item);
                    string read = stream.ReadToEnd();
                    string[] virus = new string[] { "trojan", "virus", "malware", "adware", "hacking", "hacker", "freeware", "RAT" };
                    foreach(string st in virus)
                    {
                        if(Regex.IsMatch(read, st))
                        {
                            MessageBox.Show("Virus Dectected!");
                            viruses += 1;
                            metroLabel1.Text = "Viruses: " + viruses.ToString();
                            listView1.Items.Add(item);
                        }
                        metroProgressBar1.Increment(1);
                    }
                }
                catch
                {
                    string read = item;
                    string[] virus = new string[] { "trojan", "virus", "malware", "adware", "hacking", "hacker", "freeware", "RAT" };
                    foreach (string st in virus)
                    {
                        if (Regex.IsMatch(read, st))
                        {
                            MessageBox.Show("Virus Alert");
                            viruses += 1;
                            metroLabel1.Text = "Viruses: " + viruses.ToString();
                            listView1.Items.Add(item);
                        }
                        metroProgressBar1.Increment(1);
                    }                }
            }
        }
    }
}
