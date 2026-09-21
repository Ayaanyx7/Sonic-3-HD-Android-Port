using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

// Token: 0x02000019 RID: 25
public class GClass3 : GClass0
{
	// Token: 0x06000061 RID: 97 RVA: 0x00003568 File Offset: 0x00001768
	public override void vmethod_2()
	{
		GClass3.texture2D_1 = new Texture2D[10];
		GClass3.texture2D_1[0] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/tvRing");
		GClass3.texture2D_1[1] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/tvShoes");
		GClass3.texture2D_1[2] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/tvInvincibility");
		GClass3.texture2D_1[3] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/tvBubble");
		GClass3.texture2D_1[4] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/tvFire");
		GClass3.texture2D_1[5] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/tvLightning");
		GClass3.texture2D_1[6] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/tvRobotnik");
		GClass3.texture2D_1[7] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/tvSonic1UP");
		GClass3.texture2D_1[8] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/tvNoise");
		GClass3.texture2D_1[9] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/tvBroken");
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002341 File Offset: 0x00000541
	public GClass3()
	{
		this.int_0 = 8;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00003690 File Offset: 0x00001890
	public override void Update()
	{
		this.int_2++;
		if (this.int_2 > 13)
		{
			this.int_2 = 0;
		}
		if (this.bool_4)
		{
			this.int_3--;
			if (this.int_3 == 0)
			{
				switch (this.int_1)
				{
				case 0:
					this.gclass22_0.int_17 += 10;
					GClass30.soundEffect_16.Play(GClass30.float_0, 0f, 0f);
					GClass30.soundEffect_17.Play(GClass30.float_0, 0f, 0f);
					break;
				case 1:
					this.gclass22_0.method_24();
					MediaPlayer.Play(GClass29.song_1);
					MediaPlayer.IsRepeating = false;
					break;
				case 3:
					this.gclass22_0.genum1_0 = (GEnum1)2;
					GClass30.soundEffect_13.Play(GClass30.float_0, 0f, 0f);
					break;
				case 4:
					this.gclass22_0.genum1_0 = (GEnum1)1;
					GClass30.soundEffect_14.Play(GClass30.float_0, 0f, 0f);
					break;
				case 5:
					this.gclass22_0.genum1_0 = (GEnum1)3;
					GClass30.soundEffect_15.Play(GClass30.float_0, 0f, 0f);
					break;
				case 6:
					this.gclass22_0.method_21((int)this.vector2_0.X, (int)this.vector2_0.Y);
					break;
				case 7:
					this.gclass22_0.int_18++;
					GClass30.soundEffect_19.Play(GClass30.float_0, 0f, 0f);
					GClass26.gclass29_0.int_19 = GClass26.gclass29_0.int_20 + 180;
					break;
				}
			}
		}
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003878 File Offset: 0x00001A78
	public override bool vmethod_0(GClass22 gclass22_1)
	{
		bool result;
		if (this.bool_4)
		{
			result = false;
		}
		else
		{
			if (gclass22_1.vector2_0.Y - 80f - 60f < this.vector2_0.Y + 30f && this.vector2_0.Y - 30f < gclass22_1.vector2_0.Y - 80f + 40f)
			{
				if (gclass22_1.genum4_0 == (GEnum4)5 || gclass22_1.genum4_0 == (GEnum4)3)
				{
					if (gclass22_1.vector2_0.X - 48f < this.vector2_0.X + (float)(GClass3.texture2D_1[0].Width / 2) && this.vector2_0.X - (float)(GClass3.texture2D_1[0].Width / 2) < gclass22_1.vector2_0.X + 48f)
					{
						this.bool_4 = true;
						gclass22_1.int_4 = 0;
						GClass30.soundEffect_6.Play(GClass30.float_0, 0f, 0f);
						this.int_3 = 45;
						this.gclass22_0 = gclass22_1;
						gclass22_1.method_22((int)this.vector2_0.Y);
					}
				}
				else
				{
					float num = this.vector2_0.X + (float)(GClass3.texture2D_1[0].Width / 2) - gclass22_1.vector2_0.X;
					float num2 = this.vector2_0.X - (float)(GClass3.texture2D_1[0].Width / 2) - gclass22_1.vector2_0.X;
					if (gclass22_1.float_3 < 0f && num > -44f && num <= 0f)
					{
						gclass22_1.vector2_0.X = this.vector2_0.X + (float)(GClass3.texture2D_1[0].Width / 2) + 44f;
						gclass22_1.bool_12 = true;
						gclass22_1.float_11 = num;
						gclass22_1.float_12 = num2;
					}
					if (gclass22_1.float_3 > 0f && num2 < 44f && num2 >= 0f)
					{
						gclass22_1.vector2_0.X = this.vector2_0.X - (float)(GClass3.texture2D_1[0].Width / 2) - 44f;
						gclass22_1.bool_13 = true;
						gclass22_1.float_11 = num;
						gclass22_1.float_12 = num2;
					}
					if (gclass22_1.float_3 == 0f && gclass22_1.genum4_0 == (GEnum4)9)
					{
						if (num > -44f && num <= 0f)
						{
							gclass22_1.vector2_0.X = this.vector2_0.X + (float)(GClass3.texture2D_1[0].Width / 2) + 44f;
						}
						if (num2 < 44f && num2 >= 0f)
						{
							gclass22_1.vector2_0.X = this.vector2_0.X - (float)(GClass3.texture2D_1[0].Width / 2) - 44f;
						}
					}
				}
			}
			result = false;
		}
		return result;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00003B90 File Offset: 0x00001D90
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		if (!this.bool_3)
		{
			if (!this.bool_4)
			{
				GClass0.texture2D_0 = GClass3.texture2D_1[this.int_1];
				base.method_0(vector2_1, float_1);
				if (this.int_2 == 1 || this.int_2 == 2 || this.int_2 == 9 || this.int_2 == 8)
				{
					GClass0.texture2D_0 = GClass3.texture2D_1[8];
					GClass25.gclass25_0.spriteBatch_0.End();
					GClass25.gclass25_0.spriteBatch_0.Begin(0, BlendState.Additive);
					base.method_0(vector2_1, float_1);
					GClass25.gclass25_0.spriteBatch_0.End();
					GClass25.gclass25_0.spriteBatch_0.Begin();
				}
			}
			else
			{
				GClass0.texture2D_0 = GClass3.texture2D_1[9];
				base.method_0(vector2_1, float_1);
				if (this.int_3 > 0)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass3.texture2D_1[this.int_1], new Rectangle((int)vector2_1.X - GClass0.texture2D_0.Width / 2 + 22, (int)vector2_1.Y - GClass0.texture2D_0.Height / 2 + 62 - 4 * (45 - this.int_3), 70, 60), new Rectangle?(new Rectangle(22, 12, 70, 60)), GClass29.color_0);
				}
				else if (this.int_3 > -50)
				{
					GClass25.gclass25_0.spriteBatch_0.Draw(GClass3.texture2D_1[this.int_1], new Rectangle((int)vector2_1.X - GClass0.texture2D_0.Width / 2 + 22, (int)vector2_1.Y - GClass0.texture2D_0.Height / 2 + 62 - 180, 70, 60), new Rectangle?(new Rectangle(22, 12, 70, 60)), GClass29.color_0);
				}
			}
		}
	}

	// Token: 0x04000027 RID: 39
	private static Texture2D[] texture2D_1;

	// Token: 0x04000028 RID: 40
	private int int_2 = 0;

	// Token: 0x04000029 RID: 41
	private bool bool_4 = false;

	// Token: 0x0400002A RID: 42
	private int int_3 = 0;

	// Token: 0x0400002B RID: 43
	private GClass22 gclass22_0 = null;
}
