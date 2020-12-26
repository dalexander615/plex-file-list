﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace plex_file_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void BrowseFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;

                listView1.Items.Clear();

                string[] files = Directory.GetFiles(folderDlg.SelectedPath);
                foreach (string file in files)
                {

                    string fileName = Path.GetFileNameWithoutExtension(file);
                    ListViewItem item = new ListViewItem(fileName);
                    item.Tag = file;

                    listView1.Items.Add(item);
                }
            }
        }
        public void ListFiles(string directoryPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);
            FileStream fileStream = null;
            if (directoryInfo.Exists)
            {
                FileInfo[] fileInfo1 = directoryInfo.GetFiles();
                DirectoryInfo[] subdirectoryInfo = directoryInfo.GetDirectories();
                foreach (DirectoryInfo subDirectory in subdirectoryInfo)
                {
                   ListFiles(subDirectory.FullName);
                }
                foreach (FileInfo file1 in fileInfo1)
                {
                    string fileName1 = Path.GetFileNameWithoutExtension(file1);
                    ListViewItem item = new ListViewItem(fileName1);
                    item.Tag = file1.ToString();

                    listView1.Items.Add(item);
                }
            }
        }
        // list files
        private void button2_Click(object sender, EventArgs e)
        {
            ListFiles("c:\\Temp");
        }
    }
}

