using System;
using System.Reflection;

// Token: 0x02000007 RID: 7
internal sealed class Delegate5 : MulticastDelegate
{
	// Token: 0x06000015 RID: 21
	public extern Delegate5(object object_0, IntPtr intptr_0);

	// Token: 0x06000016 RID: 22 RVA: 0x00002174 File Offset: 0x00000374
	static Delegate5()
	{
		Class6.smethod_0(18);
	}

	// Token: 0x06000017 RID: 23
	public extern Delegate Invoke(Type type_0, MethodInfo methodInfo_0);

	// Token: 0x06000018 RID: 24 RVA: 0x00002180 File Offset: 0x00000380
	public static Delegate smethod_0(Type type_0, MethodInfo methodInfo_0, Delegate5 delegate5_1)
	{
		return delegate5_1(type_0, methodInfo_0);
	}

	// Token: 0x04000006 RID: 6
	public static Delegate5 delegate5_0;
}
