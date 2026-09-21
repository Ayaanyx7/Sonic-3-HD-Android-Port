using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200001D RID: 29
public class GClass7 : GClass0
{
	// Token: 0x06000074 RID: 116 RVA: 0x00004B8C File Offset: 0x00002D8C
	public override void vmethod_2()
	{
		GClass7.texture2D_1 = new Texture2D[9];
		for (int i = 0; i < GClass7.texture2D_1.Length; i++)
		{
			GClass7.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/emeraldStand" + i);
		}
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00004BE0 File Offset: 0x00002DE0
	public GClass7()
	{
		this.bool_1 = false;
		this.bool_2 = true;
		this.int_4 = GClass7.int_3 % 7;
		GClass7.int_3++;
		this.int_0 = 2;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002456 File Offset: 0x00000656
	public override void Update()
	{
		if (this.int_1 == 0)
		{
			this.bool_1 = false;
			this.bool_2 = true;
		}
		if (this.int_1 == 1)
		{
			this.bool_1 = true;
			this.bool_2 = true;
		}
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00004C30 File Offset: 0x00002E30
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (gclass22_0.vector2_0.Y < this.vector2_0.Y + 200f - (float)GClass7.texture2D_1[0].Height - (float)GClass7.texture2D_1[1].Height + 64f && gclass22_0.vector2_0.X - 32f < this.vector2_0.X + (float)(GClass7.texture2D_1[1].Width / 2) && this.vector2_0.X - (float)(GClass7.texture2D_1[1].Width / 2) < gclass22_0.vector2_0.X + 32f)
		{
			gclass22_0.int_21 = (int)(this.vector2_0.Y + 200f - (float)GClass7.texture2D_1[0].Height - gclass22_0.vector2_0.Y - (float)(GClass7.texture2D_1[1].Height - 12));
			gclass22_0.bool_14 = true;
			this.int_2++;
			if (this.int_2 > 70)
			{
				gclass22_0.bool_18 = true;
				gclass22_0.float_3 = 0f;
				gclass22_0.vector2_1.X = 0f;
			}
			if (this.int_2 > 120)
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

	// Token: 0x06000078 RID: 120 RVA: 0x00004D94 File Offset: 0x00002F94
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		if (this.int_1 == 0)
		{
			GClass0.texture2D_0 = GClass7.texture2D_1[0];
		}
		else
		{
			GClass0.texture2D_0 = GClass7.texture2D_1[8];
		}
		GClass0.spriteEffects_0 = 0;
		base.method_0(vector2_1, float_1);
		GClass0.texture2D_0 = GClass7.texture2D_1[1 + this.int_4];
		GClass0.spriteEffects_0 = 0;
		base.method_0(vector2_1 - new Vector2(0f, (float)(GClass7.texture2D_1[0].Height / 2 - 4)), float_1);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00004E18 File Offset: 0x00003018
	public override void vmethod_4(Vector2 vector2_1, float float_1)
	{
		if (this.int_1 == 0)
		{
			this.vmethod_3(vector2_1, float_1);
		}
		else
		{
			GClass0.texture2D_0 = GClass7.texture2D_1[1 + this.int_4];
			GClass0.spriteEffects_0 = 0;
			base.method_0(vector2_1 - new Vector2(0f, (float)(GClass7.texture2D_1[0].Height / 2 - 4)), float_1);
		}
	}

	// Token: 0x04000034 RID: 52
	private static Texture2D[] texture2D_1;

	// Token: 0x04000035 RID: 53
	private int int_2 = 0;

	// Token: 0x04000036 RID: 54
	private static int int_3 = 0;

	// Token: 0x04000037 RID: 55
	private int int_4 = 0;
}
