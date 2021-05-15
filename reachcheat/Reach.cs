using System.Text;
using System.Windows.Forms;
using Memory;

namespace reachcheat
{
	internal class Reach
	{
		private Mem m = new Mem();

		public void writereach(float range)
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				m.OpenProcess("Minecraft.Windows");
				string text = range.ToString();
				m.WriteMemory("Minecraft.Windows.exe+2FED138", "float", text, "", (Encoding)null);
			}
			catch
			{
				MessageBox.Show("error in writereach module!");
			}
		}
	}
}
