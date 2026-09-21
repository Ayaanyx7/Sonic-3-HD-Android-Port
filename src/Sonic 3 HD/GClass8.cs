using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200001E RID: 30
public class GClass8 : GClass0
{
	// Token: 0x0600007B RID: 123 RVA: 0x00004E80 File Offset: 0x00003080
	public override void vmethod_2()
	{
		GClass8.texture2D_1 = new Texture2D[2];
		for (int i = 0; i < GClass8.texture2D_1.Length; i++)
		{
			GClass8.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/masterEmeraldStand" + i);
		}
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002498 File Offset: 0x00000698
	public GClass8()
	{
		this.bool_1 = false;
		this.bool_2 = true;
		this.int_0 = 2;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x000024BC File Offset: 0x000006BC
	public override void Update()
	{
		this.bool_1 = true;
		this.bool_2 = false;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00004ED4 File Offset: 0x000030D4
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (gclass22_0.vector2_0.Y < this.vector2_0.Y + 200f - (float)GClass8.texture2D_1[0].Height - (float)GClass8.texture2D_1[1].Height + 64f && gclass22_0.vector2_0.X - 32f < this.vector2_0.X + (float)(GClass8.texture2D_1[1].Width / 2) && this.vector2_0.X - (float)(GClass8.texture2D_1[1].Width / 2) < gclass22_0.vector2_0.X + 32f)
		{
			gclass22_0.int_21 = (int)(this.vector2_0.Y + 200f - (float)GClass8.texture2D_1[0].Height - gclass22_0.vector2_0.Y - (float)(GClass8.texture2D_1[1].Height - 12));
			gclass22_0.bool_14 = true;
			this.int_2++;
			if (this.int_2 > 7)
			{
				gclass22_0.bool_18 = true;
			}
			if (this.int_2 > 12)
			{
				GClass29.bool_7 = true;
			}
		}
		else if (!gclass22_0.bool_18)
		{
			this.int_2 = 0;
		}
		return false;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000501C File Offset: 0x0000321C
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		GClass0.texture2D_0 = GClass8.texture2D_1[1];
		GClass0.spriteEffects_0 = 0;
		base.method_0(vector2_1 - new Vector2(0f, (float)(GClass8.texture2D_1[0].Height / 2 - 4)), float_1);
		GClass0.texture2D_0 = GClass8.texture2D_1[0];
		GClass0.spriteEffects_0 = 0;
		base.method_0(vector2_1, float_1);
	}

	// Token: 0x04000038 RID: 56
	private static Texture2D[] texture2D_1;

	// Token: 0x04000039 RID: 57
	private int int_2 = 0;
}
