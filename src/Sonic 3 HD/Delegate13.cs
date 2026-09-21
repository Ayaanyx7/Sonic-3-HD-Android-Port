using System;

// Token: 0x0200000F RID: 15
internal sealed class Delegate13 : MulticastDelegate
{
	// Token: 0x06000035 RID: 53
	public extern Delegate13(object object_0, IntPtr intptr_0);

	// Token: 0x06000036 RID: 54 RVA: 0x0000221F File Offset: 0x0000041F
	static Delegate13()
	{
		Class6.smethod_0(6);
	}

	// Token: 0x06000037 RID: 55
	public extern string Invoke(string string_0);

	// Token: 0x06000038 RID: 56 RVA: 0x0000222B File Offset: 0x0000042B
	public static string smethod_0(string string_0, Delegate13 delegate13_1)
	{
		return delegate13_1(string_0);
	}

	// Token: 0x0400000E RID: 14
	public static Delegate13 delegate13_0;
}
