using System;

// Token: 0x0200000C RID: 12
internal sealed class Delegate10 : MulticastDelegate
{
	// Token: 0x06000029 RID: 41
	public extern Delegate10(object object_0, IntPtr intptr_0);

	// Token: 0x0600002A RID: 42 RVA: 0x000021DF File Offset: 0x000003DF
	static Delegate10()
	{
		Class6.smethod_0(13);
	}

	// Token: 0x0600002B RID: 43
	public extern Delegate Invoke(IntPtr intptr_0, Type type_0);

	// Token: 0x0600002C RID: 44 RVA: 0x000021EB File Offset: 0x000003EB
	public static Delegate smethod_0(IntPtr intptr_0, Type type_0, Delegate10 delegate10_1)
	{
		return delegate10_1(intptr_0, type_0);
	}

	// Token: 0x0400000B RID: 11
	public static Delegate10 delegate10_0;
}
