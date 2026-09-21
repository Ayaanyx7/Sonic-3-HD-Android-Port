using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass19 : GClass0
{
	private static Texture2D[] texture2D_1;

	private int int_2;

	private bool bool_4 = false;

	private int int_3 = 0;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[5];
		for (int i = 0; i < texture2D_1.Length; i++)
		{
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/badniks/madmole" + i);
		}
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		if (bool_4)
		{
			return;
		}
		GClass0.texture2D_0 = texture2D_1[1];
		if (!bool_0)
		{
			GClass0.spriteEffects_0 = (SpriteEffects)1;
		}
		else
		{
			GClass0.spriteEffects_0 = (SpriteEffects)0;
		}
		int num = int_2 % 190;
		if (0 >= num || num >= 70)
		{
			if (70 <= num && num <= 100)
			{
				method_0(vector2_1 + new Vector2(0f, (float)(GClass0.texture2D_0.Height * (100 - num)) / 30f), float_1);
			}
			if (100 < num && num < 160)
			{
				method_0(vector2_1, float_1);
			}
			if (160 <= num && num <= 190)
			{
				method_0(vector2_1 + new Vector2(0f, (float)(GClass0.texture2D_0.Height * (num - 160)) / 30f), float_1);
			}
			GClass0.spriteEffects_0 = (SpriteEffects)0;
		}
	}

	public override void vmethod_4(Vector2 vector2_1, float float_1)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		GClass0.texture2D_0 = texture2D_1[0];
		method_0(vector2_1 + new Vector2(0f, (float)(texture2D_1[0].Height + GClass0.texture2D_0.Height / 2)), float_1);
		if (bool_3)
		{
			return;
		}
		if (bool_4)
		{
			GClass0.texture2D_0 = GClass29.texture2D_13;
			if (int_3 < 26)
			{
				method_0(vector2_1 + new Vector2(0f, (float)(-int_3 * 4)), float_1);
			}
			else
			{
				method_0(vector2_1 + new Vector2(0f, -104f), float_1);
			}
		}
		GClass0.spriteEffects_0 = (SpriteEffects)0;
	}

	public GClass19()
	{
		int_2 = 0;
		bool_1 = true;
		bool_2 = true;
	}

	public override void Update()
	{
		int_2++;
		if (bool_4)
		{
			int_3++;
			if (int_3 > 51)
			{
				bool_3 = true;
			}
			if (bool_3)
			{
				bool_1 = false;
			}
		}
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (bool_4)
		{
			return false;
		}
		Vector2 val = gclass22_0.vector2_0 - (vector2_0 + new Vector2(0f, 80f));
		if (gclass22_0.vector2_0.X > vector2_0.X)
		{
			bool_0 = true;
		}
		else
		{
			bool_0 = false;
		}
		int num = int_2 % 190;
		float num2 = 0f;
		if (0 < num && num < 70)
		{
			return false;
		}
		if (70 <= num && num <= 100)
		{
			num2 = (float)(GClass0.texture2D_0.Height * (100 - num)) / 30f;
		}
		if (100 < num && num < 160)
		{
			num2 = 0f;
		}
		if (160 <= num && num <= 190)
		{
			num2 = (float)(GClass0.texture2D_0.Height * (num - 160)) / 30f;
		}
		int height = texture2D_1[1].Height;
		num2 = 0f;
		if (gclass22_0.vector2_0.X - 20f < vector2_0.X + 80f && vector2_0.X - 80f < gclass22_0.vector2_0.X + 20f && gclass22_0.vector2_0.Y - 80f - 60f < vector2_0.Y + (float)(texture2D_1[1].Height / 2) && vector2_0.Y - (float)(texture2D_1[1].Height / 2) + num2 < gclass22_0.vector2_0.Y - 80f + 40f && (double)num2 <= 0.9 * (double)texture2D_1[1].Height)
		{
			if (gclass22_0.genum4_0 == (GEnum4)5 || gclass22_0.genum4_0 == (GEnum4)6 || gclass22_0.genum4_0 == (GEnum4)3)
			{
				gclass22_0.int_19 += 100;
				GClass30.soundEffect_6.Play(GClass30.float_0, 0f, 0f);
				gclass22_0.method_22((int)vector2_0.Y);
				bool_4 = true;
			}
			else
			{
				gclass22_0.method_21((int)vector2_0.X, (int)vector2_0.Y);
			}
		}
		return false;
	}
}
