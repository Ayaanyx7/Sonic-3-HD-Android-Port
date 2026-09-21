using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000020 RID: 32
public class GClass10 : GClass0
{
	// Token: 0x06000086 RID: 134 RVA: 0x00005378 File Offset: 0x00003578
	public override void vmethod_2()
	{
		GClass10.texture2D_1 = new Texture2D[3];
		for (int i = 0; i < GClass10.texture2D_1.Length; i++)
		{
			GClass10.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/woodStand" + i);
		}
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002532 File Offset: 0x00000732
	public GClass10()
	{
		this.bool_1 = false;
		this.bool_2 = true;
		this.int_0 = 3;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0000254F File Offset: 0x0000074F
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		GClass0.texture2D_0 = GClass10.texture2D_1[this.int_1];
		GClass0.spriteEffects_0 = 0;
		base.method_0(vector2_1, float_1);
	}

	// Token: 0x0400003F RID: 63
	private static Texture2D[] texture2D_1;
}
