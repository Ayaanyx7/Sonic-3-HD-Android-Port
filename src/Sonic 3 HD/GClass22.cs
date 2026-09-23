using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Token: 0x0200003E RID: 62
public class GClass22 : GClass0
{
	// Token: 0x06000101 RID: 257 RVA: 0x0000E654 File Offset: 0x0000C854
	public GClass22(string string_2)
	{
		this.gclass25_0 = GClass25.gclass25_0;
		this.float_5 = 2f;
		this.float_10 = 0.415919036f;
		this.gclass33_0 = new GClass33(string_2, "idle", 1, "10000,10,14,20,20,20,10,20,20,10,10,30,1000,1000,10");
		this.gclass33_1 = new GClass33(string_2, "walk", 8, "8,8,8,8,8,8,8,8,8,8,8,8,8,1,1,1,1,1,1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,5,5,5,5,5,5,5,5,10,10,10,10,10,10,10,10,10,10,10,10,1,1,1,1,1,1,1,1,1,1");
		this.gclass33_2 = new GClass33(string_2, "run", 4, "2,2,2,2,10,10");
		this.gclass33_3 = new GClass33(string_2, "roll", 8, "5,5,5,5,5,5,5,5");
		this.gclass33_6 = new GClass33(string_2, "roll", 8, "1,1,1,1,1,1,1,1,1,1,1");
		this.gclass33_4 = new GClass33(string_2, "crouch", 2, "6,100000,10,10,10,10");
		this.gclass33_5 = new GClass33(string_2, "spin", 10, "1,1,1,1,1,1,1,1,1,1");
		this.gclass33_7 = new GClass33(string_2, "lookUp", 2, "6,100000,10,10,10,10");
		this.gclass33_8 = new GClass33(string_2, "otskok", 1, "1000,80,14,10,10,10");
		this.gclass33_9 = new GClass33(string_2, "walk", 8, "8,8,8,8,8,8,8,8,8,8,8,8,8,8,2,2,2,2,2,2,2");
		this.gclass33_10 = new GClass33(string_2, "run", 4, "2,2,2,2");
		this.gclass33_11 = new GClass33(string_2, "pushing", 4, "32,32,32,32,32,8,8,8,8,8,8,8,8,8,2,2,2,2,2,2,2");
		this.gclass33_12 = new GClass33(string_2, "hit", 1, "10000,10000,10000,10000");
		this.gclass33_13 = new GClass33(string_2, "die", 1, "10000,1000,1000");
		this.gclass33_14 = new GClass33(string_2, "ninja", 6, "1,2,4,5,4,3,30,2,100,100,100,100");
		GClass22.color_0 = Color.White;
		this.gclass33_16 = this.gclass33_0;
		this.genum4_0 = (GEnum4)0;
		this.method_28();
	}

	// Token: 0x06000102 RID: 258 RVA: 0x0000E9C8 File Offset: 0x0000CBC8
	private void method_2(int int_35)
	{
		float num = 0.15f;
		if (GClass31.gclass32_0[int_35].float_2 < -0.15f)
		{
			this.int_6++;
		}
		if (GClass31.gclass32_0[int_35].float_2 > num)
		{
			this.int_7++;
		}
		if (GClass31.gclass32_0[int_35].float_3 > num)
		{
			this.int_8++;
		}
		if (GClass31.gclass32_0[int_35].float_3 < -num)
		{
			this.int_9++;
		}
		if (GClass31.gclass32_0[int_35].int_10 > 0)
		{
			this.int_6++;
		}
		if (GClass31.gclass32_0[int_35].int_11 > 0)
		{
			this.int_7++;
		}
		if (GClass31.gclass32_0[int_35].int_12 > 0)
		{
			this.int_8++;
		}
		if (GClass31.gclass32_0[int_35].int_13 > 0)
		{
			this.int_9++;
		}
		if (this.int_10 < GClass31.gclass32_0[int_35].int_0)
		{
			this.int_10 = GClass31.gclass32_0[int_35].int_0;
		}
		if (this.int_11 < GClass31.gclass32_0[int_35].int_1)
		{
			this.int_11 = GClass31.gclass32_0[int_35].int_1;
		}
		if (this.int_12 < GClass31.gclass32_0[int_35].int_4)
		{
			this.int_12 = GClass31.gclass32_0[int_35].int_4;
		}
		if (this.int_13 < GClass31.gclass32_0[int_35].int_2)
		{
			this.int_13 = GClass31.gclass32_0[int_35].int_2;
		}
		if (this.int_14 < GClass31.gclass32_0[int_35].int_3)
		{
			this.int_14 = GClass31.gclass32_0[int_35].int_3;
		}
		if (this.int_15 < GClass31.gclass32_0[int_35].int_5)
		{
			this.int_15 = GClass31.gclass32_0[int_35].int_5;
		}
		if (this.int_16 < GClass31.gclass32_0[int_35].int_7)
		{
			this.int_16 = GClass31.gclass32_0[int_35].int_7;
		}
	}

	// Token: 0x06000103 RID: 259 RVA: 0x0000EC20 File Offset: 0x0000CE20
	private void method_3()
	{
		KeyboardState state = Keyboard.GetState();
		if (state.IsKeyDown(27))
		{
			this.gclass25_0.Exit();
		}
		if (this.bool_18)
		{
			this.int_8 = 0;
			this.int_9 = 0;
			this.int_7 = 0;
			this.int_6 = 0;
		}
		else
		{
			int num = this.int_10;
			int num2 = this.int_11;
			int num3 = this.int_12;
			int num4 = this.int_20;
			switch (num4)
			{
			case 0:
				if (state.IsKeyDown(37))
				{
					this.int_6++;
				}
				else
				{
					this.int_6 = 0;
				}
				if (state.IsKeyDown(39))
				{
					this.int_7++;
				}
				else
				{
					this.int_7 = 0;
				}
				if (state.IsKeyDown(38))
				{
					this.int_8++;
				}
				else
				{
					this.int_8 = 0;
				}
				if (state.IsKeyDown(40))
				{
					this.int_9++;
				}
				else
				{
					this.int_9 = 0;
				}
				if (state.IsKeyDown(65))
				{
					this.int_10++;
				}
				else
				{
					this.int_10 = 0;
				}
				if (state.IsKeyDown(83))
				{
					this.int_11++;
				}
				else
				{
					this.int_11 = 0;
				}
				if (state.IsKeyDown(68))
				{
					this.int_12++;
				}
				else
				{
					this.int_12 = 0;
				}
				if (state.IsKeyDown(81))
				{
					this.int_13++;
				}
				else
				{
					this.int_13 = 0;
				}
				if (state.IsKeyDown(87))
				{
					this.int_14++;
				}
				else
				{
					this.int_14 = 0;
				}
				if (state.IsKeyDown(69))
				{
					this.int_15++;
				}
				else
				{
					this.int_15 = 0;
				}
				if (state.IsKeyDown(13))
				{
					this.int_16++;
				}
				else
				{
					this.int_16 = 0;
				}
				this.method_2(0);
				break;
			case 1:
				if (state.IsKeyDown(75))
				{
					this.int_6++;
				}
				else
				{
					this.int_6 = 0;
				}
				if (state.IsKeyDown(186))
				{
					this.int_7++;
				}
				else
				{
					this.int_7 = 0;
				}
				if (state.IsKeyDown(79))
				{
					this.int_8++;
				}
				else
				{
					this.int_8 = 0;
				}
				if (state.IsKeyDown(76))
				{
					this.int_9++;
				}
				else
				{
					this.int_9 = 0;
				}
				if (state.IsKeyDown(70))
				{
					this.int_10++;
				}
				else
				{
					this.int_10 = 0;
				}
				if (state.IsKeyDown(71))
				{
					this.int_11++;
				}
				else
				{
					this.int_11 = 0;
				}
				if (state.IsKeyDown(72))
				{
					this.int_12++;
				}
				else
				{
					this.int_12 = 0;
				}
				if (state.IsKeyDown(82))
				{
					this.int_13++;
				}
				else
				{
					this.int_13 = 0;
				}
				if (state.IsKeyDown(84))
				{
					this.int_14++;
				}
				else
				{
					this.int_14 = 0;
				}
				if (state.IsKeyDown(89))
				{
					this.int_15++;
				}
				else
				{
					this.int_15 = 0;
				}
				if (state.IsKeyDown(50))
				{
					this.int_16++;
				}
				else
				{
					this.int_16 = 0;
				}
				this.method_2(1);
				break;
			case 2:
				break;
			default:
				switch (num4)
				{
				case 10:
					this.method_2(0);
					break;
				case 11:
					this.method_2(1);
					break;
				case 12:
					this.method_2(2);
					break;
				case 13:
					this.method_2(3);
					break;
				}
				break;
			}
			if ((num > 0 && this.int_10 == 0) || (num2 > 0 && this.int_11 == 0) || (num3 > 0 && this.int_12 == 0) || this.vector2_1.Y > -16f)
			{
				this.bool_6 = true;
			}
			if (this.genum0_0 != (GEnum0)4)
			{
				this.bool_6 = false;
			}
		}
	}

