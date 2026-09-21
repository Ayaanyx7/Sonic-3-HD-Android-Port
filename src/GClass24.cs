using System;
using System.IO;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

public class GClass24
{
	public Texture2D[] texture2D_0;

	public Texture2D texture2D_1;

	public Texture2D[] texture2D_2;

	public static Texture2D[] texture2D_3;

	public static GClass23[] gclass23_0;

	public int[] int_0;

	public bool[] bool_0;

	public bool[] bool_1;

	public bool[] bool_2;

	public int int_1 = 144;

	public int[,] int_2;

	public int[,] int_3;

	public GClass0[] gclass0_0;

	public string string_0;

	public static GClass25 gclass25_0;

	private int int_4 = 0;

	public string string_1;

	public int int_5;

	public int int_6;

	private static bool bool_3;

	public GClass24(string string_2, int int_7)
	{
		string_0 = string_2;
		int_1 = int_7;
		string_1 = "act1.2dl";
		method_1();
	}

	public void method_0()
	{
		method_5();
	}

	public void method_1()
	{
		int num = 0;
		texture2D_0 = (Texture2D[])(object)new Texture2D[int_1];
		bool_0 = new bool[int_1];
		bool_1 = new bool[int_1];
		bool_2 = new bool[int_1];
		for (num = 0; num < bool_0.Length; num++)
		{
			bool_0[num] = false;
			bool_1[num] = false;
			bool_2[num] = false;
		}
		int num2 = 0;
		texture2D_2 = (Texture2D[])(object)new Texture2D[1];
		int_5 = 192;
		int_6 = 128;
		if (string_0 == "MHZ1" && !bool_3)
		{
			texture2D_3 = (Texture2D[])(object)new Texture2D[99];
			gclass23_0 = new GClass23[texture2D_3.Length];
		}
		switch (string_0)
		{
		case "ES":
			texture2D_2 = (Texture2D[])(object)new Texture2D[1];
			int_0 = new int[texture2D_0.Length];
			int_0[1] = 2;
			int_0[2] = 2;
			int_0[3] = 2;
			int_0[4] = 2;
			int_0[5] = 2;
			break;
		case "MHZ1":
		{
			texture2D_2 = (Texture2D[])(object)new Texture2D[12];
			int_0 = new int[texture2D_0.Length];
			int_0[1] = 1;
			int_0[2] = 2;
			int_0[3] = 3;
			int_0[4] = 4;
			int_0[5] = 4;
			int_0[6] = 4;
			int_0[7] = 5;
			int_0[8] = 2;
			int_0[9] = 2;
			int_0[10] = 6;
			int_0[11] = 17;
			int_0[12] = 9;
			int_0[13] = 10;
			int_0[14] = 14;
			int_0[15] = 15;
			int_0[16] = 16;
			int_0[17] = 11;
			int_0[18] = 13;
			int_0[19] = 12;
			int_0[20] = 7;
			int_0[21] = 25;
			int_0[22] = 18;
			int_0[23] = 20;
			int_0[24] = 26;
			int_0[25] = 23;
			int_0[26] = 24;
			int_0[27] = 21;
			int_0[28] = 22;
			int_0[29] = 27;
			int_0[30] = 20;
			int_0[31] = 28;
			int_0[32] = 29;
			int_0[33] = 4;
			int_0[34] = 30;
			int_0[35] = 31;
			int_0[36] = 32;
			int_0[37] = 33;
			int_0[38] = 34;
			int_0[39] = 4;
			int_0[40] = 35;
			int_0[41] = 36;
			int_0[42] = 37;
			int_0[43] = 13;
			int_0[44] = 38;
			int_0[45] = 39;
			int_0[46] = 40;
			int_0[47] = 41;
			int_0[48] = 42;
			int_0[49] = 30;
			int_0[50] = 55;
			int_0[51] = 56;
			int_0[52] = 58;
			int_0[53] = 60;
			int_0[54] = 72;
			int_0[55] = 62;
			int_0[56] = 63;
			int_0[57] = 65;
			int_0[58] = 64;
			int_0[59] = 57;
			int_0[60] = 61;
			int_0[61] = 59;
			int_0[62] = 71;
			int_0[63] = 54;
			int_0[64] = 62;
			int_0[65] = 63;
			int_0[66] = 69;
			int_0[67] = 54;
			int_0[68] = 68;
			int_0[69] = 70;
			int_0[70] = 28;
			int_0[71] = 67;
			int_0[72] = 66;
			int_0[73] = 4;
			int_0[74] = 4;
			int_0[75] = 4;
			int_0[76] = 4;
			int_0[79] = 51;
			int_0[80] = 51;
			int_0[81] = 53;
			int_0[82] = 33;
			int_0[83] = 52;
			int_0[85] = 49;
			int_0[90] = 2;
			int_0[92] = 4;
			int_0[93] = 4;
			int_0[96] = 33;
			int_0[98] = 94;
			int_0[101] = 13;
			int_0[102] = 33;
			int_0[103] = 33;
			int_0[105] = 46;
			int_0[106] = 4;
			int_0[107] = 4;
			int_0[108] = 44;
			int_0[109] = 4;
			int_0[110] = 4;
			int_0[111] = 4;
			int_0[112] = 4;
			int_0[113] = 10;
			int_0[114] = 4;
			int_0[115] = 48;
			int_0[116] = 45;
			int_0[119] = 4;
			int_0[120] = 19;
			int_0[121] = 47;
			int_0[122] = 4;
			int_0[123] = 43;
			int_0[124] = 33;
			int_0[130] = 33;
			int_0[131] = 33;
			int_0[145] = 23;
			int_0[146] = 9;
			int_0[147] = 4;
			int_0[148] = 16;
			int_0[149] = 1;
			int_0[150] = 23;
			int_0[151] = 4;
			int_0[152] = 11;
			int_0[153] = 33;
			int_0[154] = 95;
			int_0[155] = 97;
			int_0[156] = 96;
			int_0[157] = 30;
			int_0[158] = 8;
			int_0[159] = 4;
			int_0[160] = 30;
			int_0[161] = 9;
			int_0[163] = 98;
			int_0[164] = 4;
			bool[] array = bool_0;
			bool[] array2 = bool_0;
			bool[] array3 = bool_0;
			bool[] array4 = bool_0;
			bool[] array5 = bool_0;
			bool[] array6 = bool_0;
			bool[] array7 = bool_0;
			bool[] array8 = bool_0;
			bool[] array9 = bool_0;
			bool[] array10 = bool_0;
			bool[] array11 = bool_0;
			bool[] array12 = bool_0;
			bool[] array13 = bool_0;
			bool[] array14 = bool_0;
			bool[] array15 = bool_0;
			bool[] array16 = bool_0;
			bool[] array17 = bool_0;
			bool[] array18 = bool_0;
			bool[] array19 = bool_0;
			bool[] array20 = bool_0;
			bool_0[80] = true;
			array20[79] = true;
			array19[72] = true;
			array18[70] = true;
			array17[69] = true;
			array16[67] = true;
			array15[66] = true;
			array14[65] = true;
			array13[64] = true;
			array12[63] = true;
			array11[62] = true;
			array10[61] = true;
			array9[60] = true;
			array8[58] = true;
			array7[57] = true;
			array6[56] = true;
			array5[55] = true;
			array4[54] = true;
			array3[53] = true;
			array2[52] = true;
			array[0] = true;
			bool[] array21 = bool_1;
			bool[] array22 = bool_1;
			bool[] array23 = bool_1;
			bool[] array24 = bool_1;
			bool[] array25 = bool_1;
			bool[] array26 = bool_1;
			bool_1[64] = true;
			array26[57] = true;
			array25[56] = true;
			array24[55] = true;
			array23[53] = true;
			array22[52] = true;
			array21[51] = true;
			bool[] array27 = bool_2;
			bool[] array28 = bool_2;
			bool_2[80] = true;
			array28[79] = true;
			array27[70] = true;
			break;
		}
		}
		Thread thread = new Thread(method_3);
		thread.Start();
		if (string_0 == "MHZ1")
		{
			for (num = 0; num < int_1; num++)
			{
				if (num == 82 || num == 84 || num == 91 || num == 97 || num == 99 || ((num == 100) | (num == 104)) || num == 117 || num == 118 || num == 125 || num == 126 || num == 127 || num == 128 || num == 129 || num == 132 || num == 133 || num == 134 || num == 135 || num == 136 || num == 137 || num == 138 || num == 139 || num == 140 || num == 141 || num == 142 || num == 143 || num == 144 || num == 162 || num == 165 || num == 166 || num == 168 || num == 169 || num == 171 || num == 172 || num == 173 || num == 174 || num == 175 || num == 176 || num == 178 || num == 179 || num == 180 || num == 181 || num == 182 || num == 183 || num == 184 || num == 185)
				{
					texture2D_0[num] = texture2D_0[0];
					continue;
				}
				texture2D_0[num] = ((Game)gclass25_0).Content.Load<Texture2D>("levels/" + string_0 + "/" + num);
			}
		}
		else
		{
			for (num = 0; num < int_1; num++)
			{
				texture2D_0[num] = ((Game)gclass25_0).Content.Load<Texture2D>("levels/" + string_0 + "/" + num);
			}
		}
		texture2D_1 = ((Game)gclass25_0).Content.Load<Texture2D>("levels/" + string_0 + "/background");
		for (num = 0; num < texture2D_2.Length; num++)
		{
			texture2D_2[num] = ((Game)gclass25_0).Content.Load<Texture2D>("levels/" + string_0 + "/backgroundTile" + num);
		}
		if (thread.IsAlive)
		{
			thread.Join();
		}
		int_2 = new int[int_6, int_5];
		for (int i = 0; i < int_6; i++)
		{
			for (num = 0; num < int_5; num++)
			{
				num2++;
				int_2[i, num] = 0 % int_1;
				if (num > 140 || i > 135)
				{
					int_2[i, num] = 0;
				}
			}
		}
		int_3 = new int[int_6, int_5];
		for (int i = 0; i < int_6; i++)
		{
			for (num = 0; num < int_5; num++)
			{
				int_3[i, num] = 0;
			}
		}
		gclass0_0 = new GClass0[50];
		method_0();
	}

