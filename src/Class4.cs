using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;

internal class Class4 : GClass26
{
	private static GClass26 gclass26_0;

	private static int int_0;

	private static int int_1;

	private static GClass27[] gclass27_0;

	public static GClass26 smethod_0()
	{
		int_0 = 0;
		int_1 = 0;
		gclass27_0 = new GClass27[18];
		int num = 0;
		for (num = 0; num < gclass27_0.Length; num++)
		{
			gclass27_0[num] = new GClass27();
		}
		num = 0;
		gclass27_0[0].int_0 = 2;
		gclass27_0[0].string_0 = "          SONIC III HD";
		gclass27_0[0].string_1 = "STAFF";
		num = 1;
		gclass27_0[1].int_0 = 0;
		gclass27_0[1].string_0 = "PROJECT LEAD";
		gclass27_0[1].string_1 = "DEVINATOR ";
		num = 2;
		gclass27_0[2].int_0 = 0;
		gclass27_0[2].string_0 = "PROGRAMMING";
		gclass27_0[2].string_1 = "        WINTERHELL";
		num = 3;
		gclass27_0[3].int_0 = 0;
		gclass27_0[3].string_0 = "CHARACTER DESIGN";
		gclass27_0[3].string_1 = "CORRAL SUMMER ";
		num = 4;
		gclass27_0[4].int_0 = 0;
		gclass27_0[4].string_0 = "ENEMY ARTIST";
		gclass27_0[4].string_1 = "TOKEITIME";
		num = 5;
		gclass27_0[5].int_0 = 1;
		gclass27_0[5].string_0 = "SCENE ARTISTS";
		gclass27_0[5].string_1 = "TOKEITIME";
		gclass27_0[5].string_2 = "DEVINATOR";
		num = 6;
		gclass27_0[6].int_0 = 1;
		gclass27_0[6].string_0 = "SCENE ARTISTS";
		gclass27_0[6].string_1 = "CORRAL SUMMER  ";
		gclass27_0[6].string_2 = "SUPPER SAPPHIRE";
		num = 7;
		gclass27_0[7].int_0 = 0;
		gclass27_0[7].string_0 = "SCENE ARTISTS";
		gclass27_0[7].string_1 = " RELICK";
		num = 8;
		gclass27_0[8].int_0 = 0;
		gclass27_0[8].string_0 = "MUSIC";
		gclass27_0[8].string_1 = "DEVINATOR";
		num = 9;
		gclass27_0[9].int_0 = 0;
		gclass27_0[9].string_0 = "GAME FORUM";
		gclass27_0[9].string_1 = "    RELICK";
		num = 10;
		gclass27_0[10].int_0 = 1;
		gclass27_0[10].string_0 = "SPECIAL THANKS";
		gclass27_0[10].string_1 = "GEMSTER312";
		gclass27_0[10].string_2 = "SONICA";
		num = 11;
		gclass27_0[11].int_0 = 1;
		gclass27_0[11].string_0 = "SPECIAL THANKS";
		gclass27_0[11].string_1 = "SONICYAY2";
		gclass27_0[11].string_2 = "MRMRHI";
		num = 12;
		gclass27_0[12].int_0 = 1;
		gclass27_0[12].string_0 = "SPECIAL THANKS";
		gclass27_0[12].string_1 = "MIKE BERRY";
		gclass27_0[12].string_2 = "CADUCEUS  ";
		num = 13;
		gclass27_0[13].int_0 = 1;
		gclass27_0[13].string_0 = "SPECIAL THANKS";
		gclass27_0[13].string_1 = "GLOBA PROGRAMMING";
		gclass27_0[13].string_2 = "SACOOPER95       ";
		num = 14;
		gclass27_0[14].int_0 = 0;
		gclass27_0[14].string_0 = "SPECIAL THANKS";
		gclass27_0[14].string_1 = "1994FANGIRL  ";
		num = 15;
		gclass27_0[15].int_0 = 1;
		gclass27_0[15].string_0 = " ";
		gclass27_0[15].string_1 = "THANK YOU FOR   ";
		gclass27_0[15].string_2 = "PLAYING THE DEMO";
		num = 16;
		gclass27_0[16].int_0 = 1;
		gclass27_0[16].string_0 = " ";
		gclass27_0[16].string_0 = "If you would like to help,";
		gclass27_0[16].string_1 = "come to SONIC3HD.COM      ";
		num = 17;
		return gclass26_0;
	}

