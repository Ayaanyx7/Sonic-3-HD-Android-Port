using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000027 RID: 39
public class GClass17 : GClass0
{
	// Token: 0x0600009F RID: 159 RVA: 0x00005DD8 File Offset: 0x00003FD8
	public override void vmethod_2()
	{
		GClass17.texture2D_1 = new Texture2D[8];
		for (int i = 0; i < 5; i++)
		{
			GClass17.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/butterdroid" + i);
		}
		GClass17.texture2D_1[5] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/butterdroid" + 3);
		GClass17.texture2D_1[6] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/butterdroid" + 2);
		GClass17.texture2D_1[7] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/badniks/butterdroid" + 1);
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x000026E0 File Offset: 0x000008E0
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		GClass0.texture2D_0 = GClass17.texture2D_1[this.int_2 / 8 % 8];
		if (!this.bool_0)
		{
			GClass0.spriteEffects_0 = 1;
		}
		else
		{
			GClass0.spriteEffects_0 = 0;
		}
		if (!this.bool_3)
		{
			base.method_0(vector2_1, float_1);
		}
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00005E98 File Offset: 0x00004098
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
		}
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002720 File Offset: 0x00000920
	public GClass17()
	{
		this.int_2 = 0;
		this.bool_1 = false;
		this.bool_2 = true;
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00005F20 File Offset: 0x00004120
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

	// Token: 0x060000A4 RID: 164 RVA: 0x00005F84 File Offset: 0x00004184
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		bool result;
		if (this.bool_4)
		{
			result = false;
		}
		else
		{
			Vector2 vector = gclass22_0.vector2_0 - (this.vector2_0 + new Vector2(0f, 80f));
			if (gclass22_0.vector2_0.X > this.vector2_0.X)
			{
				this.bool_0 = true;
			}
			else
			{
				this.bool_0 = false;
			}
			if (vector.Length() < 1000f)
			{
				vector.Normalize();
				this.vector2_0 += vector * 2.7f;
			}
			if (gclass22_0.vector2_0.X - 20f - (float)gclass22_0.int_29 < this.vector2_0.X + 30f && this.vector2_0.X - 30f < gclass22_0.vector2_0.X + 20f + (float)gclass22_0.int_29 && gclass22_0.vector2_0.Y - 80f - 60f - (float)gclass22_0.int_29 < this.vector2_0.Y + 30f && this.vector2_0.Y - 30f < gclass22_0.vector2_0.Y - 80f + 40f + (float)gclass22_0.int_29)
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
		return result;
	}

	// Token: 0x0400004B RID: 75
	private static Texture2D[] texture2D_1;

	// Token: 0x0400004C RID: 76
	private int int_2;

	// Token: 0x0400004D RID: 77
	private bool bool_4 = false;

	// Token: 0x0400004E RID: 78
	private int int_3 = 0;
}
