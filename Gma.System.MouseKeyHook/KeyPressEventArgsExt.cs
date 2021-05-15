using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.WinApi;

namespace Gma.System.MouseKeyHook
{
	public class KeyPressEventArgsExt : KeyPressEventArgs
	{
		public bool IsNonChar
		{
			get;
		}

		public int Timestamp
		{
			get;
		}

		internal KeyPressEventArgsExt(char keyChar, int timestamp)
			: this(keyChar)
		{
			IsNonChar = keyChar == '\0';
			Timestamp = timestamp;
		}

		public KeyPressEventArgsExt(char keyChar)
			: this(keyChar, Environment.TickCount)
		{
		}

		internal static IEnumerable<KeyPressEventArgsExt> FromRawDataApp(CallbackData data)
		{
			IntPtr wParam = data.WParam;
			uint flags = (uint)data.LParam.ToInt64();
			bool wasKeyDown = (flags & 0x40000000) != 0;
			bool isKeyReleased = (flags & 0x80000000u) != 0;
			if (!wasKeyDown && !isKeyReleased)
			{
				yield break;
			}
			int virtualKeyCode = (int)wParam;
			int scanCode = checked((int)(flags & 0xFF0000u));
			KeyboardNativeMethods.TryGetCharFromKeyboardState(virtualKeyCode, scanCode, 0, out var chars);
			if (chars != null)
			{
				char[] array = chars;
				foreach (char ch in array)
				{
					yield return new KeyPressEventArgsExt(ch);
				}
			}
		}

		internal static IEnumerable<KeyPressEventArgsExt> FromRawDataGlobal(CallbackData data)
		{
			IntPtr wParam = data.WParam;
			IntPtr lParam = data.LParam;
			if ((int)wParam != 256 && (int)wParam != 260)
			{
				yield break;
			}
			KeyboardHookStruct keyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));
			int virtualKeyCode = keyboardHookStruct.VirtualKeyCode;
			int scanCode = keyboardHookStruct.ScanCode;
			int fuState = keyboardHookStruct.Flags;
			if (virtualKeyCode == 231)
			{
				char ch = (char)scanCode;
				yield return new KeyPressEventArgsExt(ch, keyboardHookStruct.Time);
				yield break;
			}
			KeyboardNativeMethods.TryGetCharFromKeyboardState(virtualKeyCode, scanCode, fuState, out var chars);
			if (chars != null)
			{
				char[] array = chars;
				foreach (char current in array)
				{
					yield return new KeyPressEventArgsExt(current, keyboardHookStruct.Time);
				}
			}
		}
	}
}
