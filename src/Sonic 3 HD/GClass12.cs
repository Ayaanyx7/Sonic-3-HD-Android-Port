using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000022 RID: 34
public class GClass12 : GClass0
{
	// Token: 0x0600008C RID: 140 RVA: 0x00005438 File Offset: 0x00003638
	public override void vmethod_2()
	{
		GClass12.texture2D_1 = new Texture2D[13];
		for (int i = 0; i < GClass12.texture2D_1.Length; i++)
		{
			GClass12.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/miniMushroom" + i);
		}
		GClass12.texture2D_2 = new Texture2D[13];
		for (int i = 0; i < GClass12.texture2D_2.Length; i++)
		{
			GClass12.texture2D_2[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/secondMiniMushroom" + i);
		}
		GClass12.texture2D_3 = new Texture2D[6];
		for (int i = 0; i < GClass12.texture2D_3.Length; i++)
		{
			GClass12.texture2D_3[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/thirdMiniMushroom" + i);
		}
		GClass12.texture2D_4 = new Texture2D[6];
		for (int i = 0; i < GClass12.texture2D_4.Length; i++)
		{
			GClass12.texture2D_4[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/fourthMiniMushroom" + i);
		}
	}

	// Token: 0x0600008D RID: 141 RVA: 0x0000259A File Offset: 0x0000079A
	public GClass12()
	{
		this.int_0 = 4;
		this.int_2 = 0;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000025B7 File Offset: 0x000007B7
	public override void Update()
	{
		this.int_2++;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0000555C File Offset: 0x0000375C
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		if (this.int_1 < 2)
		{
			this.bool_1 = false;
			this.bool_2 = true;
		}
		else
		{
			this.bool_1 = true;
			this.bool_2 = false;
		}
		GClass0.spriteEffects_0 = 0;
		switch (this.int_1)
		{
		case 0:
		{
			int num = this.int_2 % 90;
			if (num <= 30)
			{
				GClass0.texture2D_0 = GClass12.texture2D_1[0];
			}
			else
			{
				GClass0.texture2D_0 = GClass12.texture2D_1[1 + (num - 30) / 5 % 12];
			}
			break;
		}
		case 1:
		{
			int num = this.int_2 % 90;
			if (num <= 30)
			{
				GClass0.texture2D_0 = GClass12.texture2D_2[0];
			}
			else
			{
				GClass0.texture2D_0 = GClass12.texture2D_2[1 + (num - 30) / 5 % 12];
			}
			break;
		}
		case 2:
		{
			int num = this.int_2 % 61;
			if (num <= 30)
			{
				GClass0.texture2D_0 = GClass12.texture2D_3[0 % GClass12.texture2D_3.Length];
			}
			else
			{
				GClass0.texture2D_0 = GClass12.texture2D_3[1 + (num - 30) / 6 % 5];
			}
			break;
		}
		case 3:
		{
			int num = this.int_2 % 61;
			if (num <= 30)
			{
				GClass0.texture2D_0 = GClass12.texture2D_4[0 % GClass12.texture2D_4.Length];
			}
			else
			{
				GClass0.texture2D_0 = GClass12.texture2D_4[1 + (num - 30) / 6 % 5];
			}
			break;
		}
		}
		base.method_0(vector2_1, float_1);
	}

	// Token: 0x04000041 RID: 65
	private static Texture2D[] texture2D_1;

	// Token: 0x04000042 RID: 66
	private static Texture2D[] texture2D_2;

	// Token: 0x04000043 RID: 67
	private static Texture2D[] texture2D_3;

	// Token: 0x04000044 RID: 68
	private static Texture2D[] texture2D_4;

	// Token: 0x04000045 RID: 69
	private int int_2 = 0;
}
