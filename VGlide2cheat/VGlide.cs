using Memory;

namespace VGlide2cheat
{
	internal class VGlide
	{
		private Mem m = new Mem();

		public void write()
		{
			m.OpenProcess("Minecraft.Windows");
		}
	}
}
