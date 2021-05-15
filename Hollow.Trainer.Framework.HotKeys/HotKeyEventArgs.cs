using System;
using System.Windows.Forms;

namespace Hollow.Trainer.Framework.HotKeys
{
	public class HotKeyEventArgs : EventArgs
	{
		public Keys Key
		{
			get;
			private set;
		}

		public KeyModifier Modifiers
		{
			get;
			private set;
		}

		public HotKeyEventArgs(Keys key, KeyModifier modifiers)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			Key = key;
			Modifiers = modifiers;
		}
	}
}
