using System;

// Token: 0x02000002 RID: 2
internal sealed class Delegate0 : MulticastDelegate
{
	// Token: 0x06000001 RID: 1
	public extern Delegate0(object object_0, IntPtr intptr_0);

	// Token: 0x06000002 RID: 2 RVA: 0x00002108 File Offset: 0x00000308
	static Delegate0()
	{
		Class6.smethod_0(3);
	}

	// Token: 0x06000003 RID: 3
	public extern Type Invoke(RuntimeTypeHandle runtimeTypeHandle_0);

	// Token: 0x06000004 RID: 4 RVA: 0x00002114 File Offset: 0x00000314
	public static Type smethod_0(RuntimeTypeHandle runtimeTypeHandle_0, Delegate0 delegate0_1)
	{
		return delegate0_1(runtimeTypeHandle_0);
	}

	// Token: 0x04000001 RID: 1
	public static Delegate0 delegate0_0;
}
