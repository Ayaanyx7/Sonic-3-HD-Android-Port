using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000028 RID: 40
public class GClass18 : GClass0
{
	// Token: 0x060000A5 RID: 165 RVA: 0x00006188 File Offset: 0x00004388
	public override void vmethod_2()
	{
		GClass18.texture2D_1 = new Texture2D[14];
		for (int i = 0; i < 8; i++)
		{
			GClass18.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/dragonflyHead" + i);
		}
		for (int i = 0; i < 6; i++)
		{
			GClass18.texture2D_1[i + 8] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/dragonflyHead" + (6 - i));
		}
		GClass18.texture2D_2 = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/dragonflyWings0");
		GClass18.texture2D_3 = new Texture2D[5];
		for (int i = 0; i < 5; i++)
		{
			GClass18.texture2D_3[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/dragonflyTail" + i);
		}
		GClass18.texture2D_4 = new Texture2D[5];
		for (int i = 0; i < 5; i++)
		{
			GClass18.texture2D_4[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/dragonflyTail" + (i + 5));
		}
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x000062A8 File Offset: 0x000044A8
	private Vector2 method_2(int int_4, Vector2 vector2_1)
	{
		return this.method_3(int_4, vector2_1, 120);
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x000062C4 File Offset: 0x000044C4
	private Vector2 method_3(int int_4, Vector2 vector2_1, int int_5)
	{
		Vector2 zero = Vector2.Zero;
		double num = Math.Sin((double)(int_4 % (2 * int_5)) * 3.1415926535897931 / (double)int_5);
		if (num < -0.9)
		{
			num = -0.9;
		}
		if (num > 0.9)
		{
			num = 0.9;
		}
		zero.Y = vector2_1.Y + 280f * (float)((double)Math.Sign(num) * Math.Pow(Math.Abs(num), 1.0));
		int_5 /= 4;
		num = Math.Sin((double)(int_4 % (2 * int_5)) * 3.1415926535897931 / (double)int_5);
		zero.X = vector2_1.X + 80f * (float)((double)Math.Sign(num) * Math.Pow(Math.Abs(num), 0.85000002384185791));
		return zero;
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x000063AC File Offset: 0x000045AC
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		if (!this.bool_4)
		{
			int num = this.int_2 % 240;
			GClass0.spriteEffects_0 = 1;
			int num2 = 8;
			GClass0.texture2D_0 = GClass18.texture2D_4[4];
			if (num > 60 && num < 180)
			{
				GClass0.spriteEffects_0 = 0;
			}
			else
			{
				GClass0.spriteEffects_0 = 2;
			}
			Vector2 vector = this.method_3((num2 * this.int_2 - num2 * 2 * 7 - 14) % (240 * num2), vector2_1, 120 * num2);
			base.method_0(vector, float_1);
			GClass0.texture2D_0 = GClass18.texture2D_3[4];
			for (int i = 6; i > 0; i--)
			{
				if (num > 60 && num < 180)
				{
					GClass0.spriteEffects_0 = 0;
				}
				else
				{
					GClass0.spriteEffects_0 = 2;
				}
				vector = this.method_3((num2 * this.int_2 - num2 * 2 * i - 2 * i) % (240 * num2), vector2_1, 120 * num2);
				base.method_0(vector, float_1);
			}
			GClass0.texture2D_0 = GClass18.texture2D_1[this.int_2 / 28 % 14];
			vector = this.method_2(num, vector2_1);
			base.method_0(vector, float_1);
			GClass0.spriteEffects_0 = 0;
			if (GClass29.color_0.R > 200)
			{
				switch (num % 4)
				{
				case 0:
					GClass0.texture2D_0 = GClass18.texture2D_2;
					base.method_0(vector, float_1);
					break;
				case 1:
					GClass0.texture2D_0 = GClass18.texture2D_2;
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass0.texture2D_0, vector, new Rectangle?(new Rectangle(0, 0, GClass0.texture2D_0.Width, GClass0.texture2D_0.Height)), Color.LightGray, 0f, new Vector2((float)(GClass0.texture2D_0.Width / 2), (float)(GClass0.texture2D_0.Height / 2)), float_1, GClass0.spriteEffects_0, 0f);
					GClass0.texture2D_0 = GClass18.texture2D_2;
					GClass0.spriteEffects_0 = 2;
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass0.texture2D_0, vector, new Rectangle?(new Rectangle(0, 0, GClass0.texture2D_0.Width, GClass0.texture2D_0.Height)), Color.LightGray, 0f, new Vector2((float)(GClass0.texture2D_0.Width / 2), (float)(GClass0.texture2D_0.Height / 2)), float_1, GClass0.spriteEffects_0, 0f);
					break;
				case 2:
					GClass0.texture2D_0 = GClass18.texture2D_2;
					GClass0.spriteEffects_0 = 2;
					base.method_0(vector, float_1);
					break;
				case 3:
					GClass0.texture2D_0 = GClass18.texture2D_2;
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass0.texture2D_0, vector, new Rectangle?(new Rectangle(0, 0, GClass0.texture2D_0.Width, GClass0.texture2D_0.Height)), Color.LightGray, 0f, new Vector2((float)(GClass0.texture2D_0.Width / 2), (float)(GClass0.texture2D_0.Height / 2)), float_1, GClass0.spriteEffects_0, 0f);
					GClass0.texture2D_0 = GClass18.texture2D_2;
					GClass0.spriteEffects_0 = 2;
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass0.texture2D_0, vector, new Rectangle?(new Rectangle(0, 0, GClass0.texture2D_0.Width, GClass0.texture2D_0.Height)), Color.LightGray, 0f, new Vector2((float)(GClass0.texture2D_0.Width / 2), (float)(GClass0.texture2D_0.Height / 2)), float_1, GClass0.spriteEffects_0, 0f);
					break;
				}
			}
			GClass0.spriteEffects_0 = 0;
		}
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00006724 File Offset: 0x00004924
	public override void vmethod_4(Vector2 vector2_1, float float_1)
	{
		if (!this.bool_3)
		{
			if (this.bool_4)
			{
				GClass0.texture2D_0 = GClass29.texture2D_13;
				if (this.int_3 < 26)
				{
					base.method_0(vector2_1 + new Vector2(0f, (float)(-(float)this.int_3 * 4)), float_1);
				}
				else
				{
					base.method_0(vector2_1 + new Vector2(0f, -104f), float_1);
				}
			}
			else
			{
				this.vmethod_3(vector2_1, float_1);
			}
			GClass0.spriteEffects_0 = 0;
		}
	}

	// Token: 0x060000AA RID: 170 RVA: 0x0000274B File Offset: 0x0000094B
	public GClass18()
	{
		this.int_2 = 0;
		this.bool_1 = false;
		this.bool_2 = true;
		this.int_2 = 240;
	}

	// Token: 0x060000AB RID: 171 RVA: 0x000067B0 File Offset: 0x000049B0
	public override void Update()
	{
		this.int_2++;
		if (this.bool_4)
		{
			this.int_3++;
			if (this.int_3 > 51)
			{
				this.bool_3 = true;
			}
			if (this.bool_3)
			{
				this.bool_1 = false;
				this.bool_2 = false;
			}
		}
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00006814 File Offset: 0x00004A14
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (!this.bool_4)
		{
			Vector2[] array = new Vector2[8];
			int int_ = this.int_2 % 240;
			int num = 8;
			GClass0.texture2D_0 = GClass18.texture2D_3[4];
			int i;
			for (i = 6; i > 0; i--)
			{
				array[i] = this.method_3((num * this.int_2 - num * 2 * i - 2 * i) % (240 * num), this.vector2_0, 120 * num);
			}
			array[7] = this.method_3((num * this.int_2 - num * 2 * 7 - 14) % (240 * num), this.vector2_0, 120 * num);
			array[0] = this.method_2(int_, this.vector2_0);
			i = 0;
			while (i < array.Length)
			{
				if (i != 0 || (gclass22_0.vector2_0.X - 20f - (float)gclass22_0.int_29 >= array[i].X + 30f || array[i].X - 30f >= gclass22_0.vector2_0.X + 20f + (float)gclass22_0.int_29) || (gclass22_0.vector2_0.Y - 80f - 60f - (float)gclass22_0.int_29 >= array[i].Y + 30f || array[i].Y - 30f >= gclass22_0.vector2_0.Y - 80f + 40f + (float)gclass22_0.int_29))
				{
					if (i <= 3 || (gclass22_0.vector2_0.X - 20f >= array[i].X + 30f || array[i].X - 30f >= gclass22_0.vector2_0.X + 20f) || (gclass22_0.vector2_0.Y - 80f - 60f >= array[i].Y + 30f || array[i].Y - 30f >= gclass22_0.vector2_0.Y - 80f + 40f))
					{
						i++;
						continue;
					}
					bool flag;
					if (gclass22_0.genum4_0 != (GEnum4)5 && gclass22_0.genum4_0 != (GEnum4)6)
					{
						if (gclass22_0.genum4_0 != (GEnum4)3)
						{
							flag = true;
							goto IL_33A;
						}
					}
					flag = (i != 0);
					IL_33A:
					if (!flag)
					{
						gclass22_0.int_19 += 100;
						GClass30.soundEffect_6.Play(GClass30.float_0, 0f, 0f);
						this.bool_4 = true;
						gclass22_0.method_22((int)this.vector2_0.Y);
					}
					else
					{
						gclass22_0.method_21((int)this.vector2_0.X, (int)this.vector2_0.Y);
					}
				}
				else
				{
					bool flag2;
					if (gclass22_0.genum4_0 != (GEnum4)5 && gclass22_0.genum4_0 != (GEnum4)6)
					{
						if (gclass22_0.genum4_0 != (GEnum4)3)
						{
							flag2 = true;
							goto IL_2A7;
						}
					}
					flag2 = (i != 0);
					IL_2A7:
					if (!flag2)
					{
						gclass22_0.int_19 += 100;
						GClass30.soundEffect_6.Play(GClass30.float_0, 0f, 0f);
						this.bool_4 = true;
						gclass22_0.method_22((int)this.vector2_0.Y);
					}
					else
					{
						gclass22_0.method_21((int)this.vector2_0.X, (int)this.vector2_0.Y);
					}
				}
				IL_39E:
				return false;
			}
			goto IL_39E;
		}
		return false;
	}

	// Token: 0x0400004F RID: 79
	private static Texture2D[] texture2D_1;

	// Token: 0x04000050 RID: 80
	private static Texture2D texture2D_2;

	// Token: 0x04000051 RID: 81
	private static Texture2D[] texture2D_3;

	// Token: 0x04000052 RID: 82
	private static Texture2D[] texture2D_4;

	// Token: 0x04000053 RID: 83
	private int int_2;

	// Token: 0x04000054 RID: 84
	private bool bool_4 = false;

	// Token: 0x04000055 RID: 85
	private int int_3 = 0;
}
