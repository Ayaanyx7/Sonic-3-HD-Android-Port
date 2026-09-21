using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass18 : GClass0
{
	private static Texture2D[] texture2D_1;

	private static Texture2D texture2D_2;

	private static Texture2D[] texture2D_3;

	private static Texture2D[] texture2D_4;

	private int int_2;

	private bool bool_4 = false;

	private int int_3 = 0;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[14];
		for (int i = 0; i < 8; i++)
		{
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/dragonflyHead" + i);
		}
		for (int i = 0; i < 6; i++)
		{
			texture2D_1[i + 8] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/dragonflyHead" + (6 - i));
		}
		texture2D_2 = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/dragonflyWings0");
		texture2D_3 = (Texture2D[])(object)new Texture2D[5];
		for (int i = 0; i < 5; i++)
		{
			texture2D_3[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/dragonflyTail" + i);
		}
		texture2D_4 = (Texture2D[])(object)new Texture2D[5];
		for (int i = 0; i < 5; i++)
		{
			texture2D_4[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/dragonflyTail" + (i + 5));
		}
	}

	private Vector2 method_2(int int_4, Vector2 vector2_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return method_3(int_4, vector2_1, 120);
	}

	private Vector2 method_3(int int_4, Vector2 vector2_1, int int_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		Vector2 zero = Vector2.Zero;
		double num = Math.Sin((double)(int_4 % (2 * int_5)) * Math.PI / (double)int_5);
		if (num < -0.9)
		{
			num = -0.9;
		}
		if (num > 0.9)
		{
			num = 0.9;
		}
		zero.Y = vector2_1.Y + 280f * (float)((double)Math.Sign(num) * Math.Pow(Math.Abs(num), 1.0));
		int_5 /= 4;
		num = Math.Sin((double)(int_4 % (2 * int_5)) * Math.PI / (double)int_5);
		zero.X = vector2_1.X + 80f * (float)((double)Math.Sign(num) * Math.Pow(Math.Abs(num), 0.8500000238418579));
		return zero;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		if (bool_4)
		{
			return;
		}
		int num = int_2 % 240;
		GClass0.spriteEffects_0 = (SpriteEffects)1;
		int num2 = 8;
		GClass0.texture2D_0 = texture2D_4[4];
		if (num > 60 && num < 180)
		{
			GClass0.spriteEffects_0 = (SpriteEffects)0;
		}
		else
		{
			GClass0.spriteEffects_0 = (SpriteEffects)2;
		}
		Vector2 vector2_2 = method_3((num2 * int_2 - num2 * 2 * 7 - 14) % (240 * num2), vector2_1, 120 * num2);
		method_0(vector2_2, float_1);
		GClass0.texture2D_0 = texture2D_3[4];
		for (int num3 = 6; num3 > 0; num3--)
		{
			if (num > 60 && num < 180)
			{
				GClass0.spriteEffects_0 = (SpriteEffects)0;
			}
			else
			{
				GClass0.spriteEffects_0 = (SpriteEffects)2;
			}
			vector2_2 = method_3((num2 * int_2 - num2 * 2 * num3 - 2 * num3) % (240 * num2), vector2_1, 120 * num2);
			method_0(vector2_2, float_1);
		}
		GClass0.texture2D_0 = texture2D_1[int_2 / 28 % 14];
		vector2_2 = method_2(num, vector2_1);
		method_0(vector2_2, float_1);
		GClass0.spriteEffects_0 = (SpriteEffects)0;
		if (((Color)(ref GClass29.color_0)).R > 200)
		{
			switch (num % 4)
			{
			case 0:
				GClass0.texture2D_0 = texture2D_2;
				method_0(vector2_2, float_1);
				break;
			case 1:
				GClass0.texture2D_0 = texture2D_2;
				GClass25.gclass25_0.spriteBatch_0.Draw(GClass0.texture2D_0, vector2_2, (Rectangle?)new Rectangle(0, 0, GClass0.texture2D_0.Width, GClass0.texture2D_0.Height), Color.LightGray, 0f, new Vector2((float)(GClass0.texture2D_0.Width / 2), (float)(GClass0.texture2D_0.Height / 2)), float_1, GClass0.spriteEffects_0, 0f);
				GClass0.texture2D_0 = texture2D_2;
				GClass0.spriteEffects_0 = (SpriteEffects)2;
				GClass25.gclass25_0.spriteBatch_0.Draw(GClass0.texture2D_0, vector2_2, (Rectangle?)new Rectangle(0, 0, GClass0.texture2D_0.Width, GClass0.texture2D_0.Height), Color.LightGray, 0f, new Vector2((float)(GClass0.texture2D_0.Width / 2), (float)(GClass0.texture2D_0.Height / 2)), float_1, GClass0.spriteEffects_0, 0f);
				break;
			case 2:
				GClass0.texture2D_0 = texture2D_2;
				GClass0.spriteEffects_0 = (SpriteEffects)2;
				method_0(vector2_2, float_1);
				break;
			case 3:
				GClass0.texture2D_0 = texture2D_2;
				GClass25.gclass25_0.spriteBatch_0.Draw(GClass0.texture2D_0, vector2_2, (Rectangle?)new Rectangle(0, 0, GClass0.texture2D_0.Width, GClass0.texture2D_0.Height), Color.LightGray, 0f, new Vector2((float)(GClass0.texture2D_0.Width / 2), (float)(GClass0.texture2D_0.Height / 2)), float_1, GClass0.spriteEffects_0, 0f);
				GClass0.texture2D_0 = texture2D_2;
				GClass0.spriteEffects_0 = (SpriteEffects)2;
				GClass25.gclass25_0.spriteBatch_0.Draw(GClass0.texture2D_0, vector2_2, (Rectangle?)new Rectangle(0, 0, GClass0.texture2D_0.Width, GClass0.texture2D_0.Height), Color.LightGray, 0f, new Vector2((float)(GClass0.texture2D_0.Width / 2), (float)(GClass0.texture2D_0.Height / 2)), float_1, GClass0.spriteEffects_0, 0f);
				break;
			}
		}
		GClass0.spriteEffects_0 = (SpriteEffects)0;
	}

	public override void vmethod_4(Vector2 vector2_1, float float_1)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		if (bool_3)
		{
			return;
		}
		if (bool_4)
		{
			GClass0.texture2D_0 = GClass29.texture2D_13;
			if (int_3 < 26)
			{
				method_0(vector2_1 + new Vector2(0f, (float)(-int_3 * 4)), float_1);
			}
			else
			{
				method_0(vector2_1 + new Vector2(0f, -104f), float_1);
			}
		}
		else
		{
			vmethod_3(vector2_1, float_1);
		}
		GClass0.spriteEffects_0 = (SpriteEffects)0;
	}

	public GClass18()
	{
		int_2 = 0;
		bool_1 = false;
		bool_2 = true;
		int_2 = 240;
	}

	public override void Update()
	{
		int_2++;
		if (bool_4)
		{
			int_3++;
			if (int_3 > 51)
			{
				bool_3 = true;
			}
			if (bool_3)
			{
				bool_1 = false;
				bool_2 = false;
			}
		}
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		if (bool_4)
		{
			return false;
		}
		Vector2[] array = (Vector2[])(object)new Vector2[8];
		int int_ = int_2 % 240;
		int num = 8;
		GClass0.texture2D_0 = texture2D_3[4];
		for (int num2 = 6; num2 > 0; num2--)
		{
			array[num2] = method_3((num * int_2 - num * 2 * num2 - 2 * num2) % (240 * num), vector2_0, 120 * num);
		}
		array[7] = method_3((num * int_2 - num * 2 * 7 - 14) % (240 * num), vector2_0, 120 * num);
		array[0] = method_2(int_, vector2_0);
		for (int num2 = 0; num2 < array.Length; num2++)
		{
			if (num2 != 0 || !(gclass22_0.vector2_0.X - 20f - (float)gclass22_0.int_29 < array[num2].X + 30f) || !(array[num2].X - 30f < gclass22_0.vector2_0.X + 20f + (float)gclass22_0.int_29) || !(gclass22_0.vector2_0.Y - 80f - 60f - (float)gclass22_0.int_29 < array[num2].Y + 30f) || !(array[num2].Y - 30f < gclass22_0.vector2_0.Y - 80f + 40f + (float)gclass22_0.int_29))
			{
				if (num2 > 3 && gclass22_0.vector2_0.X - 20f < array[num2].X + 30f && array[num2].X - 30f < gclass22_0.vector2_0.X + 20f && gclass22_0.vector2_0.Y - 80f - 60f < array[num2].Y + 30f && array[num2].Y - 30f < gclass22_0.vector2_0.Y - 80f + 40f)
				{
					if ((gclass22_0.genum4_0 == (GEnum4)5 || gclass22_0.genum4_0 == (GEnum4)6 || gclass22_0.genum4_0 == (GEnum4)3) && num2 == 0)
					{
						gclass22_0.int_19 += 100;
						GClass30.soundEffect_6.Play(GClass30.float_0, 0f, 0f);
						bool_4 = true;
						gclass22_0.method_22((int)vector2_0.Y);
					}
					else
					{
						gclass22_0.method_21((int)vector2_0.X, (int)vector2_0.Y);
					}
					break;
				}
				continue;
			}
			if ((gclass22_0.genum4_0 == (GEnum4)5 || gclass22_0.genum4_0 == (GEnum4)6 || gclass22_0.genum4_0 == (GEnum4)3) && num2 == 0)
			{
				gclass22_0.int_19 += 100;
				GClass30.soundEffect_6.Play(GClass30.float_0, 0f, 0f);
				bool_4 = true;
				gclass22_0.method_22((int)vector2_0.Y);
			}
			else
			{
				gclass22_0.method_21((int)vector2_0.X, (int)vector2_0.Y);
			}
			break;
		}
		return false;
	}
}
