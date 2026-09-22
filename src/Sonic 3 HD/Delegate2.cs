using System;
using System.Reflection;

// Token: 0x02000004 RID: 4
internal sealed class Delegate2 : MulticastDelegate
{
	// Token: 0x06000009 RID: 9
	public extern Delegate2(object object_0, IntPtr intptr_0);

	// Token: 0x0600000A RID: 10 RVA: 0x00002134 File Offset: 0x00000334
	static Delegate2()
	{
		Class6.smethod_0(5);
	}

	// Token: 0x0600000B RID: 11
	public extern IntPtr Invoke(Module module_0);

	// Token: 0x0600000C RID: 12 RVA: 0x00002140 File Offset: 0x00000340
	public static IntPtr smethod_0(Module module_0, Delegate2 delegate2_1)
	{
		return delegate2_1(module_0);
	}

	// Token: 0x04000003 RID: 3
	public static Delegate2 delegate2_0;
}
