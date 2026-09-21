public class GClass31
{
	public static GClass32[] gclass32_0;

	public static void smethod_0()
	{
		gclass32_0 = new GClass32[4];
		for (int i = 0; i < 4; i++)
		{
			gclass32_0[i] = new GClass32(i + 1);
		}
	}

	public static void smethod_1()
	{
		for (int i = 0; i < 4; i++)
		{
			gclass32_0[i].method_1();
		}
	}
}
