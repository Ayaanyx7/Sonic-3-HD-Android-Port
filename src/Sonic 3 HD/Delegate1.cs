using System;

// Token: 0x02000003 RID: 3
internal sealed class Delegate1 : MulticastDelegate
{
	// Token: 0x06000005 RID: 5
	public extern Delegate1(object object_0, IntPtr intptr_0);

	// Token: 0x06000006 RID: 6 RVA: 0x0000211D File Offset: 0x0000031D
	static Delegate1()
	{
		Class6.smethod_0(4);
	}

	// Token: 0x06000007 RID: 7
	public extern void Invoke(Array array_0, int int_0, int int_1);

	// Token: 0x06000008 RID: 8 RVA: 0x00002129 File Offset: 0x00000329
	public static void smethod_0(Array array_0, int int_0, int int_1, Delegate1 delegate1_1)
	{
		delegate1_1(array_0, int_0, int_1);
	}

	// Token: 0x04000002 RID: 2
	public static Delegate1 delegate1_0;
}
