using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass15 : GClass0
{
	private static Texture2D texture2D_1;

	public override void vmethod_2()
	{
		texture2D_1 = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/spinPipe");
	}

	public GClass15()
	{
		int_0 = 2;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		GClass0.spriteEffects_0 = (SpriteEffects)0;
		GClass0.texture2D_0 = texture2D_1;
		if (int_1 == 0)
		{
			method_1(vector2_1, float_1, 0f);
		}
		else
		{
			method_1(vector2_1, float_1, (float)Math.PI / 2f);
		}
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (int_1 == 0)
		{
			if (gclass22_0.vector2_1.Y < -8f && gclass22_0.vector2_0.X + 12f > vector2_0.X - (float)(texture2D_1.Width / 2) && gclass22_0.vector2_0.X - 12f < vector2_0.X + (float)(texture2D_1.Width / 2) && gclass22_0.vector2_0.Y < vector2_0.Y + 120f && gclass22_0.vector2_0.Y > vector2_0.Y + 80f)
			{
				gclass22_0.genum4_0 = (GEnum4)13;
				GClass30.soundEffect_23.Play(GClass30.float_0, 0f, 0f);
				gclass22_0.vector2_0.Y = vector2_0.Y + 76f;
				gclass22_0.int_27 = 0;
			}
			if (gclass22_0.vector2_1.Y > 8f && gclass22_0.vector2_0.X + 12f > vector2_0.X - (float)(texture2D_1.Width / 2) && gclass22_0.vector2_0.X - 12f < vector2_0.X + (float)(texture2D_1.Width / 2) && gclass22_0.vector2_0.Y < vector2_0.Y + 72f && gclass22_0.vector2_0.Y > vector2_0.Y + 32f)
			{
				gclass22_0.genum4_0 = (GEnum4)13;
				GClass30.soundEffect_23.Play(GClass30.float_0, 0f, 0f);
				gclass22_0.vector2_0.Y = vector2_0.Y + 76f;
				gclass22_0.int_27 = 0;
			}
		}
		return true;
	}
}