	// Token: 0x06000104 RID: 260 RVA: 0x0000F094 File Offset: 0x0000D294
	public void method_4()
	{
		switch (this.genum4_0)
		{
		case (GEnum4)0:
			this.gclass33_16 = this.gclass33_0;
			break;
		case (GEnum4)1:
			this.gclass33_16 = this.gclass33_1;
			break;
		case (GEnum4)2:
			this.gclass33_16 = this.gclass33_2;
			break;
		case (GEnum4)3:
			this.gclass33_16 = this.gclass33_3;
			break;
		case (GEnum4)4:
			this.gclass33_16 = this.gclass33_4;
			break;
		case (GEnum4)5:
			this.gclass33_16 = this.gclass33_6;
			break;
		case (GEnum4)6:
			this.gclass33_16 = this.gclass33_5;
			break;
		case (GEnum4)7:
			this.gclass33_16 = this.gclass33_7;
			break;
		case (GEnum4)8:
			this.gclass33_16 = this.gclass33_8;
			break;
		case (GEnum4)9:
			this.gclass33_16 = this.gclass33_9;
			break;
		case (GEnum4)10:
			this.gclass33_16 = this.gclass33_10;
			break;
		case (GEnum4)11:
			this.gclass33_16 = this.gclass33_12;
			break;
		case (GEnum4)12:
			this.gclass33_16 = this.gclass33_13;
			break;
		case (GEnum4)13:
			this.gclass33_16 = this.gclass33_14;
			break;
		}
		if (this.bool_11 || this.bool_12 || this.bool_13)
		{
			this.gclass33_16 = this.gclass33_11;
		}
		if (this.gclass33_0 != this.gclass33_16)
		{
			this.gclass33_0.int_1 = 0;
		}
		if (this.gclass33_9 != this.gclass33_16)
		{
			this.gclass33_9.int_1 = 0;
		}
		if (this.gclass33_10 != this.gclass33_16)
		{
			this.gclass33_10.int_1 = 0;
		}
		if (this.gclass33_2 != this.gclass33_16)
		{
			this.gclass33_2.int_1 = 0;
		}
		else
		{
			this.gclass33_10.int_1 = this.gclass33_2.int_1;
		}
		if (this.gclass33_3 != this.gclass33_16)
		{
			this.gclass33_3.int_1 = 0;
		}
		if (this.gclass33_4 != this.gclass33_16)
		{
			this.gclass33_4.int_1 = 0;
		}
		if (this.gclass33_6 != this.gclass33_16)
		{
			this.gclass33_6.int_1 = 0;
		}
		if (this.gclass33_5 != this.gclass33_16)
		{
			this.gclass33_5.int_1 = 0;
		}
		if (this.gclass33_7 != this.gclass33_16)
		{
			this.gclass33_7.int_1 = 0;
		}
		if (this.gclass33_8 != this.gclass33_16)
		{
			this.gclass33_8.int_1 = 0;
		}
		if (this.gclass33_1 != this.gclass33_16)
		{
			this.gclass33_1.int_1 = 0;
		}
		else
		{
			this.gclass33_9.int_1 = this.gclass33_1.int_1;
		}
		if (this.gclass33_11 != this.gclass33_16)
		{
			this.gclass33_11.int_1 = 0;
		}
		if (this.gclass33_12 != this.gclass33_16)
		{
			this.gclass33_12.int_1 = 0;
		}
		if (this.gclass33_13 != this.gclass33_16)
		{
			this.gclass33_13.int_1 = 0;
		}
		if (this.gclass33_14 != this.gclass33_16)
		{
			this.gclass33_14.int_1 = 0;
		}
		int num = this.gclass33_16.int_1;
		for (int i = 0; i < this.gclass33_16.texture2D_0.Length; i++)
		{
			if (num <= this.gclass33_16.int_0[i])
			{
				num -= this.gclass33_16.int_0[i];
				IL_375:
				if (num >= 0 && i == this.gclass33_16.texture2D_0.Length)
				{
					this.gclass33_16.int_1 = 1;
					i = 0;
				}
				this.gclass33_16.int_2 = i;
				return;
			}
			num -= this.gclass33_16.int_0[i];
		}
		goto IL_375;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x0000F44C File Offset: 0x0000D64C
	private void method_5()
	{
		bool flag = false;
		if (this.genum0_0 == (GEnum0)1)
		{
			this.float_20 = this.float_24;
		}
		if (this.genum0_0 == (GEnum0)3)
		{
			this.float_20 = this.float_26;
		}
		if (this.genum0_0 == (GEnum0)2)
		{
			this.float_20 = this.float_25;
		}
		this.float_13 = (float)((double)this.float_10 * Math.Sin((double)this.float_20));
		if ((this.float_3 <= 0f && this.float_3 + this.float_13 > 0f) || (this.float_3 >= 0f && this.float_3 + this.float_13 < 0f))
		{
			flag = true;
		}
		this.float_3 += this.float_13;
		if (this.int_6 > 0 && this.int_7 > 0)
		{
			if (Math.Abs(this.float_3) < this.float_5)
			{
				this.float_3 = 0f;
				this.genum4_0 = (GEnum4)0;
			}
		}
		else if (this.int_6 == 0 && this.int_7 == 0)
		{
			if (Math.Abs(this.float_3) < this.float_4)
			{
				this.float_3 = 0f;
				this.genum4_0 = (GEnum4)0;
			}
			else if (this.float_3 > 0f)
			{
				this.float_3 -= this.float_6;
			}
			else if (this.float_3 < 0f)
			{
				this.float_3 += this.float_6;
			}
		}
		else
		{
			if (this.int_6 > 0)
			{
				if (flag || this.float_3 <= 0f)
				{
					this.float_3 -= this.float_4;
					if (this.float_3 < -this.float_7)
					{
						this.float_3 = -this.float_7;
					}
				}
				else if (this.float_3 > 0f)
				{
					this.float_3 -= this.float_5;
					if (this.float_3 < 0f)
					{
						this.float_3 = 0f;
						this.bool_0 = false;
					}
				}
			}
			if (this.int_7 > 0)
			{
				if (flag || this.float_3 >= 0f)
				{
					this.float_3 += this.float_4;
					if (this.float_3 > this.float_7)
					{
						this.float_3 = this.float_7;
					}
				}
				else if (this.float_3 < 0f)
				{
					this.float_3 += this.float_5;
					if (this.float_3 > 0f)
					{
						this.float_3 = 0f;
						this.bool_0 = true;
					}
				}
			}
			if (this.float_3 > 0f && this.int_7 > 0)
			{
				this.bool_0 = true;
			}
			if (this.float_3 < 0f && this.int_6 > 0)
			{
				this.bool_0 = false;
			}
		}
		if (this.bool_12 || this.bool_13 || this.bool_11)
		{
			this.float_3 = 0f;
			if (this.genum4_0 == (GEnum4)1 || this.genum4_0 == (GEnum4)2)
			{
				this.genum4_0 = (GEnum4)0;
			}
		}
		this.vector2_1 = this.float_3 * new Vector2((float)Math.Cos((double)this.float_20), (float)Math.Sin((double)this.float_20));
		this.vector2_0.X = this.vector2_0.X + this.vector2_1.X;
		this.vector2_0.Y = this.vector2_0.Y + this.vector2_1.Y;
		if (0.78539816339744828 < (double)(-(double)this.float_20) && (double)(-(double)this.float_20) < 2.3561944901923448)
		{
			if (this.genum0_0 == (GEnum0)0 || this.genum0_0 == (GEnum0)2)
			{
				this.genum0_0 = (GEnum0)1;
				this.method_25();
			}
			this.genum0_0 = (GEnum0)1;
		}
		if (-0.78539816339744828 < (double)(-(double)this.float_20) && (double)(-(double)this.float_20) < 0.78539816339744828)
		{
			if (this.genum0_0 == (GEnum0)1 || this.genum0_0 == (GEnum0)3)
			{
				this.genum0_0 = (GEnum0)0;
				this.method_25();
			}
			this.genum0_0 = (GEnum0)0;
		}
		if (2.3561944901923448 < (double)(-(double)this.float_20) || (double)(-(double)this.float_20) < -2.3561944901923448)
		{
			if (this.genum0_0 == (GEnum0)1 || this.genum0_0 == (GEnum0)3)
			{
				this.genum0_0 = (GEnum0)2;
				this.method_25();
			}
			this.genum0_0 = (GEnum0)2;
		}
		else if (this.genum0_0 != (GEnum0)2)
		{
		}
		if (-2.3561944901923448 < (double)(-(double)this.float_20) && (double)(-(double)this.float_20) < -0.78539816339744828)
		{
			if (this.genum0_0 == (GEnum0)0 || this.genum0_0 == (GEnum0)2)
			{
				this.genum0_0 = (GEnum0)3;
				this.method_25();
			}
			this.genum0_0 = (GEnum0)3;
		}
	}

	// Token: 0x06000106 RID: 262 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
	private void method_6()
	{
		bool flag = false;
		if (this.genum0_0 == (GEnum0)1)
		{
			this.float_20 = this.float_24;
		}
		if (this.genum0_0 == (GEnum0)3)
		{
			this.float_20 = this.float_26;
		}
		if (this.genum0_0 == (GEnum0)2)
		{
			this.float_20 = this.float_25;
		}
		if (Math.Sign(this.float_3) != Math.Sign(Math.Sin((double)this.float_20)))
		{
			this.float_13 = (float)(0.65 * (double)this.float_10 * Math.Sin((double)this.float_20));
		}
		else
		{
			this.float_13 = (float)(2.5 * (double)this.float_10 * Math.Sin((double)this.float_20));
		}
		if ((this.float_3 <= 0f && this.float_3 + this.float_13 > 0f) || (this.float_3 >= 0f && this.float_3 + this.float_13 < 0f))
		{
			flag = true;
		}
		this.float_3 += this.float_13;
		if (this.float_3 < 0f && this.int_6 > 0)
		{
			this.int_6 = 0;
		}
		if (this.float_3 > 0f && this.int_7 > 0)
		{
			this.int_7 = 0;
		}
		if (this.int_6 == 0 && this.int_7 == 0)
		{
			if (Math.Abs(this.float_3) < this.float_4)
			{
				this.float_3 = 0f;
				this.genum4_0 = (GEnum4)0;
			}
			else if (this.float_3 > 0f)
			{
				this.float_3 -= this.float_6 / 2f;
			}
			else if (this.float_3 < 0f)
			{
				this.float_3 += this.float_6 / 2f;
			}
		}
		else
		{
			if (this.int_6 > 0)
			{
				if (flag || this.float_3 <= 0f)
				{
					this.float_3 -= this.float_4;
				}
				else if (this.float_3 > 0f)
				{
					this.float_3 -= this.float_5 / 4f;
					if (this.float_3 < 0f)
					{
						this.float_3 = 0f;
						this.bool_0 = false;
					}
				}
			}
			if (this.int_7 > 0)
			{
				if (flag || this.float_3 >= 0f)
				{
					this.float_3 += this.float_4;
				}
				else if (this.float_3 < 0f)
				{
					this.float_3 += this.float_5 / 4f;
					if (this.float_3 > 0f)
					{
						this.float_3 = 0f;
						this.bool_0 = true;
					}
				}
			}
			if (this.float_3 > 0f && this.int_7 > 0)
			{
				this.bool_0 = true;
			}
			if (this.float_3 < 0f && this.int_6 > 0)
			{
				this.bool_0 = false;
			}
		}
		if (this.bool_12 || this.bool_13 || this.bool_11)
		{
			this.float_3 = 0f;
			if (this.genum4_0 == (GEnum4)1 || this.genum4_0 == (GEnum4)2)
			{
				this.genum4_0 = (GEnum4)0;
			}
		}
		this.vector2_1 = this.float_3 * new Vector2((float)Math.Cos((double)this.float_20), (float)Math.Sin((double)this.float_20));
		this.vector2_0.X = this.vector2_0.X + this.vector2_1.X;
		this.vector2_0.Y = this.vector2_0.Y + this.vector2_1.Y;
		if (0.78539816339744828 < (double)(-(double)this.float_20) && (double)(-(double)this.float_20) < 2.3561944901923448)
		{
			if (this.genum0_0 == (GEnum0)0 || this.genum0_0 == (GEnum0)2)
			{
				this.genum0_0 = (GEnum0)1;
				this.method_25();
			}
			this.genum0_0 = (GEnum0)1;
		}
		if (-0.78539816339744828 < (double)(-(double)this.float_20) && (double)(-(double)this.float_20) < 0.78539816339744828)
		{
			if (this.genum0_0 == (GEnum0)1 || this.genum0_0 == (GEnum0)3)
			{
				this.genum0_0 = (GEnum0)0;
				this.method_25();
			}
			this.genum0_0 = (GEnum0)0;
		}
		if (2.3561944901923448 < (double)(-(double)this.float_20) || (double)(-(double)this.float_20) < -2.3561944901923448)
		{
			if (this.genum0_0 == (GEnum0)1 || this.genum0_0 == (GEnum0)3)
			{
				this.genum0_0 = (GEnum0)2;
				this.method_25();
			}
			this.genum0_0 = (GEnum0)2;
		}
		else if (this.genum0_0 != (GEnum0)2)
		{
		}
		if (-2.3561944901923448 < (double)(-(double)this.float_20) && (double)(-(double)this.float_20) < -0.78539816339744828)
		{
			if (this.genum0_0 == (GEnum0)0 || this.genum0_0 == (GEnum0)2)
			{
				this.genum0_0 = (GEnum0)3;
				this.method_25();
			}
			this.genum0_0 = (GEnum0)3;
		}
	}

	// Token: 0x06000107 RID: 263 RVA: 0x0000FF88 File Offset: 0x0000E188
	private float method_7(int int_35, int int_36, int int_37)
	{
		GClass23 gclass = GClass24.gclass23_0[int_35];
		int[] array = new int[64];
		int i;
		for (i = 0; i < 64; i++)
		{
			array[i] = 0;
		}
		int num = int_36 / 64 * 64;
		this.string_0 += "|";
		int num2 = 0;
		int num3 = 0;
		int num4 = num2;
		i = 0;
		IL_A5:
		while (i < 64)
		{
			for (int j = 0; j < 512; j++)
			{
				if (gclass.bool_0[j, num + i])
				{
					if (i <= 31)
					{
						num4 += 512 - j;
					}
					else
					{
						num3 += 512 - j;
					}
					IL_A1:
					i++;
					goto IL_A5;
				}
			}
			goto IL_A1;
		}
		float num5 = (float)Math.Atan2((double)(-(double)((float)num3 / 32f - (float)num4 / 32f)), 32.0);
		this.float_20 = (this.float_23 = num5);
		return 0f;
	}

	// Token: 0x06000108 RID: 264 RVA: 0x0001008C File Offset: 0x0000E28C
	private float method_8(int int_35, int int_36, int int_37)
	{
		GClass23 gclass = GClass24.gclass23_0[int_35];
		int[] array = new int[64];
		int i;
		for (i = 0; i < 64; i++)
		{
			array[i] = 0;
		}
		int num = int_36 / 64 * 64;
		this.string_0 += "      ";
		int num2 = 0;
		int num3 = 0;
		int num4 = num2;
		i = 0;
		IL_97:
		while (i < 64)
		{
			for (int j = 511; j >= 0; j--)
			{
				if (gclass.bool_0[j, num + i])
				{
					if (i <= 31)
					{
						num4 += j;
					}
					else
					{
						num3 += j;
					}
					IL_93:
					i++;
					goto IL_97;
				}
			}
			goto IL_93;
		}
		float num5 = (float)Math.Atan2((double)(-(double)((float)num3 / 32f - (float)num4 / 32f)), -32.0);
		this.float_20 = (this.float_25 = num5);
		return 0f;
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00010180 File Offset: 0x0000E380
	private float method_9(int int_35, int int_36, int int_37)
	{
		GClass23 gclass = GClass24.gclass23_0[int_35];
		int num = int_37 / 64 * 64;
		int num2 = 0;
		int num3 = 0;
		int i = 0;
		IL_6D:
		while (i < 64)
		{
			for (int j = 0; j < 512; j++)
			{
				if (gclass.bool_0[num + i, j])
				{
					if (i <= 31)
					{
						num3 += 512 - j;
					}
					else
					{
						num2 += 512 - j;
					}
					IL_67:
					i++;
					goto IL_6D;
				}
			}
			goto IL_67;
		}
		float num4 = (float)Math.Atan2(-32.0, (double)(-(double)((float)num3 / 32f - (float)num2 / 32f)));
		this.float_24 = num4;
		return 0f;
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00010238 File Offset: 0x0000E438
	private float method_10(int int_35, int int_36, int int_37)
	{
		GClass23 gclass = GClass24.gclass23_0[int_35];
		int num = int_37 / 64 * 64;
		int num2 = 0;
		int num3 = 0;
		int i = 0;
		IL_64:
		while (i < 64)
		{
			for (int j = 511; j >= 0; j--)
			{
				if (gclass.bool_0[num + i, j])
				{
					if (i <= 31)
					{
						num3 += j;
					}
					else
					{
						num2 += j;
					}
					IL_5E:
					i++;
					goto IL_64;
				}
			}
			goto IL_5E;
		}
		float num4 = (float)Math.Atan2(32.0, (double)(-(double)((float)num3 / 32f - (float)num2 / 32f)));
		this.float_26 = num4;
		return 0f;
	}

	// Token: 0x0600010B RID: 267 RVA: 0x000102E8 File Offset: 0x0000E4E8
	private float method_11(int int_35, int int_36)
	{
		return this.method_13(int_35, int_36, false, true);
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00010304 File Offset: 0x0000E504
	private float method_12(int int_35, int int_36, bool bool_19)
	{
		return this.method_13(int_35, int_36, bool_19, true);
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00010320 File Offset: 0x0000E520
	private float method_13(int int_35, int int_36, bool bool_19, bool bool_20)
	{
		float num = 100000f;
		float result;
		if (int_35 < 0)
		{
			result = num;
		}
		else
		{
			GClass24 gclass24_ = GClass29.gclass24_0;
			int num2 = int_35 / 512;
			int num3 = int_36 / 512;
			GClass23 gclass;
			if (bool_20)
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
			}
			else
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
			}
			int num4 = int_35 - num2 * 512;
			int num5 = int_36 - num3 * 512;
			int num6 = -num5;
			while (num6 + num5 < 512 && num5 + num6 < 512)
			{
				if (gclass.bool_0[num5 + num6, num4] && -64 < num6 && (float)num6 < num)
				{
					num = (float)num6;
				}
				num6++;
			}
			num2 = int_35 / 512;
			num3 = int_36 / 512 + 1;
			num4 = int_35 - num2 * 512;
			num5 = int_36 - num3 * 512;
			if (bool_20)
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
			}
			else
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
			}
			num6 = -num5;
			while (num6 + num5 < 512 && num5 + num6 < 512)
			{
				if (num6 + num5 >= 0 && gclass.bool_0[num5 + num6, num4] && -64 < num6 && (float)num6 < num)
				{
					num = (float)num6;
				}
				num6++;
			}
			num2 = int_35 / 512;
			num3 = int_36 / 512 - 1;
			num4 = int_35 - num2 * 512;
			num5 = int_36 - num3 * 512;
			if (bool_20)
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
			}
			else
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
			}
			num6 = -num5;
			while (num6 + num5 <= 512 && num5 + num6 < 512)
			{
				if (num6 + num5 >= 0 && gclass.bool_0[num5 + num6, num4] && num6 > -76 && -64 < num6 && (float)num6 < num)
				{
					num = (float)num6;
				}
				num6++;
			}
			if (bool_19)
			{
				num2 = int_35 / 512;
				num3 = int_36 / 512;
				if (bool_20)
				{
					gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
				}
				else
				{
					gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
				}
				num4 = int_35 - num2 * 512;
				num5 = int_36 - num3 * 512;
				num6 = -num5;
				while (num6 + num5 < 512 && num5 + num6 < 512)
				{
					if (gclass.bool_0[num5 + num6, num4] && (float)num6 == num)
					{
						if (bool_20)
						{
							this.method_7(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4, num5 + num6);
						}
						else
						{
							this.method_7(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4, num5 + num6);
						}
					}
					num6++;
				}
				num2 = int_35 / 512;
				num3 = int_36 / 512 + 1;
				num4 = int_35 - num2 * 512;
				num5 = int_36 - num3 * 512;
				if (bool_20)
				{
					gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
				}
				else
				{
					gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
				}
				num6 = -num5;
				while (num6 + num5 < 512 && num5 + num6 < 512)
				{
					if (num6 + num5 >= 0 && gclass.bool_0[num5 + num6, num4] && (float)num6 == num)
					{
						if (bool_20)
						{
							this.method_7(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4, num5 + num6);
						}
						else
						{
							this.method_7(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4, num5 + num6);
						}
					}
					num6++;
				}
				num2 = int_35 / 512;
				num3 = int_36 / 512 - 1;
				num4 = int_35 - num2 * 512;
				num5 = int_36 - num3 * 512;
				if (bool_20)
				{
					gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
				}
				else
				{
					gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
				}
				num6 = -num5;
				while (num6 + num5 <= 512 && num5 + num6 < 512)
				{
					if (num6 + num5 >= 0 && gclass.bool_0[num5 + num6, num4] && num6 > -76 && (float)num6 == num)
					{
						if (bool_20)
						{
							this.method_7(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4, num5 + num6);
						}
						else
						{
							this.method_7(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4, num5 + num6);
						}
					}
					num6++;
				}
			}
			if (num <= 1000f)
			{
			}
			result = num;
		}
		return result;
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00010988 File Offset: 0x0000EB88
	private float method_14(int int_35, int int_36)
	{
		return this.method_16(int_35, int_36, false, true);
	}

