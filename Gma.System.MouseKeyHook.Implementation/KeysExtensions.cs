using System.Windows.Forms;

namespace Gma.System.MouseKeyHook.Implementation
{
	internal static class KeysExtensions
	{
		public static Keys Normalize(this Keys key)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Invalid comparison between Unknown and I4
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Invalid comparison between Unknown and I4
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Invalid comparison between Unknown and I4
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Invalid comparison between Unknown and I4
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Invalid comparison between Unknown and I4
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Invalid comparison between Unknown and I4
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			if ((key & 0xA2) == 162 || (key & 0xA3) == 163)
			{
				return (Keys)131072;
			}
			if ((key & 0xA0) == 160 || (key & 0xA1) == 161)
			{
				return (Keys)65536;
			}
			if ((key & 0xA4) == 164 || (key & 0xA5) == 165)
			{
				return (Keys)262144;
			}
			return key;
		}
	}
}
