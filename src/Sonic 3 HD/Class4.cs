using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;

// Token: 0x02000032 RID: 50
internal class Class4 : GClass26
{
	// Token: 0x060000DF RID: 223 RVA: 0x00008FC8 File Offset: 0x000071C8
	public static GClass26 smethod_0()
	{
		Class4.int_0 = 0;
		Class4.int_1 = 0;
		Class4.gclass27_0 = new GClass27[18];
		for (int i = 0; i < Class4.gclass27_0.Length; i++)
		{
			Class4.gclass27_0[i] = new GClass27();
		}
		Class4.gclass27_0[0].int_0 = 2;
		Class4.gclass27_0[0].string_0 = "          SONIC III HD";
		Class4.gclass27_0[0].string_1 = "STAFF";
		Class4.gclass27_0[1].int_0 = 0;
		Class4.gclass27_0[1].string_0 = "PROJECT LEAD";
		Class4.gclass27_0[1].string_1 = "DEVINATOR ";
		Class4.gclass27_0[2].int_0 = 0;
		Class4.gclass27_0[2].string_0 = "PROGRAMMING";
		Class4.gclass27_0[2].string_1 = "        WINTERHELL";
		Class4.gclass27_0[3].int_0 = 0;
		Class4.gclass27_0[3].string_0 = "CHARACTER DESIGN";
		Class4.gclass27_0[3].string_1 = "CORRAL SUMMER ";
		Class4.gclass27_0[4].int_0 = 0;
		Class4.gclass27_0[4].string_0 = "ENEMY ARTIST";
		Class4.gclass27_0[4].string_1 = "TOKEITIME";
		Class4.gclass27_0[5].int_0 = 1;
		Class4.gclass27_0[5].string_0 = "SCENE ARTISTS";
		Class4.gclass27_0[5].string_1 = "TOKEITIME";
		Class4.gclass27_0[5].string_2 = "DEVINATOR";
		Class4.gclass27_0[6].int_0 = 1;
		Class4.gclass27_0[6].string_0 = "SCENE ARTISTS";
		Class4.gclass27_0[6].string_1 = "CORRAL SUMMER  ";
		Class4.gclass27_0[6].string_2 = "SUPPER SAPPHIRE";
		Class4.gclass27_0[7].int_0 = 0;
		Class4.gclass27_0[7].string_0 = "SCENE ARTISTS";
		Class4.gclass27_0[7].string_1 = " RELICK";
		Class4.gclass27_0[8].int_0 = 0;
		Class4.gclass27_0[8].string_0 = "MUSIC";
		Class4.gclass27_0[8].string_1 = "DEVINATOR";
		Class4.gclass27_0[9].int_0 = 0;
		Class4.gclass27_0[9].string_0 = "GAME FORUM";
		Class4.gclass27_0[9].string_1 = "    RELICK";
		Class4.gclass27_0[10].int_0 = 1;
		Class4.gclass27_0[10].string_0 = "SPECIAL THANKS";
		Class4.gclass27_0[10].string_1 = "GEMSTER312";
		Class4.gclass27_0[10].string_2 = "SONICA";
		Class4.gclass27_0[11].int_0 = 1;
		Class4.gclass27_0[11].string_0 = "SPECIAL THANKS";
		Class4.gclass27_0[11].string_1 = "SONICYAY2";
		Class4.gclass27_0[11].string_2 = "MRMRHI";
		Class4.gclass27_0[12].int_0 = 1;
		Class4.gclass27_0[12].string_0 = "SPECIAL THANKS";
		Class4.gclass27_0[12].string_1 = "MIKE BERRY";
		Class4.gclass27_0[12].string_2 = "CADUCEUS  ";
		Class4.gclass27_0[13].int_0 = 1;
		Class4.gclass27_0[13].string_0 = "SPECIAL THANKS";
		Class4.gclass27_0[13].string_1 = "GLOBA PROGRAMMING";
		Class4.gclass27_0[13].string_2 = "SACOOPER95       ";
		Class4.gclass27_0[14].int_0 = 0;
		Class4.gclass27_0[14].string_0 = "SPECIAL THANKS";
		Class4.gclass27_0[14].string_1 = "1994FANGIRL  ";
		Class4.gclass27_0[15].int_0 = 1;
		Class4.gclass27_0[15].string_0 = " ";
		Class4.gclass27_0[15].string_1 = "THANK YOU FOR   ";
		Class4.gclass27_0[15].string_2 = "PLAYING THE DEMO";
		Class4.gclass27_0[16].int_0 = 1;
		Class4.gclass27_0[16].string_0 = " ";
		Class4.gclass27_0[16].string_0 = "If you would like to help,";
		Class4.gclass27_0[16].string_1 = "come to SONIC3HD.COM      ";
		return Class4.gclass26_0;
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00009408 File Offset: 0x00007608
	public override void Update(GClass28 gclass28_0)
	{
		Class4.int_0++;
		if (Class4.int_0 == 2)
		{
			MediaPlayer.Play(GClass29.song_4);
		}
		if (Class4.int_0 % 285 == 0)
		{
			Class4.int_1++;
			if (Class4.int_1 > 19)
			{
				Class4.int_1 = 0;
				GClass29.bool_7 = false;
				GClass29.gclass24_0.method_0();
				GClass29.gclass24_0 = GClass26.gclass29_0.gclass24_1[7];
				GClass29.gclass24_0.method_0();
				GClass26.gclass29_0.method_0();
				GClass26.gclass29_0.gclass22_0[0].method_28();
				MediaPlayer.Stop();
				this.vmethod_0(gclass28_0, Class3.smethod_0());
			}
		}
		base.Update(gclass28_0);
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x000094CC File Offset: 0x000076CC
	public override void Draw(GClass28 gclass28_0)
	{
		GClass25.gclass25_0.GraphicsDevice.Clear(Color.Black);
		GClass25.gclass25_0.spriteBatch_0.Begin();
		Color color = Color.Black;
		int num = 15;
		int num2 = 24;
		int num3 = 720;
		if (Class4.int_0 > 4559)
		{
			color = Color.White;
			GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_1, Class4.gclass27_0[16].string_0, new Vector2((float)(num3 - Class4.gclass27_0[16].string_0.Length * num2), 350f), color);
			GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_1, Class4.gclass27_0[16].string_1, new Vector2((float)(num3 - Class4.gclass27_0[16].string_1.Length * num), 480f), color);
		}
		else
		{
			int num4 = Class4.int_0 % 285;
			if (num4 < 40)
			{
				if (num4 < 20)
				{
					color..ctor(new Vector3(0f, 0f, (float)num4 / 23f));
				}
				else
				{
					color..ctor(Vector3.Lerp(new Vector3(0f, 0f, 0.8695652f), new Vector3(1f, 1f, 1f), (float)(num4 - 20) / 20f));
				}
			}
			if (num4 >= 40 && num4 <= 260)
			{
				color = Color.White;
			}
			if (num4 > 260 && num4 < 280)
			{
				color..ctor(new Vector3(0f, 0f, (float)(20 - (num4 - 40 - 220)) / 20f));
			}
			switch (Class4.gclass27_0[Class4.int_1].int_0)
			{
			case 0:
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_1, Class4.gclass27_0[Class4.int_1].string_0, new Vector2((float)(num3 - Class4.gclass27_0[Class4.int_1].string_0.Length * num), 310f), color);
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_2, Class4.gclass27_0[Class4.int_1].string_1, new Vector2((float)(num3 - Class4.gclass27_0[Class4.int_1].string_1.Length * num2), 450f), color);
				break;
			case 1:
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_1, Class4.gclass27_0[Class4.int_1].string_0, new Vector2((float)(num3 - Class4.gclass27_0[Class4.int_1].string_0.Length * num), 310f), color);
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_2, Class4.gclass27_0[Class4.int_1].string_1, new Vector2((float)(num3 - Class4.gclass27_0[Class4.int_1].string_1.Length * num2), 450f), color);
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_2, Class4.gclass27_0[Class4.int_1].string_2, new Vector2((float)(num3 - Class4.gclass27_0[Class4.int_1].string_2.Length * num2), 550f), color);
				break;
			case 2:
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_2, Class4.gclass27_0[Class4.int_1].string_0, new Vector2((float)(num3 - Class4.gclass27_0[Class4.int_1].string_0.Length * num2), 350f), color);
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_1, Class4.gclass27_0[Class4.int_1].string_1, new Vector2((float)(num3 - Class4.gclass27_0[Class4.int_1].string_1.Length * num), 480f), color);
				break;
			}
		}
		GClass25.gclass25_0.spriteBatch_0.End();
		base.Draw(gclass28_0);
	}

	// Token: 0x040000A6 RID: 166
	private static GClass26 gclass26_0 = new Class4();

	// Token: 0x040000A7 RID: 167
	private static int int_0 = 0;

	// Token: 0x040000A8 RID: 168
	private static int int_1 = 0;

	// Token: 0x040000A9 RID: 169
	private static GClass27[] gclass27_0;
}
