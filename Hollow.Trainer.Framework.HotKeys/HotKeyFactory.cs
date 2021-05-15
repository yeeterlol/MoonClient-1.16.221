using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Hollow.Trainer.Framework.HotKeys
{
	public class HotKeyFactory : IDisposable
	{
		private Thread thread;

		private bool shutdown = false;

		private Dictionary<Keys, HotKey> hotKeyItems = new Dictionary<Keys, HotKey>();

		private object _lockObj = new object();

		public static HotKeyFactory Factory
		{
			get;
			private set;
		}

		public bool IsDisposed
		{
			get;
			private set;
		}

		[DllImport("user32.dll")]
		private static extern short GetAsyncKeyState(Keys key);

		static HotKeyFactory()
		{
			Factory = new HotKeyFactory();
		}

		private HotKeyFactory()
		{
			thread = new Thread(new ThreadStart(ThreadProc));
			thread.Start();
		}

		public HotKey RegisterHotKey(Keys key, KeyModifier modfiers = KeyModifier.None)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			HotKey hotKey = new HotKey(key, modfiers);
			lock (_lockObj)
			{
				hotKeyItems.Add(key, hotKey);
			}
			return hotKey;
		}

		internal void RemoveHotKey(HotKey hotKey)
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			lock (_lockObj)
			{
				if (hotKeyItems.ContainsKey(hotKey.Key))
				{
					hotKeyItems.Remove(hotKey.Key);
				}
			}
		}

		private void ThreadProc()
		{
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			while (!shutdown)
			{
				lock (_lockObj)
				{
					foreach (HotKey value in hotKeyItems.Values)
					{
						if ((GetAsyncKeyState(value.Key) & 0x8000) == 32768)
						{
							value.IsKeyDown = true;
						}
						if (value.Modifiers != 0)
						{
							if ((value.Modifiers & KeyModifier.Alt) == KeyModifier.Alt)
							{
								if ((GetAsyncKeyState((Keys)18) & 0x8000) == 32768)
								{
									value.ModifersDown |= KeyModifier.Alt;
								}
								else
								{
									value.ModifersDown -= (int)(value.ModifersDown & KeyModifier.Alt);
								}
							}
							if ((value.Modifiers & KeyModifier.Ctrl) == KeyModifier.Ctrl)
							{
								if ((GetAsyncKeyState((Keys)17) & 0x8000) == 32768)
								{
									value.ModifersDown |= KeyModifier.Ctrl;
								}
								else
								{
									value.ModifersDown -= (int)(value.ModifersDown & KeyModifier.Ctrl);
								}
							}
							if ((value.Modifiers & KeyModifier.Shift) == KeyModifier.Shift)
							{
								if ((GetAsyncKeyState((Keys)16) & 0x8000) == 32768)
								{
									value.ModifersDown |= KeyModifier.Shift;
								}
								else
								{
									value.ModifersDown -= (int)(value.ModifersDown & KeyModifier.Shift);
								}
							}
							if ((value.Modifiers & KeyModifier.Win) == KeyModifier.Win)
							{
								if ((GetAsyncKeyState((Keys)91) & 0x8000) == 32768)
								{
									value.ModifersDown |= KeyModifier.Win;
								}
								else
								{
									value.ModifersDown -= (int)(value.ModifersDown & KeyModifier.Win);
								}
								if ((value.ModifersDown & KeyModifier.Win) != KeyModifier.Win)
								{
									if ((GetAsyncKeyState((Keys)92) & 0x8000) == 32768)
									{
										value.ModifersDown |= KeyModifier.Win;
									}
									else
									{
										value.ModifersDown -= (int)(value.ModifersDown & KeyModifier.Win);
									}
								}
							}
						}
						if ((((GetAsyncKeyState(value.Key) & 0x8000) != 32768) & value.IsKeyDown) && value.ModifersDown == value.Modifiers)
						{
							value.IsKeyDown = false;
							value.OnHotKeyPressedHandler();
						}
					}
				}
				Thread.Sleep(15);
			}
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!IsDisposed)
			{
				if (disposing)
				{
					shutdown = true;
					thread.Join();
					hotKeyItems.Clear();
				}
				_lockObj = null;
				hotKeyItems = null;
				thread = null;
				IsDisposed = true;
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
		}
	}
}
