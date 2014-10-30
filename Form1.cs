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
using System.Xml;

namespace JustUOStartup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                string clientpath = this.folderBrowserDialog1.SelectedPath;
                string clientfile = clientpath + "\\client.exe";

                if (!File.Exists(clientfile))
                {
                    MessageBox.Show("This folder does not appear to contain client files!");
                }

                else
                    results.Text = clientpath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string _clientpath = results.Text;
            string _shardname = inputName.Text;

            if (String.IsNullOrEmpty(_shardname))
            {
                MessageBox.Show("You must type a shard name!");
            }

            else if (String.IsNullOrEmpty(_clientpath))
            {
                MessageBox.Show("You must select a path to your client files!");
            }

            else
            {
                if (File.Exists(@"startup.xml"))
                    File.Delete(@"startup.xml");

                using (XmlWriter writer = XmlWriter.Create("startup.xml"))
                {
                    writer.WriteStartElement("startupinfo");
                    writer.WriteElementString("shardname", _shardname);
                    writer.WriteElementString("clientpath", _clientpath);
                    writer.WriteEndElement();
                    writer.Flush();
                }

                MessageBox.Show("Initialization complete, we will now compile your server and start it!");

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "Compile.WIN.bat";
                proc.StartInfo.RedirectStandardError = false;
                proc.StartInfo.RedirectStandardOutput = false;
                proc.StartInfo.UseShellExecute = false;
                proc.Start();

                Application.Exit();
             }
        }
    }
}
