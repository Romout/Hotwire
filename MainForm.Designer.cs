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
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel3 = new System.Windows.Forms.Panel();
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
			this.buttonLoadDataLeft = new System.Windows.Forms.Button();
			this.buttonLoadDataRight = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hardwareToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(936, 24);
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
            this.configurationToolStripMenuItem});
			this.hardwareToolStripMenuItem.Name = "hardwareToolStripMenuItem";
			this.hardwareToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.hardwareToolStripMenuItem.Text = "&Hardware";
			// 
			// configurationToolStripMenuItem
			// 
			this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
			this.configurationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.configurationToolStripMenuItem.Text = "&Configuration...";
			this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.splitter1);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(936, 100);
			this.panel1.TabIndex = 2;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(464, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 100);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
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
			this.panel3.Location = new System.Drawing.Point(464, 0);
			this.panel3.MinimumSize = new System.Drawing.Size(175, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(472, 100);
			this.panel3.TabIndex = 1;
			// 
			// textBoxOffsetYRight
			// 
			this.textBoxOffsetYRight.Location = new System.Drawing.Point(279, 53);
			this.textBoxOffsetYRight.Name = "textBoxOffsetYRight";
			this.textBoxOffsetYRight.Size = new System.Drawing.Size(60, 20);
			this.textBoxOffsetYRight.TabIndex = 13;
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
			// 
			// textBoxScaleRight
			// 
			this.textBoxScaleRight.Location = new System.Drawing.Point(50, 53);
			this.textBoxScaleRight.Name = "textBoxScaleRight";
			this.textBoxScaleRight.Size = new System.Drawing.Size(72, 20);
			this.textBoxScaleRight.TabIndex = 11;
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
			this.buttonBrowseRight.Location = new System.Drawing.Point(422, 22);
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
			this.textBoxInputDataRight.Size = new System.Drawing.Size(366, 20);
			this.textBoxInputDataRight.TabIndex = 5;
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
			this.label2.Size = new System.Drawing.Size(470, 20);
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
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.MinimumSize = new System.Drawing.Size(333, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(464, 100);
			this.panel2.TabIndex = 0;
			// 
			// textBoxOffsetYLeft
			// 
			this.textBoxOffsetYLeft.Location = new System.Drawing.Point(274, 53);
			this.textBoxOffsetYLeft.Name = "textBoxOffsetYLeft";
			this.textBoxOffsetYLeft.Size = new System.Drawing.Size(60, 20);
			this.textBoxOffsetYLeft.TabIndex = 7;
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
			// 
			// textBoxScaleLeft
			// 
			this.textBoxScaleLeft.Location = new System.Drawing.Point(46, 53);
			this.textBoxScaleLeft.Name = "textBoxScaleLeft";
			this.textBoxScaleLeft.Size = new System.Drawing.Size(72, 20);
			this.textBoxScaleLeft.TabIndex = 5;
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
			this.buttonBrowseLeft.Location = new System.Drawing.Point(412, 22);
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
			this.textBoxInputDataLeft.Size = new System.Drawing.Size(360, 20);
			this.textBoxInputDataLeft.TabIndex = 2;
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
			this.label1.Size = new System.Drawing.Size(462, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Left Input";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonLoadDataLeft
			// 
			this.buttonLoadDataLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLoadDataLeft.Location = new System.Drawing.Point(340, 51);
			this.buttonLoadDataLeft.Name = "buttonLoadDataLeft";
			this.buttonLoadDataLeft.Size = new System.Drawing.Size(117, 23);
			this.buttonLoadDataLeft.TabIndex = 8;
			this.buttonLoadDataLeft.Text = "Load Data";
			this.buttonLoadDataLeft.UseVisualStyleBackColor = true;
			// 
			// buttonLoadDataRight
			// 
			this.buttonLoadDataRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLoadDataRight.Location = new System.Drawing.Point(350, 51);
			this.buttonLoadDataRight.Name = "buttonLoadDataRight";
			this.buttonLoadDataRight.Size = new System.Drawing.Size(117, 23);
			this.buttonLoadDataRight.TabIndex = 14;
			this.buttonLoadDataRight.Text = "Load Data";
			this.buttonLoadDataRight.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 509);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Hotwire";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
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
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
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
	}
}

