using System.Collections.Generic;
using Gma.System.MouseKeyHook.WinApi;

namespace Gma.System.MouseKeyHook.Implementation
{
	internal class GlobalKeyListener : KeyListener
	{
		public GlobalKeyListener()
			: base(HookHelper.HookGlobalKeyboard)
		{
		}

		protected override IEnumerable<KeyPressEventArgsExt> GetPressEventArgs(CallbackData data)
		{
			return KeyPressEventArgsExt.FromRawDataGlobal(data);
		}

		protected override KeyEventArgsExt GetDownUpEventArgs(CallbackData data)
		{
			return KeyEventArgsExt.FromRawDataGlobal(data);
		}
	}
}
