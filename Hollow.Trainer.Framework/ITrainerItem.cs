using System;
using System.Windows.Forms;
using Hollow.Trainer.Framework.HotKeys;

namespace Hollow.Trainer.Framework
{
	public interface ITrainerItem : IDisposable
	{
		KeyModifier HotKeyModifers
		{
			get;
		}

		Keys HotKey
		{
			get;
		}

		bool IsActive
		{
			get;
		}

		void Initialize(TrainerBase trainerBase, HotKey hotkey);

		void Activate();

		void Deactivate();

		void OnHotKeyPressed(object sender, HotKeyEventArgs e);
	}
}
