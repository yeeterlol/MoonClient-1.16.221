using System.Text;
using Memory;

namespace FlyDamagebypasscheat
{
	internal class FlyDamageBypass
	{
		private Mem m = new Mem();

		public void on()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+1B755CC", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1B755CD", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1B755CE", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1B755CF", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1B755D0", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1B755D1", "byte", "90", "", (Encoding)null);
		}

		public void off()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+1B755CC", "byte", "F3", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1B755CD", "byte", "0F", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1B755CE", "byte", "11", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1B755CF", "byte", "44", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1B755D0", "byte", "83", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1B755D1", "byte", "7C", "", (Encoding)null);
		}
	}
}
