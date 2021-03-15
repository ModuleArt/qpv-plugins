using QuickLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace qpv_plugins
{
	public partial class BlurRegionForm : QlibFixedForm
	{
		public Bitmap Result;

		private Bitmap originalImage;
		private bool previewUpdated = false;
		private Rectangle selection = Rectangle.Empty;
		private bool sliderHolded = false;

		public BlurRegionForm(Bitmap bmp, Rectangle selection)
		{
			originalImage = bmp;
			this.selection = selection;

			InitializeComponent();
			SetDraggableControls(new List<Control>() { effectLabel, titleLabel, radiusLabel, pictureBox1 });

			radiusSlider.Value = Properties.Settings.Default.BlurRadius;
			typeComboBox.SelectedIndex = Properties.Settings.Default.BlurType;

			pictureBox1.Image = bmp;
		}

		private void UpdatePreview()
		{
			if (previewCheckbox.Checked && !previewUpdated) 
			{
				if (typeComboBox.SelectedIndex == 0) UpdateBlurResult();
				else UpdatePixelateResult();
				pictureBox1.Image = Result;
				previewUpdated = true;
			}
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
			if (selection.Width == 0) selection.Width = originalImage.Width;
			if (selection.Height == 0) selection.Height = originalImage.Height;

			Bitmap selBmp = originalImage.Clone(selection, originalImage.PixelFormat);
			GaussianBlur gb = new GaussianBlur(selBmp);
			selBmp = gb.Process(radiusSlider.Value);
			Result = originalImage.Clone(new Rectangle(0, 0, originalImage.Width, originalImage.Height), originalImage.PixelFormat);

			using (Graphics g = Graphics.FromImage(Result)) g.DrawImage(selBmp, selection);
			pictureBox1.Image = Result;
		}

		private void UpdatePixelateResult()
		{
			Result = PixelateMan.ProcessPixelate(originalImage, radiusSlider.Value, selection);
		}

		private void radiusSlider_ValueChanged(object sender, EventArgs e)
		{
			radiusLabel.Text = "Radius: " + radiusSlider.Value;
			if (!sliderHolded)
			{
				previewUpdated = false;
				UpdatePreview();
			}
		}

		private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			previewUpdated = false;
			UpdatePreview();
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

		private void BlurRegionForm_Load(object sender, EventArgs e)
		{
			if (DarkMode)
			{
				resetBtn.BackColor = ThemeMan.DarkSecondColor;
				applyBtn.BackColor = ThemeMan.DarkSecondColor;
			}
			closeBtn.DarkMode = DarkMode;
			previewCheckbox.DarkMode = DarkMode;
			typeComboBox.DarkMode = DarkMode;

			infoTooltip.SetToolTip(closeBtn, NativeMan.GetMessageBoxText(NativeMan.DialogBoxCommandID.IDCLOSE) + " | Alt+F4");
		}

		private void BlurRegionForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) Close();
		}

		private void previewCheckbox_CheckedChanged(object sender, EventArgs e)
		{
			UpdatePreview();
		}

		private void radiusSlider_MouseUp(object sender, MouseEventArgs e)
		{
			sliderHolded = false;
			previewUpdated = false;
			UpdatePreview();
		}

		private void radiusSlider_MouseDown(object sender, MouseEventArgs e)
		{
			sliderHolded = true;
		}
	}
}