namespace FileRenamer
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bntOpenFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.chkIncludeChildFolder = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboHandleMode = new System.Windows.Forms.ComboBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelNewChar = new System.Windows.Forms.Panel();
            this.panelInsert = new System.Windows.Forms.Panel();
            this.txtInsertAfter = new System.Windows.Forms.TextBox();
            this.rbNewCharInsertAfter = new System.Windows.Forms.RadioButton();
            this.txtInsertBefore = new System.Windows.Forms.TextBox();
            this.rbNewCharInsertBefore = new System.Windows.Forms.RadioButton();
            this.txtNewChar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOldChar = new System.Windows.Forms.TextBox();
            this.lblOldChar = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lblModeDescription = new System.Windows.Forms.Label();
            this.nudStartPosition = new System.Windows.Forms.NumericUpDown();
            this.lvFile = new System.Windows.Forms.ListView();
            this.colOldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNewName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkBaseOnNewName = new System.Windows.Forms.CheckBox();
            this.nudEndPosition = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelExtract = new System.Windows.Forms.Panel();
            this.rbExtractByExpression = new System.Windows.Forms.RadioButton();
            this.rbExtractByPosition = new System.Windows.Forms.RadioButton();
            this.txtExractExpression = new System.Windows.Forms.TextBox();
            this.panelOldChar = new System.Windows.Forms.Panel();
            this.chkOldCharByExpression = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.openInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.panelNewChar.SuspendLayout();
            this.panelInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPosition)).BeginInit();
            this.panelExtract.SuspendLayout();
            this.panelOldChar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntOpenFolder
            // 
            this.bntOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntOpenFolder.Location = new System.Drawing.Point(557, 13);
            this.bntOpenFolder.Name = "bntOpenFolder";
            this.bntOpenFolder.Size = new System.Drawing.Size(44, 23);
            this.bntOpenFolder.TabIndex = 5;
            this.bntOpenFolder.Text = "...";
            this.bntOpenFolder.UseVisualStyleBackColor = true;
            this.bntOpenFolder.Click += new System.EventHandler(this.bntOpenFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(98, 14);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(453, 21);
            this.txtFolder.TabIndex = 4;
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Folder:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 27;
            this.label5.Text = "File filter:";
            // 
            // chkIncludeChildFolder
            // 
            this.chkIncludeChildFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIncludeChildFolder.AutoSize = true;
            this.chkIncludeChildFolder.Checked = true;
            this.chkIncludeChildFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncludeChildFolder.Location = new System.Drawing.Point(617, 17);
            this.chkIncludeChildFolder.Name = "chkIncludeChildFolder";
            this.chkIncludeChildFolder.Size = new System.Drawing.Size(144, 16);
            this.chkIncludeChildFolder.TabIndex = 26;
            this.chkIncludeChildFolder.Text = "Include child folder";
            this.chkIncludeChildFolder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 12);
            this.label2.TabIndex = 29;
            this.label2.Text = "(filter by file extension, like txt or .txt)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 30;
            this.label3.Text = "Rename mode:";
            // 
            // cboHandleMode
            // 
            this.cboHandleMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHandleMode.FormattingEnabled = true;
            this.cboHandleMode.Location = new System.Drawing.Point(98, 79);
            this.cboHandleMode.Name = "cboHandleMode";
            this.cboHandleMode.Size = new System.Drawing.Size(130, 20);
            this.cboHandleMode.TabIndex = 31;
            this.cboHandleMode.SelectedIndexChanged += new System.EventHandler(this.cboHandleMode_SelectedIndexChanged);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(590, 460);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 32;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(686, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelNewChar
            // 
            this.panelNewChar.Controls.Add(this.panelInsert);
            this.panelNewChar.Controls.Add(this.txtNewChar);
            this.panelNewChar.Controls.Add(this.label4);
            this.panelNewChar.Location = new System.Drawing.Point(3, 142);
            this.panelNewChar.Name = "panelNewChar";
            this.panelNewChar.Size = new System.Drawing.Size(758, 26);
            this.panelNewChar.TabIndex = 41;
            // 
            // panelInsert
            // 
            this.panelInsert.Controls.Add(this.txtInsertAfter);
            this.panelInsert.Controls.Add(this.rbNewCharInsertAfter);
            this.panelInsert.Controls.Add(this.txtInsertBefore);
            this.panelInsert.Controls.Add(this.rbNewCharInsertBefore);
            this.panelInsert.Location = new System.Drawing.Point(234, 0);
            this.panelInsert.Name = "panelInsert";
            this.panelInsert.Size = new System.Drawing.Size(477, 26);
            this.panelInsert.TabIndex = 39;
            // 
            // txtInsertAfter
            // 
            this.txtInsertAfter.Location = new System.Drawing.Point(344, 3);
            this.txtInsertAfter.Name = "txtInsertAfter";
            this.txtInsertAfter.Size = new System.Drawing.Size(97, 21);
            this.txtInsertAfter.TabIndex = 40;
            // 
            // rbNewCharInsertAfter
            // 
            this.rbNewCharInsertAfter.AutoSize = true;
            this.rbNewCharInsertAfter.Location = new System.Drawing.Point(235, 6);
            this.rbNewCharInsertAfter.Name = "rbNewCharInsertAfter";
            this.rbNewCharInsertAfter.Size = new System.Drawing.Size(95, 16);
            this.rbNewCharInsertAfter.TabIndex = 18;
            this.rbNewCharInsertAfter.Text = "Insert after";
            this.rbNewCharInsertAfter.UseVisualStyleBackColor = true;
            // 
            // txtInsertBefore
            // 
            this.txtInsertBefore.Location = new System.Drawing.Point(111, 4);
            this.txtInsertBefore.Name = "txtInsertBefore";
            this.txtInsertBefore.Size = new System.Drawing.Size(97, 21);
            this.txtInsertBefore.TabIndex = 39;
            // 
            // rbNewCharInsertBefore
            // 
            this.rbNewCharInsertBefore.AutoSize = true;
            this.rbNewCharInsertBefore.Checked = true;
            this.rbNewCharInsertBefore.Location = new System.Drawing.Point(3, 6);
            this.rbNewCharInsertBefore.Name = "rbNewCharInsertBefore";
            this.rbNewCharInsertBefore.Size = new System.Drawing.Size(101, 16);
            this.rbNewCharInsertBefore.TabIndex = 17;
            this.rbNewCharInsertBefore.TabStop = true;
            this.rbNewCharInsertBefore.Text = "Insert before";
            this.rbNewCharInsertBefore.UseVisualStyleBackColor = true;
            // 
            // txtNewChar
            // 
            this.txtNewChar.Location = new System.Drawing.Point(95, 2);
            this.txtNewChar.Name = "txtNewChar";
            this.txtNewChar.Size = new System.Drawing.Size(130, 21);
            this.txtNewChar.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "New char:";
            // 
            // txtOldChar
            // 
            this.txtOldChar.Location = new System.Drawing.Point(95, 3);
            this.txtOldChar.Name = "txtOldChar";
            this.txtOldChar.Size = new System.Drawing.Size(130, 21);
            this.txtOldChar.TabIndex = 36;
            // 
            // lblOldChar
            // 
            this.lblOldChar.Location = new System.Drawing.Point(4, 7);
            this.lblOldChar.Name = "lblOldChar";
            this.lblOldChar.Size = new System.Drawing.Size(85, 17);
            this.lblOldChar.TabIndex = 35;
            this.lblOldChar.Text = "Old char:";
            this.lblOldChar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Location = new System.Drawing.Point(490, 460);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 43;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblModeDescription
            // 
            this.lblModeDescription.AutoSize = true;
            this.lblModeDescription.Location = new System.Drawing.Point(238, 84);
            this.lblModeDescription.Name = "lblModeDescription";
            this.lblModeDescription.Size = new System.Drawing.Size(71, 12);
            this.lblModeDescription.TabIndex = 44;
            this.lblModeDescription.Text = "Description";
            // 
            // nudStartPosition
            // 
            this.nudStartPosition.Location = new System.Drawing.Point(116, 5);
            this.nudStartPosition.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStartPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStartPosition.Name = "nudStartPosition";
            this.nudStartPosition.Size = new System.Drawing.Size(52, 21);
            this.nudStartPosition.TabIndex = 46;
            this.nudStartPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lvFile
            // 
            this.lvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOldName,
            this.colNewName});
            this.lvFile.FullRowSelect = true;
            this.lvFile.GridLines = true;
            this.lvFile.HideSelection = false;
            this.lvFile.Location = new System.Drawing.Point(3, 253);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(769, 199);
            this.lvFile.TabIndex = 47;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            this.lvFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvFile_MouseClick);
            // 
            // colOldName
            // 
            this.colOldName.Text = "Old name";
            this.colOldName.Width = 350;
            // 
            // colNewName
            // 
            this.colNewName.Text = "New name";
            this.colNewName.Width = 350;
            // 
            // chkBaseOnNewName
            // 
            this.chkBaseOnNewName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBaseOnNewName.AutoSize = true;
            this.chkBaseOnNewName.Location = new System.Drawing.Point(8, 464);
            this.chkBaseOnNewName.Name = "chkBaseOnNewName";
            this.chkBaseOnNewName.Size = new System.Drawing.Size(120, 16);
            this.chkBaseOnNewName.TabIndex = 48;
            this.chkBaseOnNewName.Text = "Base on new name";
            this.chkBaseOnNewName.UseVisualStyleBackColor = true;
            // 
            // nudEndPosition
            // 
            this.nudEndPosition.Location = new System.Drawing.Point(189, 5);
            this.nudEndPosition.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudEndPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudEndPosition.Name = "nudEndPosition";
            this.nudEndPosition.Size = new System.Drawing.Size(56, 21);
            this.nudEndPosition.TabIndex = 49;
            this.nudEndPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 50;
            this.label7.Text = "to";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 12);
            this.label8.TabIndex = 51;
            this.label8.Text = "(the position started with 1, 0 or -1 stands for to the end)";
            // 
            // panelExtract
            // 
            this.panelExtract.Controls.Add(this.rbExtractByExpression);
            this.panelExtract.Controls.Add(this.rbExtractByPosition);
            this.panelExtract.Controls.Add(this.txtExractExpression);
            this.panelExtract.Controls.Add(this.nudEndPosition);
            this.panelExtract.Controls.Add(this.label8);
            this.panelExtract.Controls.Add(this.label7);
            this.panelExtract.Controls.Add(this.nudStartPosition);
            this.panelExtract.Enabled = false;
            this.panelExtract.Location = new System.Drawing.Point(3, 178);
            this.panelExtract.Name = "panelExtract";
            this.panelExtract.Size = new System.Drawing.Size(758, 61);
            this.panelExtract.TabIndex = 52;
            // 
            // rbExtractByExpression
            // 
            this.rbExtractByExpression.AutoSize = true;
            this.rbExtractByExpression.Location = new System.Drawing.Point(5, 35);
            this.rbExtractByExpression.Name = "rbExtractByExpression";
            this.rbExtractByExpression.Size = new System.Drawing.Size(107, 16);
            this.rbExtractByExpression.TabIndex = 55;
            this.rbExtractByExpression.Text = "By expression:";
            this.rbExtractByExpression.UseVisualStyleBackColor = true;
            // 
            // rbExtractByPosition
            // 
            this.rbExtractByPosition.AutoSize = true;
            this.rbExtractByPosition.Checked = true;
            this.rbExtractByPosition.Location = new System.Drawing.Point(5, 7);
            this.rbExtractByPosition.Name = "rbExtractByPosition";
            this.rbExtractByPosition.Size = new System.Drawing.Size(95, 16);
            this.rbExtractByPosition.TabIndex = 54;
            this.rbExtractByPosition.TabStop = true;
            this.rbExtractByPosition.Text = "By position:";
            this.rbExtractByPosition.UseVisualStyleBackColor = true;
            // 
            // txtExractExpression
            // 
            this.txtExractExpression.Location = new System.Drawing.Point(116, 34);
            this.txtExractExpression.Name = "txtExractExpression";
            this.txtExractExpression.Size = new System.Drawing.Size(129, 21);
            this.txtExractExpression.TabIndex = 53;
            // 
            // panelOldChar
            // 
            this.panelOldChar.Controls.Add(this.chkOldCharByExpression);
            this.panelOldChar.Controls.Add(this.txtOldChar);
            this.panelOldChar.Controls.Add(this.lblOldChar);
            this.panelOldChar.Location = new System.Drawing.Point(3, 107);
            this.panelOldChar.Name = "panelOldChar";
            this.panelOldChar.Size = new System.Drawing.Size(580, 29);
            this.panelOldChar.TabIndex = 53;
            // 
            // chkOldCharByExpression
            // 
            this.chkOldCharByExpression.AutoSize = true;
            this.chkOldCharByExpression.Location = new System.Drawing.Point(237, 6);
            this.chkOldCharByExpression.Name = "chkOldCharByExpression";
            this.chkOldCharByExpression.Size = new System.Drawing.Size(150, 16);
            this.chkOldCharByExpression.TabIndex = 37;
            this.chkOldCharByExpression.Text = "By regular expression";
            this.chkOldCharByExpression.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemove,
            this.openInExplorerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 48);
            // 
            // tsmiRemove
            // 
            this.tsmiRemove.Name = "tsmiRemove";
            this.tsmiRemove.Size = new System.Drawing.Size(175, 22);
            this.tsmiRemove.Text = "Remove selected";
            this.tsmiRemove.Click += new System.EventHandler(this.tsmiRemove_Click);
            // 
            // openInExplorerToolStripMenuItem
            // 
            this.openInExplorerToolStripMenuItem.Name = "openInExplorerToolStripMenuItem";
            this.openInExplorerToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.openInExplorerToolStripMenuItem.Text = "Open in explorer";
            this.openInExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInExplorerToolStripMenuItem_Click);
            // 
            // cboFilter
            // 
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.Location = new System.Drawing.Point(99, 48);
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(129, 20);
            this.cboFilter.TabIndex = 54;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 493);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.panelOldChar);
            this.Controls.Add(this.panelExtract);
            this.Controls.Add(this.chkBaseOnNewName);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.lblModeDescription);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.panelNewChar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cboHandleMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkIncludeChildFolder);
            this.Controls.Add(this.bntOpenFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File renamer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelNewChar.ResumeLayout(false);
            this.panelNewChar.PerformLayout();
            this.panelInsert.ResumeLayout(false);
            this.panelInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndPosition)).EndInit();
            this.panelExtract.ResumeLayout(false);
            this.panelExtract.PerformLayout();
            this.panelOldChar.ResumeLayout(false);
            this.panelOldChar.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntOpenFolder;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkIncludeChildFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboHandleMode;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelNewChar;
        private System.Windows.Forms.RadioButton rbNewCharInsertAfter;
        private System.Windows.Forms.RadioButton rbNewCharInsertBefore;
        private System.Windows.Forms.TextBox txtNewChar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOldChar;
        private System.Windows.Forms.Label lblOldChar;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblModeDescription;
        private System.Windows.Forms.NumericUpDown nudStartPosition;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader colOldName;
        private System.Windows.Forms.ColumnHeader colNewName;
        private System.Windows.Forms.CheckBox chkBaseOnNewName;
        private System.Windows.Forms.NumericUpDown nudEndPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelExtract;
        private System.Windows.Forms.Panel panelOldChar;
        private System.Windows.Forms.TextBox txtInsertAfter;
        private System.Windows.Forms.TextBox txtInsertBefore;
        private System.Windows.Forms.Panel panelInsert;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private System.Windows.Forms.ToolStripMenuItem openInExplorerToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkOldCharByExpression;
        private System.Windows.Forms.RadioButton rbExtractByExpression;
        private System.Windows.Forms.RadioButton rbExtractByPosition;
        private System.Windows.Forms.TextBox txtExractExpression;
        private System.Windows.Forms.ComboBox cboFilter;
    }
}

