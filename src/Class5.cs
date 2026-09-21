using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

internal class Class5 : GClass26
{
	private static GClass26 gclass26_0;

	private static int int_0;

	public static bool bool_0;

	private static int int_1;

	private static int int_2;

	public static GClass26 smethod_0()
	{
		int_2 = 0;
		return gclass26_0;
	}

	public override void Update(GClass28 gclass28_0)
	{
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		if (GClass26.gclass29_0.gclass25_0.int_9 == 1)
		{
			GClass29.gclass24_0 = GClass26.gclass29_0.gclass24_1[7];
			GClass26.gclass29_0.method_0();
			GClass29.gclass24_0.method_0();
			MediaPlayer.Stop();
			vmethod_0(gclass28_0, Class3.smethod_0());
			return;
		}
		if (int_2 > 10 && int_2 < 160)
		{
			GClass26.gclass29_0.gclass22_0[0].method_28();
		}
		if (int_2 < 166)
		{
			return;
		}
		if (int_2 > 200 && GClass26.gclass29_0.bool_6)
		{
			int_0++;
			if (int_0 == 25)
			{
				switch (GClass26.gclass29_0.int_18)
				{
				}
				GClass26.gclass29_0.bool_6 = false;
				int_0 = 0;
				int_2 = 0;
				GClass26.gclass29_0.gclass22_0[0].method_28();
				GClass26.gclass29_0.vector2_0.X = GClass26.gclass29_0.gclass22_0[0].vector2_0.X - (float)(((Texture2D)GClass26.gclass29_0.gclass25_0.renderTarget2D_0).Width / 2) + 64f;
				GClass26.gclass29_0.vector2_0.Y = GClass26.gclass29_0.gclass22_0[0].vector2_0.Y + 64f - 80f - (float)(((Texture2D)GClass26.gclass29_0.gclass25_0.renderTarget2D_0).Height / 2);
				GClass29.gclass24_0.method_0();
				MediaPlayer.Play(GClass29.song_0);
			}
		}
		GClass26.gclass29_0.method_2();
		if (int_0 > 0)
		{
			if (int_0 < 22)
			{
				GClass29.color_0 = Color.White * ((float)(22 - int_0) / 22f);
			}
			else
			{
				GClass29.color_0 = Color.Black;
			}
			((Color)(ref GClass29.color_0)).A = byte.MaxValue;
		}
		if (bool_0)
		{
			int_1++;
		}
		else
		{
			int_1 = 0;
		}
		if (int_1 >= 142)
		{
			bool_0 = false;
		}
		if (GClass29.bool_7)
		{
			vmethod_0(gclass28_0, Class4.smethod_0());
		}
	}

	public override void Draw(GClass28 gclass28_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_056d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		((Game)GClass25.gclass25_0).GraphicsDevice.Clear(Color.Black);
		int_2++;
		if (int_2 < 129)
		{
			GClass29.color_0 = Color.Black;
		}
		if (int_2 >= 129 && int_2 < 145)
		{
			float num = (float)(int_2 - 121) / 16f;
			GClass29.color_0 = new Color(num, num, num);
		}
		if (int_2 == 145)
		{
			GClass29.color_0 = Color.White;
		}
		GClass26.gclass29_0.method_3();
		int num2 = -240;
		int num3 = -190;
		GClass25.gclass25_0.spriteBatch_0.Begin();
		if (int_2 >= 9 && int_2 <= 176)
		{
			if (int_2 <= 20)
			{
				GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_15, new Vector2((float)(574 + num2), (float)(num3 - 875) + (float)(875 * (int_2 - 10)) / 12f), Color.White);
			}
			else if (int_2 < 153)
			{
				GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_15, new Vector2((float)(574 + num2), (float)num3), Color.White);
			}
			else
			{
				GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_15, new Vector2((float)(574 + num2), (float)num3 - (float)(875 * (int_2 - 153)) / 7.5f), Color.White);
			}
			float num4 = 1236 - GClass26.gclass29_0.texture2D_18.Width + 240;
			if (int_2 >= 14)
			{
				if (int_2 <= 28)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_18, new Vector2((float)num2 + num4 + ((float)((Texture2D)GClass25.gclass25_0.renderTarget2D_0).Width - num4) * (float)(15 - (int_2 - 13)) / 15f, (float)(num3 + 384 + 150)), Color.White);
				}
				else if (int_2 < 162)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_18, new Vector2(num4 + (float)num2, (float)(534 + num3)), Color.White);
				}
				else
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_18, new Vector2((float)num2 + num4 + ((float)((Texture2D)GClass25.gclass25_0.renderTarget2D_0).Width - num4) * (float)(int_2 - 161) / 7f, (float)(num3 + 384 + 150)), Color.White);
				}
			}
			float num5 = 1236 - GClass26.gclass29_0.texture2D_19.Width + 240;
			if (int_2 >= 26)
			{
				if (int_2 <= 33)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_19, new Vector2((float)num2 + num5 + ((float)((Texture2D)GClass25.gclass25_0.renderTarget2D_0).Width - num5) * (float)(8 - (int_2 - 25)) / 8f, (float)(num3 + 514 + 150)), Color.White);
				}
				else if (int_2 < 165)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_19, new Vector2((float)num2 + num5, (float)(num3 + 514 + 150)), Color.White);
				}
				else
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_19, new Vector2((float)num2 + num5 + ((float)((Texture2D)GClass25.gclass25_0.renderTarget2D_0).Width - num5) * (float)(int_2 - 164) / 7f, (float)(num3 + 514 + 150)), Color.White);
				}
			}
			float num6 = 1008 - GClass26.gclass29_0.texture2D_16.Width + 240;
			if (int_2 >= 31)
			{
				if (int_2 <= 37)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_16, new Vector2((float)(num2 + 1008 + 240) + ((float)((Texture2D)GClass25.gclass25_0.renderTarget2D_0).Width - num6) * (float)(7 - (int_2 - 30)) / 7f, (float)(num3 + 638 + 150)), Color.White);
				}
				else if (int_2 < 167)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_16, new Vector2((float)(num2 + 1008 + 240), (float)(num3 + 638 + 150)), Color.White);
				}
				else
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_16, new Vector2((float)(num2 + 1008 + 240) + ((float)((Texture2D)GClass25.gclass25_0.renderTarget2D_0).Width - num6) * (float)(int_2 - 167) / 5f, (float)(num3 + 638 + 150)), Color.White);
				}
			}
		}
		if (bool_0)
		{
			Color val = default(Color);
			((Color)(ref val))._002Ector(0.2f, 0.2f, 0.2f, 0.9f);
			((Color)(ref val))._002Ector(new Vector4((float)int_1 / 100f, (float)int_1 / 100f, (float)int_1 / 100f, 0.5f));
			GClass25.gclass25_0.spriteBatch_0.Draw(GClass25.texture2D_3, Vector2.Zero, val);
		}
		GClass25.gclass25_0.spriteBatch_0.End();
	}

	static Class5()
	{
		gclass26_0 = new Class5();
		int_0 = 0;
		bool_0 = false;
		int_1 = 0;
		int_2 = 0;
	}
}
