using System;
using System.Reflection;

// Token: 0x0200000A RID: 10
internal sealed class Delegate8 : MulticastDelegate
{
	// Token: 0x06000021 RID: 33
	public extern Delegate8(object object_0, IntPtr intptr_0);

	// Token: 0x06000022 RID: 34 RVA: 0x000021B3 File Offset: 0x000003B3
	static Delegate8()
	{
		Class6.smethod_0(17);
	}

	// Token: 0x06000023 RID: 35
	public extern bool Invoke(MethodInfo methodInfo_0, MethodInfo methodInfo_1);

	// Token: 0x06000024 RID: 36 RVA: 0x000021BF File Offset: 0x000003BF
	public static bool smethod_0(MethodInfo methodInfo_0, MethodInfo methodInfo_1, Delegate8 delegate8_1)
	{
		return delegate8_1(methodInfo_0, methodInfo_1);
	}

	// Token: 0x04000009 RID: 9
	public static Delegate8 delegate8_0;
}
