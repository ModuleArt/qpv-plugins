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
			this.components = new System.ComponentModel.Container();
			this.radiusSlider = new System.Windows.Forms.TrackBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.applyBtn = new System.Windows.Forms.Button();
			this.resetBtn = new System.Windows.Forms.Button();
			this.typeComboBox = new QuickLibrary.QlibComboBox();
			this.effectLabel = new System.Windows.Forms.Label();
			this.radiusLabel = new System.Windows.Forms.Label();
			this.closeBtn = new QuickLibrary.QlibTitlebarButton();
			this.previewCheckbox = new QuickLibrary.QlibCheckBox();
			this.infoTooltip = new System.Windows.Forms.ToolTip(this.components);
			this.titleLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.radiusSlider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// radiusSlider
			// 
			this.radiusSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radiusSlider.LargeChange = 1;
			this.radiusSlider.Location = new System.Drawing.Point(430, 71);
			this.radiusSlider.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.radiusSlider.Maximum = 64;
			this.radiusSlider.Minimum = 2;
			this.radiusSlider.Name = "radiusSlider";
			this.radiusSlider.Size = new System.Drawing.Size(200, 45);
			this.radiusSlider.TabIndex = 0;
			this.radiusSlider.TickFrequency = 2;
			this.radiusSlider.Value = 5;
			this.radiusSlider.ValueChanged += new System.EventHandler(this.radiusSlider_ValueChanged);
			this.radiusSlider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.radiusSlider_MouseDown);
			this.radiusSlider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.radiusSlider_MouseUp);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(10, 10);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(399, 338);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// applyBtn
			// 
			this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.applyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.applyBtn.FlatAppearance.BorderSize = 0;
			this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.applyBtn.Location = new System.Drawing.Point(535, 318);
			this.applyBtn.Margin = new System.Windows.Forms.Padding(0);
			this.applyBtn.Name = "applyBtn";
			this.applyBtn.Size = new System.Drawing.Size(95, 32);
			this.applyBtn.TabIndex = 3;
			this.applyBtn.Text = "Apply";
			this.applyBtn.UseVisualStyleBackColor = false;
			this.applyBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// resetBtn
			// 
			this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.resetBtn.BackColor = System.Drawing.SystemColors.ControlLight;
			this.resetBtn.FlatAppearance.BorderSize = 0;
			this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.resetBtn.Location = new System.Drawing.Point(430, 318);
			this.resetBtn.Margin = new System.Windows.Forms.Padding(0);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(95, 32);
			this.resetBtn.TabIndex = 5;
			this.resetBtn.Text = "Reset";
			this.resetBtn.UseVisualStyleBackColor = false;
			this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
			// 
			// typeComboBox
			// 
			this.typeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.typeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.ItemHeight = 26;
			this.typeComboBox.Items.AddRange(new object[] {
            "Gaussian blur",
            "Normal pixelate"});
			this.typeComboBox.Location = new System.Drawing.Point(430, 155);
			this.typeComboBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(200, 32);
			this.typeComboBox.TabIndex = 3;
			this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
			// 
			// effectLabel
			// 
			this.effectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.effectLabel.AutoSize = true;
			this.effectLabel.Location = new System.Drawing.Point(430, 126);
			this.effectLabel.Margin = new System.Windows.Forms.Padding(0);
			this.effectLabel.Name = "effectLabel";
			this.effectLabel.Size = new System.Drawing.Size(45, 19);
			this.effectLabel.TabIndex = 2;
			this.effectLabel.Text = "Effect:";
			// 
			// radiusLabel
			// 
			this.radiusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.radiusLabel.AutoSize = true;
			this.radiusLabel.Location = new System.Drawing.Point(430, 42);
			this.radiusLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.radiusLabel.Name = "radiusLabel";
			this.radiusLabel.Size = new System.Drawing.Size(64, 19);
			this.radiusLabel.TabIndex = 1;
			this.radiusLabel.Text = "Radius: 5";
			// 
			// closeBtn
			// 
			this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeBtn.DarkImage = global::qpv_plugins.Properties.Resources.black_close;
			this.closeBtn.DarkMode = false;
			this.closeBtn.FlatAppearance.BorderSize = 0;
			this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(112)))), ((int)(((byte)(122)))));
			this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
			this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeBtn.ForeColor = System.Drawing.Color.Black;
			this.closeBtn.Image = global::qpv_plugins.Properties.Resources.black_close;
			this.closeBtn.IsRed = true;
			this.closeBtn.LightImage = global::qpv_plugins.Properties.Resources.white_close;
			this.closeBtn.Location = new System.Drawing.Point(608, 0);
			this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(32, 32);
			this.closeBtn.TabIndex = 6;
			this.closeBtn.UseVisualStyleBackColor = true;
			// 
			// previewCheckbox
			// 
			this.previewCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.previewCheckbox.BackColor = System.Drawing.SystemColors.Control;
			this.previewCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.previewCheckbox.Cursor = System.Windows.Forms.Cursors.Default;
			this.previewCheckbox.DarkMode = false;
			this.previewCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.previewCheckbox.ForeColor = System.Drawing.Color.Black;
			this.previewCheckbox.Image = null;
			this.previewCheckbox.ImageIndex = 0;
			this.previewCheckbox.Location = new System.Drawing.Point(430, 285);
			this.previewCheckbox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.previewCheckbox.Name = "previewCheckbox";
			this.previewCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.previewCheckbox.Size = new System.Drawing.Size(200, 23);
			this.previewCheckbox.TabIndex = 9;
			this.previewCheckbox.Text = "Preview";
			this.previewCheckbox.UseVisualStyleBackColor = true;
			this.previewCheckbox.CheckedChanged += new System.EventHandler(this.previewCheckbox_CheckedChanged);
			// 
			// titleLabel
			// 
			this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.titleLabel.AutoSize = true;
			this.titleLabel.Location = new System.Drawing.Point(430, 7);
			this.titleLabel.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(100, 19);
			this.titleLabel.TabIndex = 10;
			this.titleLabel.Text = "Blur or pixelate";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Black;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(419, 358);
			this.panel1.TabIndex = 11;
			// 
			// BlurRegionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(640, 360);
			this.CloseButton = this.closeBtn;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.resetBtn);
			this.Controls.Add(this.previewCheckbox);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.effectLabel);
			this.Controls.Add(this.radiusSlider);
			this.Controls.Add(this.radiusLabel);
			this.Controls.Add(this.applyBtn);
			this.Draggable = true;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(480, 300);
			this.Name = "BlurRegionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Blur region";
			this.Load += new System.EventHandler(this.BlurRegionForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlurRegionForm_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.radiusSlider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TrackBar radiusSlider;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button applyBtn;
		private System.Windows.Forms.Label radiusLabel;
		private QuickLibrary.QlibComboBox typeComboBox;
		private System.Windows.Forms.Label effectLabel;
		private System.Windows.Forms.Button resetBtn;
		private QuickLibrary.QlibTitlebarButton closeBtn;
		private QuickLibrary.QlibCheckBox previewCheckbox;
		private System.Windows.Forms.ToolTip infoTooltip;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Panel panel1;
	}
}