using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ezOverLay;

namespace Memory.dll_MCBE_Chat_ÜBREARBEITUNG
{
	public class Keystrokes : Form
	{
		private ez ez = new ez();

		private IContainer components;

		private Panel panel1;

		private Panel panel6;

		private Panel panel5;

		private Panel panel4;

		private Panel panel3;

		private Panel panel2;

		public Keystrokes()
			: this()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			InitializeComponent();
		}

		private void Keystrokes_Load(object sender, EventArgs e)
		{
			ez.SetInvi((Form)(object)this);
			ez.StartLoop(500, "Minecraft", (Form)(object)this);
			ez.ClickThrough((Form)(object)this);
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				((IDisposable)components).Dispose();
			}
			((Form)this).Dispose(disposing);
		}

		private void InitializeComponent()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got Unknown
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			panel1 = new Panel();
			panel2 = new Panel();
			panel3 = new Panel();
			panel4 = new Panel();
			panel5 = new Panel();
			panel6 = new Panel();
			((Control)panel1).SuspendLayout();
			((Control)this).SuspendLayout();
			((Control)panel1).get_Controls().Add((Control)(object)panel6);
			((Control)panel1).get_Controls().Add((Control)(object)panel5);
			((Control)panel1).get_Controls().Add((Control)(object)panel4);
			((Control)panel1).get_Controls().Add((Control)(object)panel3);
			((Control)panel1).get_Controls().Add((Control)(object)panel2);
			((Control)panel1).set_Location(new Point(12, 533));
			((Control)panel1).set_Name("panel1");
			((Control)panel1).set_Size(new Size(242, 246));
			((Control)panel1).set_TabIndex(0);
			((Control)panel2).set_BackColor(Color.get_Orange());
			((Control)panel2).set_Location(new Point(85, 38));
			((Control)panel2).set_Name("panel2");
			((Control)panel2).set_Size(new Size(63, 55));
			((Control)panel2).set_TabIndex(0);
			((Control)panel3).set_BackColor(Color.get_Orange());
			((Control)panel3).set_Location(new Point(85, 99));
			((Control)panel3).set_Name("panel3");
			((Control)panel3).set_Size(new Size(63, 55));
			((Control)panel3).set_TabIndex(1);
			((Control)panel4).set_BackColor(Color.get_Orange());
			((Control)panel4).set_Location(new Point(16, 99));
			((Control)panel4).set_Name("panel4");
			((Control)panel4).set_Size(new Size(63, 55));
			((Control)panel4).set_TabIndex(2);
			((Control)panel5).set_BackColor(Color.get_Orange());
			((Control)panel5).set_Location(new Point(154, 99));
			((Control)panel5).set_Name("panel5");
			((Control)panel5).set_Size(new Size(63, 55));
			((Control)panel5).set_TabIndex(3);
			((Control)panel6).set_BackColor(Color.get_Orange());
			((Control)panel6).set_Location(new Point(16, 160));
			((Control)panel6).set_Name("panel6");
			((Control)panel6).set_Size(new Size(201, 55));
			((Control)panel6).set_TabIndex(4);
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_ClientSize(new Size(800, 791));
			((Control)this).get_Controls().Add((Control)(object)panel1);
			((Control)this).set_Name("Keystrokes");
			((Control)this).set_Text("Keystrokes");
			((Form)this).add_Load((EventHandler)Keystrokes_Load);
			((Control)panel1).ResumeLayout(false);
			((Control)this).ResumeLayout(false);
		}
	}
}