	private void method_2()
	{
		FileStream fileStream = new FileStream("Content/levels/masks", FileMode.Create);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		int num = 0;
		uint num2 = 0u;
		for (num = 0; num < gclass23_0.Length; num++)
		{
			for (int i = 0; i < 512; i++)
			{
				for (int j = 0; j < 512; j++)
				{
					if (gclass23_0[num].bool_0[i, j])
					{
						num2 += 2147483648u;
					}
					if (j % 32 == 31)
					{
						binaryWriter.Write(num2);
						num2 = 0u;
					}
					else
					{
						num2 /= 2;
					}
				}
			}
		}
		binaryWriter.Close();
		fileStream.Close();
	}

	private void method_3()
	{
		if (bool_3)
		{
			return;
		}
		bool_3 = true;
		GClass29.song_0 = ((Game)GClass25.gclass25_0).Content.Load<Song>("audio/mushroomHill");
		GClass29.song_4 = ((Game)GClass25.gclass25_0).Content.Load<Song>("audio/ending");
		GClass29.song_3 = ((Game)GClass25.gclass25_0).Content.Load<Song>("audio/hiddenPalaceZone");
		GClass29.song_1 = ((Game)GClass25.gclass25_0).Content.Load<Song>("audio/mushroomHillFast");
		int num = 0;
		Stream stream = TitleContainer.OpenStream("Content/levels/masks");
		BinaryReader binaryReader = new BinaryReader(stream);
		uint num2 = 0u;
		for (num = 0; num < gclass23_0.Length; num++)
		{
			gclass23_0[num] = new GClass23();
			for (int i = 0; i < 512; i++)
			{
				for (int j = 0; j < 512; j++)
				{
					if (j % 32 == 0)
					{
						num2 = binaryReader.ReadUInt32();
					}
					if (num2 % 2 == 1)
					{
						gclass23_0[num].bool_0[i, j] = true;
					}
					else
					{
						gclass23_0[num].bool_0[i, j] = false;
					}
					num2 /= 2;
				}
			}
		}
		binaryReader.Close();
		stream.Close();
	}

