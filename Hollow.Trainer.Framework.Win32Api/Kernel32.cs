using System;
using System.Runtime.InteropServices;

namespace Hollow.Trainer.Framework.Win32Api
{
	internal class Kernel32
	{
		[Flags]
		public enum ProcessAccessFlags
		{
			CreateProcess = 0x80,
			CreateThread = 0x2,
			DuplicateHandle = 0x40,
			QueryInformation = 0x400,
			QueryLimitedInformation = 0x1000,
			SetInformation = 0x200,
			SetQuota = 0x100,
			SuspendResume = 0x800,
			Terminate = 0x1,
			VirtualMemoryOperation = 0x8,
			VirtualMemoryRead = 0x10,
			VirtualMemoryWrite = 0x20,
			Synchronize = 0x100000,
			AllAccess = 0x101FFB
		}

		[Flags]
		public enum PageProtection
		{
			Execute = 0x10,
			ExecuteRead = 0x20,
			ExecuteReadWrite = 0x40,
			ExecuteWriteCopy = 0x80,
			NoAccess = 0x1,
			ReadOnly = 0x2,
			ReadWrite = 0x4,
			WriteCopy = 0x8,
			Guard = 0x100,
			NoCache = 0x200,
			WriteCombine = 0x400
		}

		[Flags]
		public enum MemoryAllocateType
		{
			Commit = 0x1000,
			Reserve = 0x2000,
			Reset = 0x80000,
			ResetUndo = 0x10000000,
			LargePages = 0x20000000,
			Physical = 0x400000,
			TopDown = 0x100000
		}

		[Flags]
		public enum MemoryFreeType
		{
			Decommit = 0x4000,
			Release = 0x8000
		}

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, UIntPtr nSize, out UIntPtr lpNumberOfBytesRead);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, UIntPtr nSize, out UIntPtr lpNumberOfBytesWritten);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool IsWow64Process(IntPtr processHandle, out bool wow64Process);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool CloseHandle(IntPtr hObject);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, MemoryAllocateType flAllocationType, PageProtection flProtect);

		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, MemoryFreeType dwFreeType);

		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("kernel32.dll")]
		public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

		[DllImport("kernel32.dll")]
		public static extern bool GetExitCodeThread(IntPtr hThread, out uint lpExitCode);

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool FreeLibrary(IntPtr hModule);

		[DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
		public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);
	}
}
