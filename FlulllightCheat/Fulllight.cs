using System.Text;
using Memory;

namespace FlulllightCheat
{
	internal class Fulllight
	{
		private Mem m = new Mem();

		public void on()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+03948840,10,138,18", "float", "100", "", (Encoding)null);
		}

		public void off()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+03948840,10,138,18", "float", "1.00", "", (Encoding)null);
		}
	}
}
