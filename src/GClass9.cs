using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass9 : GClass0
{
	private static Texture2D[] texture2D_1;

	private static Texture2D[] texture2D_2;

	private static int int_2;

	private int int_3 = 0;

	private int int_4 = 0;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[3];
		texture2D_2 = (Texture2D[])(object)new Texture2D[1];
		for (int i = 0; i < texture2D_1.Length; i++)
		{
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/bouncingMushroomCap" + i);
		}
		for (int i = 0; i < texture2D_2.Length; i++)
		{
			texture2D_2[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/bouncingMushroomStem" + i);
		}
	}

	public GClass9()
	{
		int_3 = 0;
		int_0 = 4;
		int_4 = 0;
	}

	public override void Update()
	{
		int_3++;
		int_4--;
		if (int_4 < 0)
		{
			int_4 = 0;
		}
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (gclass22_0.genum0_0 != (GEnum0)4)
		{
			int_2 = 0;
		}
		if (gclass22_0.vector2_0.Y - 120f < vector2_0.Y + 32f && vector2_0.Y < gclass22_0.vector2_0.Y + 0f && !gclass22_0.bool_10 && gclass22_0.vector2_1.Y > 0f && gclass22_0.vector2_0.X - 36f < vector2_0.X + (float)(texture2D_1[0].Width / 3) && vector2_0.X - (float)(texture2D_1[0].Width / 3) < gclass22_0.vector2_0.X + 36f)
		{
			GClass30.soundEffect_1.Play(GClass30.float_0, 0f, 0f);
			gclass22_0.genum4_0 = (GEnum4)8;
			int_4 = 10;
			if (int_2 == 0)
			{
				gclass22_0.vector2_1.Y = -26f;
			}
			if (int_2 == 1)
			{
				gclass22_0.vector2_1.Y = -30f;
			}
			if (int_2 == 2)
			{
				gclass22_0.vector2_1.Y = -34f;
			}
			if (int_2 < 2)
			{
				int_2++;
			}
		}
		return false;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		GClass0.spriteEffects_0 = (SpriteEffects)0;
		GClass0.texture2D_0 = texture2D_2[0];
		method_0(vector2_1 + new Vector2(0f, (float)(texture2D_1[0].Height / 2 + GClass0.texture2D_0.Height / 2 - 2)), float_1);
		GClass0.texture2D_0 = texture2D_1[0];
		if (int_4 > 7)
		{
			GClass0.texture2D_0 = texture2D_1[2];
		}
		else if (int_4 > 4)
		{
			GClass0.texture2D_0 = texture2D_1[1];
		}
		method_0(vector2_1 + new Vector2(10f * (float)Math.Sin(0.07 * (double)int_3), 0f), float_1);
	}

	static GClass9()
	{
		int_2 = 0;
	}
}
