using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass6 : GClass0
{
	private static Texture2D[] texture2D_1;

	private int int_2 = 0;

	private bool bool_4 = true;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[2];
		for (int i = 0; i < texture2D_1.Length; i++)
		{
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/seesaw" + i);
		}
	}

	public override void Update()
	{
		if (bool_4)
		{
			int_2++;
		}
		else
		{
			int_2 = 0;
		}
		if (int_2 == 81)
		{
			bool_4 = false;
			int_2 = 0;
		}
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (gclass22_0.vector2_0.Y < vector2_0.Y - (float)(texture2D_1[0].Height / 2) + 64f + 96f && gclass22_0.vector2_0.Y > vector2_0.Y - (float)(texture2D_1[0].Height / 2) - 10f && gclass22_0.vector2_0.X - 32f < vector2_0.X + 175f && vector2_0.X + 85f < gclass22_0.vector2_0.X + 32f)
		{
			if (!bool_4)
			{
				gclass22_0.int_21 = (int)(vector2_0.Y - (float)(texture2D_1[0].Height / 2) - gclass22_0.vector2_0.Y - 8f);
				if (gclass22_0.genum0_0 == (GEnum0)0)
				{
					bool_4 = true;
					GClass30.soundEffect_0.Play(GClass30.float_0, 0f, 0f);
					int_2 = 0;
				}
			}
			else
			{
				if (int_2 == 1)
				{
					gclass22_0.int_21 = (int)(vector2_0.Y - (float)(texture2D_1[0].Height / 2) + 20f - gclass22_0.vector2_0.Y - 8f);
				}
				if (int_2 == 2)
				{
					gclass22_0.int_21 = (int)(vector2_0.Y - (float)(texture2D_1[0].Height / 2) + 40f - gclass22_0.vector2_0.Y - 8f);
				}
				if (int_2 == 3)
				{
					gclass22_0.int_21 = (int)(vector2_0.Y - (float)(texture2D_1[0].Height / 2) + 60f - gclass22_0.vector2_0.Y - 8f);
				}
				if (int_2 > 3)
				{
					gclass22_0.int_21 = (int)(vector2_0.Y - (float)(texture2D_1[0].Height / 2) + 96f - gclass22_0.vector2_0.Y - 8f);
				}
				if (int_2 == 80)
				{
					if (gclass22_0.genum0_0 == (GEnum0)0)
					{
						gclass22_0.genum4_0 = (GEnum4)8;
						gclass22_0.vector2_1.Y = -48f;
						GClass30.soundEffect_1.Play(GClass30.float_0, 0f, 0f);
					}
					bool_4 = false;
					int_2 = 0;
				}
			}
			gclass22_0.bool_14 = true;
		}
		return false;
	}

	public GClass6()
	{
		bool_4 = false;
		int_0 = 2;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		GClass0.spriteEffects_0 = (SpriteEffects)0;
		GClass0.texture2D_0 = texture2D_1[1];
		if (int_2 == 0)
		{
			method_0(vector2_1 - new Vector2(126f, 110f), float_1);
		}
		else
		{
			method_0(vector2_1 - new Vector2(126f, 206f + (35.8f * (float)int_2 - 0.875f * (float)int_2 * (float)int_2 / 2f)), float_1);
		}
		GClass0.texture2D_0 = texture2D_1[0];
		if (!bool_4)
		{
			GClass0.spriteEffects_0 = (SpriteEffects)0;
		}
		else
		{
			GClass0.spriteEffects_0 = (SpriteEffects)1;
		}
		method_0(vector2_1, float_1);
	}
}
