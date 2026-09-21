using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass1 : GClass0
{
	private static Texture2D[] texture2D_1;

	private static bool bool_4;

	private int int_2;

	public bool bool_5 = false;

	private bool bool_6 = false;

	public Vector2 vector2_1;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[16];
		for (int i = 0; i < texture2D_1.Length; i++)
		{
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/ring" + i);
		}
	}

	public override void vmethod_3(Vector2 vector2_2, float float_1)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_3)
		{
			GClass0.texture2D_0 = texture2D_1[int_2 % 30 / 3];
			if (bool_5)
			{
				GClass0.texture2D_0 = texture2D_1[int_2 % 10 / 1];
			}
			GClass0.spriteEffects_0 = (SpriteEffects)0;
			method_0(vector2_2, float_1);
		}
	}

	public GClass1()
	{
		int_2 = 0;
	}

	public override void Update()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (bool_3)
		{
			return;
		}
		int_2++;
		if (bool_5)
		{
			ref Vector2 reference = ref vector2_1;
			reference.Y += 0.375f;
			vector2_0 += vector2_1;
			method_4();
			if (int_2 > 256)
			{
				bool_3 = true;
			}
		}
	}

	private float method_2(int int_3, int int_4)
	{
		return method_3(int_3, int_4, bool_7: false);
	}

	private float method_3(int int_3, int int_4, bool bool_7)
	{
		float num = 100000f;
		if (int_3 < 0)
		{
			return num;
		}
		GClass24 gclass24_ = GClass29.gclass24_0;
		int num2 = int_3 / 512;
		int num3 = int_4 / 512;
		if (num2 > 191)
		{
			num2 = 191;
		}
		if (num3 > 127)
		{
			num3 = 127;
		}
		if (num2 < 0)
		{
			num2 = 0;
		}
		if (num3 < 0)
		{
			num3 = 0;
		}
		GClass23 gClass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
		int num4 = int_3 - num2 * 512;
		int num5 = int_4 - num3 * 512;
		for (int i = -num5; i + num5 < 512; i++)
		{
			if (num4 >= 512)
			{
				break;
			}
			if (num5 + i >= 512)
			{
				break;
			}
			if (gClass.bool_0[num5 + i, num4] && (float)i < num)
			{
				num = i;
			}
		}
		num2 = int_3 / 512;
		num3 = int_4 / 512 + 1;
		if (num2 > 191)
		{
			num2 = 191;
		}
		if (num3 > 127)
		{
			num3 = 127;
		}
		if (num2 < 0)
		{
			num2 = 0;
		}
		if (num3 < 0)
		{
			num3 = 0;
		}
		num4 = int_3 - num2 * 512;
		num5 = int_4 - num3 * 512;
		gClass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
		for (int i = -num5; i + num5 < 512; i++)
		{
			if (num4 >= 512)
			{
				break;
			}
			if (num5 + i >= 512)
			{
				break;
			}
			if (i + num5 >= 0 && gClass.bool_0[num5 + i, num4] && (float)i < num)
			{
				num = i;
			}
		}
		num2 = int_3 / 512;
		num3 = int_4 / 512 - 1;
		if (num2 > 191)
		{
			num2 = 191;
		}
		if (num3 > 127)
		{
			num3 = 127;
		}
		if (num2 < 0)
		{
			num2 = 0;
		}
		if (num3 < 0)
		{
			num3 = 0;
		}
		num4 = int_3 - num2 * 512;
		num5 = int_4 - num3 * 512;
		gClass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
		for (int i = -num5; i + num5 <= 512; i++)
		{
			if (num4 >= 512)
			{
				break;
			}
			if (num5 + i >= 512)
			{
				break;
			}
			if (i + num5 >= 0 && gClass.bool_0[num5 + i, num4] && i > -76 && (float)i < num)
			{
				num = i;
			}
		}
		return num;
	}

	public void method_4()
	{
		if (!(vector2_1.Y <= 0f))
		{
			float num = method_2((int)vector2_0.X, (int)vector2_0.Y + 32);
			if (num < 0f && vector2_1.Y > 0f)
			{
				ref Vector2 reference = ref vector2_1;
				reference.Y *= -0.75f;
				ref Vector2 reference2 = ref vector2_0;
				reference2.Y -= num;
			}
		}
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (bool_3)
		{
			return false;
		}
		if (!bool_6 && gclass22_0.genum1_0 == (GEnum1)3)
		{
			Vector2 val = gclass22_0.vector2_0 - vector2_0;
			if (((Vector2)(ref val)).Length() < 500f)
			{
				bool_6 = true;
			}
		}
		if (bool_6)
		{
			Vector2 val2 = gclass22_0.vector2_0 - vector2_0;
			((Vector2)(ref val2)).Normalize();
			float num = ((Vector2)(ref vector2_1)).Length();
			vector2_1 = val2 * num;
			vector2_1 += val2 * 1f;
			if (((Vector2)(ref vector2_1)).Length() > 40f)
			{
				((Vector2)(ref vector2_1)).Normalize();
				vector2_1 *= 40f;
			}
			vector2_0 += vector2_1;
		}
		if (gclass22_0.vector2_0.X - 20f < vector2_0.X + 30f && vector2_0.X - 30f < gclass22_0.vector2_0.X + 20f && gclass22_0.vector2_0.Y - 80f - 60f < vector2_0.Y + 30f && vector2_0.Y - 30f < gclass22_0.vector2_0.Y - 80f + 40f && gclass22_0.int_5 < 56 && gclass22_0.genum4_0 != (GEnum4)11)
		{
			if (bool_4)
			{
				GClass30.soundEffect_17.Play(GClass30.float_0, 0f, 0f);
			}
			else
			{
				GClass30.soundEffect_16.Play(GClass30.float_0, 0f, 0f);
			}
			bool_4 = !bool_4;
			gclass22_0.int_17++;
			bool_3 = true;
		}
		return false;
	}

	static GClass1()
	{
		bool_4 = false;
	}
}
