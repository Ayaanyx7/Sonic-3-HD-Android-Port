using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000026 RID: 38
public class GClass16 : GClass0
{
	// Token: 0x0600009B RID: 155 RVA: 0x000026AF File Offset: 0x000008AF
	public override void vmethod_2()
	{
		this.int_0 = 1;
		GClass16.texture2D_1 = GClass25.gclass25_0.Content.Load<Texture2D>("objects/switch");
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00005C74 File Offset: 0x00003E74
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		bool flag = false;
		if (gclass22_0.vector2_0.Y - 120f < this.vector2_0.Y && this.vector2_0.Y - 32f < gclass22_0.vector2_0.Y && gclass22_0.vector2_0.X - 48f < this.vector2_0.X + (float)(GClass16.texture2D_1.Width / 2) && this.vector2_0.X - (float)(GClass16.texture2D_1.Width / 2) < gclass22_0.vector2_0.X + 48f)
		{
			flag = true;
			if (!this.bool_4 && !gclass22_0.bool_10 && gclass22_0.vector2_1.Y > 0f)
			{
				this.bool_4 = true;
				GClass30.soundEffect_21.Play(GClass30.float_0, 0f, 0f);
			}
		}
		if (!flag)
		{
			this.bool_4 = flag;
		}
		return false;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00005D88 File Offset: 0x00003F88
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		GClass0.texture2D_0 = GClass16.texture2D_1;
		if (this.bool_4)
		{
			base.method_0(vector2_1 + new Vector2(0f, (float)(GClass16.texture2D_1.Height / 3)), float_1);
		}
		else
		{
			base.method_0(vector2_1, float_1);
		}
	}

	// Token: 0x04000049 RID: 73
	private static Texture2D texture2D_1;

	// Token: 0x0400004A RID: 74
	private bool bool_4 = false;
}
