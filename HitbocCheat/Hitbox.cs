using System;
using System.Text;
using Hollow.Trainer.Framework;
using Memory;

namespace HitbocCheat
{
	internal class Hitbox
	{
		private Mem m = new Mem();

		private TrainerBase trainer;

		private IntPtr address;

		private int[] pointerOffsets;

		private UIntPtr codeCave;

		private byte[] orginalBytes = new byte[5]
		{
			137,
			67,
			4,
			217,
			238
		};

		private byte[] newBytes1 = new byte[25]
		{
			131,
			123,
			16,
			2,
			15,
			132,
			8,
			0,
			0,
			0,
			139,
			67,
			4,
			233,
			2,
			0,
			0,
			0,
			49,
			192,
			137,
			67,
			4,
			217,
			238
		};

		private byte[] newBytes = new byte[9]
		{
			144,
			144,
			144,
			144,
			144,
			144,
			144,
			144,
			144
		};

		public void Hitboxon()
		{
			m.OpenProcess("Minecraft.Windows");
			m.WriteMemory("Minecraft.Windows.exe+1A2F290", "byte", "E9", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F291", "byte", "6B", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F292", "byte", "0D", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F293", "byte", "5C", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F294", "byte", "FE", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F295", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F296", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F297", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F298", "byte", "00", "", (Encoding)null);
		}

		public void Hitboxoff()
		{
			m.WriteMemory("Minecraft.Windows.exe+1A2F290", "byte", "E9", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F291", "byte", "6B", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F292", "byte", "0D", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F293", "byte", "5C", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F294", "byte", "FE", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F295", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F296", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F297", "byte", "00", "", (Encoding)null);
			m.WriteMemory("Minecraft.Windows.exe+1A2F298", "byte", "00", "", (Encoding)null);
		}
	}
}
