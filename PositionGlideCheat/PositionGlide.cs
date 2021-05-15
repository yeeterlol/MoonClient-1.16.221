using System.Text;
using Memory;

namespace PositionGlideCheat
{
	internal class PositionGlide
	{
		private Mem m = new Mem();

		public void freezeglide()
		{
			try
			{
				m.OpenProcess("Minecraft.Windows");
			}
			catch
			{
			}
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF0", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF1", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF2", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF3", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF4", "byte", "90", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF5", "byte", "90", "", (Encoding)null);
		}

		public void unfrezzeglide()
		{
			try
			{
				m.OpenProcess("Minecraft.Windows");
			}
			catch
			{
			}
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF0", "byte", "F3", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF1", "byte", "41", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF2", "byte", "0F", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF3", "byte", "11", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF4", "byte", "47", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2AEF5", "byte", "04", "", (Encoding)null);
		}
	}
}
