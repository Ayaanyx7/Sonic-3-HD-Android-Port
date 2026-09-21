using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

public class GClass3 : GClass0
{
	private static Texture2D[] texture2D_1;

	private int int_2 = 0;

	private bool bool_4 = false;

	private int int_3 = 0;

	private GClass22 gclass22_0 = null;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[10];
		texture2D_1[0] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/tvRing");
		texture2D_1[1] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/tvShoes");
		texture2D_1[2] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/tvInvincibility");
		texture2D_1[3] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/tvBubble");
		texture2D_1[4] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/tvFire");
		texture2D_1[5] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/tvLightning");
		texture2D_1[6] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/tvRobotnik");
		texture2D_1[7] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/tvSonic1UP");
		texture2D_1[8] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/tvNoise");
		texture2D_1[9] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/tvBroken");
	}

	public GClass3()
	{
		int_0 = 8;
	}

	public override void Update()
	{
		int_2++;
		if (int_2 > 13)
		{
			int_2 = 0;
		}
		if (!bool_4)
		{
			return;
		}
		int_3--;
		if (int_3 == 0)
		{
			switch (int_1)
			{
			case 0:
				gclass22_0.int_17 += 10;
				GClass30.soundEffect_16.Play(GClass30.float_0, 0f, 0f);
				GClass30.soundEffect_17.Play(GClass30.float_0, 0f, 0f);
				break;
			case 1:
				gclass22_0.method_24();
				MediaPlayer.Play(GClass29.song_1);
				MediaPlayer.IsRepeating = false;
				break;
			case 3:
				gclass22_0.genum1_0 = (GEnum1)2;
				GClass30.soundEffect_13.Play(GClass30.float_0, 0f, 0f);
				break;
			case 4:
				gclass22_0.genum1_0 = (GEnum1)1;
				GClass30.soundEffect_14.Play(GClass30.float_0, 0f, 0f);
				break;
			case 5:
				gclass22_0.genum1_0 = (GEnum1)3;
				GClass30.soundEffect_15.Play(GClass30.float_0, 0f, 0f);
				break;
			case 6:
				gclass22_0.method_21((int)vector2_0.X, (int)vector2_0.Y);
				break;
			case 7:
				gclass22_0.int_18++;
				GClass30.soundEffect_19.Play(GClass30.float_0, 0f, 0f);
				GClass26.gclass29_0.int_19 = GClass26.gclass29_0.int_20 + 180;
				break;
			case 2:
				break;
			}
		}
	}

	public override bool vmethod_0(GClass22 gclass22_1)
	{
		if (bool_4)
		{
			return false;
		}
		if (gclass22_1.vector2_0.Y - 80f - 60f < vector2_0.Y + 30f && vector2_0.Y - 30f < gclass22_1.vector2_0.Y - 80f + 40f)
		{
			if (gclass22_1.genum4_0 == (GEnum4)5 || gclass22_1.genum4_0 == (GEnum4)3)
			{
				if (gclass22_1.vector2_0.X - 48f < vector2_0.X + (float)(texture2D_1[0].Width / 2) && vector2_0.X - (float)(texture2D_1[0].Width / 2) < gclass22_1.vector2_0.X + 48f)
				{
					bool_4 = true;
					gclass22_1.int_4 = 0;
					GClass30.soundEffect_6.Play(GClass30.float_0, 0f, 0f);
					int_3 = 45;
					gclass22_0 = gclass22_1;
					gclass22_1.method_22((int)vector2_0.Y);
				}
			}
			else
			{
				float num = vector2_0.X + (float)(texture2D_1[0].Width / 2) - gclass22_1.vector2_0.X;
				float num2 = vector2_0.X - (float)(texture2D_1[0].Width / 2) - gclass22_1.vector2_0.X;
				if (gclass22_1.float_3 < 0f && num > -44f && num <= 0f)
				{
					gclass22_1.vector2_0.X = vector2_0.X + (float)(texture2D_1[0].Width / 2) + 44f;
					gclass22_1.bool_12 = true;
					gclass22_1.float_11 = num;
					gclass22_1.float_12 = num2;
				}
				if (gclass22_1.float_3 > 0f && num2 < 44f && num2 >= 0f)
				{
					gclass22_1.vector2_0.X = vector2_0.X - (float)(texture2D_1[0].Width / 2) - 44f;
					gclass22_1.bool_13 = true;
					gclass22_1.float_11 = num;
					gclass22_1.float_12 = num2;
				}
				if (gclass22_1.float_3 == 0f && gclass22_1.genum4_0 == (GEnum4)9)
				{
					if (num > -44f && num <= 0f)
					{
						gclass22_1.vector2_0.X = vector2_0.X + (float)(texture2D_1[0].Width / 2) + 44f;
					}
					if (num2 < 44f && num2 >= 0f)
					{
						gclass22_1.vector2_0.X = vector2_0.X - (float)(texture2D_1[0].Width / 2) - 44f;
					}
				}
			}
		}
		return false;
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		if (bool_3)
		{
			return;
		}
		if (!bool_4)
		{
			GClass0.texture2D_0 = texture2D_1[int_1];
			method_0(vector2_1, float_1);
			if (int_2 == 1 || int_2 == 2 || int_2 == 9 || int_2 == 8)
			{
				GClass0.texture2D_0 = texture2D_1[8];
				GClass25.gclass25_0.spriteBatch_0.End();
				GClass25.gclass25_0.spriteBatch_0.Begin((SpriteSortMode)0, BlendState.Additive);
				method_0(vector2_1, float_1);
				GClass25.gclass25_0.spriteBatch_0.End();
				GClass25.gclass25_0.spriteBatch_0.Begin();
			}
		}
		else
		{
			GClass0.texture2D_0 = texture2D_1[9];
			method_0(vector2_1, float_1);
			if (int_3 > 0)
			{
				GClass25.gclass25_0.spriteBatch_0.Draw(texture2D_1[int_1], new Rectangle((int)vector2_1.X - GClass0.texture2D_0.Width / 2 + 22, (int)vector2_1.Y - GClass0.texture2D_0.Height / 2 + 62 - 4 * (45 - int_3), 70, 60), (Rectangle?)new Rectangle(22, 12, 70, 60), GClass29.color_0);
			}
			else if (int_3 > -50)
			{
				GClass25.gclass25_0.spriteBatch_0.Draw(texture2D_1[int_1], new Rectangle((int)vector2_1.X - GClass0.texture2D_0.Width / 2 + 22, (int)vector2_1.Y - GClass0.texture2D_0.Height / 2 + 62 - 180, 70, 60), (Rectangle?)new Rectangle(22, 12, 70, 60), GClass29.color_0);
			}
		}
	}
}
