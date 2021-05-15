using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace Memory.dll_MCBE_Chat_ÜBREARBEITUNG
{
	public class Launcher : Form
	{
		private Mem m = new Mem();

		private int mov;

		private int movX;

		private int movY;

		private IContainer components;

		private PictureBox pictureBox1;

		private PictureBox pictureBox2;

		private Panel panel1;

		private Label label3;

		private Label label2;

		private Label label1;

		private Button button7;

		private Button button6;

		private Label label4;

		private Label label5;

		private PictureBox pictureBox3;

		public Launcher()
			: this()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			InitializeComponent();
		}

		private void Launcher_Load(object sender, EventArgs e)
		{
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Process.Start("Minecraft://");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				Process.Start("minecraft://");
				Control.set_CheckForIllegalCrossThreadCalls(false);
			}
			catch
			{
			}
			while (true)
			{
				try
				{
					m.OpenProcess("Minecraft.Windows");
					Thread.Sleep(1000);
				}
				catch
				{
					MessageBox.Show("Pls try to disable your Anti-Virus! (Why: Launcher/Help)");
					continue;
				}
				break;
			}
			try
			{
				((Control)new Clickgui()).Show();
			}
			catch
			{
			}
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCL1YBSHozVw7PAFx78CxVng");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/WzGw9Sp8GP");
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			mov = 1;
			movX = e.get_X();
			movY = e.get_Y();
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			if (mov == 1)
			{
				Point mousePosition = Control.get_MousePosition();
				int num = ((Point)(ref mousePosition)).get_X() - movX;
				mousePosition = Control.get_MousePosition();
				((Form)this).SetDesktopLocation(num, ((Point)(ref mousePosition)).get_Y() - mov);
			}
		}

		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			mov = 0;
		}

		private void label4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.tiktok.com/@why_sirproxx?lang=de-DE");
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
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Expected O, but got Unknown
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e6: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected O, but got Unknown
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected O, but got Unknown
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Expected O, but got Unknown
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Expected O, but got Unknown
			//IL_02be: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Expected O, but got Unknown
			//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Expected O, but got Unknown
			//IL_039c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0426: Unknown result type (might be due to invalid IL or missing references)
			//IL_0443: Unknown result type (might be due to invalid IL or missing references)
			//IL_044d: Expected O, but got Unknown
			//IL_045f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0473: Unknown result type (might be due to invalid IL or missing references)
			//IL_0487: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0500: Unknown result type (might be due to invalid IL or missing references)
			//IL_050a: Expected O, but got Unknown
			//IL_051c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0536: Unknown result type (might be due to invalid IL or missing references)
			//IL_0547: Unknown result type (might be due to invalid IL or missing references)
			//IL_056e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05be: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f1: Expected O, but got Unknown
			//IL_0603: Unknown result type (might be due to invalid IL or missing references)
			//IL_061a: Unknown result type (might be due to invalid IL or missing references)
			//IL_062b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0652: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d5: Expected O, but got Unknown
			//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0711: Unknown result type (might be due to invalid IL or missing references)
			//IL_0735: Unknown result type (might be due to invalid IL or missing references)
			//IL_0784: Unknown result type (might be due to invalid IL or missing references)
			//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ab: Expected O, but got Unknown
			//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_080f: Unknown result type (might be due to invalid IL or missing references)
			//IL_083c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0857: Unknown result type (might be due to invalid IL or missing references)
			//IL_0861: Expected O, but got Unknown
			//IL_087a: Unknown result type (might be due to invalid IL or missing references)
			//IL_089e: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0900: Unknown result type (might be due to invalid IL or missing references)
			//IL_090a: Expected O, but got Unknown
			//IL_091c: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f4: Expected O, but got Unknown
			ComponentResourceManager val = new ComponentResourceManager(typeof(Launcher));
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			panel1 = new Panel();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			button7 = new Button();
			button6 = new Button();
			label4 = new Label();
			label5 = new Label();
			pictureBox3 = new PictureBox();
			((ISupportInitialize)pictureBox1).BeginInit();
			((ISupportInitialize)pictureBox2).BeginInit();
			((Control)panel1).SuspendLayout();
			((ISupportInitialize)pictureBox3).BeginInit();
			((Control)this).SuspendLayout();
			((Control)pictureBox1).set_BackColor(Color.get_Transparent());
			((Control)pictureBox1).set_BackgroundImage((Image)((ResourceManager)(object)val).GetObject("pictureBox1.BackgroundImage"));
			((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)3);
			((Control)pictureBox1).set_Location(new Point(1, 223));
			((Control)pictureBox1).set_Name("pictureBox1");
			((Control)pictureBox1).set_Size(new Size(40, 38));
			pictureBox1.set_TabIndex(1);
			pictureBox1.set_TabStop(false);
			((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
			((Control)pictureBox2).set_BackColor(Color.get_Transparent());
			((Control)pictureBox2).set_BackgroundImage((Image)((ResourceManager)(object)val).GetObject("pictureBox2.BackgroundImage"));
			((Control)pictureBox2).set_BackgroundImageLayout((ImageLayout)3);
			((Control)pictureBox2).set_Location(new Point(47, 223));
			((Control)pictureBox2).set_Name("pictureBox2");
			((Control)pictureBox2).set_Size(new Size(38, 38));
			pictureBox2.set_TabIndex(2);
			pictureBox2.set_TabStop(false);
			((Control)pictureBox2).add_Click((EventHandler)pictureBox2_Click);
			((Control)panel1).set_BackColor(Color.get_Transparent());
			((Control)panel1).get_Controls().Add((Control)(object)label4);
			((Control)panel1).set_Location(new Point(1, 2));
			((Control)panel1).set_Name("panel1");
			((Control)panel1).set_Size(new Size(398, 39));
			((Control)panel1).set_TabIndex(4);
			((Control)panel1).add_MouseDown(new MouseEventHandler(panel1_MouseDown));
			((Control)panel1).add_MouseMove(new MouseEventHandler(panel1_MouseMove));
			((Control)panel1).add_MouseUp(new MouseEventHandler(panel1_MouseUp));
			((Control)label3).set_AutoSize(true);
			((Control)label3).set_BackColor(Color.get_Transparent());
			((Control)label3).set_Font(new Font("Mistral", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label3).set_Location(new Point(299, 44));
			((Control)label3).set_Margin(new Padding(2, 0, 2, 0));
			((Control)label3).set_Name("label3");
			((Control)label3).set_Size(new Size(69, 57));
			((Control)label3).set_TabIndex(7);
			((Control)label3).set_Text("V0");
			((Control)label2).set_AutoSize(true);
			((Control)label2).set_BackColor(Color.get_Transparent());
			((Control)label2).set_Font(new Font("Mistral", 36f, (FontStyle)9, (GraphicsUnit)3, (byte)0));
			((Control)label2).set_ForeColor(Color.FromArgb(59, 232, 255));
			((Control)label2).set_Location(new Point(167, 44));
			((Control)label2).set_Margin(new Padding(2, 0, 2, 0));
			((Control)label2).set_Name("label2");
			((Control)label2).set_Size(new Size(128, 57));
			((Control)label2).set_TabIndex(6);
			((Control)label2).set_Text("Client");
			((Control)label1).set_AutoSize(true);
			((Control)label1).set_BackColor(Color.get_Transparent());
			((Control)label1).set_Font(new Font("Mistral", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label1).set_ForeColor(Color.FromArgb(59, 232, 255));
			((Control)label1).set_Location(new Point(49, 44));
			((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
			((Control)label1).set_Name("label1");
			((Control)label1).set_Size(new Size(114, 57));
			((Control)label1).set_TabIndex(5);
			((Control)label1).set_Text("Moon");
			((Control)button7).set_BackColor(Color.get_Transparent());
			((ButtonBase)button7).set_FlatStyle((FlatStyle)0);
			((Control)button7).set_Font(new Font("Microsoft YaHei UI", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button7).set_ForeColor(Color.FromArgb(59, 232, 255));
			((Control)button7).set_Location(new Point(136, 171));
			((Control)button7).set_Margin(new Padding(2));
			((Control)button7).set_Name("button7");
			((Control)button7).set_Size(new Size(140, 41));
			((Control)button7).set_TabIndex(9);
			((Control)button7).set_Text("Load Cheat");
			((ButtonBase)button7).set_UseVisualStyleBackColor(false);
			((Control)button7).add_Click((EventHandler)button7_Click);
			((Control)button6).set_BackColor(Color.get_Transparent());
			((ButtonBase)button6).set_FlatStyle((FlatStyle)0);
			((Control)button6).set_Font(new Font("Microsoft YaHei UI", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button6).set_ForeColor(Color.FromArgb(59, 232, 255));
			((Control)button6).set_Location(new Point(136, 126));
			((Control)button6).set_Margin(new Padding(2));
			((Control)button6).set_Name("button6");
			((Control)button6).set_Size(new Size(140, 41));
			((Control)button6).set_TabIndex(8);
			((Control)button6).set_Text("Launch Minecraft");
			((ButtonBase)button6).set_UseVisualStyleBackColor(false);
			((Control)button6).add_Click((EventHandler)button6_Click);
			((Control)label4).set_AutoSize(true);
			((Control)label4).set_BackColor(Color.get_Transparent());
			((Control)label4).set_Font(new Font("Mistral", 20.25f, (FontStyle)9, (GraphicsUnit)3, (byte)0));
			((Control)label4).set_ForeColor(Color.FromArgb(59, 232, 255));
			((Control)label4).set_Location(new Point(369, 6));
			((Control)label4).set_Margin(new Padding(2, 0, 2, 0));
			((Control)label4).set_Name("label4");
			((Control)label4).set_Size(new Size(27, 33));
			((Control)label4).set_TabIndex(7);
			((Control)label4).set_Text("X");
			((Control)label4).add_Click((EventHandler)label4_Click);
			((Control)label5).set_AutoSize(true);
			((Control)label5).set_BackColor(Color.get_Transparent());
			((Control)label5).set_Font(new Font("Mistral", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)label5).set_ForeColor(Color.FromArgb(59, 232, 255));
			((Control)label5).set_Location(new Point(328, 226));
			((Control)label5).set_Margin(new Padding(2, 0, 2, 0));
			((Control)label5).set_Name("label5");
			((Control)label5).set_Size(new Size(60, 26));
			((Control)label5).set_TabIndex(10);
			((Control)label5).set_Text("By Jan");
			((Control)pictureBox3).set_BackColor(Color.get_Transparent());
			((Control)pictureBox3).set_BackgroundImage((Image)((ResourceManager)(object)val).GetObject("pictureBox3.BackgroundImage"));
			((Control)pictureBox3).set_BackgroundImageLayout((ImageLayout)3);
			((Control)pictureBox3).set_Location(new Point(91, 223));
			((Control)pictureBox3).set_Name("pictureBox3");
			((Control)pictureBox3).set_Size(new Size(38, 38));
			pictureBox3.set_TabIndex(11);
			pictureBox3.set_TabStop(false);
			((Control)pictureBox3).add_Click((EventHandler)pictureBox3_Click);
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Control)this).set_BackgroundImage((Image)((ResourceManager)(object)val).GetObject("$this.BackgroundImage"));
			((Control)this).set_BackgroundImageLayout((ImageLayout)3);
			((Form)this).set_ClientSize(new Size(399, 261));
			((Control)this).get_Controls().Add((Control)(object)pictureBox3);
			((Control)this).get_Controls().Add((Control)(object)label5);
			((Control)this).get_Controls().Add((Control)(object)button7);
			((Control)this).get_Controls().Add((Control)(object)button6);
			((Control)this).get_Controls().Add((Control)(object)label3);
			((Control)this).get_Controls().Add((Control)(object)label2);
			((Control)this).get_Controls().Add((Control)(object)label1);
			((Control)this).get_Controls().Add((Control)(object)panel1);
			((Control)this).get_Controls().Add((Control)(object)pictureBox2);
			((Control)this).get_Controls().Add((Control)(object)pictureBox1);
			((Control)this).set_DoubleBuffered(true);
			((Form)this).set_FormBorderStyle((FormBorderStyle)0);
			((Form)this).set_Icon((Icon)((ResourceManager)(object)val).GetObject("$this.Icon"));
			((Control)this).set_Name("Launcher");
			((Control)this).set_Text("Form1");
			((Form)this).add_Load((EventHandler)Launcher_Load);
			((ISupportInitialize)pictureBox1).EndInit();
			((ISupportInitialize)pictureBox2).EndInit();
			((Control)panel1).ResumeLayout(false);
			((Control)panel1).PerformLayout();
			((ISupportInitialize)pictureBox3).EndInit();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
