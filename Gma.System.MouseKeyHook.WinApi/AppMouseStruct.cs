using System;
using System.Runtime.InteropServices;

namespace Gma.System.MouseKeyHook.WinApi
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct AppMouseStruct
	{
		[FieldOffset(0)]
		public Point Point;

		[FieldOffset(22)]
		public short MouseData_x86;

		[FieldOffset(34)]
		public short MouseData_x64;

		public MouseStruct ToMouseStruct()
		{
			MouseStruct result = default(MouseStruct);
			result.Point = Point;
			result.MouseData = ((IntPtr.Size == 4) ? MouseData_x86 : MouseData_x64);
			result.Timestamp = Environment.TickCount;
			return result;
		}
	}
}
