using Memory;

namespace SpeedCheat
{
	internal class Speed
	{
		private Mem m = new Mem();

		public void freezespeed(string speed)
		{
			m.OpenProcess("Minecraft.Windows");
			m.FreezeValue("Minecraft.Windows.exe+03CDD128,8,20,C8,480,18,1F0,9C", "float", speed, "");
		}

		public void unfreezespeed()
		{
			m.OpenProcess("Minecraft.Windows");
			m.UnfreezeValue("Minecraft.Windows.exe+03CDD128,8,20,C8,480,18,1F0,9C");
		}
	}
}
