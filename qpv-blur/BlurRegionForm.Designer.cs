namespace qpv_blur
{
	partial class BlurRegionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.radiusSlider = new System.Windows.Forms.TrackBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.previewBtn = new System.Windows.Forms.Button();
			this.saveBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.radiusSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// radiusSlider
			// 
			this.radiusSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.radiusSlider.LargeChange = 1;
			this.radiusSlider.Location = new System.Drawing.Point(10, 243);
			this.radiusSlider.Margin = new System.Windows.Forms.Padding(0);
			this.radiusSlider.Minimum = 1;
			this.radiusSlider.Name = "radiusSlider";
			this.radiusSlider.Size = new System.Drawing.Size(364, 45);
			this.radiusSlider.TabIndex = 0;
			this.radiusSlider.Value = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(10, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(364, 223);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// previewBtn
			// 
			this.previewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.previewBtn.Location = new System.Drawing.Point(10, 288);
			this.previewBtn.Margin = new System.Windows.Forms.Padding(0);
			this.previewBtn.Name = "previewBtn";
			this.previewBtn.Size = new System.Drawing.Size(75, 23);
			this.previewBtn.TabIndex = 2;
			this.previewBtn.Text = "Preview";
			this.previewBtn.UseVisualStyleBackColor = true;
			this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
			// 
			// saveBtn
			// 
			this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.saveBtn.Location = new System.Drawing.Point(299, 288);
			this.saveBtn.Margin = new System.Windows.Forms.Padding(0);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 23);
			this.saveBtn.TabIndex = 3;
			this.saveBtn.Text = "Save";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// BlurRegionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(384, 321);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.previewBtn);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.radiusSlider);
			this.MinimizeBox = false;
			this.Name = "BlurRegionForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Blur region";
			((System.ComponentModel.ISupportInitialize)(this.radiusSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar radiusSlider;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button previewBtn;
		private System.Windows.Forms.Button saveBtn;
	}
}