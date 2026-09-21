using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass14 : GClass0
{
	private static Texture2D texture2D_1;

	public override void vmethod_2()
	{
		int_0 = 1;
		texture2D_1 = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/wallBarrier");
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		GClass0.texture2D_0 = texture2D_1;
		method_0(vector2_1, float_1);
	}
}
