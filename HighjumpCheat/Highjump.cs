using System.Text;
using Memory;

namespace HighjumpCheat
{
	internal class Highjump
	{
		private Mem m = new Mem();

		public void write(float value)
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+2FEC8E8", "float", value.ToString(), "", (Encoding)null);
		}
	}
}
