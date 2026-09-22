using System;
using System.Diagnostics;

// Token: 0x02000009 RID: 9
internal sealed class Delegate7 : MulticastDelegate
{
	// Token: 0x0600001D RID: 29
	public extern Delegate7(object object_0, IntPtr intptr_0);

	// Token: 0x0600001E RID: 30 RVA: 0x0000219F File Offset: 0x0000039F
	static Delegate7()
	{
		Class6.smethod_0(2);
	}

	// Token: 0x0600001F RID: 31
	public extern Process Invoke();

	// Token: 0x06000020 RID: 32 RVA: 0x000021AB File Offset: 0x000003AB
	public static Process smethod_0(Delegate7 delegate7_1)
	{
		return delegate7_1();
	}

	// Token: 0x04000008 RID: 8
	public static Delegate7 delegate7_0;
}
