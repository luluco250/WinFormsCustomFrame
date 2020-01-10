using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace WinFormsCustomFrame.Win32
{
	internal static class NativeMethods
	{
		[DllImport("user32.dll")]
		public extern static int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

		public static int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam)
			=> SendMessage(hWnd, (uint)msg, (IntPtr)wParam, (IntPtr)lParam);

		[DllImport("dwmapi.dll")]
		public extern static int DwmGetColorizationColor(out int pcrColorization, out int pfOpaqueBlend);

		public static int DwmGetColorizationColor(out Color color, out bool isOpaque)
		{
			int result = DwmGetColorizationColor(out int colorDword, out int isOpaqueInt);

			color = ColorTranslator.FromWin32(colorDword);
			isOpaque = isOpaqueInt == 1;
			return result;
		}

		[DllImport("user32.dll")]
		public extern static int ReleaseCapture();
	}
}
