using System;

namespace Gma.System.MouseKeyHook.WinApi
{
	internal class HookResult : IDisposable
	{
		public HookProcedureHandle Handle
		{
			get;
		}

		public HookProcedure Procedure
		{
			get;
		}

		public HookResult(HookProcedureHandle handle, HookProcedure procedure)
		{
			Handle = handle;
			Procedure = procedure;
		}

		public void Dispose()
		{
			Handle.Dispose();
		}
	}
}
