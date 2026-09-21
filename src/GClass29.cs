using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

public class GClass29
{
	public static GClass24 gclass24_0;

	public GClass24[] gclass24_1;

	public static GClass0[] gclass0_0;

	public static Song song_0;

	public static Song song_1;

	public static Song song_2;

	public static Song song_3;

	public static Song song_4;

	public static Song song_5;

	public Texture2D texture2D_0;

	public Texture2D texture2D_1;

	public Texture2D texture2D_2;

	public Texture2D texture2D_3;

	private Texture2D texture2D_4;

	private Texture2D texture2D_5;

	private Texture2D texture2D_6;

	private Texture2D texture2D_7;

	private Texture2D texture2D_8;

	private Texture2D texture2D_9;

	private Texture2D texture2D_10;

	private Texture2D[] texture2D_11;

	private Texture[] texture_0;

	private Texture2D[] texture2D_12;

	public static Texture2D texture2D_13;

	public Texture2D texture2D_14;

	public Texture2D texture2D_15;

	public Texture2D texture2D_16;

	public Texture2D texture2D_17;

	public Texture2D texture2D_18;

	public Texture2D texture2D_19;

	public Texture2D[] texture2D_20;

	public Texture2D[] texture2D_21;

	public Texture2D[] texture2D_22;

	public Texture2D[] texture2D_23;

	public Texture2D[] texture2D_24;

	public Texture2D[] texture2D_25;

	public Vector2 vector2_0;

	private int int_0;

	private float float_0;

	private float float_1;

	private int int_1;

	private int int_2;

	private int int_3;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	public int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private int int_10;

	private int int_11;

	private int int_12;

	private int int_13;

	private int int_14;

	private int int_15;

	private int int_16;

	private bool bool_4;

	private Vector2 vector2_1;

	private Rectangle rectangle_0;

	private float float_2;

	private float float_3;

	public GClass22[] gclass22_0;

	private bool bool_5;

	private GClass0 gclass0_1;

	public static Color color_0;

	private int int_17;

	public static SpriteFont spriteFont_0;

	public static SpriteFont spriteFont_1;

	public static SpriteFont spriteFont_2;

	public GClass25 gclass25_0;

	public static float float_4;

	public bool bool_6;

	public int int_18;

	public int int_19;

	public int int_20;

	public static bool bool_7;

