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

namespace Subtitle_Renamer
{
    public partial class MainForm : Form
    {
        public string folderpath;
        public List<String> files = new List<String>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            folderpath = folderBrowserDialog1.SelectedPath;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool includeSubFolders = includeSubFoldersCheckbox.Checked; 
            string originExtension = txt_origem.Text;
            string destinationExtension = txt_destino.Text;
            FileInfo[] infos;
            DirectoryInfo directoryInfo = new DirectoryInfo(folderpath);
            if (includeSubFolders == true)
                infos = directoryInfo.GetFiles("*" + originExtension, SearchOption.AllDirectories);
            else
                infos = directoryInfo.GetFiles();

            long numerOfFiles = infos.Count();
           // decimal percentageToIncreaseInEachFile = 100 / numerOfFiles;

            foreach (FileInfo f in infos)
            {
                File.Move(f.FullName, f.FullName.ToString().Replace(originExtension, destinationExtension));
               // progressBar1.Value = Convert.ToInt32(percentageToIncreaseInEachFile);
            }

        }

        private void DirSearch(string sDir)
        {
            try
            {
                DirectoryInfo d1 = new DirectoryInfo(folderpath);
                List<string> rawFiles = Directory.GetFiles(sDir).ToList();
                foreach (string f in rawFiles)
                {
                    if (f.Contains(".srt") )
                    {
                        files.Add(f);
                    }
                    
                }
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
    }
}
