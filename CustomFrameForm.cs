using static WinFormsCustomFrame.Win32.Constants;
using static WinFormsCustomFrame.Win32.NativeMethods;

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using WinFormsCustomFrame.Utils;
using WinFormsCustomFrame.Properties;

namespace WinFormsCustomFrame
{
	public partial class CustomFrameForm : Form
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

		// TODO: Implement extra caption control.
		/*public Control CaptionExtraControl
		{
			get { return _CaptionExtraControl; }
			set
			{
				if (CaptionExtraControl == value)
					return;

				if (CaptionExtraControl != null)
					Controls.Remove(CaptionExtraControl);

				_CaptionExtraControl = value;

				if ()
			}
		}
		private Control _CaptionExtraControl;*/

		#endregion

		#region State

		private bool frameIsDark;
		private bool isMaximized;
		private int lastHit;
		private Stopwatch doubleClickTimer = new Stopwatch();
		private Rectangle mouseDblClkRect;

		#endregion

		#region Setup

		public CustomFrameForm()
		{
			InitializeComponent();
			SetupStyling();
			SetupEvents();
		}

		protected override void WndProc(ref Message m)
		{
			if (!DesignMode) switch (m.Msg)
			{
			case WM_MOVE:
				ResetDoubleClick();
				m.Result = IntPtr.Zero;
				break;
			case WM_SIZE:
				ResetDoubleClick();

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
				m.Result = IntPtr.Zero;
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

				Console.WriteLine($"{ctrl.Name} {hit} {lastHit}");

				if (e.Button == MouseButtons.Right)
				{
					PostMessage(Handle, WM_NCRBUTTONDOWN, hit, 0);
					return;
				}
				
				if (IsDoubleClick(hit))
				{
					PostMessage(Handle, WM_NCLBUTTONDBLCLK, hit, 0);
					ResetDoubleClick();
				}
				else
				{
					PostMessage(Handle, WM_NCLBUTTONDOWN, hit, 0);
					SetupDoubleClick(hit);
				}
			};
		}

		private void SetupDoubleClick(int hit, bool log = true)
		{
			lastHit = hit;
			mouseDblClkRect = new Rectangle(
				MousePosition,
				SystemInformation.DoubleClickSize
			);
			mouseDblClkRect.X -= mouseDblClkRect.Width / 2;
			mouseDblClkRect.Y -= mouseDblClkRect.Height / 2;

			if (log)
				Console.WriteLine("Double click setup");

			doubleClickTimer.Restart();
		}

		private void ResetDoubleClick(bool log = true)
		{
			doubleClickTimer.Stop();

			lastHit = 0;
			mouseDblClkRect = Rectangle.Empty;

			if (log)
				Console.WriteLine("Double click reset");
		}

		private bool IsDoubleClick(int hit) =>
			doubleClickTimer.ElapsedMilliseconds <= SystemInformation.DoubleClickTime &&
			lastHit != 0 && lastHit == hit &&
			mouseDblClkRect.Contains(MousePosition);

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