	private void method_4()
	{
		Color[] array = (Color[])(object)new Color[262144];
		for (int i = 0; i < texture2D_3.Length; i++)
		{
			texture2D_3[i] = ((Game)gclass25_0).Content.Load<Texture2D>("levels//collisionMasks/" + i);
			gclass23_0[i] = new GClass23();
			texture2D_3[i].GetData<Color>(array);
			for (int j = 0; j < 512; j++)
			{
				for (int k = 0; k < 512; k++)
				{
					if (((Color)(ref array[j * 512 + k])).A > 120)
					{
						gclass23_0[i].bool_0[j, k] = true;
					}
					else
					{
						gclass23_0[i].bool_0[j, k] = false;
					}
				}
			}
			((GraphicsResource)texture2D_3[i]).Dispose();
		}
	}

	public void method_5()
	{
		gclass0_0 = new GClass0[5000];
		Stream stream = TitleContainer.OpenStream("Content/levels/" + string_0 + "/" + string_1);
		BinaryReader binaryReader = new BinaryReader(stream);
		int_5 = binaryReader.ReadInt32();
		int_6 = binaryReader.ReadInt32();
		int_3 = new int[int_6, int_5];
		for (int i = 0; i < int_6; i++)
		{
			for (int j = 0; j < int_5; j++)
			{
				int_2[i, j] = binaryReader.ReadInt16();
			}
		}
		for (int i = 0; i < int_6; i++)
		{
			for (int j = 0; j < int_5; j++)
			{
				int_3[i, j] = binaryReader.ReadInt16();
			}
		}
		int_4 = binaryReader.ReadInt32();
		int num = 0;
		for (int j = 0; j < int_4; j++)
		{
			num = binaryReader.ReadByte();
			gclass0_0[j] = (GClass0)Activator.CreateInstance(GClass29.gclass0_0[num].GetType());
			gclass0_0[j].int_1 = binaryReader.ReadByte();
			gclass0_0[j].vector2_0.X = binaryReader.ReadSingle();
			gclass0_0[j].vector2_0.Y = binaryReader.ReadSingle();
		}
		binaryReader.Close();
		stream.Close();
		int_5 = 192;
		GClass29.float_4 = 0f;
	}

