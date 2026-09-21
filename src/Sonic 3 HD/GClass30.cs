using System;
using Microsoft.Xna.Framework.Audio;

// Token: 0x02000037 RID: 55
public class GClass30
{
	// Token: 0x060000F7 RID: 247 RVA: 0x0000DF74 File Offset: 0x0000C174
	public static void smethod_0()
	{
		GClass30.soundEffect_0 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/bounceOffSoftObjects");
		GClass30.soundEffect_1 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/mushroomBounce");
		GClass30.soundEffect_2 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/bubbleAttack");
		GClass30.soundEffect_3 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/dying");
		GClass30.soundEffect_4 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/fireAttack");
		GClass30.soundEffect_5 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/lightningAttack");
		GClass30.soundEffect_6 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/popStuff");
		GClass30.soundEffect_7 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/ringScatter");
		GClass30.soundEffect_8 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/rolling");
		GClass30.soundEffect_9 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/spiked");
		GClass30.soundEffect_10 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/spindash");
		GClass30.soundEffect_11 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/spring");
		GClass30.soundEffect_12 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/surkane");
		GClass30.soundEffect_13 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/takingBubble");
		GClass30.soundEffect_14 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/takingFire");
		GClass30.soundEffect_15 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/takingLightning");
		GClass30.soundEffect_16 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/takingRing0");
		GClass30.soundEffect_17 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/takingRing1");
		GClass30.soundEffect_18 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/wKaiten");
		GClass30.soundEffect_19 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/oneUP");
		GClass30.soundEffect_20 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/peelOut");
		GClass30.soundEffect_21 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/switch");
		GClass30.soundEffect_22 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/jump");
		GClass30.soundEffect_25 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/bounceMeanie");
		GClass30.soundEffect_23 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/grab");
		GClass30.soundEffect_24 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/pulley");
		GClass30.soundEffect_27 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/specialRingEnter");
		GClass30.soundEffect_26 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/gettingIntoSpecialBonus");
		GClass30.soundEffect_28 = GClass25.gclass25_0.Content.Load<SoundEffect>("audio/sfx/sega");
	}

	// Token: 0x04000106 RID: 262
	public static SoundEffect soundEffect_0;

	// Token: 0x04000107 RID: 263
	public static SoundEffect soundEffect_1;

	// Token: 0x04000108 RID: 264
	public static SoundEffect soundEffect_2;

	// Token: 0x04000109 RID: 265
	public static SoundEffect soundEffect_3;

	// Token: 0x0400010A RID: 266
	public static SoundEffect soundEffect_4;

	// Token: 0x0400010B RID: 267
	public static SoundEffect soundEffect_5;

	// Token: 0x0400010C RID: 268
	public static SoundEffect soundEffect_6;

	// Token: 0x0400010D RID: 269
	public static SoundEffect soundEffect_7;

	// Token: 0x0400010E RID: 270
	public static SoundEffect soundEffect_8;

	// Token: 0x0400010F RID: 271
	public static SoundEffect soundEffect_9;

	// Token: 0x04000110 RID: 272
	public static SoundEffect soundEffect_10;

	// Token: 0x04000111 RID: 273
	public static SoundEffect soundEffect_11;

	// Token: 0x04000112 RID: 274
	public static SoundEffect soundEffect_12;

	// Token: 0x04000113 RID: 275
	public static SoundEffect soundEffect_13;

	// Token: 0x04000114 RID: 276
	public static SoundEffect soundEffect_14;

	// Token: 0x04000115 RID: 277
	public static SoundEffect soundEffect_15;

	// Token: 0x04000116 RID: 278
	public static SoundEffect soundEffect_16;

	// Token: 0x04000117 RID: 279
	public static SoundEffect soundEffect_17;

	// Token: 0x04000118 RID: 280
	public static SoundEffect soundEffect_18;

	// Token: 0x04000119 RID: 281
	public static SoundEffect soundEffect_19;

	// Token: 0x0400011A RID: 282
	public static SoundEffect soundEffect_20;

	// Token: 0x0400011B RID: 283
	public static SoundEffect soundEffect_21;

	// Token: 0x0400011C RID: 284
	public static SoundEffect soundEffect_22;

	// Token: 0x0400011D RID: 285
	public static SoundEffect soundEffect_23;

	// Token: 0x0400011E RID: 286
	public static SoundEffect soundEffect_24;

	// Token: 0x0400011F RID: 287
	public static SoundEffect soundEffect_25;

	// Token: 0x04000120 RID: 288
	public static SoundEffect soundEffect_26;

	// Token: 0x04000121 RID: 289
	public static SoundEffect soundEffect_27;

	// Token: 0x04000122 RID: 290
	public static SoundEffect soundEffect_28;

	// Token: 0x04000123 RID: 291
	public static float float_0 = 0.5f;

	// Token: 0x04000124 RID: 292
	public static float float_1 = 0.6f;
}
