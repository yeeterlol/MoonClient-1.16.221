using System;
using System.Windows.Forms;

namespace Hollow.Trainer.Framework.HotKeys
{
	public class HotKey
	{
		public KeyModifier Modifiers
		{
			get;
			private set;
		}

		public Keys Key
		{
			get;
			private set;
		}

		internal bool IsKeyDown
		{
			get;
			set;
		}

		internal KeyModifier ModifersDown
		{
			get;
			set;
		}

		public event EventHandler<HotKeyEventArgs> OnHotKeyPressed;

		internal HotKey(Keys key, KeyModifier modifiers)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			Key = key;
			Modifiers = modifiers;
		}

		public void Unregister()
		{
			HotKeyFactory.Factory.RemoveHotKey(this);
		}

		internal void OnHotKeyPressedHandler()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			this.OnHotKeyPressed?.Invoke(this, new HotKeyEventArgs(Key, Modifiers));
		}
	}
}