	public void method_6()
	{
		FileStream fileStream = new FileStream("Content/levels/" + string_0 + "/" + string_1, FileMode.Create);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		int_5 = 192;
		binaryWriter.Write(int_5);
		binaryWriter.Write(int_6);
		for (int i = 0; i < int_6; i++)
		{
			for (int j = 0; j < int_5; j++)
			{
				binaryWriter.Write((short)int_2[i, j]);
			}
		}
		for (int i = 0; i < int_6; i++)
		{
			for (int j = 0; j < int_5; j++)
			{
				binaryWriter.Write((short)int_3[i, j]);
			}
		}
		for (int i = 0; i < gclass0_0.Length - 1; i++)
		{
			for (int j = 0; j < gclass0_0.Length - 1; j++)
			{
				if (gclass0_0[j] == null)
				{
					gclass0_0[j] = gclass0_0[j + 1];
					gclass0_0[j + 1] = null;
				}
			}
		}
		int num = 0;
		for (int j = 0; j < gclass0_0.Length && gclass0_0[j] != null; j++)
		{
			num++;
		}
		int_4 = num;
		binaryWriter.Write(int_4);
		for (int j = 0; j < int_4; j++)
		{
			for (int i = 0; i < GClass29.gclass0_0.Length; i++)
			{
				if (GClass29.gclass0_0[i] != null && gclass0_0[j].GetType() == GClass29.gclass0_0[i].GetType())
				{
					binaryWriter.Write((byte)i);
					break;
				}
			}
			binaryWriter.Write((byte)gclass0_0[j].int_1);
			binaryWriter.Write(gclass0_0[j].vector2_0.X);
			binaryWriter.Write(gclass0_0[j].vector2_0.Y);
		}
		binaryWriter.Close();
		fileStream.Close();
	}

	static GClass24()
	{
		bool_3 = false;
	}
}
