using FileRenameHandler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileRenamer
{
    public partial class frmMain : Form
    {
        private bool previewed = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.InitControls();
        }

        private void InitControls()
        {
            var modes = Enum.GetNames(typeof(FileRenameMode));
            foreach (var mode in modes)
            {
                this.cboHandleMode.Items.Add(mode);
            }

            if (modes.Count() > 0)
            {
                this.cboHandleMode.SelectedIndex = 0;
            }
        }

        private void PreHandleFileName()
        {
            this.AddFiles();

            string oldChar = this.txtOldChar.Text;
            string newChar = this.txtNewChar.Text;

            FileRenameMode mode = (FileRenameMode)Enum.Parse(typeof(FileRenameMode), this.cboHandleMode.Text);

            if (mode == FileRenameMode.RemoveOrReplace || mode == FileRenameMode.Trim)
            {
                if (string.IsNullOrEmpty(oldChar))
                {
                    MessageBox.Show("The old char can't be empty.");
                    return;
                }
            }
            else if (mode == FileRenameMode.Insert)
            {
                if (string.IsNullOrEmpty(newChar))
                {
                    MessageBox.Show("The new char can't be empty.");
                    return;
                }
            }
            else if (mode == FileRenameMode.Extract)
            {
                int startPos = (int)this.nudStartPosition.Value;
                int endPos = (int)this.nudEndPosition.Value;

                if (endPos >= 1 && startPos > endPos)
                {
                    MessageBox.Show("From position must be less than to position.");
                }
            }

            foreach (ListViewItem item in this.lvFile.Items)
            {
                FileInfo file = item.Tag as FileInfo;

                string newFileName = null;
                if (this.chkBaseOnNewName.Checked && !string.IsNullOrEmpty(item.SubItems[1].Tag?.ToString()))
                {
                    newFileName = item.SubItems[1].Tag.ToString();
                }

                FileRenameOption option = new FileRenameOption()
                {
                    Mode = mode,
                    DoRename = false,
                    ExcessiveFileName = newFileName,
                    HandleOldCharByExpression = this.chkOldCharByExpression.Checked,
                    OldChar = oldChar,
                    NewChar = newChar,
                    InsertBeforeMarkChar = this.txtInsertBefore.Text,
                    InsertAfterMarkChar = this.txtInsertAfter.Text,
                    NewCharInsertBefore = this.rbNewCharInsertBefore.Checked,
                    NewCharInsertAfter = this.rbNewCharInsertAfter.Checked,
                    ExtractByPosition = this.rbExtractByPosition.Checked,
                    ExtractByExpression = this.rbExtractByExpression.Checked,
                    ExtractStartPosition = (int)this.nudStartPosition.Value,
                    ExtractEndPosition = (int)this.nudEndPosition.Value,
                    ExtractExpression = this.txtExractExpression.Text,
                };

                FileRenameProcessor processor = new FileRenameProcessor(option);

                string errMsg = "";
                newFileName = processor.Rename(file, out errMsg);

                if (!string.IsNullOrEmpty(errMsg))
                {
                    MessageBox.Show(errMsg);
                    break;
                }
                else
                {
                    item.SubItems[1].Tag = Path.GetFileNameWithoutExtension(newFileName);
                    item.SubItems[1].Text = newFileName;
                }

                item.ForeColor = file.Name == newFileName ? Color.Black : Color.Blue;
            }

            this.previewed = true;
        }

        private void RenameFile()
        {
            int count = 0;
            foreach (ListViewItem item in this.lvFile.Items)
            {
                FileInfo file = item.Tag as FileInfo;

                if(File.Exists(file.FullName))
                {
                    string fileName = Path.GetFileNameWithoutExtension(file.Name);
                    string newFileName = item.SubItems[1].Text;

                    if (!string.IsNullOrEmpty(newFileName) && newFileName != fileName)
                    {
                        string newFilePath = Path.Combine(file.DirectoryName, newFileName);
                        if (!File.Exists(newFilePath))
                        {
                            file.MoveTo(newFilePath);
                            count++;
                        }
                    }
                } 
                else
                {
                    item.BackColor = Color.Yellow;
                }
            }

            if (count > 0)
            {
                MessageBox.Show($"Total renamed {count} files。");
            }
            else
            {
                MessageBox.Show("It doesn't rename any file.");
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            this.PreHandleFileName();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if(!this.previewed)
            {
                this.PreHandleFileName();
            }
           
            this.RenameFile();

            this.previewed = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntOpenFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtFolder.Text) && Directory.Exists(this.txtFolder.Text))
            {
                this.folderBrowserDialog1.SelectedPath = this.txtFolder.Text;
            }

            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = this.folderBrowserDialog1.SelectedPath;
                this.txtFolder.Text = path;
            }
        }

        private void AddFiles()
        {
            DirectoryInfo di = new DirectoryInfo(this.txtFolder.Text);
            string filter = string.IsNullOrEmpty(this.cboFilter.Text) ? "*.*" : "*." + this.cboFilter.Text.Trim('.');

            var files = di.GetFiles(filter, this.chkIncludeChildFolder.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

            foreach (var file in files)
            {
                if (!this.lvFile.Items.ContainsKey(file.FullName))
                {
                    ListViewItem li = new ListViewItem();
                    li.Tag = file;
                    li.Name = file.FullName;
                    li.Text = file.Name;
                    li.SubItems.Add("");

                    this.lvFile.Items.Add(li);
                }
            }
        }

        private void cboHandleMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string modeName = this.cboHandleMode.Text;

            FileRenameMode mode = (FileRenameMode)Enum.Parse(typeof(FileRenameMode), modeName);

            if (InfoHelper.HandleModeDescriptions.ContainsKey(mode))
            {
                this.lblModeDescription.Text = $"({ InfoHelper.HandleModeDescriptions[mode]})";
            }

            bool isInsertMode = mode == FileRenameMode.Insert;
            bool isExtractMode = mode == FileRenameMode.Extract;
            bool isTrimMode = mode == FileRenameMode.Trim;
            bool isInsertFolderNameMode = mode == FileRenameMode.InsertFolderName;
            this.panelExtract.Enabled = isExtractMode;

            this.panelOldChar.Enabled = !isExtractMode && !isInsertMode && !isInsertFolderNameMode;
            this.panelNewChar.Enabled = !isExtractMode && !isTrimMode;

            this.txtNewChar.Text = isInsertFolderNameMode && !string.IsNullOrEmpty(this.txtFolder.Text) ? new DirectoryInfo(this.txtFolder.Text).Name : "";

            this.panelInsert.Enabled = isInsertFolderNameMode || isInsertMode;
            this.chkOldCharByExpression.Enabled = mode == FileRenameMode.RemoveOrReplace;
        }

        private void lvFile_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.lvFile.FocusedItem.Bounds.Contains(e.Location))
                {
                    this.contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void tsmiRemove_Click(object sender, EventArgs e)
        {
            if (this.lvFile.SelectedItems != null)
            {
                for (int i = this.lvFile.SelectedItems.Count - 1; i >= 0; i--)
                {
                    this.lvFile.SelectedItems[i].Remove();
                }
            }
        }

        private void openInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lvFile.FocusedItem != null)
            {
                FileInfo file = this.lvFile.FocusedItem.Tag as FileInfo;

                string fileName = file.Name;

                if (!string.IsNullOrEmpty(this.lvFile.FocusedItem.SubItems[1].Text))
                {
                    fileName = this.lvFile.FocusedItem.SubItems[1].Text;
                }

                string filePath = Path.Combine(file.DirectoryName, fileName);

                if (!File.Exists(filePath) && file.Exists)
                {
                    filePath = file.FullName;
                }

                if (File.Exists(filePath))
                {
                    string cmd = "explorer.exe";
                    string arg = "/select," + filePath;
                    Process.Start(cmd, arg);
                }
            }
        }

        private void txtFolder_TextChanged(object sender, EventArgs e)
        {
            string folder = this.txtFolder.Text;

            if (!string.IsNullOrEmpty(folder) && Directory.Exists(folder))
            {
                DirectoryInfo di = new DirectoryInfo(folder);

                IEnumerable<FileInfo> files;

                if(Path.GetPathRoot(folder) == folder)
                {
                    files = di.GetDirectories().Where(item => item.Name != "System Volume Information").SelectMany(item => this.GetFiles(item));
                }
                else
                {
                    files = this.GetFiles(di);
                }

                var exts = files
                    .Where(item => (item.Attributes & FileAttributes.Hidden) == 0)
                    .GroupBy(item => item.Extension.ToLower())
                    .Select(item => item.Key).ToList();

                this.cboFilter.Items.Clear();
                exts.ForEach(item => this.cboFilter.Items.Add(item));
            }            
        }

        private IEnumerable<FileInfo> GetFiles(DirectoryInfo directoryInfo)
        {
            return directoryInfo.GetFiles("*.*", SearchOption.AllDirectories);
        }

        private void tsmiClearAll_Click(object sender, EventArgs e)
        {
            this.lvFile.Items.Clear();
        }
    }
}
