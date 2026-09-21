using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass12 : GClass0
{
	private static Texture2D[] texture2D_1;

	private static Texture2D[] texture2D_2;

	private static Texture2D[] texture2D_3;

	private static Texture2D[] texture2D_4;

	private int int_2 = 0;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[13];
		for (int i = 0; i < texture2D_1.Length; i++)
		{
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/miniMushroom" + i);
		}
		texture2D_2 = (Texture2D[])(object)new Texture2D[13];
		for (int i = 0; i < texture2D_2.Length; i++)
		{
			texture2D_2[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/secondMiniMushroom" + i);
		}
		texture2D_3 = (Texture2D[])(object)new Texture2D[6];
		for (int i = 0; i < texture2D_3.Length; i++)
		{
			texture2D_3[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/thirdMiniMushroom" + i);
		}
		texture2D_4 = (Texture2D[])(object)new Texture2D[6];
		for (int i = 0; i < texture2D_4.Length; i++)
		{
			texture2D_4[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/fourthMiniMushroom" + i);
		}
	}

	public GClass12()
	{
		int_0 = 4;
		int_2 = 0;
	}

	public override void Update()
	{
		int_2++;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		if (int_1 < 2)
		{
			bool_1 = false;
			bool_2 = true;
		}
		else
		{
			bool_1 = true;
			bool_2 = false;
		}
		GClass0.spriteEffects_0 = (SpriteEffects)0;
		int num = 0;
		switch (int_1)
		{
		case 0:
			num = int_2 % 90;
			if (num <= 30)
			{
				GClass0.texture2D_0 = texture2D_1[0];
			}
			else
			{
				GClass0.texture2D_0 = texture2D_1[1 + (num - 30) / 5 % 12];
			}
			break;
		case 1:
			num = int_2 % 90;
			if (num <= 30)
			{
				GClass0.texture2D_0 = texture2D_2[0];
			}
			else
			{
				GClass0.texture2D_0 = texture2D_2[1 + (num - 30) / 5 % 12];
			}
			break;
		case 2:
			num = int_2 % 61;
			if (num <= 30)
			{
				GClass0.texture2D_0 = texture2D_3[0 % texture2D_3.Length];
			}
			else
			{
				GClass0.texture2D_0 = texture2D_3[1 + (num - 30) / 6 % 5];
			}
			break;
		case 3:
			num = int_2 % 61;
			if (num <= 30)
			{
				GClass0.texture2D_0 = texture2D_4[0 % texture2D_4.Length];
			}
			else
			{
				GClass0.texture2D_0 = texture2D_4[1 + (num - 30) / 6 % 5];
			}
			break;
		}
		method_0(vector2_1, float_1);
	}
}
