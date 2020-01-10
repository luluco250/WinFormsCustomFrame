namespace WinFormsCustomFrame.Win32
{
	internal static class Constants
	{
		// Window Messages
		public const int WM_MOVE = 0x0003;
		public const int WM_SIZE = 0x0005;
		public const int WM_NCCALCSIZE = 0x0083;
		public const int WM_NCHITTEST = 0x0084;
		public const int WM_NCLBUTTONDOWN = 0x00A1;
		public const int WM_NCLBUTTONUP = 0x00A2;
		public const int WM_NCLBUTTONDBLCLK = 0x00A3;
		public const int WM_NCRBUTTONDOWN = 0x00A4;
		public const int WM_MOUSEMOVE = 0x0200;
		public const int WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320;

		// Window Styles
		public const int WS_SYSMENU = 0x00080000;

		// Extended Window Styles
		public const int WS_EX_COMPOSITED = 0x02000000;

		// Class Styles
		public const int CS_DROPSHADOW = 0x00020000;

		// WM_SIZE Parameters
		public const int SIZE_RESTORED = 0;
		public const int SIZE_MINIMIZED = 1;
		public const int SIZE_MAXIMIZED = 2;
		public const int SIZE_MAXSHOW = 3;
		public const int SIZE_MAXHIDE = 4;

		// WM_NCHITTEST Results
		public const int HTSIZE = 4;
		public const int HTMINBUTTON = 8;
		public const int HTMAXBUTTON = 9;
		public const int HTTRANSPARENT = -1;
		public const int HTCAPTION = 2;
		public const int HTSYSMENU = 3;
		public const int HTLEFT = 10;
		public const int HTRIGHT = 11;
		public const int HTTOP = 12;
		public const int HTTOPLEFT = 13;
		public const int HTTOPRIGHT = 14;
		public const int HTBOTTOM = 15;
		public const int HTBOTTOMLEFT = 16;
		public const int HTBOTTOMRIGHT = 17;
		public const int HTCLOSE = 20;
	}
}
