using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class GClass22 : GClass0
{
	private float float_1;

	public string string_0;

	public string string_1;

	public GClass33 gclass33_0;

	public GClass33 gclass33_1;

	public GClass33 gclass33_2;

	public GClass33 gclass33_3;

	public GClass33 gclass33_4;

	public GClass33 gclass33_5;

	public GClass33 gclass33_6;

	public GClass33 gclass33_7;

	public GClass33 gclass33_8;

	public GClass33 gclass33_9;

	public GClass33 gclass33_10;

	public GClass33 gclass33_11;

	public GClass33 gclass33_12;

	public GClass33 gclass33_13;

	public GClass33 gclass33_14;

	public GClass33 gclass33_15;

	public GClass33 gclass33_16;

	private GClass25 gclass25_0;

	public GEnum4 genum4_0;

	public GEnum1 genum1_0;

	public GEnum2 genum2_0;

	public GEnum3 genum3_0;

	private int int_2;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private int int_3;

	public int int_4;

	private bool bool_7;

	public int int_5;

	private float float_2;

	public Vector2 vector2_1;

	public float float_3;

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

	public GEnum0 genum0_0;

	public int int_17;

	public int int_18;

	public int int_19;

	public int int_20;

	public static Color color_0;

	public float float_4;

	public float float_5;

	public float float_6;

	public float float_7;

	public float float_8;

	public float float_9;

	private float float_10;

	public bool bool_8;

	public bool bool_9;

	public bool bool_10;

	public bool bool_11;

	public bool bool_12;

	public bool bool_13;

	public float float_11;

	public float float_12;

	public bool bool_14;

	public int int_21;

	private float float_13;

	public float float_14;

	public float float_15;

	public float float_16;

	public float float_17;

	private float float_18;

	private float float_19;

	public int int_22;

	public float float_20;

	private int int_23;

	public int int_24;

	private int int_25;

	private int int_26;

	private float float_21;

	public int int_27;

	private float float_22;

	public float float_23;

	public float float_24;

	public float float_25;

	public float float_26;

	public float float_27;

	public int int_28;

	private bool bool_15;

	public bool bool_16;

	public int int_29;

	public int int_30;

	public int int_31;

	public int int_32;

	public bool bool_17;

	public bool bool_18;

	public int int_33;

	public int int_34;

	public GClass22(string string_2)
	{
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		float_1 = 0f;
		string_0 = "";
		string_1 = "";
		genum1_0 = (GEnum1)0;
		genum2_0 = (GEnum2)0;
		genum3_0 = (GEnum3)0;
		int_2 = 0;
		bool_4 = false;
		bool_5 = false;
		bool_6 = false;
		int_3 = 0;
		int_4 = 0;
		bool_7 = false;
		int_5 = 0;
		float_2 = 0f;
		float_3 = 0f;
		genum0_0 = (GEnum0)0;
		int_17 = 0;
		int_18 = 3;
		int_19 = 0;
		int_20 = 0;
		bool_8 = false;
		bool_9 = false;
		bool_10 = true;
		bool_11 = false;
		bool_12 = false;
		bool_13 = false;
		float_11 = -10000f;
		float_12 = 10000f;
		bool_14 = false;
		int_21 = 10000;
		float_14 = 100000f;
		float_15 = 100000f;
		float_16 = -100000f;
		float_17 = -100000f;
		int_22 = 0;
		float_20 = 0f;
		int_24 = 0;
		int_25 = 0;
		int_26 = 0;
		float_21 = 0f;
		int_27 = 0;
		float_22 = 0f;
		float_27 = 0f;
		int_28 = 0;
		bool_15 = false;
		bool_16 = false;
		int_29 = 0;
		int_30 = 0;
		int_31 = 0;
		int_32 = 0;
		bool_17 = false;
		bool_18 = false;
		int_33 = 0;
		int_34 = 0;
		base._002Ector();
		gclass25_0 = GClass25.gclass25_0;
		float_5 = 2f;
		float_10 = 0.41591904f;
		gclass33_0 = new GClass33(string_2, "idle", 1, "10000,10,14,20,20,20,10,20,20,10,10,30,1000,1000,10");
		gclass33_1 = new GClass33(string_2, "walk", 8, "8,8,8,8,8,8,8,8,8,8,8,8,8,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,5,5,5,5,5,5,5,5,10,10,10,10,10,10,10,10,10,10,10,10,1,1,1,1,1,1,1,1,1,1");
		gclass33_2 = new GClass33(string_2, "run", 4, "2,2,2,2,10,10");
		gclass33_3 = new GClass33(string_2, "roll", 8, "5,5,5,5,5,5,5,5");
		gclass33_6 = new GClass33(string_2, "roll", 8, "1,1,1,1,1,1,1,1,1,1,1");
		gclass33_4 = new GClass33(string_2, "crouch", 2, "6,100000,10,10,10,10");
		gclass33_5 = new GClass33(string_2, "spin", 10, "1,1,1,1,1,1,1,1,1,1");
		gclass33_7 = new GClass33(string_2, "lookUp", 2, "6,100000,10,10,10,10");
		gclass33_8 = new GClass33(string_2, "otskok", 1, "1000,80,14,10,10,10");
		gclass33_9 = new GClass33(string_2, "walk", 8, "8,8,8,8,8,8,8,8,8,8,8,8,8,8,2,2,2,2,2,2,2");
		gclass33_10 = new GClass33(string_2, "run", 4, "2,2,2,2");
		gclass33_11 = new GClass33(string_2, "pushing", 4, "32,32,32,32,32,8,8,8,8,8,8,8,8,8,2,2,2,2,2,2,2");
		gclass33_12 = new GClass33(string_2, "hit", 1, "10000,10000,10000,10000");
		gclass33_13 = new GClass33(string_2, "die", 1, "10000,1000,1000");
		gclass33_14 = new GClass33(string_2, "ninja", 6, "1,2,4,5,4,3,30,2,100,100,100,100");
		color_0 = Color.White;
		gclass33_16 = gclass33_0;
		genum4_0 = (GEnum4)0;
		method_28();
	}

	private void method_2(int int_35)
	{
		float num = 0.15f;
		if (GClass31.gclass32_0[int_35].float_2 < -0.15f)
		{
			int_6++;
		}
		if (GClass31.gclass32_0[int_35].float_2 > num)
		{
			int_7++;
		}
		if (GClass31.gclass32_0[int_35].float_3 > num)
		{
			int_8++;
		}
		if (GClass31.gclass32_0[int_35].float_3 < 0f - num)
		{
			int_9++;
		}
		if (GClass31.gclass32_0[int_35].int_10 > 0)
		{
			int_6++;
		}
		if (GClass31.gclass32_0[int_35].int_11 > 0)
		{
			int_7++;
		}
		if (GClass31.gclass32_0[int_35].int_12 > 0)
		{
			int_8++;
		}
		if (GClass31.gclass32_0[int_35].int_13 > 0)
		{
			int_9++;
		}
		if (int_10 < GClass31.gclass32_0[int_35].int_0)
		{
			int_10 = GClass31.gclass32_0[int_35].int_0;
		}
		if (int_11 < GClass31.gclass32_0[int_35].int_1)
		{
			int_11 = GClass31.gclass32_0[int_35].int_1;
		}
		if (int_12 < GClass31.gclass32_0[int_35].int_4)
		{
			int_12 = GClass31.gclass32_0[int_35].int_4;
		}
		if (int_13 < GClass31.gclass32_0[int_35].int_2)
		{
			int_13 = GClass31.gclass32_0[int_35].int_2;
		}
		if (int_14 < GClass31.gclass32_0[int_35].int_3)
		{
			int_14 = GClass31.gclass32_0[int_35].int_3;
		}
		if (int_15 < GClass31.gclass32_0[int_35].int_5)
		{
			int_15 = GClass31.gclass32_0[int_35].int_5;
		}
		if (int_16 < GClass31.gclass32_0[int_35].int_7)
		{
			int_16 = GClass31.gclass32_0[int_35].int_7;
		}
	}

	private void method_3()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		KeyboardState state = Keyboard.GetState();
		if (((KeyboardState)(ref state)).IsKeyDown((Keys)27))
		{
			((Game)gclass25_0).Exit();
		}
		if (bool_18)
		{
			int_8 = 0;
			int_9 = 0;
			int_7 = 0;
			int_6 = 0;
			return;
		}
		int num = int_10;
		int num2 = int_11;
		int num3 = int_12;
		switch (int_20)
		{
		case 10:
			method_2(0);
			break;
		case 11:
			method_2(1);
			break;
		case 12:
			method_2(2);
			break;
		case 13:
			method_2(3);
			break;
		case 0:
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)37))
			{
				int_6++;
			}
			else
			{
				int_6 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)39))
			{
				int_7++;
			}
			else
			{
				int_7 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)38))
			{
				int_8++;
			}
			else
			{
				int_8 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)40))
			{
				int_9++;
			}
			else
			{
				int_9 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)65))
			{
				int_10++;
			}
			else
			{
				int_10 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)83))
			{
				int_11++;
			}
			else
			{
				int_11 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)68))
			{
				int_12++;
			}
			else
			{
				int_12 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)81))
			{
				int_13++;
			}
			else
			{
				int_13 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)87))
			{
				int_14++;
			}
			else
			{
				int_14 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)69))
			{
				int_15++;
			}
			else
			{
				int_15 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)13))
			{
				int_16++;
			}
			else
			{
				int_16 = 0;
			}
			method_2(0);
			break;
		case 1:
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)75))
			{
				int_6++;
			}
			else
			{
				int_6 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)186))
			{
				int_7++;
			}
			else
			{
				int_7 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)79))
			{
				int_8++;
			}
			else
			{
				int_8 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)76))
			{
				int_9++;
			}
			else
			{
				int_9 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)70))
			{
				int_10++;
			}
			else
			{
				int_10 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)71))
			{
				int_11++;
			}
			else
			{
				int_11 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)72))
			{
				int_12++;
			}
			else
			{
				int_12 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)82))
			{
				int_13++;
			}
			else
			{
				int_13 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)84))
			{
				int_14++;
			}
			else
			{
				int_14 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)89))
			{
				int_15++;
			}
			else
			{
				int_15 = 0;
			}
			if (((KeyboardState)(ref state)).IsKeyDown((Keys)50))
			{
				int_16++;
			}
			else
			{
				int_16 = 0;
			}
			method_2(1);
			break;
		}
		if ((num > 0 && int_10 == 0) || (num2 > 0 && int_11 == 0) || (num3 > 0 && int_12 == 0) || vector2_1.Y > -16f)
		{
			bool_6 = true;
		}
		if (genum0_0 != (GEnum0)4)
		{
			bool_6 = false;
		}
	}

	public void method_4()
	{
		switch (genum4_0)
		{
		case (GEnum4)0:
			gclass33_16 = gclass33_0;
			break;
		case (GEnum4)1:
			gclass33_16 = gclass33_1;
			break;
		case (GEnum4)2:
			gclass33_16 = gclass33_2;
			break;
		case (GEnum4)3:
			gclass33_16 = gclass33_3;
			break;
		case (GEnum4)4:
			gclass33_16 = gclass33_4;
			break;
		case (GEnum4)5:
			gclass33_16 = gclass33_6;
			break;
		case (GEnum4)6:
			gclass33_16 = gclass33_5;
			break;
		case (GEnum4)7:
			gclass33_16 = gclass33_7;
			break;
		case (GEnum4)8:
			gclass33_16 = gclass33_8;
			break;
		case (GEnum4)9:
			gclass33_16 = gclass33_9;
			break;
		case (GEnum4)10:
			gclass33_16 = gclass33_10;
			break;
		case (GEnum4)11:
			gclass33_16 = gclass33_12;
			break;
		case (GEnum4)12:
			gclass33_16 = gclass33_13;
			break;
		case (GEnum4)13:
			gclass33_16 = gclass33_14;
			break;
		}
		if (bool_11 || bool_12 || bool_13)
		{
			gclass33_16 = gclass33_11;
		}
		if (gclass33_0 != gclass33_16)
		{
			gclass33_0.int_1 = 0;
		}
		if (gclass33_9 != gclass33_16)
		{
			gclass33_9.int_1 = 0;
		}
		if (gclass33_10 != gclass33_16)
		{
			gclass33_10.int_1 = 0;
		}
		if (gclass33_2 != gclass33_16)
		{
			gclass33_2.int_1 = 0;
		}
		else
		{
			gclass33_10.int_1 = gclass33_2.int_1;
		}
		if (gclass33_3 != gclass33_16)
		{
			gclass33_3.int_1 = 0;
		}
		if (gclass33_4 != gclass33_16)
		{
			gclass33_4.int_1 = 0;
		}
		if (gclass33_6 != gclass33_16)
		{
			gclass33_6.int_1 = 0;
		}
		if (gclass33_5 != gclass33_16)
		{
			gclass33_5.int_1 = 0;
		}
		if (gclass33_7 != gclass33_16)
		{
			gclass33_7.int_1 = 0;
		}
		if (gclass33_8 != gclass33_16)
		{
			gclass33_8.int_1 = 0;
		}
		if (gclass33_1 != gclass33_16)
		{
			gclass33_1.int_1 = 0;
		}
		else
		{
			gclass33_9.int_1 = gclass33_1.int_1;
		}
		if (gclass33_11 != gclass33_16)
		{
			gclass33_11.int_1 = 0;
		}
		if (gclass33_12 != gclass33_16)
		{
			gclass33_12.int_1 = 0;
		}
		if (gclass33_13 != gclass33_16)
		{
			gclass33_13.int_1 = 0;
		}
		if (gclass33_14 != gclass33_16)
		{
			gclass33_14.int_1 = 0;
		}
		int num = gclass33_16.int_1;
		int num2 = 0;
		for (num2 = 0; num2 < gclass33_16.texture2D_0.Length; num2++)
		{
			if (num > gclass33_16.int_0[num2])
			{
				num -= gclass33_16.int_0[num2];
				continue;
			}
			num -= gclass33_16.int_0[num2];
			break;
		}
		if (num >= 0 && num2 == gclass33_16.texture2D_0.Length)
		{
			gclass33_16.int_1 = 1;
			num2 = 0;
		}
		gclass33_16.int_2 = num2;
	}

	private void method_5()
	{
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (genum0_0 == (GEnum0)1)
		{
			float_20 = float_24;
		}
		if (genum0_0 == (GEnum0)3)
		{
			float_20 = float_26;
		}
		if (genum0_0 == (GEnum0)2)
		{
			float_20 = float_25;
		}
		float_13 = (float)((double)float_10 * Math.Sin(float_20));
		if ((float_3 <= 0f && !(float_3 + float_13 <= 0f)) || (float_3 >= 0f && float_3 + float_13 < 0f))
		{
			flag = true;
		}
		float_3 += float_13;
		if (int_6 > 0 && int_7 > 0)
		{
			if (Math.Abs(float_3) < float_5)
			{
				float_3 = 0f;
				genum4_0 = (GEnum4)0;
			}
		}
		else if (int_6 == 0 && int_7 == 0)
		{
			if (Math.Abs(float_3) < float_4)
			{
				float_3 = 0f;
				genum4_0 = (GEnum4)0;
			}
			else if (float_3 > 0f)
			{
				float_3 -= float_6;
			}
			else if (float_3 < 0f)
			{
				float_3 += float_6;
			}
		}
		else
		{
			if (int_6 > 0)
			{
				if (flag || float_3 <= 0f)
				{
					float_3 -= float_4;
					if (float_3 < 0f - float_7)
					{
						float_3 = 0f - float_7;
					}
				}
				else if (float_3 > 0f)
				{
					float_3 -= float_5;
					if (float_3 < 0f)
					{
						float_3 = 0f;
						bool_0 = false;
					}
				}
			}
			if (int_7 > 0)
			{
				if (flag || float_3 >= 0f)
				{
					float_3 += float_4;
					if (float_3 > float_7)
					{
						float_3 = float_7;
					}
				}
				else if (float_3 < 0f)
				{
					float_3 += float_5;
					if (float_3 > 0f)
					{
						float_3 = 0f;
						bool_0 = true;
					}
				}
			}
			if (float_3 > 0f && int_7 > 0)
			{
				bool_0 = true;
			}
			if (float_3 < 0f && int_6 > 0)
			{
				bool_0 = false;
			}
		}
		if (bool_12 || bool_13 || bool_11)
		{
			float_3 = 0f;
			if (genum4_0 == (GEnum4)1 || genum4_0 == (GEnum4)2)
			{
				genum4_0 = (GEnum4)0;
			}
		}
		vector2_1 = float_3 * new Vector2((float)Math.Cos(float_20), (float)Math.Sin(float_20));
		ref Vector2 reference = ref vector2_0;
		reference.X += vector2_1.X;
		ref Vector2 reference2 = ref vector2_0;
		reference2.Y += vector2_1.Y;
		if (Math.PI / 4.0 < (double)(0f - float_20) && (double)(0f - float_20) < Math.PI * 3.0 / 4.0)
		{
			if (genum0_0 == (GEnum0)0 || genum0_0 == (GEnum0)2)
			{
				genum0_0 = (GEnum0)1;
				method_25();
			}
			genum0_0 = (GEnum0)1;
		}
		if (-Math.PI / 4.0 < (double)(0f - float_20) && (double)(0f - float_20) < Math.PI / 4.0)
		{
			if (genum0_0 == (GEnum0)1 || genum0_0 == (GEnum0)3)
			{
				genum0_0 = (GEnum0)0;
				method_25();
			}
			genum0_0 = (GEnum0)0;
		}
		if (Math.PI * 3.0 / 4.0 < (double)(0f - float_20) || (double)(0f - float_20) < Math.PI * -3.0 / 4.0)
		{
			if (genum0_0 == (GEnum0)1 || genum0_0 == (GEnum0)3)
			{
				genum0_0 = (GEnum0)2;
				method_25();
			}
			genum0_0 = (GEnum0)2;
		}
		else if (genum0_0 == (GEnum0)2)
		{
		}
		if (Math.PI * -3.0 / 4.0 < (double)(0f - float_20) && (double)(0f - float_20) < -Math.PI / 4.0)
		{
			if (genum0_0 == (GEnum0)0 || genum0_0 == (GEnum0)2)
			{
				genum0_0 = (GEnum0)3;
				method_25();
			}
			genum0_0 = (GEnum0)3;
		}
	}

	private void method_6()
	{
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (genum0_0 == (GEnum0)1)
		{
			float_20 = float_24;
		}
		if (genum0_0 == (GEnum0)3)
		{
			float_20 = float_26;
		}
		if (genum0_0 == (GEnum0)2)
		{
			float_20 = float_25;
		}
		if (Math.Sign(float_3) != Math.Sign(Math.Sin(float_20)))
		{
			float_13 = (float)(0.65 * (double)float_10 * Math.Sin(float_20));
		}
		else
		{
			float_13 = (float)(2.5 * (double)float_10 * Math.Sin(float_20));
		}
		if ((float_3 <= 0f && !(float_3 + float_13 <= 0f)) || (float_3 >= 0f && float_3 + float_13 < 0f))
		{
			flag = true;
		}
		float_3 += float_13;
		if (float_3 < 0f && int_6 > 0)
		{
			int_6 = 0;
		}
		if (float_3 > 0f && int_7 > 0)
		{
			int_7 = 0;
		}
		if (int_6 == 0 && int_7 == 0)
		{
			if (Math.Abs(float_3) < float_4)
			{
				float_3 = 0f;
				genum4_0 = (GEnum4)0;
			}
			else if (float_3 > 0f)
			{
				float_3 -= float_6 / 2f;
			}
			else if (float_3 < 0f)
			{
				float_3 += float_6 / 2f;
			}
		}
		else
		{
			if (int_6 > 0)
			{
				if (flag || float_3 <= 0f)
				{
					float_3 -= float_4;
				}
				else if (float_3 > 0f)
				{
					float_3 -= float_5 / 4f;
					if (float_3 < 0f)
					{
						float_3 = 0f;
						bool_0 = false;
					}
				}
			}
			if (int_7 > 0)
			{
				if (flag || float_3 >= 0f)
				{
					float_3 += float_4;
				}
				else if (float_3 < 0f)
				{
					float_3 += float_5 / 4f;
					if (float_3 > 0f)
					{
						float_3 = 0f;
						bool_0 = true;
					}
				}
			}
			if (float_3 > 0f && int_7 > 0)
			{
				bool_0 = true;
			}
			if (float_3 < 0f && int_6 > 0)
			{
				bool_0 = false;
			}
		}
		if (bool_12 || bool_13 || bool_11)
		{
			float_3 = 0f;
			if (genum4_0 == (GEnum4)1 || genum4_0 == (GEnum4)2)
			{
				genum4_0 = (GEnum4)0;
			}
		}
		vector2_1 = float_3 * new Vector2((float)Math.Cos(float_20), (float)Math.Sin(float_20));
		ref Vector2 reference = ref vector2_0;
		reference.X += vector2_1.X;
		ref Vector2 reference2 = ref vector2_0;
		reference2.Y += vector2_1.Y;
		if (Math.PI / 4.0 < (double)(0f - float_20) && (double)(0f - float_20) < Math.PI * 3.0 / 4.0)
		{
			if (genum0_0 == (GEnum0)0 || genum0_0 == (GEnum0)2)
			{
				genum0_0 = (GEnum0)1;
				method_25();
			}
			genum0_0 = (GEnum0)1;
		}
		if (-Math.PI / 4.0 < (double)(0f - float_20) && (double)(0f - float_20) < Math.PI / 4.0)
		{
			if (genum0_0 == (GEnum0)1 || genum0_0 == (GEnum0)3)
			{
				genum0_0 = (GEnum0)0;
				method_25();
			}
			genum0_0 = (GEnum0)0;
		}
		if (Math.PI * 3.0 / 4.0 < (double)(0f - float_20) || (double)(0f - float_20) < Math.PI * -3.0 / 4.0)
		{
			if (genum0_0 == (GEnum0)1 || genum0_0 == (GEnum0)3)
			{
				genum0_0 = (GEnum0)2;
				method_25();
			}
			genum0_0 = (GEnum0)2;
		}
		else if (genum0_0 == (GEnum0)2)
		{
		}
		if (Math.PI * -3.0 / 4.0 < (double)(0f - float_20) && (double)(0f - float_20) < -Math.PI / 4.0)
		{
			if (genum0_0 == (GEnum0)0 || genum0_0 == (GEnum0)2)
			{
				genum0_0 = (GEnum0)3;
				method_25();
			}
			genum0_0 = (GEnum0)3;
		}
	}

	private float method_7(int int_35, int int_36, int int_37)
	{
		GClass23 gClass = GClass24.gclass23_0[int_35];
		int[] array = new int[64];
		for (int i = 0; i < 64; i++)
		{
			array[i] = 0;
		}
		int num = int_36 / 64 * 64;
		int num2 = 0;
		int num3 = 0;
		string_0 += "|";
		num3 = 0;
		num2 = 0;
		for (int i = 0; i < 64; i++)
		{
			for (int j = 0; j < 512; j++)
			{
				if (gClass.bool_0[j, num + i])
				{
					if (i <= 31)
					{
						num2 += 512 - j;
					}
					else
					{
						num3 += 512 - j;
					}
					break;
				}
			}
		}
		float num4 = 0f;
		num4 = (float)Math.Atan2(0f - ((float)num3 / 32f - (float)num2 / 32f), 32.0);
		float_20 = (float_23 = num4);
		return 0f;
	}

	private float method_8(int int_35, int int_36, int int_37)
	{
		GClass23 gClass = GClass24.gclass23_0[int_35];
		int[] array = new int[64];
		for (int i = 0; i < 64; i++)
		{
			array[i] = 0;
		}
		int num = int_36 / 64 * 64;
		int num2 = 0;
		int num3 = 0;
		string_0 += "      ";
		num3 = 0;
		num2 = 0;
		for (int i = 0; i < 64; i++)
		{
			int num4 = 511;
			while (num4 >= 0)
			{
				if (!gClass.bool_0[num4, num + i])
				{
					num4--;
					continue;
				}
				if (i <= 31)
				{
					num2 += num4;
				}
				else
				{
					num3 += num4;
				}
				break;
			}
		}
		float num5 = 0f;
		num5 = (float)Math.Atan2(0f - ((float)num3 / 32f - (float)num2 / 32f), -32.0);
		float_20 = (float_25 = num5);
		return 0f;
	}

	private float method_9(int int_35, int int_36, int int_37)
	{
		GClass23 gClass = GClass24.gclass23_0[int_35];
		int num = int_37 / 64 * 64;
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < 64; i++)
		{
			for (int j = 0; j < 512; j++)
			{
				if (gClass.bool_0[num + i, j])
				{
					if (i <= 31)
					{
						num3 += 512 - j;
					}
					else
					{
						num2 += 512 - j;
					}
					break;
				}
			}
		}
		float num4 = (float)Math.Atan2(-32.0, 0f - ((float)num3 / 32f - (float)num2 / 32f));
		float_24 = num4;
		return 0f;
	}

	private float method_10(int int_35, int int_36, int int_37)
	{
		GClass23 gClass = GClass24.gclass23_0[int_35];
		int num = int_37 / 64 * 64;
		int num2 = 0;
		int num3 = 0;
		for (int i = 0; i < 64; i++)
		{
			int num4 = 511;
			while (num4 >= 0)
			{
				if (!gClass.bool_0[num + i, num4])
				{
					num4--;
					continue;
				}
				if (i <= 31)
				{
					num3 += num4;
				}
				else
				{
					num2 += num4;
				}
				break;
			}
		}
		float num5 = (float)Math.Atan2(32.0, 0f - ((float)num3 / 32f - (float)num2 / 32f));
		float_26 = num5;
		return 0f;
	}

	private float method_11(int int_35, int int_36)
	{
		return method_13(int_35, int_36, bool_19: false, bool_20: true);
	}

	private float method_12(int int_35, int int_36, bool bool_19)
	{
		return method_13(int_35, int_36, bool_19, bool_20: true);
	}

	private float method_13(int int_35, int int_36, bool bool_19, bool bool_20)
	{
		float num = 100000f;
		if (int_35 < 0)
		{
			return num;
		}
		GClass24 gclass24_ = GClass29.gclass24_0;
		int num2 = int_35 / 512;
		int num3 = int_36 / 512;
		GClass23 gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
		int num4 = int_35 - num2 * 512;
		int num5 = int_36 - num3 * 512;
		for (int i = -num5; i + num5 < 512 && num5 + i < 512; i++)
		{
			if (gClass.bool_0[num5 + i, num4] && -64 < i && (float)i < num)
			{
				num = i;
			}
		}
		num2 = int_35 / 512;
		num3 = int_36 / 512 + 1;
		num4 = int_35 - num2 * 512;
		num5 = int_36 - num3 * 512;
		gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
		for (int i = -num5; i + num5 < 512 && num5 + i < 512; i++)
		{
			if (i + num5 >= 0 && gClass.bool_0[num5 + i, num4] && -64 < i && (float)i < num)
			{
				num = i;
			}
		}
		num2 = int_35 / 512;
		num3 = int_36 / 512 - 1;
		num4 = int_35 - num2 * 512;
		num5 = int_36 - num3 * 512;
		gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
		for (int i = -num5; i + num5 <= 512 && num5 + i < 512; i++)
		{
			if (i + num5 >= 0 && gClass.bool_0[num5 + i, num4] && i > -76 && -64 < i && (float)i < num)
			{
				num = i;
			}
		}
		if (bool_19)
		{
			num2 = int_35 / 512;
			num3 = int_36 / 512;
			gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
			num4 = int_35 - num2 * 512;
			num5 = int_36 - num3 * 512;
			for (int i = -num5; i + num5 < 512 && num5 + i < 512; i++)
			{
				if (gClass.bool_0[num5 + i, num4] && (float)i == num)
				{
					if (bool_20)
					{
						method_7(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4, num5 + i);
					}
					else
					{
						method_7(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4, num5 + i);
					}
				}
			}
			num2 = int_35 / 512;
			num3 = int_36 / 512 + 1;
			num4 = int_35 - num2 * 512;
			num5 = int_36 - num3 * 512;
			gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
			for (int i = -num5; i + num5 < 512 && num5 + i < 512; i++)
			{
				if (i + num5 >= 0 && gClass.bool_0[num5 + i, num4] && (float)i == num)
				{
					if (bool_20)
					{
						method_7(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4, num5 + i);
					}
					else
					{
						method_7(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4, num5 + i);
					}
				}
			}
			num2 = int_35 / 512;
			num3 = int_36 / 512 - 1;
			num4 = int_35 - num2 * 512;
			num5 = int_36 - num3 * 512;
			gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
			for (int i = -num5; i + num5 <= 512 && num5 + i < 512; i++)
			{
				if (i + num5 >= 0 && gClass.bool_0[num5 + i, num4] && i > -76 && (float)i == num)
				{
					if (bool_20)
					{
						method_7(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4, num5 + i);
					}
					else
					{
						method_7(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4, num5 + i);
					}
				}
			}
		}
		if (!(num > 1000f))
		{
		}
		return num;
	}

	private float method_14(int int_35, int int_36)
	{
		return method_16(int_35, int_36, bool_19: false, bool_20: true);
	}

	private float method_15(int int_35, int int_36, bool bool_19)
	{
		return method_16(int_35, int_36, bool_19, bool_20: true);
	}

	private float method_16(int int_35, int int_36, bool bool_19, bool bool_20)
	{
		int num = 100000;
		float_15 = 1000f;
		float_17 = -1000f;
		GClass24 gclass24_ = GClass29.gclass24_0;
		int num2 = int_35 / 512;
		int num3 = int_36 / 512;
		GClass23 gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
		int num4 = int_35 - num2 * 512;
		int num5 = int_36 - num3 * 512;
		for (int i = -num4; i < 512 && num4 + i < 512; i++)
		{
			if (num5 >= 0 && gClass.bool_0[num5, num4 + i])
			{
				if ((float)i < float_15 && (i > 0 || (i > -80 && genum0_0 == (GEnum0)1)))
				{
					float_15 = i;
				}
				if (float_17 < (float)i && (i < 0 || (i < 80 && genum0_0 == (GEnum0)3)))
				{
					float_17 = i;
				}
			}
		}
		num2 = int_35 / 512 + 1;
		num3 = int_36 / 512;
		gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
		num4 = int_35 - num2 * 512;
		num5 = int_36 - num3 * 512;
		for (int i = -num4; i < 512 && num4 + i < 512; i++)
		{
			if (num5 >= 0 && gClass.bool_0[num5, num4 + i])
			{
				if ((float)i < float_15 && (i > 0 || (i > -80 && genum0_0 == (GEnum0)1)))
				{
					float_15 = i;
				}
				if (float_17 < (float)i && (i < 0 || (i < 80 && genum0_0 == (GEnum0)3)))
				{
					float_17 = i;
				}
			}
		}
		num2 = int_35 / 512 - 1;
		if (num2 < 0)
		{
			num2 = 0;
		}
		num3 = int_36 / 512;
		gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
		num4 = int_35 - num2 * 512;
		num5 = int_36 - num3 * 512;
		for (int i = -num4; i < 512 && num4 + i < 512; i++)
		{
			if (num4 + i >= 0 && num5 >= 0 && gClass.bool_0[num5, num4 + i])
			{
				if ((float)i < float_15 && (i > 0 || (i > -80 && genum0_0 == (GEnum0)1)))
				{
					float_15 = i;
				}
				if (float_17 < (float)i && (i < 0 || (i < 80 && genum0_0 == (GEnum0)3)))
				{
					float_17 = i;
				}
			}
		}
		if (bool_19)
		{
			num2 = int_35 / 512;
			num3 = int_36 / 512;
			gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
			num4 = int_35 - num2 * 512;
			num5 = int_36 - num3 * 512;
			for (int i = -num4; i < 512 && num4 + i < 512; i++)
			{
				if (num5 < 0 || !gClass.bool_0[num5, num4 + i])
				{
					continue;
				}
				if ((float)i == float_15)
				{
					if (bool_20)
					{
						method_9(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + i, num5);
					}
					else
					{
						method_9(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + i, num5);
					}
				}
				if (float_17 == (float)i)
				{
					if (bool_20)
					{
						method_10(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + i, num5);
					}
					else
					{
						method_10(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + i, num5);
					}
				}
			}
			num2 = int_35 / 512 + 1;
			num3 = int_36 / 512;
			gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
			num4 = int_35 - num2 * 512;
			num5 = int_36 - num3 * 512;
			for (int i = -num4; i < 512 && num4 + i < 512; i++)
			{
				if (num5 < 0 || !gClass.bool_0[num5, num4 + i])
				{
					continue;
				}
				if ((float)i == float_15)
				{
					if (bool_20)
					{
						method_9(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + i, num5);
					}
					else
					{
						method_9(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + i, num5);
					}
				}
				if (float_17 == (float)i)
				{
					if (bool_20)
					{
						method_10(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + i, num5);
					}
					else
					{
						method_10(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + i, num5);
					}
				}
			}
			num2 = int_35 / 512 - 1;
			if (num2 < 0)
			{
				num2 = 0;
			}
			num3 = int_36 / 512;
			gClass = ((!bool_20) ? GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]] : GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]]);
			num4 = int_35 - num2 * 512;
			num5 = int_36 - num3 * 512;
			for (int i = -num4; i < 512 && num4 + i < 512; i++)
			{
				if (num4 + i < 0 || num5 < 0 || !gClass.bool_0[num5, num4 + i])
				{
					continue;
				}
				if ((float)i == float_15)
				{
					if (bool_20)
					{
						method_9(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + i, num5);
					}
					else
					{
						method_9(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + i, num5);
					}
				}
				if (float_17 == (float)i)
				{
					if (bool_20)
					{
						method_10(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + i, num5);
					}
					else
					{
						method_10(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + i, num5);
					}
				}
			}
		}
		return num;
	}

	private float method_17(int int_35, int int_36)
	{
		return method_19(int_35, int_36, bool_19: false, bool_20: true);
	}

	private float method_18(int int_35, int int_36, bool bool_19)
	{
		return method_19(int_35, int_36, bool_19, bool_20: true);
	}

	private float method_19(int int_35, int int_36, bool bool_19, bool bool_20)
	{
		float num = -100000f;
		if (int_35 < 0)
		{
			return num;
		}
		GClass24 gclass24_ = GClass29.gclass24_0;
		int num2 = int_35 / 512;
		int num3 = int_36 / 512;
		int num4;
		GClass23 gClass;
		if (bool_20)
		{
			num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
			gClass = GClass24.gclass23_0[num4];
		}
		else
		{
			num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
			gClass = GClass24.gclass23_0[num4];
		}
		int num5 = int_35 - num2 * 512;
		int num6 = int_36 - num3 * 512;
		if (!gclass24_.bool_1[num4] || genum0_0 != (GEnum0)4)
		{
			for (int i = -num6; i + num6 < 512 && num6 + i < 512; i++)
			{
				if (gClass.bool_0[num6 + i, num5] && (float)i > num && i < 4)
				{
					num = i;
				}
			}
		}
		num2 = int_35 / 512;
		num3 = int_36 / 512 + 1;
		num5 = int_35 - num2 * 512;
		num6 = int_36 - num3 * 512;
		if (bool_20)
		{
			num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
			gClass = GClass24.gclass23_0[num4];
		}
		else
		{
			num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
			gClass = GClass24.gclass23_0[num4];
		}
		if (!gclass24_.bool_1[num4] || genum0_0 != (GEnum0)4)
		{
			for (int i = -num6; i + num6 < 512 && num6 + i < 512; i++)
			{
				if (i + num6 >= 0 && gClass.bool_0[num6 + i, num5] && (float)i > num && i < 4)
				{
					num = i;
				}
			}
		}
		num2 = int_35 / 512;
		num3 = int_36 / 512 - 1;
		num5 = int_35 - num2 * 512;
		num6 = int_36 - num3 * 512;
		if (bool_20)
		{
			num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
			gClass = GClass24.gclass23_0[num4];
		}
		else
		{
			num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
			gClass = GClass24.gclass23_0[num4];
		}
		if (!gclass24_.bool_1[num4] || genum0_0 != (GEnum0)4)
		{
			for (int i = -num6; i + num6 <= 512 && num6 + i < 512; i++)
			{
				if (i + num6 >= 0 && gClass.bool_0[num6 + i, num5] && (float)i > num && i < 4)
				{
					num = i;
				}
			}
		}
		if (bool_19)
		{
			num2 = int_35 / 512;
			num3 = int_36 / 512;
			if (bool_20)
			{
				num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
				gClass = GClass24.gclass23_0[num4];
			}
			else
			{
				num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
				gClass = GClass24.gclass23_0[num4];
			}
			num5 = int_35 - num2 * 512;
			num6 = int_36 - num3 * 512;
			if (!gclass24_.bool_1[num4] || genum0_0 != (GEnum0)4)
			{
				for (int i = -num6; i + num6 < 512 && num6 + i < 512; i++)
				{
					if (gClass.bool_0[num6 + i, num5] && (float)i == num)
					{
						if (bool_20)
						{
							method_8(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num5, num6 + i);
						}
						else
						{
							method_8(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num5, num6 + i);
						}
					}
				}
			}
			num2 = int_35 / 512;
			num3 = int_36 / 512 + 1;
			num5 = int_35 - num2 * 512;
			num6 = int_36 - num3 * 512;
			if (bool_20)
			{
				num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
				gClass = GClass24.gclass23_0[num4];
			}
			else
			{
				num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
				gClass = GClass24.gclass23_0[num4];
			}
			if (!gclass24_.bool_1[num4] || genum0_0 != (GEnum0)4)
			{
				for (int i = -num6; i + num6 < 512 && num6 + i < 512; i++)
				{
					if (i + num6 >= 0 && gClass.bool_0[num6 + i, num5] && (float)i == num)
					{
						if (bool_20)
						{
							method_8(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num5, num6 + i);
						}
						else
						{
							method_8(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num5, num6 + i);
						}
					}
				}
			}
			num2 = int_35 / 512;
			num3 = int_36 / 512 - 1;
			num5 = int_35 - num2 * 512;
			num6 = int_36 - num3 * 512;
			if (bool_20)
			{
				num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
				gClass = GClass24.gclass23_0[num4];
			}
			else
			{
				num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
				gClass = GClass24.gclass23_0[num4];
			}
			if (!gclass24_.bool_1[num4] || genum0_0 != (GEnum0)4)
			{
				for (int i = -num6; i + num6 <= 512 && num6 + i < 512; i++)
				{
					if (i + num6 >= 0 && gClass.bool_0[num6 + i, num5] && i > -76 && (float)i == num)
					{
						if (bool_20)
						{
							method_8(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num5, num6 + i);
						}
						else
						{
							method_8(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num5, num6 + i);
						}
					}
				}
			}
		}
		if (!(num > 1000f))
		{
		}
		float_16 = num;
		return num;
	}

	public void method_20(int int_35)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		float num2 = (float)Math.PI * 9f / 16f;
		bool flag = false;
		float num3 = 16f;
		for (int i = 0; i < GClass29.gclass24_0.gclass0_0.Length; i++)
		{
			if (GClass29.gclass24_0.gclass0_0[i] == null)
			{
				GClass1 gClass = new GClass1();
				gClass.bool_5 = true;
				gClass.vector2_0 = vector2_0 - new Vector2(0f, 20f);
				gClass.vector2_1 = new Vector2((float)Math.Cos(num2) * num3, (0f - (float)Math.Sin(num2)) * num3);
				if (flag)
				{
					ref Vector2 reference = ref gClass.vector2_1;
					reference.X *= -1f;
					num2 += (float)Math.PI / 8f;
				}
				flag = !flag;
				num++;
				if (num == 16)
				{
					num3 = 8f;
					num2 = (float)Math.PI * 9f / 16f;
				}
				GClass29.gclass24_0.gclass0_0[i] = gClass;
				if (num == int_35)
				{
					break;
				}
			}
		}
	}

	public void method_21(int int_35, int int_36)
	{
		if (!bool_7 && int_5 <= 0 && genum4_0 != (GEnum4)12 && genum4_0 != (GEnum4)11)
		{
			if (genum1_0 != 0)
			{
				genum1_0 = (GEnum1)0;
				vector2_1.Y = -16f;
				if ((int)vector2_0.X != int_35)
				{
					vector2_1.X = 2 * Math.Sign(vector2_0.X - (float)int_35) * 4;
				}
				else
				{
					vector2_1.X = -8f;
				}
				GClass30.soundEffect_9.Play(GClass30.float_0, 0f, 0f);
				int_24 = 0;
				genum4_0 = (GEnum4)11;
			}
			else if (int_17 > 0)
			{
				method_20(int_17);
				int_17 = 0;
				vector2_1.Y = -16f;
				if ((int)vector2_0.X != int_35)
				{
					vector2_1.X = 2 * Math.Sign(vector2_0.X - (float)int_35) * 4;
				}
				else
				{
					vector2_1.X = -8f;
				}
				GClass30.soundEffect_7.Play(GClass30.float_0, 0f, 0f);
				int_24 = 0;
				genum4_0 = (GEnum4)11;
			}
			else
			{
				vector2_1.Y = -28f;
				if (bool_16)
				{
					GClass30.soundEffect_9.Play(GClass30.float_0, 0f, 0f);
					bool_16 = false;
				}
				else
				{
					GClass30.soundEffect_3.Play(GClass30.float_0, 0f, 0f);
				}
				genum4_0 = (GEnum4)12;
			}
		}
		bool_16 = false;
	}

	public void method_22(int int_35)
	{
		if (int_29 > 0)
		{
			return;
		}
		bool_6 = false;
		if (vector2_1.Y < 0f)
		{
			ref Vector2 reference = ref vector2_1;
			reference.Y -= (float)Math.Sign(vector2_1.Y);
		}
		else if (vector2_0.Y - 80f < (float)int_35 || vector2_1.Y > 0f)
		{
			if (Math.Abs(vector2_1.Y) > 4f)
			{
				vector2_1.Y = 0f - Math.Abs(vector2_1.Y);
			}
			else
			{
				vector2_1.Y = -4f;
			}
		}
	}

	public void method_23()
	{
		switch (genum2_0)
		{
		case (GEnum2)0:
			float_4 = 0.1875f;
			float_6 = 0.1875f;
			float_7 = 24f;
			float_8 = 0.375f;
			float_9 = 0.875f;
			break;
		case (GEnum2)1:
			float_4 = 0.375f;
			float_6 = 0.375f;
			float_7 = 48f;
			float_8 = 0.75f;
			float_9 = 0.875f;
			int_2--;
			if (int_2 <= 0)
			{
				genum2_0 = (GEnum2)0;
				int_2 = 0;
			}
			break;
		case (GEnum2)2:
		case (GEnum2)3:
			break;
		}
	}

	public void method_24()
	{
		if (genum2_0 == (GEnum2)0 || genum2_0 == (GEnum2)1)
		{
			genum2_0 = (GEnum2)1;
			int_2 = 1200;
		}
	}

	private void method_25()
	{
		switch (genum0_0)
		{
		case (GEnum0)1:
			genum3_0 = (GEnum3)0;
			break;
		case (GEnum0)2:
			genum3_0 = (GEnum3)2;
			break;
		case (GEnum0)3:
			if (genum3_0 == (GEnum3)2)
			{
				genum3_0 = (GEnum3)1;
			}
			break;
		case (GEnum0)4:
			genum3_0 = (GEnum3)0;
			break;
		}
		int num = (int)vector2_0.X;
		int int_ = (int)vector2_0.Y;
		float_14 = 100000f;
		float num2 = 10000f;
		float num3 = 10000f;
		float num4 = 10000f;
		float num5 = 10000f;
		switch (genum0_0)
		{
		case (GEnum0)0:
			if (genum3_0 == (GEnum3)0 || genum3_0 == (GEnum3)2)
			{
				num2 = (float_18 = method_11(num - 36, int_));
				num3 = (float_19 = method_11(num + 36, int_));
				if (genum3_0 == (GEnum3)0 && (num2 > 600f || num3 > 600f))
				{
					genum3_0 = (GEnum3)1;
					num4 = (float_18 = method_11(num - 36, int_));
					num5 = (float_19 = method_11(num + 36, int_));
				}
			}
			if (genum3_0 == (GEnum3)1 || genum3_0 == (GEnum3)2)
			{
				num4 = (float_18 = method_13(num - 36, int_, bool_19: false, bool_20: false));
				num5 = (float_19 = method_13(num + 36, int_, bool_19: false, bool_20: false));
				if (genum3_0 == (GEnum3)1 && num4 > 600f && num5 > 600f)
				{
					genum3_0 = (GEnum3)0;
					num2 = (float_18 = method_11(num - 36, int_));
					num3 = (float_19 = method_11(num + 36, int_));
				}
			}
			if (float_18 < 80f || float_19 < 80f || num2 < 80f || num3 < 80f)
			{
				if (genum3_0 == (GEnum3)0)
				{
					if (float_18 < float_19)
					{
						float_14 = method_12(num - 36, int_, bool_19: true);
					}
					else
					{
						float_14 = (float_14 = method_12(num + 36, int_, bool_19: true));
					}
				}
				if (genum3_0 == (GEnum3)1)
				{
					if (float_18 < float_19)
					{
						float_14 = method_13(num - 36, int_, bool_19: true, bool_20: false);
					}
					else
					{
						float_14 = (float_14 = method_13(num + 36, int_, bool_19: true, bool_20: false));
					}
				}
				if (genum3_0 == (GEnum3)2)
				{
					if ((num2 <= num4 && !(num2 > num5)) || (num3 <= num4 && num3 <= num5))
					{
						if (num2 < num3)
						{
							float_14 = method_12(num - 36, int_, bool_19: true);
						}
						else
						{
							float_14 = (float_14 = method_12(num + 36, int_, bool_19: true));
						}
					}
					else if (float_18 < float_19)
					{
						float_14 = method_13(num - 36, int_, bool_19: true, bool_20: false);
					}
					else
					{
						float_14 = (float_14 = method_13(num + 36, int_, bool_19: true, bool_20: false));
					}
				}
			}
			else
			{
				float_20 = 0f;
			}
			if (bool_14 && (float)int_21 < float_14)
			{
				float_14 = int_21;
				float_20 = 0f;
			}
			break;
		case (GEnum0)1:
			num = (int)vector2_0.X + 80;
			int_ = (int)vector2_0.Y - 80;
			method_15(num, int_, bool_19: true);
			if (genum3_0 == (GEnum3)0 || genum3_0 == (GEnum3)2)
			{
				method_15(num, int_ - 36, bool_19: true);
				num2 = (float_18 = float_15);
				method_15(num, int_ + 36, bool_19: true);
				num3 = (float_19 = float_15);
			}
			if (genum3_0 == (GEnum3)1 || genum3_0 == (GEnum3)2)
			{
				method_16(num, int_ - 36, bool_19: true, bool_20: false);
				num4 = (float_18 = float_15);
				method_16(num, int_ + 36, bool_19: true, bool_20: false);
				num5 = (float_19 = float_15);
			}
			if (!(float_18 < 80f) && !(float_19 < 80f) && !(num2 < 80f) && !(num3 < 80f))
			{
				break;
			}
			if (genum3_0 == (GEnum3)0)
			{
				if (float_18 < float_19)
				{
					method_15(num, int_ - 36, bool_19: true);
					float_15 = float_19;
				}
				else
				{
					method_15(num, int_ + 36, bool_19: true);
					float_15 = float_18;
				}
			}
			if (genum3_0 == (GEnum3)1)
			{
				if (float_18 < float_19)
				{
					method_16(num, int_ - 36, bool_19: true, bool_20: false);
					float_15 = float_19;
				}
				else
				{
					method_16(num, int_ + 36, bool_19: true, bool_20: false);
					float_15 = float_18;
				}
			}
			if (genum3_0 == (GEnum3)2)
			{
				if (num2 < num3)
				{
					method_15(num, int_ - 36, bool_19: true);
					float_15 = num3;
				}
				else
				{
					method_15(num, int_ + 36, bool_19: true);
					float_15 = num2;
				}
			}
			break;
		case (GEnum0)2:
			float_14 = -9000f;
			num2 = -11000f;
			num3 = -12000f;
			num4 = -13000f;
			num5 = -14000f;
			num = (int)vector2_0.X;
			int_ = (int)vector2_0.Y - 160;
			if (genum3_0 == (GEnum3)0 || genum3_0 == (GEnum3)2)
			{
				method_18(num, int_, bool_19: true);
				num2 = (float_18 = method_17(num - 32, int_));
				num3 = (float_19 = method_17(num + 32, int_));
			}
			if (genum3_0 == (GEnum3)1 || genum3_0 == (GEnum3)2)
			{
				method_19(num, int_, bool_19: true, bool_20: true);
				num4 = (float_18 = method_19(num - 32, int_, bool_19: false, bool_20: false));
				num5 = (float_19 = method_19(num + 32, int_, bool_19: false, bool_20: false));
				if (num4 < -600f && num5 < -600f)
				{
				}
			}
			if (!(num4 > -80f) && !(num5 > -80f) && !(num2 > -80f) && !(num3 > -80f))
			{
				break;
			}
			if (genum3_0 == (GEnum3)0)
			{
				if (num2 > num3)
				{
					float_16 = method_19(num - 32, int_, bool_19: true, bool_20: true);
				}
				else
				{
					float_16 = method_19(num + 32, int_, bool_19: true, bool_20: true);
				}
			}
			if (genum3_0 == (GEnum3)1)
			{
				if (float_18 > float_19)
				{
					float_14 = (float_16 = method_19(num - 32, int_, bool_19: true, bool_20: false));
				}
				else
				{
					float_14 = (float_16 = method_19(num + 32, int_, bool_19: true, bool_20: false));
				}
			}
			if (genum3_0 != (GEnum3)2)
			{
				break;
			}
			if ((num2 >= num4 && !(num2 < num5)) || (num3 >= num4 && num3 >= num5))
			{
				if (num2 > num3)
				{
					float_16 = method_18(num - 32, int_, bool_19: true);
				}
				else
				{
					float_16 = method_18(num + 32, int_, bool_19: true);
				}
			}
			else if (num4 > num5)
			{
				float_16 = method_19(num - 32, int_, bool_19: true, bool_20: false);
			}
			else
			{
				float_16 = method_19(num + 32, int_, bool_19: true, bool_20: false);
			}
			break;
		case (GEnum0)3:
			num = (int)vector2_0.X - 80;
			int_ = (int)vector2_0.Y - 80;
			if (genum3_0 == (GEnum3)0 || genum3_0 == (GEnum3)2)
			{
				method_15(num, int_ + 36, bool_19: true);
				num2 = (float_18 = float_17);
				method_15(num, int_ - 36, bool_19: true);
				num3 = (float_19 = float_17);
			}
			if (genum3_0 == (GEnum3)1 || genum3_0 == (GEnum3)2)
			{
				method_16(num, int_ - 36, bool_19: true, bool_20: false);
				num4 = (float_18 = float_17);
				method_16(num, int_ + 36, bool_19: true, bool_20: false);
				num5 = (float_19 = float_17);
				if (genum3_0 == (GEnum3)1 && num4 < -600f && num5 < -600f)
				{
					genum3_0 = (GEnum3)0;
					method_15(num, int_ - 36, bool_19: true);
					num2 = (float_18 = float_17);
					method_15(num, int_ + 36, bool_19: true);
					num3 = (float_19 = float_17);
				}
			}
			if (!(float_18 < 80f) && !(float_19 < 80f) && !(num2 < 80f) && !(num3 < 80f))
			{
				break;
			}
			if (genum3_0 == (GEnum3)0)
			{
				if (float_18 < float_19)
				{
					method_15(num, int_ - 36, bool_19: true);
					float_17 = float_19;
				}
				else
				{
					method_15(num, int_ + 36, bool_19: true);
					float_17 = float_18;
				}
			}
			if (genum3_0 == (GEnum3)1)
			{
				if (float_18 > float_19)
				{
					float_14 = method_16(num, int_ - 36, bool_19: true, bool_20: false);
				}
				else
				{
					float_14 = (float_14 = method_16(num, int_ + 36, bool_19: true, bool_20: false));
				}
			}
			if (genum3_0 != (GEnum3)2)
			{
				break;
			}
			if ((num2 > num4 && !(num2 <= num5)) || (num3 > num4 && num3 > num5))
			{
				if (num2 < num3)
				{
					method_15(num, int_ - 36, bool_19: true);
					float_17 = num3;
				}
				else
				{
					method_15(num, int_ + 36, bool_19: true);
					float_17 = num2;
				}
			}
			else if (num4 < num5)
			{
				method_16(num, int_ - 36, bool_19: true, bool_20: false);
				float_17 = num5;
			}
			else
			{
				method_16(num, int_ + 36, bool_19: true, bool_20: false);
				float_17 = num4;
			}
			break;
		case (GEnum0)4:
		{
			if (genum3_0 == (GEnum3)0 || genum3_0 == (GEnum3)2)
			{
				float_14 = method_11(num, int_);
				float_18 = method_11(num - 36, int_);
				float_19 = method_11(num + 36, int_);
				if (float_18 < 80f || float_19 < 80f)
				{
					if (float_18 < float_19)
					{
						float_14 = method_12(num - 36, int_, bool_19: true);
					}
					else
					{
						float_14 = (float_14 = method_12(num + 36, int_, bool_19: true));
					}
				}
				else
				{
					float_20 = 0f;
				}
			}
			float num6 = float_14;
			float num7 = float_20;
			if (genum3_0 == (GEnum3)1 || genum3_0 == (GEnum3)2)
			{
				float_14 = method_13(num, int_, bool_19: false, bool_20: false);
				float_18 = method_13(num - 36, int_, bool_19: false, bool_20: false);
				float_19 = method_13(num + 36, int_, bool_19: false, bool_20: false);
				if (float_14 < num6)
				{
					if (float_18 < 80f || float_19 < 80f)
					{
						if (float_18 < float_19)
						{
							float_14 = method_13(num - 36, int_, bool_19: true, bool_20: false);
						}
						else
						{
							float_14 = (float_14 = method_13(num + 36, int_, bool_19: true, bool_20: false));
						}
					}
					else
					{
						float_20 = 0f;
					}
				}
				else
				{
					float_14 = num6;
					float_20 = num7;
				}
			}
			if (bool_14 && (float)int_21 < float_14)
			{
				float_14 = int_21;
				float_20 = 0f;
			}
			break;
		}
		}
	}

	private void method_26()
	{
		int num = (int)vector2_0.X;
		int num2 = (int)vector2_0.Y;
		float num3 = -1000f;
		float num4 = 1000f;
		switch (genum0_0)
		{
		case (GEnum0)0:
			if (genum3_0 == (GEnum3)0 || genum3_0 == (GEnum3)2)
			{
				method_14(num, num2 - 64);
				num3 = float_17;
				num4 = float_15;
			}
			if (genum3_0 == (GEnum3)1 || genum3_0 == (GEnum3)2)
			{
				method_16(num, num2 - 64, bool_19: false, bool_20: false);
			}
			if (genum3_0 == (GEnum3)2 || genum3_0 == (GEnum3)0)
			{
				if (num3 > float_17)
				{
					float_17 = num3;
				}
				if (num4 < float_15)
				{
					float_15 = num4;
				}
			}
			if (float_15 < 44f)
			{
				if (genum3_0 == (GEnum3)0)
				{
					float_18 = method_13(num + 16 - 36, num2, bool_19: false, bool_20: false);
					float_19 = method_13(num + 16 + 36, num2, bool_19: false, bool_20: false);
					if (float_18 < 64f || float_19 < 64f)
					{
						genum3_0 = (GEnum3)1;
					}
					else
					{
						vector2_0.X = (float)(int)vector2_0.X - (44f - float_15);
						bool_11 = true;
						float_3 = 0f;
						vector2_1.X = 0f;
					}
				}
				else
				{
					vector2_0.X = (float)(int)vector2_0.X - (44f - float_15);
					bool_11 = true;
					float_3 = 0f;
					vector2_1.X = 0f;
				}
			}
			if (float_17 > -44f)
			{
				if (genum3_0 == (GEnum3)0)
				{
					float_18 = method_13(num + 16 - 36, num2, bool_19: false, bool_20: false);
					float_19 = method_13(num + 16 + 36, num2, bool_19: false, bool_20: false);
					if (float_18 < 64f || float_19 < 64f)
					{
						genum3_0 = (GEnum3)1;
					}
					else
					{
						vector2_0.X = (float)(int)vector2_0.X + (44f + float_17);
						bool_11 = true;
						float_3 = 0f;
						vector2_1.X = 0f;
					}
				}
				else
				{
					vector2_0.X = (float)(int)vector2_0.X + (44f + float_17);
					bool_11 = true;
					float_3 = 0f;
					vector2_1.X = 0f;
				}
			}
			if (float_17 > -48f && int_6 <= 0)
			{
				bool_11 = false;
			}
			if (float_15 < 48f && int_7 <= 0)
			{
				bool_11 = false;
			}
			break;
		case (GEnum0)1:
			float_14 = method_11(num + 32, num2);
			break;
		case (GEnum0)3:
			float_14 = method_11(num - 32, num2);
			break;
		case (GEnum0)4:
			if (genum3_0 == (GEnum3)0 || genum3_0 == (GEnum3)2)
			{
				method_14(num, num2 - 64);
			}
			num3 = float_17;
			num4 = float_15;
			if (genum3_0 == (GEnum3)1 || genum3_0 == (GEnum3)2)
			{
				method_16(num, num2 - 64, bool_19: false, bool_20: false);
			}
			if (float_17 < num3)
			{
				float_17 = num3;
			}
			if (float_15 > num4)
			{
				float_15 = num4;
			}
			if (float_15 < 44f)
			{
				vector2_0.X = (float)(int)vector2_0.X - (44f - float_15);
				bool_11 = true;
				float_3 = 0f;
				vector2_1.X = 0f;
			}
			if (float_17 > -44f)
			{
				vector2_0.X = (float)(int)vector2_0.X + (44f + float_17);
				bool_11 = true;
				float_3 = 0f;
				vector2_1.X = 0f;
			}
			break;
		}
		if ((float_17 < -48f && int_7 == 0) || (float_15 > 48f && int_6 == 0))
		{
			bool_11 = false;
		}
		if (float_11 < -48f && int_7 == 0)
		{
			bool_12 = false;
		}
		if (float_12 > 48f && int_6 == 0)
		{
			bool_13 = false;
		}
		if (!bool_10)
		{
			bool_11 = false;
			bool_12 = false;
			bool_13 = false;
		}
		if (bool_12 || bool_13)
		{
			genum4_0 = (GEnum4)0;
		}
	}

	private void method_27()
	{
	}

	public void method_28()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		gclass33_16 = gclass33_0;
		genum4_0 = (GEnum4)0;
		vector2_0 = new Vector2(7132f, 6400f);
		int_28 = 0;
		float_27 = 0f;
		bool_0 = true;
		float_3 = 0f;
		int_17 = 0;
		genum4_0 = (GEnum4)0;
		genum2_0 = (GEnum2)0;
		genum1_0 = (GEnum1)0;
		bool_15 = false;
		bool_17 = false;
		bool_18 = false;
	}

	private void method_29()
	{
		method_25();
		method_5();
		method_26();
		if (Math.Abs(float_3) > 0.01f)
		{
			genum4_0 = (GEnum4)1;
		}
		if (!bool_12 && !bool_11 && int_6 > 0 && int_7 == 0)
		{
			bool_0 = false;
			genum4_0 = (GEnum4)1;
		}
		if (!bool_13 && !bool_11 && int_7 > 0 && int_6 == 0)
		{
			bool_0 = true;
			genum4_0 = (GEnum4)1;
		}
		switch (genum0_0)
		{
		case (GEnum0)0:
			if (float_14 >= 0f && vector2_1.Y >= 0f)
			{
				if (float_14 <= 80f)
				{
					vector2_1.Y = 0f;
					ref Vector2 reference = ref vector2_0;
					reference.Y += float_14;
				}
				else
				{
					vector2_1.Y = 0f;
					genum4_0 = (GEnum4)9;
				}
			}
			if (float_14 < 0f && float_14 > -80f)
			{
				ref Vector2 reference2 = ref vector2_0;
				reference2.Y += float_14;
			}
			break;
		}
		if (int_6 == 0 && int_7 == 0)
		{
			bool_11 = false;
			bool_12 = false;
			bool_13 = false;
		}
		if (int_9 > 0)
		{
			genum4_0 = (GEnum4)4;
		}
		if (int_8 > 0)
		{
			genum4_0 = (GEnum4)7;
		}
		if (int_10 == 1 || int_11 == 1 || int_12 == 1)
		{
			genum4_0 = (GEnum4)3;
			ref Vector2 reference3 = ref vector2_1;
			reference3.X += 26f * (float)Math.Sin(float_20);
			ref Vector2 reference4 = ref vector2_1;
			reference4.Y -= 26f * (float)Math.Cos(float_20);
			bool_6 = false;
			bool_5 = true;
			GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
		}
	}

	private void method_30()
	{
		if (genum0_0 != (GEnum0)2)
		{
		}
		method_25();
		method_5();
		method_26();
		if (Math.Abs(float_3) > 23.9999f)
		{
			genum4_0 = (GEnum4)2;
		}
		if (int_9 > 0)
		{
			if ((double)Math.Abs(float_3) > 4.125)
			{
				GClass30.soundEffect_8.Play(GClass30.float_0, 0f, 0f);
				genum4_0 = (GEnum4)5;
			}
			else
			{
				genum4_0 = (GEnum4)4;
			}
		}
		if (int_10 == 1 || int_11 == 1 || int_12 == 1)
		{
			genum4_0 = (GEnum4)3;
			ref Vector2 reference = ref vector2_1;
			reference.X += 26f * (float)Math.Sin(float_20);
			ref Vector2 reference2 = ref vector2_1;
			reference2.Y += -26f * (float)Math.Cos(float_20);
			bool_5 = true;
			GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
		}
		switch (genum0_0)
		{
		case (GEnum0)0:
			if (float_14 >= 0f && vector2_1.Y >= 0f)
			{
				if (float_14 <= 64f)
				{
					vector2_1.Y = 0f;
					ref Vector2 reference9 = ref vector2_0;
					reference9.Y += float_14;
				}
				else
				{
					vector2_1.Y = 0f;
					genum4_0 = (GEnum4)9;
				}
			}
			if (-64f < float_14 && float_14 < 0f)
			{
				ref Vector2 reference10 = ref vector2_0;
				reference10.Y += float_14;
			}
			break;
		case (GEnum0)1:
			if (float_15 >= 0f && (double)vector2_1.X >= -0.1)
			{
				if (float_15 <= 64f)
				{
					vector2_1.X = 0f;
					ref Vector2 reference7 = ref vector2_0;
					reference7.X += float_15;
				}
				else
				{
					vector2_1.X = 0f;
					genum4_0 = (GEnum4)9;
				}
			}
			if (-64f < float_15 && float_15 < 0f)
			{
				ref Vector2 reference8 = ref vector2_0;
				reference8.X += float_15;
			}
			break;
		case (GEnum0)2:
			if (float_16 <= 0f && vector2_1.Y <= 0f)
			{
				if (float_16 >= 64f)
				{
					vector2_1.Y = 0f;
					ref Vector2 reference5 = ref vector2_0;
					reference5.Y += float_16;
				}
				else
				{
					vector2_1.Y = 0f;
				}
			}
			if (0f < float_16 && float_16 < 64f)
			{
				ref Vector2 reference6 = ref vector2_0;
				reference6.Y += float_16;
			}
			if (float_16 < -80f)
			{
				vector2_1.Y = 0f;
				genum4_0 = (GEnum4)9;
			}
			break;
		case (GEnum0)3:
			if (float_17 <= 0f && (double)vector2_1.X <= 0.1)
			{
				if (float_17 >= -80f)
				{
					vector2_1.X = 0f;
					ref Vector2 reference3 = ref vector2_0;
					reference3.X += float_17;
				}
				else
				{
					vector2_1.X = 0f;
					genum4_0 = (GEnum4)9;
				}
			}
			if (0f < float_17 && float_17 < 80f)
			{
				ref Vector2 reference4 = ref vector2_0;
				reference4.X += float_17;
			}
			break;
		}
		if (genum4_0 == (GEnum4)1 && genum0_0 != 0 && (double)Math.Abs(float_3) < 10.0)
		{
			if ((double)(0f - float_20) < Math.PI * -499.0 / 1000.0 || (double)(0f - float_20) > Math.PI * 499.0 / 1000.0)
			{
				float_3 = 0f;
				genum4_0 = (GEnum4)9;
			}
			else
			{
				if ((double)(0f - float_20) > Math.PI * -13.0 / 25.0 && 0f - float_20 < 0f)
				{
					int_31 = 30;
				}
				if ((double)(0f - float_20) < Math.PI * 13.0 / 25.0 && 0f - float_20 > 0f)
				{
					int_32 = 30;
				}
			}
		}
		if (genum4_0 == (GEnum4)1)
		{
			if (int_26 < 1)
			{
				gclass33_16.int_1 += 8;
				int_26++;
			}
			else if (int_25 != gclass33_16.int_2)
			{
				if (Math.Abs(float_3) > 3.3333333f)
				{
					gclass33_16.int_1 += Math.Max(0, (int)(5f / 6f * Math.Abs(float_3) / 4f));
				}
				int_25 = gclass33_16.int_2;
			}
		}
		else
		{
			float_21 = 0f;
			int_26 = 0;
		}
		if (genum4_0 == (GEnum4)9)
		{
			int_33 = (int)((double)float_20 / (Math.PI / 32.0));
			int_34 = 8;
		}
	}

	private void method_31()
	{
		method_25();
		method_5();
		method_26();
		if (Math.Abs(float_3) < 20f + 0f * (float_7 - 0.1f))
		{
			genum4_0 = (GEnum4)1;
		}
		if (int_9 > 0 && (double)Math.Abs(float_3) > 4.125)
		{
			GClass30.soundEffect_8.Play(GClass30.float_0, 0f, 0f);
			genum4_0 = (GEnum4)5;
		}
		if (int_10 == 1 || int_11 == 1 || int_12 == 1)
		{
			genum4_0 = (GEnum4)3;
			ref Vector2 reference = ref vector2_1;
			reference.X -= -26f * (float)Math.Sin(float_20);
			ref Vector2 reference2 = ref vector2_1;
			reference2.Y -= 26f * (float)Math.Cos(float_20);
			bool_5 = true;
			GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
		}
		switch (genum0_0)
		{
		case (GEnum0)0:
			if (float_14 >= 0f && vector2_1.Y >= 0f)
			{
				if (float_14 <= 64f)
				{
					vector2_1.Y = 0f;
					ref Vector2 reference9 = ref vector2_0;
					reference9.Y += float_14;
				}
				else
				{
					vector2_1.Y = 0f;
					genum4_0 = (GEnum4)10;
				}
			}
			if (float_14 < 0f && float_14 > -64f)
			{
				ref Vector2 reference10 = ref vector2_0;
				reference10.Y += float_14;
			}
			break;
		case (GEnum0)1:
			if (float_15 >= 0f && (double)vector2_1.X >= -0.1)
			{
				if (float_15 <= 80f)
				{
					vector2_1.X = 0f;
					ref Vector2 reference7 = ref vector2_0;
					reference7.X += float_15;
				}
				else
				{
					vector2_1.X = 0f;
					genum4_0 = (GEnum4)10;
				}
			}
			if (-80f < float_15 && float_15 < 0f)
			{
				ref Vector2 reference8 = ref vector2_0;
				reference8.X += float_15;
			}
			break;
		case (GEnum0)2:
			if (float_16 <= 0f && vector2_1.Y <= 0f)
			{
				if (float_16 >= 64f)
				{
					vector2_1.Y = 0f;
					ref Vector2 reference5 = ref vector2_0;
					reference5.Y += float_16;
				}
				else
				{
					vector2_1.Y = 0f;
				}
			}
			if (float_16 > 0f && float_16 < 64f)
			{
				ref Vector2 reference6 = ref vector2_0;
				reference6.Y += float_16;
			}
			if (float_16 < -80f)
			{
				vector2_1.Y = 0f;
				genum4_0 = (GEnum4)10;
			}
			break;
		case (GEnum0)3:
			if (float_17 <= 0f && (double)vector2_1.X <= 0.1)
			{
				if (float_17 >= -80f)
				{
					vector2_1.X = 0f;
					ref Vector2 reference3 = ref vector2_0;
					reference3.X += float_17;
				}
				else
				{
					vector2_1.X = 0f;
					genum4_0 = (GEnum4)10;
				}
			}
			if (0f < float_17 && float_17 < 80f)
			{
				ref Vector2 reference4 = ref vector2_0;
				reference4.X += float_17;
			}
			break;
		}
		float_21 = 0f;
		if (genum4_0 == (GEnum4)10)
		{
			int_33 = (int)((double)float_20 / (Math.PI / 32.0));
			int_34 = 8;
		}
	}

	private void method_32()
	{
		method_25();
		method_6();
		method_26();
		if (int_10 == 1 || int_11 == 1 || int_12 == 1)
		{
			genum4_0 = (GEnum4)3;
			ref Vector2 reference = ref vector2_1;
			reference.X += 26f * (float)Math.Sin(float_20);
			ref Vector2 reference2 = ref vector2_1;
			reference2.Y += -26f * (float)Math.Cos(float_20);
			bool_5 = true;
			GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
		}
		switch (genum0_0)
		{
		case (GEnum0)0:
			if (float_14 >= 0f && vector2_1.Y >= 0f)
			{
				if (float_14 <= 80f)
				{
					vector2_1.Y = 0f;
					ref Vector2 reference9 = ref vector2_0;
					reference9.Y += float_14;
				}
				else
				{
					vector2_1.Y = 0f;
					genum4_0 = (GEnum4)3;
				}
			}
			if (float_14 < 0f && float_14 > -80f)
			{
				ref Vector2 reference10 = ref vector2_0;
				reference10.Y += float_14;
			}
			break;
		case (GEnum0)1:
			if (float_15 >= 0f && (double)vector2_1.X >= -0.1)
			{
				if (float_15 <= 80f)
				{
					vector2_1.X = 0f;
					ref Vector2 reference7 = ref vector2_0;
					reference7.X += float_15;
				}
				else
				{
					vector2_1.X = 0f;
					genum4_0 = (GEnum4)3;
				}
			}
			if (-80f < float_15 && float_15 < 0f)
			{
				ref Vector2 reference8 = ref vector2_0;
				reference8.X += float_15;
			}
			break;
		case (GEnum0)2:
			if (float_16 <= 0f && vector2_1.Y <= 0f)
			{
				if (float_16 >= 64f)
				{
					vector2_1.Y = 0f;
					ref Vector2 reference5 = ref vector2_0;
					reference5.Y += float_16;
				}
				else
				{
					vector2_1.Y = 0f;
				}
			}
			if (0f < float_16 && float_16 < 64f)
			{
				ref Vector2 reference6 = ref vector2_0;
				reference6.Y += float_16;
			}
			if (float_16 < -80f)
			{
				vector2_1.Y = 0f;
				genum4_0 = (GEnum4)9;
			}
			break;
		case (GEnum0)3:
			if (float_17 <= 0f && (double)vector2_1.X <= 0.1)
			{
				if (float_17 >= -80f)
				{
					vector2_1.X = 0f;
					ref Vector2 reference3 = ref vector2_0;
					reference3.X += float_17;
				}
				else
				{
					vector2_1.X = 0f;
					genum4_0 = (GEnum4)3;
				}
			}
			if (0f < float_17 && float_17 < 80f)
			{
				ref Vector2 reference4 = ref vector2_0;
				reference4.X += float_17;
			}
			break;
		}
		if (genum4_0 == (GEnum4)5 && genum0_0 != 0 && (double)Math.Abs(float_3) < 10.0 && ((double)(0f - float_20) < Math.PI * -499.0 / 1000.0 || (double)(0f - float_20) > Math.PI * 499.0 / 1000.0))
		{
			float_3 = 0f;
			genum4_0 = (GEnum4)3;
		}
		if (genum4_0 == (GEnum4)5)
		{
			if (float_21 >= 20f)
			{
				float_21 -= 20f;
			}
			else
			{
				gclass33_16.int_1--;
			}
			if (Math.Abs(float_3) < 20f)
			{
				if (Math.Abs(float_3) < 4f)
				{
					float_21 += 4f;
				}
				else
				{
					float_21 += Math.Abs(float_3);
				}
			}
			else
			{
				float_21 += 20f;
			}
		}
		else
		{
			float_21 = 0f;
		}
	}

	private void method_33()
	{
		if (int_6 > 0)
		{
			bool_0 = false;
			ref Vector2 reference = ref vector2_1;
			reference.X -= float_8;
		}
		if (int_7 > 0)
		{
			bool_0 = true;
			ref Vector2 reference2 = ref vector2_1;
			reference2.X += float_8;
		}
		if (bool_6 && vector2_1.Y < -16f)
		{
			vector2_1.Y = -16f;
		}
		method_17((int)vector2_0.X, (int)(vector2_0.Y - 116f));
		if (-4f < float_16 && vector2_1.Y < 0f)
		{
			ref Vector2 reference3 = ref vector2_0;
			reference3.Y += 0f - float_16 + 4f;
			vector2_1.Y = 0f;
		}
		if ((int_10 == 1 || int_11 == 1 || int_12 == 1) && bool_5 && vector2_1.Y >= -16f)
		{
			switch (genum1_0)
			{
			case (GEnum1)0:
				GClass30.soundEffect_18.Play(GClass30.float_0, 0f, 0f);
				break;
			case (GEnum1)1:
				if (bool_0)
				{
					vector2_1.X = 36f;
				}
				else
				{
					vector2_1.X = -36f;
				}
				vector2_1.Y = 0f;
				GClass30.soundEffect_4.Play(GClass30.float_0, 0f, 0f);
				break;
			case (GEnum1)2:
				vector2_1.X = 0f;
				vector2_1.Y = 32f;
				GClass30.soundEffect_2.Play(GClass30.float_0, 0f, 0f);
				break;
			case (GEnum1)3:
				vector2_1.Y = -22f;
				GClass30.soundEffect_5.Play(GClass30.float_0, 0f, 0f);
				break;
			}
			bool_4 = true;
			bool_5 = false;
			int_3 = 0;
		}
		if (vector2_1.X < 0f - float_7)
		{
			vector2_1.X = 0f - float_7;
		}
		if (vector2_1.X > float_7)
		{
			vector2_1.X = float_7;
		}
		if (vector2_1.Y > 64f)
		{
			vector2_1.Y = 64f;
		}
		if (vector2_1.Y < 0f && vector2_1.Y > -16f && (double)Math.Abs(vector2_1.X) > 0.5)
		{
			ref Vector2 reference4 = ref vector2_1;
			reference4.X *= 31f / 32f;
		}
		ref Vector2 reference5 = ref vector2_1;
		reference5.Y += float_9;
		ref Vector2 reference6 = ref vector2_0;
		reference6.X += vector2_1.X;
		ref Vector2 reference7 = ref vector2_0;
		reference7.Y += vector2_1.Y;
		method_26();
		method_25();
		if (float_14 > -64f && float_14 <= 0f && vector2_1.Y >= 0f)
		{
			if (1208.5828491040802 > (double)Math.Abs(float_20))
			{
				float_3 = vector2_1.X;
			}
			else if (2497.7378881484324 > (double)Math.Abs(float_20))
			{
				if (Math.Abs(vector2_1.X) > vector2_1.Y)
				{
					float_3 = vector2_1.X;
				}
				else
				{
					float_3 = (float)((double)vector2_1.Y * 0.5 * (double)(-Math.Sign(Math.Cos(float_20))));
				}
			}
			else if (5076.047966237137 > (double)Math.Abs(float_20))
			{
				if (Math.Abs(vector2_1.X) > vector2_1.Y)
				{
					float_3 = vector2_1.X;
				}
				else
				{
					float_3 = vector2_1.Y * (0f - (float)Math.Sign(Math.Cos(float_20)));
				}
			}
			vector2_1.Y = 0f;
			ref Vector2 reference8 = ref vector2_0;
			reference8.Y += float_14;
			genum4_0 = (GEnum4)1;
			if (bool_4 && !bool_5 && genum1_0 == (GEnum1)2)
			{
				vector2_1.Y = -30f;
				if (int_10 > 0 || int_11 > 0 || int_12 > 0)
				{
					bool_6 = false;
				}
				genum4_0 = (GEnum4)3;
				GClass30.soundEffect_2.Play(GClass30.float_0, 0f, 0f);
				bool_5 = true;
			}
		}
		else
		{
			float_3 = 0f;
		}
	}

	private void method_34()
	{
		if (int_6 > 0)
		{
			bool_0 = false;
			ref Vector2 reference = ref vector2_1;
			reference.X -= float_8;
		}
		if (int_7 > 0)
		{
			bool_0 = true;
			ref Vector2 reference2 = ref vector2_1;
			reference2.X += float_8;
		}
		if (vector2_1.X < -24f)
		{
			vector2_1.X = -24f;
		}
		if (vector2_1.X > 24f)
		{
			vector2_1.X = 24f;
		}
		if (vector2_1.Y > 64f)
		{
			vector2_1.Y = 64f;
		}
		if (vector2_1.Y < 0f && vector2_1.Y > -16f && (double)Math.Abs(vector2_1.X) > 0.5)
		{
			ref Vector2 reference3 = ref vector2_1;
			reference3.X *= 31f / 32f;
		}
		ref Vector2 reference4 = ref vector2_1;
		reference4.Y += float_9;
		ref Vector2 reference5 = ref vector2_0;
		reference5.X += vector2_1.X;
		ref Vector2 reference6 = ref vector2_0;
		reference6.Y += vector2_1.Y;
		method_26();
		method_25();
		method_17((int)vector2_0.X, (int)vector2_0.Y);
		if (float_16 > -160f && vector2_1.Y < 0f)
		{
			ref Vector2 reference7 = ref vector2_0;
			reference7.Y -= float_16 + 160f;
			vector2_1.Y = 0f;
		}
		if (float_14 > -64f && float_14 <= 0f && vector2_1.Y >= 0f)
		{
			if (1208.5828491040802 > (double)Math.Abs(float_20))
			{
				float_3 = vector2_1.X;
			}
			else if (2497.7378881484324 > (double)Math.Abs(float_20))
			{
				if (Math.Abs(vector2_1.X) > vector2_1.Y)
				{
					float_3 = vector2_1.X;
				}
				else
				{
					float_3 = (float)((double)vector2_1.Y * 0.5 * (double)(-Math.Sign(Math.Cos(float_20))));
				}
			}
			else if (5076.047966237137 > (double)Math.Abs(float_20))
			{
				if (Math.Abs(vector2_1.X) > vector2_1.Y)
				{
					float_3 = vector2_1.X;
				}
				else
				{
					float_3 = vector2_1.Y * (0f - (float)Math.Sign(Math.Cos(float_20)));
				}
			}
			vector2_1.Y = 0f;
			ref Vector2 reference8 = ref vector2_0;
			reference8.Y += float_14;
			genum4_0 = (GEnum4)1;
		}
		else
		{
			float_3 = 0f;
		}
		if (genum4_0 == (GEnum4)8 && vector2_1.Y >= 0f)
		{
			genum4_0 = (GEnum4)9;
		}
	}

	private void method_35()
	{
		if (int_6 > 0)
		{
			bool_0 = false;
			ref Vector2 reference = ref vector2_1;
			reference.X -= float_8;
		}
		if (int_7 > 0)
		{
			bool_0 = true;
			ref Vector2 reference2 = ref vector2_1;
			reference2.X += float_8;
		}
		if (vector2_1.X < -24f)
		{
			vector2_1.X = -24f;
		}
		if (vector2_1.X > 24f)
		{
			vector2_1.X = 24f;
		}
		if (vector2_1.Y > 64f)
		{
			vector2_1.Y = 64f;
		}
		if (vector2_1.Y < 0f && vector2_1.Y > -16f && (double)Math.Abs(vector2_1.X) > 0.5)
		{
			ref Vector2 reference3 = ref vector2_1;
			reference3.X *= 31f / 32f;
		}
		ref Vector2 reference4 = ref vector2_1;
		reference4.Y += float_9;
		ref Vector2 reference5 = ref vector2_0;
		reference5.X += vector2_1.X;
		ref Vector2 reference6 = ref vector2_0;
		reference6.Y += vector2_1.Y;
		method_17((int)vector2_0.X, (int)(vector2_0.Y - 156f));
		if (-4f < float_16 && vector2_1.Y < 0f)
		{
			ref Vector2 reference7 = ref vector2_0;
			reference7.Y += 0f - float_16 + 4f;
			vector2_1.Y = 0f;
		}
		method_26();
		method_25();
		method_17((int)vector2_0.X, (int)vector2_0.Y);
		if (float_16 > -120f && vector2_1.Y < 0f)
		{
			ref Vector2 reference8 = ref vector2_0;
			reference8.Y -= float_16 + 120f;
			vector2_1.Y = 0f;
		}
		if (-64f < float_14 && float_14 <= 4f && vector2_1.Y >= 0f)
		{
			if (1208.5828491040802 > (double)Math.Abs(float_20))
			{
				float_3 = vector2_1.X;
			}
			else if (2497.7378881484324 > (double)Math.Abs(float_20))
			{
				if (Math.Abs(vector2_1.X) > vector2_1.Y)
				{
					float_3 = vector2_1.X;
				}
				else
				{
					float_3 = (float)((double)vector2_1.Y * 0.5 * (double)(-Math.Sign(Math.Cos(float_20))));
				}
			}
			else if (5076.047966237137 > (double)Math.Abs(float_20))
			{
				if (Math.Abs(vector2_1.X) > vector2_1.Y)
				{
					float_3 = vector2_1.X;
				}
				else
				{
					float_3 = vector2_1.Y * (0f - (float)Math.Sign(Math.Cos(float_20)));
				}
			}
			vector2_1.Y = 0f;
			ref Vector2 reference9 = ref vector2_0;
			reference9.Y += float_14;
			genum4_0 = (GEnum4)1;
		}
		else
		{
			float_3 = 0f;
		}
		if (genum4_0 == (GEnum4)8 && vector2_1.Y < 0f)
		{
			genum4_0 = (GEnum4)8;
		}
	}

	private void method_36()
	{
		if (int_6 > 0)
		{
			bool_0 = false;
			ref Vector2 reference = ref vector2_1;
			reference.X -= float_8;
		}
		if (int_7 > 0)
		{
			bool_0 = true;
			ref Vector2 reference2 = ref vector2_1;
			reference2.X += float_8;
		}
		if (vector2_1.X < -24f)
		{
			vector2_1.X = -24f;
		}
		if (vector2_1.X > 24f)
		{
			vector2_1.X = 24f;
		}
		if (vector2_1.Y > 64f)
		{
			vector2_1.Y = 64f;
		}
		if (vector2_1.Y < 0f && vector2_1.Y > -16f && (double)Math.Abs(vector2_1.X) > 0.5)
		{
			ref Vector2 reference3 = ref vector2_1;
			reference3.X *= 31f / 32f;
		}
		ref Vector2 reference4 = ref vector2_1;
		reference4.Y += float_9;
		ref Vector2 reference5 = ref vector2_0;
		reference5.X += vector2_1.X;
		ref Vector2 reference6 = ref vector2_0;
		reference6.Y += vector2_1.Y;
		method_17((int)vector2_0.X, (int)(vector2_0.Y - 156f));
		if (-4f < float_16 && vector2_1.Y < 0f)
		{
			ref Vector2 reference7 = ref vector2_0;
			reference7.Y += 0f - float_16 + 4f;
			vector2_1.Y = 0f;
		}
		method_26();
		method_25();
		method_17((int)vector2_0.X, (int)vector2_0.Y);
		if (float_16 > -120f && vector2_1.Y < 0f)
		{
			ref Vector2 reference8 = ref vector2_0;
			reference8.Y -= float_16 + 120f;
			vector2_1.Y = 0f;
		}
		if (-64f < float_14 && float_14 <= 4f && vector2_1.Y >= 0f)
		{
			if (1208.5828491040802 > (double)Math.Abs(float_20))
			{
				float_3 = vector2_1.X;
			}
			else if (2497.7378881484324 > (double)Math.Abs(float_20))
			{
				if (Math.Abs(vector2_1.X) > vector2_1.Y)
				{
					float_3 = vector2_1.X;
				}
				else
				{
					float_3 = (float)((double)vector2_1.Y * 0.5 * (double)(-Math.Sign(Math.Cos(float_20))));
				}
			}
			else if (5076.047966237137 > (double)Math.Abs(float_20))
			{
				if (Math.Abs(vector2_1.X) > vector2_1.Y)
				{
					float_3 = vector2_1.X;
				}
				else
				{
					float_3 = vector2_1.Y * (0f - (float)Math.Sign(Math.Cos(float_20)));
				}
			}
			vector2_1.Y = 0f;
			ref Vector2 reference9 = ref vector2_0;
			reference9.Y += float_14;
			genum4_0 = (GEnum4)1;
		}
		else
		{
			float_3 = 0f;
		}
		if (genum4_0 == (GEnum4)8 && vector2_1.Y < 0f)
		{
			genum4_0 = (GEnum4)8;
		}
	}

	public override void Update()
	{
		if (bool_17)
		{
			return;
		}
		string_0 = "";
		string_1 = "";
		if (genum0_0 != (GEnum0)4)
		{
			bool_4 = false;
		}
		int_4++;
		int_24++;
		float_16 = -80000f;
		method_3();
		method_23();
		if (int_17 >= 100 && !bool_15)
		{
			GClass30.soundEffect_19.Play(GClass30.float_0, 0f, 0f);
			GClass26.gclass29_0.int_19 = GClass26.gclass29_0.int_20 + 180;
			bool_15 = true;
			int_18++;
		}
		if (vector2_0.Y < 0f)
		{
			genum4_0 = (GEnum4)9;
			genum0_0 = (GEnum0)4;
		}
		if (bool_4 && genum1_0 == (GEnum1)0 && int_3 < 6)
		{
			int_29 = 80;
		}
		else
		{
			int_29 = 0;
		}
		if (int_30 > 0)
		{
			int_30--;
			int_7 = 0;
			int_6 = 0;
		}
		if (int_31 > 0)
		{
			int_31--;
			int_6 = 0;
		}
		if (int_32 > 0)
		{
			int_32--;
			int_7 = 0;
		}
		switch (genum4_0)
		{
		case (GEnum4)0:
			method_29();
			break;
		case (GEnum4)1:
			method_30();
			break;
		case (GEnum4)2:
			method_31();
			break;
		case (GEnum4)3:
			method_33();
			break;
		case (GEnum4)4:
			if (int_9 == 0)
			{
				genum4_0 = (GEnum4)0;
			}
			if (int_6 > 0)
			{
				bool_0 = false;
			}
			if (int_7 > 0)
			{
				bool_0 = true;
			}
			if (genum4_0 == (GEnum4)4 && (int_10 == 1 || int_11 == 1 || int_12 == 1))
			{
				genum4_0 = (GEnum4)6;
				GClass30.soundEffect_10.Play(GClass30.float_0, 0f, 0f);
			}
			break;
		case (GEnum4)5:
			method_32();
			break;
		case (GEnum4)6:
			if (int_6 > 0)
			{
				bool_0 = false;
			}
			if (int_7 > 0)
			{
				bool_0 = true;
			}
			if (int_10 == 1 || int_11 == 1 || int_12 == 1)
			{
				GClass30.soundEffect_10.Play(GClass30.float_0, 0f, 0f);
			}
			if (int_9 == 0)
			{
				int num = 0;
				if (bool_0)
				{
					float_3 = (8 + num) * 4;
				}
				if (!bool_0)
				{
					float_3 -= (8 + num) * 4;
				}
				GClass30.soundEffect_20.Play(GClass30.float_0, 0f, 0f);
				genum4_0 = (GEnum4)5;
			}
			break;
		case (GEnum4)7:
			if (int_8 == 0)
			{
				genum4_0 = (GEnum4)0;
			}
			if (int_6 > 0)
			{
				bool_0 = false;
			}
			if (int_7 > 0)
			{
				bool_0 = true;
			}
			else if (int_10 == 1 || int_11 == 1 || int_12 == 1)
			{
				genum4_0 = (GEnum4)3;
				ref Vector2 reference6 = ref vector2_1;
				reference6.X -= -26f * (float)Math.Sin(float_20);
				ref Vector2 reference7 = ref vector2_1;
				reference7.Y -= 26f * (float)Math.Cos(float_20);
				bool_5 = true;
				GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
			}
			break;
		case (GEnum4)8:
			method_34();
			break;
		case (GEnum4)9:
			method_35();
			break;
		case (GEnum4)10:
			method_36();
			break;
		case (GEnum4)11:
		{
			if (vector2_1.X < -24f)
			{
				vector2_1.X = -24f;
			}
			if (vector2_1.X > 24f)
			{
				vector2_1.X = 24f;
			}
			if (vector2_1.Y > 64f)
			{
				vector2_1.Y = 64f;
			}
			if (vector2_1.Y < 0f && vector2_1.Y > -16f && (double)Math.Abs(vector2_1.X) > 0.5)
			{
				ref Vector2 reference = ref vector2_1;
				reference.X *= 31f / 32f;
			}
			ref Vector2 reference2 = ref vector2_1;
			reference2.Y += 0.75f;
			ref Vector2 reference3 = ref vector2_0;
			reference3.X += vector2_1.X;
			ref Vector2 reference4 = ref vector2_0;
			reference4.Y += vector2_1.Y;
			method_25();
			method_26();
			if (float_14 > -64f && float_14 <= 0f && vector2_1.Y >= 0f)
			{
				if (1208.5828491040802 > (double)Math.Abs(float_20))
				{
					float_3 = vector2_1.X;
				}
				else if (2497.7378881484324 > (double)Math.Abs(float_20))
				{
					if (Math.Abs(vector2_1.X) > vector2_1.Y)
					{
						float_3 = vector2_1.X;
					}
					else
					{
						float_3 = (float)((double)vector2_1.Y * 0.5 * (double)(-Math.Sign(Math.Cos(float_20))));
					}
				}
				else if (5076.047966237137 > (double)Math.Abs(float_20))
				{
					if (Math.Abs(vector2_1.X) > vector2_1.Y)
					{
						float_3 = vector2_1.X;
					}
					else
					{
						float_3 = vector2_1.Y * (0f - (float)Math.Sign(Math.Cos(float_20)));
					}
				}
				float_3 = 0f;
				vector2_1.Y = 0f;
				ref Vector2 reference5 = ref vector2_0;
				reference5.Y += float_14;
				genum4_0 = (GEnum4)1;
				int_5 = 120;
			}
			else
			{
				float_3 = 0f;
			}
			break;
		}
		case (GEnum4)12:
		{
			bool_13 = false;
			bool_12 = false;
			bool_11 = false;
			float_27 += vector2_1.Y;
			ref Vector2 reference8 = ref vector2_1;
			reference8.Y += float_9;
			if (!(float_27 > 1000f))
			{
				break;
			}
			int_28++;
			if (int_28 == 1)
			{
				int_18--;
			}
			if (int_28 == 60)
			{
				if (int_18 < 0)
				{
					int_18 = 0;
				}
				GClass26.gclass29_0.bool_6 = true;
			}
			break;
		}
		case (GEnum4)13:
			int_27++;
			if (int_10 == 1 || int_11 == 1 || int_12 == 1)
			{
				genum4_0 = (GEnum4)3;
				vector2_1.Y = -26f;
				bool_5 = true;
				bool_6 = false;
				GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
				int_27 = 0;
			}
			if (int_27 > 24)
			{
				if (vector2_1.Y < 0f)
				{
					genum4_0 = (GEnum4)8;
					vector2_1.Y = -40f;
				}
				else
				{
					genum4_0 = (GEnum4)3;
					vector2_1.Y = 32f;
				}
			}
			break;
		}
		if (genum4_0 == (GEnum4)4 || genum4_0 == (GEnum4)7)
		{
			bool_11 = false;
			bool_12 = false;
			bool_13 = false;
		}
		if (bool_12 && int_6 == 0)
		{
			bool_12 = false;
		}
		if (bool_13 && int_7 == 0)
		{
			bool_13 = false;
		}
		if (!bool_11 && !bool_12 && !bool_13)
		{
			gclass33_16.int_1++;
		}
		else
		{
			gclass33_11.int_1++;
		}
		if (genum4_0 == (GEnum4)3 || genum4_0 == (GEnum4)8 || genum4_0 == (GEnum4)9 || genum4_0 == (GEnum4)10)
		{
			bool_10 = false;
		}
		else
		{
			bool_10 = true;
		}
		if (genum4_0 == (GEnum4)4 || genum4_0 == (GEnum4)7)
		{
			int_22++;
		}
		else
		{
			int_22 = 0;
		}
		if (genum4_0 != (GEnum4)1)
		{
			int_23 = 0;
		}
		if (genum4_0 == (GEnum4)3 || genum4_0 == (GEnum4)8 || genum4_0 == (GEnum4)9 || genum4_0 == (GEnum4)10 || genum4_0 == (GEnum4)11)
		{
			genum0_0 = (GEnum0)4;
		}
		if (int_5 > 0)
		{
			int_5--;
		}
		if (int_5 < 0)
		{
			int_5 = 0;
		}
		if (int_33 != 0)
		{
			int_34--;
			if (int_34 == 0)
			{
				int_34 = 1001;
			}
			if (int_34 % 2 == 0)
			{
				int_33 -= Math.Sign(int_33);
			}
		}
		switch (GClass29.gclass24_0.string_0)
		{
		case "ES":
			if (vector2_0.X < 48f)
			{
				vector2_0.X = 48f;
				float_3 = 0f;
				vector2_1.X = 0f;
			}
			if (vector2_0.X > 2512f)
			{
				vector2_0.X = 2512f;
				float_3 = 0f;
				vector2_1.X = 0f;
			}
			break;
		case "MHZ1":
			if (vector2_0.X < 6508f)
			{
				vector2_0.X = 6508f;
				float_3 = 0f;
				vector2_1.X = 0f;
			}
			if (vector2_0.X > (float)(135 * GClass26.gclass29_0.int_4))
			{
				vector2_0.X = 135 * GClass26.gclass29_0.int_4;
			}
			break;
		}
		bool_14 = false;
		if (genum4_0 != (GEnum4)3)
		{
			bool_5 = false;
			bool_4 = false;
		}
		int_3++;
	}

	public override void vmethod_1()
	{
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Unknown result type (might be due to invalid IL or missing references)
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e73: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e78: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0855: Unknown result type (might be due to invalid IL or missing references)
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Unknown result type (might be due to invalid IL or missing references)
		if (bool_17)
		{
			return;
		}
		method_4();
		float_1 = 0f;
		if ((double)float_20 >= Math.PI * 3.0 / 16.0)
		{
			float_1 = (float)Math.PI / 4f;
		}
		if ((double)float_20 >= Math.PI * 3.0 / 8.0)
		{
			float_1 = (float)Math.PI / 2f;
		}
		if ((double)float_20 >= Math.PI * 5.0 / 8.0)
		{
			float_1 = (float)Math.PI * 3f / 4f;
		}
		if ((double)float_20 <= Math.PI * -3.0 / 16.0)
		{
			float_1 = -(float)Math.PI / 4f;
		}
		if ((double)float_20 <= Math.PI * -3.0 / 8.0)
		{
			float_1 = -(float)Math.PI / 2f;
		}
		if ((double)float_20 <= Math.PI * -5.0 / 8.0)
		{
			float_1 = (float)Math.PI * -3f / 4f;
		}
		if ((double)float_20 <= Math.PI * -7.0 / 8.0 || (double)float_20 >= Math.PI * 7.0 / 8.0)
		{
			float_1 = (float)Math.PI;
		}
		if (genum0_0 == (GEnum0)4)
		{
			float_1 = 0f;
		}
		if (genum4_0 == (GEnum4)9 || genum4_0 == (GEnum4)10)
		{
			float_1 = (float)int_33 * (float)Math.PI / 32f;
		}
		Vector2 zero = Vector2.Zero;
		int num = 0;
		zero.X = vector2_0.X - GClass26.gclass29_0.vector2_0.X - 100f;
		zero.Y = vector2_0.Y - GClass26.gclass29_0.vector2_0.Y - 80f - 100f;
		SpriteEffects val = ((!bool_0) ? ((SpriteEffects)1) : ((SpriteEffects)0));
		if (!bool_4)
		{
			switch (genum1_0)
			{
			case (GEnum1)1:
				if (int_4 % 4 > 1)
				{
					num = int_4 % 36 / 4 + 9;
					Texture2D val2 = GClass26.gclass29_0.texture2D_21[num];
					gclass25_0.spriteBatch_0.Draw(val2, new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height), (Rectangle?)new Rectangle(0, 0, val2.Width, val2.Height), Color.White, 0f, Vector2.Zero, val, 0f);
				}
				break;
			case (GEnum1)3:
				val = (SpriteEffects)0;
				if (int_4 % 84 >= 42 && int_4 % 84 < 78)
				{
					num = 8 - (int_4 % 84 - 42) / 4;
					Texture2D val2 = GClass26.gclass29_0.texture2D_22[num];
					gclass25_0.spriteBatch_0.Draw(val2, new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height), (Rectangle?)new Rectangle(0, 0, val2.Width, val2.Height), Color.White, 0f, Vector2.Zero, val, 0f);
				}
				break;
			}
		}
		zero.X = vector2_0.X - GClass26.gclass29_0.vector2_0.X + 80f * (float)Math.Abs(Math.Sin(float_1));
		zero.Y = vector2_0.Y - GClass26.gclass29_0.vector2_0.Y + 4f - (76f - 80f * (float)Math.Cos(float_1));
		if (genum0_0 == (GEnum0)3 || float_1 > 0f)
		{
			zero.X = vector2_0.X - GClass26.gclass29_0.vector2_0.X - 80f * (float)Math.Abs(Math.Sin(float_1));
		}
		if (genum0_0 == (GEnum0)2)
		{
			zero.Y -= 8f;
		}
		if (genum4_0 == (GEnum4)12)
		{
			zero.Y = vector2_0.Y - GClass26.gclass29_0.vector2_0.Y - float_2 - (76f - 76f * (float)Math.Cos(float_1)) + float_27;
		}
		if (genum4_0 == (GEnum4)13)
		{
			zero.Y += 100f;
		}
		val = ((!bool_0) ? ((SpriteEffects)1) : ((SpriteEffects)0));
		Color val3 = ((!(GClass29.color_0 == Color.Black)) ? Color.White : Color.Black);
		if (int_5 / 4 % 2 == 0)
		{
			gclass25_0.spriteBatch_0.Draw(gclass33_16.texture2D_0[gclass33_16.int_2], zero - new Vector2(0f, 0f), (Rectangle?)new Rectangle(0, 0, gclass33_16.texture2D_0[gclass33_16.int_2].Width, gclass33_16.texture2D_0[gclass33_16.int_2].Height), val3, float_1, new Vector2((float)(gclass33_16.texture2D_0[gclass33_16.int_2].Width / 2), (float)gclass33_16.texture2D_0[gclass33_16.int_2].Height), 1f, val, 0f);
		}
		zero.X = vector2_0.X - GClass26.gclass29_0.vector2_0.X - 100f;
		zero.Y = vector2_0.Y - GClass26.gclass29_0.vector2_0.Y - 80f - 100f;
		if (genum4_0 == (GEnum4)3 || genum4_0 == (GEnum4)5)
		{
			zero.Y += 20f;
		}
		num = 0;
		if (!bool_4)
		{
			switch (genum1_0)
			{
			case (GEnum1)1:
				if (int_4 % 4 <= 1)
				{
					num = int_4 % 36 / 4;
					Texture2D val2 = GClass26.gclass29_0.texture2D_21[num];
					gclass25_0.spriteBatch_0.Draw(val2, new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height), (Rectangle?)new Rectangle(0, 0, val2.Width, val2.Height), Color.White, 0f, Vector2.Zero, val, 0f);
				}
				break;
			case (GEnum1)2:
			{
				if (int_4 % 4 / 2 == 0)
				{
					if (int_4 % 12 > 5)
					{
						num = 10;
					}
					num = 9;
				}
				else
				{
					num = int_4 / 2 % 54 / 6;
				}
				int num2 = 0;
				Texture2D val2;
				if (int_4 % 4 / 2 == 0)
				{
					num2 = int_4 / 2 % 54 / 6;
					val2 = GClass26.gclass29_0.texture2D_20[num2];
					gclass25_0.spriteBatch_0.Draw(val2, new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height), (Rectangle?)new Rectangle(0, 0, val2.Width, val2.Height), new Color(Vector4.One * 0.5f), 0f, Vector2.Zero, val, 0f);
				}
				val2 = GClass26.gclass29_0.texture2D_20[num];
				gclass25_0.spriteBatch_0.Draw(val2, new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height), (Rectangle?)new Rectangle(0, 0, val2.Width, val2.Height), Color.White, 0f, Vector2.Zero, val, 0f);
				if (int_4 % 4 / 2 == 1)
				{
					if (int_4 % 12 > 5)
					{
						num = 10;
					}
					num = 9;
					val2 = GClass26.gclass29_0.texture2D_20[9];
					gclass25_0.spriteBatch_0.Draw(val2, new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height), (Rectangle?)new Rectangle(0, 0, val2.Width, val2.Height), new Color(Vector4.One * 0.5f), 0f, Vector2.Zero, val, 0f);
				}
				break;
			}
			case (GEnum1)3:
				val = (SpriteEffects)0;
				if (int_4 % 84 < 42 || int_4 % 84 >= 78)
				{
					if (int_4 % 84 < 36)
					{
						num = int_4 % 84 / 4;
						Texture2D val2 = GClass26.gclass29_0.texture2D_22[num];
						gclass25_0.spriteBatch_0.Draw(val2, new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height), (Rectangle?)new Rectangle(0, 0, val2.Width, val2.Height), Color.White, 0f, Vector2.Zero, val, 0f);
					}
					else if (int_4 % 84 < 42)
					{
						num = (int_4 % 84 - 36) / 2 + 9;
						Texture2D val2 = GClass26.gclass29_0.texture2D_22[num];
						gclass25_0.spriteBatch_0.Draw(val2, new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height), (Rectangle?)new Rectangle(0, 0, val2.Width, val2.Height), Color.White, 0f, Vector2.Zero, val, 0f);
					}
					else
					{
						num = (int_4 % 84 - 78) / 2 + 9;
						Texture2D val2 = GClass26.gclass29_0.texture2D_22[num];
						gclass25_0.spriteBatch_0.Draw(val2, new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height), (Rectangle?)new Rectangle(0, 0, val2.Width, val2.Height), Color.White, 0f, Vector2.Zero, val, 0f);
					}
				}
				break;
			}
		}
		zero.X = vector2_0.X - GClass26.gclass29_0.vector2_0.X;
		zero.Y = vector2_0.Y - GClass26.gclass29_0.vector2_0.Y - 80f;
		if (!bool_4)
		{
			return;
		}
		switch (genum1_0)
		{
		case (GEnum1)0:
			if (int_3 < 6)
			{
				num = int_3 % 6;
				Texture2D val2 = GClass26.gclass29_0.texture2D_25[num];
				zero.X -= (float)(val2.Width / 2);
				if (num < 7)
				{
					zero.Y += (float)(20 - val2.Height / 2);
				}
				else
				{
					zero.Y += (float)(-16 - val2.Height / 2);
				}
				SpriteBatch spriteBatch_ = gclass25_0.spriteBatch_0;
				Texture2D obj = val2;
				Rectangle val4 = new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height);
				Rectangle? val5 = new Rectangle(0, 0, val2.Width, val2.Height);
				Color white = Color.White;
				float num3 = val2.Width / 2;
				_ = val2.Height;
				spriteBatch_.Draw(obj, val4, val5, white, 0f, 0f * new Vector2(num3, 0f), val, 0f);
			}
			break;
		case (GEnum1)1:
		{
			zero.X -= 100f;
			zero.Y -= 100f;
			num = int_3 / 2 % 6;
			switch (num)
			{
			case 3:
				num = 0;
				break;
			case 4:
				num = 2;
				break;
			case 5:
				num = 3;
				break;
			}
			Texture2D val2 = GClass26.gclass29_0.texture2D_24[num];
			gclass25_0.spriteBatch_0.Draw(val2, new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height), (Rectangle?)new Rectangle(0, 0, val2.Width, val2.Height), Color.White, 0f, 0f * new Vector2(0f, 0f), val, 0f);
			break;
		}
		case (GEnum1)2:
		{
			zero.Y -= 75f;
			Texture2D val2 = GClass26.gclass29_0.texture2D_20[10];
			if (bool_5)
			{
				if (vector2_1.Y < -14f)
				{
					val2 = GClass26.gclass29_0.texture2D_23[1];
				}
				else if (vector2_1.Y < -8f)
				{
					val2 = GClass26.gclass29_0.texture2D_23[0];
				}
				else
				{
					bool_4 = false;
				}
			}
			else if (vector2_1.Y > 44f)
			{
				val2 = GClass26.gclass29_0.texture2D_23[0];
			}
			zero.X -= (float)(val2.Width / 2);
			gclass25_0.spriteBatch_0.Draw(val2, new Rectangle((int)zero.X, (int)zero.Y, val2.Width, val2.Height), (Rectangle?)new Rectangle(0, 0, val2.Width, val2.Height), Color.White, 0f, Vector2.Zero, val, 0f);
			break;
		}
		case (GEnum1)3:
			zero.X -= 100f;
			zero.Y -= 100f;
			break;
		}
	}

	public void method_37()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		Vector2 zero = Vector2.Zero;
		zero.X = vector2_0.X - GClass26.gclass29_0.vector2_0.X;
		zero.Y = vector2_0.Y - GClass26.gclass29_0.vector2_0.Y;
		gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_3, zero - new Vector2((float)(GClass26.gclass29_0.texture2D_3.Width / 2), (float)(GClass26.gclass29_0.texture2D_3.Height / 2 + 80)), Color.Green);
		if (genum0_0 == (GEnum0)1)
		{
			zero.X += 80f;
			zero.Y -= 80f;
		}
		if (genum0_0 == (GEnum0)3)
		{
			zero.X -= 80f;
			zero.Y -= 80f;
		}
		if (genum0_0 == (GEnum0)2)
		{
			zero.Y -= 160f;
		}
		gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_3, zero - new Vector2((float)(GClass26.gclass29_0.texture2D_3.Width / 2), (float)(GClass26.gclass29_0.texture2D_3.Height / 2)), Color.White);
	}

	static GClass22()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		color_0 = Color.White;
	}
}
