using System;

// Token: 0x02000012 RID: 18
internal sealed class Delegate16 : MulticastDelegate
{
	// Token: 0x06000041 RID: 65
	public extern Delegate16(object object_0, IntPtr intptr_0);

	// Token: 0x06000042 RID: 66 RVA: 0x0000225F File Offset: 0x0000045F
	static Delegate16()
	{
		Class6.smethod_0(11);
	}

	// Token: 0x06000043 RID: 67
	public extern int Invoke(long long_0);

	// Token: 0x06000044 RID: 68 RVA: 0x0000226B File Offset: 0x0000046B
	public static int smethod_0(long long_0, Delegate16 delegate16_1)
	{
		return delegate16_1(long_0);
	}

	// Token: 0x04000011 RID: 17
	public static Delegate16 delegate16_0;
}
