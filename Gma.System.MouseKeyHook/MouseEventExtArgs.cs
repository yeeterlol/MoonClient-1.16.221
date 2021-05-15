using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.WinApi;

namespace Gma.System.MouseKeyHook
{
	public class MouseEventExtArgs : MouseEventArgs
	{
		public bool Handled
		{
			get;
			set;
		}

		public bool WheelScrolled => ((MouseEventArgs)this).get_Delta() != 0;

		public bool Clicked => ((MouseEventArgs)this).get_Clicks() > 0;

		public bool IsMouseButtonDown
		{
			get;
		}

		public bool IsMouseButtonUp
		{
			get;
		}

		public int Timestamp
		{
			get;
		}

		internal Point Point => new Point(((MouseEventArgs)this).get_X(), ((MouseEventArgs)this).get_Y());

		internal MouseEventExtArgs(MouseButtons buttons, int clicks, Point point, int delta, int timestamp, bool isMouseButtonDown, bool isMouseButtonUp)
			: this(buttons, clicks, point.X, point.Y, delta)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			IsMouseButtonDown = isMouseButtonDown;
			IsMouseButtonUp = isMouseButtonUp;
			Timestamp = timestamp;
		}

		internal static MouseEventExtArgs FromRawDataApp(CallbackData data)
		{
			IntPtr wParam = data.WParam;
			IntPtr lParam = data.LParam;
			return FromRawDataUniversal(wParam, ((AppMouseStruct)Marshal.PtrToStructure(lParam, typeof(AppMouseStruct))).ToMouseStruct());
		}

		internal static MouseEventExtArgs FromRawDataGlobal(CallbackData data)
		{
			IntPtr wParam = data.WParam;
			IntPtr lParam = data.LParam;
			MouseStruct mouseInfo = (MouseStruct)Marshal.PtrToStructure(lParam, typeof(MouseStruct));
			return FromRawDataUniversal(wParam, mouseInfo);
		}

		private static MouseEventExtArgs FromRawDataUniversal(IntPtr wParam, MouseStruct mouseInfo)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			MouseButtons buttons = (MouseButtons)0;
			short delta = 0;
			int clicks = 0;
			bool isMouseButtonDown = false;
			bool isMouseButtonUp = false;
			long num = (long)wParam;
			long num2 = num - 513;
			if ((ulong)num2 <= 13uL)
			{
				switch (num2)
				{
				case 0L:
					isMouseButtonDown = true;
					buttons = (MouseButtons)1048576;
					clicks = 1;
					break;
				case 1L:
					isMouseButtonUp = true;
					buttons = (MouseButtons)1048576;
					clicks = 1;
					break;
				case 2L:
					isMouseButtonDown = true;
					buttons = (MouseButtons)1048576;
					clicks = 2;
					break;
				case 3L:
					isMouseButtonDown = true;
					buttons = (MouseButtons)2097152;
					clicks = 1;
					break;
				case 4L:
					isMouseButtonUp = true;
					buttons = (MouseButtons)2097152;
					clicks = 1;
					break;
				case 5L:
					isMouseButtonDown = true;
					buttons = (MouseButtons)2097152;
					clicks = 2;
					break;
				case 6L:
					isMouseButtonDown = true;
					buttons = (MouseButtons)4194304;
					clicks = 1;
					break;
				case 7L:
					isMouseButtonUp = true;
					buttons = (MouseButtons)4194304;
					clicks = 1;
					break;
				case 8L:
					isMouseButtonDown = true;
					buttons = (MouseButtons)4194304;
					clicks = 2;
					break;
				case 9L:
					delta = mouseInfo.MouseData;
					break;
				case 10L:
					buttons = (MouseButtons)((mouseInfo.MouseData == 1) ? 8388608 : 16777216);
					isMouseButtonDown = true;
					clicks = 1;
					break;
				case 11L:
					buttons = (MouseButtons)((mouseInfo.MouseData == 1) ? 8388608 : 16777216);
					isMouseButtonUp = true;
					clicks = 1;
					break;
				case 12L:
					isMouseButtonDown = true;
					buttons = (MouseButtons)((mouseInfo.MouseData == 1) ? 8388608 : 16777216);
					clicks = 2;
					break;
				case 13L:
					delta = mouseInfo.MouseData;
					break;
				}
			}
			return new MouseEventExtArgs(buttons, clicks, mouseInfo.Point, delta, mouseInfo.Timestamp, isMouseButtonDown, isMouseButtonUp);
		}

		internal MouseEventExtArgs ToDoubleClickEventArgs()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return new MouseEventExtArgs(((MouseEventArgs)this).get_Button(), 2, Point, ((MouseEventArgs)this).get_Delta(), Timestamp, IsMouseButtonDown, IsMouseButtonUp);
		}
	}
}
