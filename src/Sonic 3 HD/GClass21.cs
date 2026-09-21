using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200002B RID: 43
public class GClass21 : GClass0
{
	// Token: 0x060000B8 RID: 184 RVA: 0x00007114 File Offset: 0x00005314
	public override void vmethod_2()
	{
		GClass21.texture2D_1 = new Texture2D[1];
		for (int i = 0; i < GClass21.texture2D_1.Length; i++)
		{
			GClass21.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/cluckoid" + i);
		}
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x000027EA File Offset: 0x000009EA
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		if (!this.bool_4)
		{
			GClass0.texture2D_0 = GClass21.texture2D_1[0];
			base.method_0(vector2_1, float_1);
			GClass0.spriteEffects_0 = 0;
		}
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002811 File Offset: 0x00000A11
	public GClass21()
	{
		this.int_2 = 0;
		this.bool_1 = false;
		this.bool_2 = true;
	}

	// Token: 0x060000BB RID: 187 RVA: 0x0000283C File Offset: 0x00000A3C
	public override void Update()
	{
		this.int_2++;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x000027E7 File Offset: 0x000009E7
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		return false;
	}

	// Token: 0x0400005E RID: 94
	private static Texture2D[] texture2D_1;

	// Token: 0x0400005F RID: 95
	private int int_2;

	// Token: 0x04000060 RID: 96
	private bool bool_4 = false;

	// Token: 0x04000061 RID: 97
	private int int_3 = 0;
}
