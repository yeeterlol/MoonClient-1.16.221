using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace memhelp
{
	public class MCM
	{
		public struct RECT
		{
			public int Left;

			public int Top;

			public int Right;

			public int Bottom;
		}

		[Flags]
		public enum AllocationType
		{
			Commit = 0x1000,
			Reserve = 0x2000,
			Decommit = 0x4000,
			Release = 0x8000,
			Reset = 0x80000,
			Physical = 0x400000,
			TopDown = 0x100000,
			WriteWatch = 0x200000,
			LargePages = 0x20000000
		}

		[Flags]
		public enum MemoryProtection
		{
			Execute = 0x10,
			ExecuteRead = 0x20,
			ExecuteReadWrite = 0x40,
			ExecuteWriteCopy = 0x80,
			NoAccess = 0x1,
			ReadOnly = 0x2,
			ReadWrite = 0x4,
			WriteCopy = 0x8,
			GuardModifierflag = 0x100,
			NoCacheModifierflag = 0x200,
			WriteCombineModifierflag = 0x400
		}

		public static IntPtr mcProcHandle;

		public static ProcessModule mcMainModule;

		public static IntPtr mcBaseAddress;

		public static IntPtr mcWinHandle;

		public static uint mcProcId;

		public static uint mcWinProcId;

		public static Process mcProc;

		[DllImport("user32.dll")]
		public static extern bool GetAsyncKeyState(char vKey);

		[DllImport("kernel32", SetLastError = true)]
		public static extern int ReadProcessMemory(IntPtr hProcess, ulong lpBase, ref ulong lpBuffer, int nSize, int lpNumberOfBytesRead);

		[DllImport("kernel32", SetLastError = true)]
		public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, ref IntPtr lpBuffer, int nSize, int lpNumberOfBytesWritten);

		[DllImport("kernel32", SetLastError = true)]
		public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, ref byte lpBuffer, int nSize, int lpNumberOfBytesWritten);

		[DllImport("kernel32", SetLastError = true)]
		public static extern int VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, long flNewProtect, ref long lpflOldProtect);

		[DllImport("kernel32.dll")]
		public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

		[DllImport("user32.dll")]
		private static extern IntPtr GetForegroundWindow();

		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool GetWindow(IntPtr hWnd, uint uCmd);

		[DllImport("user32.dll", SetLastError = true)]
		private static extern bool IsWindowVisible(IntPtr hWnd);

		[DllImport("user32.dll")]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

		[DllImport("kernel32")]
		public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out uint lpThreadId);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);

		public static void openGame()
		{
			Process val = Process.GetProcessesByName("Minecraft.Windows")[0];
			IntPtr intPtr = OpenProcess(2035711, bInheritHandle: false, val.get_Id());
			mcProcId = (uint)val.get_Id();
			mcProcHandle = intPtr;
			mcMainModule = val.get_MainModule();
			mcBaseAddress = mcMainModule.get_BaseAddress();
			mcProc = val;
		}

		public static void openWindowHost()
		{
			Process[] processesByName = Process.GetProcessesByName("ApplicationFrameHost");
			mcWinHandle = processesByName[0].get_MainWindowHandle();
			mcWinProcId = (uint)processesByName[0].get_Id();
		}

		public static RECT getMinecraftRect()
		{
			RECT lpRect = default(RECT);
			GetWindowRect(mcWinHandle, out lpRect);
			return lpRect;
		}

		public static bool isMinecraftFocused()
		{
			StringBuilder stringBuilder = new StringBuilder("Minecraft".Length + 1);
			GetWindowText(GetForegroundWindow(), stringBuilder, "Minecraft".Length + 1);
			return stringBuilder.ToString().CompareTo("Minecraft") == 0;
		}

		public static IntPtr isMinecraftFocusedInsert()
		{
			StringBuilder stringBuilder = new StringBuilder("Minecraft".Length + 1);
			GetWindowText(GetForegroundWindow(), stringBuilder, "Minecraft".Length + 1);
			if (stringBuilder.ToString() == "Minecraft")
			{
				return (IntPtr)(-1);
			}
			return (IntPtr)(-2);
		}

		public static void unprotectMemory(IntPtr address, int bytesToUnprotect)
		{
			long lpflOldProtect = 0L;
			VirtualProtectEx(mcProcHandle, address, bytesToUnprotect, 64L, ref lpflOldProtect);
		}

		public static byte[] ceByte2Bytes(string byteString)
		{
			string[] array = byteString.Split(new char[1]
			{
				' '
			});
			byte[] array2 = new byte[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string value in array3)
			{
				array2[num] = Convert.ToByte(value, 16);
				num++;
			}
			return array2;
		}

		public static int[] ceByte2Ints(string byteString)
		{
			string[] array = byteString.Split(new char[1]
			{
				' '
			});
			int[] array2 = new int[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string s in array3)
			{
				array2[num] = int.Parse(s, NumberStyles.HexNumber);
				num++;
			}
			return array2;
		}

		public static ulong[] ceByte2uLong(string byteString)
		{
			string[] array = byteString.Split(new char[1]
			{
				' '
			});
			ulong[] array2 = new ulong[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string s in array3)
			{
				array2[num] = ulong.Parse(s, NumberStyles.HexNumber);
				num++;
			}
			return array2;
		}

		public static ulong baseEvaluatePointer(ulong offset, ulong[] offsets)
		{
			ulong lpBuffer = 0uL;
			ReadProcessMemory(mcProcHandle, (ulong)(long)mcBaseAddress + offset, ref lpBuffer, 8, 0);
			for (int i = 0; i < offsets.Length - 1; i++)
			{
				ReadProcessMemory(mcProcHandle, lpBuffer + offsets[i], ref lpBuffer, 8, 0);
			}
			return lpBuffer + offsets[^1];
		}

		public static ulong evaluatePointer(ulong addr, ulong[] offsets)
		{
			ulong lpBuffer = 0uL;
			ReadProcessMemory(mcProcHandle, addr, ref lpBuffer, 8, 0);
			for (int i = 0; i < offsets.Length - 1; i++)
			{
				ReadProcessMemory(mcProcHandle, lpBuffer + offsets[i], ref lpBuffer, 8, 0);
			}
			return lpBuffer + offsets[^1];
		}

		public static int readBaseByte(int offset)
		{
			ulong lpBuffer = 0uL;
			ReadProcessMemory(mcProcHandle, (ulong)(long)(mcBaseAddress + offset), ref lpBuffer, 1, 0);
			return (byte)lpBuffer;
		}

		public static int readBaseInt(int offset)
		{
			ulong lpBuffer = 0uL;
			ReadProcessMemory(mcProcHandle, (ulong)(long)(mcBaseAddress + offset), ref lpBuffer, 4, 0);
			return (int)lpBuffer;
		}

		public static ulong readBaseInt64(int offset)
		{
			ulong lpBuffer = 0uL;
			ReadProcessMemory(mcProcHandle, (ulong)(long)(mcBaseAddress + offset), ref lpBuffer, 8, 0);
			return lpBuffer;
		}

		public static void writeBaseByte(int offset, byte value)
		{
			WriteProcessMemory(mcProcHandle, mcBaseAddress + offset, ref value, 1, 0);
		}

		public static void writeBaseInt(int offset, int value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			int num = 0;
			byte[] array = bytes;
			foreach (byte value2 in array)
			{
				writeBaseByte(offset + num, value2);
				num++;
			}
		}

		public static void writeBaseBytes(int offset, byte[] value)
		{
			int num = 0;
			foreach (byte value2 in value)
			{
				writeBaseByte(offset + num, value2);
				num++;
			}
		}

		public static void writeBaseFloat(int offset, float value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			int num = 0;
			byte[] array = bytes;
			foreach (byte value2 in array)
			{
				writeBaseByte(offset + num, value2);
				num++;
			}
		}

		public static void writeBaseInt64(int offset, ulong value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			int num = 0;
			byte[] array = bytes;
			foreach (byte value2 in array)
			{
				writeBaseByte(offset + num, value2);
				num++;
			}
		}

		public static byte readByte(ulong address)
		{
			ulong lpBuffer = 0uL;
			ReadProcessMemory(mcProcHandle, address, ref lpBuffer, 1, 0);
			return (byte)lpBuffer;
		}

		public static int readInt(ulong address)
		{
			ulong lpBuffer = 0uL;
			ReadProcessMemory(mcProcHandle, address, ref lpBuffer, 4, 0);
			return (int)lpBuffer;
		}

		public static float readFloat(ulong address)
		{
			ulong lpBuffer = 0uL;
			ReadProcessMemory(mcProcHandle, address, ref lpBuffer, 4, 0);
			return BitConverter.ToSingle(BitConverter.GetBytes(lpBuffer), 0);
		}

		public static ulong readInt64(ulong address)
		{
			ulong lpBuffer = 0uL;
			ReadProcessMemory(mcProcHandle, address, ref lpBuffer, 8, 0);
			return lpBuffer;
		}

		public static string readString(ulong address, ulong length)
		{
			byte[] array = new byte[length];
			int num = 0;
			byte[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				_ = array2[i];
				byte b = readByte(address + (ulong)num);
				if (b == 0)
				{
					break;
				}
				array[num] = b;
				num++;
			}
			return new string(Enumerable.ToArray<char>(Enumerable.Take<char>((IEnumerable<char>)Encoding.Default.GetString(array), num)));
		}

		public static void writeByte(ulong address, byte value)
		{
			WriteProcessMemory(mcProcHandle, (IntPtr)(long)address, ref value, 1, 0);
		}

		public static void writeBytes(ulong address, byte[] value)
		{
			int num = 0;
			foreach (byte value2 in value)
			{
				writeByte(address + (ulong)num, value2);
				num++;
			}
		}

		public static void writeInt(ulong address, int value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			int num = 0;
			byte[] array = bytes;
			foreach (byte value2 in array)
			{
				writeByte(address + (ulong)num, value2);
				num++;
			}
		}

		public static void writeFloat(ulong address, float value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			int num = 0;
			byte[] array = bytes;
			foreach (byte value2 in array)
			{
				writeByte(address + (ulong)num, value2);
				num++;
			}
		}

		public static void writeInt64(ulong address, ulong value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			int num = 0;
			byte[] array = bytes;
			foreach (byte value2 in array)
			{
				writeByte(address + (ulong)num, value2);
				num++;
			}
		}

		public static void writeString(ulong address, string str)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(str);
			int num = 0;
			byte[] array = bytes;
			foreach (byte value in array)
			{
				writeByte(address + (ulong)num, value);
				num++;
			}
		}
	}
}
