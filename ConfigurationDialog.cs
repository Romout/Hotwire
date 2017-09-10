using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotwire
{
	public partial class ConfigurationDialog : Form
	{
		Regex numbersOnly = new Regex(@"^[0-9]*(\.[0-9]+)?$", RegexOptions.Compiled);
		public ConfigurationDialog()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (Configuration == null)
				Configuration = new Configuration();

			textBoxLeftDistance.Text = Configuration.LeftDistance.ToString(CultureInfo.InvariantCulture);
			textBoxRightDistance.Text = Configuration.RightDistance.ToString(CultureInfo.InvariantCulture);
			textBoxFrontDistance.Text = Configuration.FrontDistance.ToString(CultureInfo.InvariantCulture);
			textBoxBackDistance.Text = Configuration.BackDistance.ToString(CultureInfo.InvariantCulture);
			textBoxSpoolDiameter.Text = Configuration.SpoolDiameter.ToString(CultureInfo.InvariantCulture);

			textBoxOriginA.Text = Configuration.OriginA.ToString(CultureInfo.InvariantCulture);
			textBoxOriginB.Text = Configuration.OriginB.ToString(CultureInfo.InvariantCulture);
			textBoxOriginC.Text = Configuration.OriginC.ToString(CultureInfo.InvariantCulture);
			textBoxOriginD.Text = Configuration.OriginD.ToString(CultureInfo.InvariantCulture);

			textBoxXOffset.Text = Configuration.OriginOffsetX.ToString(CultureInfo.InvariantCulture);
			textBoxYOffset.Text = Configuration.OriginOffsetY.ToString(CultureInfo.InvariantCulture);

			textBoxStepsMotorA.Text = Configuration.StepsA.ToString(CultureInfo.InvariantCulture);
			textBoxStepsMotorB.Text = Configuration.StepsB.ToString(CultureInfo.InvariantCulture);
			textBoxStepsMotorC.Text = Configuration.StepsC.ToString(CultureInfo.InvariantCulture);
			textBoxStepsMotorD.Text = Configuration.StepsD.ToString(CultureInfo.InvariantCulture);

			checkBoxReverseA.Checked = Configuration.ReverseA;
			checkBoxReverseB.Checked = Configuration.ReverseB;
			checkBoxReverseC.Checked = Configuration.ReverseC;
			checkBoxReverseD.Checked = Configuration.ReverseD;
		}

		private void textBoxNumberValidator(object sender, CancelEventArgs e)
		{
			e.Cancel = !numbersOnly.Match(textBoxLeftDistance.Text).Success;
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			Configuration.LeftDistance = double.Parse(textBoxLeftDistance.Text, CultureInfo.InvariantCulture);
			Configuration.RightDistance = double.Parse(textBoxRightDistance.Text, CultureInfo.InvariantCulture);
			Configuration.FrontDistance = double.Parse(textBoxFrontDistance.Text, CultureInfo.InvariantCulture);
			Configuration.BackDistance = double.Parse(textBoxBackDistance.Text, CultureInfo.InvariantCulture);
			Configuration.SpoolDiameter = double.Parse(textBoxSpoolDiameter.Text, CultureInfo.InvariantCulture);

			Configuration.OriginA = double.Parse(textBoxOriginA.Text, CultureInfo.InvariantCulture);
			Configuration.OriginB = double.Parse(textBoxOriginB.Text, CultureInfo.InvariantCulture);
			Configuration.OriginC = double.Parse(textBoxOriginC.Text, CultureInfo.InvariantCulture);
			Configuration.OriginD = double.Parse(textBoxOriginD.Text, CultureInfo.InvariantCulture);

			Configuration.OriginOffsetX = double.Parse(textBoxXOffset.Text, CultureInfo.InvariantCulture);
			Configuration.OriginOffsetY = double.Parse(textBoxYOffset.Text, CultureInfo.InvariantCulture);

			Configuration.StepsA = double.Parse(textBoxStepsMotorA.Text, CultureInfo.InvariantCulture);
			Configuration.StepsB = double.Parse(textBoxStepsMotorB.Text, CultureInfo.InvariantCulture);
			Configuration.StepsC = double.Parse(textBoxStepsMotorC.Text, CultureInfo.InvariantCulture);
			Configuration.StepsD = double.Parse(textBoxStepsMotorD.Text, CultureInfo.InvariantCulture);

			Configuration.ReverseA = checkBoxReverseA.Checked;
			Configuration.ReverseB = checkBoxReverseB.Checked;
			Configuration.ReverseC = checkBoxReverseC.Checked;
			Configuration.ReverseD = checkBoxReverseD.Checked;

			DialogResult = DialogResult.OK;
			Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}


		public Configuration Configuration
		{
			get; set;
		}
	}
}