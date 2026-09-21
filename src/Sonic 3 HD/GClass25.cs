using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

// Token: 0x0200002E RID: 46
public class GClass25 : Game
{
	public static GClass25 gclass25_0;
	
	// Token: 0x060000C7 RID: 199 RVA: 0x00008470 File Offset: 0x00006670
	public GClass25()
	{
		GClass25.gclass25_0 = this;
		this.graphicsDeviceManager_0 = new GraphicsDeviceManager(this);
		base.Content.RootDirectory = "Content";
		
		this.int_22 = 1280;
		this.int_23 = 720;
		
		this.graphicsDeviceManager_0.PreferredBackBufferWidth = 1280;
		this.graphicsDeviceManager_0.PreferredBackBufferHeight = 720;
		this.graphicsDeviceManager_0.IsFullScreen = true;
		base.IsMouseVisible = false;
		
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
		if (this.keyboardState_0.IsKeyDown(Keys.Escape))
		{
			base.Exit();
		}
		if (this.keyboardState_0.IsKeyDown(Keys.Left))
		{
			this.int_13++;
		}
		else
		{
			this.int_13 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.Right))
		{
			this.int_14++;
		}
		else
		{
			this.int_14 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.Up))
		{
			this.int_15++;
		}
		else
		{
			this.int_15 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.Down))
		{
			this.int_16++;
		}
		else
		{
			this.int_16 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.A))
		{
			this.int_1++;
		}
		else
		{
			this.int_1 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.S))
		{
			this.int_2++;
		}
		else
		{
			this.int_2 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.D))
		{
			this.int_3++;
		}
		else
		{
			this.int_3 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.M))
		{
			this.int_5++;
		}
		else
		{
			this.int_5 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.O))
		{
			this.int_4++;
		}
		else
		{
			this.int_4 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.L))
		{
			this.int_6++;
		}
		else
		{
			this.int_6 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.F1))
		{
			this.int_17++;
		}
		else
		{
			this.int_17 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.F2))
		{
			this.int_18++;
		}
		else
		{
			this.int_18 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.F3))
		{
			this.int_19++;
		}
		else
		{
			this.int_19 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.F5))
		{
			this.int_20++;
		}
		else
		{
			this.int_20 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.F8))
		{
			this.int_21++;
		}
		else
		{
			this.int_21 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.PageUp))
		{
			this.int_7++;
		}
		else
		{
			this.int_7 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.PageDown))
		{
			this.int_8++;
		}
		else
		{
			this.int_8 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.Space))
		{
			this.int_12++;
		}
		else
		{
			this.int_12 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.Tab))
		{
			this.int_9++;
		}
		else
		{
			this.int_9 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.Home))
		{
			this.int_10++;
		}
		else
		{
			this.int_10 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.End))
		{
			this.int_11++;
		}
		else
		{
			this.int_11 = 0;
		}
		if (this.keyboardState_0.IsKeyDown(Keys.Enter))
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
		this.renderTarget2D_0 = new RenderTarget2D(this.graphicsDeviceManager_0.GraphicsDevice, this.int_22, this.int_23, false, SurfaceFormat.Color, DepthFormat.None, 1, RenderTargetUsage.DiscardContents);
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
		if (GamePad.GetState(0).Buttons.Back == ButtonState.Pressed)
		{
			base.Exit();
		}
		if (base.IsActive)
		{
			// Fixed mobile focus hook assignment block
			this.method_0();
			this.gclass28_0.method_3();
			base.Update(gameTime_0);
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

	// RESTORED DECOMPILED STRUCT FIELDS
	private GraphicsDeviceManager graphicsDeviceManager_0;
	public SpriteBatch spriteBatch_0;
	public GClass28 gclass28_0;
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
	public int int_14;
	public int int_15;
	public int int_16;
	public int int_17;
	public int int_18;
	public int int_19;
	public int int_20;
	public int int_21;
	private int int_22;
	private int int_23;
	private bool bool_2 = false;
	public static bool bool_1 = false; // Restored matching variable field
	public RenderTarget2D renderTarget2D_0;
	public static Stopwatch stopwatch_0 = new Stopwatch(); // Restored diagnostic clock tracker
	public KeyboardState keyboardState_0;
	public static Texture2D texture2D_0; // Restored core texture lookup pointers
	public static Texture2D texture2D_1;
	public static Texture2D texture2D_2;
	public static Texture2D texture2D_3;
}
