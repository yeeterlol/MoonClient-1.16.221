using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ezOverLay;

namespace Memory.dll_MCBE_Chat_ÜBREARBEITUNG
{
	public class Overlay : Form
	{
		private ez ez = new ez();

		private IContainer components;

		private Label label1;

		private ContextMenuStrip contextMenuStrip1;

		private Label label2;

		public Overlay()
			: this()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			InitializeComponent();
		}

		private void Overlay_Load(object sender, EventArgs e)
		{
			ez.SetInvi((Form)(object)this);
			ez.StartLoop(50, "Minecraft", (Form)(object)this);
			ez.ClickThrough((Form)(object)this);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
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
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected O, but got Unknown
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			components = (IContainer)new Container();
			label1 = new Label();
			contextMenuStrip1 = new ContextMenuStrip(components);
			label2 = new Label();
			((Control)this).SuspendLayout();
			((Control)label1).set_AutoSize(true);
			((Control)label1).set_BackColor(Color.get_Transparent());
			((Control)label1).set_Font(new Font("MV Boli", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label1).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label1).set_Location(new Point(16, 84));
			((Control)label1).set_Margin(new Padding(4, 0, 4, 0));
			((Control)label1).set_Name("label1");
			((Control)label1).set_Size(new Size(191, 49));
			((Control)label1).set_TabIndex(1);
			((Control)label1).set_Text("Moon V0");
			((ToolStrip)contextMenuStrip1).set_ImageScalingSize(new Size(20, 20));
			((Control)contextMenuStrip1).set_Name("contextMenuStrip1");
			((Control)contextMenuStrip1).set_Size(new Size(61, 4));
			((Control)label2).set_AutoSize(true);
			((Control)label2).set_BackColor(Color.get_Transparent());
			((Control)label2).set_Font(new Font("MV Boli", 22.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)label2).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label2).set_Location(new Point(16, 133));
			((Control)label2).set_Margin(new Padding(4, 0, 4, 0));
			((Control)label2).set_Name("label2");
			((Control)label2).set_Size(new Size(146, 50));
			((Control)label2).set_TabIndex(2);
			((Control)label2).set_Text("by Jan");
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_ClientSize(new Size(1924, 639));
			((Control)this).get_Controls().Add((Control)(object)label2);
			((Control)this).get_Controls().Add((Control)(object)label1);
			((Form)this).set_Margin(new Padding(4, 4, 4, 4));
			((Control)this).set_Name("Overlay");
			((Control)this).set_Text("Overlay");
			((Form)this).add_Load((EventHandler)Overlay_Load);
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
