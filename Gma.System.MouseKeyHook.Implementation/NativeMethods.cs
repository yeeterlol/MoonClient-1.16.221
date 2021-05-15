using System.Runtime.InteropServices;

namespace Gma.System.MouseKeyHook.Implementation
{
	internal static class NativeMethods
	{
		private const int SM_CXDRAG = 68;

		private const int SM_CYDRAG = 69;

		[DllImport("user32.dll")]
		private static extern int GetSystemMetrics(int index);

		public static int GetXDragThreshold()
		{
			return GetSystemMetrics(68);
		}

		public static int GetYDragThreshold()
		{
			return GetSystemMetrics(69);
		}
	}
}
