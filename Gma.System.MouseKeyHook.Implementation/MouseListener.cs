using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Gma.System.MouseKeyHook.WinApi;

namespace Gma.System.MouseKeyHook.Implementation
{
	internal abstract class MouseListener : BaseListener, IMouseEvents
	{
		private readonly ButtonSet m_DoubleDown;

		private readonly ButtonSet m_SingleDown;

		private readonly Point m_UninitialisedPoint = new Point(-1, -1);

		private readonly int m_xDragThreshold;

		private readonly int m_yDragThreshold;

		private Point m_DragStartPosition;

		private bool m_IsDragging;

		private Point m_PreviousPosition;

		public event MouseEventHandler MouseMove
		{
			[CompilerGenerated]
			add
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseMove;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseMove), value2, val2);
				}
				while (val != val2);
			}
			[CompilerGenerated]
			remove
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseMove;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseMove), value2, val2);
				}
				while (val != val2);
			}
		}

		public event EventHandler<MouseEventExtArgs> MouseMoveExt;

		public event MouseEventHandler MouseClick
		{
			[CompilerGenerated]
			add
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseClick;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseClick), value2, val2);
				}
				while (val != val2);
			}
			[CompilerGenerated]
			remove
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseClick;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseClick), value2, val2);
				}
				while (val != val2);
			}
		}

		public event MouseEventHandler MouseDown
		{
			[CompilerGenerated]
			add
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseDown;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseDown), value2, val2);
				}
				while (val != val2);
			}
			[CompilerGenerated]
			remove
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseDown;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseDown), value2, val2);
				}
				while (val != val2);
			}
		}

		public event EventHandler<MouseEventExtArgs> MouseDownExt;

		public event MouseEventHandler MouseUp
		{
			[CompilerGenerated]
			add
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseUp;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseUp), value2, val2);
				}
				while (val != val2);
			}
			[CompilerGenerated]
			remove
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseUp;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseUp), value2, val2);
				}
				while (val != val2);
			}
		}

		public event EventHandler<MouseEventExtArgs> MouseUpExt;

		public event MouseEventHandler MouseWheel
		{
			[CompilerGenerated]
			add
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseWheel;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseWheel), value2, val2);
				}
				while (val != val2);
			}
			[CompilerGenerated]
			remove
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseWheel;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseWheel), value2, val2);
				}
				while (val != val2);
			}
		}

		public event EventHandler<MouseEventExtArgs> MouseWheelExt;

		public event MouseEventHandler MouseDoubleClick
		{
			[CompilerGenerated]
			add
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseDoubleClick;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseDoubleClick), value2, val2);
				}
				while (val != val2);
			}
			[CompilerGenerated]
			remove
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseDoubleClick;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseDoubleClick), value2, val2);
				}
				while (val != val2);
			}
		}

		public event MouseEventHandler MouseDragStarted
		{
			[CompilerGenerated]
			add
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseDragStarted;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseDragStarted), value2, val2);
				}
				while (val != val2);
			}
			[CompilerGenerated]
			remove
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseDragStarted;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseDragStarted), value2, val2);
				}
				while (val != val2);
			}
		}

		public event EventHandler<MouseEventExtArgs> MouseDragStartedExt;

		public event MouseEventHandler MouseDragFinished
		{
			[CompilerGenerated]
			add
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseDragFinished;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseDragFinished), value2, val2);
				}
				while (val != val2);
			}
			[CompilerGenerated]
			remove
			{
				//IL_0010: Unknown result type (might be due to invalid IL or missing references)
				//IL_0016: Expected O, but got Unknown
				MouseEventHandler val = this.MouseDragFinished;
				MouseEventHandler val2;
				do
				{
					val2 = val;
					MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
					val = Interlocked.CompareExchange(ref global::System.Runtime.CompilerServices.Unsafe.As<MouseEventHandler, MouseEventHandler>(ref this.MouseDragFinished), value2, val2);
				}
				while (val != val2);
			}
		}

		public event EventHandler<MouseEventExtArgs> MouseDragFinishedExt;

		protected MouseListener(Subscribe subscribe)
			: base(subscribe)
		{
			m_xDragThreshold = NativeMethods.GetXDragThreshold();
			m_yDragThreshold = NativeMethods.GetYDragThreshold();
			m_IsDragging = false;
			m_PreviousPosition = m_UninitialisedPoint;
			m_DragStartPosition = m_UninitialisedPoint;
			m_DoubleDown = new ButtonSet();
			m_SingleDown = new ButtonSet();
		}

		protected override bool Callback(CallbackData data)
		{
			MouseEventExtArgs e = GetEventArgs(data);
			if (e.IsMouseButtonDown)
			{
				ProcessDown(ref e);
			}
			if (e.IsMouseButtonUp)
			{
				ProcessUp(ref e);
			}
			if (e.WheelScrolled)
			{
				ProcessWheel(ref e);
			}
			if (HasMoved(e.Point))
			{
				ProcessMove(ref e);
			}
			ProcessDrag(ref e);
			return !e.Handled;
		}

		protected abstract MouseEventExtArgs GetEventArgs(CallbackData data);

		protected virtual void ProcessWheel(ref MouseEventExtArgs e)
		{
			OnWheel((MouseEventArgs)(object)e);
			OnWheelExt(e);
		}

		protected virtual void ProcessDown(ref MouseEventExtArgs e)
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			OnDown((MouseEventArgs)(object)e);
			OnDownExt(e);
			if (!e.Handled)
			{
				if (((MouseEventArgs)e).get_Clicks() == 2)
				{
					m_DoubleDown.Add(((MouseEventArgs)e).get_Button());
				}
				if (((MouseEventArgs)e).get_Clicks() == 1)
				{
					m_SingleDown.Add(((MouseEventArgs)e).get_Button());
				}
			}
		}

		protected virtual void ProcessUp(ref MouseEventExtArgs e)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			OnUp((MouseEventArgs)(object)e);
			OnUpExt(e);
			if (!e.Handled)
			{
				if (m_SingleDown.Contains(((MouseEventArgs)e).get_Button()))
				{
					OnClick((MouseEventArgs)(object)e);
					m_SingleDown.Remove(((MouseEventArgs)e).get_Button());
				}
				if (m_DoubleDown.Contains(((MouseEventArgs)e).get_Button()))
				{
					e = e.ToDoubleClickEventArgs();
					OnDoubleClick((MouseEventArgs)(object)e);
					m_DoubleDown.Remove(((MouseEventArgs)e).get_Button());
				}
			}
		}

		private void ProcessMove(ref MouseEventExtArgs e)
		{
			m_PreviousPosition = e.Point;
			OnMove((MouseEventArgs)(object)e);
			OnMoveExt(e);
		}

		private void ProcessDrag(ref MouseEventExtArgs e)
		{
			if (m_SingleDown.Contains((MouseButtons)1048576))
			{
				if (m_DragStartPosition.Equals(m_UninitialisedPoint))
				{
					m_DragStartPosition = e.Point;
				}
				ProcessDragStarted(ref e);
			}
			else
			{
				m_DragStartPosition = m_UninitialisedPoint;
				ProcessDragFinished(ref e);
			}
		}

		private void ProcessDragStarted(ref MouseEventExtArgs e)
		{
			if (!m_IsDragging)
			{
				bool flag = Math.Abs(e.Point.X - m_DragStartPosition.X) > m_xDragThreshold;
				bool flag2 = Math.Abs(e.Point.Y - m_DragStartPosition.Y) > m_yDragThreshold;
				m_IsDragging = flag || flag2;
				if (m_IsDragging)
				{
					OnDragStarted((MouseEventArgs)(object)e);
					OnDragStartedExt(e);
				}
			}
		}

		private void ProcessDragFinished(ref MouseEventExtArgs e)
		{
			if (m_IsDragging)
			{
				OnDragFinished((MouseEventArgs)(object)e);
				OnDragFinishedExt(e);
				m_IsDragging = false;
			}
		}

		private bool HasMoved(Point actualPoint)
		{
			return m_PreviousPosition != actualPoint;
		}

		protected virtual void OnMove(MouseEventArgs e)
		{
			MouseEventHandler mouseMove = this.MouseMove;
			if (mouseMove != null)
			{
				mouseMove.Invoke((object)this, e);
			}
		}

		protected virtual void OnMoveExt(MouseEventExtArgs e)
		{
			this.MouseMoveExt?.Invoke(this, e);
		}

		protected virtual void OnClick(MouseEventArgs e)
		{
			MouseEventHandler mouseClick = this.MouseClick;
			if (mouseClick != null)
			{
				mouseClick.Invoke((object)this, e);
			}
		}

		protected virtual void OnDown(MouseEventArgs e)
		{
			MouseEventHandler mouseDown = this.MouseDown;
			if (mouseDown != null)
			{
				mouseDown.Invoke((object)this, e);
			}
		}

		protected virtual void OnDownExt(MouseEventExtArgs e)
		{
			this.MouseDownExt?.Invoke(this, e);
		}

		protected virtual void OnUp(MouseEventArgs e)
		{
			MouseEventHandler mouseUp = this.MouseUp;
			if (mouseUp != null)
			{
				mouseUp.Invoke((object)this, e);
			}
		}

		protected virtual void OnUpExt(MouseEventExtArgs e)
		{
			this.MouseUpExt?.Invoke(this, e);
		}

		protected virtual void OnWheel(MouseEventArgs e)
		{
			MouseEventHandler mouseWheel = this.MouseWheel;
			if (mouseWheel != null)
			{
				mouseWheel.Invoke((object)this, e);
			}
		}

		protected virtual void OnWheelExt(MouseEventExtArgs e)
		{
			this.MouseWheelExt?.Invoke(this, e);
		}

		protected virtual void OnDoubleClick(MouseEventArgs e)
		{
			MouseEventHandler mouseDoubleClick = this.MouseDoubleClick;
			if (mouseDoubleClick != null)
			{
				mouseDoubleClick.Invoke((object)this, e);
			}
		}

		protected virtual void OnDragStarted(MouseEventArgs e)
		{
			MouseEventHandler mouseDragStarted = this.MouseDragStarted;
			if (mouseDragStarted != null)
			{
				mouseDragStarted.Invoke((object)this, e);
			}
		}

		protected virtual void OnDragStartedExt(MouseEventExtArgs e)
		{
			this.MouseDragStartedExt?.Invoke(this, e);
		}

		protected virtual void OnDragFinished(MouseEventArgs e)
		{
			MouseEventHandler mouseDragFinished = this.MouseDragFinished;
			if (mouseDragFinished != null)
			{
				mouseDragFinished.Invoke((object)this, e);
			}
		}

		protected virtual void OnDragFinishedExt(MouseEventExtArgs e)
		{
			this.MouseDragFinishedExt?.Invoke(this, e);
		}
	}
}
