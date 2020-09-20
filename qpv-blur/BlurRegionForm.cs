using System;
using System.Drawing;
using System.Windows.Forms;

namespace qpv_blur
{
	public partial class BlurRegionForm : Form
	{
		private Bitmap originalImage;

		public BlurRegionForm(Bitmap bmp)
		{
			originalImage = bmp;
			InitializeComponent();
			radiusSlider.Value = Properties.Settings.Default.Radius;
			pictureBox1.Image = bmp;
		}

		private void previewBtn_Click(object sender, EventArgs e)
		{
			pictureBox1.Image = Main.ProcessBlur(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height), radiusSlider.Value);
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Radius = radiusSlider.Value;
			Properties.Settings.Default.Save();
			this.Close();
		}
	}
}
