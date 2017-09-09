namespace Hotwire
{
	partial class ConfigurationDialog
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
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxLeftDistance = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxRightDistance = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxFrontDistance = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxSpoolDiameter = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxBackDistance = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.checkBoxReverseA = new System.Windows.Forms.CheckBox();
			this.checkBoxReverseB = new System.Windows.Forms.CheckBox();
			this.checkBoxReverseC = new System.Windows.Forms.CheckBox();
			this.checkBoxReverseD = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Location = new System.Drawing.Point(469, 341);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 0;
			this.buttonCancel.Text = "&Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOk.Location = new System.Drawing.Point(388, 341);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "&OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(288, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(256, 300);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Left Distance:";
			// 
			// textBoxLeftDistance
			// 
			this.textBoxLeftDistance.Location = new System.Drawing.Point(128, 34);
			this.textBoxLeftDistance.Name = "textBoxLeftDistance";
			this.textBoxLeftDistance.Size = new System.Drawing.Size(100, 20);
			this.textBoxLeftDistance.TabIndex = 3;
			this.textBoxLeftDistance.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumberValidator);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Right Distance:";
			// 
			// textBoxRightDistance
			// 
			this.textBoxRightDistance.Location = new System.Drawing.Point(128, 60);
			this.textBoxRightDistance.Name = "textBoxRightDistance";
			this.textBoxRightDistance.Size = new System.Drawing.Size(100, 20);
			this.textBoxRightDistance.TabIndex = 3;
			this.textBoxRightDistance.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumberValidator);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Front Distance:";
			// 
			// textBoxFrontDistance
			// 
			this.textBoxFrontDistance.Location = new System.Drawing.Point(128, 86);
			this.textBoxFrontDistance.Name = "textBoxFrontDistance";
			this.textBoxFrontDistance.Size = new System.Drawing.Size(100, 20);
			this.textBoxFrontDistance.TabIndex = 3;
			this.textBoxFrontDistance.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumberValidator);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Spool Diameter:";
			// 
			// textBoxSpoolDiameter
			// 
			this.textBoxSpoolDiameter.Location = new System.Drawing.Point(128, 138);
			this.textBoxSpoolDiameter.Name = "textBoxSpoolDiameter";
			this.textBoxSpoolDiameter.Size = new System.Drawing.Size(100, 20);
			this.textBoxSpoolDiameter.TabIndex = 3;
			this.textBoxSpoolDiameter.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumberValidator);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(234, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "mm";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(234, 63);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "mm";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(234, 89);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "mm";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(234, 141);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "mm";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(29, 115);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 13);
			this.label9.TabIndex = 2;
			this.label9.Text = "Back Distance:";
			// 
			// textBoxBackDistance
			// 
			this.textBoxBackDistance.Location = new System.Drawing.Point(128, 112);
			this.textBoxBackDistance.Name = "textBoxBackDistance";
			this.textBoxBackDistance.Size = new System.Drawing.Size(100, 20);
			this.textBoxBackDistance.TabIndex = 3;
			this.textBoxBackDistance.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumberValidator);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(234, 115);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(23, 13);
			this.label10.TabIndex = 4;
			this.label10.Text = "mm";
			// 
			// checkBoxReverseA
			// 
			this.checkBoxReverseA.AutoSize = true;
			this.checkBoxReverseA.Location = new System.Drawing.Point(32, 184);
			this.checkBoxReverseA.Name = "checkBoxReverseA";
			this.checkBoxReverseA.Size = new System.Drawing.Size(158, 17);
			this.checkBoxReverseA.TabIndex = 5;
			this.checkBoxReverseA.Text = "Reverse Motor A (left/back)";
			this.checkBoxReverseA.UseVisualStyleBackColor = true;
			// 
			// checkBoxReverseB
			// 
			this.checkBoxReverseB.AutoSize = true;
			this.checkBoxReverseB.Location = new System.Drawing.Point(32, 207);
			this.checkBoxReverseB.Name = "checkBoxReverseB";
			this.checkBoxReverseB.Size = new System.Drawing.Size(155, 17);
			this.checkBoxReverseB.TabIndex = 5;
			this.checkBoxReverseB.Text = "Reverse Motor B (left/front)";
			this.checkBoxReverseB.UseVisualStyleBackColor = true;
			// 
			// checkBoxReverseC
			// 
			this.checkBoxReverseC.AutoSize = true;
			this.checkBoxReverseC.Location = new System.Drawing.Point(32, 230);
			this.checkBoxReverseC.Name = "checkBoxReverseC";
			this.checkBoxReverseC.Size = new System.Drawing.Size(164, 17);
			this.checkBoxReverseC.TabIndex = 5;
			this.checkBoxReverseC.Text = "Reverse Motor C (right/back)";
			this.checkBoxReverseC.UseVisualStyleBackColor = true;
			// 
			// checkBoxReverseD
			// 
			this.checkBoxReverseD.AutoSize = true;
			this.checkBoxReverseD.Location = new System.Drawing.Point(32, 253);
			this.checkBoxReverseD.Name = "checkBoxReverseD";
			this.checkBoxReverseD.Size = new System.Drawing.Size(162, 17);
			this.checkBoxReverseD.TabIndex = 5;
			this.checkBoxReverseD.Text = "Reverse Motor D (right/front)";
			this.checkBoxReverseD.UseVisualStyleBackColor = true;
			// 
			// ConfigurationDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 376);
			this.Controls.Add(this.checkBoxReverseD);
			this.Controls.Add(this.checkBoxReverseC);
			this.Controls.Add(this.checkBoxReverseB);
			this.Controls.Add(this.checkBoxReverseA);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxSpoolDiameter);
			this.Controls.Add(this.textBoxBackDistance);
			this.Controls.Add(this.textBoxFrontDistance);
			this.Controls.Add(this.textBoxRightDistance);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxLeftDistance);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.buttonCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfigurationDialog";
			this.Text = "Configuration";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxLeftDistance;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxRightDistance;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxFrontDistance;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxSpoolDiameter;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxBackDistance;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.CheckBox checkBoxReverseA;
		private System.Windows.Forms.CheckBox checkBoxReverseB;
		private System.Windows.Forms.CheckBox checkBoxReverseC;
		private System.Windows.Forms.CheckBox checkBoxReverseD;
	}
}