using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotwire
{
	public partial class DebugForm : Form
	{
		private HotwirePort _port;

		public DebugForm()
		{
			InitializeComponent();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			e.Cancel = true;

			Hide();
		}

		public HotwirePort Port
		{
			get
			{
				return _port;
			}
			set
			{
				if (_port != null)
					_port.DataAvailable -= Port_DataAvailable;

				_port = value;

				if (_port != null)
					_port.DataAvailable += Port_DataAvailable;
			}
		}

		private void Port_DataAvailable()
		{
			if (InvokeRequired)
				BeginInvoke(new Action(Port_DataAvailable));
			else
			{
				string text = ASCIIEncoding.ASCII.GetString(_port.GetData());
				textBox.Text = text;
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Hide();
		}

		private void buttonClear_Click(object sender, EventArgs e)
		{
			_port.ClearData();
			textBox.Text = "";
		}
	}
}