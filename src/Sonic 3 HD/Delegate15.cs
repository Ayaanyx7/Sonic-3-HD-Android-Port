using System;

// Token: 0x02000011 RID: 17
internal sealed class Delegate15 : MulticastDelegate
{
	// Token: 0x0600003D RID: 61
	public extern Delegate15(object object_0, IntPtr intptr_0);

	// Token: 0x0600003E RID: 62 RVA: 0x0000224A File Offset: 0x0000044A
	static Delegate15()
	{
		Class6.smethod_0(16);
	}

	// Token: 0x0600003F RID: 63
	public extern IntPtr Invoke(Delegate delegate_0);

	// Token: 0x06000040 RID: 64 RVA: 0x00002256 File Offset: 0x00000456
	public static IntPtr smethod_0(Delegate delegate_0, Delegate15 delegate15_1)
	{
		return delegate15_1(delegate_0);
	}

	// Token: 0x04000010 RID: 16
	public static Delegate15 delegate15_0;
}
