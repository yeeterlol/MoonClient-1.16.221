using System;

namespace Gma.System.MouseKeyHook.WinApi
{
	internal struct CallbackData
	{
		public IntPtr WParam
		{
			get;
		}

		public IntPtr LParam
		{
			get;
		}

		public CallbackData(IntPtr wParam, IntPtr lParam)
		{
			WParam = wParam;
			LParam = lParam;
		}
	}
}
