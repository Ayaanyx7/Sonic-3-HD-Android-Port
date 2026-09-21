using System;

// Token: 0x0200000D RID: 13
internal sealed class Delegate11 : MulticastDelegate
{
	// Token: 0x0600002D RID: 45
	public extern Delegate11(object object_0, IntPtr intptr_0);

	// Token: 0x0600002E RID: 46 RVA: 0x000021F5 File Offset: 0x000003F5
	static Delegate11()
	{
		Class6.smethod_0(14);
	}

	// Token: 0x0600002F RID: 47
	public extern int Invoke(IntPtr intptr_0);

	// Token: 0x06000030 RID: 48 RVA: 0x00002201 File Offset: 0x00000401
	public static int smethod_0(IntPtr intptr_0, Delegate11 delegate11_1)
	{
		return delegate11_1(intptr_0);
	}

	// Token: 0x0400000C RID: 12
	public static Delegate11 delegate11_0;
}
