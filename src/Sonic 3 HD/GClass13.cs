using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02000023 RID: 35
public class GClass13 : GClass0
{
	// Token: 0x06000090 RID: 144 RVA: 0x000025C7 File Offset: 0x000007C7
	public override void vmethod_2()
	{
		GClass13.texture2D_1 = GClass25.gclass25_0.Content.Load<Texture2D>("objects/spikes");
	}

	// Token: 0x06000091 RID: 145 RVA: 0x0000258B File Offset: 0x0000078B
	public GClass13()
	{
		this.int_0 = 4;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x000025E2 File Offset: 0x000007E2
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		GClass0.texture2D_0 = GClass13.texture2D_1;
		base.method_1(vector2_1, float_1, -6.28318548f * (float)this.int_1 / (float)this.int_0);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x000056B8 File Offset: 0x000038B8
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (gclass22_0.vector2_0.X - 40f < this.vector2_0.X + (float)(GClass13.texture2D_1.Width / 2) && this.vector2_0.X - (float)(GClass13.texture2D_1.Width / 2) < gclass22_0.vector2_0.X + 40f)
		{
			if (gclass22_0.vector2_0.Y < this.vector2_0.Y - (float)(GClass13.texture2D_1.Height / 2) + 64f && gclass22_0.vector2_0.X - 32f < this.vector2_0.X + (float)(GClass13.texture2D_1.Width / 2) && this.vector2_0.X - (float)(GClass13.texture2D_1.Width / 2) < gclass22_0.vector2_0.X + 32f)
			{
				gclass22_0.int_21 = (int)(this.vector2_0.Y - gclass22_0.vector2_0.Y - (float)(GClass13.texture2D_1.Height / 2));
				gclass22_0.bool_14 = true;
				if (gclass22_0.int_21 < 2 && gclass22_0.vector2_1.Y > -0.1f)
				{
					gclass22_0.bool_16 = true;
					gclass22_0.method_21((int)this.vector2_0.X, (int)this.vector2_0.Y);
				}
			}
			else if (gclass22_0.vector2_0.Y - 8f >= this.vector2_0.Y - (float)(GClass13.texture2D_1.Height / 2) && gclass22_0.vector2_0.Y - 160f < this.vector2_0.Y + (float)(GClass13.texture2D_1.Height / 2))
			{
				float num = this.vector2_0.X + (float)(GClass13.texture2D_1.Width / 2) - gclass22_0.vector2_0.X;
				float num2 = this.vector2_0.X - (float)(GClass13.texture2D_1.Width / 2) - gclass22_0.vector2_0.X;
				if (gclass22_0.float_3 < 0f && num > -44f && num <= 0f)
				{
					gclass22_0.vector2_0.X = this.vector2_0.X + (float)(GClass13.texture2D_1.Width / 2) + 44f;
					gclass22_0.bool_12 = true;
					gclass22_0.float_11 = num;
					gclass22_0.float_12 = num2;
				}
				if (gclass22_0.float_3 > 0f && num2 < 44f && num2 >= 0f)
				{
					gclass22_0.vector2_0.X = this.vector2_0.X - (float)(GClass13.texture2D_1.Width / 2) - 44f;
					gclass22_0.bool_13 = true;
					gclass22_0.float_11 = num;
					gclass22_0.float_12 = num2;
				}
				if (gclass22_0.float_3 == 0f)
				{
					if (num > -44f && num <= 0f)
					{
						gclass22_0.vector2_0.X = this.vector2_0.X + (float)(GClass13.texture2D_1.Width / 2) + 44f;
					}
					if (num2 < 44f && num2 >= 0f)
					{
						gclass22_0.vector2_0.X = this.vector2_0.X - (float)(GClass13.texture2D_1.Width / 2) - 44f;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x04000046 RID: 70
	private static Texture2D texture2D_1;
}
