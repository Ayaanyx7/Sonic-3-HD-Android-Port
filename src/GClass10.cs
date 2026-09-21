using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass10 : GClass0
{
	private static Texture2D[] texture2D_1;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[3];
		for (int i = 0; i < texture2D_1.Length; i++)
		{
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/woodStand" + i);
		}
	}

	public GClass10()
	{
		bool_1 = false;
		bool_2 = true;
		int_0 = 3;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		GClass0.texture2D_0 = texture2D_1[int_1];
		GClass0.spriteEffects_0 = (SpriteEffects)0;
		method_0(vector2_1, float_1);
	}
}
