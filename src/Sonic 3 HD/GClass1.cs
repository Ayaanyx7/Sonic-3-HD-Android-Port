using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000017 RID: 23
public class GClass1 : GClass0
{
	// Token: 0x06000053 RID: 83 RVA: 0x00002BD4 File Offset: 0x00000DD4
	public override void vmethod_2()
	{
		GClass1.texture2D_1 = new Texture2D[16];
		for (int i = 0; i < GClass1.texture2D_1.Length; i++)
		{
			GClass1.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/ring" + i);
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002C28 File Offset: 0x00000E28
	public override void vmethod_3(Vector2 vector2_2, float float_1)
	{
		if (!this.bool_3)
		{
			GClass0.texture2D_0 = GClass1.texture2D_1[this.int_2 % 30 / 3];
			if (this.bool_5)
			{
				GClass0.texture2D_0 = GClass1.texture2D_1[this.int_2 % 10 / 1];
			}
			GClass0.spriteEffects_0 = 0;
			base.method_0(vector2_2, float_1);
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000022D5 File Offset: 0x000004D5
	public GClass1()
	{
		this.int_2 = 0;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002C88 File Offset: 0x00000E88
	public override void Update()
	{
		if (!this.bool_3)
		{
			this.int_2++;
			if (this.bool_5)
			{
				this.vector2_1.Y = this.vector2_1.Y + 0.375f;
				this.vector2_0 += this.vector2_1;
				this.method_4();
				if (this.int_2 > 256)
				{
					this.bool_3 = true;
				}
			}
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002D08 File Offset: 0x00000F08
	private float method_2(int int_3, int int_4)
	{
		return this.method_3(int_3, int_4, false);
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002D20 File Offset: 0x00000F20
	private float method_3(int int_3, int int_4, bool bool_7)
	{
		float num = 100000f;
		float result;
		if (int_3 < 0)
		{
			result = num;
		}
		else
		{
			GClass24 gclass24_ = GClass29.gclass24_0;
			int num2 = int_3 / 512;
			int num3 = int_4 / 512;
			if (num2 > 191)
			{
				num2 = 191;
			}
			if (num3 > 127)
			{
				num3 = 127;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			GClass23 gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
			int num4 = int_3 - num2 * 512;
			int num5 = int_4 - num3 * 512;
			int num6 = -num5;
			while (num6 + num5 < 512 && num4 < 512 && num5 + num6 < 512)
			{
				if (gclass.bool_0[num5 + num6, num4] && (float)num6 < num)
				{
					num = (float)num6;
				}
				num6++;
			}
			num2 = int_3 / 512;
			num3 = int_4 / 512 + 1;
			if (num2 > 191)
			{
				num2 = 191;
			}
			if (num3 > 127)
			{
				num3 = 127;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			num4 = int_3 - num2 * 512;
			num5 = int_4 - num3 * 512;
			gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
			num6 = -num5;
			while (num6 + num5 < 512 && num4 < 512 && num5 + num6 < 512)
			{
				if (num6 + num5 >= 0 && gclass.bool_0[num5 + num6, num4] && (float)num6 < num)
				{
					num = (float)num6;
				}
				num6++;
			}
			num2 = int_3 / 512;
			num3 = int_4 / 512 - 1;
			if (num2 > 191)
			{
				num2 = 191;
			}
			if (num3 > 127)
			{
				num3 = 127;
			}
			if (num2 < 0)
			{
				num2 = 0;
			}
			if (num3 < 0)
			{
				num3 = 0;
			}
			num4 = int_3 - num2 * 512;
			num5 = int_4 - num3 * 512;
			gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
			num6 = -num5;
			while (num6 + num5 <= 512 && num4 < 512 && num5 + num6 < 512)
			{
				if (num6 + num5 >= 0 && gclass.bool_0[num5 + num6, num4] && num6 > -76 && (float)num6 < num)
				{
					num = (float)num6;
				}
				num6++;
			}
			result = num;
		}
		return result;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002FF8 File Offset: 0x000011F8
	public void method_4()
	{
		if (this.vector2_1.Y > 0f)
		{
			float num = this.method_2((int)this.vector2_0.X, (int)this.vector2_0.Y + 32);
			if (num < 0f && this.vector2_1.Y > 0f)
			{
				this.vector2_1.Y = this.vector2_1.Y * -0.75f;
				this.vector2_0.Y = this.vector2_0.Y - num;
			}
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00003088 File Offset: 0x00001288
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		bool result;
		if (this.bool_3)
		{
			result = false;
		}
		else
		{
			if (!this.bool_6 && gclass22_0.genum1_0 == (GEnum1)3 && (gclass22_0.vector2_0 - this.vector2_0).Length() < 500f)
			{
				this.bool_6 = true;
			}
			if (this.bool_6)
			{
				Vector2 vector = gclass22_0.vector2_0 - this.vector2_0;
				vector.Normalize();
				float num = this.vector2_1.Length();
				this.vector2_1 = vector * num;
				this.vector2_1 += vector * 1f;
				if (this.vector2_1.Length() > 40f)
				{
					this.vector2_1.Normalize();
					this.vector2_1 *= 40f;
				}
				this.vector2_0 += this.vector2_1;
			}
			if (gclass22_0.vector2_0.X - 20f < this.vector2_0.X + 30f && this.vector2_0.X - 30f < gclass22_0.vector2_0.X + 20f && gclass22_0.vector2_0.Y - 80f - 60f < this.vector2_0.Y + 30f && this.vector2_0.Y - 30f < gclass22_0.vector2_0.Y - 80f + 40f && gclass22_0.int_5 < 56 && gclass22_0.genum4_0 != (GEnum4)11)
			{
				if (GClass1.bool_4)
				{
					GClass30.soundEffect_17.Play(GClass30.float_0, 0f, 0f);
				}
				else
				{
					GClass30.soundEffect_16.Play(GClass30.float_0, 0f, 0f);
				}
				GClass1.bool_4 = !GClass1.bool_4;
				gclass22_0.int_17++;
				this.bool_3 = true;
			}
			result = false;
		}
		return result;
	}

	// Token: 0x0400001E RID: 30
	private static Texture2D[] texture2D_1;

	// Token: 0x0400001F RID: 31
	private static bool bool_4 = false;

	// Token: 0x04000020 RID: 32
	private int int_2;

	// Token: 0x04000021 RID: 33
	public bool bool_5 = false;

	// Token: 0x04000022 RID: 34
	private bool bool_6 = false;

	// Token: 0x04000023 RID: 35
	public Vector2 vector2_1;
}
