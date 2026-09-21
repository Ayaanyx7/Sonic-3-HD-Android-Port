using System;
using System.Text;

// Token: 0x02000013 RID: 19
internal sealed class Delegate17 : MulticastDelegate
{
	// Token: 0x06000045 RID: 69
	public extern Delegate17(object object_0, IntPtr intptr_0);

	// Token: 0x06000046 RID: 70 RVA: 0x00002274 File Offset: 0x00000474
	static Delegate17()
	{
		Class6.smethod_0(12);
	}

	// Token: 0x06000047 RID: 71
	public extern Encoding Invoke();

	// Token: 0x06000048 RID: 72 RVA: 0x00002280 File Offset: 0x00000480
	public static Encoding smethod_0(Delegate17 delegate17_1)
	{
		return delegate17_1();
	}

	// Token: 0x04000012 RID: 18
	public static Delegate17 delegate17_0;
}
