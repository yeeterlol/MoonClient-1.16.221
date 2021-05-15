using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Hollow.Trainer.Framework.HotKeys;
using Hollow.Trainer.Framework.Win32Api;

namespace Hollow.Trainer.Framework
{
	public abstract class TrainerBase : IDisposable
	{
		public ProcessManager Process
		{
			get;
			private set;
		}

		public MemoryOperations Memory
		{
			get;
			private set;
		}

		private bool IsDisposing
		{
			get;
			set;
		}

		public abstract void RegisterHotKeys();

		public abstract void AddTrainerItem(ITrainerItem item);

		protected void OpenProcess(string processName)
		{
			Process = new ProcessManager(processName);
			Memory = new MemoryOperations(Process);
		}

		protected bool InjectManagedDll(string fullPath, string fullClassName, string methodName, string argument)
		{
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			if (!Process.AdjustPrivilege("SeDebugPrivilege", enable: true))
			{
				return false;
			}
			IntPtr procAddress = Kernel32.GetProcAddress(Kernel32.GetModuleHandle("kernel32"), "LoadLibraryW");
			Memory.InjectThread(procAddress, GetManagedBootstrapPath());
			ProcessModuleCollection modules = Process.TargetProcess.get_Modules();
			ProcessModule val = null;
			foreach (ProcessModule item in (ReadOnlyCollectionBase)modules)
			{
				ProcessModule val2 = item;
				if (Path.GetFileName(val2.get_FileName())!.ToLower() == "managedbootstrap.dll")
				{
					val = val2;
				}
			}
			IntPtr functionOffset = GetFunctionOffset("ManagedBootstrap.dll", "ImplantDotNetAssembly");
			IntPtr fnFunction = (Process.Is64Bit ? new IntPtr(val.get_BaseAddress().ToInt64() + functionOffset.ToInt64()) : new IntPtr(val.get_BaseAddress().ToInt32() + functionOffset.ToInt32()));
			string argument2 = fullPath + ";" + fullClassName + ";" + methodName + ";" + argument;
			Memory.InjectThread(fnFunction, argument2);
			IntPtr procAddress2 = Kernel32.GetProcAddress(Kernel32.GetModuleHandle("kernel32"), "FreeLibrary");
			Kernel32.CreateRemoteThread(Process.TargetProcessHandle, IntPtr.Zero, 0u, procAddress2, val.get_BaseAddress(), 0u, IntPtr.Zero);
			return true;
		}

		internal string GetManagedBootstrapPath()
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			return Path.Combine(directoryName, "ManagedBootstrap.dll");
		}

		internal IntPtr GetFunctionOffset(string library, string procName)
		{
			IntPtr hModule = Kernel32.LoadLibrary(library);
			IntPtr procAddress = Kernel32.GetProcAddress(hModule, procName);
			IntPtr result = (Process.Is64Bit ? new IntPtr(procAddress.ToInt64() - hModule.ToInt64()) : new IntPtr(procAddress.ToInt32() - hModule.ToInt32()));
			Kernel32.FreeLibrary(hModule);
			return result;
		}

		protected void ReleaseProcess()
		{
			Process.Dispose();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!IsDisposing)
			{
				if (disposing)
				{
					Process.Dispose();
					HotKeyFactory.Factory.Dispose();
				}
				Memory = null;
				IsDisposing = true;
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
		}
	}
}
