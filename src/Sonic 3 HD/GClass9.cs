using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200001F RID: 31
public class GClass9 : GClass0
{
	// Token: 0x06000080 RID: 128 RVA: 0x00005080 File Offset: 0x00003280
	public override void vmethod_2()
	{
		GClass9.texture2D_1 = new Texture2D[3];
		GClass9.texture2D_2 = new Texture2D[1];
		for (int i = 0; i < GClass9.texture2D_1.Length; i++)
		{
			GClass9.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/bouncingMushroomCap" + i);
		}
		for (int i = 0; i < GClass9.texture2D_2.Length; i++)
		{
			GClass9.texture2D_2[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/bouncingMushroomStem" + i);
		}
	}

	// Token: 0x06000081 RID: 129 RVA: 0x000024CC File Offset: 0x000006CC
	public GClass9()
	{
		this.int_3 = 0;
		this.int_0 = 4;
		this.int_4 = 0;
	}

	// Token: 0x06000082 RID: 130 RVA: 0x000024F7 File Offset: 0x000006F7
	public override void Update()
	{
		this.int_3++;
		this.int_4--;
		if (this.int_4 < 0)
		{
			this.int_4 = 0;
		}
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00005118 File Offset: 0x00003318
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (gclass22_0.genum0_0 != (GEnum0)4)
		{
			GClass9.int_2 = 0;
		}
		if (gclass22_0.vector2_0.Y - 120f < this.vector2_0.Y + 32f && this.vector2_0.Y < gclass22_0.vector2_0.Y + 0f && !gclass22_0.bool_10 && gclass22_0.vector2_1.Y > 0f && gclass22_0.vector2_0.X - 36f < this.vector2_0.X + (float)(GClass9.texture2D_1[0].Width / 3) && this.vector2_0.X - (float)(GClass9.texture2D_1[0].Width / 3) < gclass22_0.vector2_0.X + 36f)
		{
			GClass30.soundEffect_1.Play(GClass30.float_0, 0f, 0f);
			gclass22_0.genum4_0 = (GEnum4)8;
			this.int_4 = 10;
			if (GClass9.int_2 == 0)
			{
				gclass22_0.vector2_1.Y = -26f;
			}
			if (GClass9.int_2 == 1)
			{
				gclass22_0.vector2_1.Y = -30f;
			}
			if (GClass9.int_2 == 2)
			{
				gclass22_0.vector2_1.Y = -34f;
			}
			if (GClass9.int_2 < 2)
			{
				GClass9.int_2++;
			}
		}
		return false;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x000052AC File Offset: 0x000034AC
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		GClass0.spriteEffects_0 = 0;
		GClass0.texture2D_0 = GClass9.texture2D_2[0];
		base.method_0(vector2_1 + new Vector2(0f, (float)(GClass9.texture2D_1[0].Height / 2 + GClass0.texture2D_0.Height / 2 - 2)), float_1);
		GClass0.texture2D_0 = GClass9.texture2D_1[0];
		if (this.int_4 > 7)
		{
			GClass0.texture2D_0 = GClass9.texture2D_1[2];
		}
		else if (this.int_4 > 4)
		{
			GClass0.texture2D_0 = GClass9.texture2D_1[1];
		}
		base.method_0(vector2_1 + new Vector2(10f * (float)Math.Sin(0.07 * (double)this.int_3), 0f), float_1);
	}

	// Token: 0x0400003A RID: 58
	private static Texture2D[] texture2D_1;

	// Token: 0x0400003B RID: 59
	private static Texture2D[] texture2D_2;

	// Token: 0x0400003C RID: 60
	private static int int_2 = 0;

	// Token: 0x0400003D RID: 61
	private int int_3 = 0;

	// Token: 0x0400003E RID: 62
	private int int_4 = 0;
}
