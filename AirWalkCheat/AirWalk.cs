using System.Text;
using Memory;

namespace AirWalkCheat
{
	internal class AirWalk
	{
		private Mem m = new Mem();

		public void go()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+1950294", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1950295", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1950296", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1950297", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1950298", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1950299", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+195029A", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+195029B", "byte", "90", "", (Encoding)null);
		}

		public void off()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+1950294", "byte", "F3", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1950295", "byte", "0F", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1950296", "byte", "11", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1950297", "byte", "81", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1950298", "byte", "A4", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1950299", "byte", "04", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+195029A", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+195029B", "byte", "00", "", (Encoding)null);
		}
	}
}
