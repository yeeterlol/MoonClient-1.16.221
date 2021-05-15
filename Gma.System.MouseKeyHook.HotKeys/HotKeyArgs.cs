using System;

namespace Gma.System.MouseKeyHook.HotKeys
{
	public sealed class HotKeyArgs : EventArgs
	{
		public DateTime Time
		{
			get;
		}

		public HotKeyArgs(DateTime triggeredAt)
		{
			Time = triggeredAt;
		}
	}
}
