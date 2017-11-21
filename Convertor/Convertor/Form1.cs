using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MediaToolkit;
using MediaToolkit.Model;

namespace Convertor
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Main 3 variables and massiv about converting formats
        /// </summary>
        public string[] str = { "mp3", "flac", "wav", "wma"};
        public string pathOutput;
        public string FormatIn;
        public string FormatOut;
        
        /// <summary>
        /// Initialize comboboxes with media formats, and program's settings
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(2100, 1200);
            this.openFileDialog1.Filter = "MusicFiles(*.mp3; *.flac; *.wav; *.wma)|*.mp3;*.flac;*.wav;*.wma;|All files(*.*)|*.*";
            this.cbFormat.Items.AddRange(str);
            this.cbFormatIn.Items.AddRange(str);
            this.notifyIcon1.Visible = true;

        }

        /// <summary>
        /// Event push button Add Folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAddFolder_Click(object sender, EventArgs e)
        {
            
            if (this.listView1.Items.Count == 0)
            {
                OpenFolder();   
            }
            else if (this.listView1.Items.Count != 0)
            {
                var qu = MessageBox.Show("Clear list?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (qu == DialogResult.Yes)
                {
                    this.listView1.Items.Clear();
                    OpenFolder();
                }
                else if (qu == DialogResult.No)
                    OpenFolder();
            }
        }
        /// <summary>
        /// Method open folder to list
        /// </summary>
        private void OpenFolder()
        {
            if (FormatIn == null)
            {
                var f = new Form2();
                f.ShowDialog();
                FormatIn += Class1.Text;
                f.Close();
                this.cbFormatIn.Text = FormatIn;
            }
            if (FormatIn == "") return;
            else
            {
                if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    List<string> lst = new List<string>(Directory.EnumerateFiles(this.folderBrowserDialog1.SelectedPath, string.Format("*.{0}", FormatIn)));
                    if (lst.Count != 0)
                    {
                        foreach (var j in lst)
                        {
                            FileInfo fi = new FileInfo(j);
                            this.listView1.Items.Add(new ListViewItem(new string[] { fi.Name, fi.Extension, string.Format("{0} Mb", (fi.Length / 1000).ToString()), fi.FullName }));
                        }
                    }

                    if (lst.Count == 0)
                        MessageBox.Show(string.Format("This folder exist no one {0} file", FormatIn), "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// Event push button Add File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void bAddFiles_Click(object sender, EventArgs e)
        {
            
            if (this.listView1.Items.Count == 0)
            {
                OpenFiles();
            }
            else if (this.listView1.Items.Count != 0)
            {
                var qu = MessageBox.Show("Clear list?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (qu == DialogResult.Yes)
                {
                    this.listView1.Items.Clear();
                    OpenFiles();
                }
                else if (qu == DialogResult.No)
                    OpenFiles();
            }
        }
        /// <summary>
        /// Method of open file to list
        /// </summary>
        private void OpenFiles()
        {
            if (FormatIn == null)
            {
                var f = new Form2();
                f.ShowDialog();
                FormatIn += Class1.Text;
                f.Close();
                this.cbFormatIn.Text = FormatIn;
            }
            if (FormatIn == "") return;
            else
            {
                this.openFileDialog1.Filter = string.Format("MusicFiles({0};)|{0};|All files(*.*)|*.*", string.Format("*.{0}", FormatIn));
                if (this.openFileDialog1.ShowDialog() != DialogResult.OK) return;

                List<string> lst = new List<string>(this.openFileDialog1.FileNames);
                foreach (var j in lst)
                {
                    FileInfo fi = new FileInfo(j);
                    this.listView1.Items.Add(new ListViewItem(new string[] { fi.Name, fi.Extension, string.Format("{0} Mb", (fi.Length / 1000).ToString()), fi.FullName }));
                }
            }
        }
        /// <summary>
        /// Event push button Remove 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRemove_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem i in this.listView1.SelectedItems)
                    i.Remove();       
            }
            else
            {
                MessageBox.Show("File not selected", "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Event push button Remove all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRemoveAll_Click(object sender, EventArgs e)
        {
            if (this.listView1.Items.Count > 0)
            {
                var q = MessageBox.Show("Clear list?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (q == DialogResult.Yes)
                    this.listView1.Items.Clear();
            }
        }


        /// <summary>
        /// Event push button Browse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void bBrowse_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pathOutput = this.folderBrowserDialog1.SelectedPath.ToString();
                this.tbPathOutput.Text = this.pathOutput;
            }
        }
        /// <summary>
        /// Event change value in OutputFormat combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFormat_SelectedIndexChanged(object sender, EventArgs e) //cbFormatOut
        {
            this.cbFormat.Text = this.cbFormat.SelectedItem.ToString();
            if (this.cbFormat.Text == FormatIn)
                MessageBox.Show("You chose the format as InFile(s) ", "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else 
                FormatOut = cbFormat.Text;
        }
        /// <summary>
        /// Event change value in InputFormat combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFormatIn_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cbFormatIn.Text = this.cbFormatIn.SelectedItem.ToString();
            if (this.cbFormatIn.Text == FormatOut)
                MessageBox.Show("You chose the format as OutFile(s)", "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                FormatIn = cbFormatIn.Text;
        }
        /// <summary>
        /// Event push button Convert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bConvert_Click(object sender, EventArgs e)
        {
            
            if (this.listView1.Items.Count != 0)
            {
                if (FormatIn != FormatOut)
                {
                    if (FormatOut != null)
                    {
                        if (tbPathOutput.Text != "")
                        {
                            this.progressBar1.Value = 0;
                            //this.progressBar1.Enabled = true;
                            //this.progressBar2.Enabled = true;
                            this.progressBar1.Step = (100/(this.listView1.Items.Count+1));
                            foreach (ListViewItem item in this.listView1.Items)
                            {
                                this.progressBar1.PerformStep();
                                MediaFile infile = new MediaFile(item.SubItems[3].Text);
                                string newName = Regex.Replace(item.SubItems[0].Text, "\\.\\w+$", "");
                                MediaFile outfile = new MediaFile(string.Format("{0}\\{1}.{2}", this.tbPathOutput.Text, newName, FormatOut));
                                StartConverting(infile, outfile);  // Method of convert files
                            }
                        }
                        else
                        {
                            MessageBox.Show("You should to choose folder for output files", "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("You should to choose format to convert", "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("You chosed the same format", "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //this.progressBar1.Enabled = false;
            }
            else
            {
                MessageBox.Show("No one file was selected", "Help", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.progressBar1.Value = 0;
        }

        /// <summary>
        /// Method of convert files
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        public void StartConverting(MediaFile inputFile, MediaFile outputFile)
        {
            
            using (var engine = new Engine())
            {
                engine.ConvertProgressEvent += Engine_ConvertProgressEvent1;
                engine.ConversionCompleteEvent += Engine_ConversionCompleteEvent;
                engine.Convert(inputFile, outputFile);
            }
        }

        private void Engine_ConvertProgressEvent1(object sender, ConvertProgressEventArgs e)
        {
            //this.progressBar2.Step = int.Parse(e.ProcessedDuration.Ticks.ToString()) * 100 / e.SizeKb;
            //this.progressBar2.PerformStep();
            //this.textBox1.Text = e.ProcessedDuration.Milliseconds.ToString();
        }

        private void Engine_ConversionCompleteEvent(object sender, ConversionCompleteEventArgs e)
        {
            //this.textBox1.Text = e.SizeKb.ToString();
        }


        /// <summary>
        /// Event push button Destination Folder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) // open destination folder
        {
            FormOutFolder fof = new FormOutFolder();
            if (this.tbPathOutput.Text == "")
            {
                MessageBox.Show("No content", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                fof.textBox1.Text = this.tbPathOutput.Text;
                List<string> newfile = new List<string>(Directory.EnumerateFiles(this.tbPathOutput.Text));
                foreach (var i in newfile)
                {
                    FileInfo fi = new FileInfo(i);
                    fof.listView1.Items.Add(new ListViewItem(new string[] { fi.Name, fi.Extension, string.Format("{0} Mb", (fi.Length / 1000).ToString()) }));
                }
                fof.Show();
            }
        }

        /// <summary>
        /// Spate of contextMenu events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitStripMenuItem1_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Close programm?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q == DialogResult.Yes)
                Application.Exit();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help h = new Convertor.Help();
            h.Show();
        }
    }
}
