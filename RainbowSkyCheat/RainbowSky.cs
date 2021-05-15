using System.Text;
using Memory;

namespace RainbowSkyCheat
{
	internal class RainbowSky
	{
		private Mem m = new Mem();

		public void on(string value)
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+2FEC5AC", "float", value, "", (Encoding)null);
		}
	}
}
