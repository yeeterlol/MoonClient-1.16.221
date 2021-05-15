using System.Windows.Forms;

namespace Gma.System.MouseKeyHook
{
	public interface IKeyboardEvents
	{
		event KeyEventHandler KeyDown;

		event KeyPressEventHandler KeyPress;

		event KeyEventHandler KeyUp;
	}
}
