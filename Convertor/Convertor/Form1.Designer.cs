namespace Convertor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addfolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAllFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPathOutput = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.bAddFiles = new System.Windows.Forms.Button();
            this.bAddFolder = new System.Windows.Forms.Button();
            this.bRemove = new System.Windows.Forms.Button();
            this.bRemoveAll = new System.Windows.Forms.Button();
            this.bConvert = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbFormatIn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lAddFiles = new System.Windows.Forms.Label();
            this.lAddFolder = new System.Windows.Forms.Label();
            this.lRemove = new System.Windows.Forms.Label();
            this.lRemoveAll = new System.Windows.Forms.Label();
            this.lConvert = new System.Windows.Forms.Label();
            this.lOpenDestFolder = new System.Windows.Forms.Label();
            this.lConvert2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.convertToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2074, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addfileToolStripMenuItem,
            this.addfolderToolStripMenuItem,
            this.removeFileToolStripMenuItem,
            this.removeAllToolStripMenuItem,
            this.exitStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.ToolTipText = "File";
            // 
            // addfileToolStripMenuItem
            // 
            this.addfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addfileToolStripMenuItem.Image")));
            this.addfileToolStripMenuItem.Name = "addfileToolStripMenuItem";
            this.addfileToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.addfileToolStripMenuItem.Text = "Add New File";
            this.addfileToolStripMenuItem.Click += new System.EventHandler(this.bAddFiles_Click);
            // 
            // addfolderToolStripMenuItem
            // 
            this.addfolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addfolderToolStripMenuItem.Image")));
            this.addfolderToolStripMenuItem.Name = "addfolderToolStripMenuItem";
            this.addfolderToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.addfolderToolStripMenuItem.Text = "Add New Folder";
            this.addfolderToolStripMenuItem.Click += new System.EventHandler(this.bAddFolder_Click);
            // 
            // removeFileToolStripMenuItem
            // 
            this.removeFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeFileToolStripMenuItem.Image")));
            this.removeFileToolStripMenuItem.Name = "removeFileToolStripMenuItem";
            this.removeFileToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.removeFileToolStripMenuItem.Text = "Remove File";
            this.removeFileToolStripMenuItem.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // removeAllToolStripMenuItem
            // 
            this.removeAllToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeAllToolStripMenuItem.Image")));
            this.removeAllToolStripMenuItem.Name = "removeAllToolStripMenuItem";
            this.removeAllToolStripMenuItem.Size = new System.Drawing.Size(286, 38);
            this.removeAllToolStripMenuItem.Text = "Remove All";
            this.removeAllToolStripMenuItem.Click += new System.EventHandler(this.bRemoveAll_Click);
            // 
            // exitStripMenuItem1
            // 
            this.exitStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitStripMenuItem1.Image")));
            this.exitStripMenuItem1.Name = "exitStripMenuItem1";
            this.exitStripMenuItem1.Size = new System.Drawing.Size(286, 38);
            this.exitStripMenuItem1.Text = "Exit";
            this.exitStripMenuItem1.Click += new System.EventHandler(this.exitStripMenuItem1_Click);
            // 
            // convertToolStripMenuItem
            // 
            this.convertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertFilesToolStripMenuItem});
            this.convertToolStripMenuItem.Name = "convertToolStripMenuItem";
            this.convertToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.convertToolStripMenuItem.Text = "Convert";
            this.convertToolStripMenuItem.ToolTipText = "Convert";
            // 
            // convertFilesToolStripMenuItem
            // 
            this.convertFilesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("convertFilesToolStripMenuItem.Image")));
            this.convertFilesToolStripMenuItem.Name = "convertFilesToolStripMenuItem";
            this.convertFilesToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.convertFilesToolStripMenuItem.Text = "Convert file(s)";
            this.convertFilesToolStripMenuItem.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.ToolTipText = "Help";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(28, 233);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(2015, 651);
            this.listView1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.listView1, "List with converter file(s)");
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File name";
            this.columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Format";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Containing Folder";
            this.columnHeader4.Width = 400;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem1,
            this.addFolderToolStripMenuItem1,
            this.removeFileToolStripMenuItem1,
            this.removeAllFilesToolStripMenuItem,
            this.convertStartToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(258, 184);
            // 
            // addFileToolStripMenuItem1
            // 
            this.addFileToolStripMenuItem1.Name = "addFileToolStripMenuItem1";
            this.addFileToolStripMenuItem1.Size = new System.Drawing.Size(257, 36);
            this.addFileToolStripMenuItem1.Text = "Add file";
            this.addFileToolStripMenuItem1.Click += new System.EventHandler(this.bAddFiles_Click);
            // 
            // addFolderToolStripMenuItem1
            // 
            this.addFolderToolStripMenuItem1.Name = "addFolderToolStripMenuItem1";
            this.addFolderToolStripMenuItem1.Size = new System.Drawing.Size(257, 36);
            this.addFolderToolStripMenuItem1.Text = "Add folder";
            this.addFolderToolStripMenuItem1.Click += new System.EventHandler(this.bAddFolder_Click);
            // 
            // removeFileToolStripMenuItem1
            // 
            this.removeFileToolStripMenuItem1.Name = "removeFileToolStripMenuItem1";
            this.removeFileToolStripMenuItem1.Size = new System.Drawing.Size(257, 36);
            this.removeFileToolStripMenuItem1.Text = "Remove file";
            this.removeFileToolStripMenuItem1.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // removeAllFilesToolStripMenuItem
            // 
            this.removeAllFilesToolStripMenuItem.Name = "removeAllFilesToolStripMenuItem";
            this.removeAllFilesToolStripMenuItem.Size = new System.Drawing.Size(257, 36);
            this.removeAllFilesToolStripMenuItem.Text = "Remove all files";
            this.removeAllFilesToolStripMenuItem.Click += new System.EventHandler(this.bRemoveAll_Click);
            // 
            // convertStartToolStripMenuItem
            // 
            this.convertStartToolStripMenuItem.Name = "convertStartToolStripMenuItem";
            this.convertStartToolStripMenuItem.Size = new System.Drawing.Size(257, 36);
            this.convertStartToolStripMenuItem.Text = "Convert start";
            this.convertStartToolStripMenuItem.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"MusicFiles(*.mp3; *.flac; *.wav; *.wma)|*.mp3;*.flac;*.wav;*.wma|All files(*.*)|" +
    "*.*\"";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 1055);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Output Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 934);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output Format";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPathOutput
            // 
            this.tbPathOutput.Location = new System.Drawing.Point(188, 1050);
            this.tbPathOutput.Multiline = true;
            this.tbPathOutput.Name = "tbPathOutput";
            this.tbPathOutput.Size = new System.Drawing.Size(902, 35);
            this.tbPathOutput.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tbPathOutput, "Destination folder path");
            // 
            // bBrowse
            // 
            this.bBrowse.Location = new System.Drawing.Point(1136, 1042);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(144, 50);
            this.bBrowse.TabIndex = 6;
            this.bBrowse.Text = "Browse";
            this.toolTip1.SetToolTip(this.bBrowse, "Chose destination folder");
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // cbFormat
            // 
            this.cbFormat.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(798, 926);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(157, 33);
            this.cbFormat.Sorted = true;
            this.cbFormat.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cbFormat, "Chose output format");
            this.cbFormat.SelectedIndexChanged += new System.EventHandler(this.cbFormat_SelectedIndexChanged);
            // 
            // bAddFiles
            // 
            this.bAddFiles.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bAddFiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAddFiles.BackgroundImage")));
            this.bAddFiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bAddFiles.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAddFiles.Location = new System.Drawing.Point(28, 85);
            this.bAddFiles.Name = "bAddFiles";
            this.bAddFiles.Size = new System.Drawing.Size(145, 135);
            this.bAddFiles.TabIndex = 0;
            this.bAddFiles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.bAddFiles, "Add File(s)");
            this.bAddFiles.UseVisualStyleBackColor = false;
            this.bAddFiles.Click += new System.EventHandler(this.bAddFiles_Click);
            // 
            // bAddFolder
            // 
            this.bAddFolder.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bAddFolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bAddFolder.BackgroundImage")));
            this.bAddFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bAddFolder.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAddFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAddFolder.Location = new System.Drawing.Point(188, 85);
            this.bAddFolder.Name = "bAddFolder";
            this.bAddFolder.Size = new System.Drawing.Size(145, 135);
            this.bAddFolder.TabIndex = 1;
            this.bAddFolder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bAddFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.bAddFolder, "Add Folder");
            this.bAddFolder.UseVisualStyleBackColor = false;
            this.bAddFolder.Click += new System.EventHandler(this.bAddFolder_Click);
            // 
            // bRemove
            // 
            this.bRemove.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bRemove.BackgroundImage")));
            this.bRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bRemove.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRemove.Location = new System.Drawing.Point(348, 85);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(145, 135);
            this.bRemove.TabIndex = 2;
            this.bRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.bRemove, "Remove Element(s)");
            this.bRemove.UseVisualStyleBackColor = false;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bRemoveAll
            // 
            this.bRemoveAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bRemoveAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bRemoveAll.BackgroundImage")));
            this.bRemoveAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bRemoveAll.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bRemoveAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRemoveAll.Location = new System.Drawing.Point(508, 85);
            this.bRemoveAll.Name = "bRemoveAll";
            this.bRemoveAll.Size = new System.Drawing.Size(145, 135);
            this.bRemoveAll.TabIndex = 3;
            this.bRemoveAll.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bRemoveAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.bRemoveAll, "Remove All");
            this.bRemoveAll.UseVisualStyleBackColor = false;
            this.bRemoveAll.Click += new System.EventHandler(this.bRemoveAll_Click);
            // 
            // bConvert
            // 
            this.bConvert.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bConvert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bConvert.BackgroundImage")));
            this.bConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bConvert.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConvert.Location = new System.Drawing.Point(668, 85);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(145, 135);
            this.bConvert.TabIndex = 4;
            this.bConvert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bConvert.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.bConvert, "Convert");
            this.bConvert.UseVisualStyleBackColor = false;
            this.bConvert.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Window;
            this.progressBar1.Location = new System.Drawing.Point(1337, 897);
            this.progressBar1.MaximumSize = new System.Drawing.Size(700, 50);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(700, 50);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.progressBar1, "Show progress of converting");
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1337, 995);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 135);
            this.button1.TabIndex = 9;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.button1, "Open destination folder");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1530, 994);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 135);
            this.button2.TabIndex = 10;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.button2, "Convert");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // cbFormatIn
            // 
            this.cbFormatIn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbFormatIn.FormattingEnabled = true;
            this.cbFormatIn.Location = new System.Drawing.Point(336, 926);
            this.cbFormatIn.Name = "cbFormatIn";
            this.cbFormatIn.Size = new System.Drawing.Size(157, 33);
            this.cbFormatIn.Sorted = true;
            this.cbFormatIn.TabIndex = 12;
            this.toolTip1.SetToolTip(this.cbFormatIn, "Chose input format");
            this.cbFormatIn.SelectedIndexChanged += new System.EventHandler(this.cbFormatIn_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 934);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Input Format";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 0;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "Convertor";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Convertor";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(149, 112);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(148, 36);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(148, 36);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 36);
            this.toolStripMenuItem1.Text = "Hide";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(268, 38);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lAddFiles
            // 
            this.lAddFiles.AutoSize = true;
            this.lAddFiles.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAddFiles.Location = new System.Drawing.Point(38, 48);
            this.lAddFiles.Name = "lAddFiles";
            this.lAddFiles.Size = new System.Drawing.Size(129, 32);
            this.lAddFiles.TabIndex = 13;
            this.lAddFiles.Text = "Add File(s)";
            // 
            // lAddFolder
            // 
            this.lAddFolder.AutoSize = true;
            this.lAddFolder.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lAddFolder.Location = new System.Drawing.Point(201, 48);
            this.lAddFolder.Name = "lAddFolder";
            this.lAddFolder.Size = new System.Drawing.Size(134, 32);
            this.lAddFolder.TabIndex = 14;
            this.lAddFolder.Text = "Add Folder";
            // 
            // lRemove
            // 
            this.lRemove.AutoSize = true;
            this.lRemove.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRemove.Location = new System.Drawing.Point(374, 48);
            this.lRemove.Name = "lRemove";
            this.lRemove.Size = new System.Drawing.Size(103, 32);
            this.lRemove.TabIndex = 15;
            this.lRemove.Text = "Remove";
            // 
            // lRemoveAll
            // 
            this.lRemoveAll.AutoSize = true;
            this.lRemoveAll.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lRemoveAll.Location = new System.Drawing.Point(515, 48);
            this.lRemoveAll.Name = "lRemoveAll";
            this.lRemoveAll.Size = new System.Drawing.Size(138, 32);
            this.lRemoveAll.TabIndex = 16;
            this.lRemoveAll.Text = "Remove All";
            // 
            // lConvert
            // 
            this.lConvert.AutoSize = true;
            this.lConvert.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lConvert.Location = new System.Drawing.Point(687, 48);
            this.lConvert.Name = "lConvert";
            this.lConvert.Size = new System.Drawing.Size(101, 32);
            this.lConvert.TabIndex = 17;
            this.lConvert.Text = "Convert";
            // 
            // lOpenDestFolder
            // 
            this.lOpenDestFolder.AutoSize = true;
            this.lOpenDestFolder.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lOpenDestFolder.Location = new System.Drawing.Point(1305, 960);
            this.lOpenDestFolder.Name = "lOpenDestFolder";
            this.lOpenDestFolder.Size = new System.Drawing.Size(211, 32);
            this.lOpenDestFolder.TabIndex = 18;
            this.lOpenDestFolder.Text = "Destination folder";
            // 
            // lConvert2
            // 
            this.lConvert2.AutoSize = true;
            this.lConvert2.Font = new System.Drawing.Font("Microsoft MHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lConvert2.Location = new System.Drawing.Point(1549, 960);
            this.lConvert2.Name = "lConvert2";
            this.lConvert2.Size = new System.Drawing.Size(101, 32);
            this.lConvert2.TabIndex = 19;
            this.lConvert2.Text = "Convert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(2074, 1129);
            this.Controls.Add(this.lConvert2);
            this.Controls.Add(this.lOpenDestFolder);
            this.Controls.Add(this.lConvert);
            this.Controls.Add(this.lRemoveAll);
            this.Controls.Add(this.lRemove);
            this.Controls.Add(this.lAddFolder);
            this.Controls.Add(this.lAddFiles);
            this.Controls.Add(this.cbFormatIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bConvert);
            this.Controls.Add(this.cbFormat);
            this.Controls.Add(this.bRemoveAll);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.bAddFolder);
            this.Controls.Add(this.tbPathOutput);
            this.Controls.Add(this.bAddFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(2100, 1200);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addfolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem removeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPathOutput;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Button bAddFiles;
        private System.Windows.Forms.Button bAddFolder;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bRemoveAll;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem convertFilesToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addFolderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeAllFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertStartToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbFormatIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lAddFiles;
        private System.Windows.Forms.Label lAddFolder;
        private System.Windows.Forms.Label lRemove;
        private System.Windows.Forms.Label lRemoveAll;
        private System.Windows.Forms.Label lConvert;
        private System.Windows.Forms.Label lOpenDestFolder;
        private System.Windows.Forms.Label lConvert2;
    }
}

