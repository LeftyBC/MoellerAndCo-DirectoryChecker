using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            Bitmap bmp = MoellerAndCoDirectoryChecker.Properties.Resources.lightning31_32x32;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        public struct InvalidEntry
        {
            public String fullPath;
            public String invalidReason;
            public override String ToString()
            {
                return String.Format("{0} ({1})", this.fullPath, this.invalidReason);
            }
            public Icon getIcon()
            {
                if (Directory.Exists(this.fullPath))
                {
                    // is a directory
                    Bitmap bmp = (Bitmap)MoellerAndCoDirectoryChecker.Properties.Resources.layers;
                    return Icon.FromHandle(bmp.GetHicon());
                } else
                {
                    // is a file
                    Bitmap bmp = (Bitmap)MoellerAndCoDirectoryChecker.Properties.Resources.document6;
                    return Icon.FromHandle(bmp.GetHicon());
                }
            }
        }

        private void bntSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSelectFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbSelectedFolder.Text = dlgSelectFolder.SelectedPath.ToString();
            }
        }

        private void btnCheckFolders_Click(object sender, EventArgs e)
        {
            String selectedPath = tbSelectedFolder.Text;
            if (Directory.Exists(selectedPath))
            {
                // start iterating files
                checkDirectories(selectedPath);
            }
            else
            {
                MessageBox.Show(String.Format("Selected folder [{0}] not found.  Please select a different folder.", selectedPath), "Folder not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkDirectories(String pathToCheck)
        {
            Console.WriteLine(String.Format("Checking path: {0}", pathToCheck));

            lvInvalidItems.Enabled = false;
            lvInvalidItems.Items.Clear();

            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            try
            {

                foreach (String dir in Directory.EnumerateDirectories(pathToCheck, "*", SearchOption.TopDirectoryOnly).Distinct())
                {
                    //Console.WriteLine(String.Format("Directory Entry: {0}", entry));
                    bool found = false;

                    foreach (String entry in Directory.EnumerateFileSystemEntries(dir, "*", SearchOption.TopDirectoryOnly).Distinct())
                    {


                        if (Directory.Exists(entry) && Path.GetFileName(entry).ToLower() == "extended")
                        {
                            // this directory is fine
                            Console.WriteLine(String.Format("Directory {0} is acceptable", entry));
                            found = true;
                        }
                        else {
                            // this directory or file shouldn't be here
                            InvalidEntry invalid = new InvalidEntry();
                            invalid.fullPath = entry;
                            invalid.invalidReason = "File/Directory should not be here";
                            String type = Directory.Exists(entry) ? "directory" : "file";
                            string[] reasons = {invalid.fullPath, invalid.invalidReason, };
                            lvInvalidItems.Items.Add(new ListViewItem(reasons, type));
                        }

                    }

                        if (!found)
                        {
                            InvalidEntry invalid = new InvalidEntry();
                            invalid.fullPath = dir;
                            invalid.invalidReason = "Directory did not contain an Extended folder";
                            string[] reasons = {invalid.fullPath, invalid.invalidReason};
                            lvInvalidItems.Items.Add(new ListViewItem(reasons, "directory"));
                        }


                }

            }
            finally
            {

                lvInvalidItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                lvInvalidItems.Enabled = true;
                Cursor.Current = currentCursor;
                    
            }
        }

        private void tbSelectedFolder_TextChanged(object sender, EventArgs e)
        {
            btnCheckFolders.Enabled = Directory.Exists(tbSelectedFolder.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void lbMatchingFolders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbMatchingFolders_DoubleClick(object sender, MouseEventArgs e)
        {
            /*
            int index = this.lvInvalidItems.Ind.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                String entry = (String)this.lvInvalidItems.SelectedItem;
                Process.Start(entry);
            }
            */
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lvInvalidItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvInvalidItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ListViewHitTestInfo info = this.lvInvalidItems.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;

            if (item != null)
            {
                Process.Start(item.Text);
            }

        }
    }
}
