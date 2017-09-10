using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotwire
{
	public partial class ManualControlDialog : Form
	{
		public ManualControlDialog()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			UpdatePositionInfo();
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void buttonToggleConnection_Click(object sender, EventArgs e)
		{
			if (Port.IsOpen)
				Port.Close();
			else
				Port.Open();

			buttonToggleConnection.BackColor = Port.IsOpen ? Color.FromArgb(0, 192, 0) : Color.Red;
		}

		private short Invert(decimal value, bool configuration, bool invert)
		{
			short steps = (short)value;
			if ((invert && !configuration) || (configuration && !invert))
				steps = (short)(-steps);

			return steps;
		}

		private void buttonLBUp_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = Invert(trackBarStepsMotorA.Value, Configuration.ReverseA, false);
			if (checkBoxMaster.Checked == false)
				Port.MoveMotor(1, steps);
			else
				Port.MoveMotors(steps, steps, steps, steps);

			PortReader();
		}

		private void buttonLBDown_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = Invert(trackBarStepsMotorA.Value, Configuration.ReverseA, true);
			if (checkBoxMaster.Checked == false)
				Port.MoveMotor(1, steps);
			else
				Port.MoveMotors(steps, steps, steps, steps);

			PortReader();
		}

		private void buttonLFUp_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = Invert(trackBarStepsMotorB.Value, Configuration.ReverseB, false);
			Port.MoveMotor(2, steps);
		}

		private void buttonLFDown_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = Invert(trackBarStepsMotorB.Value, Configuration.ReverseB, true);
			Port.MoveMotor(2, steps);
		}

		private void buttonRBUp_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = Invert(trackBarStepsMotorC.Value, Configuration.ReverseC, false);
			Port.MoveMotor(3, steps);
		}

		private void buttonRBDown_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = Invert(trackBarStepsMotorC.Value, Configuration.ReverseC, true);
			Port.MoveMotor(3, steps);
		}

		private void buttonRLUp_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = Invert(trackBarStepsMotorD.Value, Configuration.ReverseD, false);
			Port.MoveMotor(4, 1);
		}

		private void buttonRLDown_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = Invert(trackBarStepsMotorD.Value, Configuration.ReverseD, true);
			Port.MoveMotor(4, steps);
		}

		private void buttonLBStop_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			if (checkBoxMaster.Checked)
				Port.StopMotors();
			else
				Port.StopMotor(1);
		}

		private void buttonLFStop_Click(object sender, EventArgs e)
		{
			Port.StopMotor(2);
		}

		private void buttonRBStop_Click(object sender, EventArgs e)
		{
			Port.StopMotor(3);
		}

		private void buttonRLStop_Click(object sender, EventArgs e)
		{
			Port.StopMotor(4);
		}

		private void buttonLeftStop_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			Port.StopMotor(1);
			Port.StopMotor(2);
		}

		private void buttonRightStop_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			Port.StopMotor(3);
			Port.StopMotor(4);
		}

		// TODO: Short timeout
		private void PortReader()
		{
			while (Port.BytesToRead > 0)
			{
				string line = Port.ReadLine();
				if (!string.IsNullOrEmpty(line))
					textBox.Text = line;
			}
		}

		private void MoveRelative(double x, double y)
		{
			x = Configuration.X + x;
			y = Configuration.Y + y;

			MoveAbsolute(x, y);
		}

		private void MoveAbsolute(double x, double y)
		{
			Vector2 vec = new Vector2(x, y) - new Vector2(-Configuration.SpoolDiameter / 2, 0);
			double newLenA = vec.Length;

			vec = new Vector2(x, y) - new Vector2(Configuration.LeftDistance + Configuration.SpoolDiameter / 2, 0);
			double newLenB = vec.Length;

			short stepsA = (short)(Configuration.StepsA * ((newLenA - Configuration.LengthA) / 10.0));
			short stepsB = (short)(Configuration.StepsB * ((newLenB - Configuration.LengthB) / 10.0));

			stepsA = Invert(stepsA, Configuration.ReverseA, true);
			stepsB = Invert(stepsB, Configuration.ReverseB, true);

			// Max-Speed: delay of 800 for now
			short maxSteps = Math.Max(Math.Abs(stepsA), Math.Abs(stepsB));
			int totalTime = maxSteps * 800;

			short delayA = (short)(Math.Abs(totalTime / stepsA));
			short delayB = (short)(Math.Abs(totalTime / stepsB));

			//Port.SetStepDelays(delayA, delayB, 0, 0);
			
			Port.MoveMotors(stepsA, stepsB, 0, 0);
			PortReader();

			Configuration.X = x;
			Configuration.Y = y;
			Configuration.LengthA = newLenA;
			Configuration.LengthB = newLenB;

			UpdatePositionInfo();
		}

		private void UpdatePositionInfo()
		{
			labelPositionLeft.Text = string.Format("X: {0:g5}   Y: {1:g5}   Length A: {2:g5}   Length B: {3:g5}", Configuration.X, Configuration.Y, Configuration.LengthA, Configuration.LengthB);
		}

		private void buttonLeftUp_Click(object sender, EventArgs e)
		{
			MoveRelative(0, -10);
		}

		private void buttonLeftDown_Click(object sender, EventArgs e)
		{
			MoveRelative(0, 10);
		}

		private void buttonLeftLeft_Click(object sender, EventArgs e)
		{
			MoveRelative(-10, 0);
		}

		private void buttonLeftRight_Click(object sender, EventArgs e)
		{
			MoveRelative(10, 0);
		}

		private void buttonIsAtOrigin_Click(object sender, EventArgs e)
		{
			Configuration.LengthA = Configuration.OriginA;
			Configuration.LengthB = Configuration.OriginB;
			Configuration.LengthC = Configuration.OriginC;
			Configuration.LengthD = Configuration.OriginD;

			Configuration.X = Configuration.OriginOffsetX;
			Configuration.Y = Configuration.OriginOffsetY;

			UpdatePositionInfo();
		}

		public SerialPort Port { get; set; }

		public Configuration Configuration { get; set; }

		private void textBox_MouseDown(object sender, MouseEventArgs e)
		{
			PortReader();
		}
	}
}
