using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass4 : GClass0
{
	private static Texture2D[] texture2D_1;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[2];
		texture2D_1[0] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/yellowSpring");
		texture2D_1[1] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/redSpring");
	}

	public GClass4()
	{
		int_0 = 16;
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		switch (int_1 / 2)
		{
		case 6:
		{
			if (gclass22_0.vector2_0.Y < vector2_0.Y - (float)(texture2D_1[0].Width / 2) + 64f && gclass22_0.vector2_0.X - 32f < vector2_0.X + (float)(texture2D_1[0].Height / 2) + 8f && vector2_0.X - (float)(texture2D_1[0].Height / 2) < gclass22_0.vector2_0.X + 32f)
			{
				gclass22_0.int_21 = (int)(vector2_0.Y - (float)(texture2D_1[0].Width / 2) - gclass22_0.vector2_0.Y - 8f);
				gclass22_0.bool_14 = true;
				if (gclass22_0.genum0_0 == (GEnum0)0)
				{
				}
			}
			if (!(gclass22_0.vector2_0.Y - 120f < vector2_0.Y + 32f) || !(vector2_0.Y - 32f < gclass22_0.vector2_0.Y) || !(gclass22_0.vector2_0.X - 32f < vector2_0.X + (float)(texture2D_1[0].Width / 4)))
			{
				break;
			}
			float x2 = vector2_0.X;
			_ = texture2D_1[0].Width;
			if (x2 - 0f < gclass22_0.vector2_0.X + 32f)
			{
				if (int_1 % 2 == 0)
				{
					gclass22_0.vector2_1.X = 48f;
				}
				else
				{
					gclass22_0.vector2_1.X = 64f;
				}
				if (gclass22_0.genum0_0 == (GEnum0)2)
				{
					gclass22_0.float_3 = 0f - gclass22_0.vector2_1.X;
				}
				else
				{
					gclass22_0.float_3 = gclass22_0.vector2_1.X;
				}
				if (gclass22_0.int_30 < 10)
				{
					GClass30.soundEffect_11.Play(GClass30.float_0, 0f, 0f);
				}
				gclass22_0.int_30 = 16;
			}
			break;
		}
		case 0:
			if (!(gclass22_0.vector2_0.Y - 120f < vector2_0.Y + 32f) || !(vector2_0.Y - 32f < gclass22_0.vector2_0.Y + 20f))
			{
				break;
			}
			if (!gclass22_0.bool_10 && gclass22_0.vector2_1.Y > 0f)
			{
				if (gclass22_0.vector2_0.X - 48f < vector2_0.X + (float)(texture2D_1[0].Width / 2) && vector2_0.X - (float)(texture2D_1[0].Width / 2) < gclass22_0.vector2_0.X + 48f)
				{
					GClass30.soundEffect_11.Play(GClass30.float_0, 0f, 0f);
					gclass22_0.genum4_0 = (GEnum4)8;
					gclass22_0.bool_10 = false;
					if (int_1 % 2 == 0)
					{
						gclass22_0.vector2_1.Y = -48f;
					}
					else
					{
						gclass22_0.vector2_1.Y = -64f;
					}
				}
			}
			else if (gclass22_0.bool_10 && gclass22_0.vector2_0.Y - 120f < vector2_0.Y + 32f && vector2_0.Y - 32f < gclass22_0.vector2_0.Y - 2f)
			{
				float num2 = vector2_0.X + (float)(texture2D_1[0].Width / 2) - gclass22_0.vector2_0.X;
				float num3 = vector2_0.X - (float)(texture2D_1[0].Width / 2) - gclass22_0.vector2_0.X;
				if (gclass22_0.float_3 < 0f && num2 > -44f && num2 <= 0f)
				{
					gclass22_0.vector2_0.X = vector2_0.X + (float)(texture2D_1[0].Width / 2) + 44f;
					gclass22_0.bool_12 = true;
					gclass22_0.float_11 = num2;
					gclass22_0.float_12 = num3;
				}
				if (gclass22_0.float_3 > 0f && num3 < 44f && num3 >= 0f)
				{
					gclass22_0.vector2_0.X = vector2_0.X - (float)(texture2D_1[0].Width / 2) - 44f;
					gclass22_0.bool_13 = true;
					gclass22_0.float_11 = num2;
					gclass22_0.float_12 = num3;
				}
			}
			break;
		case 2:
		{
			if (gclass22_0.vector2_0.Y < vector2_0.Y - (float)(texture2D_1[0].Width / 2) + 64f && gclass22_0.vector2_0.X - 32f < vector2_0.X + (float)(texture2D_1[0].Height / 2) && vector2_0.X - (float)(texture2D_1[0].Height / 2) - 8f < gclass22_0.vector2_0.X + 32f)
			{
				gclass22_0.int_21 = (int)(vector2_0.Y - (float)(texture2D_1[0].Width / 2) - gclass22_0.vector2_0.Y - 8f);
				gclass22_0.bool_14 = true;
				if (gclass22_0.genum0_0 == (GEnum0)0)
				{
				}
			}
			if (!(gclass22_0.vector2_0.Y - 120f < vector2_0.Y + 32f) || !(vector2_0.Y - 32f < gclass22_0.vector2_0.Y))
			{
				break;
			}
			float num = gclass22_0.vector2_0.X - 32f;
			float x = vector2_0.X;
			_ = texture2D_1[0].Width;
			if (num < x + 0f && vector2_0.X - (float)(texture2D_1[0].Width / 4) < gclass22_0.vector2_0.X + 32f)
			{
				if (int_1 % 2 == 0)
				{
					gclass22_0.vector2_1.X = -48f;
				}
				else
				{
					gclass22_0.vector2_1.X = -64f;
				}
				if (gclass22_0.genum0_0 == (GEnum0)2)
				{
					gclass22_0.float_3 = 0f - gclass22_0.vector2_1.X;
				}
				else
				{
					gclass22_0.float_3 = gclass22_0.vector2_1.X;
				}
				GClass30.soundEffect_11.Play(GClass30.float_0, 0f, 0f);
				gclass22_0.int_30 = 16;
			}
			break;
		}
		}
		return false;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		GClass0.spriteEffects_0 = (SpriteEffects)0;
		GClass0.texture2D_0 = texture2D_1[int_1 % 2];
		method_1(vector2_1, float_1, (float)Math.PI * -2f * (float)(int_1 / 2) / 8f);
	}
}
