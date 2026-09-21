using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass5 : GClass0
{
	private static Texture2D texture2D_1;

	private bool bool_4 = false;

	private int int_2;

	private float float_1 = 0f;

	public override void vmethod_2()
	{
		texture2D_1 = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/fallingMushroom");
	}

	public GClass5()
	{
		int_0 = 2;
		int_2 = 0;
		float_1 = 0f;
	}

	public override void Update()
	{
		if (bool_4)
		{
			int_2++;
			if (int_2 > 22)
			{
				float_1 += 0.2f;
				ref Vector2 reference = ref vector2_0;
				reference.Y += float_1;
			}
		}
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		switch (int_1)
		{
		case 0:
			if (gclass22_0.vector2_0.Y < vector2_0.Y - (float)(texture2D_1.Height / 2) + 80f && gclass22_0.vector2_0.X - 32f < vector2_0.X + 70f && vector2_0.X - 40f < gclass22_0.vector2_0.X + 32f)
			{
				gclass22_0.int_21 = (int)((double)(vector2_0.Y - (float)(texture2D_1.Height / 2) - gclass22_0.vector2_0.Y - 4f) + 2.4 * (double)float_1);
				gclass22_0.bool_14 = true;
				if (gclass22_0.genum0_0 == (GEnum0)0 && (double)Math.Abs(gclass22_0.float_20) < Math.PI * 3.0 / 16.0)
				{
					bool_4 = true;
				}
			}
			break;
		case 1:
			if (gclass22_0.vector2_0.Y < vector2_0.Y - (float)(texture2D_1.Height / 2) + 64f && gclass22_0.vector2_0.X - 32f < vector2_0.X + 40f && vector2_0.X - 70f < gclass22_0.vector2_0.X + 32f)
			{
				gclass22_0.int_21 = (int)((double)(vector2_0.Y - (float)(texture2D_1.Height / 2) - gclass22_0.vector2_0.Y - 4f) + 2.4 * (double)float_1);
				gclass22_0.bool_14 = true;
				bool_4 = true;
			}
			break;
		}
		return false;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_2)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		GClass0.texture2D_0 = texture2D_1;
		if (int_1 == 0)
		{
			GClass0.spriteEffects_0 = (SpriteEffects)0;
		}
		else
		{
			GClass0.spriteEffects_0 = (SpriteEffects)1;
		}
		method_0(vector2_1, float_2);
	}
}
