using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Hotwire
{
	public partial class MainForm : Form
	{
		private Configuration _configuration;
		private Data _data = new Data();

		public MainForm()
		{
			InitializeComponent();

			string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);

			path = Path.Combine(path, "configuration.xml");
			_configuration = LoadData<Configuration>(path);
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
				using (Stream stream = File.OpenWrite(path))
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

			}
		}

		private void buttonBrowseRight_Click(object sender, EventArgs e)
		{
			string path = ShowFileOpenDialog();
			if (!string.IsNullOrEmpty(path))
			{
				textBoxInputDataRight.Text = path;
				_data.RightInputPath = path;
			}
		}
	}
}
