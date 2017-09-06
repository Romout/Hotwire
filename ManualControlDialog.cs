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
			Port.MoveMotor('a', 100);
			PortReader();
		}

		private void buttonLBDown_Click(object sender, EventArgs e)
		{
			Port.MoveMotor('a', -100);
			PortReader();
		}

		private void buttonLFUp_Click(object sender, EventArgs e)
		{
			Port.MoveMotor('b', 1);
		}

		private void buttonLFDown_Click(object sender, EventArgs e)
		{
			Port.MoveMotor('b', -1);
		}

		private void buttonRBUp_Click(object sender, EventArgs e)
		{
			Port.MoveMotor('c', 1);
		}

		private void buttonRBDown_Click(object sender, EventArgs e)
		{
			Port.MoveMotor('c', -1);
		}

		private void buttonRLUp_Click(object sender, EventArgs e)
		{
			Port.MoveMotor('d', 1);
		}

		private void buttonRLDown_Click(object sender, EventArgs e)
		{
			Port.MoveMotor('d', -1);
		}

		private void PortReader()
		{
			textBox.Text = Port.ReadLine();
		}

		public SerialPort Port { get; set; }
	}
}
