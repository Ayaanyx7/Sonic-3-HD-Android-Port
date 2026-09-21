using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000040 RID: 64
public class GClass33
{
	// Token: 0x06000129 RID: 297 RVA: 0x00016EA4 File Offset: 0x000150A4
	public GClass33(string string_0, string string_1, int int_5, string string_2)
	{
		this.texture2D_0 = new Texture2D[int_5];
		for (int i = 0; i < this.texture2D_0.Length; i++)
		{
			this.texture2D_0[i] = GClass25.gclass25_0.Content.Load<Texture2D>(string.Concat(new object[]
			{
				string_0,
				"/",
				string_1,
				i
			}));
		}
		this.int_0 = new int[int_5];
		for (int i = 0; i < this.int_0.Length; i++)
		{
			this.int_0[i] = 1;
		}
		char[] separator = new char[]
		{
			';',
			','
		};
		string[] array = string_2.Split(separator, StringSplitOptions.RemoveEmptyEntries);
		for (int j = 0; j < int_5; j++)
		{
			this.int_0[j] = int.Parse(array[j]);
		}
		for (int i = 0; i < this.int_0.Length; i++)
		{
			this.int_4 += this.int_0[i];
		}
		this.int_3 = this.int_4;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00016FD0 File Offset: 0x000151D0
	public bool method_0()
	{
		this.int_3--;
		bool result;
		if (this.int_3 == 0)
		{
			this.int_3 = this.int_4;
			result = false;
		}
		else
		{
			result = true;
		}
		return result;
	}

	// Token: 0x040001AC RID: 428
	public Texture2D[] texture2D_0;

	// Token: 0x040001AD RID: 429
	public int[] int_0;

	// Token: 0x040001AE RID: 430
	public int int_1;

	// Token: 0x040001AF RID: 431
	public int int_2 = 0;

	// Token: 0x040001B0 RID: 432
	public int int_3 = 0;

	// Token: 0x040001B1 RID: 433
	public int int_4 = 0;

	// Token: 0x040001B2 RID: 434
	public Color color_0;

	// Token: 0x040001B3 RID: 435
	public bool bool_0 = false;
}
