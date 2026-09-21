using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass21 : GClass0
{
	private static Texture2D[] texture2D_1;

	private int int_2;

	private bool bool_4 = false;

	private int int_3 = 0;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[1];
		for (int i = 0; i < texture2D_1.Length; i++)
		{
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/cluckoid" + i);
		}
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_4)
		{
			GClass0.texture2D_0 = texture2D_1[0];
			method_0(vector2_1, float_1);
			GClass0.spriteEffects_0 = (SpriteEffects)0;
		}
	}

	public GClass21()
	{
		int_2 = 0;
		bool_1 = false;
		bool_2 = true;
	}

	public override void Update()
	{
		int_2++;
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		return false;
	}
}
