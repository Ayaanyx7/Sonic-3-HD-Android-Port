using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200001A RID: 26
public class GClass4 : GClass0
{
	// Token: 0x06000066 RID: 102 RVA: 0x00003D7C File Offset: 0x00001F7C
	public override void vmethod_2()
	{
		GClass4.texture2D_1 = new Texture2D[2];
		GClass4.texture2D_1[0] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/yellowSpring");
		GClass4.texture2D_1[1] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/redSpring");
	}

	// Token: 0x06000067 RID: 103 RVA: 0x0000236C File Offset: 0x0000056C
	public GClass4()
	{
		this.int_0 = 16;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00003DCC File Offset: 0x00001FCC
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		int num = this.int_1 / 2;
		switch (num)
		{
		case 0:
			if (gclass22_0.vector2_0.Y - 120f < this.vector2_0.Y + 32f && this.vector2_0.Y - 32f < gclass22_0.vector2_0.Y + 20f)
			{
				if (!gclass22_0.bool_10 && gclass22_0.vector2_1.Y > 0f)
				{
					if (gclass22_0.vector2_0.X - 48f < this.vector2_0.X + (float)(GClass4.texture2D_1[0].Width / 2) && this.vector2_0.X - (float)(GClass4.texture2D_1[0].Width / 2) < gclass22_0.vector2_0.X + 48f)
					{
						GClass30.soundEffect_11.Play(GClass30.float_0, 0f, 0f);
						gclass22_0.genum4_0 = (GEnum4)8;
						gclass22_0.bool_10 = false;
						if (this.int_1 % 2 == 0)
						{
							gclass22_0.vector2_1.Y = -48f;
						}
						else
						{
							gclass22_0.vector2_1.Y = -64f;
						}
					}
				}
				else if (gclass22_0.bool_10 && gclass22_0.vector2_0.Y - 120f < this.vector2_0.Y + 32f && this.vector2_0.Y - 32f < gclass22_0.vector2_0.Y - 2f)
				{
					float num2 = this.vector2_0.X + (float)(GClass4.texture2D_1[0].Width / 2) - gclass22_0.vector2_0.X;
					float num3 = this.vector2_0.X - (float)(GClass4.texture2D_1[0].Width / 2) - gclass22_0.vector2_0.X;
					if (gclass22_0.float_3 < 0f && num2 > -44f && num2 <= 0f)
					{
						gclass22_0.vector2_0.X = this.vector2_0.X + (float)(GClass4.texture2D_1[0].Width / 2) + 44f;
						gclass22_0.bool_12 = true;
						gclass22_0.float_11 = num2;
						gclass22_0.float_12 = num3;
					}
					if (gclass22_0.float_3 > 0f && num3 < 44f && num3 >= 0f)
					{
						gclass22_0.vector2_0.X = this.vector2_0.X - (float)(GClass4.texture2D_1[0].Width / 2) - 44f;
						gclass22_0.bool_13 = true;
						gclass22_0.float_11 = num2;
						gclass22_0.float_12 = num3;
					}
				}
			}
			break;
		case 1:
			break;
		case 2:
			if (gclass22_0.vector2_0.Y < this.vector2_0.Y - (float)(GClass4.texture2D_1[0].Width / 2) + 64f && gclass22_0.vector2_0.X - 32f < this.vector2_0.X + (float)(GClass4.texture2D_1[0].Height / 2) && this.vector2_0.X - (float)(GClass4.texture2D_1[0].Height / 2) - 8f < gclass22_0.vector2_0.X + 32f)
			{
				gclass22_0.int_21 = (int)(this.vector2_0.Y - (float)(GClass4.texture2D_1[0].Width / 2) - gclass22_0.vector2_0.Y - 8f);
				gclass22_0.bool_14 = true;
				if (gclass22_0.genum0_0 != (GEnum0)0)
				{
				}
			}
			if (gclass22_0.vector2_0.Y - 120f < this.vector2_0.Y + 32f && this.vector2_0.Y - 32f < gclass22_0.vector2_0.Y)
			{
				float num4 = gclass22_0.vector2_0.X - 32f;
				float x = this.vector2_0.X;
				int width = GClass4.texture2D_1[0].Width;
				if (num4 < x + 0f && this.vector2_0.X - (float)(GClass4.texture2D_1[0].Width / 4) < gclass22_0.vector2_0.X + 32f)
				{
					if (this.int_1 % 2 == 0)
					{
						gclass22_0.vector2_1.X = -48f;
					}
					else
					{
						gclass22_0.vector2_1.X = -64f;
					}
					if (gclass22_0.genum0_0 == (GEnum0)2)
					{
						gclass22_0.float_3 = -gclass22_0.vector2_1.X;
					}
					else
					{
						gclass22_0.float_3 = gclass22_0.vector2_1.X;
					}
					GClass30.soundEffect_11.Play(GClass30.float_0, 0f, 0f);
					gclass22_0.int_30 = 16;
				}
			}
			break;
		default:
			if (num == 6)
			{
				if (gclass22_0.vector2_0.Y < this.vector2_0.Y - (float)(GClass4.texture2D_1[0].Width / 2) + 64f && gclass22_0.vector2_0.X - 32f < this.vector2_0.X + (float)(GClass4.texture2D_1[0].Height / 2) + 8f && this.vector2_0.X - (float)(GClass4.texture2D_1[0].Height / 2) < gclass22_0.vector2_0.X + 32f)
				{
					gclass22_0.int_21 = (int)(this.vector2_0.Y - (float)(GClass4.texture2D_1[0].Width / 2) - gclass22_0.vector2_0.Y - 8f);
					gclass22_0.bool_14 = true;
					if (gclass22_0.genum0_0 != (GEnum0)0)
					{
					}
				}
				if (gclass22_0.vector2_0.Y - 120f < this.vector2_0.Y + 32f && this.vector2_0.Y - 32f < gclass22_0.vector2_0.Y)
				{
					bool flag;
					if (gclass22_0.vector2_0.X - 32f < this.vector2_0.X + (float)(GClass4.texture2D_1[0].Width / 4))
					{
						float x2 = this.vector2_0.X;
						int width2 = GClass4.texture2D_1[0].Width;
						flag = (x2 - 0f >= gclass22_0.vector2_0.X + 32f);
					}
					else
					{
						flag = true;
					}
					if (!flag)
					{
						if (this.int_1 % 2 == 0)
						{
							gclass22_0.vector2_1.X = 48f;
						}
						else
						{
							gclass22_0.vector2_1.X = 64f;
						}
						if (gclass22_0.genum0_0 == (GEnum0)2)
						{
							gclass22_0.float_3 = -gclass22_0.vector2_1.X;
						}
						else
						{
							gclass22_0.float_3 = gclass22_0.vector2_1.X;
						}
						if (gclass22_0.int_30 < 10)
						{
							GClass30.soundEffect_11.Play(GClass30.float_0, 0f, 0f);
						}
						gclass22_0.int_30 = 16;
					}
				}
			}
			break;
		}
		return false;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x0000237C File Offset: 0x0000057C
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		GClass0.spriteEffects_0 = 0;
		GClass0.texture2D_0 = GClass4.texture2D_1[this.int_1 % 2];
		base.method_1(vector2_1, float_1, -6.28318548f * (float)(this.int_1 / 2) / 8f);
	}

	// Token: 0x0400002C RID: 44
	private static Texture2D[] texture2D_1;
}
