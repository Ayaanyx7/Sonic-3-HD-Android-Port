using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200001B RID: 27
public class GClass5 : GClass0
{
	// Token: 0x0600006A RID: 106 RVA: 0x000023B4 File Offset: 0x000005B4
	public override void vmethod_2()
	{
		GClass5.texture2D_1 = GClass25.gclass25_0.Content.Load<Texture2D>("objects/fallingMushroom");
	}

	// Token: 0x0600006B RID: 107 RVA: 0x000023CF File Offset: 0x000005CF
	public GClass5()
	{
		this.int_0 = 2;
		this.int_2 = 0;
		this.float_1 = 0f;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00004518 File Offset: 0x00002718
	public override void Update()
	{
		if (this.bool_4)
		{
			this.int_2++;
			if (this.int_2 > 22)
			{
				this.float_1 += 0.2f;
				this.vector2_0.Y = this.vector2_0.Y + this.float_1;
			}
		}
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00004578 File Offset: 0x00002778
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		switch (this.int_1)
		{
		case 0:
			if (gclass22_0.vector2_0.Y < this.vector2_0.Y - (float)(GClass5.texture2D_1.Height / 2) + 80f && gclass22_0.vector2_0.X - 32f < this.vector2_0.X + 70f && this.vector2_0.X - 40f < gclass22_0.vector2_0.X + 32f)
			{
				gclass22_0.int_21 = (int)((double)(this.vector2_0.Y - (float)(GClass5.texture2D_1.Height / 2) - gclass22_0.vector2_0.Y - 4f) + 2.4 * (double)this.float_1);
				gclass22_0.bool_14 = true;
				if (gclass22_0.genum0_0 == (GEnum0)0 && (double)Math.Abs(gclass22_0.float_20) < 0.58904862254808621)
				{
					this.bool_4 = true;
				}
			}
			break;
		case 1:
			if (gclass22_0.vector2_0.Y < this.vector2_0.Y - (float)(GClass5.texture2D_1.Height / 2) + 64f && gclass22_0.vector2_0.X - 32f < this.vector2_0.X + 40f && this.vector2_0.X - 70f < gclass22_0.vector2_0.X + 32f)
			{
				gclass22_0.int_21 = (int)((double)(this.vector2_0.Y - (float)(GClass5.texture2D_1.Height / 2) - gclass22_0.vector2_0.Y - 4f) + 2.4 * (double)this.float_1);
				gclass22_0.bool_14 = true;
				this.bool_4 = true;
			}
			break;
		}
		return false;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002402 File Offset: 0x00000602
	public override void vmethod_3(Vector2 vector2_1, float float_2)
	{
		GClass0.texture2D_0 = GClass5.texture2D_1;
		if (this.int_1 == 0)
		{
			GClass0.spriteEffects_0 = 0;
		}
		else
		{
			GClass0.spriteEffects_0 = 1;
		}
		base.method_0(vector2_1, float_2);
	}

	// Token: 0x0400002D RID: 45
	private static Texture2D texture2D_1;

	// Token: 0x0400002E RID: 46
	private bool bool_4 = false;

	// Token: 0x0400002F RID: 47
	private int int_2;

	// Token: 0x04000030 RID: 48
	private float float_1 = 0f;
}
