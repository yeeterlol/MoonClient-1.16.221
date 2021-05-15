using System.Text;
using Memory;

namespace PhaseCheat
{
	internal class Phase
	{
		private Mem m = new Mem();

		public void on()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+03CDD0E8,10,20,C8,4B0", "float", m.ReadFloat("Minecraft.Windows.exe+03CDD0E8,10,20,C8,4A4", "", true).ToString(), "", (Encoding)null);
		}

		public void off()
		{
			m.OpenProcess("Minecraft.Windows");
			float num = m.ReadFloat("Minecraft.Windows.exe+03CDD0E8,10,20,C8,4A4", "", true);
			m.WriteMemory("Minecraft.Windows.exe+03CDD0E8,10,20,C8,4B0", "float", (num + 1.8f).ToString(), "", (Encoding)null);
		}
	}
}
