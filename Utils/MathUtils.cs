using static System.Math;

namespace WinFormsCustomFrame.Utils
{
	internal static class MathUtils
	{
		public static int Clamp(int x, int min, int max)
			=> Max(min, Min(max, x));

		public static float Lerp(float a, float b, float t)
			=> a + t * (b - a);
	}
}
