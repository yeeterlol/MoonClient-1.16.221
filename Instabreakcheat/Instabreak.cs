using Memory;

namespace Instabreakcheat
{
	internal class Instabreak
	{
		private Mem m = new Mem();

		public void freezinsta()
		{
			m.OpenProcess("Minecraft.Windows");
			m.FreezeValue("Minecraft.Windows.exe+03CDD128,8,18,88,B68,0,98,24", "float", "1", "");
		}

		public void unfreezinsta()
		{
			m.OpenProcess("Minecraft.Windows");
			m.UnfreezeValue("Minecraft.Windows.exe+03CDD128,8,18,88,B68,0,98,24");
		}
	}
}
