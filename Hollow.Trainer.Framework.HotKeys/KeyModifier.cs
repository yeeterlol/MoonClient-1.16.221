using System;

namespace Hollow.Trainer.Framework.HotKeys
{
	[Flags]
	public enum KeyModifier
	{
		None = 0x0,
		Alt = 0x1,
		Ctrl = 0x2,
		Shift = 0x4,
		Win = 0x8
	}
}
