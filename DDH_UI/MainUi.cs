using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDH_UI.Code;

namespace DDH_UI
{
    public partial class MainUi : Form
    {
        public MainUi() {
            InitializeComponent();

            string dirPath = ConfigurationManager.AppSettings["DownloadsDirectory"];
            PopulateDirectory(dirPath);
        }
        
        private void PopulateDirectory(string directoryPathToScan) {
            var fsDataItems = new List<FileSystemItem>();

            var currentDirInfo = new DirectoryInfo(directoryPathToScan);
            var folders = currentDirInfo.GetDirectories();
            var files = currentDirInfo.GetFiles();

            // Add the ".." option, if needed
            var parentFolder = new FileSystemItem(currentDirInfo.Parent);
            parentFolder.Name = "..";
            fsDataItems.Add(parentFolder);

            foreach (var folder in folders)
                fsDataItems.Add(new FileSystemItem(folder));

            foreach (var file in files)
                fsDataItems.Add(new FileSystemItem(file));

            dgFiles.DataSource = fsDataItems;
        }

        public void ShowCustomTree() {
            var DirTree = new DirectoryTree();
            DirTree.Size = new Size(this.Width - 30, this.Height - 60);
            DirTree.Location = new Point(5, 5);
            DirTree.Drive = 'C';
            this.Controls.Add(DirTree);
        }

        private void fileSystemItemBindingSource_CurrentChanged(object sender, EventArgs e) {

        }
    }
}
