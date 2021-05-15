using System.Runtime.InteropServices;

namespace Gma.System.MouseKeyHook.WinApi
{
	internal static class MouseNativeMethods
	{
		[DllImport("user32")]
		internal static extern int GetDoubleClickTime();
	}
}
