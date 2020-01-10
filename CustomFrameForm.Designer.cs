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
			this.frameLayout = new System.Windows.Forms.TableLayoutPanel();
			this.frameInnerLayout = new System.Windows.Forms.TableLayoutPanel();
			this.frameCaption = new System.Windows.Forms.TableLayoutPanel();
			this.frameIcon = new System.Windows.Forms.Panel();
			this.frameTitle = new System.Windows.Forms.Label();
			this.frameCaptionButtons = new System.Windows.Forms.Panel();
			this.frameMinimizeButton = new System.Windows.Forms.Button();
			this.frameSizeButton = new System.Windows.Forms.Button();
			this.frameCloseButton = new System.Windows.Forms.Button();
			this.frameContent = new System.Windows.Forms.Panel();
			this.frameBorderBottomRight = new System.Windows.Forms.Panel();
			this.frameBorderBottom = new System.Windows.Forms.Panel();
			this.frameBorderBottomLeft = new System.Windows.Forms.Panel();
			this.frameBorderRight = new System.Windows.Forms.Panel();
			this.frameBorderLeft = new System.Windows.Forms.Panel();
			this.frameBorderTopRight = new System.Windows.Forms.Panel();
			this.frameBorderTop = new System.Windows.Forms.Panel();
			this.frameBorderTopLeft = new System.Windows.Forms.Panel();
			this.frameLayout.SuspendLayout();
			this.frameInnerLayout.SuspendLayout();
			this.frameCaption.SuspendLayout();
			this.frameCaptionButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// frameLayout
			// 
			this.frameLayout.ColumnCount = 3;
			this.frameLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
			this.frameLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.frameLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
			this.frameLayout.Controls.Add(this.frameInnerLayout, 1, 1);
			this.frameLayout.Controls.Add(this.frameBorderBottomRight, 2, 2);
			this.frameLayout.Controls.Add(this.frameBorderBottom, 1, 2);
			this.frameLayout.Controls.Add(this.frameBorderBottomLeft, 0, 2);
			this.frameLayout.Controls.Add(this.frameBorderRight, 2, 1);
			this.frameLayout.Controls.Add(this.frameBorderLeft, 0, 1);
			this.frameLayout.Controls.Add(this.frameBorderTopRight, 2, 0);
			this.frameLayout.Controls.Add(this.frameBorderTop, 1, 0);
			this.frameLayout.Controls.Add(this.frameBorderTopLeft, 0, 0);
			this.frameLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.frameLayout.Location = new System.Drawing.Point(0, 0);
			this.frameLayout.Margin = new System.Windows.Forms.Padding(0);
			this.frameLayout.Name = "frameLayout";
			this.frameLayout.RowCount = 3;
			this.frameLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
			this.frameLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.frameLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
			this.frameLayout.Size = new System.Drawing.Size(800, 450);
			this.frameLayout.TabIndex = 0;
			// 
			// frameInnerLayout
			// 
			this.frameInnerLayout.ColumnCount = 1;
			this.frameInnerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.frameInnerLayout.Controls.Add(this.frameCaption, 0, 0);
			this.frameInnerLayout.Controls.Add(this.frameContent, 0, 1);
			this.frameInnerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameInnerLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.frameInnerLayout.Location = new System.Drawing.Point(7, 7);
			this.frameInnerLayout.Margin = new System.Windows.Forms.Padding(0);
			this.frameInnerLayout.Name = "frameInnerLayout";
			this.frameInnerLayout.RowCount = 2;
			this.frameInnerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.frameInnerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.frameInnerLayout.Size = new System.Drawing.Size(786, 436);
			this.frameInnerLayout.TabIndex = 9;
			// 
			// frameCaption
			// 
			this.frameCaption.ColumnCount = 3;
			this.frameCaption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.frameCaption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.frameCaption.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.frameCaption.Controls.Add(this.frameIcon, 0, 0);
			this.frameCaption.Controls.Add(this.frameTitle, 1, 0);
			this.frameCaption.Controls.Add(this.frameCaptionButtons, 2, 0);
			this.frameCaption.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameCaption.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.frameCaption.Location = new System.Drawing.Point(0, 0);
			this.frameCaption.Margin = new System.Windows.Forms.Padding(0);
			this.frameCaption.Name = "frameCaption";
			this.frameCaption.RowCount = 1;
			this.frameCaption.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.frameCaption.Size = new System.Drawing.Size(786, 30);
			this.frameCaption.TabIndex = 0;
			// 
			// frameIcon
			// 
			this.frameIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.frameIcon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameIcon.Location = new System.Drawing.Point(3, 0);
			this.frameIcon.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.frameIcon.Name = "frameIcon";
			this.frameIcon.Size = new System.Drawing.Size(18, 30);
			this.frameIcon.TabIndex = 0;
			// 
			// frameTitle
			// 
			this.frameTitle.AutoEllipsis = true;
			this.frameTitle.AutoSize = true;
			this.frameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameTitle.Location = new System.Drawing.Point(24, 0);
			this.frameTitle.Margin = new System.Windows.Forms.Padding(0);
			this.frameTitle.Name = "frameTitle";
			this.frameTitle.Size = new System.Drawing.Size(642, 30);
			this.frameTitle.TabIndex = 0;
			this.frameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frameCaptionButtons
			// 
			this.frameCaptionButtons.AutoSize = true;
			this.frameCaptionButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.frameCaptionButtons.Controls.Add(this.frameMinimizeButton);
			this.frameCaptionButtons.Controls.Add(this.frameSizeButton);
			this.frameCaptionButtons.Controls.Add(this.frameCloseButton);
			this.frameCaptionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameCaptionButtons.Location = new System.Drawing.Point(666, 0);
			this.frameCaptionButtons.Margin = new System.Windows.Forms.Padding(0);
			this.frameCaptionButtons.Name = "frameCaptionButtons";
			this.frameCaptionButtons.Size = new System.Drawing.Size(120, 30);
			this.frameCaptionButtons.TabIndex = 1;
			// 
			// frameMinimizeButton
			// 
			this.frameMinimizeButton.BackColor = System.Drawing.Color.Transparent;
			this.frameMinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.frameMinimizeButton.FlatAppearance.BorderSize = 0;
			this.frameMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.frameMinimizeButton.Image = global::WinFormsCustomFrame.Properties.Resources.FrameMinimizeButtonLight;
			this.frameMinimizeButton.Location = new System.Drawing.Point(0, 0);
			this.frameMinimizeButton.Margin = new System.Windows.Forms.Padding(0);
			this.frameMinimizeButton.Name = "frameMinimizeButton";
			this.frameMinimizeButton.Size = new System.Drawing.Size(40, 30);
			this.frameMinimizeButton.TabIndex = 0;
			this.frameMinimizeButton.UseVisualStyleBackColor = false;
			// 
			// frameSizeButton
			// 
			this.frameSizeButton.BackColor = System.Drawing.Color.Transparent;
			this.frameSizeButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.frameSizeButton.FlatAppearance.BorderSize = 0;
			this.frameSizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.frameSizeButton.Image = global::WinFormsCustomFrame.Properties.Resources.FrameMaximizeButtonLight;
			this.frameSizeButton.Location = new System.Drawing.Point(40, 0);
			this.frameSizeButton.Margin = new System.Windows.Forms.Padding(0);
			this.frameSizeButton.Name = "frameSizeButton";
			this.frameSizeButton.Size = new System.Drawing.Size(40, 30);
			this.frameSizeButton.TabIndex = 1;
			this.frameSizeButton.UseVisualStyleBackColor = false;
			// 
			// frameCloseButton
			// 
			this.frameCloseButton.BackColor = System.Drawing.Color.Transparent;
			this.frameCloseButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.frameCloseButton.FlatAppearance.BorderSize = 0;
			this.frameCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.frameCloseButton.Image = global::WinFormsCustomFrame.Properties.Resources.FrameCloseButtonLight;
			this.frameCloseButton.Location = new System.Drawing.Point(80, 0);
			this.frameCloseButton.Margin = new System.Windows.Forms.Padding(0);
			this.frameCloseButton.Name = "frameCloseButton";
			this.frameCloseButton.Size = new System.Drawing.Size(40, 30);
			this.frameCloseButton.TabIndex = 2;
			this.frameCloseButton.UseVisualStyleBackColor = false;
			// 
			// frameContent
			// 
			this.frameContent.BackColor = System.Drawing.SystemColors.Control;
			this.frameContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameContent.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frameContent.Location = new System.Drawing.Point(0, 30);
			this.frameContent.Margin = new System.Windows.Forms.Padding(0);
			this.frameContent.Name = "frameContent";
			this.frameContent.Size = new System.Drawing.Size(786, 406);
			this.frameContent.TabIndex = 1;
			// 
			// frameBorderBottomRight
			// 
			this.frameBorderBottomRight.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.frameBorderBottomRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameBorderBottomRight.Location = new System.Drawing.Point(793, 443);
			this.frameBorderBottomRight.Margin = new System.Windows.Forms.Padding(0);
			this.frameBorderBottomRight.Name = "frameBorderBottomRight";
			this.frameBorderBottomRight.Size = new System.Drawing.Size(7, 7);
			this.frameBorderBottomRight.TabIndex = 8;
			// 
			// frameBorderBottom
			// 
			this.frameBorderBottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.frameBorderBottom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameBorderBottom.Location = new System.Drawing.Point(7, 443);
			this.frameBorderBottom.Margin = new System.Windows.Forms.Padding(0);
			this.frameBorderBottom.Name = "frameBorderBottom";
			this.frameBorderBottom.Size = new System.Drawing.Size(786, 7);
			this.frameBorderBottom.TabIndex = 7;
			// 
			// frameBorderBottomLeft
			// 
			this.frameBorderBottomLeft.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.frameBorderBottomLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameBorderBottomLeft.Location = new System.Drawing.Point(0, 443);
			this.frameBorderBottomLeft.Margin = new System.Windows.Forms.Padding(0);
			this.frameBorderBottomLeft.Name = "frameBorderBottomLeft";
			this.frameBorderBottomLeft.Size = new System.Drawing.Size(7, 7);
			this.frameBorderBottomLeft.TabIndex = 6;
			// 
			// frameBorderRight
			// 
			this.frameBorderRight.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.frameBorderRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameBorderRight.Location = new System.Drawing.Point(793, 7);
			this.frameBorderRight.Margin = new System.Windows.Forms.Padding(0);
			this.frameBorderRight.Name = "frameBorderRight";
			this.frameBorderRight.Size = new System.Drawing.Size(7, 436);
			this.frameBorderRight.TabIndex = 5;
			// 
			// frameBorderLeft
			// 
			this.frameBorderLeft.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.frameBorderLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameBorderLeft.Location = new System.Drawing.Point(0, 7);
			this.frameBorderLeft.Margin = new System.Windows.Forms.Padding(0);
			this.frameBorderLeft.Name = "frameBorderLeft";
			this.frameBorderLeft.Size = new System.Drawing.Size(7, 436);
			this.frameBorderLeft.TabIndex = 3;
			// 
			// frameBorderTopRight
			// 
			this.frameBorderTopRight.Cursor = System.Windows.Forms.Cursors.SizeNESW;
			this.frameBorderTopRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameBorderTopRight.Location = new System.Drawing.Point(793, 0);
			this.frameBorderTopRight.Margin = new System.Windows.Forms.Padding(0);
			this.frameBorderTopRight.Name = "frameBorderTopRight";
			this.frameBorderTopRight.Size = new System.Drawing.Size(7, 7);
			this.frameBorderTopRight.TabIndex = 2;
			// 
			// frameBorderTop
			// 
			this.frameBorderTop.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.frameBorderTop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameBorderTop.Location = new System.Drawing.Point(7, 0);
			this.frameBorderTop.Margin = new System.Windows.Forms.Padding(0);
			this.frameBorderTop.Name = "frameBorderTop";
			this.frameBorderTop.Size = new System.Drawing.Size(786, 7);
			this.frameBorderTop.TabIndex = 1;
			// 
			// frameBorderTopLeft
			// 
			this.frameBorderTopLeft.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.frameBorderTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.frameBorderTopLeft.Location = new System.Drawing.Point(0, 0);
			this.frameBorderTopLeft.Margin = new System.Windows.Forms.Padding(0);
			this.frameBorderTopLeft.Name = "frameBorderTopLeft";
			this.frameBorderTopLeft.Size = new System.Drawing.Size(7, 7);
			this.frameBorderTopLeft.TabIndex = 0;
			// 
			// CustomFrameForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.frameLayout);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.Name = "CustomFrameForm";
			this.Text = "CustomFrameForm";
			this.frameLayout.ResumeLayout(false);
			this.frameInnerLayout.ResumeLayout(false);
			this.frameCaption.ResumeLayout(false);
			this.frameCaption.PerformLayout();
			this.frameCaptionButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel frameLayout;
		private System.Windows.Forms.Panel frameBorderTopLeft;
		private System.Windows.Forms.Panel frameBorderBottomRight;
		private System.Windows.Forms.Panel frameBorderBottom;
		private System.Windows.Forms.Panel frameBorderBottomLeft;
		private System.Windows.Forms.Panel frameBorderRight;
		private System.Windows.Forms.Panel frameBorderLeft;
		private System.Windows.Forms.Panel frameBorderTopRight;
		private System.Windows.Forms.Panel frameBorderTop;
		private System.Windows.Forms.TableLayoutPanel frameInnerLayout;
		private System.Windows.Forms.TableLayoutPanel frameCaption;
		private System.Windows.Forms.Panel frameIcon;
		private System.Windows.Forms.Label frameTitle;
		private System.Windows.Forms.Panel frameCaptionButtons;
		private System.Windows.Forms.Button frameMinimizeButton;
		private System.Windows.Forms.Button frameSizeButton;
		private System.Windows.Forms.Button frameCloseButton;
		protected System.Windows.Forms.Panel frameContent;
	}
}

