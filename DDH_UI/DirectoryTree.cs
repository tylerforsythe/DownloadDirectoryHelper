using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace DDH_UI
{

    public class DirectoryTree : TreeView
    {
        public event DirectorySelectedEventHandler DirectorySelected;
        public delegate void DirectorySelectedEventHandler(object sender, DirectorySelectedEventArgs e);
        private char _Drive;
        public char Drive {
            get { return _Drive; }
            set {
                _Drive = value;
                RefreshDisplay();
            }
        }
        public void RefreshDisplay() {
            this.Nodes.Clear();
            TreeNode RootNode = new TreeNode(_Drive + ":\\");
            this.Nodes.Add(RootNode);
            Fill(RootNode);
            this.Nodes[0].Expand();
        }
        private void Fill(TreeNode DirNode) {
            DirectoryInfo Dir = new DirectoryInfo(DirNode.FullPath);
            DirectoryInfo DirItem = null;
            foreach (DirectoryInfo DirItem_loopVariable in Dir.GetDirectories()) {
                DirItem = DirItem_loopVariable;
                TreeNode NewNode = new TreeNode(DirItem.Name);
                DirNode.Nodes.Add(NewNode);
                NewNode.Nodes.Add("*");
            }
        }
        protected override void OnBeforeExpand(TreeViewCancelEventArgs e) {
            base.OnBeforeExpand(e);
            if (e.Node.Nodes[0].Text == "*") {
                e.Node.Nodes.Clear();
                Fill(e.Node);
            }
        }
        protected override void OnAfterSelect(TreeViewEventArgs e) {
            base.OnAfterSelect(e);
            if (DirectorySelected != null) {
                DirectorySelected(this, new DirectorySelectedEventArgs(e.Node.FullPath));
            }
        }
    }
    public class DirectorySelectedEventArgs : EventArgs
    {
        public string DirectoryName;
        public DirectorySelectedEventArgs(string DirectoryName) {
            this.DirectoryName = DirectoryName;
        }
    }

}
