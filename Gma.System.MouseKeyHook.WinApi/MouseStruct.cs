using System.Runtime.InteropServices;

namespace Gma.System.MouseKeyHook.WinApi
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct MouseStruct
	{
		[FieldOffset(0)]
		public Point Point;

		[FieldOffset(10)]
		public short MouseData;

		[FieldOffset(16)]
		public int Timestamp;
	}
}
