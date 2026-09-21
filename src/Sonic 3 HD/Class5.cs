using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;

// Token: 0x02000033 RID: 51
internal class Class5 : GClass26
{
	// Token: 0x060000E4 RID: 228 RVA: 0x000098E4 File Offset: 0x00007AE4
	public static GClass26 smethod_0()
	{
		Class5.int_2 = 0;
		return Class5.gclass26_0;
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x00009900 File Offset: 0x00007B00
	public override void Update(GClass28 gclass28_0)
	{
		if (GClass26.gclass29_0.gclass25_0.int_9 == 1)
		{
			GClass29.gclass24_0 = GClass26.gclass29_0.gclass24_1[7];
			GClass26.gclass29_0.method_0();
			GClass29.gclass24_0.method_0();
			MediaPlayer.Stop();
			this.vmethod_0(gclass28_0, Class3.smethod_0());
		}
		else
		{
			if (Class5.int_2 > 10 && Class5.int_2 < 160)
			{
				GClass26.gclass29_0.gclass22_0[0].method_28();
			}
			if (Class5.int_2 >= 166)
			{
				if (Class5.int_2 > 200 && GClass26.gclass29_0.bool_6)
				{
					Class5.int_0++;
					if (Class5.int_0 == 25)
					{
						switch (GClass26.gclass29_0.int_18)
						{
						default:
							GClass26.gclass29_0.bool_6 = false;
							Class5.int_0 = 0;
							Class5.int_2 = 0;
							GClass26.gclass29_0.gclass22_0[0].method_28();
							GClass26.gclass29_0.vector2_0.X = GClass26.gclass29_0.gclass22_0[0].vector2_0.X - (float)(GClass26.gclass29_0.gclass25_0.renderTarget2D_0.Width / 2) + 64f;
							GClass26.gclass29_0.vector2_0.Y = GClass26.gclass29_0.gclass22_0[0].vector2_0.Y + 64f - 80f - (float)(GClass26.gclass29_0.gclass25_0.renderTarget2D_0.Height / 2);
							GClass29.gclass24_0.method_0();
							MediaPlayer.Play(GClass29.song_0);
							break;
						}
					}
				}
				GClass26.gclass29_0.method_2();
				if (Class5.int_0 > 0)
				{
					if (Class5.int_0 < 22)
					{
						GClass29.color_0 = Color.White * ((float)(22 - Class5.int_0) / 22f);
					}
					else
					{
						GClass29.color_0 = Color.Black;
					}
					GClass29.color_0.A = byte.MaxValue;
				}
				if (Class5.bool_0)
				{
					Class5.int_1++;
				}
				else
				{
					Class5.int_1 = 0;
				}
				if (Class5.int_1 >= 142)
				{
					Class5.bool_0 = false;
				}
				if (GClass29.bool_7)
				{
					this.vmethod_0(gclass28_0, Class4.smethod_0());
				}
			}
		}
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x00009B68 File Offset: 0x00007D68
	public override void Draw(GClass28 gclass28_0)
	{
		GClass25.gclass25_0.GraphicsDevice.Clear(Color.Black);
		Class5.int_2++;
		if (Class5.int_2 < 129)
		{
			GClass29.color_0 = Color.Black;
		}
		if (Class5.int_2 >= 129 && Class5.int_2 < 145)
		{
			float num = (float)(Class5.int_2 - 121) / 16f;
			GClass29.color_0 = new Color(num, num, num);
		}
		if (Class5.int_2 == 145)
		{
			GClass29.color_0 = Color.White;
		}
		GClass26.gclass29_0.method_3();
		int num2 = -240;
		int num3 = -190;
		GClass25.gclass25_0.spriteBatch_0.Begin();
		if (Class5.int_2 >= 9 && Class5.int_2 <= 176)
		{
			if (Class5.int_2 <= 20)
			{
				GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_15, new Vector2((float)(574 + num2), (float)(num3 - 875) + (float)(875 * (Class5.int_2 - 10)) / 12f), Color.White);
			}
			else if (Class5.int_2 < 153)
			{
				GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_15, new Vector2((float)(574 + num2), (float)num3), Color.White);
			}
			else
			{
				GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_15, new Vector2((float)(574 + num2), (float)num3 - (float)(875 * (Class5.int_2 - 153)) / 7.5f), Color.White);
			}
			float num4 = (float)(1236 - GClass26.gclass29_0.texture2D_18.Width + 240);
			if (Class5.int_2 >= 14)
			{
				if (Class5.int_2 <= 28)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_18, new Vector2((float)num2 + num4 + ((float)GClass25.gclass25_0.renderTarget2D_0.Width - num4) * (float)(15 - (Class5.int_2 - 13)) / 15f, (float)(num3 + 384 + 150)), Color.White);
				}
				else if (Class5.int_2 < 162)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_18, new Vector2(num4 + (float)num2, (float)(534 + num3)), Color.White);
				}
				else
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_18, new Vector2((float)num2 + num4 + ((float)GClass25.gclass25_0.renderTarget2D_0.Width - num4) * (float)(Class5.int_2 - 161) / 7f, (float)(num3 + 384 + 150)), Color.White);
				}
			}
			float num5 = (float)(1236 - GClass26.gclass29_0.texture2D_19.Width + 240);
			if (Class5.int_2 >= 26)
			{
				if (Class5.int_2 <= 33)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_19, new Vector2((float)num2 + num5 + ((float)GClass25.gclass25_0.renderTarget2D_0.Width - num5) * (float)(8 - (Class5.int_2 - 25)) / 8f, (float)(num3 + 514 + 150)), Color.White);
				}
				else if (Class5.int_2 < 165)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_19, new Vector2((float)num2 + num5, (float)(num3 + 514 + 150)), Color.White);
				}
				else
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_19, new Vector2((float)num2 + num5 + ((float)GClass25.gclass25_0.renderTarget2D_0.Width - num5) * (float)(Class5.int_2 - 164) / 7f, (float)(num3 + 514 + 150)), Color.White);
				}
			}
			float num6 = (float)(1008 - GClass26.gclass29_0.texture2D_16.Width + 240);
			if (Class5.int_2 >= 31)
			{
				if (Class5.int_2 <= 37)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_16, new Vector2((float)(num2 + 1008 + 240) + ((float)GClass25.gclass25_0.renderTarget2D_0.Width - num6) * (float)(7 - (Class5.int_2 - 30)) / 7f, (float)(num3 + 638 + 150)), Color.White);
				}
				else if (Class5.int_2 < 167)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_16, new Vector2((float)(num2 + 1008 + 240), (float)(num3 + 638 + 150)), Color.White);
				}
				else
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_16, new Vector2((float)(num2 + 1008 + 240) + ((float)GClass25.gclass25_0.renderTarget2D_0.Width - num6) * (float)(Class5.int_2 - 167) / 5f, (float)(num3 + 638 + 150)), Color.White);
				}
			}
		}
		if (Class5.bool_0)
		{
			Color color;
			color..ctor(0.2f, 0.2f, 0.2f, 0.9f);
			color..ctor(new Vector4((float)Class5.int_1 / 100f, (float)Class5.int_1 / 100f, (float)Class5.int_1 / 100f, 0.5f));
			GClass25.gclass25_0.spriteBatch_0.Draw(GClass25.texture2D_3, Vector2.Zero, color);
		}
		GClass25.gclass25_0.spriteBatch_0.End();
	}

	// Token: 0x040000AA RID: 170
	private static GClass26 gclass26_0 = new Class5();

	// Token: 0x040000AB RID: 171
	private static int int_0 = 0;

	// Token: 0x040000AC RID: 172
	public static bool bool_0 = false;

	// Token: 0x040000AD RID: 173
	private static int int_1 = 0;

	// Token: 0x040000AE RID: 174
	private static int int_2 = 0;
}
