using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace ezOverLay
{
	public class ez
	{
		public struct RECT
		{
			public int left;

			public int top;

			public int right;

			public int bottom;
		}

		public static IntPtr hand;

		public static RECT rect;

		public bool threadwire = true;

		[DllImport("user32.dll")]
		public static extern short GetAsyncKeyState(Keys vKey);

		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

		[DllImport("user32.dll")]
		public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

		[DllImport("user32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool GetWindowRect(IntPtr hwnd, out RECT IpRect);

		public void setHandle(string window_name)
		{
			hand = FindWindow(null, window_name);
		}

		public void SetInvi(Form form)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			((Control)form).set_BackColor(Color.get_Wheat());
			form.set_TransparencyKey(Color.get_Wheat());
			form.set_TopMost(true);
			form.set_FormBorderStyle((FormBorderStyle)0);
		}

		public void ClickThrough(Form form)
		{
			ClickThrough(((Control)form).get_Handle());
		}

		public void GetRekt()
		{
			GetWindowRect(hand, out rect);
		}

		public void ClickThrough(IntPtr formHandle)
		{
			int windowLong = GetWindowLong(formHandle, -20);
			SetWindowLong(formHandle, -20, windowLong | 0x8000 | 0x20);
		}

		public Size CalcSize()
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			return new Size(rect.right - rect.left, rect.bottom - rect.top);
		}

		public void DoStuff(string WindowName, Form form)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			setHandle(WindowName);
			GetRekt();
			form.set_Size(CalcSize());
			((Control)form).set_Left(rect.left);
			((Control)form).set_Top(rect.top);
		}

		public void PauseLoop()
		{
			threadwire = false;
		}

		public void UnPauseLoop()
		{
			threadwire = true;
		}

		public void StartLoop(int frequency, string WindowName, Form form)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				LOOP(frequency, WindowName, form);
			});
			thread.IsBackground = true;
			thread.Start();
		}

		public void LOOP(int frequency, string WindowName, Form form)
		{
			while (true)
			{
				if (threadwire)
				{
					DoStuff(WindowName, form);
				}
				Thread.Sleep(frequency);
			}
		}
	}
}
