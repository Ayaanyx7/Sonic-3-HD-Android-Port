using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass13 : GClass0
{
	private static Texture2D texture2D_1;

	public override void vmethod_2()
	{
		texture2D_1 = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/spikes");
	}

	public GClass13()
	{
		int_0 = 4;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		GClass0.texture2D_0 = texture2D_1;
		method_1(vector2_1, float_1, (float)Math.PI * -2f * (float)int_1 / (float)int_0);
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (gclass22_0.vector2_0.X - 40f < vector2_0.X + (float)(texture2D_1.Width / 2) && vector2_0.X - (float)(texture2D_1.Width / 2) < gclass22_0.vector2_0.X + 40f)
		{
			if (gclass22_0.vector2_0.Y < vector2_0.Y - (float)(texture2D_1.Height / 2) + 64f && gclass22_0.vector2_0.X - 32f < vector2_0.X + (float)(texture2D_1.Width / 2) && vector2_0.X - (float)(texture2D_1.Width / 2) < gclass22_0.vector2_0.X + 32f)
			{
				gclass22_0.int_21 = (int)(vector2_0.Y - gclass22_0.vector2_0.Y - (float)(texture2D_1.Height / 2));
				gclass22_0.bool_14 = true;
				if (gclass22_0.int_21 < 2 && gclass22_0.vector2_1.Y > -0.1f)
				{
					gclass22_0.bool_16 = true;
					gclass22_0.method_21((int)vector2_0.X, (int)vector2_0.Y);
				}
			}
			else if (gclass22_0.vector2_0.Y - 8f >= vector2_0.Y - (float)(texture2D_1.Height / 2) && gclass22_0.vector2_0.Y - 160f < vector2_0.Y + (float)(texture2D_1.Height / 2))
			{
				float num = vector2_0.X + (float)(texture2D_1.Width / 2) - gclass22_0.vector2_0.X;
				float num2 = vector2_0.X - (float)(texture2D_1.Width / 2) - gclass22_0.vector2_0.X;
				if (gclass22_0.float_3 < 0f && num > -44f && num <= 0f)
				{
					gclass22_0.vector2_0.X = vector2_0.X + (float)(texture2D_1.Width / 2) + 44f;
					gclass22_0.bool_12 = true;
					gclass22_0.float_11 = num;
					gclass22_0.float_12 = num2;
				}
				if (gclass22_0.float_3 > 0f && num2 < 44f && num2 >= 0f)
				{
					gclass22_0.vector2_0.X = vector2_0.X - (float)(texture2D_1.Width / 2) - 44f;
					gclass22_0.bool_13 = true;
					gclass22_0.float_11 = num;
					gclass22_0.float_12 = num2;
				}
				if (gclass22_0.float_3 == 0f)
				{
					if (num > -44f && num <= 0f)
					{
						gclass22_0.vector2_0.X = vector2_0.X + (float)(texture2D_1.Width / 2) + 44f;
					}
					if (num2 < 44f && num2 >= 0f)
					{
						gclass22_0.vector2_0.X = vector2_0.X - (float)(texture2D_1.Width / 2) - 44f;
					}
				}
			}
		}
		return false;
	}
}