	// Token: 0x0600010F RID: 271 RVA: 0x000109A4 File Offset: 0x0000EBA4
	private float method_15(int int_35, int int_36, bool bool_19)
	{
		return this.method_16(int_35, int_36, bool_19, true);
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000109C0 File Offset: 0x0000EBC0
	private float method_16(int int_35, int int_36, bool bool_19, bool bool_20)
	{
		int num = 100000;
		this.float_15 = 1000f;
		this.float_17 = -1000f;
		GClass24 gclass24_ = GClass29.gclass24_0;
		int num2 = int_35 / 512;
		int num3 = int_36 / 512;
		GClass23 gclass;
		if (bool_20)
		{
			gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
		}
		else
		{
			gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
		}
		int num4 = int_35 - num2 * 512;
		int num5 = int_36 - num3 * 512;
		int num6 = -num4;
		while (num6 < 512 && num4 + num6 < 512)
		{
			if (num5 >= 0 && gclass.bool_0[num5, num4 + num6])
			{
				if ((float)num6 < this.float_15 && (num6 > 0 || (num6 > -80 && this.genum0_0 == (GEnum0)1)))
				{
					this.float_15 = (float)num6;
				}
				if (this.float_17 < (float)num6 && (num6 < 0 || (num6 < 80 && this.genum0_0 == (GEnum0)3)))
				{
					this.float_17 = (float)num6;
				}
			}
			num6++;
		}
		num2 = int_35 / 512 + 1;
		num3 = int_36 / 512;
		if (bool_20)
		{
			gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
		}
		else
		{
			gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
		}
		num4 = int_35 - num2 * 512;
		num5 = int_36 - num3 * 512;
		num6 = -num4;
		while (num6 < 512 && num4 + num6 < 512)
		{
			if (num5 >= 0 && gclass.bool_0[num5, num4 + num6])
			{
				if ((float)num6 < this.float_15 && (num6 > 0 || (num6 > -80 && this.genum0_0 == (GEnum0)1)))
				{
					this.float_15 = (float)num6;
				}
				if (this.float_17 < (float)num6 && (num6 < 0 || (num6 < 80 && this.genum0_0 == (GEnum0)3)))
				{
					this.float_17 = (float)num6;
				}
			}
			num6++;
		}
		num2 = int_35 / 512 - 1;
		if (num2 < 0)
		{
			num2 = 0;
		}
		num3 = int_36 / 512;
		if (bool_20)
		{
			gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
		}
		else
		{
			gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
		}
		num4 = int_35 - num2 * 512;
		num5 = int_36 - num3 * 512;
		num6 = -num4;
		while (num6 < 512 && num4 + num6 < 512)
		{
			if (num4 + num6 >= 0 && num5 >= 0 && gclass.bool_0[num5, num4 + num6])
			{
				if ((float)num6 < this.float_15 && (num6 > 0 || (num6 > -80 && this.genum0_0 == (GEnum0)1)))
				{
					this.float_15 = (float)num6;
				}
				if (this.float_17 < (float)num6 && (num6 < 0 || (num6 < 80 && this.genum0_0 == (GEnum0)3)))
				{
					this.float_17 = (float)num6;
				}
			}
			num6++;
		}
		if (bool_19)
		{
			num2 = int_35 / 512;
			num3 = int_36 / 512;
			if (bool_20)
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
			}
			else
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
			}
			num4 = int_35 - num2 * 512;
			num5 = int_36 - num3 * 512;
			num6 = -num4;
			while (num6 < 512 && num4 + num6 < 512)
			{
				if (num5 >= 0 && gclass.bool_0[num5, num4 + num6])
				{
					if ((float)num6 == this.float_15)
					{
						if (bool_20)
						{
							this.method_9(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + num6, num5);
						}
						else
						{
							this.method_9(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + num6, num5);
						}
					}
					if (this.float_17 == (float)num6)
					{
						if (bool_20)
						{
							this.method_10(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + num6, num5);
						}
						else
						{
							this.method_10(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + num6, num5);
						}
					}
				}
				num6++;
			}
			num2 = int_35 / 512 + 1;
			num3 = int_36 / 512;
			if (bool_20)
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
			}
			else
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
			}
			num4 = int_35 - num2 * 512;
			num5 = int_36 - num3 * 512;
			num6 = -num4;
			while (num6 < 512 && num4 + num6 < 512)
			{
				if (num5 >= 0 && gclass.bool_0[num5, num4 + num6])
				{
					if ((float)num6 == this.float_15)
					{
						if (bool_20)
						{
							this.method_9(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + num6, num5);
						}
						else
						{
							this.method_9(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + num6, num5);
						}
					}
					if (this.float_17 == (float)num6)
					{
						if (bool_20)
						{
							this.method_10(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + num6, num5);
						}
						else
						{
							this.method_10(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + num6, num5);
						}
					}
				}
				num6++;
			}
			num2 = int_35 / 512 - 1;
			if (num2 < 0)
			{
				num2 = 0;
			}
			num3 = int_36 / 512;
			if (bool_20)
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000]];
			}
			else
			{
				gclass = GClass24.gclass23_0[gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000]];
			}
			num4 = int_35 - num2 * 512;
			num5 = int_36 - num3 * 512;
			num6 = -num4;
			while (num6 < 512 && num4 + num6 < 512)
			{
				if (num4 + num6 >= 0 && num5 >= 0 && gclass.bool_0[num5, num4 + num6])
				{
					if ((float)num6 == this.float_15)
					{
						if (bool_20)
						{
							this.method_9(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + num6, num5);
						}
						else
						{
							this.method_9(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + num6, num5);
						}
					}
					if (this.float_17 == (float)num6)
					{
						if (bool_20)
						{
							this.method_10(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num4 + num6, num5);
						}
						else
						{
							this.method_10(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num4 + num6, num5);
						}
					}
				}
				num6++;
			}
		}
		return (float)num;
	}

	// Token: 0x06000111 RID: 273 RVA: 0x000112AC File Offset: 0x0000F4AC
	private float method_17(int int_35, int int_36)
	{
		return this.method_19(int_35, int_36, false, true);
	}

	// Token: 0x06000112 RID: 274 RVA: 0x000112C8 File Offset: 0x0000F4C8
	private float method_18(int int_35, int int_36, bool bool_19)
	{
		return this.method_19(int_35, int_36, bool_19, true);
	}

	// Token: 0x06000113 RID: 275 RVA: 0x000112E4 File Offset: 0x0000F4E4
	private float method_19(int int_35, int int_36, bool bool_19, bool bool_20)
	{
		float num = -100000f;
		float result;
		if (int_35 < 0)
		{
			result = num;
		}
		else
		{
			GClass24 gclass24_ = GClass29.gclass24_0;
			int num2 = int_35 / 512;
			int num3 = int_36 / 512;
			int num4;
			GClass23 gclass;
			if (bool_20)
			{
				num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
				gclass = GClass24.gclass23_0[num4];
			}
			else
			{
				num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
				gclass = GClass24.gclass23_0[num4];
			}
			int num5 = int_35 - num2 * 512;
			int num6 = int_36 - num3 * 512;
			if (!gclass24_.bool_1[num4] || this.genum0_0 != (GEnum0)4)
			{
				int num7 = -num6;
				while (num7 + num6 < 512 && num6 + num7 < 512)
				{
					if (gclass.bool_0[num6 + num7, num5] && (float)num7 > num && num7 < 4)
					{
						num = (float)num7;
					}
					num7++;
				}
			}
			num2 = int_35 / 512;
			num3 = int_36 / 512 + 1;
			num5 = int_35 - num2 * 512;
			num6 = int_36 - num3 * 512;
			if (bool_20)
			{
				num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
				gclass = GClass24.gclass23_0[num4];
			}
			else
			{
				num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
				gclass = GClass24.gclass23_0[num4];
			}
			if (!gclass24_.bool_1[num4] || this.genum0_0 != (GEnum0)4)
			{
				int num7 = -num6;
				while (num7 + num6 < 512 && num6 + num7 < 512)
				{
					if (num7 + num6 >= 0 && gclass.bool_0[num6 + num7, num5] && (float)num7 > num && num7 < 4)
					{
						num = (float)num7;
					}
					num7++;
				}
			}
			num2 = int_35 / 512;
			num3 = int_36 / 512 - 1;
			num5 = int_35 - num2 * 512;
			num6 = int_36 - num3 * 512;
			if (bool_20)
			{
				num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
				gclass = GClass24.gclass23_0[num4];
			}
			else
			{
				num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
				gclass = GClass24.gclass23_0[num4];
			}
			if (!gclass24_.bool_1[num4] || this.genum0_0 != (GEnum0)4)
			{
				int num7 = -num6;
				while (num7 + num6 <= 512 && num6 + num7 < 512)
				{
					if (num7 + num6 >= 0 && gclass.bool_0[num6 + num7, num5] && (float)num7 > num && num7 < 4)
					{
						num = (float)num7;
					}
					num7++;
				}
			}
			if (bool_19)
			{
				num2 = int_35 / 512;
				num3 = int_36 / 512;
				if (bool_20)
				{
					num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
					gclass = GClass24.gclass23_0[num4];
				}
				else
				{
					num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
					gclass = GClass24.gclass23_0[num4];
				}
				num5 = int_35 - num2 * 512;
				num6 = int_36 - num3 * 512;
				if (!gclass24_.bool_1[num4] || this.genum0_0 != (GEnum0)4)
				{
					int num7 = -num6;
					while (num7 + num6 < 512 && num6 + num7 < 512)
					{
						if (gclass.bool_0[num6 + num7, num5] && (float)num7 == num)
						{
							if (bool_20)
							{
								this.method_8(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num5, num6 + num7);
							}
							else
							{
								this.method_8(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num5, num6 + num7);
							}
						}
						num7++;
					}
				}
				num2 = int_35 / 512;
				num3 = int_36 / 512 + 1;
				num5 = int_35 - num2 * 512;
				num6 = int_36 - num3 * 512;
				if (bool_20)
				{
					num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
					gclass = GClass24.gclass23_0[num4];
				}
				else
				{
					num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
					gclass = GClass24.gclass23_0[num4];
				}
				if (!gclass24_.bool_1[num4] || this.genum0_0 != (GEnum0)4)
				{
					int num7 = -num6;
					while (num7 + num6 < 512 && num6 + num7 < 512)
					{
						if (num7 + num6 >= 0 && gclass.bool_0[num6 + num7, num5] && (float)num7 == num)
						{
							if (bool_20)
							{
								this.method_8(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num5, num6 + num7);
							}
							else
							{
								this.method_8(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num5, num6 + num7);
							}
						}
						num7++;
					}
				}
				num2 = int_35 / 512;
				num3 = int_36 / 512 - 1;
				num5 = int_35 - num2 * 512;
				num6 = int_36 - num3 * 512;
				if (bool_20)
				{
					num4 = gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000];
					gclass = GClass24.gclass23_0[num4];
				}
				else
				{
					num4 = gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000];
					gclass = GClass24.gclass23_0[num4];
				}
				if (!gclass24_.bool_1[num4] || this.genum0_0 != (GEnum0)4)
				{
					int num7 = -num6;
					while (num7 + num6 <= 512 && num6 + num7 < 512)
					{
						if (num7 + num6 >= 0 && gclass.bool_0[num6 + num7, num5] && num7 > -76 && (float)num7 == num)
						{
							if (bool_20)
							{
								this.method_8(gclass24_.int_0[gclass24_.int_2[num3, num2] % 1000], num5, num6 + num7);
							}
							else
							{
								this.method_8(gclass24_.int_0[gclass24_.int_3[num3, num2] % 1000], num5, num6 + num7);
							}
						}
						num7++;
					}
				}
			}
			if (num <= 1000f)
			{
			}
			this.float_16 = num;
			result = num;
		}
		return result;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x000119EC File Offset: 0x0000FBEC
	public void method_20(int int_35)
	{
		int num = 0;
		float num2 = 1.76714587f;
		bool flag = false;
		float num3 = 16f;
		for (int i = 0; i < GClass29.gclass24_0.gclass0_0.Length; i++)
		{
			if (GClass29.gclass24_0.gclass0_0[i] == null)
			{
				GClass1 gclass = new GClass1();
				gclass.bool_5 = true;
				gclass.vector2_0 = this.vector2_0 - new Vector2(0f, 20f);
				gclass.vector2_1 = new Vector2((float)Math.Cos((double)num2) * num3, -(float)Math.Sin((double)num2) * num3);
				if (flag)
				{
					GClass1 gclass2 = gclass;
					gclass2.vector2_1.X = gclass2.vector2_1.X * -1f;
					num2 += 0.3926991f;
				}
				flag = !flag;
				num++;
				if (num == 16)
				{
					num3 = 8f;
					num2 = 1.76714587f;
				}
				GClass29.gclass24_0.gclass0_0[i] = gclass;
				if (num == int_35)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000115 RID: 277 RVA: 0x00011AF4 File Offset: 0x0000FCF4
	public void method_21(int int_35, int int_36)
	{
		if (!this.bool_7 && this.int_5 <= 0 && this.genum4_0 != (GEnum4)12 && this.genum4_0 != (GEnum4)11)
		{
			if (this.genum1_0 != (GEnum1)0)
			{
				this.genum1_0 = (GEnum1)0;
				this.vector2_1.Y = -16f;
				if ((int)this.vector2_0.X != int_35)
				{
					this.vector2_1.X = (float)(2 * Math.Sign(this.vector2_0.X - (float)int_35) * 4);
				}
				else
				{
					this.vector2_1.X = -8f;
				}
				GClass30.soundEffect_9.Play(GClass30.float_0, 0f, 0f);
				this.int_24 = 0;
				this.genum4_0 = (GEnum4)11;
			}
			else if (this.int_17 > 0)
			{
				this.method_20(this.int_17);
				this.int_17 = 0;
				this.vector2_1.Y = -16f;
				if ((int)this.vector2_0.X != int_35)
				{
					this.vector2_1.X = (float)(2 * Math.Sign(this.vector2_0.X - (float)int_35) * 4);
				}
				else
				{
					this.vector2_1.X = -8f;
				}
				GClass30.soundEffect_7.Play(GClass30.float_0, 0f, 0f);
				this.int_24 = 0;
				this.genum4_0 = (GEnum4)11;
			}
			else
			{
				this.vector2_1.Y = -28f;
				if (this.bool_16)
				{
					GClass30.soundEffect_9.Play(GClass30.float_0, 0f, 0f);
					this.bool_16 = false;
				}
				else
				{
					GClass30.soundEffect_3.Play(GClass30.float_0, 0f, 0f);
				}
				this.genum4_0 = (GEnum4)12;
			}
		}
		this.bool_16 = false;
	}

	// Token: 0x06000116 RID: 278 RVA: 0x00011CD4 File Offset: 0x0000FED4
	public void method_22(int int_35)
	{
		if (this.int_29 <= 0)
		{
			this.bool_6 = false;
			if (this.vector2_1.Y < 0f)
			{
				this.vector2_1.Y = this.vector2_1.Y - (float)Math.Sign(this.vector2_1.Y);
			}
			else if (this.vector2_0.Y - 80f < (float)int_35 || this.vector2_1.Y > 0f)
			{
				if (Math.Abs(this.vector2_1.Y) > 4f)
				{
					this.vector2_1.Y = -Math.Abs(this.vector2_1.Y);
				}
				else
				{
					this.vector2_1.Y = -4f;
				}
			}
		}
	}

	// Token: 0x06000117 RID: 279 RVA: 0x00011DB0 File Offset: 0x0000FFB0
	public void method_23()
	{
		switch (this.genum2_0)
		{
		case (GEnum2)0:
			this.float_4 = 0.1875f;
			this.float_6 = 0.1875f;
			this.float_7 = 24f;
			this.float_8 = 0.375f;
			this.float_9 = 0.875f;
			break;
		case (GEnum2)1:
			this.float_4 = 0.375f;
			this.float_6 = 0.375f;
			this.float_7 = 48f;
			this.float_8 = 0.75f;
			this.float_9 = 0.875f;
			this.int_2--;
			if (this.int_2 <= 0)
			{
				this.genum2_0 = (GEnum2)0;
				this.int_2 = 0;
			}
			break;
		}
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00002A82 File Offset: 0x00000C82
	public void method_24()
	{
		if (this.genum2_0 == (GEnum2)0 || this.genum2_0 == (GEnum2)1)
		{
			this.genum2_0 = (GEnum2)1;
			this.int_2 = 1200;
		}
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00011E78 File Offset: 0x00010078
	private void method_25()
	{
		switch (this.genum0_0)
		{
		case (GEnum0)1:
			this.genum3_0 = (GEnum3)0;
			break;
		case (GEnum0)2:
			this.genum3_0 = (GEnum3)2;
			break;
		case (GEnum0)3:
			if (this.genum3_0 == (GEnum3)2)
			{
				this.genum3_0 = (GEnum3)1;
			}
			break;
		case (GEnum0)4:
			this.genum3_0 = (GEnum3)0;
			break;
		}
		int num = (int)this.vector2_0.X;
		int num2 = (int)this.vector2_0.Y;
		this.float_14 = 100000f;
		float num3 = 10000f;
		float num4 = 10000f;
		float num5 = 10000f;
		float num6 = 10000f;
		switch (this.genum0_0)
		{
		case (GEnum0)0:
			if (this.genum3_0 == (GEnum3)0 || this.genum3_0 == (GEnum3)2)
			{
				num3 = (this.float_18 = this.method_11(num - 36, num2));
				num4 = (this.float_19 = this.method_11(num + 36, num2));
				if (this.genum3_0 == (GEnum3)0 && (num3 > 600f || num4 > 600f))
				{
					this.genum3_0 = (GEnum3)1;
					num5 = (this.float_18 = this.method_11(num - 36, num2));
					num6 = (this.float_19 = this.method_11(num + 36, num2));
				}
			}
			if (this.genum3_0 == (GEnum3)1 || this.genum3_0 == (GEnum3)2)
			{
				num5 = (this.float_18 = this.method_13(num - 36, num2, false, false));
				num6 = (this.float_19 = this.method_13(num + 36, num2, false, false));
				if (this.genum3_0 == (GEnum3)1 && num5 > 600f && num6 > 600f)
				{
					this.genum3_0 = (GEnum3)0;
					num3 = (this.float_18 = this.method_11(num - 36, num2));
					num4 = (this.float_19 = this.method_11(num + 36, num2));
				}
			}
			if (this.float_18 < 80f || this.float_19 < 80f || num3 < 80f || num4 < 80f)
			{
				if (this.genum3_0 == (GEnum3)0)
				{
					if (this.float_18 < this.float_19)
					{
						this.float_14 = this.method_12(num - 36, num2, true);
					}
					else
					{
						this.float_14 = (this.float_14 = this.method_12(num + 36, num2, true));
					}
				}
				if (this.genum3_0 == (GEnum3)1)
				{
					if (this.float_18 < this.float_19)
					{
						this.float_14 = this.method_13(num - 36, num2, true, false);
					}
					else
					{
						this.float_14 = (this.float_14 = this.method_13(num + 36, num2, true, false));
					}
				}
				if (this.genum3_0 == (GEnum3)2)
				{
					if ((num3 <= num5 && num3 <= num6) || (num4 <= num5 && num4 <= num6))
					{
						if (num3 < num4)
						{
							this.float_14 = this.method_12(num - 36, num2, true);
						}
						else
						{
							this.float_14 = (this.float_14 = this.method_12(num + 36, num2, true));
						}
					}
					else if (this.float_18 < this.float_19)
					{
						this.float_14 = this.method_13(num - 36, num2, true, false);
					}
					else
					{
						this.float_14 = (this.float_14 = this.method_13(num + 36, num2, true, false));
					}
				}
			}
			else
			{
				this.float_20 = 0f;
			}
			if (this.bool_14 && (float)this.int_21 < this.float_14)
			{
				this.float_14 = (float)this.int_21;
				this.float_20 = 0f;
			}
			break;
		case (GEnum0)1:
			num = (int)this.vector2_0.X + 80;
			num2 = (int)this.vector2_0.Y - 80;
			this.method_15(num, num2, true);
			if (this.genum3_0 == (GEnum3)0 || this.genum3_0 == (GEnum3)2)
			{
				this.method_15(num, num2 - 36, true);
				num3 = (this.float_18 = this.float_15);
				this.method_15(num, num2 + 36, true);
				num4 = (this.float_19 = this.float_15);
			}
			if (this.genum3_0 == (GEnum3)1 || this.genum3_0 == (GEnum3)2)
			{
				this.method_16(num, num2 - 36, true, false);
				float num7 = this.float_18 = this.float_15;
				this.method_16(num, num2 + 36, true, false);
				num7 = (this.float_19 = this.float_15);
			}
			if (this.float_18 < 80f || this.float_19 < 80f || num3 < 80f || num4 < 80f)
			{
				if (this.genum3_0 == (GEnum3)0)
				{
					if (this.float_18 < this.float_19)
					{
						this.method_15(num, num2 - 36, true);
						this.float_15 = this.float_19;
					}
					else
					{
						this.method_15(num, num2 + 36, true);
						this.float_15 = this.float_18;
					}
				}
				if (this.genum3_0 == (GEnum3)1)
				{
					if (this.float_18 < this.float_19)
					{
						this.method_16(num, num2 - 36, true, false);
						this.float_15 = this.float_19;
					}
					else
					{
						this.method_16(num, num2 + 36, true, false);
						this.float_15 = this.float_18;
					}
				}
				if (this.genum3_0 == (GEnum3)2)
				{
					if (num3 < num4)
					{
						this.method_15(num, num2 - 36, true);
						this.float_15 = num4;
					}
					else
					{
						this.method_15(num, num2 + 36, true);
						this.float_15 = num3;
					}
				}
			}
			break;
		case (GEnum0)2:
			this.float_14 = -9000f;
			num3 = -11000f;
			num4 = -12000f;
			num5 = -13000f;
			num6 = -14000f;
			num = (int)this.vector2_0.X;
			num2 = (int)this.vector2_0.Y - 160;
			if (this.genum3_0 == (GEnum3)0 || this.genum3_0 == (GEnum3)2)
			{
				this.method_18(num, num2, true);
				num3 = (this.float_18 = this.method_17(num - 32, num2));
				num4 = (this.float_19 = this.method_17(num + 32, num2));
			}
			if (this.genum3_0 == (GEnum3)1 || this.genum3_0 == (GEnum3)2)
			{
				this.method_19(num, num2, true, true);
				num5 = (this.float_18 = this.method_19(num - 32, num2, false, false));
				num6 = (this.float_19 = this.method_19(num + 32, num2, false, false));
				if (num5 >= -600f || num6 >= -600f)
				{
				}
			}
			if (num5 > -80f || num6 > -80f || num3 > -80f || num4 > -80f)
			{
				if (this.genum3_0 == (GEnum3)0)
				{
					if (num3 > num4)
					{
						this.float_16 = this.method_19(num - 32, num2, true, true);
					}
					else
					{
						this.float_16 = this.method_19(num + 32, num2, true, true);
					}
				}
				if (this.genum3_0 == (GEnum3)1)
				{
					if (this.float_18 > this.float_19)
					{
						this.float_14 = (this.float_16 = this.method_19(num - 32, num2, true, false));
					}
					else
					{
						this.float_14 = (this.float_16 = this.method_19(num + 32, num2, true, false));
					}
				}
				if (this.genum3_0 == (GEnum3)2)
				{
					if ((num3 >= num5 && num3 >= num6) || (num4 >= num5 && num4 >= num6))
					{
						if (num3 > num4)
						{
							this.float_16 = this.method_18(num - 32, num2, true);
						}
						else
						{
							this.float_16 = this.method_18(num + 32, num2, true);
						}
					}
					else if (num5 > num6)
					{
						this.float_16 = this.method_19(num - 32, num2, true, false);
					}
					else
					{
						this.float_16 = this.method_19(num + 32, num2, true, false);
					}
				}
			}
			break;
		case (GEnum0)3:
			num = (int)this.vector2_0.X - 80;
			num2 = (int)this.vector2_0.Y - 80;
			if (this.genum3_0 == (GEnum3)0 || this.genum3_0 == (GEnum3)2)
			{
				this.method_15(num, num2 + 36, true);
				num3 = (this.float_18 = this.float_17);
				this.method_15(num, num2 - 36, true);
				num4 = (this.float_19 = this.float_17);
			}
			if (this.genum3_0 == (GEnum3)1 || this.genum3_0 == (GEnum3)2)
			{
				this.method_16(num, num2 - 36, true, false);
				num5 = (this.float_18 = this.float_17);
				this.method_16(num, num2 + 36, true, false);
				num6 = (this.float_19 = this.float_17);
				if (this.genum3_0 == (GEnum3)1 && num5 < -600f && num6 < -600f)
				{
					this.genum3_0 = (GEnum3)0;
					this.method_15(num, num2 - 36, true);
					num3 = (this.float_18 = this.float_17);
					this.method_15(num, num2 + 36, true);
					num4 = (this.float_19 = this.float_17);
				}
			}
			if (this.float_18 < 80f || this.float_19 < 80f || num3 < 80f || num4 < 80f)
			{
				if (this.genum3_0 == (GEnum3)0)
				{
					if (this.float_18 < this.float_19)
					{
						this.method_15(num, num2 - 36, true);
						this.float_17 = this.float_19;
					}
					else
					{
						this.method_15(num, num2 + 36, true);
						this.float_17 = this.float_18;
					}
				}
				if (this.genum3_0 == (GEnum3)1)
				{
					if (this.float_18 > this.float_19)
					{
						this.float_14 = this.method_16(num, num2 - 36, true, false);
					}
					else
					{
						this.float_14 = (this.float_14 = this.method_16(num, num2 + 36, true, false));
					}
				}
				if (this.genum3_0 == (GEnum3)2)
				{
					if ((num3 > num5 && num3 > num6) || (num4 > num5 && num4 > num6))
					{
						if (num3 < num4)
						{
							this.method_15(num, num2 - 36, true);
							this.float_17 = num4;
						}
						else
						{
							this.method_15(num, num2 + 36, true);
							this.float_17 = num3;
						}
					}
					else if (num5 < num6)
					{
						this.method_16(num, num2 - 36, true, false);
						this.float_17 = num6;
					}
					else
					{
						this.method_16(num, num2 + 36, true, false);
						this.float_17 = num5;
					}
				}
			}
			break;
		case (GEnum0)4:
		{
			if (this.genum3_0 == (GEnum3)0 || this.genum3_0 == (GEnum3)2)
			{
				this.float_14 = this.method_11(num, num2);
				this.float_18 = this.method_11(num - 36, num2);
				this.float_19 = this.method_11(num + 36, num2);
				if (this.float_18 < 80f || this.float_19 < 80f)
				{
					if (this.float_18 < this.float_19)
					{
						this.float_14 = this.method_12(num - 36, num2, true);
					}
					else
					{
						this.float_14 = (this.float_14 = this.method_12(num + 36, num2, true));
					}
				}
				else
				{
					this.float_20 = 0f;
				}
			}
			float num8 = this.float_14;
			float num9 = this.float_20;
			if (this.genum3_0 == (GEnum3)1 || this.genum3_0 == (GEnum3)2)
			{
				this.float_14 = this.method_13(num, num2, false, false);
				this.float_18 = this.method_13(num - 36, num2, false, false);
				this.float_19 = this.method_13(num + 36, num2, false, false);
				if (this.float_14 < num8)
				{
					if (this.float_18 < 80f || this.float_19 < 80f)
					{
						if (this.float_18 < this.float_19)
						{
							this.float_14 = this.method_13(num - 36, num2, true, false);
						}
						else
						{
							this.float_14 = (this.float_14 = this.method_13(num + 36, num2, true, false));
						}
					}
					else
					{
						this.float_20 = 0f;
					}
				}
				else
				{
					this.float_14 = num8;
					this.float_20 = num9;
				}
			}
			if (this.bool_14 && (float)this.int_21 < this.float_14)
			{
				this.float_14 = (float)this.int_21;
				this.float_20 = 0f;
			}
			break;
		}
		}
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00012BC0 File Offset: 0x00010DC0
	private void method_26()
	{
		int num = (int)this.vector2_0.X;
		int num2 = (int)this.vector2_0.Y;
		float num3 = -1000f;
		float num4 = 1000f;
		switch (this.genum0_0)
		{
		case (GEnum0)0:
			if (this.genum3_0 == (GEnum3)0 || this.genum3_0 == (GEnum3)2)
			{
				this.method_14(num, num2 - 64);
				num3 = this.float_17;
				num4 = this.float_15;
			}
			if (this.genum3_0 == (GEnum3)1 || this.genum3_0 == (GEnum3)2)
			{
				this.method_16(num, num2 - 64, false, false);
			}
			if (this.genum3_0 == (GEnum3)2 || this.genum3_0 == (GEnum3)0)
			{
				if (num3 > this.float_17)
				{
					this.float_17 = num3;
				}
				if (num4 < this.float_15)
				{
					this.float_15 = num4;
				}
			}
			if (this.float_15 < 44f)
			{
				if (this.genum3_0 == (GEnum3)0)
				{
					this.float_18 = this.method_13(num + 16 - 36, num2, false, false);
					this.float_19 = this.method_13(num + 16 + 36, num2, false, false);
					if (this.float_18 < 64f || this.float_19 < 64f)
					{
						this.genum3_0 = (GEnum3)1;
					}
					else
					{
						this.vector2_0.X = (float)((int)this.vector2_0.X) - (44f - this.float_15);
						this.bool_11 = true;
						this.float_3 = 0f;
						this.vector2_1.X = 0f;
					}
				}
				else
				{
					this.vector2_0.X = (float)((int)this.vector2_0.X) - (44f - this.float_15);
					this.bool_11 = true;
					this.float_3 = 0f;
					this.vector2_1.X = 0f;
				}
			}
			if (this.float_17 > -44f)
			{
				if (this.genum3_0 == (GEnum3)0)
				{
					this.float_18 = this.method_13(num + 16 - 36, num2, false, false);
					this.float_19 = this.method_13(num + 16 + 36, num2, false, false);
					if (this.float_18 < 64f || this.float_19 < 64f)
					{
						this.genum3_0 = (GEnum3)1;
					}
					else
					{
						this.vector2_0.X = (float)((int)this.vector2_0.X) + (44f + this.float_17);
						this.bool_11 = true;
						this.float_3 = 0f;
						this.vector2_1.X = 0f;
					}
				}
				else
				{
					this.vector2_0.X = (float)((int)this.vector2_0.X) + (44f + this.float_17);
					this.bool_11 = true;
					this.float_3 = 0f;
					this.vector2_1.X = 0f;
				}
			}
			if (this.float_17 > -48f && this.int_6 <= 0)
			{
				this.bool_11 = false;
			}
			if (this.float_15 < 48f && this.int_7 <= 0)
			{
				this.bool_11 = false;
			}
			break;
		case (GEnum0)1:
			this.float_14 = this.method_11(num + 32, num2);
			break;
		case (GEnum0)3:
			this.float_14 = this.method_11(num - 32, num2);
			break;
		case (GEnum0)4:
			if (this.genum3_0 == (GEnum3)0 || this.genum3_0 == (GEnum3)2)
			{
				this.method_14(num, num2 - 64);
			}
			num3 = this.float_17;
			num4 = this.float_15;
			if (this.genum3_0 == (GEnum3)1 || this.genum3_0 == (GEnum3)2)
			{
				this.method_16(num, num2 - 64, false, false);
			}
			if (this.float_17 < num3)
			{
				this.float_17 = num3;
			}
			if (this.float_15 > num4)
			{
				this.float_15 = num4;
			}
			if (this.float_15 < 44f)
			{
				this.vector2_0.X = (float)((int)this.vector2_0.X) - (44f - this.float_15);
				this.bool_11 = true;
				this.float_3 = 0f;
				this.vector2_1.X = 0f;
			}
			if (this.float_17 > -44f)
			{
				this.vector2_0.X = (float)((int)this.vector2_0.X) + (44f + this.float_17);
				this.bool_11 = true;
				this.float_3 = 0f;
				this.vector2_1.X = 0f;
			}
			break;
		}
		if ((this.float_17 < -48f && this.int_7 == 0) || (this.float_15 > 48f && this.int_6 == 0))
		{
			this.bool_11 = false;
		}
		if (this.float_11 < -48f && this.int_7 == 0)
		{
			this.bool_12 = false;
		}
		if (this.float_12 > 48f && this.int_6 == 0)
		{
			this.bool_13 = false;
		}
		if (!this.bool_10)
		{
			this.bool_11 = false;
			this.bool_12 = false;
			this.bool_13 = false;
		}
		if (this.bool_12 || this.bool_13)
		{
			this.genum4_0 = (GEnum4)0;
		}
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00002288 File Offset: 0x00000488
	private void method_27()
	{
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0001314C File Offset: 0x0001134C
	public void method_28()
	{
		this.gclass33_16 = this.gclass33_0;
		this.genum4_0 = (GEnum4)0;
		this.vector2_0 = new Vector2(7132f, 6400f);
		this.int_28 = 0;
		this.float_27 = 0f;
		this.bool_0 = true;
		this.float_3 = 0f;
		this.int_17 = 0;
		this.genum4_0 = (GEnum4)0;
		this.genum2_0 = (GEnum2)0;
		this.genum1_0 = (GEnum1)0;
		this.bool_15 = false;
		this.bool_17 = false;
		this.bool_18 = false;
	}

	// Token: 0x0600011D RID: 285 RVA: 0x000131D8 File Offset: 0x000113D8
	private void method_29()
	{
		this.method_25();
		this.method_5();
		this.method_26();
		if (Math.Abs(this.float_3) > 0.01f)
		{
			this.genum4_0 = (GEnum4)1;
		}
		if (!this.bool_12 && !this.bool_11 && this.int_6 > 0 && this.int_7 == 0)
		{
			this.bool_0 = false;
			this.genum4_0 = (GEnum4)1;
		}
		if (!this.bool_13 && !this.bool_11 && this.int_7 > 0 && this.int_6 == 0)
		{
			this.bool_0 = true;
			this.genum4_0 = (GEnum4)1;
		}
		switch (this.genum0_0)
		{
		case (GEnum0)0:
			if (this.float_14 >= 0f && this.vector2_1.Y >= 0f)
			{
				if (this.float_14 <= 80f)
				{
					this.vector2_1.Y = 0f;
					this.vector2_0.Y = this.vector2_0.Y + this.float_14;
				}
				else
				{
					this.vector2_1.Y = 0f;
					this.genum4_0 = (GEnum4)9;
				}
			}
			if (this.float_14 < 0f && this.float_14 > -80f)
			{
				this.vector2_0.Y = this.vector2_0.Y + this.float_14;
			}
			break;
		}
		if (this.int_6 == 0 && this.int_7 == 0)
		{
			this.bool_11 = false;
			this.bool_12 = false;
			this.bool_13 = false;
		}
		if (this.int_9 > 0)
		{
			this.genum4_0 = (GEnum4)4;
		}
		if (this.int_8 > 0)
		{
			this.genum4_0 = (GEnum4)7;
		}
		if (this.int_10 == 1 || this.int_11 == 1 || this.int_12 == 1)
		{
			this.genum4_0 = (GEnum4)3;
			this.vector2_1.X = this.vector2_1.X + 26f * (float)Math.Sin((double)this.float_20);
			this.vector2_1.Y = this.vector2_1.Y - 26f * (float)Math.Cos((double)this.float_20);
			this.bool_6 = false;
			this.bool_5 = true;
			GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
		}
	}

	// Token: 0x0600011E RID: 286 RVA: 0x00013448 File Offset: 0x00011648
	private void method_30()
	{
		if (this.genum0_0 != (GEnum0)2)
		{
		}
		this.method_25();
		this.method_5();
		this.method_26();
		if (Math.Abs(this.float_3) > 23.9999f)
		{
			this.genum4_0 = (GEnum4)2;
		}
		if (this.int_9 > 0)
		{
			if ((double)Math.Abs(this.float_3) > 4.125)
			{
				GClass30.soundEffect_8.Play(GClass30.float_0, 0f, 0f);
				this.genum4_0 = (GEnum4)5;
			}
			else
			{
				this.genum4_0 = (GEnum4)4;
			}
		}
		if (this.int_10 == 1 || this.int_11 == 1 || this.int_12 == 1)
		{
			this.genum4_0 = (GEnum4)3;
			this.vector2_1.X = this.vector2_1.X + 26f * (float)Math.Sin((double)this.float_20);
			this.vector2_1.Y = this.vector2_1.Y + -26f * (float)Math.Cos((double)this.float_20);
			this.bool_5 = true;
			GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
		}
		switch (this.genum0_0)
		{
		case (GEnum0)0:
			if (this.float_14 >= 0f && this.vector2_1.Y >= 0f)
			{
				if (this.float_14 <= 64f)
				{
					this.vector2_1.Y = 0f;
					this.vector2_0.Y = this.vector2_0.Y + this.float_14;
				}
				else
				{
					this.vector2_1.Y = 0f;
					this.genum4_0 = (GEnum4)9;
				}
			}
			if (-64f < this.float_14 && this.float_14 < 0f)
			{
				this.vector2_0.Y = this.vector2_0.Y + this.float_14;
			}
			break;
		case (GEnum0)1:
			if (this.float_15 >= 0f && (double)this.vector2_1.X >= -0.1)
			{
				if (this.float_15 <= 64f)
				{
					this.vector2_1.X = 0f;
					this.vector2_0.X = this.vector2_0.X + this.float_15;
				}
				else
				{
					this.vector2_1.X = 0f;
					this.genum4_0 = (GEnum4)9;
				}
			}
			if (-64f < this.float_15 && this.float_15 < 0f)
			{
				this.vector2_0.X = this.vector2_0.X + this.float_15;
			}
			break;
		case (GEnum0)2:
			if (this.float_16 <= 0f && this.vector2_1.Y <= 0f)
			{
				if (this.float_16 >= 64f)
				{
					this.vector2_1.Y = 0f;
					this.vector2_0.Y = this.vector2_0.Y + this.float_16;
				}
				else
				{
					this.vector2_1.Y = 0f;
				}
			}
			if (0f < this.float_16 && this.float_16 < 64f)
			{
				this.vector2_0.Y = this.vector2_0.Y + this.float_16;
			}
			if (this.float_16 < -80f)
			{
				this.vector2_1.Y = 0f;
				this.genum4_0 = (GEnum4)9;
			}
			break;
		case (GEnum0)3:
			if (this.float_17 <= 0f && (double)this.vector2_1.X <= 0.1)
			{
				if (this.float_17 >= -80f)
				{
					this.vector2_1.X = 0f;
					this.vector2_0.X = this.vector2_0.X + this.float_17;
				}
				else
				{
					this.vector2_1.X = 0f;
					this.genum4_0 = (GEnum4)9;
				}
			}
			if (0f < this.float_17 && this.float_17 < 80f)
			{
				this.vector2_0.X = this.vector2_0.X + this.float_17;
			}
			break;
		}
		if (this.genum4_0 == (GEnum4)1 && this.genum0_0 != (GEnum0)0 && (double)Math.Abs(this.float_3) < 10.0)
		{
			if ((double)(-(double)this.float_20) < -1.5676547341413067 || (double)(-(double)this.float_20) > 1.5676547341413067)
			{
				this.float_3 = 0f;
				this.genum4_0 = (GEnum4)9;
			}
			else
			{
				if ((double)(-(double)this.float_20) > -1.6336281798666925 && -this.float_20 < 0f)
				{
					this.int_31 = 30;
				}
				if ((double)(-(double)this.float_20) < 1.6336281798666925 && -this.float_20 > 0f)
				{
					this.int_32 = 30;
				}
			}
		}
		if (this.genum4_0 == (GEnum4)1)
		{
			if (this.int_26 < 1)
			{
				this.gclass33_16.int_1 += 8;
				this.int_26++;
			}
			else if (this.int_25 != this.gclass33_16.int_2)
			{
				if (Math.Abs(this.float_3) > 3.33333325f)
				{
					this.gclass33_16.int_1 += Math.Max(0, (int)(0.8333333f * Math.Abs(this.float_3) / 4f));
				}
				this.int_25 = this.gclass33_16.int_2;
			}
		}
		else
		{
			this.float_21 = 0f;
			this.int_26 = 0;
		}
		if (this.genum4_0 == (GEnum4)9)
		{
			this.int_33 = (int)((double)this.float_20 / 0.098174770424681035);
			this.int_34 = 8;
		}
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00013A74 File Offset: 0x00011C74
	private void method_31()
	{
		this.method_25();
		this.method_5();
		this.method_26();
		if (Math.Abs(this.float_3) < 20f + 0f * (this.float_7 - 0.1f))
		{
			this.genum4_0 = (GEnum4)1;
		}
		if (this.int_9 > 0 && (double)Math.Abs(this.float_3) > 4.125)
		{
			GClass30.soundEffect_8.Play(GClass30.float_0, 0f, 0f);
			this.genum4_0 = (GEnum4)5;
		}
		if (this.int_10 == 1 || this.int_11 == 1 || this.int_12 == 1)
		{
			this.genum4_0 = (GEnum4)3;
			this.vector2_1.X = this.vector2_1.X - -26f * (float)Math.Sin((double)this.float_20);
			this.vector2_1.Y = this.vector2_1.Y - 26f * (float)Math.Cos((double)this.float_20);
			this.bool_5 = true;
			GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
		}
		switch (this.genum0_0)
		{
		case (GEnum0)0:
			if (this.float_14 >= 0f && this.vector2_1.Y >= 0f)
			{
				if (this.float_14 <= 64f)
				{
					this.vector2_1.Y = 0f;
					this.vector2_0.Y = this.vector2_0.Y + this.float_14;
				}
				else
				{
					this.vector2_1.Y = 0f;
					this.genum4_0 = (GEnum4)10;
				}
			}
			if (this.float_14 < 0f && this.float_14 > -64f)
			{
				this.vector2_0.Y = this.vector2_0.Y + this.float_14;
			}
			break;
		case (GEnum0)1:
			if (this.float_15 >= 0f && (double)this.vector2_1.X >= -0.1)
			{
				if (this.float_15 <= 80f)
				{
					this.vector2_1.X = 0f;
					this.vector2_0.X = this.vector2_0.X + this.float_15;
				}
				else
				{
					this.vector2_1.X = 0f;
					this.genum4_0 = (GEnum4)10;
				}
			}
			if (-80f < this.float_15 && this.float_15 < 0f)
			{
				this.vector2_0.X = this.vector2_0.X + this.float_15;
			}
			break;
		case (GEnum0)2:
			if (this.float_16 <= 0f && this.vector2_1.Y <= 0f)
			{
				if (this.float_16 >= 64f)
				{
					this.vector2_1.Y = 0f;
					this.vector2_0.Y = this.vector2_0.Y + this.float_16;
				}
				else
				{
					this.vector2_1.Y = 0f;
				}
			}
			if (this.float_16 > 0f && this.float_16 < 64f)
			{
				this.vector2_0.Y = this.vector2_0.Y + this.float_16;
			}
			if (this.float_16 < -80f)
			{
				this.vector2_1.Y = 0f;
				this.genum4_0 = (GEnum4)10;
			}
			break;
		case (GEnum0)3:
			if (this.float_17 <= 0f && (double)this.vector2_1.X <= 0.1)
			{
				if (this.float_17 >= -80f)
				{
					this.vector2_1.X = 0f;
					this.vector2_0.X = this.vector2_0.X + this.float_17;
				}
				else
				{
					this.vector2_1.X = 0f;
					this.genum4_0 = (GEnum4)10;
				}
			}
			if (0f < this.float_17 && this.float_17 < 80f)
			{
				this.vector2_0.X = this.vector2_0.X + this.float_17;
			}
			break;
		}
		this.float_21 = 0f;
		if (this.genum4_0 == (GEnum4)10)
		{
			this.int_33 = (int)((double)this.float_20 / 0.098174770424681035);
			this.int_34 = 8;
		}
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00013F00 File Offset: 0x00012100
	private void method_32()
	{
		this.method_25();
		this.method_6();
		this.method_26();
		if (this.int_10 == 1 || this.int_11 == 1 || this.int_12 == 1)
		{
			this.genum4_0 = (GEnum4)3;
			this.vector2_1.X = this.vector2_1.X + 26f * (float)Math.Sin((double)this.float_20);
			this.vector2_1.Y = this.vector2_1.Y + -26f * (float)Math.Cos((double)this.float_20);
			this.bool_5 = true;
			GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
		}
		switch (this.genum0_0)
		{
		case (GEnum0)0:
			if (this.float_14 >= 0f && this.vector2_1.Y >= 0f)
			{
				if (this.float_14 <= 80f)
				{
					this.vector2_1.Y = 0f;
					this.vector2_0.Y = this.vector2_0.Y + this.float_14;
				}
				else
				{
					this.vector2_1.Y = 0f;
					this.genum4_0 = (GEnum4)3;
				}
			}
			if (this.float_14 < 0f && this.float_14 > -80f)
			{
				this.vector2_0.Y = this.vector2_0.Y + this.float_14;
			}
			break;
		case (GEnum0)1:
			if (this.float_15 >= 0f && (double)this.vector2_1.X >= -0.1)
			{
				if (this.float_15 <= 80f)
				{
					this.vector2_1.X = 0f;
					this.vector2_0.X = this.vector2_0.X + this.float_15;
				}
				else
				{
					this.vector2_1.X = 0f;
					this.genum4_0 = (GEnum4)3;
				}
			}
			if (-80f < this.float_15 && this.float_15 < 0f)
			{
				this.vector2_0.X = this.vector2_0.X + this.float_15;
			}
			break;
		case (GEnum0)2:
			if (this.float_16 <= 0f && this.vector2_1.Y <= 0f)
			{
				if (this.float_16 >= 64f)
				{
					this.vector2_1.Y = 0f;
					this.vector2_0.Y = this.vector2_0.Y + this.float_16;
				}
				else
				{
					this.vector2_1.Y = 0f;
				}
			}
			if (0f < this.float_16 && this.float_16 < 64f)
			{
				this.vector2_0.Y = this.vector2_0.Y + this.float_16;
			}
			if (this.float_16 < -80f)
			{
				this.vector2_1.Y = 0f;
				this.genum4_0 = (GEnum4)9;
			}
			break;
		case (GEnum0)3:
			if (this.float_17 <= 0f && (double)this.vector2_1.X <= 0.1)
			{
				if (this.float_17 >= -80f)
				{
					this.vector2_1.X = 0f;
					this.vector2_0.X = this.vector2_0.X + this.float_17;
				}
				else
				{
					this.vector2_1.X = 0f;
					this.genum4_0 = (GEnum4)3;
				}
			}
			if (0f < this.float_17 && this.float_17 < 80f)
			{
				this.vector2_0.X = this.vector2_0.X + this.float_17;
			}
			break;
		}
		if (this.genum4_0 == (GEnum4)5 && this.genum0_0 != (GEnum0)0 && (double)Math.Abs(this.float_3) < 10.0 && ((double)(-(double)this.float_20) < -1.5676547341413067 || (double)(-(double)this.float_20) > 1.5676547341413067))
		{
			this.float_3 = 0f;
			this.genum4_0 = (GEnum4)3;
		}
		if (this.genum4_0 == (GEnum4)5)
		{
			if (this.float_21 >= 20f)
			{
				this.float_21 -= 20f;
			}
			else
			{
				this.gclass33_16.int_1--;
			}
			if (Math.Abs(this.float_3) < 20f)
			{
				if (Math.Abs(this.float_3) < 4f)
				{
					this.float_21 += 4f;
				}
				else
				{
					this.float_21 += Math.Abs(this.float_3);
				}
			}
			else
			{
				this.float_21 += 20f;
			}
		}
		else
		{
			this.float_21 = 0f;
		}
	}

	// Token: 0x06000121 RID: 289 RVA: 0x00014408 File Offset: 0x00012608
	private void method_33()
	{
		if (this.int_6 > 0)
		{
			this.bool_0 = false;
			this.vector2_1.X = this.vector2_1.X - this.float_8;
		}
		if (this.int_7 > 0)
		{
			this.bool_0 = true;
			this.vector2_1.X = this.vector2_1.X + this.float_8;
		}
		if (this.bool_6 && this.vector2_1.Y < -16f)
		{
			this.vector2_1.Y = -16f;
		}
		this.method_17((int)this.vector2_0.X, (int)(this.vector2_0.Y - 116f));
		if (-4f < this.float_16 && this.vector2_1.Y < 0f)
		{
			this.vector2_0.Y = this.vector2_0.Y + (-this.float_16 + 4f);
			this.vector2_1.Y = 0f;
		}
		if ((this.int_10 == 1 || this.int_11 == 1 || this.int_12 == 1) && this.bool_5 && this.vector2_1.Y >= -16f)
		{
			switch (this.genum1_0)
			{
			case (GEnum1)0:
				GClass30.soundEffect_18.Play(GClass30.float_0, 0f, 0f);
				break;
			case (GEnum1)1:
				if (this.bool_0)
				{
					this.vector2_1.X = 36f;
				}
				else
				{
					this.vector2_1.X = -36f;
				}
				this.vector2_1.Y = 0f;
				GClass30.soundEffect_4.Play(GClass30.float_0, 0f, 0f);
				break;
			case (GEnum1)2:
				this.vector2_1.X = 0f;
				this.vector2_1.Y = 32f;
				GClass30.soundEffect_2.Play(GClass30.float_0, 0f, 0f);
				break;
			case (GEnum1)3:
				this.vector2_1.Y = -22f;
				GClass30.soundEffect_5.Play(GClass30.float_0, 0f, 0f);
				break;
			}
			this.bool_4 = true;
			this.bool_5 = false;
			this.int_3 = 0;
		}
		if (this.vector2_1.X < -this.float_7)
		{
			this.vector2_1.X = -this.float_7;
		}
		if (this.vector2_1.X > this.float_7)
		{
			this.vector2_1.X = this.float_7;
		}
		if (this.vector2_1.Y > 64f)
		{
			this.vector2_1.Y = 64f;
		}
		if (this.vector2_1.Y < 0f && this.vector2_1.Y > -16f && (double)Math.Abs(this.vector2_1.X) > 0.5)
		{
			this.vector2_1.X = this.vector2_1.X * 0.96875f;
		}
		this.vector2_1.Y = this.vector2_1.Y + this.float_9;
		this.vector2_0.X = this.vector2_0.X + this.vector2_1.X;
		this.vector2_0.Y = this.vector2_0.Y + this.vector2_1.Y;
		this.method_26();
		this.method_25();
		if (this.float_14 > -64f && this.float_14 <= 0f && this.vector2_1.Y >= 0f)
		{
			if (1208.5828491040802 > (double)Math.Abs(this.float_20))
			{
				this.float_3 = this.vector2_1.X;
			}
			else if (2497.7378881484324 > (double)Math.Abs(this.float_20))
			{
				if (Math.Abs(this.vector2_1.X) > this.vector2_1.Y)
				{
					this.float_3 = this.vector2_1.X;
				}
				else
				{
					this.float_3 = (float)((double)this.vector2_1.Y * 0.5 * (double)(-(double)Math.Sign(Math.Cos((double)this.float_20))));
				}
			}
			else if (5076.0479662371372 > (double)Math.Abs(this.float_20))
			{
				if (Math.Abs(this.vector2_1.X) > this.vector2_1.Y)
				{
					this.float_3 = this.vector2_1.X;
				}
				else
				{
					this.float_3 = this.vector2_1.Y * -(float)Math.Sign(Math.Cos((double)this.float_20));
				}
			}
			this.vector2_1.Y = 0f;
			this.vector2_0.Y = this.vector2_0.Y + this.float_14;
			this.genum4_0 = (GEnum4)1;
			if (this.bool_4 && !this.bool_5 && this.genum1_0 == (GEnum1)2)
			{
				this.vector2_1.Y = -30f;
				if (this.int_10 > 0 || this.int_11 > 0 || this.int_12 > 0)
				{
					this.bool_6 = false;
				}
				this.genum4_0 = (GEnum4)3;
				GClass30.soundEffect_2.Play(GClass30.float_0, 0f, 0f);
				this.bool_5 = true;
			}
		}
		else
		{
			this.float_3 = 0f;
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x000149D8 File Offset: 0x00012BD8
	private void method_34()
	{
		if (this.int_6 > 0)
		{
			this.bool_0 = false;
			this.vector2_1.X = this.vector2_1.X - this.float_8;
		}
		if (this.int_7 > 0)
		{
			this.bool_0 = true;
			this.vector2_1.X = this.vector2_1.X + this.float_8;
		}
		if (this.vector2_1.X < -24f)
		{
			this.vector2_1.X = -24f;
		}
		if (this.vector2_1.X > 24f)
		{
			this.vector2_1.X = 24f;
		}
		if (this.vector2_1.Y > 64f)
		{
			this.vector2_1.Y = 64f;
		}
		if (this.vector2_1.Y < 0f && this.vector2_1.Y > -16f && (double)Math.Abs(this.vector2_1.X) > 0.5)
		{
			this.vector2_1.X = this.vector2_1.X * 0.96875f;
		}
		this.vector2_1.Y = this.vector2_1.Y + this.float_9;
		this.vector2_0.X = this.vector2_0.X + this.vector2_1.X;
		this.vector2_0.Y = this.vector2_0.Y + this.vector2_1.Y;
		this.method_26();
		this.method_25();
		this.method_17((int)this.vector2_0.X, (int)this.vector2_0.Y);
		if (this.float_16 > -160f && this.vector2_1.Y < 0f)
		{
			this.vector2_0.Y = this.vector2_0.Y - (this.float_16 + 160f);
			this.vector2_1.Y = 0f;
		}
		if (this.float_14 > -64f && this.float_14 <= 0f && this.vector2_1.Y >= 0f)
		{
			if (1208.5828491040802 > (double)Math.Abs(this.float_20))
			{
				this.float_3 = this.vector2_1.X;
			}
			else if (2497.7378881484324 > (double)Math.Abs(this.float_20))
			{
				if (Math.Abs(this.vector2_1.X) > this.vector2_1.Y)
				{
					this.float_3 = this.vector2_1.X;
				}
				else
				{
					this.float_3 = (float)((double)this.vector2_1.Y * 0.5 * (double)(-(double)Math.Sign(Math.Cos((double)this.float_20))));
				}
			}
			else if (5076.0479662371372 > (double)Math.Abs(this.float_20))
			{
				if (Math.Abs(this.vector2_1.X) > this.vector2_1.Y)
				{
					this.float_3 = this.vector2_1.X;
				}
				else
				{
					this.float_3 = this.vector2_1.Y * -(float)Math.Sign(Math.Cos((double)this.float_20));
				}
			}
			this.vector2_1.Y = 0f;
			this.vector2_0.Y = this.vector2_0.Y + this.float_14;
			this.genum4_0 = (GEnum4)1;
		}
		else
		{
			this.float_3 = 0f;
		}
		if (this.genum4_0 == (GEnum4)8 && this.vector2_1.Y >= 0f)
		{
			this.genum4_0 = (GEnum4)9;
		}
	}

	// Token: 0x06000123 RID: 291 RVA: 0x00014DAC File Offset: 0x00012FAC
	private void method_35()
	{
		if (this.int_6 > 0)
		{
			this.bool_0 = false;
			this.vector2_1.X = this.vector2_1.X - this.float_8;
		}
		if (this.int_7 > 0)
		{
			this.bool_0 = true;
			this.vector2_1.X = this.vector2_1.X + this.float_8;
		}
		if (this.vector2_1.X < -24f)
		{
			this.vector2_1.X = -24f;
		}
		if (this.vector2_1.X > 24f)
		{
			this.vector2_1.X = 24f;
		}
		if (this.vector2_1.Y > 64f)
		{
			this.vector2_1.Y = 64f;
		}
		if (this.vector2_1.Y < 0f && this.vector2_1.Y > -16f && (double)Math.Abs(this.vector2_1.X) > 0.5)
		{
			this.vector2_1.X = this.vector2_1.X * 0.96875f;
		}
		this.vector2_1.Y = this.vector2_1.Y + this.float_9;
		this.vector2_0.X = this.vector2_0.X + this.vector2_1.X;
		this.vector2_0.Y = this.vector2_0.Y + this.vector2_1.Y;
		this.method_17((int)this.vector2_0.X, (int)(this.vector2_0.Y - 156f));
		if (-4f < this.float_16 && this.vector2_1.Y < 0f)
		{
			this.vector2_0.Y = this.vector2_0.Y + (-this.float_16 + 4f);
			this.vector2_1.Y = 0f;
		}
		this.method_26();
		this.method_25();
		this.method_17((int)this.vector2_0.X, (int)this.vector2_0.Y);
		if (this.float_16 > -120f && this.vector2_1.Y < 0f)
		{
			this.vector2_0.Y = this.vector2_0.Y - (this.float_16 + 120f);
			this.vector2_1.Y = 0f;
		}
		if (-64f < this.float_14 && this.float_14 <= 4f && this.vector2_1.Y >= 0f)
		{
			if (1208.5828491040802 > (double)Math.Abs(this.float_20))
			{
				this.float_3 = this.vector2_1.X;
			}
			else if (2497.7378881484324 > (double)Math.Abs(this.float_20))
			{
				if (Math.Abs(this.vector2_1.X) > this.vector2_1.Y)
				{
					this.float_3 = this.vector2_1.X;
				}
				else
				{
					this.float_3 = (float)((double)this.vector2_1.Y * 0.5 * (double)(-(double)Math.Sign(Math.Cos((double)this.float_20))));
				}
			}
			else if (5076.0479662371372 > (double)Math.Abs(this.float_20))
			{
				if (Math.Abs(this.vector2_1.X) > this.vector2_1.Y)
				{
					this.float_3 = this.vector2_1.X;
				}
				else
				{
					this.float_3 = this.vector2_1.Y * -(float)Math.Sign(Math.Cos((double)this.float_20));
				}
			}
			this.vector2_1.Y = 0f;
			this.vector2_0.Y = this.vector2_0.Y + this.float_14;
			this.genum4_0 = (GEnum4)1;
		}
		else
		{
			this.float_3 = 0f;
		}
		if (this.genum4_0 == (GEnum4)8 && this.vector2_1.Y < 0f)
		{
			this.genum4_0 = (GEnum4)8;
		}
	}

	// Token: 0x06000124 RID: 292 RVA: 0x00014DAC File Offset: 0x00012FAC
	private void method_36()
	{
		if (this.int_6 > 0)
		{
			this.bool_0 = false;
			this.vector2_1.X = this.vector2_1.X - this.float_8;
		}
		if (this.int_7 > 0)
		{
			this.bool_0 = true;
			this.vector2_1.X = this.vector2_1.X + this.float_8;
		}
		if (this.vector2_1.X < -24f)
		{
			this.vector2_1.X = -24f;
		}
		if (this.vector2_1.X > 24f)
		{
			this.vector2_1.X = 24f;
		}
		if (this.vector2_1.Y > 64f)
		{
			this.vector2_1.Y = 64f;
		}
		if (this.vector2_1.Y < 0f && this.vector2_1.Y > -16f && (double)Math.Abs(this.vector2_1.X) > 0.5)
		{
			this.vector2_1.X = this.vector2_1.X * 0.96875f;
		}
		this.vector2_1.Y = this.vector2_1.Y + this.float_9;
		this.vector2_0.X = this.vector2_0.X + this.vector2_1.X;
		this.vector2_0.Y = this.vector2_0.Y + this.vector2_1.Y;
		this.method_17((int)this.vector2_0.X, (int)(this.vector2_0.Y - 156f));
		if (-4f < this.float_16 && this.vector2_1.Y < 0f)
		{
			this.vector2_0.Y = this.vector2_0.Y + (-this.float_16 + 4f);
			this.vector2_1.Y = 0f;
		}
		this.method_26();
		this.method_25();
		this.method_17((int)this.vector2_0.X, (int)this.vector2_0.Y);
		if (this.float_16 > -120f && this.vector2_1.Y < 0f)
		{
			this.vector2_0.Y = this.vector2_0.Y - (this.float_16 + 120f);
			this.vector2_1.Y = 0f;
		}
		if (-64f < this.float_14 && this.float_14 <= 4f && this.vector2_1.Y >= 0f)
		{
			if (1208.5828491040802 > (double)Math.Abs(this.float_20))
			{
				this.float_3 = this.vector2_1.X;
			}
			else if (2497.7378881484324 > (double)Math.Abs(this.float_20))
			{
				if (Math.Abs(this.vector2_1.X) > this.vector2_1.Y)
				{
					this.float_3 = this.vector2_1.X;
				}
				else
				{
					this.float_3 = (float)((double)this.vector2_1.Y * 0.5 * (double)(-(double)Math.Sign(Math.Cos((double)this.float_20))));
				}
			}
			else if (5076.0479662371372 > (double)Math.Abs(this.float_20))
			{
				if (Math.Abs(this.vector2_1.X) > this.vector2_1.Y)
				{
					this.float_3 = this.vector2_1.X;
				}
				else
				{
					this.float_3 = this.vector2_1.Y * -(float)Math.Sign(Math.Cos((double)this.float_20));
				}
			}
			this.vector2_1.Y = 0f;
			this.vector2_0.Y = this.vector2_0.Y + this.float_14;
			this.genum4_0 = (GEnum4)1;
		}
		else
		{
			this.float_3 = 0f;
		}
		if (this.genum4_0 == (GEnum4)8 && this.vector2_1.Y < 0f)
		{
			this.genum4_0 = (GEnum4)8;
		}
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00015200 File Offset: 0x00013400
	public override void Update()
	{
		if (!this.bool_17)
		{
			this.string_0 = "";
			this.string_1 = "";
			if (this.genum0_0 != (GEnum0)4)
			{
				this.bool_4 = false;
			}
			this.int_4++;
			this.int_24++;
			this.float_16 = -80000f;
			this.method_3();
			this.method_23();
			if (this.int_17 >= 100 && !this.bool_15)
			{
				GClass30.soundEffect_19.Play(GClass30.float_0, 0f, 0f);
				GClass26.gclass29_0.int_19 = GClass26.gclass29_0.int_20 + 180;
				this.bool_15 = true;
				this.int_18++;
			}
			if (this.vector2_0.Y < 0f)
			{
				this.genum4_0 = (GEnum4)9;
				this.genum0_0 = (GEnum0)4;
			}
			if (this.bool_4 && this.genum1_0 == (GEnum1)0 && this.int_3 < 6)
			{
				this.int_29 = 80;
			}
			else
			{
				this.int_29 = 0;
			}
			if (this.int_30 > 0)
			{
				this.int_30--;
				this.int_7 = 0;
				this.int_6 = 0;
			}
			if (this.int_31 > 0)
			{
				this.int_31--;
				this.int_6 = 0;
			}
			if (this.int_32 > 0)
			{
				this.int_32--;
				this.int_7 = 0;
			}
			switch (this.genum4_0)
			{
			case (GEnum4)0:
				this.method_29();
				break;
			case (GEnum4)1:
				this.method_30();
				break;
			case (GEnum4)2:
				this.method_31();
				break;
			case (GEnum4)3:
				this.method_33();
				break;
			case (GEnum4)4:
				if (this.int_9 == 0)
				{
					this.genum4_0 = (GEnum4)0;
				}
				if (this.int_6 > 0)
				{
					this.bool_0 = false;
				}
				if (this.int_7 > 0)
				{
					this.bool_0 = true;
				}
				if (this.genum4_0 == (GEnum4)4 && (this.int_10 == 1 || this.int_11 == 1 || this.int_12 == 1))
				{
					this.genum4_0 = (GEnum4)6;
					GClass30.soundEffect_10.Play(GClass30.float_0, 0f, 0f);
				}
				break;
			case (GEnum4)5:
				this.method_32();
				break;
			case (GEnum4)6:
				if (this.int_6 > 0)
				{
					this.bool_0 = false;
				}
				if (this.int_7 > 0)
				{
					this.bool_0 = true;
				}
				if (this.int_10 == 1 || this.int_11 == 1 || this.int_12 == 1)
				{
					GClass30.soundEffect_10.Play(GClass30.float_0, 0f, 0f);
				}
				if (this.int_9 == 0)
				{
					int num = 0;
					if (this.bool_0)
					{
						this.float_3 = (float)((8 + num) * 4);
					}
					if (!this.bool_0)
					{
						this.float_3 -= (float)((8 + num) * 4);
					}
					GClass30.soundEffect_20.Play(GClass30.float_0, 0f, 0f);
					this.genum4_0 = (GEnum4)5;
				}
				break;
			case (GEnum4)7:
				if (this.int_8 == 0)
				{
					this.genum4_0 = (GEnum4)0;
				}
				if (this.int_6 > 0)
				{
					this.bool_0 = false;
				}
				if (this.int_7 > 0)
				{
					this.bool_0 = true;
				}
				else if (this.int_10 == 1 || this.int_11 == 1 || this.int_12 == 1)
				{
					this.genum4_0 = (GEnum4)3;
					this.vector2_1.X = this.vector2_1.X - -26f * (float)Math.Sin((double)this.float_20);
					this.vector2_1.Y = this.vector2_1.Y - 26f * (float)Math.Cos((double)this.float_20);
					this.bool_5 = true;
					GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
				}
				break;
			case (GEnum4)8:
				this.method_34();
				break;
			case (GEnum4)9:
				this.method_35();
				break;
			case (GEnum4)10:
				this.method_36();
				break;
			case (GEnum4)11:
				if (this.vector2_1.X < -24f)
				{
					this.vector2_1.X = -24f;
				}
				if (this.vector2_1.X > 24f)
				{
					this.vector2_1.X = 24f;
				}
				if (this.vector2_1.Y > 64f)
				{
					this.vector2_1.Y = 64f;
				}
				if (this.vector2_1.Y < 0f && this.vector2_1.Y > -16f && (double)Math.Abs(this.vector2_1.X) > 0.5)
				{
					this.vector2_1.X = this.vector2_1.X * 0.96875f;
				}
				this.vector2_1.Y = this.vector2_1.Y + 0.75f;
				this.vector2_0.X = this.vector2_0.X + this.vector2_1.X;
				this.vector2_0.Y = this.vector2_0.Y + this.vector2_1.Y;
				this.method_25();
				this.method_26();
				if (this.float_14 > -64f && this.float_14 <= 0f && this.vector2_1.Y >= 0f)
				{
					if (1208.5828491040802 > (double)Math.Abs(this.float_20))
					{
						this.float_3 = this.vector2_1.X;
					}
					else if (2497.7378881484324 > (double)Math.Abs(this.float_20))
					{
						if (Math.Abs(this.vector2_1.X) > this.vector2_1.Y)
						{
							this.float_3 = this.vector2_1.X;
						}
						else
						{
							this.float_3 = (float)((double)this.vector2_1.Y * 0.5 * (double)(-(double)Math.Sign(Math.Cos((double)this.float_20))));
						}
					}
					else if (5076.0479662371372 > (double)Math.Abs(this.float_20))
					{
						if (Math.Abs(this.vector2_1.X) > this.vector2_1.Y)
						{
							this.float_3 = this.vector2_1.X;
						}
						else
						{
							this.float_3 = this.vector2_1.Y * -(float)Math.Sign(Math.Cos((double)this.float_20));
						}
					}
					this.float_3 = 0f;
					this.vector2_1.Y = 0f;
					this.vector2_0.Y = this.vector2_0.Y + this.float_14;
					this.genum4_0 = (GEnum4)1;
					this.int_5 = 120;
				}
				else
				{
					this.float_3 = 0f;
				}
				break;
			case (GEnum4)12:
				this.bool_13 = false;
				this.bool_12 = false;
				this.bool_11 = false;
				this.float_27 += this.vector2_1.Y;
				this.vector2_1.Y = this.vector2_1.Y + this.float_9;
				if (this.float_27 > 1000f)
				{
					this.int_28++;
					if (this.int_28 == 1)
					{
						this.int_18--;
					}
					if (this.int_28 == 60)
					{
						if (this.int_18 < 0)
						{
							this.int_18 = 0;
						}
						GClass26.gclass29_0.bool_6 = true;
					}
				}
				break;
			case (GEnum4)13:
				this.int_27++;
				if (this.int_10 == 1 || this.int_11 == 1 || this.int_12 == 1)
				{
					this.genum4_0 = (GEnum4)3;
					this.vector2_1.Y = -26f;
					this.bool_5 = true;
					this.bool_6 = false;
					GClass30.soundEffect_22.Play(GClass30.float_0, 0f, 0f);
					this.int_27 = 0;
				}
				if (this.int_27 > 24)
				{
					if (this.vector2_1.Y < 0f)
					{
						this.genum4_0 = (GEnum4)8;
						this.vector2_1.Y = -40f;
					}
					else
					{
						this.genum4_0 = (GEnum4)3;
						this.vector2_1.Y = 32f;
					}
				}
				break;
			}
			if (this.genum4_0 == (GEnum4)4 || this.genum4_0 == (GEnum4)7)
			{
				this.bool_11 = false;
				this.bool_12 = false;
				this.bool_13 = false;
			}
			if (this.bool_12 && this.int_6 == 0)
			{
				this.bool_12 = false;
			}
			if (this.bool_13 && this.int_7 == 0)
			{
				this.bool_13 = false;
			}
			if (!this.bool_11 && !this.bool_12 && !this.bool_13)
			{
				this.gclass33_16.int_1++;
			}
			else
			{
				this.gclass33_11.int_1++;
			}
			if (this.genum4_0 == (GEnum4)3 || this.genum4_0 == (GEnum4)8 || this.genum4_0 == (GEnum4)9 || this.genum4_0 == (GEnum4)10)
			{
				this.bool_10 = false;
			}
			else
			{
				this.bool_10 = true;
			}
			if (this.genum4_0 == (GEnum4)4 || this.genum4_0 == (GEnum4)7)
			{
				this.int_22++;
			}
			else
			{
				this.int_22 = 0;
			}
			if (this.genum4_0 != (GEnum4)1)
			{
				this.int_23 = 0;
			}
			if (this.genum4_0 == (GEnum4)3 || this.genum4_0 == (GEnum4)8 || this.genum4_0 == (GEnum4)9 || this.genum4_0 == (GEnum4)10 || this.genum4_0 == (GEnum4)11)
			{
				this.genum0_0 = (GEnum0)4;
			}
			if (this.int_5 > 0)
			{
				this.int_5--;
			}
			if (this.int_5 < 0)
			{
				this.int_5 = 0;
			}
			if (this.int_33 != 0)
			{
				this.int_34--;
				if (this.int_34 == 0)
				{
					this.int_34 = 1001;
				}
				if (this.int_34 % 2 == 0)
				{
					this.int_33 -= Math.Sign(this.int_33);
				}
			}
			string text = GClass29.gclass24_0.string_0;
			if (text != null)
			{
				if (!(text == "MHZ1"))
				{
					if (text == "ES")
					{
						if (this.vector2_0.X < 48f)
						{
							this.vector2_0.X = 48f;
							this.float_3 = 0f;
							this.vector2_1.X = 0f;
						}
						if (this.vector2_0.X > 2512f)
						{
							this.vector2_0.X = 2512f;
							this.float_3 = 0f;
							this.vector2_1.X = 0f;
						}
					}
				}
				else
				{
					if (this.vector2_0.X < 6508f)
					{
						this.vector2_0.X = 6508f;
						this.float_3 = 0f;
						this.vector2_1.X = 0f;
					}
					if (this.vector2_0.X > (float)(135 * GClass26.gclass29_0.int_4))
					{
						this.vector2_0.X = (float)(135 * GClass26.gclass29_0.int_4);
					}
				}
			}
			this.bool_14 = false;
			if (this.genum4_0 != (GEnum4)3)
			{
				this.bool_5 = false;
				this.bool_4 = false;
			}
			this.int_3++;
		}
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00015E6C File Offset: 0x0001406C
	public override void vmethod_1()
	{
		if (!this.bool_17)
		{
			this.method_4();
			this.float_1 = 0f;
			if ((double)this.float_20 >= 0.58904862254808621)
			{
				this.float_1 = 0.7853982f;
			}
			if ((double)this.float_20 >= 1.1780972450961724)
			{
				this.float_1 = 1.57079637f;
			}
			if ((double)this.float_20 >= 1.9634954084936207)
			{
				this.float_1 = 2.3561945f;
			}
			if ((double)this.float_20 <= -0.58904862254808621)
			{
				this.float_1 = -0.7853982f;
			}
			if ((double)this.float_20 <= -1.1780972450961724)
			{
				this.float_1 = -1.57079637f;
			}
			if ((double)this.float_20 <= -1.9634954084936207)
			{
				this.float_1 = -2.3561945f;
			}
			if ((double)this.float_20 <= -2.748893571891069 || (double)this.float_20 >= 2.748893571891069)
			{
				this.float_1 = 3.14159274f;
			}
			if (this.genum0_0 == (GEnum0)4)
			{
				this.float_1 = 0f;
			}
			if (this.genum4_0 == (GEnum4)9 || this.genum4_0 == (GEnum4)10)
			{
				this.float_1 = (float)this.int_33 * 3.14159274f / 32f;
			}
			Vector2 zero = Vector2.Zero;
			zero.X = this.vector2_0.X - GClass26.gclass29_0.vector2_0.X - 100f;
			zero.Y = this.vector2_0.Y - GClass26.gclass29_0.vector2_0.Y - 80f - 100f;
			SpriteEffects spriteEffects;
			if (this.bool_0)
			{
				spriteEffects = (SpriteEffects)0;
			}
			else
			{
				spriteEffects = (SpriteEffects)1;
			}
			if (!this.bool_4)
			{
				switch (this.genum1_0)
				{
				case (GEnum1)1:
					if (this.int_4 % 4 > 1)
					{
						int num = this.int_4 % 36 / 4 + 9;
						Texture2D texture2D = GClass26.gclass29_0.texture2D_21[num];
						this.gclass25_0.spriteBatch_0.Draw(texture2D, new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height), new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height)), Color.White, 0f, Vector2.Zero, spriteEffects, 0f);
					}
					break;
				case (GEnum1)3:
					spriteEffects = 0;
					if (this.int_4 % 84 >= 42 && this.int_4 % 84 < 78)
					{
						int num = 8 - (this.int_4 % 84 - 42) / 4;
						Texture2D texture2D = GClass26.gclass29_0.texture2D_22[num];
						this.gclass25_0.spriteBatch_0.Draw(texture2D, new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height), new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height)), Color.White, 0f, Vector2.Zero, spriteEffects, 0f);
					}
					break;
				}
			}
			zero.X = this.vector2_0.X - GClass26.gclass29_0.vector2_0.X + 80f * (float)Math.Abs(Math.Sin((double)this.float_1));
			zero.Y = this.vector2_0.Y - GClass26.gclass29_0.vector2_0.Y + 4f - (76f - 80f * (float)Math.Cos((double)this.float_1));
			if (this.genum0_0 == (GEnum0)3 || this.float_1 > 0f)
			{
				zero.X = this.vector2_0.X - GClass26.gclass29_0.vector2_0.X - 80f * (float)Math.Abs(Math.Sin((double)this.float_1));
			}
			if (this.genum0_0 == (GEnum0)2)
			{
				zero.Y -= 8f;
			}
			if (this.genum4_0 == (GEnum4)12)
			{
				zero.Y = this.vector2_0.Y - GClass26.gclass29_0.vector2_0.Y - this.float_2 - (76f - 76f * (float)Math.Cos((double)this.float_1)) + this.float_27;
			}
			if (this.genum4_0 == (GEnum4)13)
			{
				zero.Y += 100f;
			}
			if (this.bool_0)
			{
				spriteEffects = (SpriteEffects)0;
			}
			else
			{
				spriteEffects = (SpriteEffects)1;
			}
			Color color;
			if (GClass29.color_0 == Color.Black)
			{
				color = Color.Black;
			}
			else
			{
				color = Color.White;
			}
			if (this.int_5 / 4 % 2 == 0)
			{
				this.gclass25_0.spriteBatch_0.Draw(this.gclass33_16.texture2D_0[this.gclass33_16.int_2], zero - new Vector2(0f, 0f), new Rectangle?(new Rectangle(0, 0, this.gclass33_16.texture2D_0[this.gclass33_16.int_2].Width, this.gclass33_16.texture2D_0[this.gclass33_16.int_2].Height)), color, this.float_1, new Vector2((float)(this.gclass33_16.texture2D_0[this.gclass33_16.int_2].Width / 2), (float)this.gclass33_16.texture2D_0[this.gclass33_16.int_2].Height), 1f, spriteEffects, 0f);
			}
			zero.X = this.vector2_0.X - GClass26.gclass29_0.vector2_0.X - 100f;
			zero.Y = this.vector2_0.Y - GClass26.gclass29_0.vector2_0.Y - 80f - 100f;
			if (this.genum4_0 == (GEnum4)3 || this.genum4_0 == (GEnum4)5)
			{
				zero.Y += 20f;
			}
			if (!this.bool_4)
			{
				switch (this.genum1_0)
				{
				case (GEnum1)1:
					if (this.int_4 % 4 <= 1)
					{
						int num = this.int_4 % 36 / 4;
						Texture2D texture2D = GClass26.gclass29_0.texture2D_21[num];
						this.gclass25_0.spriteBatch_0.Draw(texture2D, new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height), new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height)), Color.White, 0f, Vector2.Zero, spriteEffects, 0f);
					}
					break;
				case (GEnum1)2:
				{
					int num;
					if (this.int_4 % 4 / 2 == 0)
					{
						if (this.int_4 % 12 > 5)
						{
						}
						num = 9;
					}
					else
					{
						num = this.int_4 / 2 % 54 / 6;
					}
					Texture2D texture2D;
					if (this.int_4 % 4 / 2 == 0)
					{
						int num2 = this.int_4 / 2 % 54 / 6;
						texture2D = GClass26.gclass29_0.texture2D_20[num2];
						this.gclass25_0.spriteBatch_0.Draw(texture2D, new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height), new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height)), new Color(Vector4.One * 0.5f), 0f, Vector2.Zero, spriteEffects, 0f);
					}
					texture2D = GClass26.gclass29_0.texture2D_20[num];
					this.gclass25_0.spriteBatch_0.Draw(texture2D, new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height), new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height)), Color.White, 0f, Vector2.Zero, spriteEffects, 0f);
					if (this.int_4 % 4 / 2 == 1)
					{
						if (this.int_4 % 12 > 5)
						{
						}
						texture2D = GClass26.gclass29_0.texture2D_20[9];
						this.gclass25_0.spriteBatch_0.Draw(texture2D, new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height), new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height)), new Color(Vector4.One * 0.5f), 0f, Vector2.Zero, spriteEffects, 0f);
					}
					break;
				}
				case (GEnum1)3:
					spriteEffects = 0;
					if (this.int_4 % 84 < 42 || this.int_4 % 84 >= 78)
					{
						if (this.int_4 % 84 < 36)
						{
							int num = this.int_4 % 84 / 4;
							Texture2D texture2D = GClass26.gclass29_0.texture2D_22[num];
							this.gclass25_0.spriteBatch_0.Draw(texture2D, new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height), new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height)), Color.White, 0f, Vector2.Zero, spriteEffects, 0f);
						}
						else if (this.int_4 % 84 < 42)
						{
							int num = (this.int_4 % 84 - 36) / 2 + 9;
							Texture2D texture2D = GClass26.gclass29_0.texture2D_22[num];
							this.gclass25_0.spriteBatch_0.Draw(texture2D, new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height), new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height)), Color.White, 0f, Vector2.Zero, spriteEffects, 0f);
						}
						else
						{
							int num = (this.int_4 % 84 - 78) / 2 + 9;
							Texture2D texture2D = GClass26.gclass29_0.texture2D_22[num];
							this.gclass25_0.spriteBatch_0.Draw(texture2D, new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height), new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height)), Color.White, 0f, Vector2.Zero, spriteEffects, 0f);
						}
					}
					break;
				}
			}
			zero.X = this.vector2_0.X - GClass26.gclass29_0.vector2_0.X;
			zero.Y = this.vector2_0.Y - GClass26.gclass29_0.vector2_0.Y - 80f;
			if (this.bool_4)
			{
				switch (this.genum1_0)
				{
				case (GEnum1)0:
					if (this.int_3 < 6)
					{
						int num = this.int_3 % 6;
						Texture2D texture2D = GClass26.gclass29_0.texture2D_25[num];
						zero.X -= (float)(texture2D.Width / 2);
						if (num < 7)
						{
							zero.Y += (float)(20 - texture2D.Height / 2);
						}
						else
						{
							zero.Y += (float)(-16 - texture2D.Height / 2);
						}
						SpriteBatch spriteBatch_ = this.gclass25_0.spriteBatch_0;
						Texture2D texture2D2 = texture2D;
						Rectangle rectangle = new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height);
						Rectangle? rectangle2 = new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height));
						Color white = Color.White;
						float num3 = 0f;
						float num4 = 0f;
						float num5 = (float)(texture2D.Width / 2);
						int height = texture2D.Height;
						spriteBatch_.Draw(texture2D2, rectangle, rectangle2, white, num3, num4 * new Vector2(num5, 0f), spriteEffects, 0f);
					}
					break;
				case (GEnum1)1:
				{
					zero.X -= 100f;
					zero.Y -= 100f;
					int num = this.int_3 / 2 % 6;
					switch (num)
					{
					case 3:
						num = 0;
						break;
					case 4:
						num = 2;
						break;
					case 5:
						num = 3;
						break;
					}
					Texture2D texture2D = GClass26.gclass29_0.texture2D_24[num];
					this.gclass25_0.spriteBatch_0.Draw(texture2D, new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height), new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height)), Color.White, 0f, 0f * new Vector2(0f, 0f), spriteEffects, 0f);
					break;
				}
				case (GEnum1)2:
				{
					zero.Y -= 75f;
					Texture2D texture2D = GClass26.gclass29_0.texture2D_20[10];
					if (this.bool_5)
					{
						if (this.vector2_1.Y < -14f)
						{
							texture2D = GClass26.gclass29_0.texture2D_23[1];
						}
						else if (this.vector2_1.Y < -8f)
						{
							texture2D = GClass26.gclass29_0.texture2D_23[0];
						}
						else
						{
							this.bool_4 = false;
						}
					}
					else if (this.vector2_1.Y > 44f)
					{
						texture2D = GClass26.gclass29_0.texture2D_23[0];
					}
					zero.X -= (float)(texture2D.Width / 2);
					this.gclass25_0.spriteBatch_0.Draw(texture2D, new Rectangle((int)zero.X, (int)zero.Y, texture2D.Width, texture2D.Height), new Rectangle?(new Rectangle(0, 0, texture2D.Width, texture2D.Height)), Color.White, 0f, Vector2.Zero, spriteEffects, 0f);
					break;
				}
				case (GEnum1)3:
					zero.X -= 100f;
					zero.Y -= 100f;
					break;
				}
			}
		}
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00016D24 File Offset: 0x00014F24
	public void method_37()
	{
		Vector2 zero = Vector2.Zero;
		zero.X = this.vector2_0.X - GClass26.gclass29_0.vector2_0.X;
		zero.Y = this.vector2_0.Y - GClass26.gclass29_0.vector2_0.Y;
		this.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_3, zero - new Vector2((float)(GClass26.gclass29_0.texture2D_3.Width / 2), (float)(GClass26.gclass29_0.texture2D_3.Height / 2 + 80)), Color.Green);
		if (this.genum0_0 == (GEnum0)1)
		{
			zero.X += 80f;
			zero.Y -= 80f;
		}
		if (this.genum0_0 == (GEnum0)3)
		{
			zero.X -= 80f;
			zero.Y -= 80f;
		}
		if (this.genum0_0 == (GEnum0)2)
		{
			zero.Y -= 160f;
		}
		this.gclass25_0.spriteBatch_0.Draw(GClass26.gclass29_0.texture2D_3, zero - new Vector2((float)(GClass26.gclass29_0.texture2D_3.Width / 2), (float)(GClass26.gclass29_0.texture2D_3.Height / 2)), Color.White);
	}

	// Token: 0x04000145 RID: 325
	private float float_1 = 0f;

	// Token: 0x04000146 RID: 326
	public string string_0 = "";

	// Token: 0x04000147 RID: 327
	public string string_1 = "";

	// Token: 0x04000148 RID: 328
	public GClass33 gclass33_0;

	// Token: 0x04000149 RID: 329
	public GClass33 gclass33_1;

	// Token: 0x0400014A RID: 330
	public GClass33 gclass33_2;

	// Token: 0x0400014B RID: 331
	public GClass33 gclass33_3;

	// Token: 0x0400014C RID: 332
	public GClass33 gclass33_4;

	// Token: 0x0400014D RID: 333
	public GClass33 gclass33_5;

	// Token: 0x0400014E RID: 334
	public GClass33 gclass33_6;

	// Token: 0x0400014F RID: 335
	public GClass33 gclass33_7;

	// Token: 0x04000150 RID: 336
	public GClass33 gclass33_8;

	// Token: 0x04000151 RID: 337
	public GClass33 gclass33_9;

	// Token: 0x04000152 RID: 338
	public GClass33 gclass33_10;

	// Token: 0x04000153 RID: 339
	public GClass33 gclass33_11;

	// Token: 0x04000154 RID: 340
	public GClass33 gclass33_12;

	// Token: 0x04000155 RID: 341
	public GClass33 gclass33_13;

	// Token: 0x04000156 RID: 342
	public GClass33 gclass33_14;

	// Token: 0x04000157 RID: 343
	public GClass33 gclass33_15;

	// Token: 0x04000158 RID: 344
	public GClass33 gclass33_16;

	// Token: 0x04000159 RID: 345
	private GClass25 gclass25_0;

	// Token: 0x0400015A RID: 346
	public GEnum4 genum4_0;

	// Token: 0x0400015B RID: 347
	public GEnum1 genum1_0 = (GEnum1)0;

	// Token: 0x0400015C RID: 348
	public GEnum2 genum2_0 = (GEnum2)0;

	// Token: 0x0400015D RID: 349
	public GEnum3 genum3_0 = (GEnum3)0;

	// Token: 0x0400015E RID: 350
	private int int_2 = 0;

	// Token: 0x0400015F RID: 351
	private bool bool_4 = false;

	// Token: 0x04000160 RID: 352
	private bool bool_5 = false;

	// Token: 0x04000161 RID: 353
	private bool bool_6 = false;

	// Token: 0x04000162 RID: 354
	private int int_3 = 0;

	// Token: 0x04000163 RID: 355
	public int int_4 = 0;

	// Token: 0x04000164 RID: 356
	private bool bool_7 = false;

	// Token: 0x04000165 RID: 357
	public int int_5 = 0;

	// Token: 0x04000166 RID: 358
	private float float_2 = 0f;

	// Token: 0x04000167 RID: 359
	public Vector2 vector2_1;

	// Token: 0x04000168 RID: 360
	public float float_3 = 0f;

	// Token: 0x04000169 RID: 361
	private int int_6;

	// Token: 0x0400016A RID: 362
	private int int_7;

	// Token: 0x0400016B RID: 363
	private int int_8;

	// Token: 0x0400016C RID: 364
	private int int_9;

	// Token: 0x0400016D RID: 365
	private int int_10;

	// Token: 0x0400016E RID: 366
	private int int_11;

	// Token: 0x0400016F RID: 367
	private int int_12;

	// Token: 0x04000170 RID: 368
	private int int_13;

	// Token: 0x04000171 RID: 369
	private int int_14;

	// Token: 0x04000172 RID: 370
	private int int_15;

	// Token: 0x04000173 RID: 371
	private int int_16;

	// Token: 0x04000174 RID: 372
	public GEnum0 genum0_0 = (GEnum0)0;

	// Token: 0x04000175 RID: 373
	public int int_17 = 0;

	// Token: 0x04000176 RID: 374
	public int int_18 = 3;

	// Token: 0x04000177 RID: 375
	public int int_19 = 0;

	// Token: 0x04000178 RID: 376
	public int int_20 = 0;

	// Token: 0x04000179 RID: 377
	public static Color color_0 = Color.White;

	// Token: 0x0400017A RID: 378
	public float float_4;

	// Token: 0x0400017B RID: 379
	public float float_5;

	// Token: 0x0400017C RID: 380
	public float float_6;

	// Token: 0x0400017D RID: 381
	public float float_7;

	// Token: 0x0400017E RID: 382
	public float float_8;

	// Token: 0x0400017F RID: 383
	public float float_9;

	// Token: 0x04000180 RID: 384
	private float float_10;

	// Token: 0x04000181 RID: 385
	public bool bool_8 = false;

	// Token: 0x04000182 RID: 386
	public bool bool_9 = false;

	// Token: 0x04000183 RID: 387
	public bool bool_10 = true;

	// Token: 0x04000184 RID: 388
	public bool bool_11 = false;

	// Token: 0x04000185 RID: 389
	public bool bool_12 = false;

	// Token: 0x04000186 RID: 390
	public bool bool_13 = false;

	// Token: 0x04000187 RID: 391
	public float float_11 = -10000f;

	// Token: 0x04000188 RID: 392
	public float float_12 = 10000f;

	// Token: 0x04000189 RID: 393
	public bool bool_14 = false;

	// Token: 0x0400018A RID: 394
	public int int_21 = 10000;

	// Token: 0x0400018B RID: 395
	private float float_13;

	// Token: 0x0400018C RID: 396
	public float float_14 = 100000f;

	// Token: 0x0400018D RID: 397
	public float float_15 = 100000f;

	// Token: 0x0400018E RID: 398
	public float float_16 = -100000f;

	// Token: 0x0400018F RID: 399
	public float float_17 = -100000f;

	// Token: 0x04000190 RID: 400
	private float float_18;

	// Token: 0x04000191 RID: 401
	private float float_19;

	// Token: 0x04000192 RID: 402
	public int int_22 = 0;

	// Token: 0x04000193 RID: 403
	public float float_20 = 0f;

	// Token: 0x04000194 RID: 404
	private int int_23;

	// Token: 0x04000195 RID: 405
	public int int_24 = 0;

	// Token: 0x04000196 RID: 406
	private int int_25 = 0;

	// Token: 0x04000197 RID: 407
	private int int_26 = 0;

	// Token: 0x04000198 RID: 408
	private float float_21 = 0f;

	// Token: 0x04000199 RID: 409
	public int int_27 = 0;

	// Token: 0x0400019A RID: 410
	private float float_22 = 0f;

	// Token: 0x0400019B RID: 411
	public float float_23;

	// Token: 0x0400019C RID: 412
	public float float_24;

	// Token: 0x0400019D RID: 413
	public float float_25;

	// Token: 0x0400019E RID: 414
	public float float_26;

	// Token: 0x0400019F RID: 415
	public float float_27 = 0f;

	// Token: 0x040001A0 RID: 416
	public int int_28 = 0;

	// Token: 0x040001A1 RID: 417
	private bool bool_15 = false;

	// Token: 0x040001A2 RID: 418
	public bool bool_16 = false;

	// Token: 0x040001A3 RID: 419
	public int int_29 = 0;

	// Token: 0x040001A4 RID: 420
	public int int_30 = 0;

	// Token: 0x040001A5 RID: 421
	public int int_31 = 0;

	// Token: 0x040001A6 RID: 422
	public int int_32 = 0;

	// Token: 0x040001A7 RID: 423
	public bool bool_17 = false;

	// Token: 0x040001A8 RID: 424
	public bool bool_18 = false;

	// Token: 0x040001A9 RID: 425
	public int int_33 = 0;

	// Token: 0x040001AA RID: 426
	public int int_34 = 0;
}
