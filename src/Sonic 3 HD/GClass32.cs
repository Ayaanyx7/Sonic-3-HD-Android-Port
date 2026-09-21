using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

// Token: 0x02000039 RID: 57
public class GClass32
{
	// Token: 0x060000FD RID: 253 RVA: 0x00002A5C File Offset: 0x00000C5C
	public GClass32(int int_19)
	{
		this.method_0(int_19);
	}

	// Token: 0x060000FE RID: 254 RVA: 0x0000E2B8 File Offset: 0x0000C4B8
	public void method_0(int int_19)
	{
		switch (int_19)
		{
		case 1:
			this.playerIndex_0 = 0;
			break;
		case 2:
			this.playerIndex_0 = 1;
			break;
		case 3:
			this.playerIndex_0 = 2;
			break;
		case 4:
			this.playerIndex_0 = 3;
			break;
		}
	}

	// Token: 0x060000FF RID: 255 RVA: 0x0000E304 File Offset: 0x0000C504
	public void method_1()
	{
		GClass32.gamePadState_0 = GamePad.GetState(this.playerIndex_0);
		this.int_0 = (GClass32.gamePadState_0.IsButtonDown(4096) ? (this.int_0 + 1) : 0);
		this.int_1 = (GClass32.gamePadState_0.IsButtonDown(8192) ? (this.int_1 + 1) : 0);
		this.int_2 = (GClass32.gamePadState_0.IsButtonDown(16384) ? (this.int_2 + 1) : 0);
		this.int_3 = (GClass32.gamePadState_0.IsButtonDown(32768) ? (this.int_3 + 1) : 0);
		this.int_4 = (GClass32.gamePadState_0.IsButtonDown(256) ? (this.int_4 + 1) : 0);
		this.int_5 = (GClass32.gamePadState_0.IsButtonDown(512) ? (this.int_5 + 1) : 0);
		this.int_6 = (GClass32.gamePadState_0.IsButtonDown(32) ? (this.int_6 + 1) : 0);
		this.int_7 = (GClass32.gamePadState_0.IsButtonDown(16) ? (this.int_7 + 1) : 0);
		this.int_8 = (GClass32.gamePadState_0.IsButtonDown(64) ? (this.int_8 + 1) : 0);
		this.int_9 = (GClass32.gamePadState_0.IsButtonDown(128) ? (this.int_9 + 1) : 0);
		this.int_10 = (GClass32.gamePadState_0.IsButtonDown(4) ? (this.int_10 + 1) : 0);
		this.int_11 = (GClass32.gamePadState_0.IsButtonDown(8) ? (this.int_11 + 1) : 0);
		this.int_12 = (GClass32.gamePadState_0.IsButtonDown(1) ? (this.int_12 + 1) : 0);
		this.int_13 = (GClass32.gamePadState_0.IsButtonDown(2) ? (this.int_13 + 1) : 0);
		this.float_2 = GClass32.gamePadState_0.ThumbSticks.Left.X;
		this.float_3 = GClass32.gamePadState_0.ThumbSticks.Left.Y;
		this.float_4 = GClass32.gamePadState_0.ThumbSticks.Right.X;
		this.float_5 = GClass32.gamePadState_0.ThumbSticks.Right.Y;
		this.float_0 = GClass32.gamePadState_0.Triggers.Left;
		this.float_1 = GClass32.gamePadState_0.Triggers.Right;
		this.int_14 = ((Math.Abs(this.float_2) > 0.3f) ? (this.int_14 + 1) : 0);
		this.int_15 = ((Math.Abs(this.float_3) > 0.3f) ? (this.int_15 + 1) : 0);
		this.int_16 = ((Math.Abs(this.float_4) > 0.3f) ? (this.int_16 + 1) : 0);
		this.int_17 = ((Math.Abs(this.float_5) > 0.3f) ? (this.int_17 + 1) : 0);
		if (this.int_18 == 1 || this.int_18 == -1000)
		{
			this.method_2(0f, 0f, 0);
		}
		this.int_18--;
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00002A6B File Offset: 0x00000C6B
	public void method_2(float float_6, float float_7, int int_19)
	{
		this.int_18 = int_19;
		GamePad.SetVibration(this.playerIndex_0, float_6, float_7);
	}

	// Token: 0x04000126 RID: 294
	private static GamePadState gamePadState_0;

	// Token: 0x04000127 RID: 295
	public int int_0;

	// Token: 0x04000128 RID: 296
	public int int_1;

	// Token: 0x04000129 RID: 297
	public int int_2;

	// Token: 0x0400012A RID: 298
	public int int_3;

	// Token: 0x0400012B RID: 299
	public int int_4;

	// Token: 0x0400012C RID: 300
	public int int_5;

	// Token: 0x0400012D RID: 301
	public int int_6;

	// Token: 0x0400012E RID: 302
	public int int_7;

	// Token: 0x0400012F RID: 303
	public int int_8;

	// Token: 0x04000130 RID: 304
	public int int_9;

	// Token: 0x04000131 RID: 305
	public int int_10;

	// Token: 0x04000132 RID: 306
	public int int_11;

	// Token: 0x04000133 RID: 307
	public int int_12;

	// Token: 0x04000134 RID: 308
	public int int_13;

	// Token: 0x04000135 RID: 309
	public float float_0;

	// Token: 0x04000136 RID: 310
	public float float_1;

	// Token: 0x04000137 RID: 311
	public float float_2;

	// Token: 0x04000138 RID: 312
	public float float_3;

	// Token: 0x04000139 RID: 313
	public float float_4;

	// Token: 0x0400013A RID: 314
	public float float_5;

	// Token: 0x0400013B RID: 315
	public int int_14;

	// Token: 0x0400013C RID: 316
	public int int_15;

	// Token: 0x0400013D RID: 317
	public int int_16;

	// Token: 0x0400013E RID: 318
	public int int_17;

	// Token: 0x0400013F RID: 319
	private int int_18;

	// Token: 0x04000140 RID: 320
	private PlayerIndex playerIndex_0;
}
