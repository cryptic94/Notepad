namespace PE_MonteroAMB_Notepad
{
	partial class Notepad
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notepad));
			this.tabMenu = new System.Windows.Forms.TabControl();
			this.tabFile = new System.Windows.Forms.TabPage();
			this.imlBigIcons = new System.Windows.Forms.ImageList(this.components);
			this.gbPrint = new System.Windows.Forms.GroupBox();
			this.imlIcons = new System.Windows.Forms.ImageList(this.components);
			this.gbDocument = new System.Windows.Forms.GroupBox();
			this.tabHome = new System.Windows.Forms.TabPage();
			this.gbFont = new System.Windows.Forms.GroupBox();
			this.tabEdit = new System.Windows.Forms.TabPage();
			this.gbSearch = new System.Windows.Forms.GroupBox();
			this.gbClipboard = new System.Windows.Forms.GroupBox();
			this.tabView = new System.Windows.Forms.TabPage();
			this.statusText = new System.Windows.Forms.StatusStrip();
			this.tslCharacter = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslWord = new System.Windows.Forms.ToolStripStatusLabel();
			this.tslLines = new System.Windows.Forms.ToolStripStatusLabel();
			this.rtbInput = new System.Windows.Forms.RichTextBox();
			this.sfdText = new System.Windows.Forms.SaveFileDialog();
			this.ofdNote = new System.Windows.Forms.OpenFileDialog();
			this.pdNote = new System.Windows.Forms.PrintDialog();
			this.psdText = new System.Windows.Forms.PageSetupDialog();
			this.gbParagraph = new System.Windows.Forms.GroupBox();
			this.fontDialogNote = new System.Windows.Forms.FontDialog();
			this.colorDialogNote = new System.Windows.Forms.ColorDialog();
			this.gbShowHide = new System.Windows.Forms.GroupBox();
			this.ttpEffects = new System.Windows.Forms.ToolTip(this.components);
			this.ttpAlign = new System.Windows.Forms.ToolTip(this.components);
			this.ttpBullet = new System.Windows.Forms.ToolTip(this.components);
			this.ttpIndent = new System.Windows.Forms.ToolTip(this.components);
			this.ttpDocument = new System.Windows.Forms.ToolTip(this.components);
			this.ttpPrint = new System.Windows.Forms.ToolTip(this.components);
			this.ttpInstruct = new System.Windows.Forms.ToolTip(this.components);
			this.ttpEdit = new System.Windows.Forms.ToolTip(this.components);
			this.btExit = new System.Windows.Forms.Button();
			this.btPrint = new System.Windows.Forms.Button();
			this.btPage = new System.Windows.Forms.Button();
			this.btSaveAs = new System.Windows.Forms.Button();
			this.btSave = new System.Windows.Forms.Button();
			this.btOpen = new System.Windows.Forms.Button();
			this.btNew = new System.Windows.Forms.Button();
			this.btRight = new System.Windows.Forms.Button();
			this.btCenter = new System.Windows.Forms.Button();
			this.btLeft = new System.Windows.Forms.Button();
			this.btDecIndent = new System.Windows.Forms.Button();
			this.btIncIndent = new System.Windows.Forms.Button();
			this.btList = new System.Windows.Forms.Button();
			this.btSubscript = new System.Windows.Forms.Button();
			this.btSuperscript = new System.Windows.Forms.Button();
			this.btUnderline = new System.Windows.Forms.Button();
			this.btStrike = new System.Windows.Forms.Button();
			this.btItalic = new System.Windows.Forms.Button();
			this.btBold = new System.Windows.Forms.Button();
			this.btColor = new System.Windows.Forms.Button();
			this.btFont = new System.Windows.Forms.Button();
			this.btRedo = new System.Windows.Forms.Button();
			this.btUndo = new System.Windows.Forms.Button();
			this.btSelect = new System.Windows.Forms.Button();
			this.btReplace = new System.Windows.Forms.Button();
			this.btGoTo = new System.Windows.Forms.Button();
			this.btFind = new System.Windows.Forms.Button();
			this.btPaste = new System.Windows.Forms.Button();
			this.btCopy = new System.Windows.Forms.Button();
			this.btCut = new System.Windows.Forms.Button();
			this.btDateTime = new System.Windows.Forms.Button();
			this.btStatusBar = new System.Windows.Forms.Button();
			this.btWrap = new System.Windows.Forms.Button();
			this.tabHelp = new System.Windows.Forms.TabPage();
			this.btAbout = new System.Windows.Forms.Button();
			this.tabMenu.SuspendLayout();
			this.tabFile.SuspendLayout();
			this.gbPrint.SuspendLayout();
			this.gbDocument.SuspendLayout();
			this.tabHome.SuspendLayout();
			this.gbFont.SuspendLayout();
			this.tabEdit.SuspendLayout();
			this.gbSearch.SuspendLayout();
			this.gbClipboard.SuspendLayout();
			this.tabView.SuspendLayout();
			this.statusText.SuspendLayout();
			this.gbParagraph.SuspendLayout();
			this.gbShowHide.SuspendLayout();
			this.tabHelp.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabMenu
			// 
			this.tabMenu.Controls.Add(this.tabFile);
			this.tabMenu.Controls.Add(this.tabHome);
			this.tabMenu.Controls.Add(this.tabEdit);
			this.tabMenu.Controls.Add(this.tabView);
			this.tabMenu.Controls.Add(this.tabHelp);
			this.tabMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.tabMenu.ItemSize = new System.Drawing.Size(66, 23);
			this.tabMenu.Location = new System.Drawing.Point(0, 0);
			this.tabMenu.Margin = new System.Windows.Forms.Padding(0);
			this.tabMenu.Multiline = true;
			this.tabMenu.Name = "tabMenu";
			this.tabMenu.SelectedIndex = 0;
			this.tabMenu.Size = new System.Drawing.Size(828, 190);
			this.tabMenu.TabIndex = 0;
			// 
			// tabFile
			// 
			this.tabFile.Controls.Add(this.btExit);
			this.tabFile.Controls.Add(this.gbPrint);
			this.tabFile.Controls.Add(this.gbDocument);
			this.tabFile.Location = new System.Drawing.Point(4, 27);
			this.tabFile.Name = "tabFile";
			this.tabFile.Padding = new System.Windows.Forms.Padding(3);
			this.tabFile.Size = new System.Drawing.Size(820, 159);
			this.tabFile.TabIndex = 4;
			this.tabFile.Text = "File";
			this.tabFile.ToolTipText = "File Settings";
			this.tabFile.UseVisualStyleBackColor = true;
			// 
			// imlBigIcons
			// 
			this.imlBigIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBigIcons.ImageStream")));
			this.imlBigIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.imlBigIcons.Images.SetKeyName(0, "delete-1-icon.png");
			this.imlBigIcons.Images.SetKeyName(1, "clock-icon-png-10763.png");
			this.imlBigIcons.Images.SetKeyName(2, "orange-question-mark-png-image-55605.png");
			// 
			// gbPrint
			// 
			this.gbPrint.Controls.Add(this.btPrint);
			this.gbPrint.Controls.Add(this.btPage);
			this.gbPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.gbPrint.Location = new System.Drawing.Point(301, 0);
			this.gbPrint.Name = "gbPrint";
			this.gbPrint.Size = new System.Drawing.Size(200, 153);
			this.gbPrint.TabIndex = 1;
			this.gbPrint.TabStop = false;
			this.gbPrint.Text = "Print";
			// 
			// imlIcons
			// 
			this.imlIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlIcons.ImageStream")));
			this.imlIcons.TransparentColor = System.Drawing.Color.Transparent;
			this.imlIcons.Images.SetKeyName(0, "Glossary-icon.png");
			this.imlIcons.Images.SetKeyName(1, "New-file-icon.png");
			this.imlIcons.Images.SetKeyName(2, "Open-file-icon.png");
			this.imlIcons.Images.SetKeyName(3, "Printer-blue-icon.png");
			this.imlIcons.Images.SetKeyName(4, "Save-icon.png");
			this.imlIcons.Images.SetKeyName(5, "Save-as-icon.png");
			this.imlIcons.Images.SetKeyName(6, "Continue-icon.png");
			this.imlIcons.Images.SetKeyName(7, "copy-icon.png");
			this.imlIcons.Images.SetKeyName(8, "cut-icon.png");
			this.imlIcons.Images.SetKeyName(9, "Paste-icon.png");
			this.imlIcons.Images.SetKeyName(10, "search-icon.png");
			this.imlIcons.Images.SetKeyName(11, "Actions-select-all-icon.png");
			this.imlIcons.Images.SetKeyName(12, "Actions-blue-arrow-redo-icon.png");
			this.imlIcons.Images.SetKeyName(13, "Go-back-icon.png");
			this.imlIcons.Images.SetKeyName(14, "text.png");
			this.imlIcons.Images.SetKeyName(15, "Theme-icon.png");
			this.imlIcons.Images.SetKeyName(16, "find-and-replace.png");
			this.imlIcons.Images.SetKeyName(17, "User-Interface-Checked-Checkbox-icon.png");
			this.imlIcons.Images.SetKeyName(18, "User-Interface-Unchecked-Checkbox-icon.png");
			// 
			// gbDocument
			// 
			this.gbDocument.Controls.Add(this.btSaveAs);
			this.gbDocument.Controls.Add(this.btSave);
			this.gbDocument.Controls.Add(this.btOpen);
			this.gbDocument.Controls.Add(this.btNew);
			this.gbDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.gbDocument.Location = new System.Drawing.Point(3, 0);
			this.gbDocument.Name = "gbDocument";
			this.gbDocument.Size = new System.Drawing.Size(294, 153);
			this.gbDocument.TabIndex = 0;
			this.gbDocument.TabStop = false;
			this.gbDocument.Text = "Document";
			// 
			// tabHome
			// 
			this.tabHome.BackColor = System.Drawing.Color.White;
			this.tabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tabHome.Controls.Add(this.gbParagraph);
			this.tabHome.Controls.Add(this.gbFont);
			this.tabHome.Location = new System.Drawing.Point(4, 27);
			this.tabHome.Margin = new System.Windows.Forms.Padding(0);
			this.tabHome.Name = "tabHome";
			this.tabHome.Size = new System.Drawing.Size(820, 159);
			this.tabHome.TabIndex = 1;
			this.tabHome.Text = "Home";
			this.tabHome.ToolTipText = "Format Settings";
			// 
			// gbFont
			// 
			this.gbFont.Controls.Add(this.btSubscript);
			this.gbFont.Controls.Add(this.btSuperscript);
			this.gbFont.Controls.Add(this.btUnderline);
			this.gbFont.Controls.Add(this.btStrike);
			this.gbFont.Controls.Add(this.btItalic);
			this.gbFont.Controls.Add(this.btBold);
			this.gbFont.Controls.Add(this.btColor);
			this.gbFont.Controls.Add(this.btFont);
			this.gbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.gbFont.Location = new System.Drawing.Point(3, 0);
			this.gbFont.Name = "gbFont";
			this.gbFont.Size = new System.Drawing.Size(341, 153);
			this.gbFont.TabIndex = 3;
			this.gbFont.TabStop = false;
			this.gbFont.Text = "Font";
			// 
			// tabEdit
			// 
			this.tabEdit.Controls.Add(this.btRedo);
			this.tabEdit.Controls.Add(this.btUndo);
			this.tabEdit.Controls.Add(this.gbSearch);
			this.tabEdit.Controls.Add(this.gbClipboard);
			this.tabEdit.Location = new System.Drawing.Point(4, 27);
			this.tabEdit.Name = "tabEdit";
			this.tabEdit.Padding = new System.Windows.Forms.Padding(3);
			this.tabEdit.Size = new System.Drawing.Size(820, 159);
			this.tabEdit.TabIndex = 5;
			this.tabEdit.Text = "Edit";
			this.tabEdit.ToolTipText = "Text Settings";
			this.tabEdit.UseVisualStyleBackColor = true;
			// 
			// gbSearch
			// 
			this.gbSearch.Controls.Add(this.btSelect);
			this.gbSearch.Controls.Add(this.btReplace);
			this.gbSearch.Controls.Add(this.btGoTo);
			this.gbSearch.Controls.Add(this.btFind);
			this.gbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.gbSearch.Location = new System.Drawing.Point(270, 0);
			this.gbSearch.Name = "gbSearch";
			this.gbSearch.Size = new System.Drawing.Size(331, 153);
			this.gbSearch.TabIndex = 2;
			this.gbSearch.TabStop = false;
			this.gbSearch.Text = "Text Settings";
			// 
			// gbClipboard
			// 
			this.gbClipboard.Controls.Add(this.btPaste);
			this.gbClipboard.Controls.Add(this.btCopy);
			this.gbClipboard.Controls.Add(this.btCut);
			this.gbClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.gbClipboard.Location = new System.Drawing.Point(3, 0);
			this.gbClipboard.Name = "gbClipboard";
			this.gbClipboard.Size = new System.Drawing.Size(263, 153);
			this.gbClipboard.TabIndex = 1;
			this.gbClipboard.TabStop = false;
			this.gbClipboard.Text = "Clipboard";
			// 
			// tabView
			// 
			this.tabView.Controls.Add(this.btDateTime);
			this.tabView.Controls.Add(this.gbShowHide);
			this.tabView.Location = new System.Drawing.Point(4, 27);
			this.tabView.Name = "tabView";
			this.tabView.Padding = new System.Windows.Forms.Padding(3);
			this.tabView.Size = new System.Drawing.Size(820, 159);
			this.tabView.TabIndex = 3;
			this.tabView.Text = "View";
			this.tabView.ToolTipText = "Environment Settings";
			this.tabView.UseVisualStyleBackColor = true;
			// 
			// statusText
			// 
			this.statusText.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.statusText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCharacter,
            this.tslWord,
            this.tslLines});
			this.statusText.Location = new System.Drawing.Point(0, 610);
			this.statusText.Name = "statusText";
			this.statusText.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.statusText.Size = new System.Drawing.Size(828, 34);
			this.statusText.SizingGrip = false;
			this.statusText.TabIndex = 0;
			// 
			// tslCharacter
			// 
			this.tslCharacter.BackColor = System.Drawing.Color.Transparent;
			this.tslCharacter.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tslCharacter.Name = "tslCharacter";
			this.tslCharacter.Size = new System.Drawing.Size(113, 29);
			this.tslCharacter.Text = "Characters: 0";
			// 
			// tslWord
			// 
			this.tslWord.BackColor = System.Drawing.Color.Transparent;
			this.tslWord.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.tslWord.Name = "tslWord";
			this.tslWord.Size = new System.Drawing.Size(88, 29);
			this.tslWord.Text = "Words: 0";
			// 
			// tslLines
			// 
			this.tslLines.BackColor = System.Drawing.Color.Transparent;
			this.tslLines.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.tslLines.Name = "tslLines";
			this.tslLines.Size = new System.Drawing.Size(74, 29);
			this.tslLines.Text = "Lines: 0";
			// 
			// rtbInput
			// 
			this.rtbInput.AcceptsTab = true;
			this.rtbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.rtbInput.HideSelection = false;
			this.rtbInput.Location = new System.Drawing.Point(4, 195);
			this.rtbInput.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
			this.rtbInput.Name = "rtbInput";
			this.rtbInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.rtbInput.Size = new System.Drawing.Size(819, 408);
			this.rtbInput.TabIndex = 1;
			this.rtbInput.Text = "";
			this.rtbInput.TextChanged += new System.EventHandler(this.rtbInput_TextChanged);
			this.rtbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbInput_KeyDown);
			// 
			// sfdText
			// 
			this.sfdText.AutoUpgradeEnabled = false;
			this.sfdText.DefaultExt = "txt";
			this.sfdText.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*rtf)|*.rtf|Word Document (*.doc)|*.do" +
    "c|All Files (*.*)|*.*";
			this.sfdText.InitialDirectory = "C:\\\\";
			this.sfdText.Title = "Save File";
			// 
			// ofdNote
			// 
			this.ofdNote.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*rtf)|*.rtf|Word Document (*.doc)|*.do" +
    "c|All Files (*.*)|*.*";
			this.ofdNote.InitialDirectory = "C:\\\\";
			this.ofdNote.Title = "Open File";
			// 
			// pdNote
			// 
			this.pdNote.AllowSelection = true;
			this.pdNote.AllowSomePages = true;
			this.pdNote.UseEXDialog = true;
			// 
			// gbParagraph
			// 
			this.gbParagraph.Controls.Add(this.btRight);
			this.gbParagraph.Controls.Add(this.btCenter);
			this.gbParagraph.Controls.Add(this.btLeft);
			this.gbParagraph.Controls.Add(this.btDecIndent);
			this.gbParagraph.Controls.Add(this.btIncIndent);
			this.gbParagraph.Controls.Add(this.btList);
			this.gbParagraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.gbParagraph.Location = new System.Drawing.Point(348, 0);
			this.gbParagraph.Name = "gbParagraph";
			this.gbParagraph.Size = new System.Drawing.Size(170, 153);
			this.gbParagraph.TabIndex = 4;
			this.gbParagraph.TabStop = false;
			this.gbParagraph.Text = "Paragraph";
			// 
			// fontDialogNote
			// 
			this.fontDialogNote.FontMustExist = true;
			this.fontDialogNote.MinSize = 1;
			this.fontDialogNote.ShowEffects = false;
			// 
			// colorDialogNote
			// 
			this.colorDialogNote.AnyColor = true;
			// 
			// gbShowHide
			// 
			this.gbShowHide.Controls.Add(this.btStatusBar);
			this.gbShowHide.Controls.Add(this.btWrap);
			this.gbShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.gbShowHide.Location = new System.Drawing.Point(3, 0);
			this.gbShowHide.Name = "gbShowHide";
			this.gbShowHide.Size = new System.Drawing.Size(197, 153);
			this.gbShowHide.TabIndex = 2;
			this.gbShowHide.TabStop = false;
			this.gbShowHide.Text = "Show/Hide";
			// 
			// ttpEffects
			// 
			this.ttpEffects.AutomaticDelay = 800;
			this.ttpEffects.AutoPopDelay = 7000;
			this.ttpEffects.InitialDelay = 800;
			this.ttpEffects.ReshowDelay = 160;
			this.ttpEffects.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttpEffects.ToolTipTitle = "Effects";
			// 
			// ttpAlign
			// 
			this.ttpAlign.AutomaticDelay = 800;
			this.ttpAlign.AutoPopDelay = 7000;
			this.ttpAlign.InitialDelay = 800;
			this.ttpAlign.ReshowDelay = 160;
			this.ttpAlign.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttpAlign.ToolTipTitle = "Alignment";
			// 
			// ttpBullet
			// 
			this.ttpBullet.AutomaticDelay = 800;
			this.ttpBullet.AutoPopDelay = 7000;
			this.ttpBullet.InitialDelay = 800;
			this.ttpBullet.ReshowDelay = 160;
			this.ttpBullet.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttpBullet.ToolTipTitle = "Bullet List";
			// 
			// ttpIndent
			// 
			this.ttpIndent.AutomaticDelay = 800;
			this.ttpIndent.AutoPopDelay = 7000;
			this.ttpIndent.InitialDelay = 800;
			this.ttpIndent.ReshowDelay = 160;
			this.ttpIndent.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttpIndent.ToolTipTitle = "Text Indent";
			// 
			// ttpDocument
			// 
			this.ttpDocument.AutomaticDelay = 800;
			this.ttpDocument.AutoPopDelay = 7000;
			this.ttpDocument.InitialDelay = 800;
			this.ttpDocument.ReshowDelay = 160;
			this.ttpDocument.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttpDocument.ToolTipTitle = "Document";
			// 
			// ttpPrint
			// 
			this.ttpPrint.AutomaticDelay = 800;
			this.ttpPrint.AutoPopDelay = 7000;
			this.ttpPrint.InitialDelay = 800;
			this.ttpPrint.ReshowDelay = 160;
			this.ttpPrint.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttpPrint.ToolTipTitle = "Print";
			// 
			// ttpInstruct
			// 
			this.ttpInstruct.AutomaticDelay = 800;
			this.ttpInstruct.AutoPopDelay = 7000;
			this.ttpInstruct.InitialDelay = 800;
			this.ttpInstruct.ReshowDelay = 160;
			this.ttpInstruct.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttpInstruct.ToolTipTitle = "Instruction";
			// 
			// ttpEdit
			// 
			this.ttpEdit.AutomaticDelay = 800;
			this.ttpEdit.AutoPopDelay = 7000;
			this.ttpEdit.InitialDelay = 800;
			this.ttpEdit.ReshowDelay = 160;
			this.ttpEdit.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ttpEdit.ToolTipTitle = "Edit";
			// 
			// btExit
			// 
			this.btExit.AutoSize = true;
			this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btExit.FlatAppearance.BorderSize = 0;
			this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btExit.ImageKey = "delete-1-icon.png";
			this.btExit.ImageList = this.imlBigIcons;
			this.btExit.Location = new System.Drawing.Point(521, 30);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(149, 90);
			this.btExit.TabIndex = 3;
			this.btExit.Text = "   Exit";
			this.btExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpInstruct.SetToolTip(this.btExit, "\r\nCloses the program.");
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// btPrint
			// 
			this.btPrint.AutoSize = true;
			this.btPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btPrint.FlatAppearance.BorderSize = 0;
			this.btPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btPrint.ImageIndex = 3;
			this.btPrint.ImageList = this.imlIcons;
			this.btPrint.Location = new System.Drawing.Point(8, 85);
			this.btPrint.Name = "btPrint";
			this.btPrint.Size = new System.Drawing.Size(119, 55);
			this.btPrint.TabIndex = 2;
			this.btPrint.Text = "Print";
			this.btPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpPrint.SetToolTip(this.btPrint, "\r\nOpens the print dialog.");
			this.btPrint.UseVisualStyleBackColor = true;
			this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
			// 
			// btPage
			// 
			this.btPage.AutoSize = true;
			this.btPage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btPage.FlatAppearance.BorderSize = 0;
			this.btPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btPage.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btPage.ImageIndex = 0;
			this.btPage.ImageList = this.imlIcons;
			this.btPage.Location = new System.Drawing.Point(8, 24);
			this.btPage.Name = "btPage";
			this.btPage.Size = new System.Drawing.Size(150, 55);
			this.btPage.TabIndex = 0;
			this.btPage.Text = "Page Setup";
			this.btPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpPrint.SetToolTip(this.btPage, "\r\nOpens the page setup dialog.");
			this.btPage.UseVisualStyleBackColor = true;
			this.btPage.Click += new System.EventHandler(this.btPage_Click);
			// 
			// btSaveAs
			// 
			this.btSaveAs.AutoSize = true;
			this.btSaveAs.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSaveAs.FlatAppearance.BorderSize = 0;
			this.btSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSaveAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btSaveAs.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btSaveAs.ImageIndex = 5;
			this.btSaveAs.ImageList = this.imlIcons;
			this.btSaveAs.Location = new System.Drawing.Point(136, 85);
			this.btSaveAs.Name = "btSaveAs";
			this.btSaveAs.Size = new System.Drawing.Size(143, 55);
			this.btSaveAs.TabIndex = 4;
			this.btSaveAs.Text = "Save As";
			this.btSaveAs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpDocument.SetToolTip(this.btSaveAs, "\r\nSaves file as a new file.");
			this.btSaveAs.UseVisualStyleBackColor = true;
			this.btSaveAs.Click += new System.EventHandler(this.btSaveAs_Click);
			// 
			// btSave
			// 
			this.btSave.AutoSize = true;
			this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSave.FlatAppearance.BorderSize = 0;
			this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btSave.ImageIndex = 4;
			this.btSave.ImageList = this.imlIcons;
			this.btSave.Location = new System.Drawing.Point(136, 24);
			this.btSave.Name = "btSave";
			this.btSave.Size = new System.Drawing.Size(120, 55);
			this.btSave.TabIndex = 3;
			this.btSave.Text = "Save";
			this.btSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpDocument.SetToolTip(this.btSave, "\r\nSaves current file.");
			this.btSave.UseVisualStyleBackColor = true;
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btOpen
			// 
			this.btOpen.AutoSize = true;
			this.btOpen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btOpen.FlatAppearance.BorderSize = 0;
			this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btOpen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btOpen.ImageIndex = 2;
			this.btOpen.ImageList = this.imlIcons;
			this.btOpen.Location = new System.Drawing.Point(8, 85);
			this.btOpen.Name = "btOpen";
			this.btOpen.Size = new System.Drawing.Size(99, 55);
			this.btOpen.TabIndex = 2;
			this.btOpen.Text = "Open";
			this.btOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpDocument.SetToolTip(this.btOpen, "\r\nOpens an existing file.");
			this.btOpen.UseVisualStyleBackColor = true;
			this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
			// 
			// btNew
			// 
			this.btNew.AutoSize = true;
			this.btNew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btNew.FlatAppearance.BorderSize = 0;
			this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btNew.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btNew.ImageIndex = 1;
			this.btNew.ImageList = this.imlIcons;
			this.btNew.Location = new System.Drawing.Point(8, 24);
			this.btNew.Name = "btNew";
			this.btNew.Size = new System.Drawing.Size(99, 55);
			this.btNew.TabIndex = 0;
			this.btNew.Text = "New";
			this.btNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpDocument.SetToolTip(this.btNew, "\r\nCreates a new file.");
			this.btNew.UseVisualStyleBackColor = true;
			this.btNew.Click += new System.EventHandler(this.btNew_Click);
			// 
			// btRight
			// 
			this.btRight.AutoSize = true;
			this.btRight.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.Text_align_right_icon;
			this.btRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btRight.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btRight.FlatAppearance.BorderSize = 0;
			this.btRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btRight.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btRight.ImageIndex = 15;
			this.btRight.Location = new System.Drawing.Point(110, 85);
			this.btRight.Name = "btRight";
			this.btRight.Size = new System.Drawing.Size(45, 45);
			this.btRight.TabIndex = 9;
			this.btRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpAlign.SetToolTip(this.btRight, "\r\nAlign text to the right.");
			this.btRight.UseVisualStyleBackColor = true;
			this.btRight.Click += new System.EventHandler(this.btRight_Click);
			// 
			// btCenter
			// 
			this.btCenter.AutoSize = true;
			this.btCenter.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.Text_align_center_icon;
			this.btCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btCenter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btCenter.FlatAppearance.BorderSize = 0;
			this.btCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btCenter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btCenter.ImageIndex = 15;
			this.btCenter.Location = new System.Drawing.Point(59, 85);
			this.btCenter.Name = "btCenter";
			this.btCenter.Size = new System.Drawing.Size(45, 45);
			this.btCenter.TabIndex = 8;
			this.btCenter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpAlign.SetToolTip(this.btCenter, "\r\nAlign text to the center.");
			this.btCenter.UseVisualStyleBackColor = true;
			this.btCenter.Click += new System.EventHandler(this.btCenter_Click);
			// 
			// btLeft
			// 
			this.btLeft.AutoSize = true;
			this.btLeft.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.Text_align_left_icon;
			this.btLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btLeft.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btLeft.FlatAppearance.BorderSize = 0;
			this.btLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btLeft.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btLeft.ImageIndex = 15;
			this.btLeft.Location = new System.Drawing.Point(8, 85);
			this.btLeft.Name = "btLeft";
			this.btLeft.Size = new System.Drawing.Size(45, 45);
			this.btLeft.TabIndex = 7;
			this.btLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpAlign.SetToolTip(this.btLeft, "\r\nAlign text to the left.");
			this.btLeft.UseVisualStyleBackColor = true;
			this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
			// 
			// btDecIndent
			// 
			this.btDecIndent.AutoSize = true;
			this.btDecIndent.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.multimedia;
			this.btDecIndent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btDecIndent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btDecIndent.FlatAppearance.BorderSize = 0;
			this.btDecIndent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btDecIndent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btDecIndent.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btDecIndent.ImageIndex = 15;
			this.btDecIndent.Location = new System.Drawing.Point(110, 24);
			this.btDecIndent.Name = "btDecIndent";
			this.btDecIndent.Size = new System.Drawing.Size(45, 45);
			this.btDecIndent.TabIndex = 6;
			this.btDecIndent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpIndent.SetToolTip(this.btDecIndent, "\r\nDecrease indent.");
			this.btDecIndent.UseVisualStyleBackColor = true;
			this.btDecIndent.Click += new System.EventHandler(this.btDecIndent_Click);
			// 
			// btIncIndent
			// 
			this.btIncIndent.AutoSize = true;
			this.btIncIndent.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.multimedia__1_;
			this.btIncIndent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btIncIndent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btIncIndent.FlatAppearance.BorderSize = 0;
			this.btIncIndent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btIncIndent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btIncIndent.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btIncIndent.ImageIndex = 15;
			this.btIncIndent.Location = new System.Drawing.Point(59, 24);
			this.btIncIndent.Name = "btIncIndent";
			this.btIncIndent.Size = new System.Drawing.Size(45, 45);
			this.btIncIndent.TabIndex = 5;
			this.btIncIndent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpIndent.SetToolTip(this.btIncIndent, "\r\nIncrease indent.");
			this.btIncIndent.UseVisualStyleBackColor = true;
			this.btIncIndent.Click += new System.EventHandler(this.btIncIndent_Click);
			// 
			// btList
			// 
			this.btList.AutoSize = true;
			this.btList.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.list_512;
			this.btList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btList.FlatAppearance.BorderSize = 0;
			this.btList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btList.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btList.ImageIndex = 15;
			this.btList.Location = new System.Drawing.Point(8, 24);
			this.btList.Name = "btList";
			this.btList.Size = new System.Drawing.Size(45, 45);
			this.btList.TabIndex = 4;
			this.btList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpBullet.SetToolTip(this.btList, "\r\nStarts a bullet list.");
			this.btList.UseVisualStyleBackColor = true;
			this.btList.Click += new System.EventHandler(this.btList_Click);
			// 
			// btSubscript
			// 
			this.btSubscript.AutoSize = true;
			this.btSubscript.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.superscript16002;
			this.btSubscript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btSubscript.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSubscript.FlatAppearance.BorderSize = 0;
			this.btSubscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSubscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btSubscript.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btSubscript.ImageIndex = 15;
			this.btSubscript.Location = new System.Drawing.Point(263, 85);
			this.btSubscript.Name = "btSubscript";
			this.btSubscript.Size = new System.Drawing.Size(45, 45);
			this.btSubscript.TabIndex = 9;
			this.btSubscript.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEffects.SetToolTip(this.btSubscript, "\r\nMake your text subscript.");
			this.btSubscript.UseVisualStyleBackColor = true;
			this.btSubscript.Click += new System.EventHandler(this.btSubscript_Click);
			// 
			// btSuperscript
			// 
			this.btSuperscript.AutoSize = true;
			this.btSuperscript.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.subscript16002;
			this.btSuperscript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btSuperscript.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSuperscript.FlatAppearance.BorderSize = 0;
			this.btSuperscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSuperscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btSuperscript.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btSuperscript.ImageIndex = 15;
			this.btSuperscript.Location = new System.Drawing.Point(212, 85);
			this.btSuperscript.Name = "btSuperscript";
			this.btSuperscript.Size = new System.Drawing.Size(45, 45);
			this.btSuperscript.TabIndex = 8;
			this.btSuperscript.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEffects.SetToolTip(this.btSuperscript, "\r\nMake your text superscript.");
			this.btSuperscript.UseVisualStyleBackColor = true;
			this.btSuperscript.Click += new System.EventHandler(this.btSuperscript_Click);
			// 
			// btUnderline
			// 
			this.btUnderline.AutoSize = true;
			this.btUnderline.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.Actions_format_text_underline_icon;
			this.btUnderline.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btUnderline.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btUnderline.FlatAppearance.BorderSize = 0;
			this.btUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btUnderline.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btUnderline.ImageIndex = 15;
			this.btUnderline.Location = new System.Drawing.Point(161, 85);
			this.btUnderline.Name = "btUnderline";
			this.btUnderline.Size = new System.Drawing.Size(45, 45);
			this.btUnderline.TabIndex = 7;
			this.btUnderline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEffects.SetToolTip(this.btUnderline, "\r\nMake your text underlined.");
			this.btUnderline.UseVisualStyleBackColor = true;
			this.btUnderline.Click += new System.EventHandler(this.btUnderline_Click);
			// 
			// btStrike
			// 
			this.btStrike.AutoSize = true;
			this.btStrike.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.Actions_format_text_strikethrough_icon;
			this.btStrike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btStrike.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btStrike.FlatAppearance.BorderSize = 0;
			this.btStrike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btStrike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btStrike.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btStrike.ImageIndex = 15;
			this.btStrike.Location = new System.Drawing.Point(110, 85);
			this.btStrike.Name = "btStrike";
			this.btStrike.Size = new System.Drawing.Size(45, 45);
			this.btStrike.TabIndex = 6;
			this.btStrike.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEffects.SetToolTip(this.btStrike, "\r\nMake your text strikethrough.");
			this.btStrike.UseVisualStyleBackColor = true;
			this.btStrike.Click += new System.EventHandler(this.btStrike_Click);
			// 
			// btItalic
			// 
			this.btItalic.AutoSize = true;
			this.btItalic.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.Actions_format_text_italic_icon;
			this.btItalic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btItalic.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btItalic.FlatAppearance.BorderSize = 0;
			this.btItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btItalic.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btItalic.ImageIndex = 15;
			this.btItalic.Location = new System.Drawing.Point(59, 85);
			this.btItalic.Name = "btItalic";
			this.btItalic.Size = new System.Drawing.Size(45, 45);
			this.btItalic.TabIndex = 5;
			this.btItalic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEffects.SetToolTip(this.btItalic, "\r\nMake your text italic.");
			this.btItalic.UseVisualStyleBackColor = true;
			this.btItalic.Click += new System.EventHandler(this.btItalic_Click);
			// 
			// btBold
			// 
			this.btBold.AutoSize = true;
			this.btBold.BackgroundImage = global::PE_MonteroAMB_Notepad.Properties.Resources.Actions_format_text_bold_icon;
			this.btBold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btBold.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btBold.FlatAppearance.BorderSize = 0;
			this.btBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btBold.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btBold.ImageIndex = 15;
			this.btBold.Location = new System.Drawing.Point(8, 85);
			this.btBold.Name = "btBold";
			this.btBold.Size = new System.Drawing.Size(45, 45);
			this.btBold.TabIndex = 4;
			this.btBold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEffects.SetToolTip(this.btBold, "\r\nMake your text bold.");
			this.btBold.UseVisualStyleBackColor = true;
			this.btBold.Click += new System.EventHandler(this.btBold_Click);
			// 
			// btColor
			// 
			this.btColor.AutoSize = true;
			this.btColor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btColor.FlatAppearance.BorderSize = 0;
			this.btColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btColor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btColor.ImageIndex = 15;
			this.btColor.ImageList = this.imlIcons;
			this.btColor.Location = new System.Drawing.Point(163, 24);
			this.btColor.Name = "btColor";
			this.btColor.Size = new System.Drawing.Size(138, 55);
			this.btColor.TabIndex = 3;
			this.btColor.Text = "Text Color";
			this.btColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEdit.SetToolTip(this.btColor, "\r\nChanges current font color.");
			this.btColor.UseVisualStyleBackColor = true;
			this.btColor.Click += new System.EventHandler(this.btColor_Click);
			// 
			// btFont
			// 
			this.btFont.AutoSize = true;
			this.btFont.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btFont.FlatAppearance.BorderSize = 0;
			this.btFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btFont.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btFont.ImageIndex = 14;
			this.btFont.ImageList = this.imlIcons;
			this.btFont.Location = new System.Drawing.Point(8, 24);
			this.btFont.Name = "btFont";
			this.btFont.Size = new System.Drawing.Size(130, 55);
			this.btFont.TabIndex = 0;
			this.btFont.Text = "Text Font";
			this.btFont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEdit.SetToolTip(this.btFont, "\r\nChanges the current font.");
			this.btFont.UseVisualStyleBackColor = true;
			this.btFont.Click += new System.EventHandler(this.btFont_Click);
			// 
			// btRedo
			// 
			this.btRedo.AutoSize = true;
			this.btRedo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btRedo.Enabled = false;
			this.btRedo.FlatAppearance.BorderSize = 0;
			this.btRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btRedo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btRedo.ImageKey = "Actions-blue-arrow-redo-icon.png";
			this.btRedo.ImageList = this.imlIcons;
			this.btRedo.Location = new System.Drawing.Point(621, 77);
			this.btRedo.Name = "btRedo";
			this.btRedo.Size = new System.Drawing.Size(125, 55);
			this.btRedo.TabIndex = 5;
			this.btRedo.Text = "   Redo";
			this.btRedo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEdit.SetToolTip(this.btRedo, "\r\nRedo last word written.");
			this.btRedo.UseVisualStyleBackColor = true;
			this.btRedo.Click += new System.EventHandler(this.btRedo_Click);
			// 
			// btUndo
			// 
			this.btUndo.AutoSize = true;
			this.btUndo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btUndo.Enabled = false;
			this.btUndo.FlatAppearance.BorderSize = 0;
			this.btUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btUndo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btUndo.ImageKey = "Go-back-icon.png";
			this.btUndo.ImageList = this.imlIcons;
			this.btUndo.Location = new System.Drawing.Point(621, 15);
			this.btUndo.Name = "btUndo";
			this.btUndo.Size = new System.Drawing.Size(125, 55);
			this.btUndo.TabIndex = 4;
			this.btUndo.Text = "   Undo";
			this.btUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEdit.SetToolTip(this.btUndo, "\r\nUndo last word written.");
			this.btUndo.UseVisualStyleBackColor = true;
			this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
			// 
			// btSelect
			// 
			this.btSelect.AutoSize = true;
			this.btSelect.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btSelect.FlatAppearance.BorderSize = 0;
			this.btSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btSelect.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btSelect.ImageIndex = 11;
			this.btSelect.ImageList = this.imlIcons;
			this.btSelect.Location = new System.Drawing.Point(163, 85);
			this.btSelect.Name = "btSelect";
			this.btSelect.Size = new System.Drawing.Size(134, 55);
			this.btSelect.TabIndex = 4;
			this.btSelect.Text = "Select All";
			this.btSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEdit.SetToolTip(this.btSelect, "\r\nHighlights entire file.");
			this.btSelect.UseVisualStyleBackColor = true;
			this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
			// 
			// btReplace
			// 
			this.btReplace.AutoSize = true;
			this.btReplace.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btReplace.Enabled = false;
			this.btReplace.FlatAppearance.BorderSize = 0;
			this.btReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btReplace.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btReplace.ImageIndex = 16;
			this.btReplace.ImageList = this.imlIcons;
			this.btReplace.Location = new System.Drawing.Point(163, 24);
			this.btReplace.Name = "btReplace";
			this.btReplace.Size = new System.Drawing.Size(120, 55);
			this.btReplace.TabIndex = 3;
			this.btReplace.Text = "Replace";
			this.btReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEdit.SetToolTip(this.btReplace, "\r\nReplaces an instance of a text.\r\n");
			this.btReplace.UseVisualStyleBackColor = true;
			this.btReplace.Click += new System.EventHandler(this.btReplace_Click);
			// 
			// btGoTo
			// 
			this.btGoTo.AutoSize = true;
			this.btGoTo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btGoTo.Enabled = false;
			this.btGoTo.FlatAppearance.BorderSize = 0;
			this.btGoTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btGoTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btGoTo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btGoTo.ImageIndex = 6;
			this.btGoTo.ImageList = this.imlIcons;
			this.btGoTo.Location = new System.Drawing.Point(8, 85);
			this.btGoTo.Name = "btGoTo";
			this.btGoTo.Size = new System.Drawing.Size(117, 55);
			this.btGoTo.TabIndex = 2;
			this.btGoTo.Text = "Go To...";
			this.btGoTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEdit.SetToolTip(this.btGoTo, "\r\nGo to a specified line.");
			this.btGoTo.UseVisualStyleBackColor = true;
			this.btGoTo.Click += new System.EventHandler(this.btGoTo_Click);
			// 
			// btFind
			// 
			this.btFind.AutoSize = true;
			this.btFind.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btFind.Enabled = false;
			this.btFind.FlatAppearance.BorderSize = 0;
			this.btFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btFind.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btFind.ImageIndex = 10;
			this.btFind.ImageList = this.imlIcons;
			this.btFind.Location = new System.Drawing.Point(8, 24);
			this.btFind.Name = "btFind";
			this.btFind.Size = new System.Drawing.Size(99, 55);
			this.btFind.TabIndex = 0;
			this.btFind.Text = "Find";
			this.btFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEdit.SetToolTip(this.btFind, "\r\nFinds an instance of a text.");
			this.btFind.UseVisualStyleBackColor = true;
			this.btFind.Click += new System.EventHandler(this.btFind_Click);
			// 
			// btPaste
			// 
			this.btPaste.AutoSize = true;
			this.btPaste.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btPaste.Enabled = false;
			this.btPaste.FlatAppearance.BorderSize = 0;
			this.btPaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btPaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btPaste.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btPaste.ImageIndex = 9;
			this.btPaste.ImageList = this.imlIcons;
			this.btPaste.Location = new System.Drawing.Point(129, 56);
			this.btPaste.Name = "btPaste";
			this.btPaste.Size = new System.Drawing.Size(107, 55);
			this.btPaste.TabIndex = 3;
			this.btPaste.Text = "Paste";
			this.btPaste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEdit.SetToolTip(this.btPaste, "\r\nPaste text in clipboard.");
			this.btPaste.UseVisualStyleBackColor = true;
			this.btPaste.Click += new System.EventHandler(this.btPaste_Click);
			// 
			// btCopy
			// 
			this.btCopy.AutoSize = true;
			this.btCopy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btCopy.Enabled = false;
			this.btCopy.FlatAppearance.BorderSize = 0;
			this.btCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btCopy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btCopy.ImageIndex = 7;
			this.btCopy.ImageList = this.imlIcons;
			this.btCopy.Location = new System.Drawing.Point(8, 85);
			this.btCopy.Name = "btCopy";
			this.btCopy.Size = new System.Drawing.Size(99, 55);
			this.btCopy.TabIndex = 2;
			this.btCopy.Text = "Copy";
			this.btCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEdit.SetToolTip(this.btCopy, "\r\nCopies selected text.");
			this.btCopy.UseVisualStyleBackColor = true;
			this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
			// 
			// btCut
			// 
			this.btCut.AutoSize = true;
			this.btCut.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btCut.Enabled = false;
			this.btCut.FlatAppearance.BorderSize = 0;
			this.btCut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btCut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btCut.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btCut.ImageIndex = 8;
			this.btCut.ImageList = this.imlIcons;
			this.btCut.Location = new System.Drawing.Point(8, 24);
			this.btCut.Name = "btCut";
			this.btCut.Size = new System.Drawing.Size(99, 55);
			this.btCut.TabIndex = 0;
			this.btCut.Text = "Cut";
			this.btCut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpEdit.SetToolTip(this.btCut, "\r\nCuts selected text.");
			this.btCut.UseVisualStyleBackColor = true;
			this.btCut.Click += new System.EventHandler(this.btCut_Click);
			// 
			// btDateTime
			// 
			this.btDateTime.AutoSize = true;
			this.btDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btDateTime.FlatAppearance.BorderSize = 0;
			this.btDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btDateTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btDateTime.ImageKey = "clock-icon-png-10763.png";
			this.btDateTime.ImageList = this.imlBigIcons;
			this.btDateTime.Location = new System.Drawing.Point(220, 30);
			this.btDateTime.Name = "btDateTime";
			this.btDateTime.Size = new System.Drawing.Size(204, 90);
			this.btDateTime.TabIndex = 4;
			this.btDateTime.Text = "   Date/Time";
			this.btDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btDateTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpInstruct.SetToolTip(this.btDateTime, "\r\nAdds today\'s date and time to current file.");
			this.btDateTime.UseVisualStyleBackColor = true;
			this.btDateTime.Click += new System.EventHandler(this.btDateTime_Click);
			// 
			// btStatusBar
			// 
			this.btStatusBar.AutoSize = true;
			this.btStatusBar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btStatusBar.FlatAppearance.BorderSize = 0;
			this.btStatusBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btStatusBar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btStatusBar.ImageIndex = 17;
			this.btStatusBar.ImageList = this.imlIcons;
			this.btStatusBar.Location = new System.Drawing.Point(8, 85);
			this.btStatusBar.Name = "btStatusBar";
			this.btStatusBar.Size = new System.Drawing.Size(138, 55);
			this.btStatusBar.TabIndex = 2;
			this.btStatusBar.Text = "Status Bar";
			this.btStatusBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpInstruct.SetToolTip(this.btStatusBar, "\r\nAdjust visibility of status bar.");
			this.btStatusBar.UseVisualStyleBackColor = true;
			this.btStatusBar.Click += new System.EventHandler(this.btStatusBar_Click);
			// 
			// btWrap
			// 
			this.btWrap.AutoSize = true;
			this.btWrap.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btWrap.FlatAppearance.BorderSize = 0;
			this.btWrap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btWrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btWrap.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btWrap.ImageIndex = 17;
			this.btWrap.ImageList = this.imlIcons;
			this.btWrap.Location = new System.Drawing.Point(8, 24);
			this.btWrap.Name = "btWrap";
			this.btWrap.Size = new System.Drawing.Size(150, 55);
			this.btWrap.TabIndex = 0;
			this.btWrap.Text = "Word Wrap";
			this.btWrap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpInstruct.SetToolTip(this.btWrap, "\r\nAdjust word wrap state.");
			this.btWrap.UseVisualStyleBackColor = true;
			this.btWrap.Click += new System.EventHandler(this.btWrap_Click);
			// 
			// tabHelp
			// 
			this.tabHelp.Controls.Add(this.btAbout);
			this.tabHelp.Location = new System.Drawing.Point(4, 27);
			this.tabHelp.Name = "tabHelp";
			this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
			this.tabHelp.Size = new System.Drawing.Size(820, 159);
			this.tabHelp.TabIndex = 6;
			this.tabHelp.Text = "Help";
			this.tabHelp.UseVisualStyleBackColor = true;
			// 
			// btAbout
			// 
			this.btAbout.AutoSize = true;
			this.btAbout.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btAbout.FlatAppearance.BorderSize = 0;
			this.btAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btAbout.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btAbout.ImageKey = "orange-question-mark-png-image-55605.png";
			this.btAbout.ImageList = this.imlBigIcons;
			this.btAbout.Location = new System.Drawing.Point(21, 28);
			this.btAbout.Name = "btAbout";
			this.btAbout.Size = new System.Drawing.Size(265, 90);
			this.btAbout.TabIndex = 5;
			this.btAbout.Text = "   About Notepad#";
			this.btAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.ttpInstruct.SetToolTip(this.btAbout, "\r\nAdds today\'s date and time to current file.");
			this.btAbout.UseVisualStyleBackColor = true;
			this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
			// 
			// Notepad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(828, 644);
			this.Controls.Add(this.statusText);
			this.Controls.Add(this.rtbInput);
			this.Controls.Add(this.tabMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(700, 550);
			this.Name = "Notepad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Notepad#";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
			this.tabMenu.ResumeLayout(false);
			this.tabFile.ResumeLayout(false);
			this.tabFile.PerformLayout();
			this.gbPrint.ResumeLayout(false);
			this.gbPrint.PerformLayout();
			this.gbDocument.ResumeLayout(false);
			this.gbDocument.PerformLayout();
			this.tabHome.ResumeLayout(false);
			this.gbFont.ResumeLayout(false);
			this.gbFont.PerformLayout();
			this.tabEdit.ResumeLayout(false);
			this.tabEdit.PerformLayout();
			this.gbSearch.ResumeLayout(false);
			this.gbSearch.PerformLayout();
			this.gbClipboard.ResumeLayout(false);
			this.gbClipboard.PerformLayout();
			this.tabView.ResumeLayout(false);
			this.tabView.PerformLayout();
			this.statusText.ResumeLayout(false);
			this.statusText.PerformLayout();
			this.gbParagraph.ResumeLayout(false);
			this.gbParagraph.PerformLayout();
			this.gbShowHide.ResumeLayout(false);
			this.gbShowHide.PerformLayout();
			this.tabHelp.ResumeLayout(false);
			this.tabHelp.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabMenu;
		private System.Windows.Forms.TabPage tabHome;
		private System.Windows.Forms.StatusStrip statusText;
		private System.Windows.Forms.ToolStripStatusLabel tslCharacter;
		private System.Windows.Forms.TabPage tabView;
		private System.Windows.Forms.ToolStripStatusLabel tslWord;
		private System.Windows.Forms.ToolStripStatusLabel tslLines;
		private System.Windows.Forms.TabPage tabFile;
		private System.Windows.Forms.TabPage tabEdit;
		private System.Windows.Forms.GroupBox gbDocument;
		private System.Windows.Forms.Button btNew;
		private System.Windows.Forms.ImageList imlIcons;
		private System.Windows.Forms.Button btOpen;
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.GroupBox gbPrint;
		private System.Windows.Forms.Button btPrint;
		private System.Windows.Forms.Button btPage;
		private System.Windows.Forms.Button btSaveAs;
		private System.Windows.Forms.Button btExit;
		private System.Windows.Forms.ImageList imlBigIcons;
		private System.Windows.Forms.OpenFileDialog ofdNote;
		private System.Windows.Forms.PrintDialog pdNote;
		private System.Windows.Forms.PageSetupDialog psdText;
		private System.Windows.Forms.GroupBox gbClipboard;
		private System.Windows.Forms.Button btPaste;
		private System.Windows.Forms.Button btCopy;
		private System.Windows.Forms.Button btCut;
		private System.Windows.Forms.Button btUndo;
		private System.Windows.Forms.GroupBox gbSearch;
		private System.Windows.Forms.Button btSelect;
		private System.Windows.Forms.Button btReplace;
		private System.Windows.Forms.Button btGoTo;
		private System.Windows.Forms.Button btFind;
		private System.Windows.Forms.SaveFileDialog sfdText;
		private System.Windows.Forms.Button btRedo;
		private System.Windows.Forms.GroupBox gbFont;
		private System.Windows.Forms.Button btColor;
		private System.Windows.Forms.Button btFont;
		public System.Windows.Forms.RichTextBox rtbInput;
		private System.Windows.Forms.Button btBold;
		private System.Windows.Forms.Button btItalic;
		private System.Windows.Forms.Button btSubscript;
		private System.Windows.Forms.Button btSuperscript;
		private System.Windows.Forms.Button btUnderline;
		private System.Windows.Forms.Button btStrike;
		private System.Windows.Forms.GroupBox gbParagraph;
		private System.Windows.Forms.Button btRight;
		private System.Windows.Forms.Button btCenter;
		private System.Windows.Forms.Button btLeft;
		private System.Windows.Forms.Button btDecIndent;
		private System.Windows.Forms.Button btIncIndent;
		private System.Windows.Forms.Button btList;
		private System.Windows.Forms.FontDialog fontDialogNote;
		private System.Windows.Forms.ColorDialog colorDialogNote;
		private System.Windows.Forms.GroupBox gbShowHide;
		private System.Windows.Forms.Button btStatusBar;
		private System.Windows.Forms.Button btWrap;
		private System.Windows.Forms.Button btDateTime;
		private System.Windows.Forms.ToolTip ttpEffects;
		private System.Windows.Forms.ToolTip ttpAlign;
		private System.Windows.Forms.ToolTip ttpBullet;
		private System.Windows.Forms.ToolTip ttpIndent;
		private System.Windows.Forms.ToolTip ttpInstruct;
		private System.Windows.Forms.ToolTip ttpPrint;
		private System.Windows.Forms.ToolTip ttpDocument;
		private System.Windows.Forms.ToolTip ttpEdit;
		private System.Windows.Forms.TabPage tabHelp;
		private System.Windows.Forms.Button btAbout;
	}
}

