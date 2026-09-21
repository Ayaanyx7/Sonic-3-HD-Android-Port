using System;

// Token: 0x02000006 RID: 6
internal sealed class Delegate4 : MulticastDelegate
{
	// Token: 0x06000011 RID: 17
	public extern Delegate4(object object_0, IntPtr intptr_0);

	// Token: 0x06000012 RID: 18 RVA: 0x0000215F File Offset: 0x0000035F
	static Delegate4()
	{
		Class6.smethod_0(9);
	}

	// Token: 0x06000013 RID: 19
	public extern uint Invoke(int int_0);

	// Token: 0x06000014 RID: 20 RVA: 0x0000216B File Offset: 0x0000036B
	public static uint smethod_0(int int_0, Delegate4 delegate4_1)
	{
		return delegate4_1(int_0);
	}

	// Token: 0x04000005 RID: 5
	public static Delegate4 delegate4_0;
}
