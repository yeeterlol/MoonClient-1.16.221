using System;
using System.Windows.Forms;

namespace Memory.dll_MCBE_Chat_ÜBREARBEITUNG
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Launcher());
		}
	}
}
