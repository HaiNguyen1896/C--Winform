using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            takeInputDir();
            takeOutputDir();
        }

        public void takeInputDir()
        {
            if (File.Exists("E:\\example\\BeforeDirectivePathSavingFile.txt"))
            {
                using (FileStream fsr = File.OpenRead("E:\\example\\BeforeDirectivePathSavingFile.txt"))
                {
                    StreamReader streamReader = new StreamReader(fsr);
                    string readerVal = streamReader.ReadToEnd();
                    txtOpenFol.Text = readerVal;
                }
            }
        }

        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dirSelected = new FolderBrowserDialog();
            if (dirSelected.ShowDialog() == DialogResult.OK)
            {
                    txtOpenFol.Text = dirSelected.SelectedPath;
            }
            else
            {
                MessageBox.Show("Please select the folder");
            }
        }

        private void createStorageFolderAndWritePathFiles(string path,string folderStoreName,string file)
        {
            Directory.CreateDirectory(path+@"/"+folderStoreName);
            string savingFilePath = path + @"/"+file;
            File.Create(savingFilePath).Close();
            using (FileStream fsw = File.OpenWrite(savingFilePath))
            {
                StreamWriter writer = new StreamWriter(fsw);
                writer.Write(path+@"/"+folderStoreName);
                writer.Close();
            }
        }
        private void chkSaveBfr_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSaveBfr.Checked)
            {
                if (txtOpenFol.Text == "")
                {
                    MessageBox.Show("Directive to List file still empty, please select directive first");
                }
                else
                {
                    if (Directory.Exists(txtOpenFol.Text))
                    {
                        string folderStoreName = "Storage";
                        string file = "BeforeDirectivePathSavingFile.txt";
                        createStorageFolderAndWritePathFiles(txtOpenFol.Text,folderStoreName,file);
                    }
                    else
                    {
                        MessageBox.Show("Directory is not exits");
                    }
                  
                }
            }
        }
        
        private int doFilesCount (string path) {
            int fileCount = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories).Length;
            return fileCount;
        }
        private string[] doGetFiles (string path) {
            string[] filesNames = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
            return filesNames;
        }
        
      

        private void showFilesInRichTextBox(string[]files)
        {
            string fileName = "";
            foreach (var file in files)
            {
                fileName += file +"\n";
            }

            rtbList.Text = fileName;
        }
        private void btnGetFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog getFile = new OpenFileDialog();
            
                if (Directory.Exists(txtOpenFol.Text))
                {
                    txtOpenFol.Text = txtOpenFol.Text.Replace('/', '\\');
                    getFile.InitialDirectory = txtOpenFol.Text;
                    int numberFilesInFolder = doFilesCount(txtOpenFol.Text);
                    if(numberFilesInFolder==0)
                    {
                        MessageBox.Show("Folder is empty, copy files to folder to rename or select a different folder");
                    }
                    else
                    {
                        MessageBox.Show("The folder has " + numberFilesInFolder+ " jpg type" + " files");
                        string[] files = doGetFiles(txtOpenFol.Text);
                        if (files.Length > 0 && files.GetType().IsArray)
                        {
                            showFilesInRichTextBox(files);
                        }
                    }
                }
                else
                {
                    getFile.InitialDirectory = @"E:\";
                }
        }

        private void btnSaveBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dirSelected = new FolderBrowserDialog();
            if (dirSelected.ShowDialog() == DialogResult.OK)
            {
                txtSaveFol.Text = dirSelected.SelectedPath;
            }
            else
            {
                MessageBox.Show("Please select the folder");
            }
        }
        
        public void takeOutputDir()
        {
            if (File.Exists("E:\\example\\AfterDirectivePathSavingFile.txt"))
            {
                using (FileStream fsr = File.OpenRead("E:\\example\\AfterDirectivePathSavingFile.txt"))
                {
                    StreamReader streamReader = new StreamReader(fsr);
                    string readerVal = streamReader.ReadToEnd();
                    txtSaveFol.Text = readerVal;
                }
            }
        }

        private void chkSaveAft_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSaveAft.Checked)
            {
                if (txtSaveFol.Text == "")
                {
                    MessageBox.Show("Directive to List file still empty, please select directive first");
                }
                else
                {
                    if (Directory.Exists(txtSaveFol.Text))
                    {
                        string folderStoreName = "FinalStorage";
                        string file = "AfterDirectivePathSavingFile.txt";
                        createStorageFolderAndWritePathFiles(txtSaveFol.Text,folderStoreName,file);
                    }
                    else
                    {
                        MessageBox.Show("Directory is not exits");
                    }
                }
            }
        }
        
        private void copyFiles (string sourcePath,string finalPath) {
            string[] filesNames = doGetFiles(sourcePath);
            if (filesNames.Length > 0 && filesNames.GetType().IsArray)
            {
                foreach (var file in filesNames)
                {
                    string fileName = Path.GetFileName(file);
                    fileName = fileName.Replace(".jpg", "_new.jpg");
                    string changeOriginalName = fileName;
                    string finalFileName = Path.Combine(finalPath, changeOriginalName);
                    File.Create(finalFileName);
                }
                MessageBox.Show("Copy to new folder finished and successfully rename");
            }
            else
            {
                if (rtbList.Text == "")
                {
                    MessageBox.Show("No files exit in copy folder");
                }
                else if (txtSaveFol.Text == "")
                {
                    MessageBox.Show("No destination files path, please choose one to located the saving file path");
                }
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (rtbList.Text != "" && txtSaveFol.Text != "")
            {
                copyFiles(txtOpenFol.Text,txtSaveFol.Text);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}