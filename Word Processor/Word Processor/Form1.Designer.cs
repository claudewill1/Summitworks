namespace Word_Processor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuPageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindAndReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuInsertImage = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paragraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rtbDoc = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFivePts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTenPts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFifteenPts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTwentyPts = new System.Windows.Forms.ToolStripMenuItem();
            this.bulletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBullets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveBullets = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.paragraphToolStripMenuItem,
            this.bulletsToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.toolStripSeparator1,
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.toolStripSeparator2,
            this.mnuPageSetup,
            this.mnuPrintPreview,
            this.mnuPrint,
            this.toolStripSeparator3,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnuNew
            // 
            this.mnuNew.Image = ((System.Drawing.Image)(resources.GetObject("mnuNew.Image")));
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(224, 26);
            this.mnuNew.Text = "&New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpen.Image")));
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(224, 26);
            this.mnuOpen.Text = "&Open";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = ((System.Drawing.Image)(resources.GetObject("mnuSave.Image")));
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(224, 26);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(224, 26);
            this.mnuSaveAs.Text = "Save &As";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuPageSetup
            // 
            this.mnuPageSetup.Name = "mnuPageSetup";
            this.mnuPageSetup.Size = new System.Drawing.Size(224, 26);
            this.mnuPageSetup.Text = "Page Setup...";
            this.mnuPageSetup.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Name = "mnuPrintPreview";
            this.mnuPrintPreview.Size = new System.Drawing.Size(224, 26);
            this.mnuPrintPreview.Text = "Print Pre&view";
            this.mnuPrintPreview.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Image = ((System.Drawing.Image)(resources.GetObject("mnuPrint.Image")));
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(224, 26);
            this.mnuPrint.Text = "&Print...";
            this.mnuPrint.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(224, 26);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.mnuRedo,
            this.toolStripSeparator4,
            this.mnuFind,
            this.mnuFindAndReplace,
            this.toolStripSeparator5,
            this.mnuSelectAll,
            this.toolStripSeparator6,
            this.mnuCopy,
            this.mnuCut,
            this.mnuPast,
            this.toolStripSeparator7,
            this.mnuInsertImage});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // mnuUndo
            // 
            this.mnuUndo.Image = ((System.Drawing.Image)(resources.GetObject("mnuUndo.Image")));
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.Size = new System.Drawing.Size(224, 26);
            this.mnuUndo.Text = "&Undo";
            this.mnuUndo.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // mnuRedo
            // 
            this.mnuRedo.Image = ((System.Drawing.Image)(resources.GetObject("mnuRedo.Image")));
            this.mnuRedo.Name = "mnuRedo";
            this.mnuRedo.Size = new System.Drawing.Size(224, 26);
            this.mnuRedo.Text = "&Redo";
            this.mnuRedo.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuFind
            // 
            this.mnuFind.Image = ((System.Drawing.Image)(resources.GetObject("mnuFind.Image")));
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Size = new System.Drawing.Size(224, 26);
            this.mnuFind.Text = "Fi&nd...";
            this.mnuFind.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // mnuFindAndReplace
            // 
            this.mnuFindAndReplace.Name = "mnuFindAndReplace";
            this.mnuFindAndReplace.Size = new System.Drawing.Size(224, 26);
            this.mnuFindAndReplace.Text = "Find and &Replace...";
            this.mnuFindAndReplace.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Name = "mnuSelectAll";
            this.mnuSelectAll.Size = new System.Drawing.Size(224, 26);
            this.mnuSelectAll.Text = "Select &All";
            this.mnuSelectAll.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnuCopy.Image")));
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(224, 26);
            this.mnuCopy.Text = "&Copy";
            this.mnuCopy.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // mnuCut
            // 
            this.mnuCut.Image = ((System.Drawing.Image)(resources.GetObject("mnuCut.Image")));
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Size = new System.Drawing.Size(224, 26);
            this.mnuCut.Text = "C&ut";
            this.mnuCut.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // mnuPast
            // 
            this.mnuPast.Image = ((System.Drawing.Image)(resources.GetObject("mnuPast.Image")));
            this.mnuPast.Name = "mnuPast";
            this.mnuPast.Size = new System.Drawing.Size(224, 26);
            this.mnuPast.Text = "Pas&te";
            this.mnuPast.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuInsertImage
            // 
            this.mnuInsertImage.Name = "mnuInsertImage";
            this.mnuInsertImage.Size = new System.Drawing.Size(224, 26);
            this.mnuInsertImage.Text = "Insert Image...";
            this.mnuInsertImage.Click += new System.EventHandler(this.insertImageToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFontToolStripMenuItem,
            this.toolStripSeparator8,
            this.fontColorToolStripMenuItem,
            this.toolStripSeparator9,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.toolStripSeparator10,
            this.pageColorToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.fontToolStripMenuItem.Text = "F&ont";
            // 
            // selectFontToolStripMenuItem
            // 
            this.selectFontToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectFontToolStripMenuItem.Image")));
            this.selectFontToolStripMenuItem.Name = "selectFontToolStripMenuItem";
            this.selectFontToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.selectFontToolStripMenuItem.Text = "Se&lect Font";
            this.selectFontToolStripMenuItem.Click += new System.EventHandler(this.selectFontToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            this.fontColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fontColorToolStripMenuItem.Text = "Font &Color";
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("boldToolStripMenuItem.Image")));
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.boldToolStripMenuItem.Text = "&Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("italicToolStripMenuItem.Image")));
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.italicToolStripMenuItem.Text = "&Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.italicToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("underlineToolStripMenuItem.Image")));
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.underlineToolStripMenuItem.Text = "&Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.underlineToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.normalToolStripMenuItem.Text = "&Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // pageColorToolStripMenuItem
            // 
            this.pageColorToolStripMenuItem.Name = "pageColorToolStripMenuItem";
            this.pageColorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pageColorToolStripMenuItem.Text = "&Page Color";
            this.pageColorToolStripMenuItem.Click += new System.EventHandler(this.pageColorToolStripMenuItem_Click);
            // 
            // paragraphToolStripMenuItem
            // 
            this.paragraphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indentToolStripMenuItem,
            this.alignToolStripMenuItem});
            this.paragraphToolStripMenuItem.Name = "paragraphToolStripMenuItem";
            this.paragraphToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.paragraphToolStripMenuItem.Text = "P&aragraph";
            // 
            // indentToolStripMenuItem
            // 
            this.indentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNormal,
            this.mnuFivePts,
            this.mnuTenPts,
            this.mnuFifteenPts,
            this.mnuTwentyPts});
            this.indentToolStripMenuItem.Name = "indentToolStripMenuItem";
            this.indentToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.indentToolStripMenuItem.Text = "&Indent";
            // 
            // alignToolStripMenuItem
            // 
            this.alignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLeft,
            this.mnuCenter,
            this.mnuRight});
            this.alignToolStripMenuItem.Name = "alignToolStripMenuItem";
            this.alignToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.alignToolStripMenuItem.Text = "&Align";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // rtbDoc
            // 
            this.rtbDoc.Location = new System.Drawing.Point(0, 69);
            this.rtbDoc.Name = "rtbDoc";
            this.rtbDoc.Size = new System.Drawing.Size(800, 444);
            this.rtbDoc.TabIndex = 2;
            this.rtbDoc.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuLeft
            // 
            this.mnuLeft.Image = ((System.Drawing.Image)(resources.GetObject("mnuLeft.Image")));
            this.mnuLeft.Name = "mnuLeft";
            this.mnuLeft.Size = new System.Drawing.Size(224, 26);
            this.mnuLeft.Text = "Left";
            this.mnuLeft.Click += new System.EventHandler(this.mnuLeft_Click);
            // 
            // mnuCenter
            // 
            this.mnuCenter.Image = ((System.Drawing.Image)(resources.GetObject("mnuCenter.Image")));
            this.mnuCenter.Name = "mnuCenter";
            this.mnuCenter.Size = new System.Drawing.Size(224, 26);
            this.mnuCenter.Text = "Center";
            this.mnuCenter.Click += new System.EventHandler(this.mnuCenter_Click);
            // 
            // mnuRight
            // 
            this.mnuRight.Image = ((System.Drawing.Image)(resources.GetObject("mnuRight.Image")));
            this.mnuRight.Name = "mnuRight";
            this.mnuRight.Size = new System.Drawing.Size(224, 26);
            this.mnuRight.Text = "Right";
            this.mnuRight.Click += new System.EventHandler(this.mnuRight_Click);
            // 
            // mnuNormal
            // 
            this.mnuNormal.Name = "mnuNormal";
            this.mnuNormal.Size = new System.Drawing.Size(224, 26);
            this.mnuNormal.Text = "Normal";
            this.mnuNormal.Click += new System.EventHandler(this.mnuNormal_Click);
            // 
            // mnuFivePts
            // 
            this.mnuFivePts.Name = "mnuFivePts";
            this.mnuFivePts.Size = new System.Drawing.Size(224, 26);
            this.mnuFivePts.Text = "5 Pts";
            this.mnuFivePts.Click += new System.EventHandler(this.mnuFivePts_Click);
            // 
            // mnuTenPts
            // 
            this.mnuTenPts.Name = "mnuTenPts";
            this.mnuTenPts.Size = new System.Drawing.Size(224, 26);
            this.mnuTenPts.Text = "10 Pts";
            this.mnuTenPts.Click += new System.EventHandler(this.mnuTenPts_Click);
            // 
            // mnuFifteenPts
            // 
            this.mnuFifteenPts.Name = "mnuFifteenPts";
            this.mnuFifteenPts.Size = new System.Drawing.Size(224, 26);
            this.mnuFifteenPts.Text = "15 Pts";
            this.mnuFifteenPts.Click += new System.EventHandler(this.mnuFifteenPts_Click);
            // 
            // mnuTwentyPts
            // 
            this.mnuTwentyPts.Name = "mnuTwentyPts";
            this.mnuTwentyPts.Size = new System.Drawing.Size(224, 26);
            this.mnuTwentyPts.Text = "20 Pts";
            this.mnuTwentyPts.Click += new System.EventHandler(this.mnuTwentyPts_Click);
            // 
            // bulletsToolStripMenuItem
            // 
            this.bulletsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddBullets,
            this.mnuRemoveBullets});
            this.bulletsToolStripMenuItem.Name = "bulletsToolStripMenuItem";
            this.bulletsToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.bulletsToolStripMenuItem.Text = "&Bullets";
            // 
            // mnuAddBullets
            // 
            this.mnuAddBullets.Name = "mnuAddBullets";
            this.mnuAddBullets.Size = new System.Drawing.Size(224, 26);
            this.mnuAddBullets.Text = "A&dd Bullets";
            this.mnuAddBullets.Click += new System.EventHandler(this.mnuAddBullets_Click);
            // 
            // mnuRemoveBullets
            // 
            this.mnuRemoveBullets.Name = "mnuRemoveBullets";
            this.mnuRemoveBullets.Size = new System.Drawing.Size(224, 26);
            this.mnuRemoveBullets.Text = "&Remove Bullets";
            this.mnuRemoveBullets.Click += new System.EventHandler(this.mnuRemoveBullets_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(68, 518);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 22);
            this.txtFind.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.rtbDoc);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuPageSetup;
        private System.Windows.Forms.ToolStripMenuItem mnuPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripMenuItem mnuFindAndReplace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuPast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mnuInsertImage;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox rtbDoc;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paragraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem mnuNormal;
        private System.Windows.Forms.ToolStripMenuItem mnuFivePts;
        private System.Windows.Forms.ToolStripMenuItem mnuTenPts;
        private System.Windows.Forms.ToolStripMenuItem mnuFifteenPts;
        private System.Windows.Forms.ToolStripMenuItem mnuTwentyPts;
        private System.Windows.Forms.ToolStripMenuItem mnuLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuCenter;
        private System.Windows.Forms.ToolStripMenuItem mnuRight;
        private System.Windows.Forms.ToolStripMenuItem bulletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBullets;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveBullets;
        private System.Windows.Forms.TextBox txtFind;
    }
}

