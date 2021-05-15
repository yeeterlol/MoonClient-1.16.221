using System.Text;
using Memory;

namespace Zoomcheat
{
	internal class Zoom
	{
		private Mem m = new Mem();

		public void Zoomin()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+3948840,18,130,18", "float", "20", "", (Encoding)null);
		}

		public void Zoomout()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+3948840,18,130,18", "float", "100", "", (Encoding)null);
		}
	}
}
