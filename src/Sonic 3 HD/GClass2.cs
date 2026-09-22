using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

// Token: 0x02000018 RID: 24
public class GClass2 : GClass0
{
	// Token: 0x0600005C RID: 92 RVA: 0x000032C4 File Offset: 0x000014C4
	public override void vmethod_2()
	{
		GClass2.texture2D_1 = new Texture2D[10];
		for (int i = 0; i < GClass2.texture2D_1.Length; i++)
		{
			GClass2.texture2D_1[i] = GClass25.gclass25_0.Content.Load<Texture2D>("objects/giantRing" + i);
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x000022FA File Offset: 0x000004FA
	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		if (!this.bool_3)
		{
			GClass0.texture2D_0 = GClass2.texture2D_1[this.int_2 % 30 / 3];
			GClass0.spriteEffects_0 = 0;
			base.method_0(vector2_1, float_1);
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x0000232B File Offset: 0x0000052B
	public GClass2()
	{
		this.int_2 = 0;
		this.bool_4 = false;
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00003318 File Offset: 0x00001518
	public override void Update()
	{
		this.int_2++;
		if (this.bool_4 && this.int_2 == 20)
		{
			Class5.bool_0 = true;
		}
		if (this.bool_4 && this.int_2 == 100)
		{
			GClass30.soundEffect_26.Play(GClass30.float_0, 0f, 0f);
		}
		if (this.bool_4 && this.int_2 == 160)
		{
			GClass29.gclass24_0 = GClass26.gclass29_0.gclass24_1[11];
			GClass26.gclass29_0.gclass22_0[0].method_28();
			GClass26.gclass29_0.gclass22_0[0].vector2_0 = new Vector2(1284f, 11008f);
			GClass26.gclass29_0.gclass22_0[0].bool_17 = false;
			GClass26.gclass29_0.vector2_0 = new Vector2(616f, 10544f);
			MediaPlayer.Play(GClass29.song_3);
		}
		if (!this.bool_3)
		{
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00003428 File Offset: 0x00001628
	public override bool vmethod_0(GClass22 gclass22_0)
	{
		bool result;
		if (this.bool_3)
		{
			result = false;
		}
		else
		{
			if (gclass22_0.vector2_0.X - 20f < this.vector2_0.X + (float)(GClass2.texture2D_1[0].Width / 4) && this.vector2_0.X - (float)(GClass2.texture2D_1[0].Width / 4) < gclass22_0.vector2_0.X + 20f && gclass22_0.vector2_0.Y - 80f - 60f < this.vector2_0.Y + 30f && this.vector2_0.Y - 30f < gclass22_0.vector2_0.Y - 80f + 40f && gclass22_0.int_5 < 56 && gclass22_0.genum4_0 != (GEnum4)11)
			{
				this.bool_4 = true;
				GClass26.gclass29_0.gclass22_0[0].bool_17 = true;
				GClass30.soundEffect_27.Play(GClass30.float_0, 0f, 0f);
				this.int_2 = 0;
				this.bool_3 = true;
			}
			result = false;
		}
		return result;
	}

	// Token: 0x04000024 RID: 36
	private static Texture2D[] texture2D_1;

	// Token: 0x04000025 RID: 37
	private int int_2;

	// Token: 0x04000026 RID: 38
	private bool bool_4;
}
