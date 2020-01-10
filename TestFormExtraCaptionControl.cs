using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCustomFrame
{
	public partial class TestFormExtraCaptionControl : UserControl
	{
		public TestFormExtraCaptionControl()
		{
			InitializeComponent();
			SetupEvents();
		}

		private void SetupEvents()
		{
			prevScreen.Click += (_, e) => MoveToScreen(-1);
			nextScreen.Click += (_, e) => MoveToScreen(1);
		}

		private void MoveToScreen(int increment)
		{
			// Find the destination screen.
			var screens = Screen.AllScreens.ToList();
			var curr = screens.FindIndex(s => s.Equals(Screen.FromControl(this)));
			var dst = Mod(curr + increment, screens.Count);

			Console.WriteLine($"{curr} -> {dst}");

			// Move window to it.
			var form = FindForm();
			bool max = form.WindowState == FormWindowState.Maximized;

			if (max)
				form.WindowState = FormWindowState.Normal;

			var rect = screens[dst].WorkingArea;

			if (max)
			{
				form.Location = rect.Location;
				form.WindowState = FormWindowState.Maximized;
			}
			else
			{
				form.Left = rect.X + rect.Width / 2 - form.Width / 2;
				form.Top = rect.Y + rect.Height / 2 - form.Height / 2;
			}
		}

		private static int Mod(int x, int m)
			=> (x % m + m) % m;
	}
}
