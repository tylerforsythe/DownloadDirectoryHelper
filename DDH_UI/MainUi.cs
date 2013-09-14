﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDH_UI
{
    public partial class MainUi : Form
    {
        public MainUi() {
            InitializeComponent();

            DirectoryTree DirTree = new DirectoryTree();
            DirTree.Size = new Size(this.Width - 30, this.Height - 60);
            DirTree.Location = new Point(5, 5);
            DirTree.Drive = 'C';
            this.Controls.Add(DirTree);
        }
    }
}
