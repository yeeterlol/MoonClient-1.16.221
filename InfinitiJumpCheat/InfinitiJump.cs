using Memory;

namespace InfinitiJumpCheat
{
	internal class InfinitiJump
	{
		private Mem m = new Mem();

		public void freezejump(string jmps)
		{
			m.OpenProcess("Minecraft.Windows");
			m.FreezeValue("Minecraft.Windows.exe+039763C0,10,128,0,130,180,0,4E0", "float", jmps, "");
		}

		public void unfreezejump()
		{
			m.OpenProcess("Minecraft.Windows");
			m.UnfreezeValue("Minecraft.Windows.exe+039763C0,10,128,0,130,180,0,4E0");
		}
	}
}
