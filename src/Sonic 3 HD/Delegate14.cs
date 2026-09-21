using System;

// Token: 0x02000010 RID: 16
internal sealed class Delegate14 : MulticastDelegate
{
	// Token: 0x06000039 RID: 57
	public extern Delegate14(object object_0, IntPtr intptr_0);

	// Token: 0x0600003A RID: 58 RVA: 0x00002234 File Offset: 0x00000434
	static Delegate14()
	{
		Class6.smethod_0(19);
	}

	// Token: 0x0600003B RID: 59
	public extern void Invoke(IntPtr intptr_0, IntPtr intptr_1);

	// Token: 0x0600003C RID: 60 RVA: 0x00002240 File Offset: 0x00000440
	public static void smethod_0(IntPtr intptr_0, IntPtr intptr_1, Delegate14 delegate14_1)
	{
		delegate14_1(intptr_0, intptr_1);
	}

	// Token: 0x0400000F RID: 15
	public static Delegate14 delegate14_0;
}
