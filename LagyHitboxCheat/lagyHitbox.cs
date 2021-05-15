using System.Text;
using Memory;

namespace LagyHitboxCheat
{
	internal class lagyHitbox
	{
		private Mem m = new Mem();

		public void writeHitbox(string withe)
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+2FEC938", "float", withe, "", (Encoding)null);
		}
	}
}
