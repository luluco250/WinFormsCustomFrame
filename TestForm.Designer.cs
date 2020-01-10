namespace WinFormsCustomFrame
{
	partial class TestForm
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
			this.content = new System.Windows.Forms.Panel();
			this.buttons = new System.Windows.Forms.Panel();
			this.yesButton = new System.Windows.Forms.Button();
			this.noButton = new System.Windows.Forms.Button();
			this.message = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.content.SuspendLayout();
			this.buttons.SuspendLayout();
			this.SuspendLayout();
			// 
			// content
			// 
			this.content.BackColor = System.Drawing.SystemColors.Control;
			this.content.Controls.Add(this.buttons);
			this.content.Controls.Add(this.message);
			this.content.Dock = System.Windows.Forms.DockStyle.Fill;
			this.content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.content.ForeColor = System.Drawing.SystemColors.ControlText;
			this.content.Location = new System.Drawing.Point(7, 37);
			this.content.Margin = new System.Windows.Forms.Padding(0);
			this.content.Name = "content";
			this.content.Size = new System.Drawing.Size(350, 157);
			this.content.TabIndex = 5;
			// 
			// buttons
			// 
			this.buttons.Controls.Add(this.yesButton);
			this.buttons.Controls.Add(this.noButton);
			this.buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttons.Location = new System.Drawing.Point(0, 127);
			this.buttons.Margin = new System.Windows.Forms.Padding(0);
			this.buttons.Name = "buttons";
			this.buttons.Size = new System.Drawing.Size(350, 30);
			this.buttons.TabIndex = 1;
			// 
			// yesButton
			// 
			this.yesButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.yesButton.Location = new System.Drawing.Point(200, 0);
			this.yesButton.Name = "yesButton";
			this.yesButton.Size = new System.Drawing.Size(75, 30);
			this.yesButton.TabIndex = 1;
			this.yesButton.Text = "Yes";
			this.yesButton.UseVisualStyleBackColor = true;
			// 
			// noButton
			// 
			this.noButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.noButton.Location = new System.Drawing.Point(275, 0);
			this.noButton.Name = "noButton";
			this.noButton.Size = new System.Drawing.Size(75, 30);
			this.noButton.TabIndex = 0;
			this.noButton.Text = "No";
			this.noButton.UseVisualStyleBackColor = true;
			// 
			// message
			// 
			this.message.Dock = System.Windows.Forms.DockStyle.Fill;
			this.message.Location = new System.Drawing.Point(0, 0);
			this.message.Margin = new System.Windows.Forms.Padding(0);
			this.message.Name = "message";
			this.message.Size = new System.Drawing.Size(350, 157);
			this.message.TabIndex = 0;
			this.message.Text = "This is a test message.";
			this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Right;
			this.button1.Location = new System.Drawing.Point(195, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 30);
			this.button1.TabIndex = 6;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// TestForm
			// 
			this.ClientSize = new System.Drawing.Size(364, 201);
			this.Controls.Add(this.content);
			this.Name = "TestForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestForm";
			this.Controls.SetChildIndex(this.content, 0);
			this.content.ResumeLayout(false);
			this.buttons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel content;
		private System.Windows.Forms.Label message;
		private System.Windows.Forms.Panel buttons;
		private System.Windows.Forms.Button noButton;
		private System.Windows.Forms.Button yesButton;
		private System.Windows.Forms.Button button1;
	}
}
