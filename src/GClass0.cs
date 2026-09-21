using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass0
{
	public Vector2 vector2_0;

	public bool bool_0 = true;

	public int int_0 = 1;

	public int int_1 = 0;

	public bool bool_1 = true;

	public bool bool_2 = false;

	protected static Texture2D texture2D_0;

	protected static SpriteEffects spriteEffects_0;

	protected static float float_0;

	private Rectangle rectangle_0;

	protected bool bool_3 = false;

	public virtual void Update()
	{
	}

	public virtual bool vmethod_0(GClass22 gclass22_0)
	{
		if (rectangle_0.Width == 1 || rectangle_0.Height <= 1)
		{
			return false;
		}
		return false;
	}

	public virtual void vmethod_1()
	{
	}

	public virtual void vmethod_2()
	{
	}

	protected void method_0(Vector2 vector2_1, float float_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		method_1(vector2_1, float_1, 0f);
	}

	protected void method_1(Vector2 vector2_1, float float_1, float float_2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		GClass25.gclass25_0.spriteBatch_0.Draw(texture2D_0, vector2_1, (Rectangle?)new Rectangle(0, 0, texture2D_0.Width, texture2D_0.Height), GClass29.color_0, float_2, new Vector2((float)(texture2D_0.Width / 2), (float)(texture2D_0.Height / 2)), float_1, spriteEffects_0, 0f);
		spriteEffects_0 = (SpriteEffects)0;
	}

	public virtual void vmethod_3(Vector2 vector2_1, float float_1)
	{
	}

	public virtual void vmethod_4(Vector2 vector2_1, float float_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		vmethod_3(vector2_1, float_1);
	}
}
