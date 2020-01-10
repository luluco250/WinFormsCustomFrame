﻿using static WinFormsCustomFrame.Win32.Constants;
using static WinFormsCustomFrame.Win32.NativeMethods;

using System.Windows.Forms;
using System;
using System.Drawing;
using WinFormsCustomFrame.Utils;
using WinFormsCustomFrame.Properties;

namespace WinFormsCustomFrame
{
	public partial class CustomFrameForm_NoLayout : Form
	{
		#region Constants

		public const int DarkFrameColorThreshold = 127;

		#endregion

		#region Property

		public override string Text
		{
			get { return base.Text; }
			set
			{
				base.Text = value;
				title.Text = value;
			}
		}

		#endregion

		#region State

		private bool frameIsDark;
		private bool isMaximized;
		private int lastHit;
		private Timer doubleClickTimer;

		#endregion

		#region Setup

		protected override CreateParams CreateParams
		{
			get
			{
				var cp = base.CreateParams;

				//cp.ExStyle |= WS_EX_COMPOSITED;
				//cp.ClassStyle |= CS_DROPSHADOW;

				return cp;
			}
		}

		public CustomFrameForm_NoLayout()
		{
			InitializeComponent();
			SetupStyling();
			SetupEvents();
		}

		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
			case WM_SIZE:
				if ((int)m.WParam == SIZE_MAXIMIZED && !isMaximized)
				{
					sizeButton.Image = frameIsDark
						? Resources.FrameRestoreButtonLight
						: Resources.FrameRestoreButtonDark;

					isMaximized = true;
				}
				else if (isMaximized)
				{
					sizeButton.Image = frameIsDark
						? Resources.FrameMaximizeButtonLight
						: Resources.FrameMaximizeButtonDark;

					isMaximized = false;
				}
				break;
			case WM_NCCALCSIZE:
				m.Result = IntPtr.Zero;
				return;
			case WM_DWMCOLORIZATIONCOLORCHANGED:
				UpdateFrameColor((int)m.WParam);
				m.Result = IntPtr.Zero;
				return;
			}

