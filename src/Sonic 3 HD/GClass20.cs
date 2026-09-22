using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200002A RID: 42
public class GClass20 : GClass0
{
	// Token: 0x060000B3 RID: 179 RVA: 0x000070C0 File Offset: 0x000052C0
	public override void vmethod_2()
	{
		GClass20.texture2D_1 = new Texture2D[1];
		for (int i = 0; i < GClass20.texture2D_1.Length; i++)
		{
			GClass20.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/mushmeanie" + i);
		}
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002288 File Offset: 0x00000488
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x000027AC File Offset: 0x000009AC
	public GClass20()
	{
		this.int_2 = 0;
		this.bool_1 = false;
		this.bool_2 = true;
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x000027D7 File Offset: 0x000009D7
	public override void Update()
	{
		this.int_2++;
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x000027E7 File Offset: 0x000009E7
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		return false;
	}

	// Token: 0x0400005A RID: 90
	private static Texture2D[] texture2D_1;

	// Token: 0x0400005B RID: 91
	private int int_2;

	// Token: 0x0400005C RID: 92
	private bool bool_4 = false;

	// Token: 0x0400005D RID: 93
	private int int_3 = 0;
}
