namespace DDH_UI
{
    partial class MainUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dgFiles = new System.Windows.Forms.DataGridView();
            this.fileSystemItemsCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isFolderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaySizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastAccessTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastWriteTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSystemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemItemsCollectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFiles
            // 
            this.dgFiles.AllowUserToAddRows = false;
            this.dgFiles.AllowUserToDeleteRows = false;
            this.dgFiles.AllowUserToOrderColumns = true;
            this.dgFiles.AllowUserToResizeRows = false;
            this.dgFiles.AutoGenerateColumns = false;
            this.dgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isFolderDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.displaySizeDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.creationTimeDataGridViewTextBoxColumn,
            this.lastAccessTimeDataGridViewTextBoxColumn,
            this.lastWriteTimeDataGridViewTextBoxColumn,
            this.fileSystemTypeDataGridViewTextBoxColumn});
            this.dgFiles.DataSource = this.fileSystemItemsCollectionBindingSource;
            this.dgFiles.Location = new System.Drawing.Point(12, 40);
            this.dgFiles.Name = "dgFiles";
            this.dgFiles.ReadOnly = true;
            this.dgFiles.RowHeadersVisible = false;
            this.dgFiles.Size = new System.Drawing.Size(920, 572);
            this.dgFiles.TabIndex = 0;
            // 
            // fileSystemItemsCollectionBindingSource
            // 
            this.fileSystemItemsCollectionBindingSource.DataSource = typeof(DDH_UI.Code.FileSystemItemsCollection);
            // 
            // isFolderDataGridViewCheckBoxColumn
            // 
            this.isFolderDataGridViewCheckBoxColumn.DataPropertyName = "IsFolder";
            this.isFolderDataGridViewCheckBoxColumn.HeaderText = "IsFolder";
            this.isFolderDataGridViewCheckBoxColumn.Name = "isFolderDataGridViewCheckBoxColumn";
            this.isFolderDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isFolderDataGridViewCheckBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 230;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // displaySizeDataGridViewTextBoxColumn
            // 
            this.displaySizeDataGridViewTextBoxColumn.DataPropertyName = "DisplaySize";
            this.displaySizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.displaySizeDataGridViewTextBoxColumn.Name = "displaySizeDataGridViewTextBoxColumn";
            this.displaySizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Visible = false;
            // 
            // creationTimeDataGridViewTextBoxColumn
            // 
            this.creationTimeDataGridViewTextBoxColumn.DataPropertyName = "CreationTime";
            this.creationTimeDataGridViewTextBoxColumn.HeaderText = "CreationTime";
            this.creationTimeDataGridViewTextBoxColumn.Name = "creationTimeDataGridViewTextBoxColumn";
            this.creationTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.creationTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // lastAccessTimeDataGridViewTextBoxColumn
            // 
            this.lastAccessTimeDataGridViewTextBoxColumn.DataPropertyName = "LastAccessTime";
            this.lastAccessTimeDataGridViewTextBoxColumn.HeaderText = "LastAccessTime";
            this.lastAccessTimeDataGridViewTextBoxColumn.Name = "lastAccessTimeDataGridViewTextBoxColumn";
            this.lastAccessTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastAccessTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // lastWriteTimeDataGridViewTextBoxColumn
            // 
            this.lastWriteTimeDataGridViewTextBoxColumn.DataPropertyName = "LastWriteTime";
            this.lastWriteTimeDataGridViewTextBoxColumn.HeaderText = "LastWriteTime";
            this.lastWriteTimeDataGridViewTextBoxColumn.Name = "lastWriteTimeDataGridViewTextBoxColumn";
            this.lastWriteTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastWriteTimeDataGridViewTextBoxColumn.Width = 130;
            // 
            // fileSystemTypeDataGridViewTextBoxColumn
            // 
            this.fileSystemTypeDataGridViewTextBoxColumn.DataPropertyName = "FileSystemType";
            this.fileSystemTypeDataGridViewTextBoxColumn.HeaderText = "FileSystemType";
            this.fileSystemTypeDataGridViewTextBoxColumn.Name = "fileSystemTypeDataGridViewTextBoxColumn";
            this.fileSystemTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 624);
            this.Controls.Add(this.dgFiles);
            this.Name = "MainUi";
            this.Text = "Download Directory Helper";
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemItemsCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFiles;
        private System.Windows.Forms.BindingSource fileSystemItemsCollectionBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFolderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displaySizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastAccessTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastWriteTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileSystemTypeDataGridViewTextBoxColumn;
    }
}

