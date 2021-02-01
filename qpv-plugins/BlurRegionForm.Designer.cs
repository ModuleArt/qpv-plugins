namespace qpv_plugins
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
			this.applyBtn = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.resetBtn = new System.Windows.Forms.Button();
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.radiusLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.radiusSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// radiusSlider
			// 
			this.radiusSlider.LargeChange = 1;
			this.radiusSlider.Location = new System.Drawing.Point(10, 55);
			this.radiusSlider.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.radiusSlider.Minimum = 1;
			this.radiusSlider.Name = "radiusSlider";
			this.radiusSlider.Size = new System.Drawing.Size(180, 45);
			this.radiusSlider.TabIndex = 0;
			this.radiusSlider.Value = 1;
			this.radiusSlider.ValueChanged += new System.EventHandler(this.radiusSlider_ValueChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(10, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(454, 341);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// previewBtn
			// 
			this.previewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.previewBtn.Location = new System.Drawing.Point(474, 319);
			this.previewBtn.Margin = new System.Windows.Forms.Padding(0);
			this.previewBtn.Name = "previewBtn";
			this.previewBtn.Size = new System.Drawing.Size(95, 32);
			this.previewBtn.TabIndex = 2;
			this.previewBtn.Text = "< Preview";
			this.previewBtn.UseVisualStyleBackColor = true;
			this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
			// 
			// applyBtn
			// 
			this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.applyBtn.Location = new System.Drawing.Point(579, 319);
			this.applyBtn.Margin = new System.Windows.Forms.Padding(0);
			this.applyBtn.Name = "applyBtn";
			this.applyBtn.Size = new System.Drawing.Size(95, 32);
			this.applyBtn.TabIndex = 3;
			this.applyBtn.Text = "Apply";
			this.applyBtn.UseVisualStyleBackColor = true;
			this.applyBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.resetBtn);
			this.groupBox1.Controls.Add(this.typeComboBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.radiusLabel);
			this.groupBox1.Controls.Add(this.radiusSlider);
			this.groupBox1.Location = new System.Drawing.Point(474, 10);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
			this.groupBox1.Size = new System.Drawing.Size(200, 299);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// resetBtn
			// 
			this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.resetBtn.Location = new System.Drawing.Point(137, 0);
			this.resetBtn.Margin = new System.Windows.Forms.Padding(0);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(64, 32);
			this.resetBtn.TabIndex = 5;
			this.resetBtn.Text = "Reset";
			this.resetBtn.UseVisualStyleBackColor = true;
			this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
			// 
			// typeComboBox
			// 
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Items.AddRange(new object[] {
			"Blur (Slow)",
			"Pixelate"});
			this.typeComboBox.Location = new System.Drawing.Point(10, 137);
			this.typeComboBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(180, 25);
			this.typeComboBox.TabIndex = 3;
			this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 110);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Effect:";
			// 
			// radiusLabel
			// 
			this.radiusLabel.AutoSize = true;
			this.radiusLabel.Location = new System.Drawing.Point(10, 28);
			this.radiusLabel.Margin = new System.Windows.Forms.Padding(0);
			this.radiusLabel.Name = "radiusLabel";
			this.radiusLabel.Size = new System.Drawing.Size(50, 17);
			this.radiusLabel.TabIndex = 1;
			this.radiusLabel.Text = "Radius:";
			// 
			// BlurRegionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(684, 361);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.applyBtn);
			this.Controls.Add(this.previewBtn);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "BlurRegionForm";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Blur region";
			((System.ComponentModel.ISupportInitialize)(this.radiusSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TrackBar radiusSlider;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button previewBtn;
		private System.Windows.Forms.Button applyBtn;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label radiusLabel;
		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button resetBtn;
	}
}