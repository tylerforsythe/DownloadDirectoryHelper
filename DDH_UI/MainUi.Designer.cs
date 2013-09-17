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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreatedNDaysAgo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLargerThan = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFindAsYouType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isFolderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displaySizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastAccessTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastWriteTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSystemTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileSystemItemsCollectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ago";
            // 
            // txtCreatedNDaysAgo
            // 
            this.txtCreatedNDaysAgo.Location = new System.Drawing.Point(95, 12);
            this.txtCreatedNDaysAgo.Name = "txtCreatedNDaysAgo";
            this.txtCreatedNDaysAgo.Size = new System.Drawing.Size(32, 20);
            this.txtCreatedNDaysAgo.TabIndex = 0;
            this.txtCreatedNDaysAgo.Text = "7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "created at least";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "larger than";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "MB";
            // 
            // txtLargerThan
            // 
            this.txtLargerThan.Location = new System.Drawing.Point(237, 14);
            this.txtLargerThan.Name = "txtLargerThan";
            this.txtLargerThan.Size = new System.Drawing.Size(32, 20);
            this.txtLargerThan.TabIndex = 1;
            this.txtLargerThan.Text = "0";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(857, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFindAsYouType
            // 
            this.txtFindAsYouType.Location = new System.Drawing.Point(832, 618);
            this.txtFindAsYouType.Name = "txtFindAsYouType";
            this.txtFindAsYouType.Size = new System.Drawing.Size(100, 20);
            this.txtFindAsYouType.TabIndex = 6;
            this.txtFindAsYouType.TextChanged += new System.EventHandler(this.txtFindAsYouType_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(739, 621);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Find as you type:";
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
            // fileSystemItemsCollectionBindingSource
            // 
            this.fileSystemItemsCollectionBindingSource.DataSource = typeof(DDH_UI.Code.FileSystemItemsCollection);
            // 
            // MainUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 650);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFindAsYouType);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtLargerThan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreatedNDaysAgo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgFiles);
            this.Name = "MainUi";
            this.Text = "Download Directory Helper";
            ((System.ComponentModel.ISupportInitialize)(this.dgFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemItemsCollectionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreatedNDaysAgo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLargerThan;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtFindAsYouType;
        private System.Windows.Forms.Label label5;
    }
}

