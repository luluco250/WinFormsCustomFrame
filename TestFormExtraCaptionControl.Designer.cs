namespace WinFormsCustomFrame
{
	partial class TestFormExtraCaptionControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.prevScreen = new System.Windows.Forms.Button();
			this.nextScreen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// prevScreen
			// 
			this.prevScreen.AutoSize = true;
			this.prevScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.prevScreen.Dock = System.Windows.Forms.DockStyle.Right;
			this.prevScreen.FlatAppearance.BorderSize = 0;
			this.prevScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.prevScreen.Location = new System.Drawing.Point(0, 0);
			this.prevScreen.Margin = new System.Windows.Forms.Padding(0);
			this.prevScreen.Name = "prevScreen";
			this.prevScreen.Size = new System.Drawing.Size(26, 30);
			this.prevScreen.TabIndex = 1;
			this.prevScreen.Text = "<-";
			this.prevScreen.UseVisualStyleBackColor = true;
			// 
			// nextScreen
			// 
			this.nextScreen.AutoSize = true;
			this.nextScreen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.nextScreen.Dock = System.Windows.Forms.DockStyle.Right;
			this.nextScreen.FlatAppearance.BorderSize = 0;
			this.nextScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.nextScreen.Location = new System.Drawing.Point(26, 0);
			this.nextScreen.Margin = new System.Windows.Forms.Padding(0);
			this.nextScreen.Name = "nextScreen";
			this.nextScreen.Size = new System.Drawing.Size(26, 30);
			this.nextScreen.TabIndex = 2;
			this.nextScreen.Text = "->";
			this.nextScreen.UseVisualStyleBackColor = true;
			// 
			// TestFormExtraCaptionControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.prevScreen);
			this.Controls.Add(this.nextScreen);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.MinimumSize = new System.Drawing.Size(0, 30);
			this.Name = "TestFormExtraCaptionControl";
			this.Size = new System.Drawing.Size(52, 30);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button prevScreen;
		private System.Windows.Forms.Button nextScreen;
	}
}
