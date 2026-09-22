using System;

// Token: 0x02000005 RID: 5
internal sealed class Delegate3 : MulticastDelegate
{
	// Token: 0x0600000D RID: 13
	public extern Delegate3(object object_0, IntPtr intptr_0);

	// Token: 0x0600000E RID: 14 RVA: 0x00002149 File Offset: 0x00000349
	static Delegate3()
	{
		Class6.smethod_0(7);
	}

	// Token: 0x0600000F RID: 15
	public extern bool Invoke(string string_0, string string_1);

	// Token: 0x06000010 RID: 16 RVA: 0x00002155 File Offset: 0x00000355
	public static bool smethod_0(string string_0, string string_1, Delegate3 delegate3_1)
	{
		return delegate3_1(string_0, string_1);
	}

	// Token: 0x04000004 RID: 4
	public static Delegate3 delegate3_0;
}
