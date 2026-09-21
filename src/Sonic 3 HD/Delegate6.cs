using System;

// Token: 0x02000008 RID: 8
internal sealed class Delegate6 : MulticastDelegate
{
	// Token: 0x06000019 RID: 25
	public extern Delegate6(object object_0, IntPtr intptr_0);

	// Token: 0x0600001A RID: 26 RVA: 0x0000218A File Offset: 0x0000038A
	static Delegate6()
	{
		Class6.smethod_0(15);
	}

	// Token: 0x0600001B RID: 27
	public extern long Invoke(IntPtr intptr_0);

	// Token: 0x0600001C RID: 28 RVA: 0x00002196 File Offset: 0x00000396
	public static long smethod_0(IntPtr intptr_0, Delegate6 delegate6_1)
	{
		return delegate6_1(intptr_0);
	}

	// Token: 0x04000007 RID: 7
	public static Delegate6 delegate6_0;
}
