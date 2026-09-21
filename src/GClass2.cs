using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

public class GClass2 : GClass0
{
	private static Texture2D[] texture2D_1;

	private int int_2;

	private bool bool_4;

	public override void vmethod_2()
	{
		texture2D_1 = (Texture2D[])(object)new Texture2D[10];
		for (int i = 0; i < texture2D_1.Length; i++)
		{
			texture2D_1[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>("objects/giantRing" + i);
		}
	}

	public override void vmethod_3(Vector2 vector2_1, float float_1)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (!bool_3)
		{
			GClass0.texture2D_0 = texture2D_1[int_2 % 30 / 3];
			GClass0.spriteEffects_0 = (SpriteEffects)0;
			method_0(vector2_1, float_1);
		}
	}

	public GClass2()
	{
		int_2 = 0;
		bool_4 = false;
	}

	public override void Update()
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		int_2++;
		if (bool_4 && int_2 == 20)
		{
			Class5.bool_0 = true;
		}
		if (bool_4 && int_2 == 100)
		{
			GClass30.soundEffect_26.Play(GClass30.float_0, 0f, 0f);
		}
		if (bool_4 && int_2 == 160)
		{
			GClass29.gclass24_0 = GClass26.gclass29_0.gclass24_1[11];
			GClass26.gclass29_0.gclass22_0[0].method_28();
			GClass26.gclass29_0.gclass22_0[0].vector2_0 = new Vector2(1284f, 11008f);
			GClass26.gclass29_0.gclass22_0[0].bool_17 = false;
			GClass26.gclass29_0.vector2_0 = new Vector2(616f, 10544f);
			MediaPlayer.Play(GClass29.song_3);
		}
		if (bool_3)
		{
		}
	}

	public override bool vmethod_0(GClass22 gclass22_0)
	{
		if (bool_3)
		{
			return false;
		}
		if (gclass22_0.vector2_0.X - 20f < vector2_0.X + (float)(texture2D_1[0].Width / 4) && vector2_0.X - (float)(texture2D_1[0].Width / 4) < gclass22_0.vector2_0.X + 20f && gclass22_0.vector2_0.Y - 80f - 60f < vector2_0.Y + 30f && vector2_0.Y - 30f < gclass22_0.vector2_0.Y - 80f + 40f && gclass22_0.int_5 < 56 && gclass22_0.genum4_0 != (GEnum4)11)
		{
			bool_4 = true;
			GClass26.gclass29_0.gclass22_0[0].bool_17 = true;
			GClass30.soundEffect_27.Play(GClass30.float_0, 0f, 0f);
			int_2 = 0;
			bool_3 = true;
		}
		return false;
	}
}
