﻿namespace ManiaBSEdit
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
			System.Windows.Forms.MenuStrip menuStrip1;
			System.Windows.Forms.ImageList imageList1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.Panel panel1;
			System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
			System.Windows.Forms.ToolTip toolTip1;
			System.Windows.Forms.Panel panel5;
			System.Windows.Forms.ToolStrip layoutSectionListToolStrip;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveUndoHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolOptionsPanel = new System.Windows.Forms.Panel();
			this.startButton = new System.Windows.Forms.RadioButton();
			this.lineButton = new System.Windows.Forms.RadioButton();
			this.fillButton = new System.Windows.Forms.RadioButton();
			this.pencilButton = new System.Windows.Forms.RadioButton();
			this.selectButton = new System.Windows.Forms.RadioButton();
			this.rectangleButton = new System.Windows.Forms.RadioButton();
			this.diamondButton = new System.Windows.Forms.RadioButton();
			this.ovalButton = new System.Windows.Forms.RadioButton();
			this.layoutSectionListBox = new System.Windows.Forms.ListBox();
			this.foreSpherePicture = new System.Windows.Forms.PictureBox();
			this.backSpherePicture = new System.Windows.Forms.PictureBox();
			this.paletteYellow = new System.Windows.Forms.PictureBox();
			this.paletteRing = new System.Windows.Forms.PictureBox();
			this.paletteBumper = new System.Windows.Forms.PictureBox();
			this.paletteBlue = new System.Windows.Forms.PictureBox();
			this.paletteRed = new System.Windows.Forms.PictureBox();
			this.paletteErase = new System.Windows.Forms.PictureBox();
			this.layoutSectionPreview = new System.Windows.Forms.PictureBox();
			this.paletteGreen = new System.Windows.Forms.PictureBox();
			this.palettePink = new System.Windows.Forms.PictureBox();
			this.layoutPanelContainer = new System.Windows.Forms.Panel();
			this.layoutPanel = new OpenTK.GLControl(new OpenTK.Graphics.GraphicsMode(), 2, 1, OpenTK.Graphics.GraphicsContextFlags.Default);
			this.layoutSectionSplitContainer = new System.Windows.Forms.SplitContainer();
			this.importToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.stageLayoutOptionsPanel = new System.Windows.Forms.Panel();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.layoutContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteOnceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteRepeatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.insertTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceFGToBGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceBGToFGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.swapFGAndBGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.markBlueGreenRedSpheresAsRingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flipHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flipVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rotateLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rotateRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteSectionOnceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteSectionRepeatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			menuStrip1 = new System.Windows.Forms.MenuStrip();
			imageList1 = new System.Windows.Forms.ImageList(this.components);
			panel1 = new System.Windows.Forms.Panel();
			tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			panel5 = new System.Windows.Forms.Panel();
			layoutSectionListToolStrip = new System.Windows.Forms.ToolStrip();
			toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			menuStrip1.SuspendLayout();
			panel1.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.foreSpherePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.backSpherePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteYellow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteRing)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteBumper)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteRed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteErase)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutSectionPreview)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.palettePink)).BeginInit();
			this.layoutPanelContainer.SuspendLayout();
			panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutSectionSplitContainer)).BeginInit();
			this.layoutSectionSplitContainer.Panel1.SuspendLayout();
			this.layoutSectionSplitContainer.Panel2.SuspendLayout();
			this.layoutSectionSplitContainer.SuspendLayout();
			layoutSectionListToolStrip.SuspendLayout();
			this.stageLayoutOptionsPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.layoutContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.editToolStripMenuItem,
			this.viewToolStripMenuItem});
			menuStrip1.Location = new System.Drawing.Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new System.Drawing.Size(584, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.newToolStripMenuItem,
			this.openToolStripMenuItem,
			this.saveToolStripMenuItem,
			this.saveAsToolStripMenuItem,
			this.exportImageToolStripMenuItem,
			this.recentFilesToolStripMenuItem,
			this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.openToolStripMenuItem.Text = "&Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// exportImageToolStripMenuItem
			// 
			this.exportImageToolStripMenuItem.Name = "exportImageToolStripMenuItem";
			this.exportImageToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.exportImageToolStripMenuItem.Text = "&Export Image...";
			this.exportImageToolStripMenuItem.Click += new System.EventHandler(this.exportImageToolStripMenuItem_Click);
			// 
			// recentFilesToolStripMenuItem
			// 
			this.recentFilesToolStripMenuItem.Enabled = false;
			this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
			this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.recentFilesToolStripMenuItem.Text = "&Recent Files";
			this.recentFilesToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.recentFilesToolStripMenuItem_DropDownItemClicked);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.undoToolStripMenuItem,
			this.redoToolStripMenuItem,
			this.saveUndoHistoryToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Enabled = false;
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.undoToolStripMenuItem.Text = "&Undo";
			this.undoToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.undoToolStripMenuItem_DropDownItemClicked);
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Enabled = false;
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.redoToolStripMenuItem.Text = "&Redo";
			this.redoToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.redoToolStripMenuItem_DropDownItemClicked);
			// 
			// saveUndoHistoryToolStripMenuItem
			// 
			this.saveUndoHistoryToolStripMenuItem.Checked = true;
			this.saveUndoHistoryToolStripMenuItem.CheckOnClick = true;
			this.saveUndoHistoryToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.saveUndoHistoryToolStripMenuItem.Name = "saveUndoHistoryToolStripMenuItem";
			this.saveUndoHistoryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.saveUndoHistoryToolStripMenuItem.Text = "&Save Undo History";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.showGridToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// showGridToolStripMenuItem
			// 
			this.showGridToolStripMenuItem.Checked = true;
			this.showGridToolStripMenuItem.CheckOnClick = true;
			this.showGridToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
			this.showGridToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.showGridToolStripMenuItem.Text = "Show &Grid";
			this.showGridToolStripMenuItem.CheckStateChanged += new System.EventHandler(this.showGridToolStripMenuItem_CheckStateChanged);
			// 
			// imageList1
			// 
			imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			imageList1.TransparentColor = System.Drawing.Color.Red;
			imageList1.Images.SetKeyName(0, "select");
			imageList1.Images.SetKeyName(1, "pencil");
			imageList1.Images.SetKeyName(2, "fill");
			imageList1.Images.SetKeyName(3, "line");
			imageList1.Images.SetKeyName(4, "rectangle");
			imageList1.Images.SetKeyName(5, "diamond");
			imageList1.Images.SetKeyName(6, "oval");
			imageList1.Images.SetKeyName(7, "start");
			// 
			// panel1
			// 
			panel1.AutoSize = true;
			panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			panel1.Controls.Add(this.toolOptionsPanel);
			panel1.Controls.Add(tableLayoutPanel1);
			panel1.Dock = System.Windows.Forms.DockStyle.Left;
			panel1.Location = new System.Drawing.Point(0, 24);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(60, 537);
			panel1.TabIndex = 2;
			// 
			// toolOptionsPanel
			// 
			this.toolOptionsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.toolOptionsPanel.Location = new System.Drawing.Point(9, 123);
			this.toolOptionsPanel.Name = "toolOptionsPanel";
			this.toolOptionsPanel.Size = new System.Drawing.Size(42, 66);
			this.toolOptionsPanel.TabIndex = 1;
			this.toolOptionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toolOptionsPanel_Paint);
			this.toolOptionsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.toolOptionsPanel_MouseClick);
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.AutoSize = true;
			tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			tableLayoutPanel1.Controls.Add(this.startButton, 0, 3);
			tableLayoutPanel1.Controls.Add(this.lineButton, 1, 1);
			tableLayoutPanel1.Controls.Add(this.fillButton, 0, 1);
			tableLayoutPanel1.Controls.Add(this.pencilButton, 1, 0);
			tableLayoutPanel1.Controls.Add(this.selectButton, 0, 0);
			tableLayoutPanel1.Controls.Add(this.rectangleButton, 0, 2);
			tableLayoutPanel1.Controls.Add(this.diamondButton, 1, 2);
			tableLayoutPanel1.Controls.Add(this.ovalButton, 0, 3);
			tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 4;
			tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayoutPanel1.Size = new System.Drawing.Size(60, 120);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// startButton
			// 
			this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.startButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.startButton.ImageKey = "start";
			this.startButton.ImageList = imageList1;
			this.startButton.Location = new System.Drawing.Point(33, 93);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(24, 24);
			this.startButton.TabIndex = 7;
			toolTip1.SetToolTip(this.startButton, "Start Position Tool");
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.CheckedChanged += new System.EventHandler(this.startButton_CheckedChanged);
			// 
			// lineButton
			// 
			this.lineButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.lineButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.lineButton.ImageKey = "line";
			this.lineButton.ImageList = imageList1;
			this.lineButton.Location = new System.Drawing.Point(33, 33);
			this.lineButton.Name = "lineButton";
			this.lineButton.Size = new System.Drawing.Size(24, 24);
			this.lineButton.TabIndex = 3;
			toolTip1.SetToolTip(this.lineButton, "Line Tool");
			this.lineButton.UseVisualStyleBackColor = true;
			this.lineButton.CheckedChanged += new System.EventHandler(this.lineButton_CheckedChanged);
			// 
			// fillButton
			// 
			this.fillButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.fillButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.fillButton.ImageKey = "fill";
			this.fillButton.ImageList = imageList1;
			this.fillButton.Location = new System.Drawing.Point(3, 33);
			this.fillButton.Name = "fillButton";
			this.fillButton.Size = new System.Drawing.Size(24, 24);
			this.fillButton.TabIndex = 2;
			toolTip1.SetToolTip(this.fillButton, "Fill Tool");
			this.fillButton.UseVisualStyleBackColor = true;
			this.fillButton.CheckedChanged += new System.EventHandler(this.fillButton_CheckedChanged);
			// 
			// pencilButton
			// 
			this.pencilButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pencilButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.pencilButton.Checked = true;
			this.pencilButton.ImageKey = "pencil";
			this.pencilButton.ImageList = imageList1;
			this.pencilButton.Location = new System.Drawing.Point(33, 3);
			this.pencilButton.Name = "pencilButton";
			this.pencilButton.Size = new System.Drawing.Size(24, 24);
			this.pencilButton.TabIndex = 1;
			this.pencilButton.TabStop = true;
			toolTip1.SetToolTip(this.pencilButton, "Pencil Tool");
			this.pencilButton.UseVisualStyleBackColor = true;
			this.pencilButton.CheckedChanged += new System.EventHandler(this.pencilButton_CheckedChanged);
			// 
			// selectButton
			// 
			this.selectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.selectButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.selectButton.ImageKey = "select";
			this.selectButton.ImageList = imageList1;
			this.selectButton.Location = new System.Drawing.Point(3, 3);
			this.selectButton.Name = "selectButton";
			this.selectButton.Size = new System.Drawing.Size(24, 24);
			this.selectButton.TabIndex = 0;
			toolTip1.SetToolTip(this.selectButton, "Select Tool");
			this.selectButton.UseVisualStyleBackColor = true;
			this.selectButton.CheckedChanged += new System.EventHandler(this.selectButton_CheckedChanged);
			// 
			// rectangleButton
			// 
			this.rectangleButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rectangleButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.rectangleButton.ImageKey = "rectangle";
			this.rectangleButton.ImageList = imageList1;
			this.rectangleButton.Location = new System.Drawing.Point(3, 63);
			this.rectangleButton.Name = "rectangleButton";
			this.rectangleButton.Size = new System.Drawing.Size(24, 24);
			this.rectangleButton.TabIndex = 4;
			toolTip1.SetToolTip(this.rectangleButton, "Rectangle Tool");
			this.rectangleButton.UseVisualStyleBackColor = true;
			this.rectangleButton.CheckedChanged += new System.EventHandler(this.rectangleButton_CheckedChanged);
			// 
			// diamondButton
			// 
			this.diamondButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.diamondButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.diamondButton.ImageKey = "diamond";
			this.diamondButton.ImageList = imageList1;
			this.diamondButton.Location = new System.Drawing.Point(33, 63);
			this.diamondButton.Name = "diamondButton";
			this.diamondButton.Size = new System.Drawing.Size(24, 24);
			this.diamondButton.TabIndex = 6;
			toolTip1.SetToolTip(this.diamondButton, "Diamond Tool");
			this.diamondButton.UseVisualStyleBackColor = true;
			this.diamondButton.CheckedChanged += new System.EventHandler(this.diamondButton_CheckedChanged);
			// 
			// ovalButton
			// 
			this.ovalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.ovalButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.ovalButton.ImageKey = "oval";
			this.ovalButton.ImageList = imageList1;
			this.ovalButton.Location = new System.Drawing.Point(3, 93);
			this.ovalButton.Name = "ovalButton";
			this.ovalButton.Size = new System.Drawing.Size(24, 24);
			this.ovalButton.TabIndex = 5;
			toolTip1.SetToolTip(this.ovalButton, "Oval Tool");
			this.ovalButton.UseVisualStyleBackColor = true;
			this.ovalButton.CheckedChanged += new System.EventHandler(this.ovalButton_CheckedChanged);
			// 
			// layoutSectionListBox
			// 
			this.layoutSectionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutSectionListBox.FormattingEnabled = true;
			this.layoutSectionListBox.IntegralHeight = false;
			this.layoutSectionListBox.Location = new System.Drawing.Point(0, 0);
			this.layoutSectionListBox.Name = "layoutSectionListBox";
			this.layoutSectionListBox.Size = new System.Drawing.Size(200, 142);
			this.layoutSectionListBox.TabIndex = 0;
			toolTip1.SetToolTip(this.layoutSectionListBox, "Layout Sections");
			this.layoutSectionListBox.SelectedIndexChanged += new System.EventHandler(this.layoutSectionListBox_SelectedIndexChanged);
			this.layoutSectionListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.layoutSectionListBox_KeyDown);
			// 
			// foreSpherePicture
			// 
			this.foreSpherePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.foreSpherePicture.Location = new System.Drawing.Point(0, 0);
			this.foreSpherePicture.Margin = new System.Windows.Forms.Padding(0);
			this.foreSpherePicture.Name = "foreSpherePicture";
			this.foreSpherePicture.Size = new System.Drawing.Size(20, 20);
			this.foreSpherePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.foreSpherePicture.TabIndex = 1;
			this.foreSpherePicture.TabStop = false;
			toolTip1.SetToolTip(this.foreSpherePicture, "Click To Swap");
			this.foreSpherePicture.Click += new System.EventHandler(this.foreSpherePicture_Click);
			// 
			// backSpherePicture
			// 
			this.backSpherePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.backSpherePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.backSpherePicture.Location = new System.Drawing.Point(12, 12);
			this.backSpherePicture.Margin = new System.Windows.Forms.Padding(0);
			this.backSpherePicture.Name = "backSpherePicture";
			this.backSpherePicture.Size = new System.Drawing.Size(20, 20);
			this.backSpherePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.backSpherePicture.TabIndex = 0;
			this.backSpherePicture.TabStop = false;
			toolTip1.SetToolTip(this.backSpherePicture, "Click To Swap");
			this.backSpherePicture.Click += new System.EventHandler(this.foreSpherePicture_Click);
			// 
			// paletteYellow
			// 
			this.paletteYellow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.paletteYellow.Location = new System.Drawing.Point(153, 5);
			this.paletteYellow.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.paletteYellow.Name = "paletteYellow";
			this.paletteYellow.Size = new System.Drawing.Size(28, 28);
			this.paletteYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.paletteYellow.TabIndex = 5;
			this.paletteYellow.TabStop = false;
			toolTip1.SetToolTip(this.paletteYellow, "Yellow Sphere");
			this.paletteYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paletteYellow_MouseClick);
			// 
			// paletteRing
			// 
			this.paletteRing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.paletteRing.Location = new System.Drawing.Point(237, 5);
			this.paletteRing.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.paletteRing.Name = "paletteRing";
			this.paletteRing.Size = new System.Drawing.Size(28, 28);
			this.paletteRing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.paletteRing.TabIndex = 4;
			this.paletteRing.TabStop = false;
			toolTip1.SetToolTip(this.paletteRing, "Ring");
			this.paletteRing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paletteRing_MouseClick);
			// 
			// paletteBumper
			// 
			this.paletteBumper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.paletteBumper.Location = new System.Drawing.Point(125, 5);
			this.paletteBumper.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.paletteBumper.Name = "paletteBumper";
			this.paletteBumper.Size = new System.Drawing.Size(28, 28);
			this.paletteBumper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.paletteBumper.TabIndex = 3;
			this.paletteBumper.TabStop = false;
			toolTip1.SetToolTip(this.paletteBumper, "Bumper");
			this.paletteBumper.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paletteBumper_MouseClick);
			// 
			// paletteBlue
			// 
			this.paletteBlue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.paletteBlue.Location = new System.Drawing.Point(69, 5);
			this.paletteBlue.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.paletteBlue.Name = "paletteBlue";
			this.paletteBlue.Size = new System.Drawing.Size(28, 28);
			this.paletteBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.paletteBlue.TabIndex = 2;
			this.paletteBlue.TabStop = false;
			toolTip1.SetToolTip(this.paletteBlue, "Blue Sphere");
			this.paletteBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paletteBlue_MouseClick);
			// 
			// paletteRed
			// 
			this.paletteRed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.paletteRed.Location = new System.Drawing.Point(97, 5);
			this.paletteRed.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.paletteRed.Name = "paletteRed";
			this.paletteRed.Size = new System.Drawing.Size(28, 28);
			this.paletteRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.paletteRed.TabIndex = 1;
			this.paletteRed.TabStop = false;
			toolTip1.SetToolTip(this.paletteRed, "Red Sphere");
			this.paletteRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paletteRed_MouseClick);
			// 
			// paletteErase
			// 
			this.paletteErase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.paletteErase.Location = new System.Drawing.Point(41, 5);
			this.paletteErase.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.paletteErase.Name = "paletteErase";
			this.paletteErase.Size = new System.Drawing.Size(28, 28);
			this.paletteErase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.paletteErase.TabIndex = 0;
			this.paletteErase.TabStop = false;
			toolTip1.SetToolTip(this.paletteErase, "Erase");
			this.paletteErase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paletteErase_MouseClick);
			// 
			// layoutSectionPreview
			// 
			this.layoutSectionPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutSectionPreview.Location = new System.Drawing.Point(0, 0);
			this.layoutSectionPreview.Margin = new System.Windows.Forms.Padding(0);
			this.layoutSectionPreview.Name = "layoutSectionPreview";
			this.layoutSectionPreview.Size = new System.Drawing.Size(200, 176);
			this.layoutSectionPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.layoutSectionPreview.TabIndex = 0;
			this.layoutSectionPreview.TabStop = false;
			toolTip1.SetToolTip(this.layoutSectionPreview, "Layout Section Preview");
			// 
			// paletteGreen
			// 
			this.paletteGreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.paletteGreen.Location = new System.Drawing.Point(181, 5);
			this.paletteGreen.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.paletteGreen.Name = "paletteGreen";
			this.paletteGreen.Size = new System.Drawing.Size(28, 28);
			this.paletteGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.paletteGreen.TabIndex = 6;
			this.paletteGreen.TabStop = false;
			toolTip1.SetToolTip(this.paletteGreen, "Green Sphere");
			this.paletteGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paletteGreen_MouseClick);
			// 
			// palettePink
			// 
			this.palettePink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.palettePink.Location = new System.Drawing.Point(209, 5);
			this.palettePink.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.palettePink.Name = "palettePink";
			this.palettePink.Size = new System.Drawing.Size(28, 28);
			this.palettePink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.palettePink.TabIndex = 7;
			this.palettePink.TabStop = false;
			toolTip1.SetToolTip(this.palettePink, "Pink Sphere");
			this.palettePink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.palettePink_MouseClick);
			// 
			// layoutPanelContainer
			// 
			this.layoutPanelContainer.AutoScroll = true;
			this.layoutPanelContainer.BackColor = System.Drawing.SystemColors.ControlDark;
			this.layoutPanelContainer.Controls.Add(this.layoutPanel);
			this.layoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutPanelContainer.Location = new System.Drawing.Point(60, 62);
			this.layoutPanelContainer.Name = "layoutPanelContainer";
			this.layoutPanelContainer.Size = new System.Drawing.Size(324, 499);
			this.layoutPanelContainer.TabIndex = 1;
			this.layoutPanelContainer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.layoutPanelContainer_Scroll);
			// 
			// layoutPanel
			// 
			this.layoutPanel.BackColor = System.Drawing.SystemColors.Control;
			this.layoutPanel.Location = new System.Drawing.Point(0, 0);
			this.layoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.layoutPanel.Name = "layoutPanel";
			this.layoutPanel.Size = new System.Drawing.Size(896, 896);
			this.layoutPanel.TabIndex = 0;
			this.layoutPanel.Load += new System.EventHandler(this.layoutPanel_Load);
			this.layoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.layoutPanel_Paint);
			this.layoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.layoutPanel_MouseDown);
			this.layoutPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.layoutPanel_MouseMove);
			this.layoutPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.layoutPanel_MouseUp);
			// 
			// panel5
			// 
			panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			panel5.Controls.Add(this.layoutSectionSplitContainer);
			panel5.Controls.Add(this.stageLayoutOptionsPanel);
			panel5.Dock = System.Windows.Forms.DockStyle.Right;
			panel5.Location = new System.Drawing.Point(384, 24);
			panel5.Name = "panel5";
			panel5.Size = new System.Drawing.Size(200, 537);
			panel5.TabIndex = 2;
			// 
			// layoutSectionSplitContainer
			// 
			this.layoutSectionSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutSectionSplitContainer.Location = new System.Drawing.Point(0, 215);
			this.layoutSectionSplitContainer.Margin = new System.Windows.Forms.Padding(0);
			this.layoutSectionSplitContainer.Name = "layoutSectionSplitContainer";
			this.layoutSectionSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// layoutSectionSplitContainer.Panel1
			// 
			this.layoutSectionSplitContainer.Panel1.Controls.Add(this.layoutSectionListBox);
			this.layoutSectionSplitContainer.Panel1.Controls.Add(layoutSectionListToolStrip);
			// 
			// layoutSectionSplitContainer.Panel2
			// 
			this.layoutSectionSplitContainer.Panel2.Controls.Add(this.layoutSectionPreview);
			this.layoutSectionSplitContainer.Size = new System.Drawing.Size(200, 322);
			this.layoutSectionSplitContainer.SplitterDistance = 142;
			this.layoutSectionSplitContainer.TabIndex = 9;
			// 
			// layoutSectionListToolStrip
			// 
			layoutSectionListToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			layoutSectionListToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.importToolStripButton});
			layoutSectionListToolStrip.Location = new System.Drawing.Point(0, 0);
			layoutSectionListToolStrip.Name = "layoutSectionListToolStrip";
			layoutSectionListToolStrip.Size = new System.Drawing.Size(175, 25);
			layoutSectionListToolStrip.TabIndex = 1;
			layoutSectionListToolStrip.Text = "toolStrip1";
			layoutSectionListToolStrip.Visible = false;
			// 
			// importToolStripButton
			// 
			this.importToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.importToolStripButton.Name = "importToolStripButton";
			this.importToolStripButton.Size = new System.Drawing.Size(56, 22);
			this.importToolStripButton.Text = "I&mport...";
			// 
			// stageLayoutOptionsPanel
			// 
			this.stageLayoutOptionsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.stageLayoutOptionsPanel.Controls.Add(this.propertyGrid1);
			this.stageLayoutOptionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.stageLayoutOptionsPanel.Location = new System.Drawing.Point(0, 0);
			this.stageLayoutOptionsPanel.Margin = new System.Windows.Forms.Padding(0);
			this.stageLayoutOptionsPanel.Name = "stageLayoutOptionsPanel";
			this.stageLayoutOptionsPanel.Size = new System.Drawing.Size(200, 215);
			this.stageLayoutOptionsPanel.TabIndex = 8;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.HelpVisible = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark;
			this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.PropertySort = System.Windows.Forms.PropertySort.NoSort;
			this.propertyGrid1.Size = new System.Drawing.Size(200, 215);
			this.propertyGrid1.TabIndex = 0;
			this.propertyGrid1.ToolbarVisible = false;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new System.Drawing.Size(277, 6);
			toolStripSeparator2.Visible = false;
			// 
			// panel2
			// 
			this.panel2.AutoSize = true;
			this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel2.Controls.Add(this.palettePink);
			this.panel2.Controls.Add(this.paletteGreen);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.paletteYellow);
			this.panel2.Controls.Add(this.paletteRing);
			this.panel2.Controls.Add(this.paletteBumper);
			this.panel2.Controls.Add(this.paletteBlue);
			this.panel2.Controls.Add(this.paletteRed);
			this.panel2.Controls.Add(this.paletteErase);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(60, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(324, 38);
			this.panel2.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.foreSpherePicture);
			this.panel3.Controls.Add(this.backSpherePicture);
			this.panel3.Location = new System.Drawing.Point(6, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(32, 32);
			this.panel3.TabIndex = 0;
			// 
			// layoutContextMenuStrip
			// 
			this.layoutContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.cutToolStripMenuItem,
			this.copyToolStripMenuItem,
			this.pasteOnceToolStripMenuItem,
			this.pasteRepeatingToolStripMenuItem,
			this.importToolStripMenuItem,
			this.insertTextToolStripMenuItem,
			this.replaceToolStripMenuItem,
			this.markBlueGreenRedSpheresAsRingsToolStripMenuItem,
			toolStripSeparator1,
			this.flipHorizontallyToolStripMenuItem,
			this.flipVerticallyToolStripMenuItem,
			this.rotateLeftToolStripMenuItem,
			this.rotateRightToolStripMenuItem,
			toolStripSeparator2,
			this.saveSectionToolStripMenuItem,
			this.pasteSectionOnceToolStripMenuItem,
			this.pasteSectionRepeatingToolStripMenuItem});
			this.layoutContextMenuStrip.Name = "layoutContextMenuStrip";
			this.layoutContextMenuStrip.Size = new System.Drawing.Size(281, 346);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Image = global::ManiaBSEdit.Properties.Resources.cut;
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.cutToolStripMenuItem.Text = "Cu&t";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = global::ManiaBSEdit.Properties.Resources.copy;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// pasteOnceToolStripMenuItem
			// 
			this.pasteOnceToolStripMenuItem.Image = global::ManiaBSEdit.Properties.Resources.paste;
			this.pasteOnceToolStripMenuItem.Name = "pasteOnceToolStripMenuItem";
			this.pasteOnceToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.pasteOnceToolStripMenuItem.Text = "&Paste Once";
			this.pasteOnceToolStripMenuItem.Click += new System.EventHandler(this.pasteOnceToolStripMenuItem_Click);
			// 
			// pasteRepeatingToolStripMenuItem
			// 
			this.pasteRepeatingToolStripMenuItem.Image = global::ManiaBSEdit.Properties.Resources.paste;
			this.pasteRepeatingToolStripMenuItem.Name = "pasteRepeatingToolStripMenuItem";
			this.pasteRepeatingToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.pasteRepeatingToolStripMenuItem.Text = "Paste &Repeating";
			this.pasteRepeatingToolStripMenuItem.Click += new System.EventHandler(this.pasteRepeatingToolStripMenuItem_Click);
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.importToolStripMenuItem.Text = "I&mport...";
			this.importToolStripMenuItem.Visible = false;
			this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
			// 
			// insertTextToolStripMenuItem
			// 
			this.insertTextToolStripMenuItem.Image = global::ManiaBSEdit.Properties.Resources.FontHS;
			this.insertTextToolStripMenuItem.Name = "insertTextToolStripMenuItem";
			this.insertTextToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.insertTextToolStripMenuItem.Text = "Insert Te&xt...";
			this.insertTextToolStripMenuItem.Click += new System.EventHandler(this.insertTextToolStripMenuItem_Click);
			// 
			// replaceToolStripMenuItem
			// 
			this.replaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.replaceFGToBGToolStripMenuItem,
			this.replaceBGToFGToolStripMenuItem,
			this.swapFGAndBGToolStripMenuItem});
			this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
			this.replaceToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.replaceToolStripMenuItem.Text = "Repl&ace...";
			// 
			// replaceFGToBGToolStripMenuItem
			// 
			this.replaceFGToBGToolStripMenuItem.Name = "replaceFGToBGToolStripMenuItem";
			this.replaceFGToBGToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.replaceFGToBGToolStripMenuItem.Text = "&FG -> BG";
			this.replaceFGToBGToolStripMenuItem.Click += new System.EventHandler(this.replaceFGToBGToolStripMenuItem_Click);
			// 
			// replaceBGToFGToolStripMenuItem
			// 
			this.replaceBGToFGToolStripMenuItem.Name = "replaceBGToFGToolStripMenuItem";
			this.replaceBGToFGToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.replaceBGToFGToolStripMenuItem.Text = "&BG -> FG";
			this.replaceBGToFGToolStripMenuItem.Click += new System.EventHandler(this.replaceBGToFGToolStripMenuItem_Click);
			// 
			// swapFGAndBGToolStripMenuItem
			// 
			this.swapFGAndBGToolStripMenuItem.Name = "swapFGAndBGToolStripMenuItem";
			this.swapFGAndBGToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.swapFGAndBGToolStripMenuItem.Text = "F&G <-> BG";
			this.swapFGAndBGToolStripMenuItem.Click += new System.EventHandler(this.swapFGAndBGToolStripMenuItem_Click);
			// 
			// markBlueGreenRedSpheresAsRingsToolStripMenuItem
			// 
			this.markBlueGreenRedSpheresAsRingsToolStripMenuItem.Name = "markBlueGreenRedSpheresAsRingsToolStripMenuItem";
			this.markBlueGreenRedSpheresAsRingsToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.markBlueGreenRedSpheresAsRingsToolStripMenuItem.Text = "Mark &Blue/Green/Red Spheres As Rings";
			this.markBlueGreenRedSpheresAsRingsToolStripMenuItem.Click += new System.EventHandler(this.markBlueGreenRedSpheresAsRingsToolStripMenuItem_Click);
			// 
			// flipHorizontallyToolStripMenuItem
			// 
			this.flipHorizontallyToolStripMenuItem.Image = global::ManiaBSEdit.Properties.Resources.fliph;
			this.flipHorizontallyToolStripMenuItem.Name = "flipHorizontallyToolStripMenuItem";
			this.flipHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.flipHorizontallyToolStripMenuItem.Text = "Flip &Horizontally";
			this.flipHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.flipHorizontallyToolStripMenuItem_Click);
			// 
			// flipVerticallyToolStripMenuItem
			// 
			this.flipVerticallyToolStripMenuItem.Image = global::ManiaBSEdit.Properties.Resources.flipv;
			this.flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
			this.flipVerticallyToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.flipVerticallyToolStripMenuItem.Text = "Flip &Vertically";
			this.flipVerticallyToolStripMenuItem.Click += new System.EventHandler(this.flipVerticallyToolStripMenuItem_Click);
			// 
			// rotateLeftToolStripMenuItem
			// 
			this.rotateLeftToolStripMenuItem.Image = global::ManiaBSEdit.Properties.Resources.rotatel;
			this.rotateLeftToolStripMenuItem.Name = "rotateLeftToolStripMenuItem";
			this.rotateLeftToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.rotateLeftToolStripMenuItem.Text = "Rotate &Left";
			this.rotateLeftToolStripMenuItem.Click += new System.EventHandler(this.rotateLeftToolStripMenuItem_Click);
			// 
			// rotateRightToolStripMenuItem
			// 
			this.rotateRightToolStripMenuItem.Image = global::ManiaBSEdit.Properties.Resources.rotater;
			this.rotateRightToolStripMenuItem.Name = "rotateRightToolStripMenuItem";
			this.rotateRightToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.rotateRightToolStripMenuItem.Text = "Rotate R&ight";
			this.rotateRightToolStripMenuItem.Click += new System.EventHandler(this.rotateRightToolStripMenuItem_Click);
			// 
			// saveSectionToolStripMenuItem
			// 
			this.saveSectionToolStripMenuItem.Name = "saveSectionToolStripMenuItem";
			this.saveSectionToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.saveSectionToolStripMenuItem.Text = "&Save Section...";
			this.saveSectionToolStripMenuItem.Click += new System.EventHandler(this.saveSectionToolStripMenuItem_Click);
			// 
			// pasteSectionOnceToolStripMenuItem
			// 
			this.pasteSectionOnceToolStripMenuItem.Image = global::ManiaBSEdit.Properties.Resources.paste;
			this.pasteSectionOnceToolStripMenuItem.Name = "pasteSectionOnceToolStripMenuItem";
			this.pasteSectionOnceToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.pasteSectionOnceToolStripMenuItem.Text = "P&aste Section Once";
			this.pasteSectionOnceToolStripMenuItem.Click += new System.EventHandler(this.pasteSectionOnceToolStripMenuItem_Click);
			// 
			// pasteSectionRepeatingToolStripMenuItem
			// 
			this.pasteSectionRepeatingToolStripMenuItem.Image = global::ManiaBSEdit.Properties.Resources.paste;
			this.pasteSectionRepeatingToolStripMenuItem.Name = "pasteSectionRepeatingToolStripMenuItem";
			this.pasteSectionRepeatingToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
			this.pasteSectionRepeatingToolStripMenuItem.Text = "Paste Section R&epeating";
			this.pasteSectionRepeatingToolStripMenuItem.Click += new System.EventHandler(this.pasteSectionRepeatingToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 561);
			this.Controls.Add(this.layoutPanelContainer);
			this.Controls.Add(this.panel2);
			this.Controls.Add(panel1);
			this.Controls.Add(panel5);
			this.Controls.Add(menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = menuStrip1;
			this.Name = "MainForm";
			this.Text = "ManiaBSEdit - New Stage";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.foreSpherePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.backSpherePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteYellow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteRing)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteBumper)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteBlue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteRed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteErase)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutSectionPreview)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paletteGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.palettePink)).EndInit();
			this.layoutPanelContainer.ResumeLayout(false);
			panel5.ResumeLayout(false);
			this.layoutSectionSplitContainer.Panel1.ResumeLayout(false);
			this.layoutSectionSplitContainer.Panel1.PerformLayout();
			this.layoutSectionSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutSectionSplitContainer)).EndInit();
			this.layoutSectionSplitContainer.ResumeLayout(false);
			layoutSectionListToolStrip.ResumeLayout(false);
			layoutSectionListToolStrip.PerformLayout();
			this.stageLayoutOptionsPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.layoutContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton selectButton;
		private System.Windows.Forms.RadioButton fillButton;
		private System.Windows.Forms.RadioButton pencilButton;
		private System.Windows.Forms.RadioButton lineButton;
		private System.Windows.Forms.RadioButton rectangleButton;
		private System.Windows.Forms.RadioButton ovalButton;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox paletteBlue;
		private System.Windows.Forms.PictureBox paletteRed;
		private System.Windows.Forms.PictureBox paletteErase;
		private System.Windows.Forms.PictureBox paletteYellow;
		private System.Windows.Forms.PictureBox paletteRing;
		private System.Windows.Forms.PictureBox paletteBumper;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private OpenTK.GLControl layoutPanel;
		private System.Windows.Forms.PictureBox backSpherePicture;
		private System.Windows.Forms.PictureBox foreSpherePicture;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.Panel toolOptionsPanel;
		private System.Windows.Forms.RadioButton diamondButton;
		private System.Windows.Forms.RadioButton startButton;
		private System.Windows.Forms.ContextMenuStrip layoutContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteOnceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteRepeatingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveSectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteSectionOnceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteSectionRepeatingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flipHorizontallyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flipVerticallyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rotateLeftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rotateRightToolStripMenuItem;
		private System.Windows.Forms.SplitContainer layoutSectionSplitContainer;
		private System.Windows.Forms.ListBox layoutSectionListBox;
		private System.Windows.Forms.ToolStripButton importToolStripButton;
		private System.Windows.Forms.PictureBox layoutSectionPreview;
		private System.Windows.Forms.Panel stageLayoutOptionsPanel;
		private System.Windows.Forms.ToolStripMenuItem saveUndoHistoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insertTextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem replaceFGToBGToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem replaceBGToFGToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem swapFGAndBGToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
		private System.Windows.Forms.PictureBox paletteGreen;
		private System.Windows.Forms.PictureBox palettePink;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.ToolStripMenuItem markBlueGreenRedSpheresAsRingsToolStripMenuItem;
		private System.Windows.Forms.Panel layoutPanelContainer;
	}
}

