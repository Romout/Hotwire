namespace Hotwire
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemPortSelection = new System.Windows.Forms.ToolStripMenuItem();
			this.cOM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manualMovementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showHideDebugInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel3 = new System.Windows.Forms.Panel();
			this.buttonLoadDataRight = new System.Windows.Forms.Button();
			this.textBoxOffsetYRight = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxOffsetXRight = new System.Windows.Forms.TextBox();
			this.textBoxScaleRight = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.buttonBrowseRight = new System.Windows.Forms.Button();
			this.textBoxInputDataRight = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.buttonLoadDataLeft = new System.Windows.Forms.Button();
			this.textBoxOffsetYLeft = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBoxOffsetXLeft = new System.Windows.Forms.TextBox();
			this.textBoxScaleLeft = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonBrowseLeft = new System.Windows.Forms.Button();
			this.textBoxInputDataLeft = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonCut = new System.Windows.Forms.Button();
			this.labelInfo = new System.Windows.Forms.Label();
			this.textBoxTotalDisplayScale = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panelPreview = new Hotwire.PreviewPanel();
			this.menuStrip1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hardwareToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(934, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.openToolStripMenuItem.Text = "&Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItem2.Text = "&Save";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItem3.Text = "S&ave as...";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.closeToolStripMenuItem.Text = "&Close";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
			this.exitToolStripMenuItem.Text = "&Exit";
			// 
			// hardwareToolStripMenuItem
			// 
			this.hardwareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem,
            this.toolStripMenuItemPortSelection,
            this.manualMovementsToolStripMenuItem,
            this.showHideDebugInformationToolStripMenuItem});
			this.hardwareToolStripMenuItem.Name = "hardwareToolStripMenuItem";
			this.hardwareToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.hardwareToolStripMenuItem.Text = "&Hardware";
			// 
			// configurationToolStripMenuItem
			// 
			this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
			this.configurationToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.configurationToolStripMenuItem.Text = "&Configuration...";
			this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
			// 
			// toolStripMenuItemPortSelection
			// 
			this.toolStripMenuItemPortSelection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOM1ToolStripMenuItem});
			this.toolStripMenuItemPortSelection.Name = "toolStripMenuItemPortSelection";
			this.toolStripMenuItemPortSelection.Size = new System.Drawing.Size(237, 22);
			this.toolStripMenuItemPortSelection.Text = "Port Selection";
			this.toolStripMenuItemPortSelection.DropDownOpening += new System.EventHandler(this.toolStripMenuItemPortSelection_DropDownOpening);
			// 
			// cOM1ToolStripMenuItem
			// 
			this.cOM1ToolStripMenuItem.Name = "cOM1ToolStripMenuItem";
			this.cOM1ToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
			this.cOM1ToolStripMenuItem.Text = "COM1";
			// 
			// manualMovementsToolStripMenuItem
			// 
			this.manualMovementsToolStripMenuItem.Name = "manualMovementsToolStripMenuItem";
			this.manualMovementsToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.manualMovementsToolStripMenuItem.Text = "Manual Movements...";
			this.manualMovementsToolStripMenuItem.Click += new System.EventHandler(this.manualMovementsToolStripMenuItem_Click);
			// 
			// showHideDebugInformationToolStripMenuItem
			// 
			this.showHideDebugInformationToolStripMenuItem.Name = "showHideDebugInformationToolStripMenuItem";
			this.showHideDebugInformationToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
			this.showHideDebugInformationToolStripMenuItem.Text = "Show/Hide Debug Information";
			this.showHideDebugInformationToolStripMenuItem.Click += new System.EventHandler(this.showHideDebugInformationToolStripMenuItem_Click);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.buttonLoadDataRight);
			this.panel3.Controls.Add(this.textBoxOffsetYRight);
			this.panel3.Controls.Add(this.label8);
			this.panel3.Controls.Add(this.textBoxOffsetXRight);
			this.panel3.Controls.Add(this.textBoxScaleRight);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.buttonBrowseRight);
			this.panel3.Controls.Add(this.textBoxInputDataRight);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(470, 3);
			this.panel3.MinimumSize = new System.Drawing.Size(175, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(461, 101);
			this.panel3.TabIndex = 1;
			// 
			// buttonLoadDataRight
			// 
			this.buttonLoadDataRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLoadDataRight.Location = new System.Drawing.Point(339, 51);
			this.buttonLoadDataRight.Name = "buttonLoadDataRight";
			this.buttonLoadDataRight.Size = new System.Drawing.Size(117, 23);
			this.buttonLoadDataRight.TabIndex = 14;
			this.buttonLoadDataRight.Text = "Load Data";
			this.buttonLoadDataRight.UseVisualStyleBackColor = true;
			this.buttonLoadDataRight.Click += new System.EventHandler(this.buttonLoadDataRight_Click);
			// 
			// textBoxOffsetYRight
			// 
			this.textBoxOffsetYRight.Location = new System.Drawing.Point(276, 53);
			this.textBoxOffsetYRight.Name = "textBoxOffsetYRight";
			this.textBoxOffsetYRight.Size = new System.Drawing.Size(60, 20);
			this.textBoxOffsetYRight.TabIndex = 13;
			this.textBoxOffsetYRight.Text = "0";
			this.textBoxOffsetYRight.TextChanged += new System.EventHandler(this.textBoxOffsetYRight_TextChanged);
			this.textBoxOffsetYRight.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateDouble);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(256, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(17, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "Y:";
			// 
			// textBoxOffsetXRight
			// 
			this.textBoxOffsetXRight.Location = new System.Drawing.Point(190, 53);
			this.textBoxOffsetXRight.Name = "textBoxOffsetXRight";
			this.textBoxOffsetXRight.Size = new System.Drawing.Size(60, 20);
			this.textBoxOffsetXRight.TabIndex = 10;
			this.textBoxOffsetXRight.Text = "0";
			this.textBoxOffsetXRight.TextChanged += new System.EventHandler(this.textBoxOffsetXRight_TextChanged);
			this.textBoxOffsetXRight.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateDouble);
			// 
			// textBoxScaleRight
			// 
			this.textBoxScaleRight.Location = new System.Drawing.Point(50, 53);
			this.textBoxScaleRight.Name = "textBoxScaleRight";
			this.textBoxScaleRight.Size = new System.Drawing.Size(72, 20);
			this.textBoxScaleRight.TabIndex = 11;
			this.textBoxScaleRight.Text = "1,0";
			this.textBoxScaleRight.TextChanged += new System.EventHandler(this.textBoxScaleRight_TextChanged);
			this.textBoxScaleRight.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateDouble);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(136, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Offset X:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(9, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(37, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Scale:";
			// 
			// buttonBrowseRight
			// 
			this.buttonBrowseRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseRight.Location = new System.Drawing.Point(411, 22);
			this.buttonBrowseRight.Name = "buttonBrowseRight";
			this.buttonBrowseRight.Size = new System.Drawing.Size(45, 23);
			this.buttonBrowseRight.TabIndex = 6;
			this.buttonBrowseRight.Text = "...";
			this.buttonBrowseRight.UseVisualStyleBackColor = true;
			this.buttonBrowseRight.Click += new System.EventHandler(this.buttonBrowseRight_Click);
			// 
			// textBoxInputDataRight
			// 
			this.textBoxInputDataRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxInputDataRight.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBoxInputDataRight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.textBoxInputDataRight.Location = new System.Drawing.Point(50, 24);
			this.textBoxInputDataRight.Name = "textBoxInputDataRight";
			this.textBoxInputDataRight.Size = new System.Drawing.Size(355, 20);
			this.textBoxInputDataRight.TabIndex = 5;
			this.textBoxInputDataRight.TextChanged += new System.EventHandler(this.textBoxInputDataRight_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Data:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(459, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Right Input";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.buttonLoadDataLeft);
			this.panel2.Controls.Add(this.textBoxOffsetYLeft);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.textBoxOffsetXLeft);
			this.panel2.Controls.Add(this.textBoxScaleLeft);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.buttonBrowseLeft);
			this.panel2.Controls.Add(this.textBoxInputDataLeft);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.MinimumSize = new System.Drawing.Size(333, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(461, 101);
			this.panel2.TabIndex = 0;
			// 
			// buttonLoadDataLeft
			// 
			this.buttonLoadDataLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLoadDataLeft.Location = new System.Drawing.Point(337, 51);
			this.buttonLoadDataLeft.Name = "buttonLoadDataLeft";
			this.buttonLoadDataLeft.Size = new System.Drawing.Size(117, 23);
			this.buttonLoadDataLeft.TabIndex = 8;
			this.buttonLoadDataLeft.Text = "Load Data";
			this.buttonLoadDataLeft.UseVisualStyleBackColor = true;
			this.buttonLoadDataLeft.Click += new System.EventHandler(this.buttonLoadDataLeft_Click);
			// 
			// textBoxOffsetYLeft
			// 
			this.textBoxOffsetYLeft.Location = new System.Drawing.Point(274, 53);
			this.textBoxOffsetYLeft.Name = "textBoxOffsetYLeft";
			this.textBoxOffsetYLeft.Size = new System.Drawing.Size(60, 20);
			this.textBoxOffsetYLeft.TabIndex = 7;
			this.textBoxOffsetYLeft.Text = "0";
			this.textBoxOffsetYLeft.TextChanged += new System.EventHandler(this.textBoxOffsetYLeft_TextChanged);
			this.textBoxOffsetYLeft.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateDouble);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(251, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(17, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Y:";
			// 
			// textBoxOffsetXLeft
			// 
			this.textBoxOffsetXLeft.Location = new System.Drawing.Point(185, 53);
			this.textBoxOffsetXLeft.Name = "textBoxOffsetXLeft";
			this.textBoxOffsetXLeft.Size = new System.Drawing.Size(60, 20);
			this.textBoxOffsetXLeft.TabIndex = 5;
			this.textBoxOffsetXLeft.Text = "0";
			this.textBoxOffsetXLeft.TextChanged += new System.EventHandler(this.textBoxOffsetXLeft_TextChanged);
			this.textBoxOffsetXLeft.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateDouble);
			// 
			// textBoxScaleLeft
			// 
			this.textBoxScaleLeft.Location = new System.Drawing.Point(46, 53);
			this.textBoxScaleLeft.Name = "textBoxScaleLeft";
			this.textBoxScaleLeft.Size = new System.Drawing.Size(72, 20);
			this.textBoxScaleLeft.TabIndex = 5;
			this.textBoxScaleLeft.Text = "1,0";
			this.textBoxScaleLeft.TextChanged += new System.EventHandler(this.textBoxScaleLeft_TextChanged);
			this.textBoxScaleLeft.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateDouble);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(131, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "Offset X:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 56);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Scale:";
			// 
			// buttonBrowseLeft
			// 
			this.buttonBrowseLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowseLeft.Location = new System.Drawing.Point(409, 22);
			this.buttonBrowseLeft.Name = "buttonBrowseLeft";
			this.buttonBrowseLeft.Size = new System.Drawing.Size(45, 23);
			this.buttonBrowseLeft.TabIndex = 3;
			this.buttonBrowseLeft.Text = "...";
			this.buttonBrowseLeft.UseVisualStyleBackColor = true;
			this.buttonBrowseLeft.Click += new System.EventHandler(this.buttonBrowseLeft_Click);
			// 
			// textBoxInputDataLeft
			// 
			this.textBoxInputDataLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxInputDataLeft.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBoxInputDataLeft.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.textBoxInputDataLeft.Location = new System.Drawing.Point(46, 24);
			this.textBoxInputDataLeft.Name = "textBoxInputDataLeft";
			this.textBoxInputDataLeft.Size = new System.Drawing.Size(357, 20);
			this.textBoxInputDataLeft.TabIndex = 2;
			this.textBoxInputDataLeft.TextChanged += new System.EventHandler(this.textBoxInputDataLeft_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(5, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Data:";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(459, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Left Input";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(934, 107);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.buttonCut);
			this.panel1.Controls.Add(this.labelInfo);
			this.panel1.Controls.Add(this.textBoxTotalDisplayScale);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 131);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(934, 32);
			this.panel1.TabIndex = 5;
			// 
			// buttonCut
			// 
			this.buttonCut.Location = new System.Drawing.Point(854, 3);
			this.buttonCut.Name = "buttonCut";
			this.buttonCut.Size = new System.Drawing.Size(75, 23);
			this.buttonCut.TabIndex = 4;
			this.buttonCut.Text = "Cut!";
			this.buttonCut.UseVisualStyleBackColor = true;
			this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
			// 
			// labelInfo
			// 
			this.labelInfo.AutoSize = true;
			this.labelInfo.Location = new System.Drawing.Point(280, 8);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(210, 13);
			this.labelInfo.TabIndex = 3;
			this.labelInfo.Text = "Left: width / height      Right: width / height";
			// 
			// textBoxTotalDisplayScale
			// 
			this.textBoxTotalDisplayScale.Location = new System.Drawing.Point(115, 5);
			this.textBoxTotalDisplayScale.Name = "textBoxTotalDisplayScale";
			this.textBoxTotalDisplayScale.Size = new System.Drawing.Size(82, 20);
			this.textBoxTotalDisplayScale.TabIndex = 1;
			this.textBoxTotalDisplayScale.TextChanged += new System.EventHandler(this.textBoxTotalDisplayScale_TextChanged);
			this.textBoxTotalDisplayScale.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateDouble);
			// 
			// label11
			// 
			this.label11.Dock = System.Windows.Forms.DockStyle.Left;
			this.label11.Location = new System.Drawing.Point(0, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(109, 30);
			this.label11.TabIndex = 0;
			this.label11.Text = "Total Display Scale:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelPreview
			// 
			this.panelPreview.Data = null;
			this.panelPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPreview.Location = new System.Drawing.Point(0, 163);
			this.panelPreview.Name = "panelPreview";
			this.panelPreview.Size = new System.Drawing.Size(934, 248);
			this.panelPreview.TabIndex = 3;
			this.panelPreview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPreview_MouseDown);
			this.panelPreview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPreview_MouseMove);
			this.panelPreview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPreview_MouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 411);
			this.Controls.Add(this.panelPreview);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(950, 450);
			this.Name = "MainForm";
			this.Text = "Hotwire";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hardwareToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonBrowseRight;
		private System.Windows.Forms.TextBox textBoxInputDataRight;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonBrowseLeft;
		private System.Windows.Forms.TextBox textBoxInputDataLeft;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxOffsetYRight;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxOffsetXRight;
		private System.Windows.Forms.TextBox textBoxScaleRight;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxOffsetYLeft;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxOffsetXLeft;
		private System.Windows.Forms.TextBox textBoxScaleLeft;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button buttonLoadDataRight;
		private System.Windows.Forms.Button buttonLoadDataLeft;
		private PreviewPanel panelPreview;
		private System.Windows.Forms.ToolStripMenuItem manualMovementsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPortSelection;
		private System.Windows.Forms.ToolStripMenuItem cOM1ToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxTotalDisplayScale;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.Button buttonCut;
		private System.Windows.Forms.ToolStripMenuItem showHideDebugInformationToolStripMenuItem;
	}
}

