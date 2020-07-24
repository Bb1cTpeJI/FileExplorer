using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using FileExplorer;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace FileExplorer
{
    public class TreeViewFormation
    {        
        public void FormTree(string fileNames, TreeView TreeViewFiles, string searchFor, List<List<string>> fileInfo)
        {            
            string[] splitPath = fileNames.Split("\\");
            string searchedFile = splitPath[^1]; // the last index of the array?

            if (searchedFile.IndexOf(searchFor) >= 0)
            {
                FileInfo fDetails = new FileInfo(fileNames);
                List<string> fInfo = new List<string>();
                
                fInfo.Add(fDetails.Name);
                fInfo.Add(fDetails.Length.ToString());
                fInfo.Add(fDetails.FullName);

                fileInfo.Add(fInfo);

                FormNodes(splitPath, TreeViewFiles);
                //fInfo.Clear();
            }
        }

        public void FormNodes(string[] splitPath, TreeView TreeViewFiles)
        {
            TreeNode node;
            TreeNodeCollection nodes = TreeViewFiles.Nodes;

            foreach (string name in splitPath)
            {
                if (nodes.ContainsKey(name))
                {
                    node = nodes[name];
                }
                else
                {
                    node = new TreeNode(name);
                    node.Name = name;
                    nodes.Add(node);
                }
                nodes = node.Nodes;
            }
        }
    }
}

