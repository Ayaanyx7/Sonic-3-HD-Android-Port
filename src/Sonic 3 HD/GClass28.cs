using System;

// Token: 0x02000035 RID: 53
public class GClass28
{
	// Token: 0x060000EA RID: 234 RVA: 0x00002953 File Offset: 0x00000B53
	public GClass28(GClass25 gclass25_1)
	{
		this.gclass25_0 = gclass25_1;
		this.gclass26_0[this.int_0] = Class2.smethod_0();
	}

	// Token: 0x060000EB RID: 235 RVA: 0x00002988 File Offset: 0x00000B88
	public void method_0(GClass26 gclass26_1)
	{
		this.gclass26_0[this.int_0] = gclass26_1;
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00002998 File Offset: 0x00000B98
	public void method_1(GClass26 gclass26_1)
	{
		if (this.int_0 > this.gclass26_0.Length)
		{
			this.int_0 = 0;
		}
		else
		{
			this.int_0++;
		}
		this.gclass26_0[this.int_0] = gclass26_1;
	}

	// Token: 0x060000ED RID: 237 RVA: 0x000029D4 File Offset: 0x00000BD4
	public void method_2()
	{
		if (this.int_0 > 0)
		{
			this.int_0--;
		}
		else
		{
			this.gclass25_0.bool_0 = true;
		}
	}

	// Token: 0x060000EE RID: 238 RVA: 0x00002A00 File Offset: 0x00000C00
	public void method_3()
	{
		this.gclass26_0[this.int_0].Update(this);
	}

	// Token: 0x060000EF RID: 239 RVA: 0x00002A15 File Offset: 0x00000C15
	public void method_4()
	{
		this.gclass26_0[this.int_0].Draw(this);
	}

	// Token: 0x040000B3 RID: 179
	public GClass25 gclass25_0;

	// Token: 0x040000B4 RID: 180
	private int int_0 = 0;

	// Token: 0x040000B5 RID: 181
	private GClass26[] gclass26_0 = new GClass26[100];
}
