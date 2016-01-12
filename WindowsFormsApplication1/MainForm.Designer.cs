namespace WindowsFormsApplication1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bntSelectFolder = new System.Windows.Forms.Button();
            this.btnCheckFolders = new System.Windows.Forms.Button();
            this.dlgSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tbSelectedFolder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvInvalidItems = new System.Windows.Forms.ListView();
            this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntSelectFolder
            // 
            this.bntSelectFolder.Location = new System.Drawing.Point(11, 38);
            this.bntSelectFolder.Name = "bntSelectFolder";
            this.bntSelectFolder.Size = new System.Drawing.Size(123, 23);
            this.bntSelectFolder.TabIndex = 0;
            this.bntSelectFolder.Text = "Select Folder";
            this.bntSelectFolder.UseVisualStyleBackColor = true;
            this.bntSelectFolder.Click += new System.EventHandler(this.bntSelectFolder_Click);
            // 
            // btnCheckFolders
            // 
            this.btnCheckFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckFolders.Enabled = false;
            this.btnCheckFolders.Location = new System.Drawing.Point(363, 38);
            this.btnCheckFolders.Name = "btnCheckFolders";
            this.btnCheckFolders.Size = new System.Drawing.Size(130, 23);
            this.btnCheckFolders.TabIndex = 1;
            this.btnCheckFolders.Text = "Check Folder";
            this.btnCheckFolders.UseVisualStyleBackColor = true;
            this.btnCheckFolders.Click += new System.EventHandler(this.btnCheckFolders_Click);
            // 
            // dlgSelectFolder
            // 
            this.dlgSelectFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.dlgSelectFolder.ShowNewFolderButton = false;
            // 
            // tbSelectedFolder
            // 
            this.tbSelectedFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSelectedFolder.Location = new System.Drawing.Point(10, 12);
            this.tbSelectedFolder.Name = "tbSelectedFolder";
            this.tbSelectedFolder.ReadOnly = true;
            this.tbSelectedFolder.Size = new System.Drawing.Size(483, 20);
            this.tbSelectedFolder.TabIndex = 2;
            this.tbSelectedFolder.TextChanged += new System.EventHandler(this.tbSelectedFolder_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lvInvalidItems);
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 370);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Invalid Folders/Files (Double-click to open)";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lvInvalidItems
            // 
            this.lvInvalidItems.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvInvalidItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chPath,
            this.chReason});
            this.lvInvalidItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInvalidItems.FullRowSelect = true;
            this.lvInvalidItems.GridLines = true;
            this.lvInvalidItems.LargeImageList = this.ilLarge;
            this.lvInvalidItems.Location = new System.Drawing.Point(3, 16);
            this.lvInvalidItems.MultiSelect = false;
            this.lvInvalidItems.Name = "lvInvalidItems";
            this.lvInvalidItems.ShowGroups = false;
            this.lvInvalidItems.Size = new System.Drawing.Size(477, 351);
            this.lvInvalidItems.SmallImageList = this.ilSmall;
            this.lvInvalidItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvInvalidItems.TabIndex = 0;
            this.lvInvalidItems.UseCompatibleStateImageBehavior = false;
            this.lvInvalidItems.View = System.Windows.Forms.View.Details;
            this.lvInvalidItems.SelectedIndexChanged += new System.EventHandler(this.lvInvalidItems_SelectedIndexChanged);
            this.lvInvalidItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvInvalidItems_MouseDoubleClick);
            // 
            // chPath
            // 
            this.chPath.Text = "Path";
            // 
            // chReason
            // 
            this.chReason.Text = "Reason";
            // 
            // ilLarge
            // 
            this.ilLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLarge.ImageStream")));
            this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ilLarge.Images.SetKeyName(0, "directory");
            this.ilLarge.Images.SetKeyName(1, "file");
            // 
            // ilSmall
            // 
            this.ilSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSmall.ImageStream")));
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSmall.Images.SetKeyName(0, "file");
            this.ilSmall.Images.SetKeyName(1, "directory");
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Location = new System.Drawing.Point(421, 444);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 479);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbSelectedFolder);
            this.Controls.Add(this.btnCheckFolders);
            this.Controls.Add(this.bntSelectFolder);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.Text = "Directory Checker";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSelectFolder;
        private System.Windows.Forms.Button btnCheckFolders;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectFolder;
        private System.Windows.Forms.TextBox tbSelectedFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ListView lvInvalidItems;
        private System.Windows.Forms.ColumnHeader chPath;
        private System.Windows.Forms.ColumnHeader chReason;
        private System.Windows.Forms.ImageList ilLarge;
        private System.Windows.Forms.ImageList ilSmall;
    }
}

