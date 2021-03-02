using System;
using System.Drawing;
using System.Windows.Forms;

namespace qpv_plugins
{
	public partial class BlurRegionForm : Form
	{
		public Bitmap Result;

		private Bitmap originalImage;
		private bool previewUpdated = false;
		private Rectangle selection;

		public BlurRegionForm(Bitmap bmp, Rectangle selection)
		{
			originalImage = bmp;
			this.selection = selection;
			InitializeComponent();

			radiusSlider.Value = Properties.Settings.Default.BlurRadius;
			typeComboBox.SelectedIndex = Properties.Settings.Default.BlurType;

			pictureBox1.Image = bmp;
		}

		private void previewBtn_Click(object sender, EventArgs e)
		{
			if (typeComboBox.SelectedIndex == 0)
			{
				GaussianBlur gb = new GaussianBlur(originalImage as Bitmap);
				Result = gb.Process(radiusSlider.Value);
				pictureBox1.Image = Result;
			}
			else
			{
				Result = originalImage;
				Result = PixelateMan.ProcessPixelate(originalImage, radiusSlider.Value, selection);
				pictureBox1.Image = Result;
			}
			previewUpdated = true;
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			saveSettings();
			if (!previewUpdated)
			{
				if (typeComboBox.SelectedIndex == 0)
				{
					GaussianBlur gb = new GaussianBlur(originalImage as Bitmap);
					Result = gb.Process(radiusSlider.Value);
					pictureBox1.Image = Result;
				}
				else
				{
					Result = PixelateMan.ProcessPixelate(originalImage, radiusSlider.Value, selection);
					pictureBox1.Image = Result;
				}
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void radiusSlider_ValueChanged(object sender, EventArgs e)
		{
			previewUpdated = false;
			radiusLabel.Text = "Radius: " + radiusSlider.Value;
		}

		private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			previewUpdated = false;
		}

		private void resetBtn_Click(object sender, EventArgs e)
		{
			radiusSlider.Value = 5;
			typeComboBox.SelectedIndex = 0;
		}

		private void saveSettings()
		{
			Properties.Settings.Default.BlurRadius = radiusSlider.Value;
			Properties.Settings.Default.BlurType = typeComboBox.SelectedIndex;
			Properties.Settings.Default.Save();
		}
	}
}
