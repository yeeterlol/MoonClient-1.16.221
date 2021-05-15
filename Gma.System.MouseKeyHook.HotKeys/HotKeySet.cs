using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.Implementation;

namespace Gma.System.MouseKeyHook.HotKeys
{
	public class HotKeySet
	{
		public delegate void HotKeyHandler(object sender, HotKeyArgs e);

		private readonly Dictionary<Keys, bool> m_hotkeystate;

		private readonly Dictionary<Keys, Keys> m_remapping;

		private bool m_enabled = true;

		private int m_hotkeydowncount;

		private int m_remappingCount;

		public string Name
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public IEnumerable<Keys> HotKeys
		{
			get;
		}

		public bool HotKeysActivated => m_hotkeydowncount == m_hotkeystate.Count - m_remappingCount;

		public bool Enabled
		{
			get
			{
				return m_enabled;
			}
			set
			{
				if (value)
				{
					InitializeKeys();
				}
				m_enabled = value;
			}
		}

		public event HotKeyHandler OnHotKeysDownHold;

		public event HotKeyHandler OnHotKeysUp;

		public event HotKeyHandler OnHotKeysDownOnce;

		public HotKeySet(IEnumerable<Keys> hotkeys)
		{
			m_hotkeystate = new Dictionary<Keys, bool>();
			m_remapping = new Dictionary<Keys, Keys>();
			HotKeys = hotkeys;
			InitializeKeys();
		}

		private void InvokeHotKeyHandler(HotKeyHandler hotKeyDelegate)
		{
			hotKeyDelegate?.Invoke(this, new HotKeyArgs(DateTime.Now));
		}

		private void InitializeKeys()
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			foreach (Keys hotKey in HotKeys)
			{
				if (m_hotkeystate.ContainsKey(hotKey))
				{
					m_hotkeystate.Add(hotKey, value: false);
				}
				m_hotkeystate[hotKey] = KeyboardState.GetCurrent().IsDown(hotKey);
			}
		}

		public bool UnregisterExclusiveOrKey(Keys anyKeyInTheExclusiveOrSet)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			Keys exclusiveOrPrimaryKey = GetExclusiveOrPrimaryKey(anyKeyInTheExclusiveOrSet);
			if ((int)exclusiveOrPrimaryKey == 0 || !m_remapping.ContainsValue(exclusiveOrPrimaryKey))
			{
				return false;
			}
			List<Keys> list = new List<Keys>();
			foreach (KeyValuePair<Keys, Keys> item in m_remapping)
			{
				if (item.Value == exclusiveOrPrimaryKey)
				{
					list.Add(item.Key);
				}
			}
			foreach (Keys item2 in list)
			{
				m_remapping.Remove(item2);
			}
			m_remappingCount--;
			return true;
		}

		public Keys RegisterExclusiveOrKey(IEnumerable<Keys> orKeySet)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			foreach (Keys item in orKeySet)
			{
				if (!m_hotkeystate.ContainsKey(item))
				{
					return (Keys)0;
				}
			}
			int num = 0;
			Keys val = (Keys)0;
			foreach (Keys item2 in orKeySet)
			{
				if (num == 0)
				{
					val = item2;
				}
				m_remapping[item2] = val;
				num++;
			}
			m_remappingCount++;
			return val;
		}

		private Keys GetExclusiveOrPrimaryKey(Keys k)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			return (Keys)(m_remapping.ContainsKey(k) ? ((int)m_remapping[k]) : 0);
		}

		private Keys GetPrimaryKey(Keys k)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			return m_remapping.ContainsKey(k) ? m_remapping[k] : k;
		}

		internal void OnKey(KeyEventArgsExt kex)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			if (Enabled)
			{
				Keys primaryKey = GetPrimaryKey(((KeyEventArgs)kex).get_KeyCode());
				if (kex.IsKeyDown)
				{
					OnKeyDown(primaryKey);
				}
				else
				{
					OnKeyUp(primaryKey);
				}
			}
		}

		private void OnKeyDown(Keys k)
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			if (HotKeysActivated)
			{
				InvokeHotKeyHandler(this.OnHotKeysDownHold);
			}
			else if (m_hotkeystate.ContainsKey(k) && !m_hotkeystate[k])
			{
				m_hotkeystate[k] = true;
				m_hotkeydowncount++;
				if (HotKeysActivated)
				{
					InvokeHotKeyHandler(this.OnHotKeysDownOnce);
				}
			}
		}

		private void OnKeyUp(Keys k)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			if (m_hotkeystate.ContainsKey(k) && m_hotkeystate[k])
			{
				bool hotKeysActivated = HotKeysActivated;
				m_hotkeystate[k] = false;
				m_hotkeydowncount--;
				if (hotKeysActivated)
				{
					InvokeHotKeyHandler(this.OnHotKeysUp);
				}
			}
		}
	}
}
