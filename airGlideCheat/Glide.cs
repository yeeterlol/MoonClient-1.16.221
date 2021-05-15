using System.Text;
using Memory;

namespace airGlideCheat
{
	internal class Glide
	{
		private Mem m = new Mem();

		public void glideon()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("7FF6BEE3AF54", "bytes", "90 90 90 90 90 90", "", (Encoding)null);
		}

		public void glideof()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("7FF6BEE3AF54", "bytes", "88 90 C3 01 00 00", "", (Encoding)null);
		}
	}
}
