using System.Text;
using Memory;

namespace SpeedSneakCheat
{
	internal class FastSneak
	{
		private Mem m = new Mem();

		public void on()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+1510784", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1510785", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1510786", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1510787", "byte", "90", "", (Encoding)null);
		}

		public void off()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+1510784", "byte", "80", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1510785", "byte", "7B", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1510786", "byte", "48", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1510787", "byte", "00", "", (Encoding)null);
		}
	}
}
