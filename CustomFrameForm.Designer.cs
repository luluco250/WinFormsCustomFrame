namespace WinFormsCustomFrame
{
	partial class CustomFrameForm
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
			this.leftBorder = new System.Windows.Forms.Panel();
			this.topLeftBorder = new System.Windows.Forms.Panel();
			this.bottomLeftBorder = new System.Windows.Forms.Panel();
			this.rightBorder = new System.Windows.Forms.Panel();
			this.topRightBorder = new System.Windows.Forms.Panel();
			this.bottomRightBorder = new System.Windows.Forms.Panel();
			this.bottomBorder = new System.Windows.Forms.Panel();
			this.topBorder = new System.Windows.Forms.Panel();
			this.caption = new System.Windows.Forms.Panel();
			this.minimizeButton = new System.Windows.Forms.Button();
			this.sizeButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.title = new System.Windows.Forms.Label();
			this.icon = new System.Windows.Forms.Panel();
			this.leftBorder.SuspendLayout();
			this.rightBorder.SuspendLayout();
			this.caption.SuspendLayout();
			this.SuspendLayout();
			// 
			// leftBorder
			// 
			this.leftBorder.Controls.Add(this.topLeftBorder);
			this.leftBorder.Controls.Add(this.bottomLeftBorder);
			this.leftBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.leftBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftBorder.Location = new System.Drawing.Point(0, 0);
			this.leftBorder.Margin = new System.Windows.Forms.Padding(0);
			this.leftBorder.Name = "leftBorder";
			this.leftBorder.Size = new System.Drawing.Size(7, 450);
			this.leftBorder.TabIndex = 0;
			// 
			// topLeftBorder
			// 
			this.topLeftBorder.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.topLeftBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.topLeftBorder.Location = new System.Drawing.Point(0, 0);
			this.topLeftBorder.Margin = new System.Windows.Forms.Padding(0);
			this.topLeftBorder.Name = "topLeftBorder";
			this.topLeftBorder.Size = new System.Drawing.Size(7, 7);
			this.topLeftBorder.TabIndex = 1;
			// 
			// bottomLeftBorder
			// 
			this.bottomLeftBorder.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.bottomLeftBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomLeftBorder.Location = new System.Drawing.Point(0, 443);
			this.bottomLeftBorder.Margin = new System.Windows.Forms.Padding(0);
			this.bottomLeftBorder.Name = "bottomLeftBorder";
			this.bottomLeftBorder.Size = new System.Drawing.Size(7, 7);
			this.bottomLeftBorder.TabIndex = 2;
			// 
			// rightBorder
			// 
			this.rightBorder.Controls.Add(this.topRightBorder);
			this.rightBorder.Controls.Add(this.bottomRightBorder);
			this.rightBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.rightBorder.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightBorder.Location = new System.Drawing.Point(793, 0);
			this.rightBorder.Margin = new System.Windows.Forms.Padding(0);
			this.rightBorder.Name = "rightBorder";
			this.rightBorder.Size = new System.Drawing.Size(7, 450);
			this.rightBorder.TabIndex = 1;
			// 
			// topRightBorder
			// 
			this.topRightBorder.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.topRightBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.topRightBorder.Location = new System.Drawing.Point(0, 0);
			this.topRightBorder.Margin = new System.Windows.Forms.Padding(0);
			this.topRightBorder.Name = "topRightBorder";
			this.topRightBorder.Size = new System.Drawing.Size(7, 7);
			this.topRightBorder.TabIndex = 0;
			// 
			// bottomRightBorder
			// 
			this.bottomRightBorder.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.bottomRightBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomRightBorder.Location = new System.Drawing.Point(0, 443);
			this.bottomRightBorder.Margin = new System.Windows.Forms.Padding(0);
			this.bottomRightBorder.Name = "bottomRightBorder";
			this.bottomRightBorder.Size = new System.Drawing.Size(7, 7);
			this.bottomRightBorder.TabIndex = 1;
			// 
			// bottomBorder
			// 
			this.bottomBorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.bottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomBorder.Location = new System.Drawing.Point(7, 443);
			this.bottomBorder.Margin = new System.Windows.Forms.Padding(0);
			this.bottomBorder.Name = "bottomBorder";
			this.bottomBorder.Size = new System.Drawing.Size(786, 7);
			this.bottomBorder.TabIndex = 2;
			// 
			// topBorder
			// 
			this.topBorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.topBorder.Dock = System.Windows.Forms.DockStyle.Top;
			this.topBorder.Location = new System.Drawing.Point(7, 0);
			this.topBorder.Margin = new System.Windows.Forms.Padding(0);
			this.topBorder.Name = "topBorder";
			this.topBorder.Size = new System.Drawing.Size(786, 7);
			this.topBorder.TabIndex = 3;
			// 
			// caption
			// 
			this.caption.Controls.Add(this.minimizeButton);
			this.caption.Controls.Add(this.sizeButton);
			this.caption.Controls.Add(this.closeButton);
			this.caption.Controls.Add(this.title);
			this.caption.Controls.Add(this.icon);
			this.caption.Dock = System.Windows.Forms.DockStyle.Top;
			this.caption.Location = new System.Drawing.Point(7, 7);
			this.caption.Margin = new System.Windows.Forms.Padding(0);
			this.caption.Name = "caption";
			this.caption.Size = new System.Drawing.Size(786, 30);
			this.caption.TabIndex = 4;
			// 
			// minimizeButton
			// 
			this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Image = global::WinFormsCustomFrame.Properties.Resources.FrameMinimizeButtonLight;
			this.minimizeButton.Location = new System.Drawing.Point(666, 0);
			this.minimizeButton.Margin = new System.Windows.Forms.Padding(0);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(40, 30);
			this.minimizeButton.TabIndex = 4;
			this.minimizeButton.UseVisualStyleBackColor = true;
			// 
			// sizeButton
			// 
			this.sizeButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.sizeButton.FlatAppearance.BorderSize = 0;
			this.sizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sizeButton.Image = global::WinFormsCustomFrame.Properties.Resources.FrameMaximizeButtonLight;
			this.sizeButton.Location = new System.Drawing.Point(706, 0);
			this.sizeButton.Margin = new System.Windows.Forms.Padding(0);
			this.sizeButton.Name = "sizeButton";
			this.sizeButton.Size = new System.Drawing.Size(40, 30);
			this.sizeButton.TabIndex = 3;
			this.sizeButton.UseVisualStyleBackColor = true;
			// 
			// closeButton
			// 
			this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Image = global::WinFormsCustomFrame.Properties.Resources.FrameCloseButtonLight;
			this.closeButton.Location = new System.Drawing.Point(746, 0);
			this.closeButton.Margin = new System.Windows.Forms.Padding(0);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(40, 30);
			this.closeButton.TabIndex = 2;
			this.closeButton.UseVisualStyleBackColor = true;
			// 
			// title
			// 
			this.title.AutoEllipsis = true;
			this.title.AutoSize = true;
			this.title.Dock = System.Windows.Forms.DockStyle.Left;
			this.title.Location = new System.Drawing.Point(18, 0);
			this.title.Margin = new System.Windows.Forms.Padding(0);
			this.title.MinimumSize = new System.Drawing.Size(0, 30);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(27, 30);
			this.title.TabIndex = 1;
			this.title.Text = "Test";
			this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// icon
			// 
			this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.icon.Dock = System.Windows.Forms.DockStyle.Left;
			this.icon.Location = new System.Drawing.Point(0, 0);
			this.icon.Margin = new System.Windows.Forms.Padding(0);
			this.icon.Name = "icon";
			this.icon.Size = new System.Drawing.Size(18, 30);
			this.icon.TabIndex = 0;
			// 
			// CustomFrameForm_NoLayout
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.caption);
			this.Controls.Add(this.topBorder);
			this.Controls.Add(this.bottomBorder);
			this.Controls.Add(this.rightBorder);
			this.Controls.Add(this.leftBorder);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.Name = "CustomFrameForm_NoLayout";
			this.Text = "CustomFrameForm_NoLayouts";
			this.leftBorder.ResumeLayout(false);
			this.rightBorder.ResumeLayout(false);
			this.caption.ResumeLayout(false);
			this.caption.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel leftBorder;
		private System.Windows.Forms.Panel rightBorder;
		private System.Windows.Forms.Panel bottomBorder;
		private System.Windows.Forms.Panel topBorder;
		private System.Windows.Forms.Panel caption;
		private System.Windows.Forms.Panel icon;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button minimizeButton;
		private System.Windows.Forms.Button sizeButton;
		private System.Windows.Forms.Panel topRightBorder;
		private System.Windows.Forms.Panel bottomRightBorder;
		private System.Windows.Forms.Panel topLeftBorder;
		private System.Windows.Forms.Panel bottomLeftBorder;
	}
}