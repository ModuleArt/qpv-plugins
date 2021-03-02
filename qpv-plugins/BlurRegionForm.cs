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
			if (typeComboBox.SelectedIndex == 0) UpdateBlurResult();
			else UpdatePixelateResult();
			pictureBox1.Image = Result;
			previewUpdated = true;
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			saveSettings();
			if (!previewUpdated)
			{
				if (typeComboBox.SelectedIndex == 0) UpdateBlurResult();
				else UpdatePixelateResult();
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void UpdateBlurResult()
		{
			Bitmap selBmp = originalImage.Clone(selection, originalImage.PixelFormat);
			GaussianBlur gb = new GaussianBlur(selBmp);
			selBmp = gb.Process(radiusSlider.Value);
			Result = originalImage.Clone(new Rectangle(0, 0, originalImage.Width, originalImage.Height), originalImage.PixelFormat);
			using (Graphics g = Graphics.FromImage(Result))
			{
				g.DrawImage(selBmp, selection);
			}
			pictureBox1.Image = Result;
		}

		private void UpdatePixelateResult()
		{
			Result = PixelateMan.ProcessPixelate(originalImage, radiusSlider.Value, selection);
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
			pictureBox1.Image = originalImage;
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
