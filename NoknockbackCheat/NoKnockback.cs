using System.Text;
using Memory;

namespace NoknockbackCheat
{
	internal class NoKnockback
	{
		private Mem m = new Mem();

		public void Noknockback_on()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+194162B", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+194162C", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+194162D", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+194162E", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+194162F", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941630", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941622", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941623", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941624", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941625", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941626", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941627", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941634", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941635", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941636", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941637", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941638", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941639", "byte", "90", "", (Encoding)null);
		}

		public void Noknockback_off()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+194162B", "byte", "89", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+194162C", "byte", "81", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+194162D", "byte", "E0", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+194162E", "byte", "04", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+194162F", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941630", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941622", "byte", "89", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941623", "byte", "81", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941624", "byte", "DC", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941625", "byte", "04", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941626", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941627", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941634", "byte", "89", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941635", "byte", "81", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941636", "byte", "E4", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941637", "byte", "04", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941638", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1941639", "byte", "00", "", (Encoding)null);
		}
	}
}
