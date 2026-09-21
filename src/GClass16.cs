using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass16 : GClass0
{
	private static Texture2D texture2D_1;

	private bool bool_4 = false;

	public override void vmethod_2()
	{
		int_0 = 1;
		texture2D_1 = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/switch");
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		bool flag = false;
		if (gclass22_0.vector2_0.Y - 120f < vector2_0.Y && vector2_0.Y - 32f < gclass22_0.vector2_0.Y && gclass22_0.vector2_0.X - 48f < vector2_0.X + (float)(texture2D_1.Width / 2) && vector2_0.X - (float)(texture2D_1.Width / 2) < gclass22_0.vector2_0.X + 48f)
		{
			flag = true;
			if (!bool_4 && !gclass22_0.bool_10 && gclass22_0.vector2_1.Y > 0f)
			{
				bool_4 = true;
				GClass30.soundEffect_21.Play(GClass30.float_0, 0f, 0f);
			}
		}
		if (!flag)
		{
			bool_4 = flag;
		}
		return false;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		GClass0.texture2D_0 = texture2D_1;
		if (bool_4)
		{
			method_0(vector2_1 + new Vector2(0f, (float)(texture2D_1.Height / 3)), float_1);
		}
		else
		{
			method_0(vector2_1, float_1);
		}
	}
}
