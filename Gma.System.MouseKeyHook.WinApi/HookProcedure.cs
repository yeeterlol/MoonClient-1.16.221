using System;

namespace Gma.System.MouseKeyHook.WinApi
{
	public delegate IntPtr HookProcedure(int nCode, IntPtr wParam, IntPtr lParam);
}
