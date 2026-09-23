using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

// Token: 0x02000036 RID: 54
public class GClass29
{
	// Token: 0x060000F0 RID: 240 RVA: 0x0000A178 File Offset: 0x00008378
	public GClass29(GClass25 gclass25_1)
	{
		if (GClass25.stopwatch_0 == null)
		{
			GClass25.stopwatch_0 = new System.Diagnostics.Stopwatch();
		}
		
		if (GClass25.stopwatch_0.IsRunning)
		{
			GClass25.stopwatch_0.Stop();
		}
		GClass25.stopwatch_0.Restart();
		this.gclass25_0 = gclass25_1;
		this.texture2D_4 = this.gclass25_0.Content.Load<Texture2D>("misc/ramka");
		this.texture2D_14 = this.gclass25_0.Content.Load<Texture2D>("misc/zvezda");
		GClass29.texture2D_13 = this.gclass25_0.Content.Load<Texture2D>("misc/nadpisi/100");
		this.texture2D_5 = this.gclass25_0.Content.Load<Texture2D>("misc/nadpisi/score");
		this.texture2D_6 = this.gclass25_0.Content.Load<Texture2D>("misc/nadpisi/time");
		this.texture2D_7 = this.gclass25_0.Content.Load<Texture2D>("misc/nadpisi/rings");
		this.texture2D_8 = this.gclass25_0.Content.Load<Texture2D>("misc/nadpisi/tochki");
		this.texture2D_10 = this.gclass25_0.Content.Load<Texture2D>("misc/hud/common");
		this.texture2D_11 = new Texture2D[10];
		for (int i = 0; i < this.texture2D_11.Length; i++)
		{
			this.texture2D_11[i] = this.gclass25_0.Content.Load<Texture2D>("misc/hud/" + i);
		}
		this.texture2D_12 = new Texture2D[10];
		for (int i = 0; i < this.texture2D_12.Length; i++)
		{
			this.texture2D_12[i] = this.gclass25_0.Content.Load<Texture2D>("misc/nadpisi/" + i);
		}
		this.texture2D_20 = new Texture2D[11];
		this.texture2D_21 = new Texture2D[18];
		this.texture2D_22 = new Texture2D[12];
		this.texture2D_23 = new Texture2D[2];
		this.texture2D_24 = new Texture2D[4];
		this.texture2D_25 = new Texture2D[6];
		for (int i = 0; i < this.texture2D_25.Length; i++)
		{
			this.texture2D_25[i] = this.gclass25_0.Content.Load<Texture2D>("misc/shields/wKaiten" + i);
		}
		for (int i = 0; i < this.texture2D_20.Length; i++)
		{
			this.texture2D_20[i] = this.gclass25_0.Content.Load<Texture2D>("misc/shields/bubbleShield" + i);
		}
		for (int i = 0; i < this.texture2D_23.Length; i++)
		{
			this.texture2D_23[i] = this.gclass25_0.Content.Load<Texture2D>("misc/shields/bubbleAttack" + i);
		}
		for (int i = 0; i < this.texture2D_21.Length; i++)
		{
			this.texture2D_21[i] = this.gclass25_0.Content.Load<Texture2D>("misc/shields/fireShield" + i);
		}
		for (int i = 0; i < this.texture2D_24.Length; i++)
		{
			this.texture2D_24[i] = this.gclass25_0.Content.Load<Texture2D>("misc/shields/fireAttack" + i);
		}
		for (int i = 0; i < this.texture2D_22.Length; i++)
		{
			this.texture2D_22[i] = this.gclass25_0.Content.Load<Texture2D>("misc/shields/lightningShield" + i);
		}
		if (!GClass25.bool_1)
		{
		}
		this.texture2D_3 = this.gclass25_0.Content.Load<Texture2D>("misc/rozovo");
		GClass30.smethod_0();
		this.texture2D_15 = this.gclass25_0.Content.Load<Texture2D>("misc/titles/sonic3Ribbon");
		this.texture2D_16 = this.gclass25_0.Content.Load<Texture2D>("misc/titles/act1");
		this.texture2D_19 = this.gclass25_0.Content.Load<Texture2D>("misc/titles/zone");
		this.texture2D_18 = this.gclass25_0.Content.Load<Texture2D>("misc/titles/mushroomHill");
		this.method_0();
		GClass29.gclass0_0 = new GClass0[100];
		GClass29.gclass0_0[0] = new GClass1();
		GClass29.gclass0_0[1] = new GClass3();
		GClass29.gclass0_0[2] = new GClass4();
		GClass29.gclass0_0[3] = new GClass13();
		GClass29.gclass0_0[4] = new GClass11();
		GClass29.gclass0_0[5] = new GClass12();
		GClass29.gclass0_0[6] = new GClass5();
		GClass29.gclass0_0[7] = new GClass15();
		GClass29.gclass0_0[8] = new GClass14();
		GClass29.gclass0_0[9] = new GClass16();
		GClass29.gclass0_0[10] = new GClass17();
		GClass29.gclass0_0[11] = new GClass18();
		GClass29.gclass0_0[12] = new GClass19();
		GClass29.gclass0_0[13] = new GClass20();
		GClass29.gclass0_0[14] = new GClass21();
		GClass29.gclass0_0[15] = new GClass9();
		GClass29.gclass0_0[16] = new GClass10();
		GClass29.gclass0_0[17] = new GClass2();
		GClass29.gclass0_0[18] = new GClass6();
		GClass29.gclass0_0[19] = new GClass7();
		GClass29.gclass0_0[20] = new GClass8();
		for (int i = 0; i < GClass29.gclass0_0.Length; i++)
		{
			if (GClass29.gclass0_0[i] != null)
			{
				GClass29.gclass0_0[i].vmethod_2();
			}
		}
		this.gclass24_1 = new GClass24[12];
		this.gclass24_1[7] = new GClass24("MHZ1", 187);
		this.gclass24_1[11] = new GClass24("ES", 6);
		GClass29.gclass24_0 = this.gclass24_1[7];
		GClass29.spriteFont_0 = this.gclass25_0.Content.Load<SpriteFont>("misc/WinterFont1");
		GClass29.spriteFont_1 = this.gclass25_0.Content.Load<SpriteFont>("misc/creditsFont0");
		GClass29.spriteFont_2 = this.gclass25_0.Content.Load<SpriteFont>("misc/creditsFont1");
				if (GClass25.stopwatch_0.IsRunning)
		{
			GClass25.stopwatch_0.Stop();
			// Wiped desktop window title properties to prevent NullReferenceException on Android
			GClass25.string_0 = "Sonic 3 HD Mobile";
		}
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x0000A890 File Offset: 0x00008A90
	public void method_0()
	{
		this.vector2_0.X = (float)(this.int_4 * (this.int_2 - 1) + this.int_4 / 2);
		this.gclass22_0 = new GClass22[3];
		this.gclass22_0[0] = new GClass22("characters/Sonic");
		this.vector2_0.X = this.gclass22_0[0].vector2_0.X - (float)(this.gclass25_0.renderTarget2D_0.Width / 2);
		this.vector2_0.Y = this.gclass22_0[0].vector2_0.Y + 64f - 80f - (float)(this.gclass25_0.renderTarget2D_0.Height / 2);
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x0000A950 File Offset: 0x00008B50
	private void method_1()
	{
		if (this.gclass25_0.int_20 == 1)
		{
			GClass29.gclass24_0.method_6();
		}
		if (this.gclass25_0.int_21 == 1)
		{
			GClass29.gclass24_0.method_5();
		}
		if (this.gclass25_0.int_13 == 1)
		{
			this.int_2--;
		}
		if (this.gclass25_0.int_14 == 1)
		{
			this.int_2++;
		}
		if (this.gclass25_0.int_15 == 1)
		{
			this.int_3--;
		}
		if (this.gclass25_0.int_16 == 1)
		{
			this.int_3++;
		}
		if (this.int_2 < 0)
		{
			this.int_2 = 0;
		}
		if (this.int_2 > GClass29.gclass24_0.int_5 - 1)
		{
			this.int_2 = GClass29.gclass24_0.int_5 - 1;
		}
		if (this.int_3 < 0)
		{
			this.int_3 = 0;
		}
		if (this.int_3 > 127)
		{
			this.int_3 = 127;
		}
		if (this.gclass25_0.int_3 == 1)
		{
			GClass29.gclass24_0.int_2[this.int_3, this.int_2]++;
		}
		if (this.gclass25_0.int_2 == 1)
		{
			GClass29.gclass24_0.int_2[this.int_3, this.int_2]--;
		}
		if (GClass29.gclass24_0.int_2[this.int_3, this.int_2] < 0)
		{
			GClass29.gclass24_0.int_2[this.int_3, this.int_2] = GClass29.gclass24_0.int_1 - 1;
		}
		if (GClass29.gclass24_0.int_2[this.int_3, this.int_2] % 1000 >= GClass29.gclass24_0.int_1)
		{
			GClass29.gclass24_0.int_2[this.int_3, this.int_2] = 0;
		}
		if (this.gclass25_0.int_5 == 1)
		{
			this.bool_1 = !this.bool_1;
		}
		if (this.gclass25_0.int_6 == 1)
		{
			this.bool_2 = !this.bool_2;
		}
		if (this.gclass25_0.int_4 == 1)
		{
			this.bool_3 = !this.bool_3;
		}
		this.bool_4 = false;
		if (this.bool_3)
		{
			if (this.gclass25_0.int_13 == 1)
			{
				this.int_1--;
				if (this.int_1 < 0)
				{
					this.int_1 = 0;
				}
			}
			if (this.gclass25_0.int_14 == 1)
			{
				this.int_1++;
				if (this.int_1 > 20)
				{
					this.int_1 = 20;
				}
			}
		}
		if (this.bool_1)
		{
			if (this.gclass25_0.int_7 == 1)
			{
				GClass29.gclass24_0.int_2[this.int_3, this.int_2] = GClass29.gclass24_0.int_2[this.int_3, this.int_2] + 1000;
				if (GClass29.gclass24_0.int_2[this.int_3, this.int_2] / 1000 > GClass29.gclass24_0.texture2D_2.Length)
				{
					GClass29.gclass24_0.int_2[this.int_3, this.int_2] = GClass29.gclass24_0.int_2[this.int_3, this.int_2] % 1000;
				}
				//GClass29.gclass24_0.int_2[this.int_3, this.int_2];
			}
			if (this.gclass25_0.int_8 == 1)
			{
				GClass29.gclass24_0.int_2[this.int_3, this.int_2] = GClass29.gclass24_0.int_2[this.int_3, this.int_2] - 1000;
				if (GClass29.gclass24_0.int_2[this.int_3, this.int_2] < 0)
				{
					GClass29.gclass24_0.int_2[this.int_3, this.int_2] = GClass29.gclass24_0.int_2[this.int_3, this.int_2] + (1 + GClass29.gclass24_0.texture2D_2.Length) * 1000;
				}
				//GClass29.gclass24_0.int_2[this.int_3, this.int_2];
			}
			if (GClass29.gclass24_0.bool_0[GClass29.gclass24_0.int_2[this.int_3, this.int_2] % 1000])
			{
				if (this.gclass25_0.int_10 != 1)
				{
				}
				if (this.gclass25_0.int_11 == 1)
				{
					bool flag = false;
					int i = GClass29.gclass24_0.int_3[this.int_3, this.int_2] + 1;
					while (i < GClass29.gclass24_0.bool_0.Length)
					{
						if (!GClass29.gclass24_0.bool_0[i])
						{
							i++;
						}
						else
						{
							flag = true;
							GClass29.gclass24_0.int_3[this.int_3, this.int_2] = i;
							IL_5B0:
							if (!flag)
							{
								GClass29.gclass24_0.int_3[this.int_3, this.int_2] = 0;
								goto IL_5EE;
							}
							goto IL_5EE;
						}
					}
					goto IL_5B0;
				}
			}
			else
			{
				GClass29.gclass24_0.int_3[this.int_3, this.int_2] = 0;
			}
		}
		IL_5EE:
		if (this.int_5 >= 1)
		{
			this.int_8 = Mouse.GetState().X;
			this.int_9 = Mouse.GetState().Y;
			float num = (float)this.gclass25_0.renderTarget2D_0.Width / (float)this.gclass25_0.renderTarget2D_0.Height;
			int num2;
			int num3;
			if ((float)this.gclass25_0.Window.ClientBounds.Width > num * (float)this.gclass25_0.Window.ClientBounds.Height)
			{
				num2 = (int)((float)this.gclass25_0.Window.ClientBounds.Height * num);
				num3 = this.gclass25_0.Window.ClientBounds.Height;
			}
			else
			{
				num2 = this.gclass25_0.Window.ClientBounds.Width;
				num3 = (int)((float)this.gclass25_0.Window.ClientBounds.Width / num);
			}
			this.rectangle_0.X = (this.gclass25_0.Window.ClientBounds.Width - num2) / 2;
			this.rectangle_0.Y = (this.gclass25_0.Window.ClientBounds.Height - num3) / 2;
			this.rectangle_0.Width = num2;
			this.rectangle_0.Height = num3;
			this.int_8 = (int)((float)(this.int_8 - this.rectangle_0.X) * ((float)this.gclass25_0.renderTarget2D_0.Width / (float)this.rectangle_0.Width));
			this.int_9 = (int)((float)(this.int_9 - this.rectangle_0.Y) * ((float)this.gclass25_0.renderTarget2D_0.Height / (float)this.rectangle_0.Height));
			if (this.bool_1)
			{
				for (int i = 0; i < GClass29.gclass24_0.int_1; i++)
				{
					if (this.int_8 >= i % this.int_16 * this.int_4 / this.int_14 && this.int_8 < i % this.int_16 * this.int_4 / this.int_14 + this.int_4 / this.int_14 && this.int_9 >= i / this.int_16 * this.int_4 / this.int_14 && this.int_9 < i / this.int_16 * this.int_4 / this.int_14 + this.int_4 / this.int_14)
					{
						GClass29.gclass24_0.int_2[this.int_3, this.int_2] = i;
						this.bool_4 = true;
						break;
					}
				}
			}
			if (this.bool_3 && !this.bool_4)
			{
				for (int i = this.int_1; i < GClass29.gclass0_0.Length; i++)
				{
					if (GClass29.gclass0_0[i] != null && 640 + (i - this.int_1) * 2 * this.int_4 / this.int_14 <= this.int_8 && this.int_8 <= 640 + (i - this.int_1) * 2 * this.int_4 / this.int_14 + 2 * this.int_4 / this.int_14 && 800 <= this.int_9 && this.int_9 <= 800 + 2 * this.int_4 / this.int_14)
					{
						this.bool_4 = true;
						this.bool_5 = true;
						this.gclass0_1 = (GClass0)Activator.CreateInstance(GClass29.gclass0_0[i].GetType());
					}
				}
			}
			if (this.bool_2 && !this.bool_4)
			{
				int j = 0;
				IL_AC3:
				while (j < 128)
				{
					for (int i = 0; i < GClass29.gclass24_0.int_5; i++)
					{
						if (this.int_8 > i * this.int_4 / this.int_15 + this.int_16 * this.int_4 / this.int_14 && this.int_8 < i * this.int_4 / this.int_15 + this.int_16 * this.int_4 / this.int_14 + this.int_4 / this.int_15 && this.int_9 > j * this.int_4 / this.int_15 && this.int_9 < j * this.int_4 / this.int_15 + this.int_4 / this.int_15)
						{
							this.int_2 = i + this.int_0;
							this.int_3 = j;
							j = 200;
							IL_ABD:
							j++;
							goto IL_AC3;
						}
					}
					goto IL_ABD;
				}
			}
			this.int_8 = Mouse.GetState().X;
			this.int_9 = Mouse.GetState().Y;
		}
		if (this.bool_3 && this.bool_5)
		{
			this.int_8 = Mouse.GetState().X;
			this.int_9 = Mouse.GetState().Y;
			float num = (float)this.gclass25_0.renderTarget2D_0.Width / (float)this.gclass25_0.renderTarget2D_0.Height;
			int num2;
			int num3;
			if ((float)this.gclass25_0.Window.ClientBounds.Width > num * (float)this.gclass25_0.Window.ClientBounds.Height)
			{
				num2 = (int)((float)this.gclass25_0.Window.ClientBounds.Height * num);
				num3 = this.gclass25_0.Window.ClientBounds.Height;
			}
			else
			{
				num2 = this.gclass25_0.Window.ClientBounds.Width;
				num3 = (int)((float)this.gclass25_0.Window.ClientBounds.Width / num);
			}
			this.rectangle_0.X = (this.gclass25_0.Window.ClientBounds.Width - num2) / 2;
			this.rectangle_0.Y = (this.gclass25_0.Window.ClientBounds.Height - num3) / 2;
			this.rectangle_0.Width = num2;
			this.rectangle_0.Height = num3;
			this.int_8 = (int)((float)(this.int_8 - this.rectangle_0.X) * ((float)this.gclass25_0.renderTarget2D_0.Width / (float)this.rectangle_0.Width));
			this.int_9 = (int)((float)(this.int_9 - this.rectangle_0.Y) * ((float)this.gclass25_0.renderTarget2D_0.Height / (float)this.rectangle_0.Height));
			this.gclass0_1.vector2_0 = new Vector2((float)(this.int_8 - (int)((float)this.int_8 + this.vector2_0.X) % 4), (float)(this.int_9 - (int)((float)this.int_9 + this.vector2_0.Y) % 4));
			if (this.gclass25_0.int_7 == 1)
			{
				this.gclass0_1.int_1++;
				this.gclass25_0.Window.Title = "blaa";
			}
			if (this.gclass25_0.int_8 == 1)
			{
				this.gclass0_1.int_1--;
				this.gclass25_0.Window.Title = "blaa2";
			}
			if (this.gclass0_1.int_1 < 0)
			{
				this.gclass0_1.int_1 = this.gclass0_1.int_0 - 1;
			}
			if (this.gclass0_1.int_1 > this.gclass0_1.int_0 - 1)
			{
				this.gclass0_1.int_1 = 0;
			}
			if (this.int_5 == 1 && !this.bool_4)
			{
				for (int i = 0; i < GClass29.gclass24_0.gclass0_0.Length; i++)
				{
					if (GClass29.gclass24_0.gclass0_0[i] == null)
					{
						GClass29.gclass24_0.gclass0_0[i] = this.gclass0_1;
						GClass29.gclass24_0.gclass0_0[i].vector2_0 += this.vector2_0;
						this.gclass0_1 = (GClass0)Activator.CreateInstance(this.gclass0_1.GetType());
						this.gclass0_1.vector2_0.X = (float)(this.int_8 - (int)((float)this.int_8 + this.vector2_0.X) % 4);
						this.gclass0_1.vector2_0.Y = (float)(this.int_9 - (int)((float)this.int_9 + this.vector2_0.Y) % 4);
						break;
					}
				}
			}
			if (this.int_6 == 1 && !this.bool_4)
			{
				int num4 = -1;
				float num5 = 150f;
				Vector2 vector = new Vector2((float)(this.int_8 - (int)((float)this.int_8 + this.vector2_0.X) % 4), (float)(this.int_9 - (int)((float)this.int_9 + this.vector2_0.Y) % 4)) + this.vector2_0;
				for (int i = 0; i < GClass29.gclass24_0.gclass0_0.Length; i++)
				{
					if (GClass29.gclass24_0.gclass0_0[i] != null && Vector2.Distance(GClass29.gclass24_0.gclass0_0[i].vector2_0, vector) < num5)
					{
						num5 = Vector2.Distance(GClass29.gclass24_0.gclass0_0[i].vector2_0, vector);
						num4 = i;
					}
				}
				if (num4 != -1)
				{
					GClass29.gclass24_0.gclass0_0[num4] = null;
				}
			}
			this.int_8 = Mouse.GetState().X;
			this.int_9 = Mouse.GetState().Y;
		}
		if (!this.bool_2 && this.int_5 >= 1)
		{
			this.int_8 = Mouse.GetState().X;
			this.int_9 = Mouse.GetState().Y;
			float num = (float)this.gclass25_0.renderTarget2D_0.Width / (float)this.gclass25_0.renderTarget2D_0.Height;
			int num2;
			int num3;
			if ((float)this.gclass25_0.Window.ClientBounds.Width > num * (float)this.gclass25_0.Window.ClientBounds.Height)
			{
				num2 = (int)((float)this.gclass25_0.Window.ClientBounds.Height * num);
				num3 = this.gclass25_0.Window.ClientBounds.Height;
			}
			else
			{
				num2 = this.gclass25_0.Window.ClientBounds.Width;
				num3 = (int)((float)this.gclass25_0.Window.ClientBounds.Width / num);
			}
			this.rectangle_0.X = (this.gclass25_0.Window.ClientBounds.Width - num2) / 2;
			this.rectangle_0.Y = (this.gclass25_0.Window.ClientBounds.Height - num3) / 2;
			this.rectangle_0.Width = num2;
			this.rectangle_0.Height = num3;
			this.int_8 = (int)((float)(this.int_8 - this.rectangle_0.X) * ((float)this.gclass25_0.renderTarget2D_0.Width / (float)this.rectangle_0.Width));
			this.int_9 = (int)((float)(this.int_9 - this.rectangle_0.Y) * ((float)this.gclass25_0.renderTarget2D_0.Height / (float)this.rectangle_0.Height));
			this.rectangle_0.X = (int)(this.vector2_0.X / (float)this.int_4);
			if (this.rectangle_0.X < 0)
			{
				this.rectangle_0.X = 0;
			}
			this.rectangle_0.Y = (int)(this.vector2_0.Y / (float)this.int_4);
			if (this.rectangle_0.Y < 0)
			{
				this.rectangle_0.Y = 0;
			}
			this.rectangle_0.Width = 5;
			this.rectangle_0.Height = 3;
			if (!this.bool_4)
			{
				int j = this.rectangle_0.Y;
				IL_134F:
				while (j < this.rectangle_0.Height + this.rectangle_0.Y)
				{
					for (int i = this.rectangle_0.X; i < this.rectangle_0.Width + this.rectangle_0.X; i++)
					{
						Vector2 vector2;
						vector2.X = (float)(i * this.int_4) - this.vector2_0.X;
						vector2.Y = (float)(j * this.int_4) - this.vector2_0.Y;
						if ((float)this.int_8 > vector2.X && (float)this.int_8 < vector2.X + (float)this.int_4 && (float)this.int_9 > vector2.Y && (float)this.int_9 < vector2.Y + (float)this.int_4)
						{
							this.int_2 = i;
							this.int_3 = j;
							IL_1349:
							j++;
							goto IL_134F;
						}
					}
					goto IL_1349;
				}
			}
			this.int_8 = Mouse.GetState().X;
			this.int_9 = Mouse.GetState().Y;
		}
		if (this.int_7 > 2)
		{
			Vector2 zero = Vector2.Zero;
			float num = (float)this.gclass25_0.renderTarget2D_0.Width / (float)this.gclass25_0.renderTarget2D_0.Height;
			int num2;
			int num3;
			if ((float)this.gclass25_0.Window.ClientBounds.Width > num * (float)this.gclass25_0.Window.ClientBounds.Height)
			{
				num2 = (int)((float)this.gclass25_0.Window.ClientBounds.Height * num);
				num3 = this.gclass25_0.Window.ClientBounds.Height;
			}
			else
			{
				num2 = this.gclass25_0.Window.ClientBounds.Width;
				num3 = (int)((float)this.gclass25_0.Window.ClientBounds.Width / num);
			}
			this.rectangle_0.X = (this.gclass25_0.Window.ClientBounds.Width - num2) / 2;
			this.rectangle_0.Y = (this.gclass25_0.Window.ClientBounds.Height - num3) / 2;
			this.rectangle_0.Width = num2;
			this.rectangle_0.Height = num3;
			zero.X = (float)(this.int_8 - this.rectangle_0.X) * ((float)this.gclass25_0.renderTarget2D_0.Width / (float)this.rectangle_0.Width) - (float)(this.int_10 - this.rectangle_0.X) * ((float)this.gclass25_0.renderTarget2D_0.Width / (float)this.rectangle_0.Width);
			zero.Y = (float)(this.int_9 - this.rectangle_0.Y) * ((float)this.gclass25_0.renderTarget2D_0.Height / (float)this.rectangle_0.Height) - (float)(this.int_11 - this.rectangle_0.Y) * ((float)this.gclass25_0.renderTarget2D_0.Height / (float)this.rectangle_0.Height);
			if (this.bool_2)
			{
				this.float_0 -= zero.X;
				this.float_1 += zero.Y;
				if (this.float_0 > (float)(this.int_4 / this.int_15))
				{
					this.float_0 -= (float)(this.int_4 / this.int_15);
					this.int_0++;
				}
				if (this.float_0 < (float)(-(float)this.int_4 / this.int_15))
				{
					this.float_0 += (float)(this.int_4 / this.int_15);
					this.int_0--;
				}
				if (this.int_0 < 0)
				{
					this.int_0 = 0;
				}
				if (this.int_0 > 120)
				{
					this.int_0 = 120;
				}
			}
			else
			{
				this.vector2_0 -= zero;
				if (this.vector2_0.X < 0f)
				{
					this.vector2_0.X = 0f;
				}
				if (this.vector2_0.Y < 0f)
				{
					this.vector2_0.Y = 0f;
				}
			}
		}
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0000C04C File Offset: 0x0000A24C
	public void method_2()
	{
		this.method_4();
		MouseState state = Mouse.GetState();
		if (state.LeftButton == ButtonState.Pressed)
		{
			this.int_5++;
		}
		else
		{
			this.int_5 = 0;
		}
		if (state.RightButton == ButtonState.Pressed)
		{
			this.int_6++;
		}
		else
		{
			this.int_6 = 0;
		}
		if (state.MiddleButton == ButtonState.Pressed)
		{
			this.int_7++;
		}
		else
		{
			this.int_7 = 0;
		}
		this.int_10 = this.int_8;
		this.int_11 = this.int_9;
		this.int_8 = Mouse.GetState().X;
		this.int_9 = Mouse.GetState().Y;
		if (this.gclass25_0.int_0 == 1)
		{
			this.bool_0 = !this.bool_0;
			if (GClass25.bool_1)
			{
				GClass25.gclass25_0.IsMouseVisible = this.bool_0;
			}
		}
		this.int_13 = this.int_12;
		this.int_12 = Mouse.GetState().ScrollWheelValue;
		if (this.gclass25_0.int_12 == 1)
		{
			this.bool_5 = false;
			this.gclass0_1 = null;
		}
		this.bool_4 = false;
		if (this.bool_0)
		{
			if (GClass25.bool_1)
			{
				this.method_1();
			}
		}
		else
		{
			for (int i = 0; i < this.gclass22_0.Length; i++)
			{
				if (this.gclass22_0[i] != null)
				{
					this.gclass22_0[i].Update();
					for (int j = 0; j < GClass29.gclass24_0.gclass0_0.Length; j++)
					{
						GClass0 gclass = GClass29.gclass24_0.gclass0_0[j];
						if (gclass != null)
						{
							gclass.vmethod_0(this.gclass22_0[i]);
						}
					}
				}
			}
			for (int i = 0; i < GClass29.gclass24_0.gclass0_0.Length; i++)
			{
				GClass0 gclass = GClass29.gclass24_0.gclass0_0[i];
				if (gclass != null)
				{
					gclass.Update();
				}
			}
			float num = this.vector2_0.X + (float)(this.gclass25_0.renderTarget2D_0.Width / 2);
			if (this.gclass22_0[0].vector2_0.X > num)
			{
				if (this.gclass22_0[0].vector2_0.X > num + 64f)
				{
					this.vector2_0.X = this.vector2_0.X + 64f;
				}
				else
				{
					this.vector2_0.X = this.vector2_0.X + (this.gclass22_0[0].vector2_0.X - num);
				}
			}
			else if (this.gclass22_0[0].vector2_0.X < num - 64f)
			{
				if (this.gclass22_0[0].vector2_0.X < num - 128f)
				{
					this.vector2_0.X = this.vector2_0.X - 64f;
				}
				else
				{
					this.vector2_0.X = this.gclass22_0[0].vector2_0.X - (float)(this.gclass25_0.renderTarget2D_0.Width / 2) + 64f;
				}
			}
			float num2 = this.vector2_0.Y + (float)(this.gclass25_0.renderTarget2D_0.Height / 2);
			int num3 = 0;
			int num4 = (int)this.gclass22_0[0].vector2_0.Y - 80;
			if (this.gclass22_0[0].int_22 > 120)
			{
				if (this.gclass22_0[0].genum4_0 == (GEnum4)4)
				{
					if (this.gclass22_0[0].int_22 > 164 + num3)
					{
						this.vector2_0.Y = (float)(num4 + 64 + (44 + num3) * 2 * 4 - this.gclass25_0.renderTarget2D_0.Height / 2);
					}
					else
					{
						this.vector2_0.Y = (float)(num4 + 64 + (this.gclass22_0[0].int_22 - 120) * 2 * 4 - this.gclass25_0.renderTarget2D_0.Height / 2);
					}
				}
				if (this.gclass22_0[0].genum4_0 == (GEnum4)7)
				{
					if (this.gclass22_0[0].int_22 > 120 + (52 + 2 * num3))
					{
						this.vector2_0.Y = (float)(num4 + 64 - (52 + 2 * num3) * 2 * 4 - this.gclass25_0.renderTarget2D_0.Height / 2);
					}
					else
					{
						this.vector2_0.Y = (float)(num4 + 64 - (this.gclass22_0[0].int_22 - 120) * 2 * 4 - this.gclass25_0.renderTarget2D_0.Height / 2);
					}
				}
			}
			else if (this.gclass22_0[0].bool_10)
			{
				if (Math.Abs(this.gclass22_0[0].vector2_1.Y) > 48f)
				{
					if (num2 - 64f < (float)num4)
					{
						if (num2 - 64f + 64f < (float)num4)
						{
							this.vector2_0.Y = this.vector2_0.Y + 64f;
						}
						else
						{
							this.vector2_0.Y = (float)(num4 + 64 - this.gclass25_0.renderTarget2D_0.Height / 2);
						}
					}
					if (num2 - 64f > (float)num4)
					{
						if (num2 - 64f - 64f > (float)num4)
						{
							this.vector2_0.Y = this.vector2_0.Y - 64f;
						}
						else
						{
							this.vector2_0.Y = (float)(num4 + 64 - this.gclass25_0.renderTarget2D_0.Height / 2);
						}
					}
				}
				else
				{
					if (num2 - 64f < (float)num4)
					{
						if (num2 - 64f + 24f < (float)num4)
						{
							this.vector2_0.Y = this.vector2_0.Y + 24f;
						}
						else
						{
							this.vector2_0.Y = (float)(num4 + 64 - this.gclass25_0.renderTarget2D_0.Height / 2);
						}
					}
					if (num2 - 64f > (float)num4)
					{
						if (num2 - 64f - 24f > (float)num4)
						{
							this.vector2_0.Y = this.vector2_0.Y - 24f;
						}
						else
						{
							this.vector2_0.Y = (float)(num4 + 64 - this.gclass25_0.renderTarget2D_0.Height / 2);
						}
					}
				}
			}
			else if (num2 - 192f > (float)num4 || (float)num4 > num2 + 64f)
			{
				if (num2 - 192f > (float)num4)
				{
					if (num2 - 192f - 64f > (float)num4)
					{
						this.vector2_0.Y = this.vector2_0.Y - 64f;
					}
					else
					{
						this.vector2_0.Y = (float)(num4 + 192 - this.gclass25_0.renderTarget2D_0.Height / 2);
					}
				}
				else if (num2 + 64f + 64f < (float)num4)
				{
					this.vector2_0.Y = this.vector2_0.Y + 64f;
				}
				else
				{
					this.vector2_0.Y = (float)(num4 - 64 - this.gclass25_0.renderTarget2D_0.Height / 2);
				}
			}
			if (!this.bool_0)
			{
				string string_ = GClass29.gclass24_0.string_0;
				if (string_ != null)
				{
					if (!(string_ == "MHZ1"))
					{
						if (string_ == "ES")
						{
							if (this.vector2_0.X < 0f)
							{
								this.vector2_0.X = 0f;
							}
							if (this.vector2_0.X > (float)(2 * this.int_4 + 128 - 24))
							{
								this.vector2_0.X = (float)(2 * this.int_4 + 128 - 24);
							}
							this.vector2_0.Y = 10344f;
						}
					}
					else
					{
						if (this.vector2_0.X < 6404f)
						{
							this.vector2_0.X = 6404f;
						}
						if (this.vector2_0.X > (float)(132 * this.int_4 + 180))
						{
							this.vector2_0.X = (float)(132 * this.int_4 + 180);
						}
					}
				}
			}
			this.vector2_0.X = (float)((int)this.vector2_0.X);
			this.vector2_0.Y = (float)((int)this.vector2_0.Y);
			if (this.gclass22_0[0].vector2_0.Y > (float)(22 * this.int_4))
			{
				GClass29.gclass24_0.method_0();
				this.gclass22_0[0].method_28();
			}
			if (GClass29.gclass24_0.string_0 != "ES")
			{
				GClass29.float_4 += 0.0166666675f;
			}
			this.int_17++;
			if (this.int_17 > 15)
			{
				this.int_17 = 0;
			}
		}
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
	public void method_3()
	{
		string string_ = GClass29.gclass24_0.string_0;
		if (string_ != null)
		{
			if (!(string_ == "MHZ1"))
			{
				if (string_ == "ES")
				{
					this.vector2_1.X = -2.1f * this.vector2_0.X * this.float_2;
					this.vector2_1.Y = -this.vector2_0.Y * this.float_3 * 8f + 800f;
				}
			}
			else
			{
				this.vector2_1.X = -this.vector2_0.X * this.float_2;
				this.vector2_1.Y = -this.vector2_0.Y * this.float_3 * 8f - 100f;
			}
		}
		this.gclass25_0.spriteBatch_0.Begin();
		if ((this.bool_0 && !this.bool_2) || !this.bool_0)
		{
			this.gclass25_0.spriteBatch_0.Draw(GClass29.gclass24_0.texture2D_1, this.vector2_1, GClass29.color_0);
			this.vector2_1.X = this.vector2_1.X + (float)GClass29.gclass24_0.texture2D_1.Width;
			this.gclass25_0.spriteBatch_0.Draw(GClass29.gclass24_0.texture2D_1, this.vector2_1, GClass29.color_0);
			this.vector2_1.X = this.vector2_1.X + (float)GClass29.gclass24_0.texture2D_1.Width;
			this.gclass25_0.spriteBatch_0.Draw(GClass29.gclass24_0.texture2D_1, this.vector2_1, GClass29.color_0);
			this.vector2_1.X = this.vector2_1.X + (float)GClass29.gclass24_0.texture2D_1.Width;
			this.gclass25_0.spriteBatch_0.Draw(GClass29.gclass24_0.texture2D_1, this.vector2_1, GClass29.color_0);
			this.vector2_1.X = -this.vector2_0.X;
			this.vector2_1.Y = -this.vector2_0.Y;
		}
		this.rectangle_0.X = (int)(this.vector2_0.X / (float)this.int_4);
		if (this.rectangle_0.X < 0)
		{
			this.rectangle_0.X = 0;
		}
		this.rectangle_0.Y = (int)(this.vector2_0.Y / (float)this.int_4);
		if (this.rectangle_0.Y < 0)
		{
			this.rectangle_0.Y = 0;
		}
		this.rectangle_0.Width = 5;
		this.rectangle_0.Height = 4;
		Vector2 zero = Vector2.Zero;
		if ((this.bool_0 && !this.bool_2) || !this.bool_0)
		{
			for (int i = this.rectangle_0.Y; i < this.rectangle_0.Height + this.rectangle_0.Y; i++)
			{
				for (int j = this.rectangle_0.X; j < this.rectangle_0.Width + this.rectangle_0.X; j++)
				{
					if (GClass29.gclass24_0.int_2[i, j] / 1000 != 0)
					{
						zero.X = (float)(j * this.int_4) - this.vector2_0.X;
						zero.Y = (float)(i * this.int_4) - this.vector2_0.Y;
						this.gclass25_0.spriteBatch_0.Draw(GClass29.gclass24_0.texture2D_2[GClass29.gclass24_0.int_2[i, j] / 1000 - 1], zero, GClass29.color_0);
					}
				}
			}
			for (int i = this.rectangle_0.Y; i < this.rectangle_0.Height + this.rectangle_0.Y; i++)
			{
				for (int j = this.rectangle_0.X; j < this.rectangle_0.Width + this.rectangle_0.X; j++)
				{
					if (GClass29.gclass24_0.int_3[i, j] != 0)
					{
						zero.X = (float)(j * this.int_4) - this.vector2_0.X;
						zero.Y = (float)(i * this.int_4) - this.vector2_0.Y;
						int num = GClass29.gclass24_0.int_3[i, j];
						this.gclass25_0.spriteBatch_0.Draw(GClass29.gclass24_0.texture2D_0[num], zero, GClass29.color_0);
					}
				}
			}
			for (int j = 0; j < GClass29.gclass24_0.gclass0_0.Length; j++)
			{
				GClass0 gclass = GClass29.gclass24_0.gclass0_0[j];
				if (gclass != null && (gclass.bool_1 || !gclass.bool_2))
				{
					gclass.vmethod_3(GClass29.gclass24_0.gclass0_0[j].vector2_0 - this.vector2_0, 1f);
				}
			}
			for (int j = 0; j < this.gclass22_0.Length; j++)
			{
				GClass0 gclass = this.gclass22_0[j];
				if (gclass != null)
				{
					gclass.vmethod_1();
				}
			}
			for (int i = this.rectangle_0.Y; i < this.rectangle_0.Height + this.rectangle_0.Y; i++)
			{
				for (int j = this.rectangle_0.X; j < this.rectangle_0.Width + this.rectangle_0.X; j++)
				{
					if (GClass29.gclass24_0.int_2[i, j] % 1000 != 0)
					{
						zero.X = (float)(j * this.int_4) - this.vector2_0.X;
						zero.Y = (float)(i * this.int_4) - this.vector2_0.Y;
						int num2 = GClass29.gclass24_0.int_2[i, j];
						this.gclass25_0.spriteBatch_0.Draw(GClass29.gclass24_0.texture2D_0[num2 % 1000], zero + new Vector2(0f, (float)(this.int_4 - GClass29.gclass24_0.texture2D_0[num2 % 1000].Height)), GClass29.color_0);
					}
				}
			}
			for (int j = 0; j < GClass29.gclass24_0.gclass0_0.Length; j++)
			{
				GClass0 gclass = GClass29.gclass24_0.gclass0_0[j];
				if (gclass != null && gclass.bool_2)
				{
					gclass.vmethod_4(GClass29.gclass24_0.gclass0_0[j].vector2_0 - this.vector2_0, 1f);
				}
			}
			if (this.gclass22_0[0].genum4_0 == (GEnum4)12)
			{
				this.gclass22_0[0].vmethod_1();
			}
			bool flag = true;
			if (GClass29.gclass24_0.string_0 == "ES")
			{
				flag = false;
			}
			if (flag)
			{
				this.gclass25_0.spriteBatch_0.Draw(this.texture2D_5, new Vector2(64f, 36f), GClass29.color_0);
				int num3 = 64 + this.texture2D_5.Width - 8 + 6 * this.texture2D_12[0].Width;
				int num4 = this.gclass22_0[0].int_19;
				if (Math.Ceiling(Math.Log10((double)num4)) > 6.0)
				{
					num3 = 64 + this.texture2D_5.Width - 8 + (int)Math.Ceiling(Math.Log10((double)num4)) * this.texture2D_12[0].Width;
				}
				int j = 0;
				Texture2D texture2D;
				while (j < 8 && (num4 != 0 || j == 0))
				{
					texture2D = this.texture2D_12[num4 % 10];
					num4 /= 10;
					this.gclass25_0.spriteBatch_0.Draw(texture2D, new Vector2((float)(num3 - j * texture2D.Width), 36f), GClass29.color_0);
					j++;
				}
				if (this.gclass22_0[0].int_17 != 0 || this.int_17 <= 7)
				{
					this.gclass25_0.spriteBatch_0.Draw(this.texture2D_7, new Vector2(64f, 164f), GClass29.color_0);
				}
				num4 = this.gclass22_0[0].int_17;
				if (Math.Ceiling(Math.Log10((double)num4)) > 3.0)
				{
					num3 = 64 + this.texture2D_7.Width + (int)Math.Ceiling(Math.Log10((double)num4)) * this.texture2D_12[0].Width;
				}
				else
				{
					num3 = 64 + this.texture2D_7.Width + 3 * this.texture2D_12[0].Width;
				}
				j = 0;
				while (j < 6 && (num4 != 0 || j == 0))
				{
					texture2D = this.texture2D_12[num4 % 10];
					num4 /= 10;
					this.gclass25_0.spriteBatch_0.Draw(texture2D, new Vector2((float)(num3 - j * texture2D.Width), 164f), GClass29.color_0);
					j++;
				}
				int num5 = (int)GClass29.float_4;
				int num6 = num5 / 60;
				int num7 = (int)(GClass29.float_4 * 100f) % 100;
				if (num6 < 9 || this.int_17 <= 7)
				{
					this.gclass25_0.spriteBatch_0.Draw(this.texture2D_6, new Vector2(64f, 100f), GClass29.color_0);
				}
				if (num6 >= 10)
				{
					if (this.gclass22_0[0].genum4_0 != (GEnum4)12)
					{
						this.gclass22_0[0].genum4_0 = (GEnum4)12;
						this.gclass22_0[0].vector2_1.Y = -28f;
					}
					num5 = 599;
					num6 = 9;
					num7 = 99;
				}
				texture2D = this.texture2D_12[num6 % 10];
				num3 = 64 + this.texture2D_6.Width + texture2D.Width;
				this.gclass25_0.spriteBatch_0.Draw(texture2D, new Vector2((float)num3, 100f), GClass29.color_0);
				num3 += texture2D.Width;
				this.gclass25_0.spriteBatch_0.Draw(this.texture2D_8, new Vector2((float)num3, 100f), GClass29.color_0);
				num3 += texture2D.Width;
				texture2D = this.texture2D_12[num5 % 60 / 10];
				this.gclass25_0.spriteBatch_0.Draw(texture2D, new Vector2((float)num3, 100f), GClass29.color_0);
				num3 += texture2D.Width;
				texture2D = this.texture2D_12[num5 % 10];
				this.gclass25_0.spriteBatch_0.Draw(texture2D, new Vector2((float)num3, 100f), GClass29.color_0);
				num3 += texture2D.Width;
				this.gclass25_0.spriteBatch_0.Draw(this.texture2D_8, new Vector2((float)num3, 100f), GClass29.color_0);
				num3 += texture2D.Width;
				texture2D = this.texture2D_12[num7 / 10];
				this.gclass25_0.spriteBatch_0.Draw(texture2D, new Vector2((float)num3, 100f), GClass29.color_0);
				num3 += texture2D.Width;
				texture2D = this.texture2D_12[num7 % 10];
				this.gclass25_0.spriteBatch_0.Draw(texture2D, new Vector2((float)num3, 100f), GClass29.color_0);
				this.gclass25_0.spriteBatch_0.Draw(this.texture2D_10, new Vector2(0f, (float)(this.gclass25_0.renderTarget2D_0.Height - 100)), GClass29.color_0);
				if (this.gclass22_0[0].int_18 >= 0)
				{
					this.gclass25_0.spriteBatch_0.Draw(this.texture2D_11[this.gclass22_0[0].int_18 % 10], new Vector2(0f, (float)(this.gclass25_0.renderTarget2D_0.Height - 100)), GClass29.color_0);
				}
			}
		}
		if (this.bool_0)
		{
			if (this.bool_2)
			{
				this.gclass25_0.GraphicsDevice.Clear(Color.Black);
			}
			if (this.bool_1)
			{
				this.gclass25_0.spriteBatch_0.End();
				this.gclass25_0.spriteBatch_0.Begin((SpriteSortMode)1, BlendState.Opaque);
				for (int j = 0; j < GClass29.gclass24_0.int_1; j++)
				{
					this.gclass25_0.spriteBatch_0.Draw(GClass29.gclass24_0.texture2D_0[j], new Rectangle(j % this.int_16 * this.int_4 / this.int_14, j / this.int_16 * this.int_4 / this.int_14, this.int_4 / this.int_14, this.int_4 / this.int_14), Color.White);
				}
				this.gclass25_0.spriteBatch_0.End();
				this.gclass25_0.spriteBatch_0.Begin();
				for (int j = 0; j < GClass29.gclass24_0.int_1; j++)
				{
					this.gclass25_0.spriteBatch_0.Draw(this.texture2D_4, new Rectangle(j % this.int_16 * this.int_4 / this.int_14, j / this.int_16 * this.int_4 / this.int_14, this.int_4 / this.int_14, this.int_4 / this.int_14), Color.White);
				}
				this.gclass25_0.spriteBatch_0.Draw(this.texture2D_4, new Rectangle(GClass29.gclass24_0.int_2[this.int_3, this.int_2] % this.int_16 * this.int_4 / this.int_14, GClass29.gclass24_0.int_2[this.int_3, this.int_2] / this.int_16 * this.int_4 / this.int_14, this.int_4 / this.int_14, this.int_4 / this.int_14), Color.Red);
			}
			if (this.bool_3)
			{
				if (this.int_1 < 0)
				{
					this.int_1 = 0;
				}
				this.gclass25_0.spriteBatch_0.End();
				this.gclass25_0.spriteBatch_0.Begin();
				for (int j = this.int_1; j < GClass29.gclass0_0.Length; j++)
				{
					if (GClass29.gclass0_0[j] != null)
					{
						GClass29.gclass0_0[j].vmethod_3(new Vector2((float)(704 + 128 * (j - this.int_1)), 864f), 0.5f);
					}
				}
				this.gclass25_0.spriteBatch_0.End();
				this.gclass25_0.spriteBatch_0.Begin();
				for (int j = 0; j < 10; j++)
				{
					this.gclass25_0.spriteBatch_0.Draw(this.texture2D_4, new Rectangle(640 + j * 2 * this.int_4 / this.int_14, 800, 2 * this.int_4 / this.int_14, 2 * this.int_4 / this.int_14), Color.White);
				}
				if (this.bool_5)
				{
					this.gclass0_1.vmethod_3(this.gclass0_1.vector2_0, 1f);
				}
			}
			if (this.bool_2)
			{
				Color color = Color.Red;
				if (this.gclass25_0.keyboardState_0.IsKeyDown(80))
				{
					color = Color.White;
				}
				if (this.texture2D_0 != null)
				{
					this.gclass25_0.spriteBatch_0.Draw(this.texture2D_0, new Rectangle(0 / this.int_15 + this.int_16 * this.int_4 / this.int_14, 0 / this.int_15, this.texture2D_0.Width, this.texture2D_0.Height), new Rectangle?(new Rectangle(this.int_0 * 32, 0, this.texture2D_0.Width, this.texture2D_0.Height)), color);
				}
				for (int i = 0; i < 128; i++)
				{
					for (int j = 0; j < GClass29.gclass24_0.int_5; j++)
					{
						if (GClass29.gclass24_0.int_2[i, j] >= 1000 && j - this.int_0 >= 0)
						{
							int num2 = GClass29.gclass24_0.int_2[i, j] / 1000 - 1;
							this.gclass25_0.spriteBatch_0.Draw(GClass29.gclass24_0.texture2D_2[num2], new Rectangle((j - this.int_0) * this.int_4 / this.int_15 + this.int_16 * this.int_4 / this.int_14, i * this.int_4 / this.int_15, this.int_4 / this.int_15, this.int_4 / this.int_15), Color.White);
						}
					}
				}
				for (int i = 0; i < 128; i++)
				{
					for (int j = 0; j < GClass29.gclass24_0.int_5; j++)
					{
						if (GClass29.gclass24_0.int_3[i, j] != 0 && j - this.int_0 >= 0)
						{
							int num2 = GClass29.gclass24_0.int_3[i, j] % 1000;
							this.gclass25_0.spriteBatch_0.Draw(GClass29.gclass24_0.texture2D_0[num2], new Rectangle((j - this.int_0) * this.int_4 / this.int_15 + this.int_16 * this.int_4 / this.int_14, i * this.int_4 / this.int_15, this.int_4 / this.int_15, this.int_4 / this.int_15), Color.White);
						}
					}
				}
				for (int i = 0; i < 128; i++)
				{
					for (int j = 0; j < GClass29.gclass24_0.int_5; j++)
					{
						if (GClass29.gclass24_0.int_2[i, j] != 0 && j - this.int_0 >= 0)
						{
							int num2 = GClass29.gclass24_0.int_2[i, j] % 1000;
							this.gclass25_0.spriteBatch_0.Draw(GClass29.gclass24_0.texture2D_0[num2], new Rectangle((j - this.int_0) * this.int_4 / this.int_15 + this.int_16 * this.int_4 / this.int_14, i * this.int_4 / this.int_15, this.int_4 / this.int_15, this.int_4 / this.int_15), Color.White);
						}
					}
				}
				this.gclass25_0.spriteBatch_0.End();
				this.gclass25_0.spriteBatch_0.Begin();
				this.gclass25_0.spriteBatch_0.Draw(this.texture2D_4, new Rectangle((this.int_2 - this.int_0) * this.int_4 / this.int_15 + this.int_16 * this.int_4 / this.int_14, this.int_3 * this.int_4 / this.int_15, this.int_4 / this.int_15, this.int_4 / this.int_15), Color.White);
			}
			else if (this.bool_1)
			{
				this.gclass25_0.spriteBatch_0.Draw(this.texture2D_4, new Vector2((float)(this.int_2 * this.int_4), (float)(this.int_3 * this.int_4)) - this.vector2_0 - 0f * new Vector2((float)(this.int_4 / 2), (float)(this.int_4 / 2)), Color.White);
			}
		}
		this.gclass25_0.spriteBatch_0.End();
		if (MediaPlayer.State == 0)
		{
			MediaPlayer.Play(GClass29.song_0);
			MediaPlayer.IsRepeating = true;
		}
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x0000DEF4 File Offset: 0x0000C0F4
	private void method_4()
	{
		this.int_19--;
		if (this.int_19 < 0)
		{
			this.int_19 = 0;
		}
		if (this.int_19 > this.int_20)
		{
			MediaPlayer.Volume = 0f;
		}
		if (this.int_19 <= this.int_20)
		{
			MediaPlayer.Volume = GClass30.float_1 * (float)(this.int_20 - this.int_19) / (float)this.int_20;
		}
	}

	// Token: 0x040000B6 RID: 182
	public static GClass24 gclass24_0;

	// Token: 0x040000B7 RID: 183
	public GClass24[] gclass24_1;

	// Token: 0x040000B8 RID: 184
	public static GClass0[] gclass0_0;

	// Token: 0x040000B9 RID: 185
	public static Song song_0;

	// Token: 0x040000BA RID: 186
	public static Song song_1;

	// Token: 0x040000BB RID: 187
	public static Song song_2;

	// Token: 0x040000BC RID: 188
	public static Song song_3;

	// Token: 0x040000BD RID: 189
	public static Song song_4;

	// Token: 0x040000BE RID: 190
	public static Song song_5;

	// Token: 0x040000BF RID: 191
	public Texture2D texture2D_0;

	// Token: 0x040000C0 RID: 192
	public Texture2D texture2D_1;

	// Token: 0x040000C1 RID: 193
	public Texture2D texture2D_2;

	// Token: 0x040000C2 RID: 194
	public Texture2D texture2D_3;

	// Token: 0x040000C3 RID: 195
	private Texture2D texture2D_4;

	// Token: 0x040000C4 RID: 196
	private Texture2D texture2D_5;

	// Token: 0x040000C5 RID: 197
	private Texture2D texture2D_6;

	// Token: 0x040000C6 RID: 198
	private Texture2D texture2D_7;

	// Token: 0x040000C7 RID: 199
	private Texture2D texture2D_8;

	// Token: 0x040000C8 RID: 200
	private Texture2D texture2D_9;

	// Token: 0x040000C9 RID: 201
	private Texture2D texture2D_10;

	// Token: 0x040000CA RID: 202
	private Texture2D[] texture2D_11;

	// Token: 0x040000CB RID: 203
	private Texture[] texture_0;

	// Token: 0x040000CC RID: 204
	private Texture2D[] texture2D_12;

	// Token: 0x040000CD RID: 205
	public static Texture2D texture2D_13;

	// Token: 0x040000CE RID: 206
	public Texture2D texture2D_14;

	// Token: 0x040000CF RID: 207
	public Texture2D texture2D_15;

	// Token: 0x040000D0 RID: 208
	public Texture2D texture2D_16;

	// Token: 0x040000D1 RID: 209
	public Texture2D texture2D_17;

	// Token: 0x040000D2 RID: 210
	public Texture2D texture2D_18;

	// Token: 0x040000D3 RID: 211
	public Texture2D texture2D_19;

	// Token: 0x040000D4 RID: 212
	public Texture2D[] texture2D_20;

	// Token: 0x040000D5 RID: 213
	public Texture2D[] texture2D_21;

	// Token: 0x040000D6 RID: 214
	public Texture2D[] texture2D_22;

	// Token: 0x040000D7 RID: 215
	public Texture2D[] texture2D_23;

	// Token: 0x040000D8 RID: 216
	public Texture2D[] texture2D_24;

	// Token: 0x040000D9 RID: 217
	public Texture2D[] texture2D_25;

	// Token: 0x040000DA RID: 218
	public Vector2 vector2_0;

	// Token: 0x040000DB RID: 219
	private int int_0;

	// Token: 0x040000DC RID: 220
	private float float_0;

	// Token: 0x040000DD RID: 221
	private float float_1;

	// Token: 0x040000DE RID: 222
	private int int_1;

	// Token: 0x040000DF RID: 223
	private int int_2 = 2;

	// Token: 0x040000E0 RID: 224
	private int int_3 = 10;

	// Token: 0x040000E1 RID: 225
	private bool bool_0 = false;

	// Token: 0x040000E2 RID: 226
	private bool bool_1 = false;

	// Token: 0x040000E3 RID: 227
	private bool bool_2 = false;

	// Token: 0x040000E4 RID: 228
	private bool bool_3 = false;

	// Token: 0x040000E5 RID: 229
	public int int_4 = 512;

	// Token: 0x040000E6 RID: 230
	private int int_5;

	// Token: 0x040000E7 RID: 231
	private int int_6;

	// Token: 0x040000E8 RID: 232
	private int int_7;

	// Token: 0x040000E9 RID: 233
	private int int_8;

	// Token: 0x040000EA RID: 234
	private int int_9;

	// Token: 0x040000EB RID: 235
	private int int_10;

	// Token: 0x040000EC RID: 236
	private int int_11;

	// Token: 0x040000ED RID: 237
	private int int_12;

	// Token: 0x040000EE RID: 238
	private int int_13;

	// Token: 0x040000EF RID: 239
	private int int_14 = 8;

	// Token: 0x040000F0 RID: 240
	private int int_15 = 16;

	// Token: 0x040000F1 RID: 241
	private int int_16 = 10;

	// Token: 0x040000F2 RID: 242
	private bool bool_4 = false;

	// Token: 0x040000F3 RID: 243
	private Vector2 vector2_1;

	// Token: 0x040000F4 RID: 244
	private Rectangle rectangle_0 = default(Rectangle);

	// Token: 0x040000F5 RID: 245
	private float float_2 = 0.05f;

	// Token: 0x040000F6 RID: 246
	private float float_3 = 0.01f;

	// Token: 0x040000F7 RID: 247
	public GClass22[] gclass22_0;

	// Token: 0x040000F8 RID: 248
	private bool bool_5 = false;

	// Token: 0x040000F9 RID: 249
	private GClass0 gclass0_1;

	// Token: 0x040000FA RID: 250
	public static Color color_0 = Color.White;

	// Token: 0x040000FB RID: 251
	private int int_17 = 0;

	// Token: 0x040000FC RID: 252
	public static SpriteFont spriteFont_0;

	// Token: 0x040000FD RID: 253
	public static SpriteFont spriteFont_1;

	// Token: 0x040000FE RID: 254
	public static SpriteFont spriteFont_2;

	// Token: 0x040000FF RID: 255
	public GClass25 gclass25_0;

	// Token: 0x04000100 RID: 256
	public static float float_4 = 0f;

	// Token: 0x04000101 RID: 257
	public bool bool_6 = false;

	// Token: 0x04000102 RID: 258
	public int int_18 = 0;

	// Token: 0x04000103 RID: 259
	public int int_19 = 0;

	// Token: 0x04000104 RID: 260
	public int int_20 = 50;

	// Token: 0x04000105 RID: 261
	public static bool bool_7 = false;
}
