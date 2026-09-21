using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000025 RID: 37
public class GClass15 : GClass0
{
	// Token: 0x06000097 RID: 151 RVA: 0x00002649 File Offset: 0x00000849
	public override void vmethod_2()
	{
		GClass15.texture2D_1 = GClass25.gclass25_0.Content.Load<Texture2D>("objects/spinPipe");
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002664 File Offset: 0x00000864
	public GClass15()
	{
		this.int_0 = 2;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002673 File Offset: 0x00000873
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		GClass0.spriteEffects_0 = 0;
		GClass0.texture2D_0 = GClass15.texture2D_1;
		if (this.int_1 == 0)
		{
			base.method_1(vector2_1, float_1, 0f);
		}
		else
		{
			base.method_1(vector2_1, float_1, 1.57079637f);
		}
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00005A48 File Offset: 0x00003C48
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (this.int_1 == 0)
		{
			if (gclass22_0.vector2_1.Y < -8f && gclass22_0.vector2_0.X + 12f > this.vector2_0.X - (float)(GClass15.texture2D_1.Width / 2) && gclass22_0.vector2_0.X - 12f < this.vector2_0.X + (float)(GClass15.texture2D_1.Width / 2) && gclass22_0.vector2_0.Y < this.vector2_0.Y + 120f && gclass22_0.vector2_0.Y > this.vector2_0.Y + 80f)
			{
				gclass22_0.genum4_0 = (GEnum4)13;
				GClass30.soundEffect_23.Play(GClass30.float_0, 0f, 0f);
				gclass22_0.vector2_0.Y = this.vector2_0.Y + 76f;
				gclass22_0.int_27 = 0;
			}
			if (gclass22_0.vector2_1.Y > 8f && gclass22_0.vector2_0.X + 12f > this.vector2_0.X - (float)(GClass15.texture2D_1.Width / 2) && gclass22_0.vector2_0.X - 12f < this.vector2_0.X + (float)(GClass15.texture2D_1.Width / 2) && gclass22_0.vector2_0.Y < this.vector2_0.Y + 72f && gclass22_0.vector2_0.Y > this.vector2_0.Y + 32f)
			{
				gclass22_0.genum4_0 = (GEnum4)13;
				GClass30.soundEffect_23.Play(GClass30.float_0, 0f, 0f);
				gclass22_0.vector2_0.Y = this.vector2_0.Y + 76f;
				gclass22_0.int_27 = 0;
			}
		}
		return true;
	}

	// Token: 0x04000048 RID: 72
	private static Texture2D texture2D_1;
}
