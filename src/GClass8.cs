using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass8 : GClass0
{
	private static Texture2D[] texture2D_1;

	private int int_2 = 0;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[2];
		for (int i = 0; i < texture2D_1.Length; i++)
		{
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/masterEmeraldStand" + i);
		}
	}

	public GClass8()
	{
		bool_1 = false;
		bool_2 = true;
		int_0 = 2;
	}

	public override void Update()
	{
		bool_1 = true;
		bool_2 = false;
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (gclass22_0.vector2_0.Y < vector2_0.Y + 200f - (float)texture2D_1[0].Height - (float)texture2D_1[1].Height + 64f && gclass22_0.vector2_0.X - 32f < vector2_0.X + (float)(texture2D_1[1].Width / 2) && vector2_0.X - (float)(texture2D_1[1].Width / 2) < gclass22_0.vector2_0.X + 32f)
		{
			gclass22_0.int_21 = (int)(vector2_0.Y + 200f - (float)texture2D_1[0].Height - gclass22_0.vector2_0.Y - (float)(texture2D_1[1].Height - 12));
			gclass22_0.bool_14 = true;
			int_2++;
			if (int_2 > 7)
			{
				gclass22_0.bool_18 = true;
			}
			if (int_2 > 12)
			{
				GClass29.bool_7 = true;
			}
		}
		else if (!gclass22_0.bool_18)
		{
			int_2 = 0;
		}
		return false;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		GClass0.texture2D_0 = texture2D_1[1];
		GClass0.spriteEffects_0 = (SpriteEffects)0;
		method_0(vector2_1 - new Vector2(0f, (float)(texture2D_1[0].Height / 2 - 4)), float_1);
		GClass0.texture2D_0 = texture2D_1[0];
		GClass0.spriteEffects_0 = (SpriteEffects)0;
		method_0(vector2_1, float_1);
	}
}
