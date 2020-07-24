using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace FileExplorer
{
    public class SearchedPaths
    {

        public string[] getDiskPath()
        {
            string[] diskNames = Directory.GetLogicalDrives();            
            return diskNames;
        }

        public List<string> getFolderDisk(string[] path) //yield return
        {
            List<string> folderNames = new List<string>();
            
            foreach (string disk in path)
            {
                var driveIsReady = new DriveInfo(disk);
                if (driveIsReady.IsReady)
                    folderNames.AddRange(Directory.GetDirectories(disk));                
            }
            return folderNames;           
        }

        public List<String> getAllSubFolders(string path, List<String> folderList) //yield return
        {
            var options = new EnumerationOptions()
            {
                IgnoreInaccessible = true
            };

            string[] directories = Directory.GetDirectories(path, "*", options);
            
            foreach (string folder in directories)
            {
                folderList.AddRange(Directory.GetDirectories(folder, "*", options));
                getAllSubFolders(folder, folderList);
            }

            return folderList;
        }
    }
}
