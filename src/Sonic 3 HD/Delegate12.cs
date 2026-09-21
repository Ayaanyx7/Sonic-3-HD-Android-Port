using System;

// Token: 0x0200000E RID: 14
internal sealed class Delegate12 : MulticastDelegate
{
	// Token: 0x06000031 RID: 49
	public extern Delegate12(object object_0, IntPtr intptr_0);

	// Token: 0x06000032 RID: 50 RVA: 0x0000220A File Offset: 0x0000040A
	static Delegate12()
	{
		Class6.smethod_0(8);
	}

	// Token: 0x06000033 RID: 51
	public extern byte[] Invoke(int int_0);

	// Token: 0x06000034 RID: 52 RVA: 0x00002216 File Offset: 0x00000416
	public static byte[] smethod_0(int int_0, Delegate12 delegate12_1)
	{
		return delegate12_1(int_0);
	}

	// Token: 0x0400000D RID: 13
	public static Delegate12 delegate12_0;
}
