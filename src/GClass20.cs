using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass20 : GClass0
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
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/mushmeanie" + i);
		}
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
	}

	public GClass20()
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
