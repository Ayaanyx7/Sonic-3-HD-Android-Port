using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000029 RID: 41
public class GClass19 : GClass0
{
	// Token: 0x060000AD RID: 173 RVA: 0x00006BC4 File Offset: 0x00004DC4
	public override void vmethod_2()
	{
		GClass19.texture2D_1 = new Texture2D[5];
		for (int i = 0; i < GClass19.texture2D_1.Length; i++)
		{
			GClass19.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/madmole" + i);
		}
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00006C18 File Offset: 0x00004E18
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		if (!this.bool_4)
		{
			GClass0.texture2D_0 = GClass19.texture2D_1[1];
			if (!this.bool_0)
			{
				GClass0.spriteEffects_0 = 1;
			}
			else
			{
				GClass0.spriteEffects_0 = 0;
			}
			int num = this.int_2 % 190;
			if (0 >= num || num >= 70)
			{
				if (70 <= num && num <= 100)
				{
					base.method_0(vector2_1 + new Vector2(0f, (float)(GClass0.texture2D_0.Height * (100 - num)) / 30f), float_1);
				}
				if (100 < num && num < 160)
				{
					base.method_0(vector2_1, float_1);
				}
				if (160 <= num && num <= 190)
				{
					base.method_0(vector2_1 + new Vector2(0f, (float)(GClass0.texture2D_0.Height * (num - 160)) / 30f), float_1);
				}
				GClass0.spriteEffects_0 = 0;
			}
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00006D1C File Offset: 0x00004F1C
	public override void vmethod_4(Vector2 vector2_1, float float_1)
	{
		GClass0.texture2D_0 = GClass19.texture2D_1[0];
		base.method_0(vector2_1 + new Vector2(0f, (float)(GClass19.texture2D_1[0].Height + GClass0.texture2D_0.Height / 2)), float_1);
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
			GClass0.spriteEffects_0 = 0;
		}
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002781 File Offset: 0x00000981
	public GClass19()
	{
		this.int_2 = 0;
		this.bool_1 = true;
		this.bool_2 = true;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00006DDC File Offset: 0x00004FDC
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
			}
		}
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00006E38 File Offset: 0x00005038
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		bool result;
		if (this.bool_4)
		{
			result = false;
		}
		else
		{
			gclass22_0.vector2_0 - (this.vector2_0 + new Vector2(0f, 80f));
			if (gclass22_0.vector2_0.X > this.vector2_0.X)
			{
				this.bool_0 = true;
			}
			else
			{
				this.bool_0 = false;
			}
			int num = this.int_2 % 190;
			if (0 < num && num < 70)
			{
				result = false;
			}
			else
			{
				float num2;
				if (70 <= num && num <= 100)
				{
					num2 = (float)(GClass0.texture2D_0.Height * (100 - num)) / 30f;
				}
				if (100 < num && num < 160)
				{
				}
				if (160 <= num && num <= 190)
				{
					num2 = (float)(GClass0.texture2D_0.Height * (num - 160)) / 30f;
				}
				int height = GClass19.texture2D_1[1].Height;
				num2 = 0f;
				if (gclass22_0.vector2_0.X - 20f < this.vector2_0.X + 80f && this.vector2_0.X - 80f < gclass22_0.vector2_0.X + 20f && gclass22_0.vector2_0.Y - 80f - 60f < this.vector2_0.Y + (float)(GClass19.texture2D_1[1].Height / 2) && this.vector2_0.Y - (float)(GClass19.texture2D_1[1].Height / 2) + num2 < gclass22_0.vector2_0.Y - 80f + 40f && (double)num2 <= 0.9 * (double)GClass19.texture2D_1[1].Height)
				{
					if (gclass22_0.genum4_0 == (GEnum4)5 || gclass22_0.genum4_0 == (GEnum4)6 || gclass22_0.genum4_0 == (GEnum4)3)
					{
						gclass22_0.int_19 += 100;
						GClass30.soundEffect_6.Play(GClass30.float_0, 0f, 0f);
						gclass22_0.method_22((int)this.vector2_0.Y);
						this.bool_4 = true;
					}
					else
					{
						gclass22_0.method_21((int)this.vector2_0.X, (int)this.vector2_0.Y);
					}
				}
				result = false;
			}
		}
		return result;
	}

	// Token: 0x04000056 RID: 86
	private static Texture2D[] texture2D_1;

	// Token: 0x04000057 RID: 87
	private int int_2;

	// Token: 0x04000058 RID: 88
	private bool bool_4 = false;

	// Token: 0x04000059 RID: 89
	private int int_3 = 0;
}
