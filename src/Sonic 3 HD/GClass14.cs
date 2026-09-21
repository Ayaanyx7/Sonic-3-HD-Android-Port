using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000024 RID: 36
public class GClass14 : GClass0
{
	// Token: 0x06000094 RID: 148 RVA: 0x0000260B File Offset: 0x0000080B
	public override void vmethod_2()
	{
		this.int_0 = 1;
		GClass14.texture2D_1 = GClass25.gclass25_0.Content.Load<Texture2D>("objects/wallBarrier");
	}

	// Token: 0x06000095 RID: 149 RVA: 0x0000262D File Offset: 0x0000082D
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		GClass0.texture2D_0 = GClass14.texture2D_1;
		base.method_0(vector2_1, float_1);
	}

	// Token: 0x04000047 RID: 71
	private static Texture2D texture2D_1;
}
