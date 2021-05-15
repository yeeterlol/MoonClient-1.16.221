using System.Text;
using Memory;

namespace AirJumpcheat
{
	internal class AirJumpcs
	{
		private Mem m = new Mem();

		public void freezairjump()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+E9AFF4", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFF5", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFF6", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFF7", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFF8", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFF9", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFFA", "byte", "90", "", (Encoding)null);
		}

		public void unfreezairjump()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+E9AFF4", "byte", "0F", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFF5", "byte", "B6", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFF6", "byte", "80", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFF7", "byte", "C0", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFF8", "byte", "01", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFF9", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+E9AFFA", "byte", "00", "", (Encoding)null);
		}
	}
}
