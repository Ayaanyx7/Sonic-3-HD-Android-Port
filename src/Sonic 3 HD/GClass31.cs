using System;

// Token: 0x02000038 RID: 56
public class GClass31
{
	// Token: 0x060000FA RID: 250 RVA: 0x0000E258 File Offset: 0x0000C458
	public static void smethod_0()
	{
		GClass31.gclass32_0 = new GClass32[4];
		for (int i = 0; i < 4; i++)
		{
			GClass31.gclass32_0[i] = new GClass32(i + 1);
		}
	}

	// Token: 0x060000FB RID: 251 RVA: 0x0000E290 File Offset: 0x0000C490
	public static void smethod_1()
	{
		for (int i = 0; i < 4; i++)
		{
			GClass31.gclass32_0[i].method_1();
		}
	}

	// Token: 0x04000125 RID: 293
	public static GClass32[] gclass32_0;
}
