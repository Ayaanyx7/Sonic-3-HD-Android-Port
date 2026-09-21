using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000016 RID: 22
public class GClass0
{
	// Token: 0x0600004A RID: 74 RVA: 0x00002288 File Offset: 0x00000488
	public virtual void Update()
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002B24 File Offset: 0x00000D24
	public virtual bool vmethod_0(GClass22 gclass22_0)
	{
		return (this.rectangle_0.Width == 1 || this.rectangle_0.Height <= 1) && false;
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002288 File Offset: 0x00000488
	public virtual void vmethod_1()
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002288 File Offset: 0x00000488
	public virtual void vmethod_2()
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0000228A File Offset: 0x0000048A
	protected void method_0(Vector2 vector2_1, float float_1)
	{
		this.method_1(vector2_1, float_1, 0f);
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002B5C File Offset: 0x00000D5C
	protected void method_1(Vector2 vector2_1, float float_1, float float_2)
	{
		GClass25.gclass25_0.spriteBatch_0.Draw(GClass0.texture2D_0, vector2_1, new Rectangle?(new Rectangle(0, 0, GClass0.texture2D_0.Width, GClass0.texture2D_0.Height)), GClass29.color_0, float_2, new Vector2((float)(GClass0.texture2D_0.Width / 2), (float)(GClass0.texture2D_0.Height / 2)), float_1, GClass0.spriteEffects_0, 0f);
		GClass0.spriteEffects_0 = 0;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002288 File Offset: 0x00000488
	public virtual void vmethod_3(Vector2 vector2_1, float float_1)
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002299 File Offset: 0x00000499
	public virtual void vmethod_4(Vector2 vector2_1, float float_1)
	{
		this.vmethod_3(vector2_1, float_1);
	}

	// Token: 0x04000013 RID: 19
	public Vector2 vector2_0;

	// Token: 0x04000014 RID: 20
	public bool bool_0 = true;

	// Token: 0x04000015 RID: 21
	public int int_0 = 1;

	// Token: 0x04000016 RID: 22
	public int int_1 = 0;

	// Token: 0x04000017 RID: 23
	public bool bool_1 = true;

	// Token: 0x04000018 RID: 24
	public bool bool_2 = false;

	// Token: 0x04000019 RID: 25
	protected static Texture2D texture2D_0;

	// Token: 0x0400001A RID: 26
	protected static SpriteEffects spriteEffects_0;

	// Token: 0x0400001B RID: 27
	protected static float float_0;

	// Token: 0x0400001C RID: 28
	private Rectangle rectangle_0;

	// Token: 0x0400001D RID: 29
	protected bool bool_3 = false;
}
