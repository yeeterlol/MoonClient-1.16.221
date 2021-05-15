using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Gma.System.MouseKeyHook.Implementation;

namespace Gma.System.MouseKeyHook.WinApi
{
	internal static class HookHelper
	{
		private static HookProcedure _appHookProc;

		private static HookProcedure _globalHookProc;

		public static HookResult HookAppMouse(Callback callback)
		{
			return HookApp(7, callback);
		}

		public static HookResult HookAppKeyboard(Callback callback)
		{
			return HookApp(2, callback);
		}

		public static HookResult HookGlobalMouse(Callback callback)
		{
			return HookGlobal(14, callback);
		}

		public static HookResult HookGlobalKeyboard(Callback callback)
		{
			return HookGlobal(13, callback);
		}

		private static HookResult HookApp(int hookId, Callback callback)
		{
			_appHookProc = (int code, IntPtr param, IntPtr lParam) => HookProcedure(code, param, lParam, callback);
			HookProcedureHandle hookProcedureHandle = HookNativeMethods.SetWindowsHookEx(hookId, _appHookProc, IntPtr.Zero, ThreadNativeMethods.GetCurrentThreadId());
			if (hookProcedureHandle.IsInvalid)
			{
				ThrowLastUnmanagedErrorAsException();
			}
			return new HookResult(hookProcedureHandle, _appHookProc);
		}

		private static HookResult HookGlobal(int hookId, Callback callback)
		{
			_globalHookProc = (int code, IntPtr param, IntPtr lParam) => HookProcedure(code, param, lParam, callback);
			HookProcedureHandle hookProcedureHandle = HookNativeMethods.SetWindowsHookEx(hookId, _globalHookProc, Process.GetCurrentProcess().get_MainModule().get_BaseAddress(), 0);
			if (hookProcedureHandle.IsInvalid)
			{
				ThrowLastUnmanagedErrorAsException();
			}
			return new HookResult(hookProcedureHandle, _globalHookProc);
		}

		private static IntPtr HookProcedure(int nCode, IntPtr wParam, IntPtr lParam, Callback callback)
		{
			if (nCode != 0)
			{
				return CallNextHookEx(nCode, wParam, lParam);
			}
			CallbackData data = new CallbackData(wParam, lParam);
			if (!callback(data))
			{
				return new IntPtr(-1);
			}
			return CallNextHookEx(nCode, wParam, lParam);
		}

		private static IntPtr CallNextHookEx(int nCode, IntPtr wParam, IntPtr lParam)
		{
			return HookNativeMethods.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
		}

		private static void ThrowLastUnmanagedErrorAsException()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			int lastWin32Error = Marshal.GetLastWin32Error();
			throw new Win32Exception(lastWin32Error);
		}
	}
}
