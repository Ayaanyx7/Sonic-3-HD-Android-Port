using System;
using Microsoft.Xna.Framework;

// Token: 0x02000030 RID: 48
internal class Class2 : GClass26
{
	// Token: 0x060000D5 RID: 213 RVA: 0x00008C08 File Offset: 0x00006E08
	public static GClass26 smethod_0()
	{
		Class2.int_0 = 0;
		return Class2.gclass26_0;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00008C24 File Offset: 0x00006E24
	public override void Update(GClass28 gclass28_0)
	{
		if (Class2.int_0 == 1)
		{
			GClass26.gclass29_0 = new GClass29(gclass28_0.gclass25_0);
		}
		Class2.int_0++;
		if (Class2.int_0 > 2)
		{
			this.vmethod_0(gclass28_0, Class3.smethod_0());
		}
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00008C74 File Offset: 0x00006E74
	public override void Draw(GClass28 gclass28_0)
	{
		GClass25.gclass25_0.GraphicsDevice.Clear(Color.Black);
		GClass25.gclass25_0.spriteBatch_0.Begin();
		Color white;
		if (Class2.int_0 > 2)
		{
			white..ctor(Vector3.One * (float)(14 - Class2.int_0) / 10f);
		}
		else
		{
			white = Color.White;
		}
		GClass25.gclass25_0.spriteBatch_0.Draw(GClass25.texture2D_1, new Vector2(0f, 0f), white);
		GClass25.gclass25_0.spriteBatch_0.End();
	}

	// Token: 0x0400009F RID: 159
	private static GClass26 gclass26_0 = new Class2();

	// Token: 0x040000A0 RID: 160
	private static int int_0 = 0;
}
