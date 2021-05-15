using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using airGlideCheat;
using AirJumpcheat;
using AirWalkCheat;
using ezOverLay;
using FlulllightCheat;
using FlyDamagebypasscheat;
using Gma.System.MouseKeyHook;
using HighjumpCheat;
using HitbocCheat;
using InfinitiJumpCheat;
using Instabreakcheat;
using LagyHitboxCheat;
using NoknockbackCheat;
using PhaseCheat;
using PositionGlideCheat;
using RainbowSkyCheat;
using reachcheat;
using SpeedCheat;
using SpeedSneakCheat;
using stopskycircluscheat;
using Zoomcheat;

namespace Memory.dll_MCBE_Chat_ÜBREARBEITUNG
{
	public class Clickgui : Form
	{
		private Mem m = new Mem();

		private ez ez = new ez();

		private Point MouseDownLocation;

		private Point MouseDownLocation1;

		private Point MouseDownLocation2;

		private Point MouseDownLocation3;

		private Point MouseDownLocation4;

		private Keystrokes keystform = new Keystrokes();

		private Reach reach = new Reach();

		private Zoom zoom = new Zoom();

		private lagyHitbox lhitbox = new lagyHitbox();

		private PositionGlide pglide = new PositionGlide();

		private AirJumpcs airj = new AirJumpcs();

		private Instabreak instab = new Instabreak();

		private Speed speed = new Speed();

		private InfinitiJump ijmp = new InfinitiJump();

		private AirWalk airwalk = new AirWalk();

		private NoKnockback noknck = new NoKnockback();

		private Glide aglide = new Glide();

		private Hitbox hitbox = new Hitbox();

		private RainbowSky Rsky = new RainbowSky();

		private FastSneak speedsneak = new FastSneak();

		private Phase phs = new Phase();

		private Highjump hgjmp = new Highjump();

		private FlyDamageBypass fdbypass = new FlyDamageBypass();

		private Fulllight Fullli = new Fulllight();

		private StopSkyCirclus SVT = new StopSkyCirclus();

		private bool isClickGuishown = true;

		private bool reach_on;

		private float range;

		private bool p4isshown;

		private bool lagyhitbox_on;

		private bool poglide;

		private bool airjump_on;

		private bool instabreak_on;

		private bool speed_on;

		private bool infjmp_on;

		private bool airwalk_on;

		private bool noknock_on;

		private bool Glide_on;

		private bool hizboxom;

		private bool RSRun;

		private bool speedsneakon;

		private bool phaseon;

		private bool highjumpon;

		private bool flydbon;

		private bool fulllighton;

		private bool stopvton;

		private IContainer components;

		private Panel panel1;

		private Label label1;

		private Button button1;

		private Panel panel2;

		private TrackBar trackBar1;

		private Label label2;

		private Panel panel3;

		private Label label3;

		private Button button2;

		private Panel panel4;

		private Label label4;

		private ComboBox comboBox1;

		private Panel panel5;

		private Label label5;

		private TrackBar trackBar2;

		private Panel panel6;

		private Button button4;

		private Label label6;

		private Panel panel7;

		private ComboBox comboBox2;

		private Label label7;

		private Label label8;

		private Button button5;

		private Panel panel8;

		private ComboBox comboBox3;

		private Label label9;

		private Button button6;

		private Panel panel9;

		private Label label10;

		private Button button7;

		private Panel panel10;

		private Label label11;

		private TrackBar trackBar3;

		private Button button8;

		private Panel panel11;

		private TrackBar trackBar4;

		private ComboBox comboBox4;

		private Label label12;

		private Button button11;

		private Button button10;

		private Button button9;

		private Button button12;

		private Button button13;

		private Button button14;

		private CheckBox checkBox1;

		private Button button15;

		private Panel panel12;

		private ComboBox comboBox5;

		private Label label13;

		private Button button16;

		private Button button17;

		private Button button18;

		private BackgroundWorker RainbowSkyBGW;

		private Button button19;

		private Button button3;

		private Panel panel13;

		private TrackBar trackBar5;

		private ComboBox comboBox6;

		private Label label14;

		private Panel panel14;

		private Button button23;

		private Label label15;

		private Button button20;

		private Label label16;

		private Button button21;

		public Clickgui()
			: this()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			InitializeComponent();
		}

