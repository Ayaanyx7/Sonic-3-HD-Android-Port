using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

public class GClass25 : Game
{
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

	public RenderTarget2D renderTarget2D_0;

	public static Stopwatch stopwatch_0;

	public KeyboardState keyboardState_0;

	public static Texture2D texture2D_0;

	public static Texture2D texture2D_1;

	public static Texture2D texture2D_2;

	public static Texture2D texture2D_3;

	public bool bool_0;

	public static GClass25 gclass25_0;

	public static string string_0;

	private int int_22;

	private int int_23;

	public static bool bool_1;

	private bool bool_2;

	public GClass25()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		bool_0 = false;
		int_22 = 1920;
		int_23 = 1200;
		bool_2 = true;
		((Game)this)._002Ector();
		gclass25_0 = this;
		graphicsDeviceManager_0 = new GraphicsDeviceManager((Game)(object)this);
		((Game)this).Content.RootDirectory = "Content";
		if (bool_2)
		{
			int_22 = 1433;
			int_23 = 806;
		}
		graphicsDeviceManager_0.PreferredBackBufferWidth = 1280;
		graphicsDeviceManager_0.PreferredBackBufferHeight = 720;
		graphicsDeviceManager_0.IsFullScreen = true;
		((Game)this).IsMouseVisible = false;
		((Game)this).Window.AllowUserResizing = true;
		GraphicsDeviceManager obj = graphicsDeviceManager_0;
		((Game)this).IsFixedTimeStep = true;
		obj.SynchronizeWithVerticalRetrace = true;
		((Game)this).IsFixedTimeStep = false;
		((Game)this).TargetElapsedTime = TimeSpan.FromTicks(166666L);
		MediaPlayer.Volume = 0f;
		GClass24.gclass25_0 = this;
	}

	private void method_0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		keyboardState_0 = Keyboard.GetState();
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)27))
		{
			((Game)this).Exit();
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)37))
		{
			int_13++;
		}
		else
		{
			int_13 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)39))
		{
			int_14++;
		}
		else
		{
			int_14 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)38))
		{
			int_15++;
		}
		else
		{
			int_15 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)40))
		{
			int_16++;
		}
		else
		{
			int_16 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)65))
		{
			int_1++;
		}
		else
		{
			int_1 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)83))
		{
			int_2++;
		}
		else
		{
			int_2 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)68))
		{
			int_3++;
		}
		else
		{
			int_3 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)77))
		{
			int_5++;
		}
		else
		{
			int_5 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)79))
		{
			int_4++;
		}
		else
		{
			int_4 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)76))
		{
			int_6++;
		}
		else
		{
			int_6 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)112))
		{
			int_17++;
		}
		else
		{
			int_17 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)113))
		{
			int_18++;
		}
		else
		{
			int_18 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)114))
		{
			int_19++;
		}
		else
		{
			int_19 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)116))
		{
			int_20++;
		}
		else
		{
			int_20 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)119))
		{
			int_21++;
		}
		else
		{
			int_21 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)33))
		{
			int_7++;
		}
		else
		{
			int_7 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)34))
		{
			int_8++;
		}
		else
		{
			int_8 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)32))
		{
			int_12++;
		}
		else
		{
			int_12 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)9))
		{
			int_9++;
		}
		else
		{
			int_9 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)36))
		{
			int_10++;
		}
		else
		{
			int_10 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)35))
		{
			int_11++;
		}
		else
		{
			int_11 = 0;
		}
		if (((KeyboardState)(ref keyboardState_0)).IsKeyDown((Keys)13))
		{
			int_0++;
		}
		else
		{
			int_0 = 0;
		}
		GClass31.smethod_1();
	}

	protected override void Initialize()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		((Game)this).Initialize();
		GClass31.smethod_0();
		renderTarget2D_0 = new RenderTarget2D(graphicsDeviceManager_0.GraphicsDevice, int_22, int_23, false, (SurfaceFormat)0, (DepthFormat)0, 1, (RenderTargetUsage)2);
		DepthStencilState val = new DepthStencilState();
		val.DepthBufferEnable = false;
		val.DepthBufferWriteEnable = false;
		gclass28_0 = new GClass28(this);
	}

	protected override void LoadContent()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		spriteBatch_0 = new SpriteBatch(((Game)this).GraphicsDevice);
		texture2D_0 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/s3logo");
		texture2D_1 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/disclaimer");
		texture2D_2 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/sega");
		texture2D_3 = ((Game)gclass25_0).Content.Load<Texture2D>("misc/blind");
	}

	protected override void UnloadContent()
	{
	}

	protected override void Update(GameTime gameTime_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		GamePadState state = GamePad.GetState((PlayerIndex)0);
		GamePadButtons buttons = ((GamePadState)(ref state)).Buttons;
		if ((int)((GamePadButtons)(ref buttons)).Back == 1)
		{
			((Game)this).Exit();
		}
		if (!((Game)this).IsActive)
		{
			return;
		}
		Form val = (Form)Control.FromHandle(((Game)this).Window.Handle);
		if ((int)val.WindowState != 1)
		{
			method_0();
			gclass28_0.method_3();
			if (int_19 == 1)
			{
				graphicsDeviceManager_0.ToggleFullScreen();
			}
			((Game)this).Update(gameTime_0);
		}
	}

	protected override void Draw(GameTime gameTime_0)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		if (((Game)this).IsActive)
		{
			float num = (float)((Texture2D)renderTarget2D_0).Width / (float)((Texture2D)renderTarget2D_0).Height;
			graphicsDeviceManager_0.GraphicsDevice.SetRenderTarget(renderTarget2D_0);
			gclass28_0.method_4();
			graphicsDeviceManager_0.GraphicsDevice.SetRenderTarget((RenderTarget2D)null);
			((Game)this).GraphicsDevice.Clear(Color.Black);
			spriteBatch_0.Begin();
			int num2;
			int num3;
			if ((float)((Game)this).Window.ClientBounds.Width > num * (float)((Game)this).Window.ClientBounds.Height)
			{
				num2 = (int)((float)((Game)this).Window.ClientBounds.Height * num);
				num3 = ((Game)this).Window.ClientBounds.Height;
			}
			else
			{
				num2 = ((Game)this).Window.ClientBounds.Width;
				num3 = (int)((float)((Game)this).Window.ClientBounds.Width / num);
			}
			Rectangle val = new Rectangle
			{
				X = (((Game)this).Window.ClientBounds.Width - num2) / 2,
				Y = (((Game)this).Window.ClientBounds.Height - num3) / 2,
				Width = num2,
				Height = num3
			};
			spriteBatch_0.Draw((Texture2D)(object)renderTarget2D_0, val, Color.White);
			spriteBatch_0.End();
			((Game)this).Draw(gameTime_0);
		}
	}

	static GClass25()
	{
		bool_1 = false;
	}
}
