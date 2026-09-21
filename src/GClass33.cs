using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class GClass33
{
	public Texture2D[] texture2D_0;

	public int[] int_0;

	public int int_1;

	public int int_2 = 0;

	public int int_3 = 0;

	public int int_4 = 0;

	public Color color_0;

	public bool bool_0 = false;

	public GClass33(string string_0, string string_1, int int_5, string string_2)
	{
		texture2D_0 = (Texture2D[])(object)new Texture2D[int_5];
		for (int i = 0; i < texture2D_0.Length; i++)
		{
			texture2D_0[i] = ((Game)GClass25.gclass25_0).Content.Load<Texture2D>(string_0 + "/" + string_1 + i);
		}
		int_0 = new int[int_5];
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = 1;
		}
		char[] separator = new char[2] { ';', ',' };
		string[] array = string_2.Split(separator, StringSplitOptions.RemoveEmptyEntries);
		for (int j = 0; j < int_5; j++)
		{
			int_0[j] = int.Parse(array[j]);
		}
		for (int i = 0; i < int_0.Length; i++)
		{
			int_4 += int_0[i];
		}
		int_3 = int_4;
	}

	public bool method_0()
	{
		int_3--;
		if (int_3 == 0)
		{
			int_3 = int_4;
			return false;
		}
		return true;
	}
}
