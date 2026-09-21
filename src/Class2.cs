using Microsoft.Xna.Framework;

internal class Class2 : GClass26
{
	private static GClass26 gclass26_0;

	private static int int_0;

	public static GClass26 smethod_0()
	{
		int_0 = 0;
		return gclass26_0;
	}

	public override void Update(GClass28 gclass28_0)
	{
		if (int_0 == 1)
		{
			GClass26.gclass29_0 = new GClass29(gclass28_0.gclass25_0);
		}
		int_0++;
		if (int_0 > 2)
		{
			vmethod_0(gclass28_0, Class3.smethod_0());
		}
	}

	public override void Draw(GClass28 gclass28_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		((Game)GClass25.gclass25_0).GraphicsDevice.Clear(Color.Black);
		GClass25.gclass25_0.spriteBatch_0.Begin();
		Color white = default(Color);
		if (int_0 > 2)
		{
			((Color)(ref white))._002Ector(Vector3.One * (float)(14 - int_0) / 10f);
		}
		else
		{
			white = Color.White;
		}
		GClass25.gclass25_0.spriteBatch_0.Draw(GClass25.texture2D_1, new Vector2(0f, 0f), white);
		GClass25.gclass25_0.spriteBatch_0.End();
	}

	static Class2()
	{
		gclass26_0 = new Class2();
		int_0 = 0;
	}
}
