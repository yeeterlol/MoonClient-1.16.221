using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.WinApi;

namespace Gma.System.MouseKeyHook.Implementation
{
	public class KeyboardState
	{
		private readonly byte[] m_KeyboardStateNative;

		private KeyboardState(byte[] keyboardStateNative)
		{
			m_KeyboardStateNative = keyboardStateNative;
		}

		public static KeyboardState GetCurrent()
		{
			byte[] array = new byte[256];
			KeyboardNativeMethods.GetKeyboardState(array);
			return new KeyboardState(array);
		}

		internal byte[] GetNativeState()
		{
			return m_KeyboardStateNative;
		}

		public bool IsDown(Keys key)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Invalid comparison between Unknown and I4
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Invalid comparison between Unknown and I4
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Invalid comparison between Unknown and I4
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Invalid comparison between Unknown and I4
			if ((int)key < 256)
			{
				return IsDownRaw(key);
			}
			if ((int)key == 262144)
			{
				return IsDownRaw((Keys)164) || IsDownRaw((Keys)165);
			}
			if ((int)key == 65536)
			{
				return IsDownRaw((Keys)160) || IsDownRaw((Keys)161);
			}
			if ((int)key == 131072)
			{
				return IsDownRaw((Keys)162) || IsDownRaw((Keys)163);
			}
			return false;
		}

		private bool IsDownRaw(Keys key)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			byte keyState = GetKeyState(key);
			return GetHighBit(keyState);
		}

		public bool IsToggled(Keys key)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			byte keyState = GetKeyState(key);
			return GetLowBit(keyState);
		}

		public bool AreAllDown(IEnumerable<Keys> keys)
		{
			return Enumerable.All<Keys>(keys, (Func<Keys, bool>)IsDown);
		}

		private byte GetKeyState(Keys key)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Expected I4, but got Unknown
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			int num = (int)key;
			if (num < 0 || num > 255)
			{
				throw new ArgumentOutOfRangeException("key", key, "The value must be between 0 and 255.");
			}
			return m_KeyboardStateNative[num];
		}

		private static bool GetHighBit(byte value)
		{
			return value >> 7 != 0;
		}

		private static bool GetLowBit(byte value)
		{
			return (value & 1) != 0;
		}
	}
}