	public override void Update(GClass28 gclass28_0)
	{
		int_0++;
		if (int_0 == 2)
		{
			MediaPlayer.Play(GClass29.song_4);
		}
		if (int_0 % 285 == 0)
		{
			int_1++;
			if (int_1 > 19)
			{
				int_1 = 0;
				GClass29.bool_7 = false;
				GClass29.gclass24_0.method_0();
				GClass29.gclass24_0 = GClass26.gclass29_0.gclass24_1[7];
				GClass29.gclass24_0.method_0();
				GClass26.gclass29_0.method_0();
				GClass26.gclass29_0.gclass22_0[0].method_28();
				MediaPlayer.Stop();
				vmethod_0(gclass28_0, Class3.smethod_0());
			}
		}
		base.Update(gclass28_0);
	}

	public override void Draw(GClass28 gclass28_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		((Game)GClass25.gclass25_0).GraphicsDevice.Clear(Color.Black);
		GClass25.gclass25_0.spriteBatch_0.Begin();
		Color val = Color.Black;
		int num = 15;
		int num2 = 24;
		int num3 = 720;
		if (int_0 > 4559)
		{
			val = Color.White;
			GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_1, gclass27_0[16].string_0, new Vector2((float)(num3 - gclass27_0[16].string_0.Length * num2), 350f), val);
			GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_1, gclass27_0[16].string_1, new Vector2((float)(num3 - gclass27_0[16].string_1.Length * num), 480f), val);
		}
		else
		{
			int num4 = int_0 % 285;
			if (num4 < 40)
			{
				if (num4 < 20)
				{
					((Color)(ref val))._002Ector(new Vector3(0f, 0f, (float)num4 / 23f));
				}
				else
				{
					((Color)(ref val))._002Ector(Vector3.Lerp(new Vector3(0f, 0f, 0.8695652f), new Vector3(1f, 1f, 1f), (float)(num4 - 20) / 20f));
				}
			}
			if (num4 >= 40 && num4 <= 260)
			{
				val = Color.White;
			}
			if (num4 > 260 && num4 < 280)
			{
				((Color)(ref val))._002Ector(new Vector3(0f, 0f, (float)(20 - (num4 - 40 - 220)) / 20f));
			}
			switch (gclass27_0[int_1].int_0)
			{
			case 0:
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_1, gclass27_0[int_1].string_0, new Vector2((float)(num3 - gclass27_0[int_1].string_0.Length * num), 310f), val);
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_2, gclass27_0[int_1].string_1, new Vector2((float)(num3 - gclass27_0[int_1].string_1.Length * num2), 450f), val);
				break;
			case 1:
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_1, gclass27_0[int_1].string_0, new Vector2((float)(num3 - gclass27_0[int_1].string_0.Length * num), 310f), val);
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_2, gclass27_0[int_1].string_1, new Vector2((float)(num3 - gclass27_0[int_1].string_1.Length * num2), 450f), val);
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_2, gclass27_0[int_1].string_2, new Vector2((float)(num3 - gclass27_0[int_1].string_2.Length * num2), 550f), val);
				break;
			case 2:
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_2, gclass27_0[int_1].string_0, new Vector2((float)(num3 - gclass27_0[int_1].string_0.Length * num2), 350f), val);
				GClass25.gclass25_0.spriteBatch_0.DrawString(GClass29.spriteFont_1, gclass27_0[int_1].string_1, new Vector2((float)(num3 - gclass27_0[int_1].string_1.Length * num), 480f), val);
				break;
			}
		}
		GClass25.gclass25_0.spriteBatch_0.End();
		base.Draw(gclass28_0);
	}

	static Class4()
	{
		gclass26_0 = new Class4();
		int_0 = 0;
		int_1 = 0;
	}
}
