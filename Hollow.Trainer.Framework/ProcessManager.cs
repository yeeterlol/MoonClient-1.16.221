using System;
using System.ComponentModel;
using System.Diagnostics;
using Hollow.Trainer.Framework.Win32Api;

namespace Hollow.Trainer.Framework
{
	public class ProcessManager : IDisposable
	{
		private bool disposedValue = false;

		public Process TargetProcess
		{
			get;
			set;
		}

		public IntPtr TargetProcessHandle
		{
			get;
			set;
		}

		public bool Is64Bit
		{
			get
			{
				if (Environment.OSVersion.Version.Major > 5 || (Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1))
				{
					try
					{
						bool wow64Process;
						return !(Kernel32.IsWow64Process(TargetProcess.get_Handle(), out wow64Process) && wow64Process);
					}
					catch
					{
						return false;
					}
				}
				return false;
			}
		}

		internal ProcessManager(string processName)
		{
			Process[] processesByName = Process.GetProcessesByName(processName);
			if (processesByName.Length == 0)
			{
				throw new Exception("TODO: Error no process found");
			}
			if (processesByName.Length > 1)
			{
				throw new Exception("TODO: more than 1 process found");
			}
			TargetProcess = processesByName[0];
			IntPtr intPtr = Kernel32.OpenProcess(Kernel32.ProcessAccessFlags.CreateThread | Kernel32.ProcessAccessFlags.QueryInformation | Kernel32.ProcessAccessFlags.VirtualMemoryOperation | Kernel32.ProcessAccessFlags.VirtualMemoryRead | Kernel32.ProcessAccessFlags.VirtualMemoryWrite, bInheritHandle: false, TargetProcess.get_Id());
			if (intPtr == IntPtr.Zero)
			{
				throw new Exception("TODO: Error opening process");
			}
			TargetProcessHandle = intPtr;
		}

		public bool AdjustPrivilege(string privilegeName, bool enable)
		{
			if (TargetProcessHandle == IntPtr.Zero)
			{
				return false;
			}
			if (!Advapi32.OpenProcessToken(TargetProcessHandle, 40u, out var TokenHandle))
			{
				return false;
			}
			Advapi32.TOKEN_PRIVILEGES NewState = default(Advapi32.TOKEN_PRIVILEGES);
			NewState.PrivilegeCount = 1u;
			NewState.Privileges = new Advapi32.LUID_AND_ATTRIBUTES[1];
			NewState.Privileges[0].Attributes = (enable ? 2u : 0u);
			if (!Advapi32.LookupPrivilegeValue(null, privilegeName, out NewState.Privileges[0].Luid))
			{
				Kernel32.CloseHandle(TokenHandle);
				return false;
			}
			bool result = Advapi32.AdjustTokenPrivileges(TokenHandle, DisableAllPrivileges: false, ref NewState, 0u, IntPtr.Zero, IntPtr.Zero);
			Kernel32.CloseHandle(TokenHandle);
			return result;
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					((Component)TargetProcess).Dispose();
				}
				Kernel32.CloseHandle(TargetProcessHandle);
				disposedValue = true;
			}
		}

		~ProcessManager()
		{
			Dispose(disposing: false);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}
	}
}
