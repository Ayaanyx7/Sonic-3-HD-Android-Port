using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000021 RID: 33
public class GClass11 : GClass0
{
	// Token: 0x06000089 RID: 137 RVA: 0x00002570 File Offset: 0x00000770
	public override void vmethod_2()
	{
		GClass11.texture2D_1 = GClass25.gclass25_0.Content.Load<Texture2D>("objects/shroom");
	}

	// Token: 0x0600008A RID: 138 RVA: 0x0000258B File Offset: 0x0000078B
	public GClass11()
	{
		this.int_0 = 4;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000053CC File Offset: 0x000035CC
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		GClass0.texture2D_0 = GClass11.texture2D_1;
		if (this.int_1 / 2 == 0)
		{
			this.bool_1 = true;
			this.bool_2 = false;
		}
		else
		{
			this.bool_1 = false;
			this.bool_2 = true;
		}
		if (this.int_1 % 2 == 1)
		{
			GClass0.spriteEffects_0 = 1;
		}
		else
		{
			GClass0.spriteEffects_0 = 0;
		}
		base.method_0(vector2_1, float_1);
	}

	// Token: 0x04000040 RID: 64
	private static Texture2D texture2D_1;
}
