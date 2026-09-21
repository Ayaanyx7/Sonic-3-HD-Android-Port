using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass17 : GClass0
{
	private static Texture2D[] texture2D_1;

	private int int_2;

	private bool bool_4 = false;

	private int int_3 = 0;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[8];
		for (int i = 0; i < 5; i++)
		{
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/butterdroid" + i);
		}
		texture2D_1[5] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/butterdroid" + 3);
		texture2D_1[6] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/butterdroid" + 2);
		texture2D_1[7] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/butterdroid" + 1);
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		GClass0.texture2D_0 = texture2D_1[int_2 / 8 % 8];
		if (!bool_0)
		{
			GClass0.spriteEffects_0 = (SpriteEffects)1;
		}
		else
		{
			GClass0.spriteEffects_0 = (SpriteEffects)0;
		}
		if (!bool_3)
		{
			method_0(vector2_1, float_1);
		}
	}

	public override void vmethod_4(Vector2 vector2_1, float float_1)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
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
	}

	public GClass17()
	{
		int_2 = 0;
		bool_1 = false;
		bool_2 = true;
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		if (bool_4)
		{
			return false;
		}
		Vector2 val = gclass22_0.vector2_0 - (vector2_0 + new Vector2(0f, 80f));
		if (gclass22_0.vector2_0.X > vector2_0.X)
		{
			bool_0 = true;
		}
		else
		{
			bool_0 = false;
		}
		if (((Vector2)(ref val)).Length() < 1000f)
		{
			((Vector2)(ref val)).Normalize();
			vector2_0 += val * 2.7f;
		}
		if (gclass22_0.vector2_0.X - 20f - (float)gclass22_0.int_29 < vector2_0.X + 30f && vector2_0.X - 30f < gclass22_0.vector2_0.X + 20f + (float)gclass22_0.int_29 && gclass22_0.vector2_0.Y - 80f - 60f - (float)gclass22_0.int_29 < vector2_0.Y + 30f && vector2_0.Y - 30f < gclass22_0.vector2_0.Y - 80f + 40f + (float)gclass22_0.int_29)
		{
			if (gclass22_0.genum4_0 == (GEnum4)5 || gclass22_0.genum4_0 == (GEnum4)6 || gclass22_0.genum4_0 == (GEnum4)3)
			{
				gclass22_0.int_19 += 100;
				GClass30.soundEffect_6.Play(GClass30.float_0, 0f, 0f);
				gclass22_0.method_22((int)vector2_0.Y);
				bool_4 = true;
			}
			else
			{
				gclass22_0.method_21((int)vector2_0.X, (int)vector2_0.Y);
			}
		}
		return false;
	}
}
