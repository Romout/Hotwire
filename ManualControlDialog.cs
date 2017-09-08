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

		private void buttonLBUp_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = (short)trackBarStepsMotorA.Value;
			if (checkBoxMaster.Checked == false)
				Port.MoveMotor(1, steps);
			else
				Port.MoveMotors(steps, steps, steps, steps);

			PortReader();
		}

		private void buttonLBDown_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = (short)(-trackBarStepsMotorA.Value);
			if (checkBoxMaster.Checked == false)
				Port.MoveMotor(1, steps);
			else
				Port.MoveMotors(steps, steps, steps, steps);

			PortReader();
		}

		private void buttonLFUp_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = (short)trackBarStepsMotorB.Value;
			Port.MoveMotor(2, steps);
		}

		private void buttonLFDown_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = (short)(-trackBarStepsMotorB.Value);
			Port.MoveMotor(2, steps);
		}

		private void buttonRBUp_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = (short)trackBarStepsMotorC.Value;
			Port.MoveMotor(3, steps);
		}

		private void buttonRBDown_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = (short)(-trackBarStepsMotorC.Value);
			Port.MoveMotor(3, steps);
		}

		private void buttonRLUp_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = (short)trackBarStepsMotorD.Value;
			Port.MoveMotor(4, 1);
		}

		private void buttonRLDown_Click(object sender, EventArgs e)
		{
			textBox.Text = "";
			short steps = (short)(-trackBarStepsMotorD.Value);
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
			textBox.Text = Port.ReadLine();
		}

		public SerialPort Port { get; set; }

	}
}
