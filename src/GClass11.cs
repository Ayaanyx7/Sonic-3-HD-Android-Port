using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass11 : GClass0
{
	private static Texture2D texture2D_1;

	public override void vmethod_2()
	{
		texture2D_1 = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/shroom");
	}

	public GClass11()
	{
		int_0 = 4;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		GClass0.texture2D_0 = texture2D_1;
		if (int_1 / 2 == 0)
		{
			bool_1 = true;
			bool_2 = false;
		}
		else
		{
			bool_1 = false;
			bool_2 = true;
		}
		if (int_1 % 2 == 1)
		{
			GClass0.spriteEffects_0 = (SpriteEffects)1;
		}
		else
		{
			GClass0.spriteEffects_0 = (SpriteEffects)0;
		}
		method_0(vector2_1, float_1);
	}
}
