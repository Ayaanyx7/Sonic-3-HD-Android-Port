using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200001C RID: 28
public class GClass6 : GClass0
{
	// Token: 0x0600006F RID: 111 RVA: 0x00004770 File Offset: 0x00002970
	public override void vmethod_2()
	{
		GClass6.texture2D_1 = new Texture2D[2];
		for (int i = 0; i < GClass6.texture2D_1.Length; i++)
		{
			GClass6.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/seesaw" + i);
		}
	}

	// Token: 0x06000070 RID: 112 RVA: 0x000047C4 File Offset: 0x000029C4
	public override void Update()
	{
		if (this.bool_4)
		{
			this.int_2++;
		}
		else
		{
			this.int_2 = 0;
		}
		if (this.int_2 == 81)
		{
			this.bool_4 = false;
			this.int_2 = 0;
		}
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00004810 File Offset: 0x00002A10
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (gclass22_0.vector2_0.Y < this.vector2_0.Y - (float)(GClass6.texture2D_1[0].Height / 2) + 64f + 96f && gclass22_0.vector2_0.Y > this.vector2_0.Y - (float)(GClass6.texture2D_1[0].Height / 2) - 10f && gclass22_0.vector2_0.X - 32f < this.vector2_0.X + 175f && this.vector2_0.X + 85f < gclass22_0.vector2_0.X + 32f)
		{
			if (!this.bool_4)
			{
				gclass22_0.int_21 = (int)(this.vector2_0.Y - (float)(GClass6.texture2D_1[0].Height / 2) - gclass22_0.vector2_0.Y - 8f);
				if (gclass22_0.genum0_0 == (GEnum0)0)
				{
					this.bool_4 = true;
					GClass30.soundEffect_0.Play(GClass30.float_0, 0f, 0f);
					this.int_2 = 0;
				}
			}
			else
			{
				if (this.int_2 == 1)
				{
					gclass22_0.int_21 = (int)(this.vector2_0.Y - (float)(GClass6.texture2D_1[0].Height / 2) + 20f - gclass22_0.vector2_0.Y - 8f);
				}
				if (this.int_2 == 2)
				{
					gclass22_0.int_21 = (int)(this.vector2_0.Y - (float)(GClass6.texture2D_1[0].Height / 2) + 40f - gclass22_0.vector2_0.Y - 8f);
				}
				if (this.int_2 == 3)
				{
					gclass22_0.int_21 = (int)(this.vector2_0.Y - (float)(GClass6.texture2D_1[0].Height / 2) + 60f - gclass22_0.vector2_0.Y - 8f);
				}
				if (this.int_2 > 3)
				{
					gclass22_0.int_21 = (int)(this.vector2_0.Y - (float)(GClass6.texture2D_1[0].Height / 2) + 96f - gclass22_0.vector2_0.Y - 8f);
				}
				if (this.int_2 == 80)
				{
					if (gclass22_0.genum0_0 == (GEnum0)0)
					{
						gclass22_0.genum4_0 = (GEnum4)8;
						gclass22_0.vector2_1.Y = -48f;
						GClass30.soundEffect_1.Play(GClass30.float_0, 0f, 0f);
					}
					this.bool_4 = false;
					this.int_2 = 0;
				}
			}
			gclass22_0.bool_14 = true;
		}
		return false;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002432 File Offset: 0x00000632
	public GClass6()
	{
		this.bool_4 = false;
		this.int_0 = 2;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00004AD0 File Offset: 0x00002CD0
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		GClass0.spriteEffects_0 = 0;
		GClass0.texture2D_0 = GClass6.texture2D_1[1];
		if (this.int_2 == 0)
		{
			base.method_0(vector2_1 - new Vector2(126f, 110f), float_1);
		}
		else
		{
			base.method_0(vector2_1 - new Vector2(126f, 206f + (35.8f * (float)this.int_2 - 0.875f * (float)this.int_2 * (float)this.int_2 / 2f)), float_1);
		}
		GClass0.texture2D_0 = GClass6.texture2D_1[0];
		if (!this.bool_4)
		{
			GClass0.spriteEffects_0 = 0;
		}
		else
		{
			GClass0.spriteEffects_0 = 1;
		}
		base.method_0(vector2_1, float_1);
	}

	// Token: 0x04000031 RID: 49
	private static Texture2D[] texture2D_1;

	// Token: 0x04000032 RID: 50
	private int int_2 = 0;

	// Token: 0x04000033 RID: 51
	private bool bool_4 = true;
}
