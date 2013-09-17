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
        private List<FileSystemItem> _originalListing;

        public MainUi() {
            InitializeComponent();

            string dirPath = ConfigurationManager.AppSettings["DownloadsDirectory"];

#if DEBUG
            if (Environment.MachineName.ToUpper().Contains("BLACKBELT"))
                dirPath = @"C:\home\Downloads";
            if (Environment.MachineName.ToUpper().Contains("ORGRIMMAR"))
                dirPath = @"D:\Downloads";
#endif

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
            _originalListing = fsDataItems;
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

        private void txtFindAsYouType_TextChanged(object sender, EventArgs e) {
            if (txtFindAsYouType.Text.Length == 0)
                dgFiles.DataSource = _originalListing;
            else {
                dgFiles.DataSource = _originalListing.Where(f => f.Name.ToLower().Contains(txtFindAsYouType.Text.ToLower())).ToList();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            var query = _originalListing.AsQueryable();

            int largerThanSize = 0;
            if (int.TryParse(txtLargerThan.Text, out largerThanSize))
                query = query.Where(x => (x.Size / 1000 / 1000) > largerThanSize);

            int olderThanDays = 0;
            if (int.TryParse(txtCreatedNDaysAgo.Text, out olderThanDays))
                query = query.Where(x => (DateTime.Now - x.CreationTime).Days >= olderThanDays);

            dgFiles.DataSource = query.ToList();
        }

        private void dgFiles_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            dgFiles.Rows[e.RowIndex].Selected = true;
        }

        private void showInWindowsExplorerToolStripMenuItem_Click(object sender, EventArgs e) {
            if (dgFiles.SelectedRows.Count == 0)
                return;
            var selectedRowKey = dgFiles.SelectedRows[0].Cells["ItemGuid"].Value;
            var fileItem = _originalListing.SingleOrDefault(x => x.ItemGuid.ToString() == (string)selectedRowKey);
            ShowSelectedInExplorer.FileOrFolder(fileItem.FullName);
        }
    }
}
