using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

// Token: 0x02000031 RID: 49
internal class Class3 : GClass26
{
	// Token: 0x060000DA RID: 218 RVA: 0x00008D10 File Offset: 0x00006F10
	public static GClass26 smethod_0()
	{
		Class3.int_0 = 0;
		Class3.int_1 = 480;
		Class3.int_2 = 180;
		Class3.int_3 = 180;
		if (GClass25.bool_1)
		{
			Class3.int_0 = Class3.int_1 + Class3.int_2 + Class3.int_3 + 13;
		}
		return Class3.gclass26_0;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00008D6C File Offset: 0x00006F6C
	public override void Update(GClass28 gclass28_0)
	{
		Class3.int_0++;
		if (GClass25.gclass25_0.int_0 == 1)
		{
			if (Class3.int_0 > 14 && Class3.int_0 < 14 + Class3.int_1)
			{
				Class3.int_0 = 14 + Class3.int_1;
			}
			else if (Class3.int_0 >= 14 + Class3.int_1 && Class3.int_0 <= 14 + Class3.int_1 + Class3.int_3)
			{
				Class3.int_0 = 14 + Class3.int_1 + Class3.int_3;
			}
		}
		if (Class3.int_0 > 14 + Class3.int_1 + Class3.int_3 + Class3.int_2)
		{
			this.vmethod_0(gclass28_0, Class5.smethod_0());
		}
		if (Class3.int_0 == 14 + Class3.int_1 + Class3.int_3 + Class3.int_2)
		{
			MediaPlayer.Volume = GClass30.float_1;
			MediaPlayer.Play(GClass29.song_0);
			MediaPlayer.IsRepeating = true;
		}
		if (Class3.int_0 == 14 + Class3.int_1 + Class3.int_3)
		{
			GClass30.soundEffect_28.Play(GClass30.float_0, 0f, 0f);
		}
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00008E9C File Offset: 0x0000709C
	public override void Draw(GClass28 gclass28_0)
	{
		GClass25.gclass25_0.GraphicsDevice.Clear(Color.Black);
		GClass25.gclass25_0.spriteBatch_0.Begin();
		Color white = Color.White;
		Texture2D texture2D = GClass25.texture2D_1;
		if (Class3.int_0 < Class3.int_1)
		{
			texture2D = GClass25.texture2D_1;
		}
		if (Class3.int_0 >= Class3.int_1 && Class3.int_0 <= Class3.int_1 + Class3.int_3)
		{
			texture2D = GClass25.texture2D_0;
		}
		if (Class3.int_0 > Class3.int_1 + Class3.int_3)
		{
			texture2D = GClass25.texture2D_2;
		}
		if (texture2D == GClass25.texture2D_0)
		{
			GClass25.gclass25_0.spriteBatch_0.Draw(texture2D, new Vector2((float)(GClass25.gclass25_0.renderTarget2D_0.Width / 2 - GClass25.texture2D_0.Width / 2), (float)(GClass25.gclass25_0.renderTarget2D_0.Height / 2 - GClass25.texture2D_0.Height / 2)), white);
		}
		else
		{
			GClass25.gclass25_0.spriteBatch_0.Draw(texture2D, new Vector2(0f, 0f), white);
		}
		GClass25.gclass25_0.spriteBatch_0.End();
	}

	// Token: 0x040000A1 RID: 161
	private static GClass26 gclass26_0 = new Class3();

	// Token: 0x040000A2 RID: 162
	private static int int_0 = 0;

	// Token: 0x040000A3 RID: 163
	private static int int_1;

	// Token: 0x040000A4 RID: 164
	private static int int_2;

	// Token: 0x040000A5 RID: 165
	private static int int_3;
}
