using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

internal class Class3 : GClass26
{
	private static GClass26 gclass26_0;

	private static int int_0;

	private static int int_1;

	private static int int_2;

	private static int int_3;

	public static GClass26 smethod_0()
	{
		int_0 = 0;
		int_1 = 480;
		int_2 = 180;
		int_3 = 180;
		if (GClass25.bool_1)
		{
			int_0 = int_1 + int_2 + int_3 + 13;
		}
		return gclass26_0;
	}

	public override void Update(GClass28 gclass28_0)
	{
		int_0++;
		if (GClass25.gclass25_0.int_0 == 1)
		{
			if (int_0 > 14 && int_0 < 14 + int_1)
			{
				int_0 = 14 + int_1;
			}
			else if (int_0 >= 14 + int_1 && int_0 <= 14 + int_1 + int_3)
			{
				int_0 = 14 + int_1 + int_3;
			}
		}
		if (int_0 > 14 + int_1 + int_3 + int_2)
		{
			vmethod_0(gclass28_0, Class5.smethod_0());
		}
		if (int_0 == 14 + int_1 + int_3 + int_2)
		{
			MediaPlayer.Volume = GClass30.float_1;
			MediaPlayer.Play(GClass29.song_0);
			MediaPlayer.IsRepeating = true;
		}
		if (int_0 == 14 + int_1 + int_3)
		{
			GClass30.soundEffect_28.Play(GClass30.float_0, 0f, 0f);
		}
	}

	public override void Draw(GClass28 gclass28_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		((Game)GClass25.gclass25_0).GraphicsDevice.Clear(Color.Black);
		GClass25.gclass25_0.spriteBatch_0.Begin();
		Color white = Color.White;
		Texture2D val = GClass25.texture2D_1;
		if (int_0 < int_1)
		{
			val = GClass25.texture2D_1;
		}
		if (int_0 >= int_1 && int_0 <= int_1 + int_3)
		{
			val = GClass25.texture2D_0;
		}
		if (int_0 > int_1 + int_3)
		{
			val = GClass25.texture2D_2;
		}
		if (val == GClass25.texture2D_0)
		{
			GClass25.gclass25_0.spriteBatch_0.Draw(val, new Vector2((float)(((Texture2D)GClass25.gclass25_0.renderTarget2D_0).Width / 2 - GClass25.texture2D_0.Width / 2), (float)(((Texture2D)GClass25.gclass25_0.renderTarget2D_0).Height / 2 - GClass25.texture2D_0.Height / 2)), white);
		}
		else
		{
			GClass25.gclass25_0.spriteBatch_0.Draw(val, new Vector2(0f, 0f), white);
		}
		GClass25.gclass25_0.spriteBatch_0.End();
	}

	static Class3()
	{
		gclass26_0 = new Class3();
		int_0 = 0;
	}
}
