using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Hotwire
{
	public partial class MainForm : Form
	{
		private DebugForm _debugForm;
		private Configuration _configuration;
		private Data _data = new Data();
		private HotwirePort _port;

		private bool _settingOrigin;

		public MainForm()
		{
			InitializeComponent();

			panelPreview.Data = _data;

			string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);

			path = Path.Combine(path, "configuration.xml");
			_configuration = LoadData<Configuration>(path);
			if (_configuration == null)
			{
				MessageBox.Show("No previous configuration could be loaded. Please check your settings!");
				_configuration = new Configuration();
			}

			_debugForm = new DebugForm();
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private T LoadData<T>(string path) where T : class
		{
			if (File.Exists(path))
			{
				XmlSerializer serializer = new XmlSerializer(typeof(T));
				try
				{
					using (Stream stream = File.OpenRead(path))
						return (T)serializer.Deserialize(stream);
				}
				catch
				{ }
			}

			return null;
		}

		private void SaveData<T>(string path, T data)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(T));
			try
			{
				using (Stream stream = File.Open(path, FileMode.Create))
					serializer.Serialize(stream, data);
			}
			catch
			{ }
		}

		private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
		{			
			using (ConfigurationDialog dialog = new ConfigurationDialog())
			{
				dialog.Configuration = _configuration;
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "configuration.xml");
					SaveData<Configuration>(path, _configuration);
				}
			}
		}

		private string ShowFileOpenDialog()
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.CheckFileExists = true;
				dialog.RestoreDirectory = true;
				dialog.Filter = "*.dat|*.dat|All files (*.*)|*.*";
				if (dialog.ShowDialog() == DialogResult.OK)
					return dialog.FileName;
			}
			return null;
		}
		private void buttonBrowseLeft_Click(object sender, EventArgs e)
		{
			string path = ShowFileOpenDialog();
			if (!string.IsNullOrEmpty(path))
			{
				textBoxInputDataLeft.Text = path;
				_data.LeftInputPath = path;
				RefreshPreview();
			}
		}

		private void buttonBrowseRight_Click(object sender, EventArgs e)
		{
			string path = ShowFileOpenDialog();
			if (!string.IsNullOrEmpty(path))
			{
				textBoxInputDataRight.Text = path;
				_data.RightInputPath = path;
				RefreshPreview();
			}
		}

		private void RefreshPreview()
		{
			panelPreview.Refresh();
		}

		private void buttonLoadDataLeft_Click(object sender, EventArgs e)
		{
			if (File.Exists(_data.LeftInputPath))
			{
				Profile profile = new Profile();
				profile.FileName = _data.LeftInputPath;
				_data.LeftProfile = profile;
				RefreshPreview();
			}
		}

		private void buttonLoadDataRight_Click(object sender, EventArgs e)
		{
			if (File.Exists(_data.RightInputPath))
			{
				Profile profile = new Profile();
				profile.FileName = _data.RightInputPath;
				_data.RightProfile = profile;
				RefreshPreview();
			}
		}

		private void textBoxInputDataLeft_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (File.Exists(textBoxInputDataLeft.Text))
					_data.LeftInputPath = textBoxInputDataLeft.Text;
			}
			catch
			{ }
		}

		private void textBoxInputDataRight_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (File.Exists(textBoxInputDataRight.Text))
					_data.RightInputPath = textBoxInputDataRight.Text;
			}
			catch
			{ }
		}

		private void textBoxScaleLeft_TextChanged(object sender, EventArgs e)
		{
			double scale;
			if (double.TryParse(textBoxScaleLeft.Text, out scale))
			{
				_data.ScaleLeft = scale;
				RefreshPreview();
			}
		}

		private void textBoxScaleRight_TextChanged(object sender, EventArgs e)
		{
			double scale;
			if (double.TryParse(textBoxScaleRight.Text, out scale))
			{
				_data.ScaleRight = scale;
				RefreshPreview();
			}
		}

		private void textBoxOffsetXLeft_TextChanged(object sender, EventArgs e)
		{
			double offset;
			if (double.TryParse(textBoxOffsetXLeft.Text, out offset))
			{
				_data.LeftXOffset = offset;
				RefreshPreview();
			}
		}

		private void textBoxOffsetXRight_TextChanged(object sender, EventArgs e)
		{
			double offset;
			if (double.TryParse(textBoxOffsetXRight.Text, out offset))
			{
				_data.RightXOffset = offset;
				RefreshPreview();
			}
		}

		private void textBoxOffsetYLeft_TextChanged(object sender, EventArgs e)
		{
			double offset;
			if (double.TryParse(textBoxOffsetYLeft.Text, out offset))
			{
				_data.LeftYOffset = offset;
				RefreshPreview();
			}
		}

		private void textBoxOffsetYRight_TextChanged(object sender, EventArgs e)
		{
			double offset;
			if (double.TryParse(textBoxOffsetYRight.Text, out offset))
			{
				_data.RightYOffset = offset;
				RefreshPreview();
			}
		}

		private void ValidateDouble(object sender, CancelEventArgs e)
		{
			double value;
			e.Cancel = !double.TryParse(((TextBox)sender).Text, out value);
		}

		private void manualMovementsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_port == null || !_port.IsOpen)
				MessageBox.Show("You need to choose the port before using it");
			else
			{
				using (ManualControlDialog dialog = new ManualControlDialog())
				{
					dialog.Port = _port;
					dialog.Configuration = _configuration;
					dialog.ShowDialog();
				}
			}
		}

		private void toolStripMenuItemPortSelection_DropDownOpening(object sender, EventArgs e)
		{
			string[] portNames = SerialPort.GetPortNames();
			toolStripMenuItemPortSelection.DropDownItems.Clear();
			toolStripMenuItemPortSelection.DropDownItems.AddRange(portNames.Select(n => new ToolStripMenuItem(n, null, PortSelected)).ToArray());
		}

		private void PortSelected(object sender, EventArgs e)
		{
			string portName = ((ToolStripMenuItem)sender).Text;
			if (_port != null && _port.IsOpen)
			{
				_port.Close();
				_port.Dispose();
			}
			_port = new HotwirePort(portName, 9600);
			_port.Open();

			_debugForm.Port = _port;
		}

		private void textBoxTotalDisplayScale_TextChanged(object sender, EventArgs e)
		{
			double scale;
			if (double.TryParse(textBoxTotalDisplayScale.Text, out scale))
			{
				_data.ViewScale = scale;
				RefreshPreview();
			}
		}

		private void UpdateOrigin(MouseEventArgs e)
		{
			double minx, maxx, miny, maxy, scale, width, height;
			IEnumerable<Vector2> leftProfile, rightProfile;
			_data.ProcessProfiles(panelPreview.Width, out leftProfile, out rightProfile, out minx, out maxx, out miny, out maxy, out scale, out width, out height);

			double xPoint = (e.X - (panelPreview.Width - width) / 2) / scale + minx;
			double yPoint = ((panelPreview.Height + height / 2) / 2 - e.Y) / scale + miny;

			labelInfo.Text = string.Format("Setting origin at {0} / {1} (Adapt configuration to match lengths!)", xPoint, yPoint);

			_data.Origin = new Vector2(xPoint, yPoint);
			RefreshPreview();
		}

		private void panelPreview_MouseDown(object sender, MouseEventArgs e)
		{
			_settingOrigin = true;
			UpdateOrigin(e);
		}

		private void panelPreview_MouseUp(object sender, MouseEventArgs e)
		{
			_settingOrigin = false;
			UpdateOrigin(e);
		}

		private void panelPreview_MouseMove(object sender, MouseEventArgs e)
		{
			if (_settingOrigin)
				UpdateOrigin(e);
		}

		private void buttonCut_Click(object sender, EventArgs e)
		{
			double minx, maxx, miny, maxy, scale, width, height;
			IEnumerable<Vector2> leftProfile, rightProfile;
			_data.ProcessProfiles(panelPreview.Width, out leftProfile, out rightProfile, out minx, out maxx, out miny, out maxy, out scale, out width, out height);

			HotwireControl control = new HotwireControl(_configuration, _port);
			Vector2 last = null;
			foreach (Vector2 point in leftProfile)
			{
				if (last != null)
				{
					Vector2 vec = point - last;
					control.MoveRelative(vec.x, vec.y);
				}
				last = point;
			}
		}

		private void showHideDebugInformationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (_debugForm.Visible)
				_debugForm.Hide();
			else
				_debugForm.Show();

			showHideDebugInformationToolStripMenuItem.Checked = _debugForm.Visible;
		}
	}
}