			base.WndProc(ref m);
		}

		private void SetupStyling()
		{
			UpdateFrameColor();

			minimizeButton.FlatAppearance.BorderColor =
			sizeButton.FlatAppearance.BorderColor =
			closeButton.FlatAppearance.BorderColor =
				Color.FromArgb(0, 255, 255, 255);

			title.Text = Text;

			int iconSize = Math.Min(icon.Width, icon.Height);
			icon.BackgroundImage = new Bitmap(
				Icon.ToBitmap(),
				new Size(iconSize, iconSize)
			);
		}

		private void SetupEvents()
		{
			SetupNonClientHit(leftBorder, HTLEFT);
			SetupNonClientHit(rightBorder, HTRIGHT);
			SetupNonClientHit(topBorder, HTTOP);
			SetupNonClientHit(topLeftBorder, HTTOPLEFT);
			SetupNonClientHit(topRightBorder, HTTOPRIGHT);
			SetupNonClientHit(bottomBorder, HTBOTTOM);
			SetupNonClientHit(bottomLeftBorder, HTBOTTOMLEFT);
			SetupNonClientHit(bottomRightBorder, HTBOTTOMRIGHT);
			SetupNonClientHit(caption, HTCAPTION);
			SetupNonClientHit(title, HTCAPTION);
			SetupNonClientHit(icon, HTSYSMENU);

			minimizeButton.Click += (_, e)
				=> WindowState = FormWindowState.Minimized;
			
			sizeButton.Click += (_, e) =>
				WindowState = (WindowState == FormWindowState.Maximized)
					? FormWindowState.Normal
					: FormWindowState.Maximized;
			
			// TODO: There is a delay before the close button image is updated.
			// Perhaps it'd be best to create a custom control instead.
			closeButton.MouseEnter += CloseButton_MouseEnterDown;
			closeButton.MouseDown += CloseButton_MouseEnterDown;
			closeButton.MouseLeave += CloseButton_MouseLeaveUp;
			closeButton.MouseUp += CloseButton_MouseLeaveUp;
			closeButton.Click += (_, e) => Close();

			doubleClickTimer = new Timer();
			doubleClickTimer.Interval = SystemInformation.DoubleClickTime;
			doubleClickTimer.Tick += (_, e) =>
			{
				lastHit = 0;
				doubleClickTimer.Stop();
			};
		}

		#endregion

		#region Utils

		private void UpdateFrameColor(int colorDword = -1)
		{
			SuspendLayout();

			if (colorDword == -1)
			{
				int result = DwmGetColorizationColor(out colorDword, out int _);

				// Dwm may be disabled on older systems.
				if (result != 0)
					colorDword = unchecked((int)0xFFFFFFFF);
			}

			BackColor = Color.FromArgb(255, ColorUtils.ColorFromDwordArgb(colorDword));

			var lum = ColorUtils.GetColorLuma(BackColor);

			if (lum < DarkFrameColorThreshold)
			{
				ForeColor = Color.White;
				minimizeButton.Image = Resources.FrameMinimizeButtonLight;
				sizeButton.Image = (WindowState == FormWindowState.Maximized)
					? Resources.FrameRestoreButtonLight
					: Resources.FrameMaximizeButtonLight;
				closeButton.Image = Resources.FrameCloseButtonLight;

				minimizeButton.FlatAppearance.MouseOverBackColor =
				sizeButton.FlatAppearance.MouseOverBackColor =
					ColorUtils.Add(BackColor, 20);

				minimizeButton.FlatAppearance.MouseDownBackColor =
				sizeButton.FlatAppearance.MouseDownBackColor =
					ColorUtils.Add(BackColor, 40);

				frameIsDark = true;
			}
			else
			{
				ForeColor = Color.Black;
				minimizeButton.Image = Resources.FrameMinimizeButtonDark;
				sizeButton.Image = (WindowState == FormWindowState.Maximized)
					? Resources.FrameRestoreButtonDark
					: Resources.FrameMaximizeButtonDark;
				closeButton.Image = Resources.FrameCloseButtonDark;

				minimizeButton.FlatAppearance.MouseOverBackColor =
				sizeButton.FlatAppearance.MouseOverBackColor =
					ColorUtils.Add(BackColor, -20);

				minimizeButton.FlatAppearance.MouseDownBackColor =
				sizeButton.FlatAppearance.MouseDownBackColor =
					ColorUtils.Add(BackColor, -40);

				frameIsDark = false;
			}

			closeButton.FlatAppearance.MouseOverBackColor = Color.Red;
			closeButton.FlatAppearance.MouseDownBackColor =
				ColorUtils.Lerp(BackColor, Color.Red, 0.5f);

			ResumeLayout();
		}

		private void SetupNonClientHit(Control ctrl, int hit)
		{
			ctrl.MouseDown += (_, e) =>
			{
				ReleaseCapture();

				if (e.Button == MouseButtons.Right)
				{
					SendMessage(Handle, WM_NCRBUTTONDOWN, hit, 0);
					return;
				}
				
				// If double-click.
				if (lastHit == hit)
				{
					SendMessage(Handle, WM_NCLBUTTONDBLCLK, hit, 0);

					// Reset double click state.
					lastHit = 0;
					doubleClickTimer.Stop();

					
				}
				else
				{
					SendMessage(Handle, WM_NCLBUTTONDOWN, hit, 0);

					// Set for double click next time if possible.
					lastHit = hit;
					doubleClickTimer.Stop();
					doubleClickTimer.Start();
				}
			};
		}

		#endregion

		#region Events

		private void CloseButton_MouseEnterDown(object sender, EventArgs e)
		{
			if (!frameIsDark)
				closeButton.Image = Resources.FrameCloseButtonLight;
		}

		private void CloseButton_MouseLeaveUp(object sender, EventArgs e)
		{
			if (!frameIsDark)
				closeButton.Image = Resources.FrameCloseButtonDark;
		}

		#endregion
	}
}