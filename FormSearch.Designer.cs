namespace FileExplorer
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.tbSearchFor = new System.Windows.Forms.TextBox();
            this.tbExtension = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbFileSize = new System.Windows.Forms.Label();
            this.lbFilePath = new System.Windows.Forms.Label();
            this.lbFilesCount = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewFiles.Location = new System.Drawing.Point(12, 12);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.Size = new System.Drawing.Size(364, 481);
            this.treeViewFiles.TabIndex = 0;
            this.treeViewFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFiles_AfterSelect);
            // 
            // tbSearchFor
            // 
            this.tbSearchFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchFor.Location = new System.Drawing.Point(398, 60);
            this.tbSearchFor.Name = "tbSearchFor";
            this.tbSearchFor.Size = new System.Drawing.Size(326, 23);
            this.tbSearchFor.TabIndex = 1;
            // 
            // tbExtension
            // 
            this.tbExtension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExtension.Location = new System.Drawing.Point(734, 60);
            this.tbExtension.Name = "tbExtension";
            this.tbExtension.Size = new System.Drawing.Size(88, 23);
            this.tbExtension.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search For";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(734, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Extension";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Size:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Path:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Files Searched:";
            // 
            // lbFileName
            // 
            this.lbFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFileName.AutoSize = true;
            this.lbFileName.Location = new System.Drawing.Point(495, 145);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(34, 15);
            this.lbFileName.TabIndex = 3;
            this.lbFileName.Text = "none";
            // 
            // lbFileSize
            // 
            this.lbFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFileSize.AutoSize = true;
            this.lbFileSize.Location = new System.Drawing.Point(495, 178);
            this.lbFileSize.Name = "lbFileSize";
            this.lbFileSize.Size = new System.Drawing.Size(65, 15);
            this.lbFileSize.TabIndex = 3;
            this.lbFileSize.Text = "//SizeLabel";
            this.lbFileSize.Visible = false;
            // 
            // lbFilePath
            // 
            this.lbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFilePath.AutoSize = true;
            this.lbFilePath.Location = new System.Drawing.Point(495, 212);
            this.lbFilePath.Name = "lbFilePath";
            this.lbFilePath.Size = new System.Drawing.Size(69, 15);
            this.lbFilePath.TabIndex = 3;
            this.lbFilePath.Text = "//PathLabel";
            this.lbFilePath.Visible = false;
            // 
            // lbFilesCount
            // 
            this.lbFilesCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFilesCount.AutoSize = true;
            this.lbFilesCount.Location = new System.Drawing.Point(495, 114);
            this.lbFilesCount.Name = "lbFilesCount";
            this.lbFilesCount.Size = new System.Drawing.Size(13, 15);
            this.lbFilesCount.TabIndex = 3;
            this.lbFilesCount.Text = "0";
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.Location = new System.Drawing.Point(438, 445);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(124, 48);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.Location = new System.Drawing.Point(568, 445);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(124, 48);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(698, 445);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(124, 48);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(402, 250);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(77, 15);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "//StatusLabel";
            this.lbStatus.Visible = false;
            // 
            // FormSearch
            // 
            this.ClientSize = new System.Drawing.Size(834, 505);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.lbFilesCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbFilePath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbFileSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbExtension);
            this.Controls.Add(this.tbSearchFor);
            this.Controls.Add(this.treeViewFiles);
            this.MinimumSize = new System.Drawing.Size(850, 544);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSearch_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //private System.Windows.Forms.Button btSearch;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label2;
        //private System.Windows.Forms.Button btPauseContinue;
        //public System.Windows.Forms.Label label3;
        //public System.Windows.Forms.Label label4;
        //public System.Windows.Forms.Label label5;
        //public System.Windows.Forms.TreeView treeViewFiles;
        //public System.Windows.Forms.TextBox tbSearchFor;
        //public System.Windows.Forms.TextBox tbExtension;
        //private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.Label lbFileName;
        //private System.Windows.Forms.Label lbFileSize;
        //private System.Windows.Forms.Label lbFilePath;
        //private System.Windows.Forms.Label lbFilesCount;
        private System.Windows.Forms.TreeView treeViewFiles;
        private System.Windows.Forms.TextBox tbSearchFor;
        private System.Windows.Forms.TextBox tbExtension;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Label lbFileSize;
        private System.Windows.Forms.Label lbFilePath;
        private System.Windows.Forms.Label lbFilesCount;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbStatus;
    }
}