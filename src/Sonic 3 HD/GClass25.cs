using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

// Token: 0x0200002E RID: 46
public class GClass25 : Game
{
	// Token: 0x060000C7 RID: 199 RVA: 0x00008470 File Offset: 0x00006670
	public GClass25()
	{
		GClass25.gclass25_0 = this;
		this.graphicsDeviceManager_0 = new GraphicsDeviceManager(this);
		base.Content.RootDirectory = "Content";
		if (this.bool_2)
		{
			this.int_22 = 1433;
			this.int_23 = 806;
		}
		this.graphicsDeviceManager_0.PreferredBackBufferWidth = 1280;
		this.graphicsDeviceManager_0.PreferredBackBufferHeight = 720;
		this.graphicsDeviceManager_0.IsFullScreen = true;
		base.IsMouseVisible = false;
		base.Window.AllowUserResizing = true;
		GraphicsDeviceManager graphicsDeviceManager = this.graphicsDeviceManager_0;
		base.IsFixedTimeStep = true;
		graphicsDeviceManager.SynchronizeWithVerticalRetrace = true;
		base.IsFixedTimeStep = false;
		base.TargetElapsedTime = TimeSpan.FromTicks(166666L);
		MediaPlayer.Volume = 0f;
		GClass24.gclass25_0 = this;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00008568 File Offset: 0x00006768
	private void method_0()
	{
		this.keyboardState_0 = Keyboard.GetState();
		if (this.keyboardState_0.IsKeyDown(27))
		{
			base.Exit();
		}
		if (this.keyboardState_0.IsKeyDown(37))
		{
			this.int_13++;
		}
		else
		{
			this.int_13 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(39))
		{
			this.int_14++;
		}
		else
		{
			this.int_14 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(38))
		{
			this.int_15++;
		}
		else
		{
			this.int_15 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(40))
		{
			this.int_16++;
		}
		else
		{
			this.int_16 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(65))
		{
			this.int_1++;
		}
		else
		{
			this.int_1 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(83))
		{
			this.int_2++;
		}
		else
		{
			this.int_2 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(68))
		{
			this.int_3++;
		}
		else
		{
			this.int_3 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(77))
		{
			this.int_5++;
		}
		else
		{
			this.int_5 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(79))
		{
			this.int_4++;
		}
		else
		{
			this.int_4 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(76))
		{
			this.int_6++;
		}
		else
		{
			this.int_6 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(112))
		{
			this.int_17++;
		}
		else
		{
			this.int_17 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(113))
		{
			this.int_18++;
		}
		else
		{
			this.int_18 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(114))
		{
			this.int_19++;
		}
		else
		{
			this.int_19 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(116))
		{
			this.int_20++;
		}
		else
		{
			this.int_20 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(119))
		{
			this.int_21++;
		}
		else
		{
			this.int_21 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(33))
		{
			this.int_7++;
		}
		else
		{
			this.int_7 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(34))
		{
			this.int_8++;
		}
		else
		{
			this.int_8 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(32))
		{
			this.int_12++;
		}
		else
		{
			this.int_12 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(9))
		{
			this.int_9++;
		}
		else
		{
			this.int_9 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(36))
		{
			this.int_10++;
		}
		else
		{
			this.int_10 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(35))
		{
			this.int_11++;
		}
		else
		{
			this.int_11 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(13))
		{
			this.int_0++;
		}
		else
		{
			this.int_0 = 0;
		}
		GClass31.smethod_1();
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00008924 File Offset: 0x00006B24
	protected override void Initialize()
	{
		base.Initialize();
		GClass31.smethod_0();
		this.renderTarget2D_0 = new RenderTarget2D(this.graphicsDeviceManager_0.GraphicsDevice, this.int_22, this.int_23, false, 0, 0, 1, 2);
		DepthStencilState depthStencilState = new DepthStencilState();
		depthStencilState.DepthBufferEnable = false;
		depthStencilState.DepthBufferWriteEnable = false;
		this.gclass28_0 = new GClass28(this);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x00008984 File Offset: 0x00006B84
	protected override void LoadContent()
	{
		this.spriteBatch_0 = new SpriteBatch(base.GraphicsDevice);
		GClass25.texture2D_0 = GClass25.gclass25_0.Content.Load<Texture2D>("misc/s3logo");
		GClass25.texture2D_1 = GClass25.gclass25_0.Content.Load<Texture2D>("misc/disclaimer");
		GClass25.texture2D_2 = GClass25.gclass25_0.Content.Load<Texture2D>("misc/sega");
		GClass25.texture2D_3 = GClass25.gclass25_0.Content.Load<Texture2D>("misc/blind");
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002288 File Offset: 0x00000488
	protected override void UnloadContent()
	{
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00008A08 File Offset: 0x00006C08
	protected override void Update(GameTime gameTime_0)
	{
		if (GamePad.GetState(0).Buttons.Back == 1)
		{
			base.Exit();
		}
		if (base.IsActive)
		{
			Form form = (Form)Control.FromHandle(base.Window.Handle);
			if (form.WindowState != FormWindowState.Minimized)
			{
				this.method_0();
				this.gclass28_0.method_3();
				if (this.int_19 == 1)
				{
					this.graphicsDeviceManager_0.ToggleFullScreen();
				}
				base.Update(gameTime_0);
			}
		}
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00008A98 File Offset: 0x00006C98
	protected override void Draw(GameTime gameTime_0)
	{
		if (base.IsActive)
		{
			float num = (float)this.renderTarget2D_0.Width / (float)this.renderTarget2D_0.Height;
			this.graphicsDeviceManager_0.GraphicsDevice.SetRenderTarget(this.renderTarget2D_0);
			this.gclass28_0.method_4();
			this.graphicsDeviceManager_0.GraphicsDevice.SetRenderTarget(null);
			base.GraphicsDevice.Clear(Color.Black);
			this.spriteBatch_0.Begin();
			int num2;
			int num3;
			if ((float)base.Window.ClientBounds.Width > num * (float)base.Window.ClientBounds.Height)
			{
				num2 = (int)((float)base.Window.ClientBounds.Height * num);
				num3 = base.Window.ClientBounds.Height;
			}
			else
			{
				num2 = base.Window.ClientBounds.Width;
				num3 = (int)((float)base.Window.ClientBounds.Width / num);
			}
			Rectangle rectangle = default(Rectangle);
			rectangle.X = (base.Window.ClientBounds.Width - num2) / 2;
			rectangle.Y = (base.Window.ClientBounds.Height - num3) / 2;
			rectangle.Width = num2;
			rectangle.Height = num3;
			this.spriteBatch_0.Draw(this.renderTarget2D_0, rectangle, Color.White);
			this.spriteBatch_0.End();
			base.Draw(gameTime_0);
		}
	}

	// Token: 0x04000077 RID: 119
	private GraphicsDeviceManager graphicsDeviceManager_0;

	// Token: 0x04000078 RID: 120
	public SpriteBatch spriteBatch_0;

	// Token: 0x04000079 RID: 121
	public GClass28 gclass28_0;

	// Token: 0x0400007A RID: 122
	public int int_0;

	// Token: 0x0400007B RID: 123
	public int int_1;

	// Token: 0x0400007C RID: 124
	public int int_2;

	// Token: 0x0400007D RID: 125
	public int int_3;

	// Token: 0x0400007E RID: 126
	public int int_4;

	// Token: 0x0400007F RID: 127
	public int int_5;

	// Token: 0x04000080 RID: 128
	public int int_6;

	// Token: 0x04000081 RID: 129
	public int int_7;

	// Token: 0x04000082 RID: 130
	public int int_8;

	// Token: 0x04000083 RID: 131
	public int int_9;

	// Token: 0x04000084 RID: 132
	public int int_10;

	// Token: 0x04000085 RID: 133
	public int int_11;

	// Token: 0x04000086 RID: 134
	public int int_12;

	// Token: 0x04000087 RID: 135
	public int int_13;

	// Token: 0x04000088 RID: 136
	public int int_14;

	// Token: 0x04000089 RID: 137
	public int int_15;

	// Token: 0x0400008A RID: 138
	public int int_16;

	// Token: 0x0400008B RID: 139
	public int int_17;

	// Token: 0x0400008C RID: 140
	public int int_18;

	// Token: 0x0400008D RID: 141
	public int int_19;

	// Token: 0x0400008E RID: 142
	public int int_20;

	// Token: 0x0400008F RID: 143
	public int int_21;

	// Token: 0x04000090 RID: 144
	public RenderTarget2D renderTarget2D_0;

	// Token: 0x04000091 RID: 145
	public static Stopwatch stopwatch_0;

	// Token: 0x04000092 RID: 146
	public KeyboardState keyboardState_0;

	// Token: 0x04000093 RID: 147
	public static Texture2D texture2D_0;

	// Token: 0x04000094 RID: 148
	public static Texture2D texture2D_1;

	// Token: 0x04000095 RID: 149
	public static Texture2D texture2D_2;

	// Token: 0x04000096 RID: 150
	public static Texture2D texture2D_3;

	// Token: 0x04000097 RID: 151
	public bool bool_0 = false;

	// Token: 0x04000098 RID: 152
	public static GClass25 gclass25_0;

	// Token: 0x04000099 RID: 153
	public static string string_0;

	// Token: 0x0400009A RID: 154
	private int int_22 = 1920;

	// Token: 0x0400009B RID: 155
	private int int_23 = 1200;

	// Token: 0x0400009C RID: 156
	public static bool bool_1 = false;

	// Token: 0x0400009D RID: 157
	private bool bool_2 = true;
}