	public GClass29(GClass25 gclass25_1)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		int_2 = 2;
		int_3 = 10;
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		int_4 = 512;
		int_14 = 8;
		int_15 = 16;
		int_16 = 10;
		bool_4 = false;
		rectangle_0 = default(Rectangle);
		float_2 = 0.05f;
		float_3 = 0.01f;
		bool_5 = false;
		int_17 = 0;
		bool_6 = false;
		int_18 = 0;
		int_19 = 0;
		int_20 = 50;
		base._002Ector();
		if (GClass25.stopwatch_0.IsRunning)
		{
			GClass25.stopwatch_0.Stop();
		}
		GClass25.stopwatch_0.Restart();
		gclass25_0 = gclass25_1;
		texture2D_4 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/ramka");
		texture2D_14 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/zvezda");
		texture2D_13 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/nadpisi/100");
		texture2D_5 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/nadpisi/score");
		texture2D_6 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/nadpisi/time");
		texture2D_7 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/nadpisi/rings");
		texture2D_8 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/nadpisi/tochki");
		texture2D_10 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/hud/common");
		texture2D_11 = (Texture2D[])(object)new Texture2D[10];
		for (int i = 0; i < texture2D_11.Length; i++)
		{
			texture2D_11[i] = ((Game)gclass25_0).Content.Load<Texture2D>("misc/hud/" + i);
		}
		texture2D_12 = (Texture2D[])(object)new Texture2D[10];
		for (int i = 0; i < texture2D_12.Length; i++)
		{
			texture2D_12[i] = ((Game)gclass25_0).Content.Load<Texture2D>("misc/nadpisi/" + i);
		}
		texture2D_20 = (Texture2D[])(object)new Texture2D[11];
		texture2D_21 = (Texture2D[])(object)new Texture2D[18];
		texture2D_22 = (Texture2D[])(object)new Texture2D[12];
		texture2D_23 = (Texture2D[])(object)new Texture2D[2];
		texture2D_24 = (Texture2D[])(object)new Texture2D[4];
		texture2D_25 = (Texture2D[])(object)new Texture2D[6];
		for (int i = 0; i < texture2D_25.Length; i++)
		{
			texture2D_25[i] = ((Game)gclass25_0).Content.Load<Texture2D>("misc/shields/wKaiten" + i);
		}
		for (int i = 0; i < texture2D_20.Length; i++)
		{
			texture2D_20[i] = ((Game)gclass25_0).Content.Load<Texture2D>("misc/shields/bubbleShield" + i);
		}
		for (int i = 0; i < texture2D_23.Length; i++)
		{
			texture2D_23[i] = ((Game)gclass25_0).Content.Load<Texture2D>("misc/shields/bubbleAttack" + i);
		}
		for (int i = 0; i < texture2D_21.Length; i++)
		{
			texture2D_21[i] = ((Game)gclass25_0).Content.Load<Texture2D>("misc/shields/fireShield" + i);
		}
		for (int i = 0; i < texture2D_24.Length; i++)
		{
			texture2D_24[i] = ((Game)gclass25_0).Content.Load<Texture2D>("misc/shields/fireAttack" + i);
		}
		for (int i = 0; i < texture2D_22.Length; i++)
		{
			texture2D_22[i] = ((Game)gclass25_0).Content.Load<Texture2D>("misc/shields/lightningShield" + i);
		}
		if (!GClass25.bool_1)
		{
		}
		texture2D_3 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/rozovo");
		GClass30.smethod_0();
		texture2D_15 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/titles/sonic3Ribbon");
		texture2D_16 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/titles/act1");
		texture2D_19 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/titles/zone");
		texture2D_18 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/titles/mushroomHill");
		method_0();
		gclass0_0 = new GClass0[100];
		gclass0_0[0] = new GClass1();
		gclass0_0[1] = new GClass3();
		gclass0_0[2] = new GClass4();
		gclass0_0[3] = new GClass13();
		gclass0_0[4] = new GClass11();
		gclass0_0[5] = new GClass12();
		gclass0_0[6] = new GClass5();
		gclass0_0[7] = new GClass15();
		gclass0_0[8] = new GClass14();
		gclass0_0[9] = new GClass16();
		gclass0_0[10] = new GClass17();
		gclass0_0[11] = new GClass18();
		gclass0_0[12] = new GClass19();
		gclass0_0[13] = new GClass20();
		gclass0_0[14] = new GClass21();
		gclass0_0[15] = new GClass9();
		gclass0_0[16] = new GClass10();
		gclass0_0[17] = new GClass2();
		gclass0_0[18] = new GClass6();
		gclass0_0[19] = new GClass7();
		gclass0_0[20] = new GClass8();
		for (int i = 0; i < gclass0_0.Length; i++)
		{
			if (gclass0_0[i] != null)
			{
				gclass0_0[i].vmethod_2();
			}
		}
		gclass24_1 = new GClass24[12];
		gclass24_1[7] = new GClass24("MHZ1", 187);
		gclass24_1[11] = new GClass24("ES", 6);
		gclass24_0 = gclass24_1[7];
		spriteFont_0 = ((Game)gclass25_0).Content.Load<SpriteFont>("misc/WinterFont1");
		spriteFont_1 = ((Game)gclass25_0).Content.Load<SpriteFont>("misc/creditsFont0");
		spriteFont_2 = ((Game)gclass25_0).Content.Load<SpriteFont>("misc/creditsFont1");
		if (GClass25.stopwatch_0.IsRunning)
		{
			GClass25.stopwatch_0.Stop();
			GameWindow window = ((Game)gclass25_0).Window;
			object title = window.Title;
			window.Title = string.Concat(new object[6]
			{
				title,
				"  Loading time: ",
				GClass25.stopwatch_0.Elapsed.Seconds,
				".",
				GClass25.stopwatch_0.Elapsed.Milliseconds,
				" seconds   pre tech demo build 99"
			});
			GClass25.string_0 = ((Game)gclass25_0).Window.Title;
		}
	}

	public void method_0()
	{
		vector2_0.X = int_4 * (int_2 - 1) + int_4 / 2;
		gclass22_0 = new GClass22[3];
		gclass22_0[0] = new GClass22("characters/Sonic");
		vector2_0.X = gclass22_0[0].vector2_0.X - (float)(((Texture2D)gclass25_0.renderTarget2D_0).Width / 2);
		vector2_0.Y = gclass22_0[0].vector2_0.Y + 64f - 80f - (float)(((Texture2D)gclass25_0.renderTarget2D_0).Height / 2);
	}

	private void method_1()
	{
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0615: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_13dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_100a: Unknown result type (might be due to invalid IL or missing references)
		//IL_100f: Unknown result type (might be due to invalid IL or missing references)
		//IL_101d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1022: Unknown result type (might be due to invalid IL or missing references)
		//IL_105e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1443: Unknown result type (might be due to invalid IL or missing references)
		//IL_1459: Unknown result type (might be due to invalid IL or missing references)
		//IL_1411: Unknown result type (might be due to invalid IL or missing references)
		//IL_142b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_1093: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_1479: Unknown result type (might be due to invalid IL or missing references)
		//IL_149d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_168f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1694: Unknown result type (might be due to invalid IL or missing references)
		//IL_1696: Unknown result type (might be due to invalid IL or missing references)
		//IL_169b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1370: Unknown result type (might be due to invalid IL or missing references)
		//IL_1375: Unknown result type (might be due to invalid IL or missing references)
		//IL_1383: Unknown result type (might be due to invalid IL or missing references)
		//IL_1388: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f90: Unknown result type (might be due to invalid IL or missing references)
		if (gclass25_0.int_20 == 1)
		{
			gclass24_0.method_6();
		}
		if (gclass25_0.int_21 == 1)
		{
			gclass24_0.method_5();
		}
		if (gclass25_0.int_13 == 1)
		{
			int_2--;
		}
		if (gclass25_0.int_14 == 1)
		{
			int_2++;
		}
		if (gclass25_0.int_15 == 1)
		{
			int_3--;
		}
		if (gclass25_0.int_16 == 1)
		{
			int_3++;
		}
		if (int_2 < 0)
		{
			int_2 = 0;
		}
		if (int_2 > gclass24_0.int_5 - 1)
		{
			int_2 = gclass24_0.int_5 - 1;
		}
		if (int_3 < 0)
		{
			int_3 = 0;
		}
		if (int_3 > 127)
		{
			int_3 = 127;
		}
		if (gclass25_0.int_3 == 1)
		{
			gclass24_0.int_2[int_3, int_2]++;
		}
		if (gclass25_0.int_2 == 1)
		{
			gclass24_0.int_2[int_3, int_2]--;
		}
		if (gclass24_0.int_2[int_3, int_2] < 0)
		{
			gclass24_0.int_2[int_3, int_2] = gclass24_0.int_1 - 1;
		}
		if (gclass24_0.int_2[int_3, int_2] % 1000 >= gclass24_0.int_1)
		{
			gclass24_0.int_2[int_3, int_2] = 0;
		}
		if (gclass25_0.int_5 == 1)
		{
			bool_1 = !bool_1;
		}
		if (gclass25_0.int_6 == 1)
		{
			bool_2 = !bool_2;
		}
		if (gclass25_0.int_4 == 1)
		{
			bool_3 = !bool_3;
		}
		bool_4 = false;
		if (bool_3)
		{
			if (gclass25_0.int_13 == 1)
			{
				int_1--;
				if (int_1 < 0)
				{
					int_1 = 0;
				}
			}
			if (gclass25_0.int_14 == 1)
			{
				int_1++;
				if (int_1 > 20)
				{
					int_1 = 20;
				}
			}
		}
		if (bool_1)
		{
			if (gclass25_0.int_7 == 1)
			{
				gclass24_0.int_2[int_3, int_2] = gclass24_0.int_2[int_3, int_2] + 1000;
				if (gclass24_0.int_2[int_3, int_2] / 1000 > gclass24_0.texture2D_2.Length)
				{
					gclass24_0.int_2[int_3, int_2] = gclass24_0.int_2[int_3, int_2] % 1000;
				}
				_ = gclass24_0.int_2[int_3, int_2];
			}
			if (gclass25_0.int_8 == 1)
			{
				gclass24_0.int_2[int_3, int_2] = gclass24_0.int_2[int_3, int_2] - 1000;
				if (gclass24_0.int_2[int_3, int_2] < 0)
				{
					gclass24_0.int_2[int_3, int_2] = gclass24_0.int_2[int_3, int_2] + (1 + gclass24_0.texture2D_2.Length) * 1000;
				}
				_ = gclass24_0.int_2[int_3, int_2];
			}
			if (gclass24_0.bool_0[gclass24_0.int_2[int_3, int_2] % 1000])
			{
				if (gclass25_0.int_10 != 1)
				{
				}
				if (gclass25_0.int_11 == 1)
				{
					bool flag = false;
					for (int i = gclass24_0.int_3[int_3, int_2] + 1; i < gclass24_0.bool_0.Length; i++)
					{
						if (gclass24_0.bool_0[i])
						{
							flag = true;
							gclass24_0.int_3[int_3, int_2] = i;
							break;
						}
					}
					if (!flag)
					{
						gclass24_0.int_3[int_3, int_2] = 0;
					}
				}
			}
			else
			{
				gclass24_0.int_3[int_3, int_2] = 0;
			}
		}
		MouseState state;
		float num;
		int num2;
		int num3;
		if (int_5 >= 1)
		{
			state = Mouse.GetState();
			int_8 = ((MouseState)(ref state)).X;
			state = Mouse.GetState();
			int_9 = ((MouseState)(ref state)).Y;
			num = (float)((Texture2D)gclass25_0.renderTarget2D_0).Width / (float)((Texture2D)gclass25_0.renderTarget2D_0).Height;
			if ((float)((Game)gclass25_0).Window.ClientBounds.Width > num * (float)((Game)gclass25_0).Window.ClientBounds.Height)
			{
				num2 = (int)((float)((Game)gclass25_0).Window.ClientBounds.Height * num);
				num3 = ((Game)gclass25_0).Window.ClientBounds.Height;
			}
			else
			{
				num2 = ((Game)gclass25_0).Window.ClientBounds.Width;
				num3 = (int)((float)((Game)gclass25_0).Window.ClientBounds.Width / num);
			}
			rectangle_0.X = (((Game)gclass25_0).Window.ClientBounds.Width - num2) / 2;
			rectangle_0.Y = (((Game)gclass25_0).Window.ClientBounds.Height - num3) / 2;
			rectangle_0.Width = num2;
			rectangle_0.Height = num3;
			int_8 = (int)((float)(int_8 - rectangle_0.X) * ((float)((Texture2D)gclass25_0.renderTarget2D_0).Width / (float)rectangle_0.Width));
			int_9 = (int)((float)(int_9 - rectangle_0.Y) * ((float)((Texture2D)gclass25_0.renderTarget2D_0).Height / (float)rectangle_0.Height));
			if (bool_1)
			{
				for (int i = 0; i < gclass24_0.int_1; i++)
				{
					if (int_8 >= i % int_16 * int_4 / int_14 && int_8 < i % int_16 * int_4 / int_14 + int_4 / int_14 && int_9 >= i / int_16 * int_4 / int_14 && int_9 < i / int_16 * int_4 / int_14 + int_4 / int_14)
					{
						gclass24_0.int_2[int_3, int_2] = i;
						bool_4 = true;
						break;
					}
				}
			}
			if (bool_3 && !bool_4)
			{
				for (int i = int_1; i < gclass0_0.Length; i++)
				{
					if (gclass0_0[i] != null && 640 + (i - int_1) * 2 * int_4 / int_14 <= int_8 && int_8 <= 640 + (i - int_1) * 2 * int_4 / int_14 + 2 * int_4 / int_14 && 800 <= int_9 && int_9 <= 800 + 2 * int_4 / int_14)
					{
						bool_4 = true;
						bool_5 = true;
						gclass0_1 = (GClass0)Activator.CreateInstance(gclass0_0[i].GetType());
					}
				}
			}
			if (bool_2 && !bool_4)
			{
				for (int j = 0; j < 128; j++)
				{
					for (int i = 0; i < gclass24_0.int_5; i++)
					{
						if (int_8 > i * int_4 / int_15 + int_16 * int_4 / int_14 && int_8 < i * int_4 / int_15 + int_16 * int_4 / int_14 + int_4 / int_15 && int_9 > j * int_4 / int_15 && int_9 < j * int_4 / int_15 + int_4 / int_15)
						{
							int_2 = i + int_0;
							int_3 = j;
							j = 200;
							break;
						}
					}
				}
			}
			state = Mouse.GetState();
			int_8 = ((MouseState)(ref state)).X;
			state = Mouse.GetState();
			int_9 = ((MouseState)(ref state)).Y;
		}
		if (bool_3 && bool_5)
		{
			state = Mouse.GetState();
			int_8 = ((MouseState)(ref state)).X;
			state = Mouse.GetState();
			int_9 = ((MouseState)(ref state)).Y;
			num = (float)((Texture2D)gclass25_0.renderTarget2D_0).Width / (float)((Texture2D)gclass25_0.renderTarget2D_0).Height;
			if ((float)((Game)gclass25_0).Window.ClientBounds.Width > num * (float)((Game)gclass25_0).Window.ClientBounds.Height)
			{
				num2 = (int)((float)((Game)gclass25_0).Window.ClientBounds.Height * num);
				num3 = ((Game)gclass25_0).Window.ClientBounds.Height;
			}
			else
			{
				num2 = ((Game)gclass25_0).Window.ClientBounds.Width;
				num3 = (int)((float)((Game)gclass25_0).Window.ClientBounds.Width / num);
			}
			rectangle_0.X = (((Game)gclass25_0).Window.ClientBounds.Width - num2) / 2;
			rectangle_0.Y = (((Game)gclass25_0).Window.ClientBounds.Height - num3) / 2;
			rectangle_0.Width = num2;
			rectangle_0.Height = num3;
			int_8 = (int)((float)(int_8 - rectangle_0.X) * ((float)((Texture2D)gclass25_0.renderTarget2D_0).Width / (float)rectangle_0.Width));
			int_9 = (int)((float)(int_9 - rectangle_0.Y) * ((float)((Texture2D)gclass25_0.renderTarget2D_0).Height / (float)rectangle_0.Height));
			gclass0_1.vector2_0 = new Vector2((float)(int_8 - (int)((float)int_8 + vector2_0.X) % 4), (float)(int_9 - (int)((float)int_9 + vector2_0.Y) % 4));
			if (gclass25_0.int_7 == 1)
			{
				gclass0_1.int_1++;
				((Game)gclass25_0).Window.Title = "blaa";
			}
			if (gclass25_0.int_8 == 1)
			{
				gclass0_1.int_1--;
				((Game)gclass25_0).Window.Title = "blaa2";
			}
			if (gclass0_1.int_1 < 0)
			{
				gclass0_1.int_1 = gclass0_1.int_0 - 1;
			}
			if (gclass0_1.int_1 > gclass0_1.int_0 - 1)
			{
				gclass0_1.int_1 = 0;
			}
			if (int_5 == 1 && !bool_4)
			{
				for (int i = 0; i < gclass24_0.gclass0_0.Length; i++)
				{
					if (gclass24_0.gclass0_0[i] == null)
					{
						gclass24_0.gclass0_0[i] = gclass0_1;
						GClass0 obj = gclass24_0.gclass0_0[i];
						obj.vector2_0 += vector2_0;
						gclass0_1 = (GClass0)Activator.CreateInstance(gclass0_1.GetType());
						gclass0_1.vector2_0.X = int_8 - (int)((float)int_8 + vector2_0.X) % 4;
						gclass0_1.vector2_0.Y = int_9 - (int)((float)int_9 + vector2_0.Y) % 4;
						break;
					}
				}
			}
			if (int_6 == 1 && !bool_4)
			{
				int num4 = -1;
				float num5 = 150f;
				Vector2 val = new Vector2((float)(int_8 - (int)((float)int_8 + vector2_0.X) % 4), (float)(int_9 - (int)((float)int_9 + vector2_0.Y) % 4)) + vector2_0;
				for (int i = 0; i < gclass24_0.gclass0_0.Length; i++)
				{
					if (gclass24_0.gclass0_0[i] != null && Vector2.Distance(gclass24_0.gclass0_0[i].vector2_0, val) < num5)
					{
						num5 = Vector2.Distance(gclass24_0.gclass0_0[i].vector2_0, val);
						num4 = i;
					}
				}
				if (num4 != -1)
				{
					gclass24_0.gclass0_0[num4] = null;
				}
			}
			state = Mouse.GetState();
			int_8 = ((MouseState)(ref state)).X;
			state = Mouse.GetState();
			int_9 = ((MouseState)(ref state)).Y;
		}
		if (!bool_2 && int_5 >= 1)
		{
			state = Mouse.GetState();
			int_8 = ((MouseState)(ref state)).X;
			state = Mouse.GetState();
			int_9 = ((MouseState)(ref state)).Y;
			num = (float)((Texture2D)gclass25_0.renderTarget2D_0).Width / (float)((Texture2D)gclass25_0.renderTarget2D_0).Height;
			if ((float)((Game)gclass25_0).Window.ClientBounds.Width > num * (float)((Game)gclass25_0).Window.ClientBounds.Height)
			{
				num2 = (int)((float)((Game)gclass25_0).Window.ClientBounds.Height * num);
				num3 = ((Game)gclass25_0).Window.ClientBounds.Height;
			}
			else
			{
				num2 = ((Game)gclass25_0).Window.ClientBounds.Width;
				num3 = (int)((float)((Game)gclass25_0).Window.ClientBounds.Width / num);
			}
			rectangle_0.X = (((Game)gclass25_0).Window.ClientBounds.Width - num2) / 2;
			rectangle_0.Y = (((Game)gclass25_0).Window.ClientBounds.Height - num3) / 2;
			rectangle_0.Width = num2;
			rectangle_0.Height = num3;
			int_8 = (int)((float)(int_8 - rectangle_0.X) * ((float)((Texture2D)gclass25_0.renderTarget2D_0).Width / (float)rectangle_0.Width));
			int_9 = (int)((float)(int_9 - rectangle_0.Y) * ((float)((Texture2D)gclass25_0.renderTarget2D_0).Height / (float)rectangle_0.Height));
			rectangle_0.X = (int)(vector2_0.X / (float)int_4);
			if (rectangle_0.X < 0)
			{
				rectangle_0.X = 0;
			}
			rectangle_0.Y = (int)(vector2_0.Y / (float)int_4);
			if (rectangle_0.Y < 0)
			{
				rectangle_0.Y = 0;
			}
			rectangle_0.Width = 5;
			rectangle_0.Height = 3;
			if (!bool_4)
			{
				Vector2 val2 = default(Vector2);
				for (int j = rectangle_0.Y; j < rectangle_0.Height + rectangle_0.Y; j++)
				{
					for (int i = rectangle_0.X; i < rectangle_0.Width + rectangle_0.X; i++)
					{
						val2.X = (float)(i * int_4) - vector2_0.X;
						val2.Y = (float)(j * int_4) - vector2_0.Y;
						if ((float)int_8 > val2.X && (float)int_8 < val2.X + (float)int_4 && (float)int_9 > val2.Y && (float)int_9 < val2.Y + (float)int_4)
						{
							int_2 = i;
							int_3 = j;
							break;
						}
					}
				}
			}
			state = Mouse.GetState();
			int_8 = ((MouseState)(ref state)).X;
			state = Mouse.GetState();
			int_9 = ((MouseState)(ref state)).Y;
		}
		if (int_7 <= 2)
		{
			return;
		}
		Vector2 zero = Vector2.Zero;
		num = (float)((Texture2D)gclass25_0.renderTarget2D_0).Width / (float)((Texture2D)gclass25_0.renderTarget2D_0).Height;
		if ((float)((Game)gclass25_0).Window.ClientBounds.Width > num * (float)((Game)gclass25_0).Window.ClientBounds.Height)
		{
			num2 = (int)((float)((Game)gclass25_0).Window.ClientBounds.Height * num);
			num3 = ((Game)gclass25_0).Window.ClientBounds.Height;
		}
		else
		{
			num2 = ((Game)gclass25_0).Window.ClientBounds.Width;
			num3 = (int)((float)((Game)gclass25_0).Window.ClientBounds.Width / num);
		}
		rectangle_0.X = (((Game)gclass25_0).Window.ClientBounds.Width - num2) / 2;
		rectangle_0.Y = (((Game)gclass25_0).Window.ClientBounds.Height - num3) / 2;
		rectangle_0.Width = num2;
		rectangle_0.Height = num3;
		zero.X = (float)(int_8 - rectangle_0.X) * ((float)((Texture2D)gclass25_0.renderTarget2D_0).Width / (float)rectangle_0.Width) - (float)(int_10 - rectangle_0.X) * ((float)((Texture2D)gclass25_0.renderTarget2D_0).Width / (float)rectangle_0.Width);
		zero.Y = (float)(int_9 - rectangle_0.Y) * ((float)((Texture2D)gclass25_0.renderTarget2D_0).Height / (float)rectangle_0.Height) - (float)(int_11 - rectangle_0.Y) * ((float)((Texture2D)gclass25_0.renderTarget2D_0).Height / (float)rectangle_0.Height);
		if (bool_2)
		{
			float_0 -= zero.X;
			float_1 += zero.Y;
			if (float_0 > (float)(int_4 / int_15))
			{
				float_0 -= int_4 / int_15;
				int_0++;
			}
			if (float_0 < (float)(-int_4 / int_15))
			{
				float_0 += int_4 / int_15;
				int_0--;
			}
			if (int_0 < 0)
			{
				int_0 = 0;
			}
			if (int_0 > 120)
			{
				int_0 = 120;
			}
		}
		else
		{
			vector2_0 -= zero;
			if (vector2_0.X < 0f)
			{
				vector2_0.X = 0f;
			}
			if (vector2_0.Y < 0f)
			{
				vector2_0.Y = 0f;
			}
		}
	}

	public void method_2()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		method_4();
		MouseState state = Mouse.GetState();
		if ((int)((MouseState)(ref state)).LeftButton == 1)
		{
			int_5++;
		}
		else
		{
			int_5 = 0;
		}
		if ((int)((MouseState)(ref state)).RightButton == 1)
		{
			int_6++;
		}
		else
		{
			int_6 = 0;
		}
		if ((int)((MouseState)(ref state)).MiddleButton == 1)
		{
			int_7++;
		}
		else
		{
			int_7 = 0;
		}
		int_10 = int_8;
		int_11 = int_9;
		MouseState state2 = Mouse.GetState();
		int_8 = ((MouseState)(ref state2)).X;
		state2 = Mouse.GetState();
		int_9 = ((MouseState)(ref state2)).Y;
		if (gclass25_0.int_0 == 1)
		{
			bool_0 = !bool_0;
			if (GClass25.bool_1)
			{
				((Game)GClass25.gclass25_0).IsMouseVisible = bool_0;
			}
		}
		int_13 = int_12;
		state2 = Mouse.GetState();
		int_12 = ((MouseState)(ref state2)).ScrollWheelValue;
		if (gclass25_0.int_12 == 1)
		{
			bool_5 = false;
			gclass0_1 = null;
		}
		bool_4 = false;
		if (bool_0)
		{
			if (GClass25.bool_1)
			{
				method_1();
			}
			return;
		}
		for (int i = 0; i < gclass22_0.Length; i++)
		{
			if (gclass22_0[i] != null)
			{
				gclass22_0[i].Update();
				for (int j = 0; j < gclass24_0.gclass0_0.Length; j++)
				{
					gclass24_0.gclass0_0[j]?.vmethod_0(gclass22_0[i]);
				}
			}
		}
		for (int i = 0; i < gclass24_0.gclass0_0.Length; i++)
		{
			gclass24_0.gclass0_0[i]?.Update();
		}
		float num = vector2_0.X + (float)(((Texture2D)gclass25_0.renderTarget2D_0).Width / 2);
		if (gclass22_0[0].vector2_0.X > num)
		{
			if (gclass22_0[0].vector2_0.X > num + 64f)
			{
				ref Vector2 reference = ref vector2_0;
				reference.X += 64f;
			}
			else
			{
				ref Vector2 reference2 = ref vector2_0;
				reference2.X += gclass22_0[0].vector2_0.X - num;
			}
		}
		else if (gclass22_0[0].vector2_0.X < num - 64f)
		{
			if (gclass22_0[0].vector2_0.X < num - 128f)
			{
				ref Vector2 reference3 = ref vector2_0;
				reference3.X -= 64f;
			}
			else
			{
				vector2_0.X = gclass22_0[0].vector2_0.X - (float)(((Texture2D)gclass25_0.renderTarget2D_0).Width / 2) + 64f;
			}
		}
		float num2 = vector2_0.Y + (float)(((Texture2D)gclass25_0.renderTarget2D_0).Height / 2);
		int num3 = 0;
		int num4 = (int)gclass22_0[0].vector2_0.Y - 80;
		if (gclass22_0[0].int_22 > 120)
		{
			if (gclass22_0[0].genum4_0 == (GEnum4)4)
			{
				if (gclass22_0[0].int_22 > 164 + num3)
				{
					vector2_0.Y = num4 + 64 + (44 + num3) * 2 * 4 - ((Texture2D)gclass25_0.renderTarget2D_0).Height / 2;
				}
				else
				{
					vector2_0.Y = num4 + 64 + (gclass22_0[0].int_22 - 120) * 2 * 4 - ((Texture2D)gclass25_0.renderTarget2D_0).Height / 2;
				}
			}
			if (gclass22_0[0].genum4_0 == (GEnum4)7)
			{
				if (gclass22_0[0].int_22 > 120 + (52 + 2 * num3))
				{
					vector2_0.Y = num4 + 64 - (52 + 2 * num3) * 2 * 4 - ((Texture2D)gclass25_0.renderTarget2D_0).Height / 2;
				}
				else
				{
					vector2_0.Y = num4 + 64 - (gclass22_0[0].int_22 - 120) * 2 * 4 - ((Texture2D)gclass25_0.renderTarget2D_0).Height / 2;
				}
			}
		}
		else if (gclass22_0[0].bool_10)
		{
			if (Math.Abs(gclass22_0[0].vector2_1.Y) > 48f)
			{
				if (num2 - 64f < (float)num4)
				{
					if (num2 - 64f + 64f < (float)num4)
					{
						ref Vector2 reference4 = ref vector2_0;
						reference4.Y += 64f;
					}
					else
					{
						vector2_0.Y = num4 + 64 - ((Texture2D)gclass25_0.renderTarget2D_0).Height / 2;
					}
				}
				if (num2 - 64f > (float)num4)
				{
					if (num2 - 64f - 64f > (float)num4)
					{
						ref Vector2 reference5 = ref vector2_0;
						reference5.Y -= 64f;
					}
					else
					{
						vector2_0.Y = num4 + 64 - ((Texture2D)gclass25_0.renderTarget2D_0).Height / 2;
					}
				}
			}
			else
			{
				if (num2 - 64f < (float)num4)
				{
					if (num2 - 64f + 24f < (float)num4)
					{
						ref Vector2 reference6 = ref vector2_0;
						reference6.Y += 24f;
					}
					else
					{
						vector2_0.Y = num4 + 64 - ((Texture2D)gclass25_0.renderTarget2D_0).Height / 2;
					}
				}
				if (num2 - 64f > (float)num4)
				{
					if (num2 - 64f - 24f > (float)num4)
					{
						ref Vector2 reference7 = ref vector2_0;
						reference7.Y -= 24f;
					}
					else
					{
						vector2_0.Y = num4 + 64 - ((Texture2D)gclass25_0.renderTarget2D_0).Height / 2;
					}
				}
			}
		}
		else if (!(num2 - 192f <= (float)num4) || !((float)num4 <= num2 + 64f))
		{
			if (num2 - 192f > (float)num4)
			{
				if (num2 - 192f - 64f > (float)num4)
				{
					ref Vector2 reference8 = ref vector2_0;
					reference8.Y -= 64f;
				}
				else
				{
					vector2_0.Y = num4 + 192 - ((Texture2D)gclass25_0.renderTarget2D_0).Height / 2;
				}
			}
			else if (num2 + 64f + 64f < (float)num4)
			{
				ref Vector2 reference9 = ref vector2_0;
				reference9.Y += 64f;
			}
			else
			{
				vector2_0.Y = num4 - 64 - ((Texture2D)gclass25_0.renderTarget2D_0).Height / 2;
			}
		}
		if (!bool_0)
		{
			switch (gclass24_0.string_0)
			{
			case "ES":
				if (vector2_0.X < 0f)
				{
					vector2_0.X = 0f;
				}
				if (vector2_0.X > (float)(2 * int_4 + 128 - 24))
				{
					vector2_0.X = 2 * int_4 + 128 - 24;
				}
				vector2_0.Y = 10344f;
				break;
			case "MHZ1":
				if (vector2_0.X < 6404f)
				{
					vector2_0.X = 6404f;
				}
				if (vector2_0.X > (float)(132 * int_4 + 180))
				{
					vector2_0.X = 132 * int_4 + 180;
				}
				break;
			}
		}
		vector2_0.X = (int)vector2_0.X;
		vector2_0.Y = (int)vector2_0.Y;
		if (gclass22_0[0].vector2_0.Y > (float)(22 * int_4))
		{
			gclass24_0.method_0();
			gclass22_0[0].method_28();
		}
		if (gclass24_0.string_0 != "ES")
		{
			float_4 += 1f / 60f;
		}
		int_17++;
		if (int_17 > 15)
		{
			int_17 = 0;
		}
	}

	public void method_3()
	{
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1509: Unknown result type (might be due to invalid IL or missing references)
		//IL_150f: Invalid comparison between Unknown and I4
		//IL_0cbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1028: Unknown result type (might be due to invalid IL or missing references)
		//IL_102d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_104b: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Unknown result type (might be due to invalid IL or missing references)
		//IL_100b: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_1470: Unknown result type (might be due to invalid IL or missing references)
		//IL_1475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_065f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		switch (gclass24_0.string_0)
		{
		case "ES":
			vector2_1.X = -2.1f * vector2_0.X * float_2;
			vector2_1.Y = (0f - vector2_0.Y) * float_3 * 8f + 800f;
			break;
		case "MHZ1":
			vector2_1.X = (0f - vector2_0.X) * float_2;
			vector2_1.Y = (0f - vector2_0.Y) * float_3 * 8f - 100f;
			break;
		}
		gclass25_0.spriteBatch_0.Begin();
		if ((bool_0 && !bool_2) || !bool_0)
		{
			gclass25_0.spriteBatch_0.Draw(gclass24_0.texture2D_1, vector2_1, color_0);
			ref Vector2 reference = ref vector2_1;
			reference.X += (float)gclass24_0.texture2D_1.Width;
			gclass25_0.spriteBatch_0.Draw(gclass24_0.texture2D_1, vector2_1, color_0);
			ref Vector2 reference2 = ref vector2_1;
			reference2.X += (float)gclass24_0.texture2D_1.Width;
			gclass25_0.spriteBatch_0.Draw(gclass24_0.texture2D_1, vector2_1, color_0);
			ref Vector2 reference3 = ref vector2_1;
			reference3.X += (float)gclass24_0.texture2D_1.Width;
			gclass25_0.spriteBatch_0.Draw(gclass24_0.texture2D_1, vector2_1, color_0);
			vector2_1.X = 0f - vector2_0.X;
			vector2_1.Y = 0f - vector2_0.Y;
		}
		rectangle_0.X = (int)(vector2_0.X / (float)int_4);
		if (rectangle_0.X < 0)
		{
			rectangle_0.X = 0;
		}
		rectangle_0.Y = (int)(vector2_0.Y / (float)int_4);
		if (rectangle_0.Y < 0)
		{
			rectangle_0.Y = 0;
		}
		rectangle_0.Width = 5;
		rectangle_0.Height = 4;
		Vector2 zero = Vector2.Zero;
		if ((bool_0 && !bool_2) || !bool_0)
		{
			for (int i = rectangle_0.Y; i < rectangle_0.Height + rectangle_0.Y; i++)
			{
				for (int j = rectangle_0.X; j < rectangle_0.Width + rectangle_0.X; j++)
				{
					if (gclass24_0.int_2[i, j] / 1000 != 0)
					{
						zero.X = (float)(j * int_4) - vector2_0.X;
						zero.Y = (float)(i * int_4) - vector2_0.Y;
						gclass25_0.spriteBatch_0.Draw(gclass24_0.texture2D_2[gclass24_0.int_2[i, j] / 1000 - 1], zero, color_0);
					}
				}
			}
			for (int i = rectangle_0.Y; i < rectangle_0.Height + rectangle_0.Y; i++)
			{
				for (int j = rectangle_0.X; j < rectangle_0.Width + rectangle_0.X; j++)
				{
					if (gclass24_0.int_3[i, j] != 0)
					{
						zero.X = (float)(j * int_4) - vector2_0.X;
						zero.Y = (float)(i * int_4) - vector2_0.Y;
						int num = gclass24_0.int_3[i, j];
						gclass25_0.spriteBatch_0.Draw(gclass24_0.texture2D_0[num], zero, color_0);
					}
				}
			}
			for (int j = 0; j < gclass24_0.gclass0_0.Length; j++)
			{
				GClass0 gClass = gclass24_0.gclass0_0[j];
				if (gClass != null && (gClass.bool_1 || !gClass.bool_2))
				{
					gClass.vmethod_3(gclass24_0.gclass0_0[j].vector2_0 - vector2_0, 1f);
				}
			}
			for (int j = 0; j < gclass22_0.Length; j++)
			{
				gclass22_0[j]?.vmethod_1();
			}
			for (int i = rectangle_0.Y; i < rectangle_0.Height + rectangle_0.Y; i++)
			{
				for (int j = rectangle_0.X; j < rectangle_0.Width + rectangle_0.X; j++)
				{
					if (gclass24_0.int_2[i, j] % 1000 != 0)
					{
						zero.X = (float)(j * int_4) - vector2_0.X;
						zero.Y = (float)(i * int_4) - vector2_0.Y;
						int num2 = gclass24_0.int_2[i, j];
						gclass25_0.spriteBatch_0.Draw(gclass24_0.texture2D_0[num2 % 1000], zero + new Vector2(0f, (float)(int_4 - gclass24_0.texture2D_0[num2 % 1000].Height)), color_0);
					}
				}
			}
			for (int j = 0; j < gclass24_0.gclass0_0.Length; j++)
			{
				GClass0 gClass = gclass24_0.gclass0_0[j];
				if (gClass != null && gClass.bool_2)
				{
					gClass.vmethod_4(gclass24_0.gclass0_0[j].vector2_0 - vector2_0, 1f);
				}
			}
			if (gclass22_0[0].genum4_0 == (GEnum4)12)
			{
				gclass22_0[0].vmethod_1();
			}
			bool flag = true;
			if (gclass24_0.string_0 == "ES")
			{
				flag = false;
			}
			if (flag)
			{
				gclass25_0.spriteBatch_0.Draw(texture2D_5, new Vector2(64f, 36f), color_0);
				Texture2D val = null;
				int num3 = 64 + texture2D_5.Width - 8 + 6 * texture2D_12[0].Width;
				int num4 = gclass22_0[0].int_19;
				if (Math.Ceiling(Math.Log10(num4)) > 6.0)
				{
					num3 = 64 + texture2D_5.Width - 8 + (int)Math.Ceiling(Math.Log10(num4)) * texture2D_12[0].Width;
				}
				for (int j = 0; j < 8 && (num4 != 0 || j == 0); j++)
				{
					val = texture2D_12[num4 % 10];
					num4 /= 10;
					gclass25_0.spriteBatch_0.Draw(val, new Vector2((float)(num3 - j * val.Width), 36f), color_0);
				}
				if (gclass22_0[0].int_17 != 0 || int_17 <= 7)
				{
					gclass25_0.spriteBatch_0.Draw(texture2D_7, new Vector2(64f, 164f), color_0);
				}
				val = null;
				num4 = gclass22_0[0].int_17;
				num3 = ((!(Math.Ceiling(Math.Log10(num4)) > 3.0)) ? (64 + texture2D_7.Width + 3 * texture2D_12[0].Width) : (64 + texture2D_7.Width + (int)Math.Ceiling(Math.Log10(num4)) * texture2D_12[0].Width));
				for (int j = 0; j < 6 && (num4 != 0 || j == 0); j++)
				{
					val = texture2D_12[num4 % 10];
					num4 /= 10;
					gclass25_0.spriteBatch_0.Draw(val, new Vector2((float)(num3 - j * val.Width), 164f), color_0);
				}
				int num5 = (int)float_4;
				int num6 = num5 / 60;
				int num7 = (int)(float_4 * 100f) % 100;
				if (num6 < 9 || int_17 <= 7)
				{
					gclass25_0.spriteBatch_0.Draw(texture2D_6, new Vector2(64f, 100f), color_0);
				}
				if (num6 >= 10)
				{
					if (gclass22_0[0].genum4_0 != (GEnum4)12)
					{
						gclass22_0[0].genum4_0 = (GEnum4)12;
						gclass22_0[0].vector2_1.Y = -28f;
					}
					num5 = 599;
					num6 = 9;
					num7 = 99;
				}
				val = texture2D_12[num6 % 10];
				num3 = 64 + texture2D_6.Width + val.Width;
				gclass25_0.spriteBatch_0.Draw(val, new Vector2((float)num3, 100f), color_0);
				num3 += val.Width;
				gclass25_0.spriteBatch_0.Draw(texture2D_8, new Vector2((float)num3, 100f), color_0);
				num3 += val.Width;
				val = texture2D_12[num5 % 60 / 10];
				gclass25_0.spriteBatch_0.Draw(val, new Vector2((float)num3, 100f), color_0);
				num3 += val.Width;
				val = texture2D_12[num5 % 10];
				gclass25_0.spriteBatch_0.Draw(val, new Vector2((float)num3, 100f), color_0);
				num3 += val.Width;
				gclass25_0.spriteBatch_0.Draw(texture2D_8, new Vector2((float)num3, 100f), color_0);
				num3 += val.Width;
				val = texture2D_12[num7 / 10];
				gclass25_0.spriteBatch_0.Draw(val, new Vector2((float)num3, 100f), color_0);
				num3 += val.Width;
				val = texture2D_12[num7 % 10];
				gclass25_0.spriteBatch_0.Draw(val, new Vector2((float)num3, 100f), color_0);
				gclass25_0.spriteBatch_0.Draw(texture2D_10, new Vector2(0f, (float)(((Texture2D)gclass25_0.renderTarget2D_0).Height - 100)), color_0);
				if (gclass22_0[0].int_18 >= 0)
				{
					gclass25_0.spriteBatch_0.Draw(texture2D_11[gclass22_0[0].int_18 % 10], new Vector2(0f, (float)(((Texture2D)gclass25_0.renderTarget2D_0).Height - 100)), color_0);
				}
			}
		}
		if (bool_0)
		{
			if (bool_2)
			{
				((Game)gclass25_0).GraphicsDevice.Clear(Color.Black);
			}
			if (bool_1)
			{
				gclass25_0.spriteBatch_0.End();
				gclass25_0.spriteBatch_0.Begin((SpriteSortMode)1, BlendState.Opaque);
				for (int j = 0; j < gclass24_0.int_1; j++)
				{
					gclass25_0.spriteBatch_0.Draw(gclass24_0.texture2D_0[j], new Rectangle(j % int_16 * int_4 / int_14, j / int_16 * int_4 / int_14, int_4 / int_14, int_4 / int_14), Color.White);
				}
				gclass25_0.spriteBatch_0.End();
				gclass25_0.spriteBatch_0.Begin();
				for (int j = 0; j < gclass24_0.int_1; j++)
				{
					gclass25_0.spriteBatch_0.Draw(texture2D_4, new Rectangle(j % int_16 * int_4 / int_14, j / int_16 * int_4 / int_14, int_4 / int_14, int_4 / int_14), Color.White);
				}
				gclass25_0.spriteBatch_0.Draw(texture2D_4, new Rectangle(gclass24_0.int_2[int_3, int_2] % int_16 * int_4 / int_14, gclass24_0.int_2[int_3, int_2] / int_16 * int_4 / int_14, int_4 / int_14, int_4 / int_14), Color.Red);
			}
			if (bool_3)
			{
				if (int_1 < 0)
				{
					int_1 = 0;
				}
				gclass25_0.spriteBatch_0.End();
				gclass25_0.spriteBatch_0.Begin();
				for (int j = int_1; j < gclass0_0.Length; j++)
				{
					if (gclass0_0[j] != null)
					{
						gclass0_0[j].vmethod_3(new Vector2((float)(704 + 128 * (j - int_1)), 864f), 0.5f);
					}
				}
				gclass25_0.spriteBatch_0.End();
				gclass25_0.spriteBatch_0.Begin();
				for (int j = 0; j < 10; j++)
				{
					gclass25_0.spriteBatch_0.Draw(texture2D_4, new Rectangle(640 + j * 2 * int_4 / int_14, 800, 2 * int_4 / int_14, 2 * int_4 / int_14), Color.White);
				}
				if (bool_5)
				{
					gclass0_1.vmethod_3(gclass0_1.vector2_0, 1f);
				}
			}
			if (bool_2)
			{
				Color val2 = Color.Red;
				if (((KeyboardState)(ref gclass25_0.keyboardState_0)).IsKeyDown((Keys)80))
				{
					val2 = Color.White;
				}
				if (texture2D_0 != null)
				{
					gclass25_0.spriteBatch_0.Draw(texture2D_0, new Rectangle(0 / int_15 + int_16 * int_4 / int_14, 0 / int_15, texture2D_0.Width, texture2D_0.Height), (Rectangle?)new Rectangle(int_0 * 32, 0, texture2D_0.Width, texture2D_0.Height), val2);
				}
				for (int i = 0; i < 128; i++)
				{
					for (int j = 0; j < gclass24_0.int_5; j++)
					{
						if (gclass24_0.int_2[i, j] >= 1000 && j - int_0 >= 0)
						{
							int num2 = gclass24_0.int_2[i, j] / 1000 - 1;
							gclass25_0.spriteBatch_0.Draw(gclass24_0.texture2D_2[num2], new Rectangle((j - int_0) * int_4 / int_15 + int_16 * int_4 / int_14, i * int_4 / int_15, int_4 / int_15, int_4 / int_15), Color.White);
						}
					}
				}
				for (int i = 0; i < 128; i++)
				{
					for (int j = 0; j < gclass24_0.int_5; j++)
					{
						if (gclass24_0.int_3[i, j] != 0 && j - int_0 >= 0)
						{
							int num2 = gclass24_0.int_3[i, j] % 1000;
							gclass25_0.spriteBatch_0.Draw(gclass24_0.texture2D_0[num2], new Rectangle((j - int_0) * int_4 / int_15 + int_16 * int_4 / int_14, i * int_4 / int_15, int_4 / int_15, int_4 / int_15), Color.White);
						}
					}
				}
				for (int i = 0; i < 128; i++)
				{
					for (int j = 0; j < gclass24_0.int_5; j++)
					{
						if (gclass24_0.int_2[i, j] != 0 && j - int_0 >= 0)
						{
							int num2 = gclass24_0.int_2[i, j] % 1000;
							gclass25_0.spriteBatch_0.Draw(gclass24_0.texture2D_0[num2], new Rectangle((j - int_0) * int_4 / int_15 + int_16 * int_4 / int_14, i * int_4 / int_15, int_4 / int_15, int_4 / int_15), Color.White);
						}
					}
				}
				gclass25_0.spriteBatch_0.End();
				gclass25_0.spriteBatch_0.Begin();
				gclass25_0.spriteBatch_0.Draw(texture2D_4, new Rectangle((int_2 - int_0) * int_4 / int_15 + int_16 * int_4 / int_14, int_3 * int_4 / int_15, int_4 / int_15, int_4 / int_15), Color.White);
			}
			else if (bool_1)
			{
				gclass25_0.spriteBatch_0.Draw(texture2D_4, new Vector2((float)(int_2 * int_4), (float)(int_3 * int_4)) - vector2_0 - 0f * new Vector2((float)(int_4 / 2), (float)(int_4 / 2)), Color.White);
			}
		}
		gclass25_0.spriteBatch_0.End();
		if ((int)MediaPlayer.State == 0)
		{
			MediaPlayer.Play(song_0);
			MediaPlayer.IsRepeating = true;
		}
	}

	private void method_4()
	{
		int_19--;
		if (int_19 < 0)
		{
			int_19 = 0;
		}
		if (int_19 > int_20)
		{
			MediaPlayer.Volume = 0f;
		}
		if (int_19 <= int_20)
		{
			MediaPlayer.Volume = GClass30.float_1 * (float)(int_20 - int_19) / (float)int_20;
		}
	}

	static GClass29()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		color_0 = Color.White;
		float_4 = 0f;
		bool_7 = false;
	}
}
