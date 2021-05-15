using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Hollow.Trainer.Framework;
using Hollow.Trainer.Framework.HotKeys;

namespace Trainer
{
	internal class Trainer : TrainerBase
	{
		private List<ITrainerItem> trainerItems = new List<ITrainerItem>();

		public Trainer(string processName)
			: this()
		{
			((TrainerBase)this).OpenProcess(processName);
			((TrainerBase)this).get_Process().get_TargetProcess().add_Exited((EventHandler)TargetProcessOnExited);
			Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "InjectTest.exe");
		}

		private void TargetProcessOnExited(object sender, EventArgs eventArgs)
		{
			foreach (ITrainerItem trainerItem in trainerItems)
			{
				try
				{
					trainerItem.Deactivate();
				}
				catch
				{
				}
			}
		}

		public override void AddTrainerItem(ITrainerItem item)
		{
			trainerItems.Add(item);
		}

		public override void RegisterHotKeys()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			foreach (ITrainerItem trainerItem in trainerItems)
			{
				HotKey val = HotKeyFactory.get_Factory().RegisterHotKey(trainerItem.get_HotKey(), trainerItem.get_HotKeyModifers());
				trainerItem.Initialize((TrainerBase)(object)this, val);
			}
		}

		public void EmulateHotkey(int stepNum)
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			if (stepNum < 2 || stepNum > 9)
			{
				throw new ArgumentException("Invalid argument value must be between 2 and 9", "stepNum");
			}
			ITrainerItem val = trainerItems[stepNum - 2];
			val.OnHotKeyPressed((object)this, new HotKeyEventArgs(val.get_HotKey(), val.get_HotKeyModifers()));
		}
	}
}
