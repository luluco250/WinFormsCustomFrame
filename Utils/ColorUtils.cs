using System;
using System.Drawing;

namespace WinFormsCustomFrame.Utils
{
	internal static class ColorUtils
	{
		public static Color ColorFromDwordArgb(int colorDword)
		{
			int a = (int)((colorDword & 0xFF000000) >> 32);
			int r = (colorDword & 0x00FF0000) >> 16;
			int g = (colorDword & 0x0000FF00) >> 8;
			int b = colorDword & 0x000000FF;

			return Color.FromArgb(a, r, g, b);
		}

		public static int GetColorLuminance(Color color)
			=> Math.Max(color.R, Math.Max(color.G, color.B));

		public static Color Add(Color color, int add)
		{
			return Color.FromArgb(
				color.A,
				MathUtils.Clamp(color.R + add, 0, 255),
				MathUtils.Clamp(color.G + add, 0, 255),
				MathUtils.Clamp(color.B + add, 0, 255)
			);
		}

		public static Color Lerp(Color a, Color b, float t)
		{
			return Color.FromArgb(
				(int)MathUtils.Lerp(a.A, b.A, t),
				(int)MathUtils.Lerp(a.R, b.R, t),
				(int)MathUtils.Lerp(a.G, b.G, t),
				(int)MathUtils.Lerp(a.B, b.B, t)
			);
		}
	}
}
