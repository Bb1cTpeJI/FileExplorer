using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FileExplorer;
using System.Threading.Tasks;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace FileExplorer
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
            
            string path = Directory.GetCurrentDirectory();
            using (FileStream fStream = File.OpenRead($"{path}\\config.txt"))
            {
                byte[] array = new byte[fStream.Length];
                fStream.Read(array);
                string[] configText = (System.Text.Encoding.Default.GetString(array)).Split("\\");
                tbSearchFor.Text = configText[0];
                tbExtension.Text = configText[1];
            }    
        }

        //ToDo поменять типирование на var где возможно
        // Rider(jet brain) или resharper


        List<List<string>> fileInfo = new List<List<string>>();        
        bool taskRunning = false;
        bool isBreak = false;
        int filesFound = 0;

        public void btSearch_Click(object sender, EventArgs e)
        {
            if (taskRunning == false)
            {
                AsyncSearch();
                taskRunning = true;
                btSearch.Text = "Pause";
                if (isBreak)
                {
                    treeViewFiles.Nodes.Clear();
                    filesFound = 0;
                    btSearch.Text = "Search";
                    lbFileName.Text = "none";
                    isBreak = false;
                }
            }
            else if(taskRunning == true)
            {
                taskRunning = false;
                btSearch.Text = "Resume";
            }
        }

        private void FormSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            using (FileStream fStream = new FileStream($"{path}\\config.txt", FileMode.Truncate))
            {
                string userSearch = tbSearchFor.Text + "\\" + tbExtension.Text;
                byte[] array = System.Text.Encoding.Default.GetBytes(userSearch);
                fStream.Write(array);
            }
        }

        private void treeViewFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lbFileName.Text = e.Node.Text;
            for (int i = 0; i < fileInfo.Count(); i++)
            {
                if (fileInfo[i].Contains(e.Node.Text))
                {
                    lbFileSize.Text = fileInfo[i][1];
                    lbFilePath.Text = fileInfo[i][2];
                    lbFileSize.Visible = true;
                    lbFilePath.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                }
                else
                {
                    lbFileSize.Visible = false;
                    lbFilePath.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                }
            }
        }

        private async Task AsyncSearch() //много циклов, попробовать уйти от этого. Создать task/yield в кнопку и возвращать частичный result.
        {
            TreeViewFormation searchEngine = new TreeViewFormation();
            SearchedPaths searchedPaths = new SearchedPaths();

            var options = new EnumerationOptions()
            {
                IgnoreInaccessible = true
            };

            string[] diskPath = searchedPaths.getDiskPath();

            
            List<string> folderPath = await Task.Run(() => searchedPaths.getFolderDisk(diskPath));
                        

            foreach (string disk in diskPath)
            {
                var driveIsReady = new DriveInfo(disk);
                if (driveIsReady.IsReady)
                {
                    string[] fileNames = Directory.GetFiles(disk, tbExtension.Text, options);
                    foreach (string file in fileNames)
                    {
                        searchEngine.FormTree(file, treeViewFiles, tbSearchFor.Text, fileInfo);
                    }
                }
            }          

            List<string> filePath = new List<string>();            
            foreach(string folder in folderPath)
            {
                string[] fileNames = await Task.Run(() => Directory.GetFiles(folder, tbExtension.Text, options));
                foreach (string file in fileNames)
                {
                    searchEngine.FormTree(file, treeViewFiles, tbSearchFor.Text, fileInfo);
                }

                filePath = await Task.Run(() => searchedPaths.getAllSubFolders(folder, filePath));
                foreach (string folderFilePath in filePath)
                {
                    if (!isBreak)
                    {
                        fileNames = await Task.Run(() => Directory.GetFiles(folderFilePath, tbExtension.Text, options));
                        foreach (string file in fileNames)
                        {
                            Resume1:
                            if (taskRunning)
                            {
                                await Task.Run(() => Thread.Sleep(0));
                                Thread thread = Thread.CurrentThread;
                                filesFound++;
                                lbFilesCount.Text = filesFound.ToString();
                                searchEngine.FormTree(file, treeViewFiles, tbSearchFor.Text, fileInfo);
                            }
                            else if (!taskRunning && isBreak)
                            {
                                Array.Resize(ref fileNames, 1);
                                Array.Clear(fileNames, 0, fileNames.Length);
                                taskRunning = false;
                                btSearch.Text = "Search";
                                break;
                            }
                            else if (!taskRunning)
                            {
                                await Task.Run(() => Thread.Sleep(100));
                                goto Resume1; //аккуратнее с goto
                            }
                        }
                    }
                    else
                    {
                        folderPath.Clear();
                        taskRunning = false;
                        btSearch.Text = "Search";
                        break;
                    }
                }
            }            
            lbStatus.Text = "Search is finished";
            lbStatus.Visible = true;
            btSearch.Text = "Search";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            isBreak = true;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
