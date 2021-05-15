using System.Windows.Forms;
using Gma.System.MouseKeyHook.WinApi;

namespace Gma.System.MouseKeyHook.Implementation
{
	internal class GlobalMouseListener : MouseListener
	{
		private readonly int m_SystemDoubleClickTime;

		private MouseButtons m_PreviousClicked;

		private Point m_PreviousClickedPosition;

		private int m_PreviousClickedTime;

		public GlobalMouseListener()
			: base(HookHelper.HookGlobalMouse)
		{
			m_SystemDoubleClickTime = MouseNativeMethods.GetDoubleClickTime();
		}

		protected override void ProcessDown(ref MouseEventExtArgs e)
		{
			if (IsDoubleClick(e))
			{
				e = e.ToDoubleClickEventArgs();
			}
			base.ProcessDown(ref e);
		}

		protected override void ProcessUp(ref MouseEventExtArgs e)
		{
			base.ProcessUp(ref e);
			if (((MouseEventArgs)e).get_Clicks() == 2)
			{
				StopDoubleClickWaiting();
			}
			if (((MouseEventArgs)e).get_Clicks() == 1)
			{
				StartDoubleClickWaiting(e);
			}
		}

		private void StartDoubleClickWaiting(MouseEventExtArgs e)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			m_PreviousClicked = ((MouseEventArgs)e).get_Button();
			m_PreviousClickedTime = e.Timestamp;
			m_PreviousClickedPosition = e.Point;
		}

		private void StopDoubleClickWaiting()
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			m_PreviousClicked = (MouseButtons)0;
			m_PreviousClickedTime = 0;
			m_PreviousClickedPosition = new Point(0, 0);
		}

		private bool IsDoubleClick(MouseEventExtArgs e)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return ((MouseEventArgs)e).get_Button() == m_PreviousClicked && e.Point == m_PreviousClickedPosition && e.Timestamp - m_PreviousClickedTime <= m_SystemDoubleClickTime;
		}

		protected override MouseEventExtArgs GetEventArgs(CallbackData data)
		{
			return MouseEventExtArgs.FromRawDataGlobal(data);
		}
	}
}
