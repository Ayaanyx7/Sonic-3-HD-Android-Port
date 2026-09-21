using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

public class GClass32
{
	private static GamePadState gamePadState_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;

	public int int_12;

	public int int_13;

	public float float_0;

	public float float_1;

	public float float_2;

	public float float_3;

	public float float_4;

	public float float_5;

	public int int_14;

	public int int_15;

	public int int_16;

	public int int_17;

	private int int_18;

	private PlayerIndex playerIndex_0;

	public GClass32(int int_19)
	{
		method_0(int_19);
	}

	public void method_0(int int_19)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		switch (int_19)
		{
		case 1:
			playerIndex_0 = (PlayerIndex)0;
			break;
		case 2:
			playerIndex_0 = (PlayerIndex)1;
			break;
		case 3:
			playerIndex_0 = (PlayerIndex)2;
			break;
		case 4:
			playerIndex_0 = (PlayerIndex)3;
			break;
		}
	}

	public void method_1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		gamePadState_0 = GamePad.GetState(playerIndex_0);
		int_0 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)4096) ? (int_0 + 1) : 0);
		int_1 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)8192) ? (int_1 + 1) : 0);
		int_2 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)16384) ? (int_2 + 1) : 0);
		int_3 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)32768) ? (int_3 + 1) : 0);
		int_4 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)256) ? (int_4 + 1) : 0);
		int_5 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)512) ? (int_5 + 1) : 0);
		int_6 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)32) ? (int_6 + 1) : 0);
		int_7 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)16) ? (int_7 + 1) : 0);
		int_8 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)64) ? (int_8 + 1) : 0);
		int_9 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)128) ? (int_9 + 1) : 0);
		int_10 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)4) ? (int_10 + 1) : 0);
		int_11 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)8) ? (int_11 + 1) : 0);
		int_12 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)1) ? (int_12 + 1) : 0);
		int_13 = (((GamePadState)(ref gamePadState_0)).IsButtonDown((Buttons)2) ? (int_13 + 1) : 0);
		GamePadThumbSticks thumbSticks = ((GamePadState)(ref gamePadState_0)).ThumbSticks;
		float_2 = ((GamePadThumbSticks)(ref thumbSticks)).Left.X;
		thumbSticks = ((GamePadState)(ref gamePadState_0)).ThumbSticks;
		float_3 = ((GamePadThumbSticks)(ref thumbSticks)).Left.Y;
		thumbSticks = ((GamePadState)(ref gamePadState_0)).ThumbSticks;
		float_4 = ((GamePadThumbSticks)(ref thumbSticks)).Right.X;
		thumbSticks = ((GamePadState)(ref gamePadState_0)).ThumbSticks;
		float_5 = ((GamePadThumbSticks)(ref thumbSticks)).Right.Y;
		GamePadTriggers triggers = ((GamePadState)(ref gamePadState_0)).Triggers;
		float_0 = ((GamePadTriggers)(ref triggers)).Left;
		triggers = ((GamePadState)(ref gamePadState_0)).Triggers;
		float_1 = ((GamePadTriggers)(ref triggers)).Right;
		int_14 = ((Math.Abs(float_2) > 0.3f) ? (int_14 + 1) : 0);
		int_15 = ((Math.Abs(float_3) > 0.3f) ? (int_15 + 1) : 0);
		int_16 = ((Math.Abs(float_4) > 0.3f) ? (int_16 + 1) : 0);
		int_17 = ((Math.Abs(float_5) > 0.3f) ? (int_17 + 1) : 0);
		if (int_18 == 1 || int_18 == -1000)
		{
			method_2(0f, 0f, 0);
		}
		int_18--;
	}

	public void method_2(float float_6, float float_7, int int_19)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		int_18 = int_19;
		GamePad.SetVibration(playerIndex_0, float_6, float_7);
	}
}
