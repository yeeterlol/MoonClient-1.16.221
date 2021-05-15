using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.WinApi;

namespace Gma.System.MouseKeyHook
{
	public class KeyEventArgsExt : KeyEventArgs
	{
		public int ScanCode
		{
			get;
		}

		public int Timestamp
		{
			get;
		}

		public bool IsKeyDown
		{
			get;
		}

		public bool IsKeyUp
		{
			get;
		}

		public bool IsExtendedKey
		{
			get;
		}

		public KeyEventArgsExt(Keys keyData)
			: this(keyData)
		{
		}//IL_0001: Unknown result type (might be due to invalid IL or missing references)


		internal KeyEventArgsExt(Keys keyData, int scanCode, int timestamp, bool isKeyDown, bool isKeyUp, bool isExtendedKey)
			: this(keyData)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			ScanCode = scanCode;
			Timestamp = timestamp;
			IsKeyDown = isKeyDown;
			IsKeyUp = isKeyUp;
			IsExtendedKey = isExtendedKey;
		}

		internal static KeyEventArgsExt FromRawDataApp(CallbackData data)
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			IntPtr wParam = data.WParam;
			IntPtr lParam = data.LParam;
			int tickCount = Environment.TickCount;
			uint num = (uint)lParam.ToInt64();
			bool flag = (num & 0x40000000) != 0;
			bool flag2 = (num & 0x80000000u) != 0;
			bool isExtendedKey = (num & 0x1000000) != 0;
			Keys keyData = AppendModifierStates((Keys)(int)wParam);
			int scanCode = (int)(((num & 0x10000) | (num & 0x20000) | (num & 0x40000) | (num & 0x80000) | (num & 0x100000) | (num & 0x200000) | (num & 0x400000) | (num & 0x800000)) >> 16);
			bool isKeyDown = !flag2;
			bool isKeyUp = flag && flag2;
			return new KeyEventArgsExt(keyData, scanCode, tickCount, isKeyDown, isKeyUp, isExtendedKey);
		}

		internal static KeyEventArgsExt FromRawDataGlobal(CallbackData data)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			IntPtr wParam = data.WParam;
			IntPtr lParam = data.LParam;
			KeyboardHookStruct keyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
			Keys keyData = AppendModifierStates((Keys)keyboardHookStruct.VirtualKeyCode);
			int num = (int)wParam;
			bool isKeyDown = num == 256 || num == 260;
			bool isKeyUp = num == 257 || num == 261;
			bool isExtendedKey = (long)((ulong)keyboardHookStruct.Flags & 1uL) > 0L;
			return new KeyEventArgsExt(keyData, keyboardHookStruct.ScanCode, keyboardHookStruct.Time, isKeyDown, isKeyUp, isExtendedKey);
		}

		private static bool CheckModifier(int vKey)
		{
			return (KeyboardNativeMethods.GetKeyState(vKey) & 0x8000) > 0;
		}

		private static Keys AppendModifierStates(Keys keyData)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			bool flag = CheckModifier(17);
			bool flag2 = CheckModifier(16);
			bool flag3 = CheckModifier(18);
			return (Keys)(keyData | (flag ? 131072 : 0) | (flag2 ? 65536 : 0) | (flag3 ? 262144 : 0));
		}
	}
}
