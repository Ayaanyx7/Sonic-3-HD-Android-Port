using System;

// Token: 0x0200000B RID: 11
internal sealed class Delegate9 : MulticastDelegate
{
	// Token: 0x06000025 RID: 37
	public extern Delegate9(object object_0, IntPtr intptr_0);

	// Token: 0x06000026 RID: 38 RVA: 0x000021C9 File Offset: 0x000003C9
	static Delegate9()
	{
		Class6.smethod_0(10);
	}

	// Token: 0x06000027 RID: 39
	public extern void Invoke(IntPtr intptr_0, int int_0);

	// Token: 0x06000028 RID: 40 RVA: 0x000021D5 File Offset: 0x000003D5
	public static void smethod_0(IntPtr intptr_0, int int_0, Delegate9 delegate9_1)
	{
		delegate9_1(intptr_0, int_0);
	}

	// Token: 0x0400000A RID: 10
	public static Delegate9 delegate9_0;
}