		private void Clickgui_Load(object sender, EventArgs e)
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			m.OpenProcess("Minecraft.Windows");
			((Form)this).set_TopMost(true);
			ez.SetInvi((Form)(object)this);
			ez.StartLoop(200, "Minecraft", (Form)(object)this);
			IKeyboardMouseEvents obj = Hook.GlobalEvents();
			((IKeyboardEvents)obj).add_KeyDown(new KeyEventHandler(Hook_KeyDown));
			((IKeyboardEvents)obj).add_KeyUp(new KeyEventHandler(Hook_KeyUp));
			((Control)panel2).Hide();
			((Control)panel4).Hide();
			((Control)panel5).Hide();
			((Control)panel7).Hide();
			((Control)panel8).Hide();
			((Control)panel10).Hide();
			((Control)panel11).Hide();
			((Control)panel12).Hide();
			((Control)panel13).Hide();
			((Control)new Overlay()).Show();
			((Control)keystform).Show();
			((Control)keystform).Hide();
		}

		private void Hook_KeyUp(object sender, KeyEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Invalid comparison between Unknown and I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			if ((int)e.get_KeyCode() == 67)
			{
				zoom.Zoomout();
			}
			if ((int)e.get_KeyCode() == 45)
			{
				isClickGuishown = !isClickGuishown;
				if (!isClickGuishown)
				{
					((Control)this).Hide();
				}
				else
				{
					((Control)this).Show();
				}
			}
			if (e.get_KeyCode() == injumpkey())
			{
				ijmp.unfreezejump();
			}
		}

		private void Hook_KeyDown(object sender, KeyEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Invalid comparison between Unknown and I4
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			if ((int)e.get_KeyCode() == 67)
			{
				zoom.Zoomin();
			}
			if (e.get_KeyCode() == pglidekey())
			{
				poglide = !poglide;
				if (poglide)
				{
					pglide.freezeglide();
					((Control)panel7).Show();
				}
				else
				{
					pglide.unfrezzeglide();
					((Control)panel7).Hide();
				}
			}
			if (e.get_KeyCode() == aglidekey())
			{
				Glide_on = !Glide_on;
				if (Glide_on)
				{
					aglide.glideon();
				}
				else
				{
					aglide.glideof();
				}
			}
			if (e.get_KeyCode() == injumpkey())
			{
				string jmps = ((trackBar4.get_Value() == 0) ? "0.13" : ((trackBar4.get_Value() == 1) ? "0.14" : ((trackBar4.get_Value() == 2) ? "0.18" : ((trackBar4.get_Value() == 3) ? "0.2" : ((trackBar4.get_Value() == 4) ? "0.5" : ((trackBar4.get_Value() == 5) ? "0.8" : ((trackBar4.get_Value() == 6) ? "1" : ((trackBar4.get_Value() != 7) ? "3" : "1.5"))))))));
				ijmp.freezejump(jmps);
			}
		}

		public void button1_Click(object sender, EventArgs e)
		{
			reach_on = !reach_on;
			if (reach_on)
			{
				range = trackBar1.get_Value();
				((Control)panel2).Show();
				reach.writereach(range);
			}
			else
			{
				((Control)panel2).Hide();
				reach.writereach(3f);
			}
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			reach.writereach(trackBar1.get_Value());
		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if ((int)e.get_Button() == 1048576)
			{
				MouseDownLocation = e.get_Location();
			}
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)e.get_Button() == 1048576)
			{
				((Control)panel1).set_Left(e.get_X() + ((Control)panel1).get_Left() - ((Point)(ref MouseDownLocation)).get_X());
				((Control)panel1).set_Top(e.get_Y() + ((Control)panel1).get_Top() - ((Point)(ref MouseDownLocation)).get_Y());
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			p4isshown = !p4isshown;
			if (p4isshown)
			{
				((Control)panel4).Show();
			}
			else
			{
				((Control)panel4).Hide();
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void button3_Click(object sender, EventArgs e)
		{
			lagyhitbox_on = !lagyhitbox_on;
			if (lagyhitbox_on)
			{
				((Control)panel5).Show();
				if (trackBar2.get_Value() != 0)
				{
					if (trackBar2.get_Value() == 1)
					{
						lhitbox.writeHitbox("0.5");
					}
					else if (trackBar2.get_Value() == 2)
					{
						lhitbox.writeHitbox("1");
					}
					else if (trackBar2.get_Value() == 3)
					{
						lhitbox.writeHitbox("1.5");
					}
					else if (trackBar2.get_Value() == 1)
					{
						lhitbox.writeHitbox("2");
					}
				}
			}
			else
			{
				((Control)panel5).Hide();
				lhitbox.writeHitbox("0.10");
			}
		}

		private void trackBar2_Scroll(object sender, EventArgs e)
		{
			if (trackBar2.get_Value() != 0)
			{
				if (trackBar2.get_Value() == 1)
				{
					lhitbox.writeHitbox("0.5");
				}
				else if (trackBar2.get_Value() == 2)
				{
					lhitbox.writeHitbox("1");
				}
				else if (trackBar2.get_Value() == 3)
				{
					lhitbox.writeHitbox("1.5");
				}
				else if (trackBar2.get_Value() == 1)
				{
					lhitbox.writeHitbox("2");
				}
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			poglide = !poglide;
			if (poglide)
			{
				pglide.freezeglide();
				((Control)panel7).Show();
			}
			else
			{
				pglide.unfrezzeglide();
				((Control)panel7).Hide();
			}
		}

		public void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			pglidekey();
		}

		public Keys pglidekey()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			if (comboBox2.get_SelectedItem() == "F1")
			{
				return (Keys)112;
			}
			if (comboBox2.get_SelectedItem() == "F2")
			{
				return (Keys)113;
			}
			if (comboBox2.get_SelectedItem() == "F3")
			{
				return (Keys)114;
			}
			if (comboBox2.get_SelectedItem() == "F4")
			{
				return (Keys)115;
			}
			if (comboBox2.get_SelectedItem() == "F5")
			{
				return (Keys)116;
			}
			if (comboBox2.get_SelectedItem() == "F6")
			{
				return (Keys)117;
			}
			if (comboBox2.get_SelectedItem() == "F7")
			{
				return (Keys)118;
			}
			if (comboBox2.get_SelectedItem() == "F8")
			{
				return (Keys)119;
			}
			if (comboBox2.get_SelectedItem() == "F9")
			{
				return (Keys)120;
			}
			if (comboBox2.get_SelectedItem() == "F10")
			{
				return (Keys)121;
			}
			if (comboBox2.get_SelectedItem() == "F11")
			{
				return (Keys)122;
			}
			if (comboBox2.get_SelectedItem() == "F12")
			{
				return (Keys)123;
			}
			return (Keys)113;
		}

		private void panel3_MouseDown(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if ((int)e.get_Button() == 1048576)
			{
				MouseDownLocation1 = e.get_Location();
			}
		}

		private void panel3_MouseMove(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)e.get_Button() == 1048576)
			{
				((Control)panel3).set_Left(e.get_X() + ((Control)panel3).get_Left() - ((Point)(ref MouseDownLocation1)).get_X());
				((Control)panel3).set_Top(e.get_Y() + ((Control)panel3).get_Top() - ((Point)(ref MouseDownLocation1)).get_Y());
			}
		}

		private void panel6_MouseDown(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if ((int)e.get_Button() == 1048576)
			{
				MouseDownLocation2 = e.get_Location();
			}
		}

		private void panel6_MouseMove(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)e.get_Button() == 1048576)
			{
				((Control)panel6).set_Left(e.get_X() + ((Control)panel6).get_Left() - ((Point)(ref MouseDownLocation2)).get_X());
				((Control)panel6).set_Top(e.get_Y() + ((Control)panel6).get_Top() - ((Point)(ref MouseDownLocation2)).get_Y());
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			airjump_on = !airjump_on;
			if (airjump_on)
			{
				airj.freezairjump();
				((Control)panel8).Show();
			}
			else
			{
				airj.unfreezairjump();
				((Control)panel8).Hide();
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			instabreak_on = !instabreak_on;
			if (instabreak_on)
			{
				instab.freezinsta();
			}
			else
			{
				instab.unfreezinsta();
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			speed_on = !speed_on;
			if (speed_on)
			{
				((Control)panel10).Show();
				string text = ((trackBar3.get_Value() == 0) ? "0.13" : ((trackBar3.get_Value() == 1) ? "0.14" : ((trackBar3.get_Value() == 2) ? "0.18" : ((trackBar3.get_Value() == 3) ? "0.2" : ((trackBar3.get_Value() == 4) ? "0.5" : ((trackBar3.get_Value() == 5) ? "0.8" : ((trackBar3.get_Value() == 6) ? "1" : ((trackBar3.get_Value() != 7) ? "3" : "1.5"))))))));
				speed.freezespeed(text);
			}
			else
			{
				((Control)panel10).Hide();
				speed.unfreezespeed();
			}
		}

		private void trackBar3_Scroll(object sender, EventArgs e)
		{
			string text = ((trackBar3.get_Value() == 0) ? "0.13" : ((trackBar3.get_Value() == 1) ? "0.14" : ((trackBar3.get_Value() == 2) ? "0.18" : ((trackBar3.get_Value() == 3) ? "0.2" : ((trackBar3.get_Value() == 4) ? "0.5" : ((trackBar3.get_Value() == 5) ? "0.8" : ((trackBar3.get_Value() == 6) ? "1" : ((trackBar3.get_Value() != 7) ? "3" : "1.5"))))))));
			speed.freezespeed(text);
		}

		public void trackBar4_Scroll(object sender, EventArgs e)
		{
			if (trackBar4.get_Value() != 0 && trackBar4.get_Value() != 1 && trackBar4.get_Value() != 2 && trackBar4.get_Value() != 3 && trackBar4.get_Value() != 4 && trackBar4.get_Value() != 5 && trackBar4.get_Value() != 6)
			{
				trackBar4.get_Value();
				_ = 7;
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			infjmp_on = !infjmp_on;
			if (infjmp_on)
			{
				if (trackBar4.get_Value() != 0 && trackBar4.get_Value() != 1 && trackBar4.get_Value() != 2 && trackBar4.get_Value() != 3 && trackBar4.get_Value() != 4 && trackBar4.get_Value() != 5 && trackBar4.get_Value() != 6)
				{
					trackBar4.get_Value();
					_ = 7;
				}
				((Control)panel11).Show();
			}
			else
			{
				ijmp.unfreezejump();
				((Control)panel11).Hide();
			}
		}

		public Keys injumpkey()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			if (comboBox4.get_SelectedItem() == "F1")
			{
				return (Keys)112;
			}
			if (comboBox4.get_SelectedItem() == "F2")
			{
				return (Keys)113;
			}
			if (comboBox4.get_SelectedItem() == "F3")
			{
				return (Keys)114;
			}
			if (comboBox4.get_SelectedItem() == "F4")
			{
				return (Keys)115;
			}
			if (comboBox4.get_SelectedItem() == "F5")
			{
				return (Keys)116;
			}
			if (comboBox4.get_SelectedItem() == "F6")
			{
				return (Keys)117;
			}
			if (comboBox4.get_SelectedItem() == "F7")
			{
				return (Keys)118;
			}
			if (comboBox4.get_SelectedItem() == "F8")
			{
				return (Keys)119;
			}
			if (comboBox4.get_SelectedItem() == "F9")
			{
				return (Keys)120;
			}
			if (comboBox4.get_SelectedItem() == "F10")
			{
				return (Keys)121;
			}
			if (comboBox4.get_SelectedItem() == "F11")
			{
				return (Keys)122;
			}
			if (comboBox4.get_SelectedItem() == "F12")
			{
				return (Keys)123;
			}
			return (Keys)113;
		}

		private void button13_Click(object sender, EventArgs e)
		{
			airjump_on = !airwalk_on;
			if (airwalk_on)
			{
				airwalk.go();
			}
			else
			{
				airwalk.off();
			}
		}

		private void panel9_MouseDown(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if ((int)e.get_Button() == 1048576)
			{
				MouseDownLocation3 = e.get_Location();
			}
		}

		private void panel9_MouseMove(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)e.get_Button() == 1048576)
			{
				((Control)panel9).set_Left(e.get_X() + ((Control)panel9).get_Left() - ((Point)(ref MouseDownLocation3)).get_X());
				((Control)panel9).set_Top(e.get_Y() + ((Control)panel9).get_Top() - ((Point)(ref MouseDownLocation3)).get_Y());
			}
		}

		private void button14_Click(object sender, EventArgs e)
		{
			m.OpenProcess("Minecraft.Windows");
			noknock_on = !noknock_on;
			if (noknock_on)
			{
				noknck.Noknockback_on();
			}
			else
			{
				noknck.Noknockback_off();
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			Glide_on = !Glide_on;
			if (Glide_on)
			{
				aglide.glideon();
			}
			else
			{
				aglide.glideof();
			}
		}

		public Keys aglidekey()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			if (comboBox4.get_SelectedItem() == "F1")
			{
				return (Keys)112;
			}
			if (comboBox4.get_SelectedItem() == "F2")
			{
				return (Keys)113;
			}
			if (comboBox4.get_SelectedItem() == "F3")
			{
				return (Keys)114;
			}
			if (comboBox4.get_SelectedItem() == "F4")
			{
				return (Keys)115;
			}
			if (comboBox4.get_SelectedItem() == "F5")
			{
				return (Keys)116;
			}
			if (comboBox4.get_SelectedItem() == "F6")
			{
				return (Keys)117;
			}
			if (comboBox4.get_SelectedItem() == "F7")
			{
				return (Keys)118;
			}
			if (comboBox4.get_SelectedItem() == "F8")
			{
				return (Keys)119;
			}
			if (comboBox4.get_SelectedItem() == "F9")
			{
				return (Keys)120;
			}
			if (comboBox4.get_SelectedItem() == "F10")
			{
				return (Keys)121;
			}
			if (comboBox4.get_SelectedItem() == "F11")
			{
				return (Keys)122;
			}
			if (comboBox4.get_SelectedItem() == "F12")
			{
				return (Keys)123;
			}
			return (Keys)113;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.get_Checked())
			{
				((Control)keystform).Show();
			}
			else
			{
				((Control)keystform).Hide();
			}
		}

		private void button17_Click(object sender, EventArgs e)
		{
			hizboxom = !hizboxom;
			if (hizboxom)
			{
				hitbox.Hitboxon();
			}
		}

		private void button18_Click(object sender, EventArgs e)
		{
			RSRun = !RSRun;
			if (!RainbowSkyBGW.get_IsBusy())
			{
				RainbowSkyBGW.RunWorkerAsync();
			}
		}

		private void RainbowSkyBGW_DoWork(object sender, DoWorkEventArgs e)
		{
			float num = 0.05f;
			while (RSRun)
			{
				Rsky.on(num.ToString());
				num += 0.01f;
				Thread.Sleep(10);
			}
		}

		private void button19_Click(object sender, EventArgs e)
		{
			speedsneakon = !speedsneakon;
			if (speedsneakon)
			{
				speedsneak.on();
			}
			else
			{
				speedsneak.off();
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			phaseon = !phaseon;
			if (phaseon)
			{
				phs.on();
			}
			else
			{
				phs.off();
			}
		}

		private void button3_Click_1(object sender, EventArgs e)
		{
			highjumpon = !highjumpon;
			if (highjumpon)
			{
				((Control)panel13).Show();
				if (trackBar5.get_Value() == 0)
				{
					hgjmp.write(0.4f);
				}
				else if (trackBar5.get_Value() == 1)
				{
					hgjmp.write(0.5f);
				}
				else if (trackBar5.get_Value() == 2)
				{
					hgjmp.write(0.6f);
				}
				else if (trackBar5.get_Value() == 3)
				{
					hgjmp.write(0.8f);
				}
				else if (trackBar5.get_Value() == 4)
				{
					hgjmp.write(1f);
				}
				else if (trackBar5.get_Value() == 5)
				{
					hgjmp.write(1.5f);
				}
				else
				{
					hgjmp.write(2f);
				}
			}
			else
			{
				hgjmp.write(0.4f);
				((Control)panel13).Hide();
			}
		}

		private void trackBar5_Scroll(object sender, EventArgs e)
		{
			if (highjumpon)
			{
				if (trackBar5.get_Value() == 0)
				{
					hgjmp.write(0.4f);
				}
				else if (trackBar5.get_Value() == 1)
				{
					hgjmp.write(0.5f);
				}
				else if (trackBar5.get_Value() == 2)
				{
					hgjmp.write(0.6f);
				}
				else if (trackBar5.get_Value() == 3)
				{
					hgjmp.write(0.8f);
				}
				else if (trackBar5.get_Value() == 4)
				{
					hgjmp.write(1f);
				}
				else if (trackBar5.get_Value() == 5)
				{
					hgjmp.write(1.5f);
				}
				else
				{
					hgjmp.write(2f);
				}
			}
		}

		private void panel14_MouseDown(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if ((int)e.get_Button() == 1048576)
			{
				MouseDownLocation4 = e.get_Location();
			}
		}

		private void panel14_MouseMove(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)e.get_Button() == 1048576)
			{
				((Control)panel14).set_Left(e.get_X() + ((Control)panel14).get_Left() - ((Point)(ref MouseDownLocation4)).get_X());
				((Control)panel14).set_Top(e.get_Y() + ((Control)panel14).get_Top() - ((Point)(ref MouseDownLocation4)).get_Y());
			}
		}

		private void button23_Click(object sender, EventArgs e)
		{
			flydbon = !flydbon;
			if (flydbon)
			{
				fdbypass.on();
			}
			else
			{
				fdbypass.off();
			}
		}

		private void button20_Click(object sender, EventArgs e)
		{
			fulllighton = !fulllighton;
			if (fulllighton)
			{
				Fullli.on();
			}
			else
			{
				Fullli.off();
			}
		}

		private void button21_Click(object sender, EventArgs e)
		{
			stopvton = !stopvton;
			if (stopvton)
			{
				SVT.on();
			}
			else
			{
				SVT.off();
			}
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
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Expected O, but got Unknown
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Expected O, but got Unknown
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Expected O, but got Unknown
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Expected O, but got Unknown
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected O, but got Unknown
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Expected O, but got Unknown
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Expected O, but got Unknown
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Expected O, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Expected O, but got Unknown
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected O, but got Unknown
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Expected O, but got Unknown
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Expected O, but got Unknown
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Expected O, but got Unknown
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Expected O, but got Unknown
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Expected O, but got Unknown
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Expected O, but got Unknown
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Expected O, but got Unknown
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Expected O, but got Unknown
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Expected O, but got Unknown
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Expected O, but got Unknown
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected O, but got Unknown
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Expected O, but got Unknown
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Expected O, but got Unknown
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Expected O, but got Unknown
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Expected O, but got Unknown
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected O, but got Unknown
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Expected O, but got Unknown
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Expected O, but got Unknown
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Expected O, but got Unknown
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Expected O, but got Unknown
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Expected O, but got Unknown
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected O, but got Unknown
			//IL_0263: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Expected O, but got Unknown
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Expected O, but got Unknown
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Expected O, but got Unknown
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Expected O, but got Unknown
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Expected O, but got Unknown
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Expected O, but got Unknown
			//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Expected O, but got Unknown
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Expected O, but got Unknown
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Expected O, but got Unknown
			//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Expected O, but got Unknown
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Expected O, but got Unknown
			//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e0: Expected O, but got Unknown
			//IL_0467: Unknown result type (might be due to invalid IL or missing references)
			//IL_0491: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04be: Expected O, but got Unknown
			//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d5: Expected O, but got Unknown
			//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ec: Expected O, but got Unknown
			//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_051b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0525: Expected O, but got Unknown
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_054d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0574: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f6: Expected O, but got Unknown
			//IL_060b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0621: Unknown result type (might be due to invalid IL or missing references)
			//IL_0648: Unknown result type (might be due to invalid IL or missing references)
			//IL_0697: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ca: Expected O, but got Unknown
			//IL_06df: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_071c: Unknown result type (might be due to invalid IL or missing references)
			//IL_076b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0794: Unknown result type (might be due to invalid IL or missing references)
			//IL_079e: Expected O, but got Unknown
			//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0848: Unknown result type (might be due to invalid IL or missing references)
			//IL_0865: Unknown result type (might be due to invalid IL or missing references)
			//IL_086f: Expected O, but got Unknown
			//IL_0884: Unknown result type (might be due to invalid IL or missing references)
			//IL_0898: Unknown result type (might be due to invalid IL or missing references)
			//IL_08bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0918: Unknown result type (might be due to invalid IL or missing references)
			//IL_093f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0967: Unknown result type (might be due to invalid IL or missing references)
			//IL_0984: Unknown result type (might be due to invalid IL or missing references)
			//IL_098e: Expected O, but got Unknown
			//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_09d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a50: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab7: Expected O, but got Unknown
			//IL_0b80: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd7: Expected O, but got Unknown
			//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bee: Expected O, but got Unknown
			//IL_0bf4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c27: Expected O, but got Unknown
			//IL_0c3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c79: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cfb: Expected O, but got Unknown
			//IL_0d10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dcf: Expected O, but got Unknown
			//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dfa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e21: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e99: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ea3: Expected O, but got Unknown
			//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ece: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f56: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f60: Expected O, but got Unknown
			//IL_0f75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f8b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fea: Unknown result type (might be due to invalid IL or missing references)
			//IL_1013: Unknown result type (might be due to invalid IL or missing references)
			//IL_101d: Expected O, but got Unknown
			//IL_1032: Unknown result type (might be due to invalid IL or missing references)
			//IL_1045: Unknown result type (might be due to invalid IL or missing references)
			//IL_106c: Unknown result type (might be due to invalid IL or missing references)
			//IL_10a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d7: Expected O, but got Unknown
			//IL_10ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_10ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1126: Unknown result type (might be due to invalid IL or missing references)
			//IL_1181: Unknown result type (might be due to invalid IL or missing references)
			//IL_119e: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a8: Expected O, but got Unknown
			//IL_11bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_11d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_11f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1251: Unknown result type (might be due to invalid IL or missing references)
			//IL_1278: Unknown result type (might be due to invalid IL or missing references)
			//IL_12bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_12e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_132f: Unknown result type (might be due to invalid IL or missing references)
			//IL_134c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1356: Expected O, but got Unknown
			//IL_136b: Unknown result type (might be due to invalid IL or missing references)
			//IL_137d: Unknown result type (might be due to invalid IL or missing references)
			//IL_13a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1400: Unknown result type (might be due to invalid IL or missing references)
			//IL_1427: Unknown result type (might be due to invalid IL or missing references)
			//IL_144f: Unknown result type (might be due to invalid IL or missing references)
			//IL_146c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1476: Expected O, but got Unknown
			//IL_148b: Unknown result type (might be due to invalid IL or missing references)
			//IL_149d: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_14fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_152c: Unknown result type (might be due to invalid IL or missing references)
			//IL_156e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1589: Unknown result type (might be due to invalid IL or missing references)
			//IL_1593: Expected O, but got Unknown
			//IL_1688: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_16df: Expected O, but got Unknown
			//IL_16ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_16f6: Expected O, but got Unknown
			//IL_16fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1725: Unknown result type (might be due to invalid IL or missing references)
			//IL_172f: Expected O, but got Unknown
			//IL_1744: Unknown result type (might be due to invalid IL or missing references)
			//IL_175a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1781: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_17fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_1804: Expected O, but got Unknown
			//IL_1819: Unknown result type (might be due to invalid IL or missing references)
			//IL_182f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1856: Unknown result type (might be due to invalid IL or missing references)
			//IL_18a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_18cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_18d9: Expected O, but got Unknown
			//IL_18ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_1904: Unknown result type (might be due to invalid IL or missing references)
			//IL_192b: Unknown result type (might be due to invalid IL or missing references)
			//IL_197a: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ad: Expected O, but got Unknown
			//IL_19c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_19d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a77: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a81: Expected O, but got Unknown
			//IL_1a96: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aac: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ad3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b22: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b55: Expected O, but got Unknown
			//IL_1b6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b80: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ba7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bf6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c29: Expected O, but got Unknown
			//IL_1c3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c54: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cca: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cf3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cfd: Expected O, but got Unknown
			//IL_1d12: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d25: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dc4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dce: Expected O, but got Unknown
			//IL_1de3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1df6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e78: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e95: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e9f: Expected O, but got Unknown
			//IL_1eb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ec8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eec: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f4b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f72: Unknown result type (might be due to invalid IL or missing references)
			//IL_20db: Unknown result type (might be due to invalid IL or missing references)
			//IL_20ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_214e: Unknown result type (might be due to invalid IL or missing references)
			//IL_216b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2175: Expected O, but got Unknown
			//IL_218a: Unknown result type (might be due to invalid IL or missing references)
			//IL_219c: Unknown result type (might be due to invalid IL or missing references)
			//IL_21c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_21f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_2215: Unknown result type (might be due to invalid IL or missing references)
			//IL_221f: Expected O, but got Unknown
			//IL_2234: Unknown result type (might be due to invalid IL or missing references)
			//IL_224b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2272: Unknown result type (might be due to invalid IL or missing references)
			//IL_22d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_22f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_2461: Unknown result type (might be due to invalid IL or missing references)
			//IL_2485: Unknown result type (might be due to invalid IL or missing references)
			//IL_24bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_24da: Unknown result type (might be due to invalid IL or missing references)
			//IL_24e4: Expected O, but got Unknown
			//IL_24f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_250b: Unknown result type (might be due to invalid IL or missing references)
			//IL_252f: Unknown result type (might be due to invalid IL or missing references)
			//IL_255e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2579: Unknown result type (might be due to invalid IL or missing references)
			//IL_2583: Expected O, but got Unknown
			//IL_25de: Unknown result type (might be due to invalid IL or missing references)
			//IL_2608: Unknown result type (might be due to invalid IL or missing references)
			//IL_262c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2636: Expected O, but got Unknown
			//IL_2643: Unknown result type (might be due to invalid IL or missing references)
			//IL_264d: Expected O, but got Unknown
			//IL_2653: Unknown result type (might be due to invalid IL or missing references)
			//IL_267c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2686: Expected O, but got Unknown
			//IL_269b: Unknown result type (might be due to invalid IL or missing references)
			//IL_26af: Unknown result type (might be due to invalid IL or missing references)
			//IL_26d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_2730: Unknown result type (might be due to invalid IL or missing references)
			//IL_273a: Expected O, but got Unknown
			//IL_274f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2762: Unknown result type (might be due to invalid IL or missing references)
			//IL_2786: Unknown result type (might be due to invalid IL or missing references)
			//IL_27e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_27fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_2808: Expected O, but got Unknown
			//IL_281d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2831: Unknown result type (might be due to invalid IL or missing references)
			//IL_2858: Unknown result type (might be due to invalid IL or missing references)
			//IL_28b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_28de: Unknown result type (might be due to invalid IL or missing references)
			//IL_2907: Unknown result type (might be due to invalid IL or missing references)
			//IL_2924: Unknown result type (might be due to invalid IL or missing references)
			//IL_292e: Expected O, but got Unknown
			//IL_2943: Unknown result type (might be due to invalid IL or missing references)
			//IL_2955: Unknown result type (might be due to invalid IL or missing references)
			//IL_2979: Unknown result type (might be due to invalid IL or missing references)
			//IL_29b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_29e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a93: Unknown result type (might be due to invalid IL or missing references)
			//IL_2abf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2aef: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2c9f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cf4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cfe: Expected O, but got Unknown
			//IL_2d13: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d25: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d49: Unknown result type (might be due to invalid IL or missing references)
			//IL_2da8: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dcf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f39: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f95: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fbc: Expected O, but got Unknown
			//IL_2fd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fe3: Unknown result type (might be due to invalid IL or missing references)
			//IL_3007: Unknown result type (might be due to invalid IL or missing references)
			//IL_303a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3044: Expected O, but got Unknown
			//IL_3093: Unknown result type (might be due to invalid IL or missing references)
			//IL_30ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_30e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_3116: Unknown result type (might be due to invalid IL or missing references)
			//IL_32a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_32c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_32fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_331b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3325: Expected O, but got Unknown
			//IL_333a: Unknown result type (might be due to invalid IL or missing references)
			//IL_334c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3370: Unknown result type (might be due to invalid IL or missing references)
			//IL_339f: Unknown result type (might be due to invalid IL or missing references)
			//IL_33ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_33c4: Expected O, but got Unknown
			//IL_3409: Unknown result type (might be due to invalid IL or missing references)
			//IL_3433: Unknown result type (might be due to invalid IL or missing references)
			//IL_3457: Unknown result type (might be due to invalid IL or missing references)
			//IL_3461: Expected O, but got Unknown
			//IL_346e: Unknown result type (might be due to invalid IL or missing references)
			//IL_3478: Expected O, but got Unknown
			//IL_347e: Unknown result type (might be due to invalid IL or missing references)
			//IL_34a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_34b1: Expected O, but got Unknown
			//IL_34c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_34d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3500: Unknown result type (might be due to invalid IL or missing references)
			//IL_355b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3578: Unknown result type (might be due to invalid IL or missing references)
			//IL_3582: Expected O, but got Unknown
			//IL_3597: Unknown result type (might be due to invalid IL or missing references)
			//IL_35ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_35d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_360a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3627: Unknown result type (might be due to invalid IL or missing references)
			//IL_3631: Expected O, but got Unknown
			//IL_3646: Unknown result type (might be due to invalid IL or missing references)
			//IL_365c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3683: Unknown result type (might be due to invalid IL or missing references)
			//IL_36b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_36d1: Unknown result type (might be due to invalid IL or missing references)
			ComponentResourceManager val = new ComponentResourceManager(typeof(Clickgui));
			panel1 = new Panel();
			button17 = new Button();
			button14 = new Button();
			button6 = new Button();
			button1 = new Button();
			label1 = new Label();
			panel2 = new Panel();
			label2 = new Label();
			trackBar1 = new TrackBar();
			panel3 = new Panel();
			button21 = new Button();
			button20 = new Button();
			button18 = new Button();
			button11 = new Button();
			button10 = new Button();
			button9 = new Button();
			button2 = new Button();
			label3 = new Label();
			panel4 = new Panel();
			comboBox1 = new ComboBox();
			label4 = new Label();
			panel5 = new Panel();
			label5 = new Label();
			trackBar2 = new TrackBar();
			panel6 = new Panel();
			button3 = new Button();
			button19 = new Button();
			button15 = new Button();
			button13 = new Button();
			button12 = new Button();
			button8 = new Button();
			button7 = new Button();
			button5 = new Button();
			button4 = new Button();
			label6 = new Label();
			panel7 = new Panel();
			comboBox2 = new ComboBox();
			label7 = new Label();
			label8 = new Label();
			panel8 = new Panel();
			comboBox3 = new ComboBox();
			label9 = new Label();
			panel9 = new Panel();
			button16 = new Button();
			checkBox1 = new CheckBox();
			label10 = new Label();
			panel10 = new Panel();
			label11 = new Label();
			trackBar3 = new TrackBar();
			panel11 = new Panel();
			trackBar4 = new TrackBar();
			comboBox4 = new ComboBox();
			label12 = new Label();
			panel12 = new Panel();
			comboBox5 = new ComboBox();
			label13 = new Label();
			RainbowSkyBGW = new BackgroundWorker();
			panel13 = new Panel();
			trackBar5 = new TrackBar();
			comboBox6 = new ComboBox();
			label14 = new Label();
			panel14 = new Panel();
			button23 = new Button();
			label15 = new Label();
			label16 = new Label();
			((Control)panel1).SuspendLayout();
			((Control)panel2).SuspendLayout();
			((ISupportInitialize)trackBar1).BeginInit();
			((Control)panel3).SuspendLayout();
			((Control)panel4).SuspendLayout();
			((Control)panel5).SuspendLayout();
			((ISupportInitialize)trackBar2).BeginInit();
			((Control)panel6).SuspendLayout();
			((Control)panel7).SuspendLayout();
			((Control)panel8).SuspendLayout();
			((Control)panel9).SuspendLayout();
			((Control)panel10).SuspendLayout();
			((ISupportInitialize)trackBar3).BeginInit();
			((Control)panel11).SuspendLayout();
			((ISupportInitialize)trackBar4).BeginInit();
			((Control)panel12).SuspendLayout();
			((Control)panel13).SuspendLayout();
			((ISupportInitialize)trackBar5).BeginInit();
			((Control)panel14).SuspendLayout();
			((Control)this).SuspendLayout();
			((Control)panel1).set_BackColor(Color.FromArgb(3, 2, 8));
			((Control)panel1).set_BackgroundImage((Image)((ResourceManager)(object)val).GetObject("panel1.BackgroundImage"));
			((Control)panel1).set_BackgroundImageLayout((ImageLayout)3);
			((Control)panel1).get_Controls().Add((Control)(object)button17);
			((Control)panel1).get_Controls().Add((Control)(object)button14);
			((Control)panel1).get_Controls().Add((Control)(object)button6);
			((Control)panel1).get_Controls().Add((Control)(object)button1);
			((Control)panel1).get_Controls().Add((Control)(object)label1);
			((Control)panel1).set_Location(new Point(338, 112));
			((Control)panel1).set_Name("panel1");
			((Control)panel1).set_Size(new Size(167, 337));
			((Control)panel1).set_TabIndex(0);
			((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
			((Control)panel1).add_MouseDown(new MouseEventHandler(panel1_MouseDown));
			((Control)panel1).add_MouseMove(new MouseEventHandler(panel1_MouseMove));
			((Control)button17).set_BackColor(Color.get_Transparent());
			((ButtonBase)button17).set_FlatStyle((FlatStyle)1);
			((Control)button17).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button17).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button17).set_Location(new Point(3, 106));
			((Control)button17).set_Name("button17");
			((Control)button17).set_Size(new Size(161, 29));
			((Control)button17).set_TabIndex(5);
			((Control)button17).set_Text("Hitbox");
			((ButtonBase)button17).set_UseVisualStyleBackColor(false);
			((Control)button17).add_Click((EventHandler)button17_Click);
			((Control)button14).set_BackColor(Color.get_Transparent());
			((ButtonBase)button14).set_FlatStyle((FlatStyle)1);
			((Control)button14).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button14).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button14).set_Location(new Point(3, 176));
			((Control)button14).set_Name("button14");
			((Control)button14).set_Size(new Size(161, 29));
			((Control)button14).set_TabIndex(4);
			((Control)button14).set_Text("NoKnockback");
			((ButtonBase)button14).set_UseVisualStyleBackColor(false);
			((Control)button14).add_Click((EventHandler)button14_Click);
			((Control)button6).set_BackColor(Color.get_Transparent());
			((ButtonBase)button6).set_FlatStyle((FlatStyle)1);
			((Control)button6).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button6).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button6).set_Location(new Point(3, 141));
			((Control)button6).set_Name("button6");
			((Control)button6).set_Size(new Size(161, 29));
			((Control)button6).set_TabIndex(3);
			((Control)button6).set_Text("Instabreak");
			((ButtonBase)button6).set_UseVisualStyleBackColor(false);
			((Control)button6).add_Click((EventHandler)button6_Click);
			((Control)button1).set_BackColor(Color.get_Transparent());
			((ButtonBase)button1).set_FlatStyle((FlatStyle)1);
			((Control)button1).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button1).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button1).set_Location(new Point(3, 71));
			((Control)button1).set_Name("button1");
			((Control)button1).set_Size(new Size(161, 29));
			((Control)button1).set_TabIndex(1);
			((Control)button1).set_Text("Reach");
			((ButtonBase)button1).set_UseVisualStyleBackColor(false);
			((Control)button1).add_Click((EventHandler)button1_Click);
			((Control)label1).set_AutoSize(true);
			((Control)label1).set_BackColor(Color.get_Transparent());
			((Control)label1).set_Font(new Font("MV Boli", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label1).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label1).set_Location(new Point(27, 29));
			((Control)label1).set_Name("label1");
			((Control)label1).set_Size(new Size(109, 39));
			((Control)label1).set_TabIndex(0);
			((Control)label1).set_Text("Combo");
			((Control)panel2).get_Controls().Add((Control)(object)label2);
			((Control)panel2).get_Controls().Add((Control)(object)trackBar1);
			((Control)panel2).set_Location(new Point(12, 38));
			((Control)panel2).set_Name("panel2");
			((Control)panel2).set_Size(new Size(139, 68));
			((Control)panel2).set_TabIndex(1);
			((Control)label2).set_AutoSize(true);
			((Control)label2).set_BackColor(Color.get_Transparent());
			((Control)label2).set_Font(new Font("MV Boli", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label2).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label2).set_Location(new Point(3, 0));
			((Control)label2).set_Name("label2");
			((Control)label2).set_Size(new Size(47, 17));
			((Control)label2).set_TabIndex(1);
			((Control)label2).set_Text("Range");
			trackBar1.set_LargeChange(1);
			((Control)trackBar1).set_Location(new Point(3, 23));
			trackBar1.set_Maximum(7);
			trackBar1.set_Minimum(3);
			((Control)trackBar1).set_Name("trackBar1");
			((Control)trackBar1).set_Size(new Size(105, 45));
			((Control)trackBar1).set_TabIndex(0);
			trackBar1.set_Value(3);
			trackBar1.add_Scroll((EventHandler)trackBar1_Scroll);
			((Control)panel3).set_BackColor(Color.FromArgb(3, 2, 8));
			((Control)panel3).set_BackgroundImage((Image)((ResourceManager)(object)val).GetObject("panel3.BackgroundImage"));
			((Control)panel3).set_BackgroundImageLayout((ImageLayout)3);
			((Control)panel3).get_Controls().Add((Control)(object)button21);
			((Control)panel3).get_Controls().Add((Control)(object)button20);
			((Control)panel3).get_Controls().Add((Control)(object)button18);
			((Control)panel3).get_Controls().Add((Control)(object)button11);
			((Control)panel3).get_Controls().Add((Control)(object)button10);
			((Control)panel3).get_Controls().Add((Control)(object)button9);
			((Control)panel3).get_Controls().Add((Control)(object)button2);
			((Control)panel3).get_Controls().Add((Control)(object)label3);
			((Control)panel3).set_Location(new Point(540, 112));
			((Control)panel3).set_Name("panel3");
			((Control)panel3).set_Size(new Size(167, 337));
			((Control)panel3).set_TabIndex(2);
			((Control)panel3).add_MouseDown(new MouseEventHandler(panel3_MouseDown));
			((Control)panel3).add_MouseMove(new MouseEventHandler(panel3_MouseMove));
			((Control)button21).set_BackColor(Color.get_Transparent());
			((ButtonBase)button21).set_FlatStyle((FlatStyle)1);
			((Control)button21).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button21).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button21).set_Location(new Point(3, 278));
			((Control)button21).set_Name("button21");
			((Control)button21).set_Size(new Size(161, 29));
			((Control)button21).set_TabIndex(8);
			((Control)button21).set_Text("Stop Visual Time");
			((ButtonBase)button21).set_UseVisualStyleBackColor(false);
			((Control)button21).add_Click((EventHandler)button21_Click);
			((Control)button20).set_BackColor(Color.get_Transparent());
			((ButtonBase)button20).set_FlatStyle((FlatStyle)1);
			((Control)button20).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button20).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button20).set_Location(new Point(3, 243));
			((Control)button20).set_Name("button20");
			((Control)button20).set_Size(new Size(161, 29));
			((Control)button20).set_TabIndex(7);
			((Control)button20).set_Text("Fulllight");
			((ButtonBase)button20).set_UseVisualStyleBackColor(false);
			((Control)button20).add_Click((EventHandler)button20_Click);
			((Control)button18).set_BackColor(Color.get_Transparent());
			((ButtonBase)button18).set_FlatStyle((FlatStyle)1);
			((Control)button18).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button18).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button18).set_Location(new Point(3, 210));
			((Control)button18).set_Name("button18");
			((Control)button18).set_Size(new Size(161, 29));
			((Control)button18).set_TabIndex(6);
			((Control)button18).set_Text("Rainbow Sky");
			((ButtonBase)button18).set_UseVisualStyleBackColor(false);
			((Control)button18).add_Click((EventHandler)button18_Click);
			((Control)button11).set_BackColor(Color.get_Transparent());
			((ButtonBase)button11).set_FlatStyle((FlatStyle)1);
			((Control)button11).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button11).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button11).set_Location(new Point(3, 176));
			((Control)button11).set_Name("button11");
			((Control)button11).set_Size(new Size(161, 29));
			((Control)button11).set_TabIndex(5);
			((Control)button11).set_Text("XRAY");
			((ButtonBase)button11).set_UseVisualStyleBackColor(false);
			((Control)button10).set_BackColor(Color.get_Transparent());
			((ButtonBase)button10).set_FlatStyle((FlatStyle)1);
			((Control)button10).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button10).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button10).set_Location(new Point(3, 141));
			((Control)button10).set_Name("button10");
			((Control)button10).set_Size(new Size(161, 29));
			((Control)button10).set_TabIndex(4);
			((Control)button10).set_Text("ObjectESP");
			((ButtonBase)button10).set_UseVisualStyleBackColor(false);
			((Control)button9).set_BackColor(Color.get_Transparent());
			((ButtonBase)button9).set_FlatStyle((FlatStyle)1);
			((Control)button9).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button9).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button9).set_Location(new Point(3, 106));
			((Control)button9).set_Name("button9");
			((Control)button9).set_Size(new Size(161, 29));
			((Control)button9).set_TabIndex(3);
			((Control)button9).set_Text("ESP");
			((ButtonBase)button9).set_UseVisualStyleBackColor(false);
			((Control)button2).set_BackColor(Color.get_Transparent());
			((ButtonBase)button2).set_FlatStyle((FlatStyle)1);
			((Control)button2).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button2).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button2).set_Location(new Point(3, 71));
			((Control)button2).set_Name("button2");
			((Control)button2).set_Size(new Size(161, 29));
			((Control)button2).set_TabIndex(2);
			((Control)button2).set_Text("Zoom");
			((ButtonBase)button2).set_UseVisualStyleBackColor(false);
			((Control)button2).add_Click((EventHandler)button2_Click);
			((Control)label3).set_AutoSize(true);
			((Control)label3).set_BackColor(Color.get_Transparent());
			((Control)label3).set_Font(new Font("MV Boli", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label3).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label3).set_Location(new Point(27, 29));
			((Control)label3).set_Name("label3");
			((Control)label3).set_Size(new Size(111, 39));
			((Control)label3).set_TabIndex(0);
			((Control)label3).set_Text("Visuals");
			((Control)panel4).get_Controls().Add((Control)(object)comboBox1);
			((Control)panel4).get_Controls().Add((Control)(object)label4);
			((Control)panel4).set_Location(new Point(12, 112));
			((Control)panel4).set_Name("panel4");
			((Control)panel4).set_Size(new Size(139, 68));
			((Control)panel4).set_TabIndex(3);
			((Control)comboBox1).set_Anchor((AnchorStyles)9);
			comboBox1.set_FlatStyle((FlatStyle)1);
			((ListControl)comboBox1).set_FormattingEnabled(true);
			((Control)comboBox1).set_Location(new Point(6, 29));
			((Control)comboBox1).set_Name("comboBox1");
			((Control)comboBox1).set_Size(new Size(44, 21));
			((Control)comboBox1).set_TabIndex(2);
			((Control)comboBox1).set_Text("C");
			comboBox1.add_SelectedIndexChanged((EventHandler)comboBox1_SelectedIndexChanged);
			((Control)label4).set_AutoSize(true);
			((Control)label4).set_BackColor(Color.get_Transparent());
			((Control)label4).set_Font(new Font("MV Boli", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label4).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label4).set_Location(new Point(3, 0));
			((Control)label4).set_Name("label4");
			((Control)label4).set_Size(new Size(86, 17));
			((Control)label4).set_TabIndex(1);
			((Control)label4).set_Text("Zoom Key:");
			((Control)panel5).get_Controls().Add((Control)(object)label5);
			((Control)panel5).get_Controls().Add((Control)(object)trackBar2);
			((Control)panel5).set_Location(new Point(12, 186));
			((Control)panel5).set_Name("panel5");
			((Control)panel5).set_Size(new Size(139, 68));
			((Control)panel5).set_TabIndex(4);
			((Control)label5).set_AutoSize(true);
			((Control)label5).set_BackColor(Color.get_Transparent());
			((Control)label5).set_Font(new Font("MV Boli", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label5).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label5).set_Location(new Point(3, 0));
			((Control)label5).set_Name("label5");
			((Control)label5).set_Size(new Size(48, 17));
			((Control)label5).set_TabIndex(1);
			((Control)label5).set_Text("Withe");
			trackBar2.set_LargeChange(1);
			((Control)trackBar2).set_Location(new Point(3, 23));
			trackBar2.set_Maximum(4);
			((Control)trackBar2).set_Name("trackBar2");
			((Control)trackBar2).set_Size(new Size(105, 45));
			((Control)trackBar2).set_TabIndex(0);
			trackBar2.set_Value(3);
			trackBar2.add_Scroll((EventHandler)trackBar2_Scroll);
			((Control)panel6).set_BackColor(Color.FromArgb(3, 2, 8));
			((Control)panel6).set_BackgroundImage((Image)((ResourceManager)(object)val).GetObject("panel6.BackgroundImage"));
			((Control)panel6).set_BackgroundImageLayout((ImageLayout)3);
			((Control)panel6).get_Controls().Add((Control)(object)button3);
			((Control)panel6).get_Controls().Add((Control)(object)button19);
			((Control)panel6).get_Controls().Add((Control)(object)button15);
			((Control)panel6).get_Controls().Add((Control)(object)button13);
			((Control)panel6).get_Controls().Add((Control)(object)button12);
			((Control)panel6).get_Controls().Add((Control)(object)button8);
			((Control)panel6).get_Controls().Add((Control)(object)button7);
			((Control)panel6).get_Controls().Add((Control)(object)button5);
			((Control)panel6).get_Controls().Add((Control)(object)button4);
			((Control)panel6).get_Controls().Add((Control)(object)label6);
			((Control)panel6).set_Location(new Point(723, 112));
			((Control)panel6).set_Name("panel6");
			((Control)panel6).set_Size(new Size(167, 410));
			((Control)panel6).set_TabIndex(5);
			((Control)panel6).add_MouseDown(new MouseEventHandler(panel6_MouseDown));
			((Control)panel6).add_MouseMove(new MouseEventHandler(panel6_MouseMove));
			((Control)button3).set_BackColor(Color.get_Transparent());
			((ButtonBase)button3).set_FlatStyle((FlatStyle)1);
			((Control)button3).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button3).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button3).set_Location(new Point(3, 348));
			((Control)button3).set_Name("button3");
			((Control)button3).set_Size(new Size(161, 29));
			((Control)button3).set_TabIndex(10);
			((Control)button3).set_Text("HighJump");
			((ButtonBase)button3).set_UseVisualStyleBackColor(false);
			((Control)button3).add_Click((EventHandler)button3_Click_1);
			((Control)button19).set_BackColor(Color.get_Transparent());
			((ButtonBase)button19).set_FlatStyle((FlatStyle)1);
			((Control)button19).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button19).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button19).set_Location(new Point(3, 313));
			((Control)button19).set_Name("button19");
			((Control)button19).set_Size(new Size(161, 29));
			((Control)button19).set_TabIndex(9);
			((Control)button19).set_Text("Speed Sneak");
			((ButtonBase)button19).set_UseVisualStyleBackColor(false);
			((Control)button19).add_Click((EventHandler)button19_Click);
			((Control)button15).set_BackColor(Color.get_Transparent());
			((ButtonBase)button15).set_FlatStyle((FlatStyle)1);
			((Control)button15).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button15).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button15).set_Location(new Point(3, 278));
			((Control)button15).set_Name("button15");
			((Control)button15).set_Size(new Size(161, 29));
			((Control)button15).set_TabIndex(8);
			((Control)button15).set_Text("Normal Glide");
			((ButtonBase)button15).set_UseVisualStyleBackColor(false);
			((Control)button15).add_Click((EventHandler)button15_Click);
			((Control)button13).set_BackColor(Color.get_Transparent());
			((ButtonBase)button13).set_FlatStyle((FlatStyle)1);
			((Control)button13).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button13).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button13).set_Location(new Point(3, 243));
			((Control)button13).set_Name("button13");
			((Control)button13).set_Size(new Size(161, 29));
			((Control)button13).set_TabIndex(7);
			((Control)button13).set_Text("AirWalk");
			((ButtonBase)button13).set_UseVisualStyleBackColor(false);
			((Control)button13).add_Click((EventHandler)button13_Click);
			((Control)button12).set_BackColor(Color.get_Transparent());
			((ButtonBase)button12).set_FlatStyle((FlatStyle)1);
			((Control)button12).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button12).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button12).set_Location(new Point(3, 210));
			((Control)button12).set_Name("button12");
			((Control)button12).set_Size(new Size(161, 29));
			((Control)button12).set_TabIndex(6);
			((Control)button12).set_Text("Phase");
			((ButtonBase)button12).set_UseVisualStyleBackColor(false);
			((Control)button12).add_Click((EventHandler)button12_Click);
			((Control)button8).set_BackColor(Color.get_Transparent());
			((ButtonBase)button8).set_FlatStyle((FlatStyle)1);
			((Control)button8).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button8).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button8).set_Location(new Point(3, 176));
			((Control)button8).set_Name("button8");
			((Control)button8).set_Size(new Size(161, 29));
			((Control)button8).set_TabIndex(5);
			((Control)button8).set_Text("InfinitiJump");
			((ButtonBase)button8).set_UseVisualStyleBackColor(false);
			((Control)button8).add_Click((EventHandler)button8_Click);
			((Control)button7).set_BackColor(Color.get_Transparent());
			((ButtonBase)button7).set_FlatStyle((FlatStyle)1);
			((Control)button7).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button7).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button7).set_Location(new Point(3, 141));
			((Control)button7).set_Name("button7");
			((Control)button7).set_Size(new Size(161, 29));
			((Control)button7).set_TabIndex(4);
			((Control)button7).set_Text("Speed");
			((ButtonBase)button7).set_UseVisualStyleBackColor(false);
			((Control)button7).add_Click((EventHandler)button7_Click);
			((Control)button5).set_BackColor(Color.get_Transparent());
			((ButtonBase)button5).set_FlatStyle((FlatStyle)1);
			((Control)button5).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button5).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button5).set_Location(new Point(3, 106));
			((Control)button5).set_Name("button5");
			((Control)button5).set_Size(new Size(161, 29));
			((Control)button5).set_TabIndex(3);
			((Control)button5).set_Text("AirJump");
			((ButtonBase)button5).set_UseVisualStyleBackColor(false);
			((Control)button5).add_Click((EventHandler)button5_Click);
			((Control)button4).set_BackColor(Color.get_Transparent());
			((ButtonBase)button4).set_FlatStyle((FlatStyle)1);
			((Control)button4).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button4).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button4).set_Location(new Point(3, 71));
			((Control)button4).set_Name("button4");
			((Control)button4).set_Size(new Size(161, 29));
			((Control)button4).set_TabIndex(2);
			((Control)button4).set_Text("P Glide");
			((ButtonBase)button4).set_UseVisualStyleBackColor(false);
			((Control)button4).add_Click((EventHandler)button4_Click);
			((Control)label6).set_AutoSize(true);
			((Control)label6).set_BackColor(Color.get_Transparent());
			((Control)label6).set_Font(new Font("MV Boli", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label6).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label6).set_Location(new Point(50, 29));
			((Control)label6).set_Name("label6");
			((Control)label6).set_Size(new Size(76, 39));
			((Control)label6).set_TabIndex(0);
			((Control)label6).set_Text("Mov");
			((Control)panel7).get_Controls().Add((Control)(object)comboBox2);
			((Control)panel7).get_Controls().Add((Control)(object)label7);
			((Control)panel7).set_Location(new Point(12, 260));
			((Control)panel7).set_Name("panel7");
			((Control)panel7).set_Size(new Size(139, 68));
			((Control)panel7).set_TabIndex(6);
			((Control)comboBox2).set_Anchor((AnchorStyles)9);
			comboBox2.set_FlatStyle((FlatStyle)1);
			((ListControl)comboBox2).set_FormattingEnabled(true);
			comboBox2.get_Items().AddRange(new object[31]
			{
				"F1",
				"F2",
				"F3",
				"F4",
				"F5",
				"F6",
				"F7",
				"F8",
				"F9",
				"F10",
				"F11",
				"F12",
				"Y",
				"X",
				"C",
				"V",
				"B",
				"N",
				"M",
				"L",
				"K",
				"J",
				"H",
				"G",
				"F",
				"R",
				"Z",
				"U",
				"I",
				"O",
				"P"
			});
			((Control)comboBox2).set_Location(new Point(6, 29));
			((Control)comboBox2).set_Name("comboBox2");
			((Control)comboBox2).set_Size(new Size(44, 21));
			((Control)comboBox2).set_TabIndex(2);
			((Control)comboBox2).set_Text("F6");
			comboBox2.add_SelectedIndexChanged((EventHandler)comboBox2_SelectedIndexChanged);
			((Control)label7).set_AutoSize(true);
			((Control)label7).set_BackColor(Color.get_Transparent());
			((Control)label7).set_Font(new Font("MV Boli", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label7).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label7).set_Location(new Point(3, 0));
			((Control)label7).set_Name("label7");
			((Control)label7).set_Size(new Size(93, 17));
			((Control)label7).set_TabIndex(1);
			((Control)label7).set_Text("P Glide key:");
			((Control)label8).set_AutoSize(true);
			((Control)label8).set_BackColor(Color.get_Transparent());
			((Control)label8).set_Font(new Font("MV Boli", 48f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label8).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label8).set_Location(new Point(830, 9));
			((Control)label8).set_Name("label8");
			((Control)label8).set_Size(new Size(266, 85));
			((Control)label8).set_TabIndex(7);
			((Control)label8).set_Text("ClickGui");
			((Control)panel8).get_Controls().Add((Control)(object)comboBox3);
			((Control)panel8).get_Controls().Add((Control)(object)label9);
			((Control)panel8).set_Location(new Point(12, 334));
			((Control)panel8).set_Name("panel8");
			((Control)panel8).set_Size(new Size(139, 68));
			((Control)panel8).set_TabIndex(8);
			((Control)comboBox3).set_Anchor((AnchorStyles)9);
			comboBox3.set_FlatStyle((FlatStyle)1);
			((ListControl)comboBox3).set_FormattingEnabled(true);
			comboBox3.get_Items().AddRange(new object[31]
			{
				"F1",
				"F2",
				"F3",
				"F4",
				"F5",
				"F6",
				"F7",
				"F8",
				"F9",
				"F10",
				"F11",
				"F12",
				"Y",
				"X",
				"C",
				"V",
				"B",
				"N",
				"M",
				"L",
				"K",
				"J",
				"H",
				"G",
				"F",
				"R",
				"Z",
				"U",
				"I",
				"O",
				"P"
			});
			((Control)comboBox3).set_Location(new Point(6, 29));
			((Control)comboBox3).set_Name("comboBox3");
			((Control)comboBox3).set_Size(new Size(44, 21));
			((Control)comboBox3).set_TabIndex(2);
			((Control)comboBox3).set_Text("F6");
			((Control)label9).set_AutoSize(true);
			((Control)label9).set_BackColor(Color.get_Transparent());
			((Control)label9).set_Font(new Font("MV Boli", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label9).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label9).set_Location(new Point(3, 0));
			((Control)label9).set_Name("label9");
			((Control)label9).set_Size(new Size(102, 17));
			((Control)label9).set_TabIndex(1);
			((Control)label9).set_Text("AirJump key:");
			((Control)panel9).set_BackColor(Color.FromArgb(3, 2, 8));
			((Control)panel9).set_BackgroundImage((Image)((ResourceManager)(object)val).GetObject("panel9.BackgroundImage"));
			((Control)panel9).set_BackgroundImageLayout((ImageLayout)3);
			((Control)panel9).get_Controls().Add((Control)(object)button16);
			((Control)panel9).get_Controls().Add((Control)(object)checkBox1);
			((Control)panel9).get_Controls().Add((Control)(object)label10);
			((Control)panel9).set_Location(new Point(1099, 112));
			((Control)panel9).set_Name("panel9");
			((Control)panel9).set_Size(new Size(167, 337));
			((Control)panel9).set_TabIndex(9);
			((Control)panel9).add_MouseDown(new MouseEventHandler(panel9_MouseDown));
			((Control)panel9).add_MouseMove(new MouseEventHandler(panel9_MouseMove));
			((Control)button16).set_BackColor(Color.get_Transparent());
			((ButtonBase)button16).set_FlatStyle((FlatStyle)1);
			((Control)button16).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button16).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button16).set_Location(new Point(114, 84));
			((Control)button16).set_Name("button16");
			((Control)button16).set_Size(new Size(49, 24));
			((Control)button16).set_TabIndex(3);
			((Control)button16).set_Text("Color");
			((ButtonBase)button16).set_UseVisualStyleBackColor(false);
			((Control)checkBox1).set_AutoSize(true);
			((ButtonBase)checkBox1).set_FlatStyle((FlatStyle)1);
			((Control)checkBox1).set_Font(new Font("MV Boli", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)checkBox1).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)checkBox1).set_Location(new Point(8, 84));
			((Control)checkBox1).set_Name("checkBox1");
			((Control)checkBox1).set_Size(new Size(102, 24));
			((Control)checkBox1).set_TabIndex(1);
			((Control)checkBox1).set_Text("KeyStrokes");
			((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
			checkBox1.add_CheckedChanged((EventHandler)checkBox1_CheckedChanged);
			((Control)label10).set_AutoSize(true);
			((Control)label10).set_BackColor(Color.get_Transparent());
			((Control)label10).set_Font(new Font("MV Boli", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label10).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label10).set_Location(new Point(27, 29));
			((Control)label10).set_Name("label10");
			((Control)label10).set_Size(new Size(136, 39));
			((Control)label10).set_TabIndex(0);
			((Control)label10).set_Text("Settings");
			((Control)panel10).get_Controls().Add((Control)(object)label11);
			((Control)panel10).get_Controls().Add((Control)(object)trackBar3);
			((Control)panel10).set_Location(new Point(12, 408));
			((Control)panel10).set_Name("panel10");
			((Control)panel10).set_Size(new Size(139, 68));
			((Control)panel10).set_TabIndex(10);
			((Control)label11).set_AutoSize(true);
			((Control)label11).set_BackColor(Color.get_Transparent());
			((Control)label11).set_Font(new Font("MV Boli", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label11).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label11).set_Location(new Point(3, 0));
			((Control)label11).set_Name("label11");
			((Control)label11).set_Size(new Size(47, 17));
			((Control)label11).set_TabIndex(1);
			((Control)label11).set_Text("Speed");
			trackBar3.set_LargeChange(1);
			((Control)trackBar3).set_Location(new Point(3, 23));
			trackBar3.set_Maximum(8);
			((Control)trackBar3).set_Name("trackBar3");
			((Control)trackBar3).set_Size(new Size(105, 45));
			((Control)trackBar3).set_TabIndex(0);
			trackBar3.set_Value(3);
			trackBar3.add_Scroll((EventHandler)trackBar3_Scroll);
			((Control)panel11).get_Controls().Add((Control)(object)trackBar4);
			((Control)panel11).get_Controls().Add((Control)(object)comboBox4);
			((Control)panel11).get_Controls().Add((Control)(object)label12);
			((Control)panel11).set_Location(new Point(12, 482));
			((Control)panel11).set_Name("panel11");
			((Control)panel11).set_Size(new Size(139, 102));
			((Control)panel11).set_TabIndex(11);
			trackBar4.set_LargeChange(1);
			((Control)trackBar4).set_Location(new Point(6, 54));
			trackBar4.set_Maximum(8);
			((Control)trackBar4).set_Name("trackBar4");
			((Control)trackBar4).set_Size(new Size(105, 45));
			((Control)trackBar4).set_TabIndex(3);
			trackBar4.set_Value(3);
			trackBar4.add_Scroll((EventHandler)trackBar4_Scroll);
			((Control)comboBox4).set_Anchor((AnchorStyles)9);
			comboBox4.set_FlatStyle((FlatStyle)1);
			((ListControl)comboBox4).set_FormattingEnabled(true);
			comboBox4.get_Items().AddRange(new object[31]
			{
				"F1",
				"F2",
				"F3",
				"F4",
				"F5",
				"F6",
				"F7",
				"F8",
				"F9",
				"F10",
				"F11",
				"F12",
				"Y",
				"X",
				"C",
				"V",
				"B",
				"N",
				"M",
				"L",
				"K",
				"J",
				"H",
				"G",
				"F",
				"R",
				"Z",
				"U",
				"I",
				"O",
				"P"
			});
			((Control)comboBox4).set_Location(new Point(6, 29));
			((Control)comboBox4).set_Name("comboBox4");
			((Control)comboBox4).set_Size(new Size(44, 21));
			((Control)comboBox4).set_TabIndex(2);
			((Control)comboBox4).set_Text("F6");
			((Control)label12).set_AutoSize(true);
			((Control)label12).set_BackColor(Color.get_Transparent());
			((Control)label12).set_Font(new Font("MV Boli", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label12).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label12).set_Location(new Point(3, 0));
			((Control)label12).set_Name("label12");
			((Control)label12).set_Size(new Size(36, 17));
			((Control)label12).set_TabIndex(1);
			((Control)label12).set_Text("key:");
			((Control)panel12).get_Controls().Add((Control)(object)comboBox5);
			((Control)panel12).get_Controls().Add((Control)(object)label13);
			((Control)panel12).set_Location(new Point(157, 38));
			((Control)panel12).set_Name("panel12");
			((Control)panel12).set_Size(new Size(139, 68));
			((Control)panel12).set_TabIndex(12);
			((Control)comboBox5).set_Anchor((AnchorStyles)9);
			comboBox5.set_FlatStyle((FlatStyle)1);
			((ListControl)comboBox5).set_FormattingEnabled(true);
			comboBox5.get_Items().AddRange(new object[31]
			{
				"F1",
				"F2",
				"F3",
				"F4",
				"F5",
				"F6",
				"F7",
				"F8",
				"F9",
				"F10",
				"F11",
				"F12",
				"Y",
				"X",
				"C",
				"V",
				"B",
				"N",
				"M",
				"L",
				"K",
				"J",
				"H",
				"G",
				"F",
				"R",
				"Z",
				"U",
				"I",
				"O",
				"P"
			});
			((Control)comboBox5).set_Location(new Point(6, 29));
			((Control)comboBox5).set_Name("comboBox5");
			((Control)comboBox5).set_Size(new Size(44, 21));
			((Control)comboBox5).set_TabIndex(2);
			((Control)comboBox5).set_Text("F6");
			((Control)label13).set_AutoSize(true);
			((Control)label13).set_BackColor(Color.get_Transparent());
			((Control)label13).set_Font(new Font("MV Boli", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label13).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label13).set_Location(new Point(3, 0));
			((Control)label13).set_Name("label13");
			((Control)label13).set_Size(new Size(94, 17));
			((Control)label13).set_TabIndex(1);
			((Control)label13).set_Text("N Glide key:");
			RainbowSkyBGW.add_DoWork(new DoWorkEventHandler(RainbowSkyBGW_DoWork));
			((Control)panel13).get_Controls().Add((Control)(object)trackBar5);
			((Control)panel13).get_Controls().Add((Control)(object)comboBox6);
			((Control)panel13).get_Controls().Add((Control)(object)label14);
			((Control)panel13).set_Location(new Point(157, 112));
			((Control)panel13).set_Name("panel13");
			((Control)panel13).set_Size(new Size(139, 102));
			((Control)panel13).set_TabIndex(13);
			trackBar5.set_LargeChange(1);
			((Control)trackBar5).set_Location(new Point(6, 54));
			trackBar5.set_Maximum(5);
			((Control)trackBar5).set_Name("trackBar5");
			((Control)trackBar5).set_Size(new Size(105, 45));
			((Control)trackBar5).set_TabIndex(3);
			trackBar5.set_Value(3);
			trackBar5.add_Scroll((EventHandler)trackBar5_Scroll);
			((Control)comboBox6).set_Anchor((AnchorStyles)9);
			comboBox6.set_FlatStyle((FlatStyle)1);
			((ListControl)comboBox6).set_FormattingEnabled(true);
			comboBox6.get_Items().AddRange(new object[31]
			{
				"F1",
				"F2",
				"F3",
				"F4",
				"F5",
				"F6",
				"F7",
				"F8",
				"F9",
				"F10",
				"F11",
				"F12",
				"Y",
				"X",
				"C",
				"V",
				"B",
				"N",
				"M",
				"L",
				"K",
				"J",
				"H",
				"G",
				"F",
				"R",
				"Z",
				"U",
				"I",
				"O",
				"P"
			});
			((Control)comboBox6).set_Location(new Point(6, 29));
			((Control)comboBox6).set_Name("comboBox6");
			((Control)comboBox6).set_Size(new Size(44, 21));
			((Control)comboBox6).set_TabIndex(2);
			((Control)comboBox6).set_Text("F3");
			((Control)label14).set_AutoSize(true);
			((Control)label14).set_BackColor(Color.get_Transparent());
			((Control)label14).set_Font(new Font("MV Boli", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label14).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label14).set_Location(new Point(3, 0));
			((Control)label14).set_Name("label14");
			((Control)label14).set_Size(new Size(110, 17));
			((Control)label14).set_TabIndex(1);
			((Control)label14).set_Text("HighJump key:");
			((Control)panel14).set_BackColor(Color.FromArgb(3, 2, 8));
			((Control)panel14).set_BackgroundImage((Image)((ResourceManager)(object)val).GetObject("panel14.BackgroundImage"));
			((Control)panel14).set_BackgroundImageLayout((ImageLayout)3);
			((Control)panel14).get_Controls().Add((Control)(object)button23);
			((Control)panel14).get_Controls().Add((Control)(object)label15);
			((Control)panel14).set_Location(new Point(910, 117));
			((Control)panel14).set_Name("panel14");
			((Control)panel14).set_Size(new Size(167, 337));
			((Control)panel14).set_TabIndex(14);
			((Control)panel14).add_MouseDown(new MouseEventHandler(panel14_MouseDown));
			((Control)panel14).add_MouseMove(new MouseEventHandler(panel14_MouseMove));
			((Control)button23).set_BackColor(Color.get_Transparent());
			((ButtonBase)button23).set_FlatStyle((FlatStyle)1);
			((Control)button23).set_Font(new Font("MV Boli", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
			((Control)button23).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)button23).set_Location(new Point(3, 92));
			((Control)button23).set_Name("button23");
			((Control)button23).set_Size(new Size(161, 29));
			((Control)button23).set_TabIndex(1);
			((Control)button23).set_Text("FlyDamageBypass");
			((ButtonBase)button23).set_UseVisualStyleBackColor(false);
			((Control)button23).add_Click((EventHandler)button23_Click);
			((Control)label15).set_AutoSize(true);
			((Control)label15).set_BackColor(Color.get_Transparent());
			((Control)label15).set_Font(new Font("MV Boli", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label15).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label15).set_Location(new Point(27, 29));
			((Control)label15).set_Name("label15");
			((Control)label15).set_Size(new Size(128, 39));
			((Control)label15).set_TabIndex(0);
			((Control)label15).set_Text("Exploits");
			((Control)label16).set_AutoSize(true);
			((Control)label16).set_BackColor(Color.get_Transparent());
			((Control)label16).set_Font(new Font("MV Boli", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
			((Control)label16).set_ForeColor(Color.FromArgb(203, 228, 235));
			((Control)label16).set_Location(new Point(5, 674));
			((Control)label16).set_Name("label16");
			((Control)label16).set_Size(new Size(301, 39));
			((Control)label16).set_TabIndex(15);
			((Control)label16).set_Text("by Jan | SirPROXx");
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Form)this).set_ClientSize(new Size(1605, 722));
			((Control)this).get_Controls().Add((Control)(object)label16);
			((Control)this).get_Controls().Add((Control)(object)panel14);
			((Control)this).get_Controls().Add((Control)(object)panel13);
			((Control)this).get_Controls().Add((Control)(object)panel12);
			((Control)this).get_Controls().Add((Control)(object)panel11);
			((Control)this).get_Controls().Add((Control)(object)panel10);
			((Control)this).get_Controls().Add((Control)(object)panel9);
			((Control)this).get_Controls().Add((Control)(object)panel8);
			((Control)this).get_Controls().Add((Control)(object)label8);
			((Control)this).get_Controls().Add((Control)(object)panel7);
			((Control)this).get_Controls().Add((Control)(object)panel6);
			((Control)this).get_Controls().Add((Control)(object)panel5);
			((Control)this).get_Controls().Add((Control)(object)panel4);
			((Control)this).get_Controls().Add((Control)(object)panel3);
			((Control)this).get_Controls().Add((Control)(object)panel2);
			((Control)this).get_Controls().Add((Control)(object)panel1);
			((Control)this).set_Name("Clickgui");
			((Form)this).set_ShowIcon(false);
			((Form)this).set_ShowInTaskbar(false);
			((Control)this).set_Text("Clickgui");
			((Form)this).add_Load((EventHandler)Clickgui_Load);
			((Control)panel1).ResumeLayout(false);
			((Control)panel1).PerformLayout();
			((Control)panel2).ResumeLayout(false);
			((Control)panel2).PerformLayout();
			((ISupportInitialize)trackBar1).EndInit();
			((Control)panel3).ResumeLayout(false);
			((Control)panel3).PerformLayout();
			((Control)panel4).ResumeLayout(false);
			((Control)panel4).PerformLayout();
			((Control)panel5).ResumeLayout(false);
			((Control)panel5).PerformLayout();
			((ISupportInitialize)trackBar2).EndInit();
			((Control)panel6).ResumeLayout(false);
			((Control)panel6).PerformLayout();
			((Control)panel7).ResumeLayout(false);
			((Control)panel7).PerformLayout();
			((Control)panel8).ResumeLayout(false);
			((Control)panel8).PerformLayout();
			((Control)panel9).ResumeLayout(false);
			((Control)panel9).PerformLayout();
			((Control)panel10).ResumeLayout(false);
			((Control)panel10).PerformLayout();
			((ISupportInitialize)trackBar3).EndInit();
			((Control)panel11).ResumeLayout(false);
			((Control)panel11).PerformLayout();
			((ISupportInitialize)trackBar4).EndInit();
			((Control)panel12).ResumeLayout(false);
			((Control)panel12).PerformLayout();
			((Control)panel13).ResumeLayout(false);
			((Control)panel13).PerformLayout();
			((ISupportInitialize)trackBar5).EndInit();
			((Control)panel14).ResumeLayout(false);
			((Control)panel14).PerformLayout();
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}
	}
}
