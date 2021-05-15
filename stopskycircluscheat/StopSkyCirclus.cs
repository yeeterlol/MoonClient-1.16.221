using System.Text;
using Memory;

namespace stopskycircluscheat
{
	internal class StopSkyCirclus
	{
		private Mem m = new Mem();

		public void on()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+1CA18C3", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1CA18C4", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1CA18C5", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1CA18C6", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1CA18C7", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1CA18C8", "byte", "90", "", (Encoding)null);
		}

		public void off()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+1CA18C3", "byte", "89", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1CA18C4", "byte", "91", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1CA18C5", "byte", "D8", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1CA18C6", "byte", "05", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1CA18C7", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1CA18C8", "byte", "00", "", (Encoding)null);
		}
	}
}
