using System;
using System.IO;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

// Token: 0x0200002D RID: 45
public class GClass24
{
	// Token: 0x060000BE RID: 190 RVA: 0x00002869 File Offset: 0x00000A69
	public GClass24(string string_2, int int_7)
	{
		this.string_0 = string_2;
		this.int_1 = int_7;
		this.string_1 = "act1.2dl";
		this.method_1();
	}

	// Token: 0x060000BF RID: 191 RVA: 0x000028A2 File Offset: 0x00000AA2
	public void method_0()
	{
		this.method_5();
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00007168 File Offset: 0x00005368
	public void method_1()
	{
		this.texture2D_0 = new Texture2D[this.int_1];
		this.bool_0 = new bool[this.int_1];
		this.bool_1 = new bool[this.int_1];
		this.bool_2 = new bool[this.int_1];
		for (int i = 0; i < this.bool_0.Length; i++)
		{
			this.bool_0[i] = false;
			this.bool_1[i] = false;
			this.bool_2[i] = false;
		}
		int num = 0;
		this.texture2D_2 = new Texture2D[1];
		this.int_5 = 192;
		this.int_6 = 128;
		if (this.string_0 == "MHZ1" && !GClass24.bool_3)
		{
			GClass24.texture2D_3 = new Texture2D[99];
			GClass24.gclass23_0 = new GClass23[GClass24.texture2D_3.Length];
		}
		string text = this.string_0;
		if (text != null)
		{
			if (!(text == "MHZ1"))
			{
				if (text == "ES")
				{
					this.texture2D_2 = new Texture2D[1];
					this.int_0 = new int[this.texture2D_0.Length];
					this.int_0[1] = 2;
					this.int_0[2] = 2;
					this.int_0[3] = 2;
					this.int_0[4] = 2;
					this.int_0[5] = 2;
				}
			}
			else
			{
				this.texture2D_2 = new Texture2D[12];
				this.int_0 = new int[this.texture2D_0.Length];
				this.int_0[1] = 1;
				this.int_0[2] = 2;
				this.int_0[3] = 3;
				this.int_0[4] = 4;
				this.int_0[5] = 4;
				this.int_0[6] = 4;
				this.int_0[7] = 5;
				this.int_0[8] = 2;
				this.int_0[9] = 2;
				this.int_0[10] = 6;
				this.int_0[11] = 17;
				this.int_0[12] = 9;
				this.int_0[13] = 10;
				this.int_0[14] = 14;
				this.int_0[15] = 15;
				this.int_0[16] = 16;
				this.int_0[17] = 11;
				this.int_0[18] = 13;
				this.int_0[19] = 12;
				this.int_0[20] = 7;
				this.int_0[21] = 25;
				this.int_0[22] = 18;
				this.int_0[23] = 20;
				this.int_0[24] = 26;
				this.int_0[25] = 23;
				this.int_0[26] = 24;
				this.int_0[27] = 21;
				this.int_0[28] = 22;
				this.int_0[29] = 27;
				this.int_0[30] = 20;
				this.int_0[31] = 28;
				this.int_0[32] = 29;
				this.int_0[33] = 4;
				this.int_0[34] = 30;
				this.int_0[35] = 31;
				this.int_0[36] = 32;
				this.int_0[37] = 33;
				this.int_0[38] = 34;
				this.int_0[39] = 4;
				this.int_0[40] = 35;
				this.int_0[41] = 36;
				this.int_0[42] = 37;
				this.int_0[43] = 13;
				this.int_0[44] = 38;
				this.int_0[45] = 39;
				this.int_0[46] = 40;
				this.int_0[47] = 41;
				this.int_0[48] = 42;
				this.int_0[49] = 30;
				this.int_0[50] = 55;
				this.int_0[51] = 56;
				this.int_0[52] = 58;
				this.int_0[53] = 60;
				this.int_0[54] = 72;
				this.int_0[55] = 62;
				this.int_0[56] = 63;
				this.int_0[57] = 65;
				this.int_0[58] = 64;
				this.int_0[59] = 57;
				this.int_0[60] = 61;
				this.int_0[61] = 59;
				this.int_0[62] = 71;
				this.int_0[63] = 54;
				this.int_0[64] = 62;
				this.int_0[65] = 63;
				this.int_0[66] = 69;
				this.int_0[67] = 54;
				this.int_0[68] = 68;
				this.int_0[69] = 70;
				this.int_0[70] = 28;
				this.int_0[71] = 67;
				this.int_0[72] = 66;
				this.int_0[73] = 4;
				this.int_0[74] = 4;
				this.int_0[75] = 4;
				this.int_0[76] = 4;
				this.int_0[79] = 51;
				this.int_0[80] = 51;
				this.int_0[81] = 53;
				this.int_0[82] = 33;
				this.int_0[83] = 52;
				this.int_0[85] = 49;
				this.int_0[90] = 2;
				this.int_0[92] = 4;
				this.int_0[93] = 4;
				this.int_0[96] = 33;
				this.int_0[98] = 94;
				this.int_0[101] = 13;
				this.int_0[102] = 33;
				this.int_0[103] = 33;
				this.int_0[105] = 46;
				this.int_0[106] = 4;
				this.int_0[107] = 4;
				this.int_0[108] = 44;
				this.int_0[109] = 4;
				this.int_0[110] = 4;
				this.int_0[111] = 4;
				this.int_0[112] = 4;
				this.int_0[113] = 10;
				this.int_0[114] = 4;
				this.int_0[115] = 48;
				this.int_0[116] = 45;
				this.int_0[119] = 4;
				this.int_0[120] = 19;
				this.int_0[121] = 47;
				this.int_0[122] = 4;
				this.int_0[123] = 43;
				this.int_0[124] = 33;
				this.int_0[130] = 33;
				this.int_0[131] = 33;
				this.int_0[145] = 23;
				this.int_0[146] = 9;
				this.int_0[147] = 4;
				this.int_0[148] = 16;
				this.int_0[149] = 1;
				this.int_0[150] = 23;
				this.int_0[151] = 4;
				this.int_0[152] = 11;
				this.int_0[153] = 33;
				this.int_0[154] = 95;
				this.int_0[155] = 97;
				this.int_0[156] = 96;
				this.int_0[157] = 30;
				this.int_0[158] = 8;
				this.int_0[159] = 4;
				this.int_0[160] = 30;
				this.int_0[161] = 9;
				this.int_0[163] = 98;
				this.int_0[164] = 4;
				bool[] array = this.bool_0;
				int num2 = 0;
				bool[] array2 = this.bool_0;
				int num3 = 52;
				bool[] array3 = this.bool_0;
				int num4 = 53;
				bool[] array4 = this.bool_0;
				int num5 = 54;
				bool[] array5 = this.bool_0;
				int num6 = 55;
				bool[] array6 = this.bool_0;
				int num7 = 56;
				bool[] array7 = this.bool_0;
				int num8 = 57;
				bool[] array8 = this.bool_0;
				int num9 = 58;
				bool[] array9 = this.bool_0;
				int num10 = 60;
				bool[] array10 = this.bool_0;
				int num11 = 61;
				bool[] array11 = this.bool_0;
				int num12 = 62;
				bool[] array12 = this.bool_0;
				int num13 = 63;
				bool[] array13 = this.bool_0;
				int num14 = 64;
				bool[] array14 = this.bool_0;
				int num15 = 65;
				bool[] array15 = this.bool_0;
				int num16 = 66;
				bool[] array16 = this.bool_0;
				int num17 = 67;
				bool[] array17 = this.bool_0;
				int num18 = 69;
				bool[] array18 = this.bool_0;
				int num19 = 70;
				bool[] array19 = this.bool_0;
				int num20 = 72;
				bool[] array20 = this.bool_0;
				int num21 = 79;
				this.bool_0[80] = true;
				array20[num21] = true;
				array19[num20] = true;
				array18[num19] = true;
				array17[num18] = true;
				array16[num17] = true;
				array15[num16] = true;
				array14[num15] = true;
				array13[num14] = true;
				array12[num13] = true;
				array11[num12] = true;
				array10[num11] = true;
				array9[num10] = true;
				array8[num9] = true;
				array7[num8] = true;
				array6[num7] = true;
				array5[num6] = true;
				array4[num5] = true;
				array3[num4] = true;
				array2[num3] = true;
				array[num2] = true;
				bool[] array21 = this.bool_1;
				int num22 = 51;
				bool[] array22 = this.bool_1;
				int num23 = 52;
				bool[] array23 = this.bool_1;
				int num24 = 53;
				bool[] array24 = this.bool_1;
				int num25 = 55;
				bool[] array25 = this.bool_1;
				int num26 = 56;
				bool[] array26 = this.bool_1;
				int num27 = 57;
				this.bool_1[64] = true;
				array26[num27] = true;
				array25[num26] = true;
				array24[num25] = true;
				array23[num24] = true;
				array22[num23] = true;
				array21[num22] = true;
				bool[] array27 = this.bool_2;
				int num28 = 70;
				bool[] array28 = this.bool_2;
				int num29 = 79;
				this.bool_2[80] = true;
				array28[num29] = true;
				array27[num28] = true;
			}
		}
		Thread thread = new Thread(new ThreadStart(this.method_3));
		thread.Start();
		if (this.string_0 == "MHZ1")
		{
			for (int i = 0; i < this.int_1; i++)
			{
				if (i == 82 || i == 84 || i == 91 || i == 97 || i == 99 || (i == 100 | i == 104) || i == 117 || i == 118 || i == 125 || i == 126 || i == 127 || i == 128 || i == 129 || i == 132 || i == 133 || i == 134 || i == 135 || i == 136 || i == 137 || i == 138 || i == 139 || i == 140 || i == 141 || i == 142 || i == 143 || i == 144 || i == 162 || i == 165 || i == 166 || i == 168 || i == 169 || i == 171 || i == 172 || i == 173 || i == 174 || i == 175 || i == 176 || i == 178 || i == 179 || i == 180 || i == 181 || i == 182 || i == 183 || i == 184 || i == 185)
				{
					this.texture2D_0[i] = this.texture2D_0[0];
				}
				else
				{
					this.texture2D_0[i] = GClass24.gclass25_0.Content.Load<Texture2D>(string.Concat(new object[]
					{
						"levels/",
						this.string_0,
						"/",
						i
					}));
				}
			}
		}
		else
		{
			for (int i = 0; i < this.int_1; i++)
			{
				this.texture2D_0[i] = GClass24.gclass25_0.Content.Load<Texture2D>(string.Concat(new object[]
				{
					"levels/",
					this.string_0,
					"/",
					i
				}));
			}
		}
		this.texture2D_1 = GClass24.gclass25_0.Content.Load<Texture2D>("levels/" + this.string_0 + "/background");
		for (int i = 0; i < this.texture2D_2.Length; i++)
		{
			this.texture2D_2[i] = GClass24.gclass25_0.Content.Load<Texture2D>(string.Concat(new object[]
			{
				"levels/",
				this.string_0,
				"/backgroundTile",
				i
			}));
		}
		if (thread.IsAlive)
		{
			thread.Join();
		}
		this.int_2 = new int[this.int_6, this.int_5];
		for (int j = 0; j < this.int_6; j++)
		{
			for (int i = 0; i < this.int_5; i++)
			{
				num++;
				this.int_2[j, i] = 0 % this.int_1;
				if (i > 140 || j > 135)
				{
					this.int_2[j, i] = 0;
				}
			}
		}
		this.int_3 = new int[this.int_6, this.int_5];
		for (int j = 0; j < this.int_6; j++)
		{
			for (int i = 0; i < this.int_5; i++)
			{
				this.int_3[j, i] = 0;
			}
		}
		this.gclass0_0 = new GClass0[50];
		this.method_0();
	}

	private void method_2()
	{
		FileStream fileStream = new FileStream("Content/levels/masks", FileMode.Create);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		uint num = 0U;
		for (int i = 0; i < GClass24.gclass23_0.Length; i++)
		{
			for (int j = 0; j < 512; j++)
			{
				for (int k = 0; k < 512; k++)
				{
					if (GClass24.gclass23_0[i].bool_0[j, k])
					{
						num += 2147483648U;
					}
					if (k % 32 == 31)
					{
						binaryWriter.Write(num);
						num = 0U;
					}
					else
					{
						num /= 2U;
					}
				}
			}
		}
		binaryWriter.Close();
		fileStream.Close();
	}

	private void method_3()
	{
		if (!GClass24.bool_3)
		{
			GClass24.bool_3 = true;
			GClass29.song_0 = GClass25.gclass25_0.Content.Load<Song>("audio/mushroomHill");
			GClass29.song_4 = GClass25.gclass25_0.Content.Load<Song>("audio/ending");
			GClass29.song_3 = GClass25.gclass25_0.Content.Load<Song>("audio/hiddenPalaceZone");
			GClass29.song_1 = GClass25.gclass25_0.Content.Load<Song>("audio/mushroomHillFast");
			Stream stream = TitleContainer.OpenStream("Content/levels/masks");
			BinaryReader binaryReader = new BinaryReader(stream);
			uint num = 0U;
			for (int i = 0; i < GClass24.gclass23_0.Length; i++)
			{
				GClass24.gclass23_0[i] = new GClass23();
				for (int j = 0; j < 512; j++)
				{
					for (int k = 0; k < 512; k++)
					{
						if (k % 32 == 0)
						{
							num = binaryReader.ReadUInt32();
						}
						if (num % 2U == 1U)
						{
							GClass24.gclass23_0[i].bool_0[j, k] = true;
						}
						else
						{
							GClass24.gclass23_0[i].bool_0[j, k] = false;
						}
						num /= 2U;
					}
				}
			}
			binaryReader.Close();
			stream.Close();
		}
	}

	private void method_4()
	{
		Color[] array = new Color[512 * 512];
		for (int i = 0; i < GClass24.texture2D_3.Length; i++)
		{
			GClass24.texture2D_3[i] = GClass24.gclass25_0.Content.Load<Texture2D>("levels//collisionMasks/" + i);
			GClass24.gclass23_0[i] = new GClass23();
			GClass24.texture2D_3[i].GetData<Color>(array);
			for (int j = 0; j < 512; j++)
			{
				for (int k = 0; k < 512; k++)
				{
					if (array[j * 512 + k].A > 120)
					{
						GClass24.gclass23_0[i].bool_0[j, k] = true;
					}
					else
					{
						GClass24.gclass23_0[i].bool_0[j, k] = false;
					}
				}
			}
			GClass24.texture2D_3[i].Dispose();
		}
	}

	public void method_5()
	{
		Stream stream = TitleContainer.OpenStream("Content/levels/" + this.string_0 + "/" + this.string_1);
		BinaryReader binaryReader = new BinaryReader(stream);
		this.int_5 = binaryReader.ReadInt32();
		this.int_6 = binaryReader.ReadInt32();
		this.int_3 = new int[this.int_6, this.int_5];
		for (int i = 0; i < this.int_6; i++)
		{
			for (int j = 0; j < this.int_5; j++)
			{
				this.int_2[i, j] = (int)binaryReader.ReadInt16();
			}
		}
		for (int i = 0; i < this.int_6; i++)
		{
			for (int j = 0; j < this.int_5; j++)
			{
				this.int_3[i, j] = (int)binaryReader.ReadInt16();
			}
		}
		this.int_4 = binaryReader.ReadInt32();
		for (int j = 0; j < this.int_4; j++)
		{
			int num = (int)binaryReader.ReadByte();
			this.gclass0_0[j] = (GClass0)Activator.CreateInstance(GClass29.gclass0_0[num].GetType());
			this.gclass0_0[j].int_1 = (int)binaryReader.ReadByte();
			this.gclass0_0[j].vector2_0.X = binaryReader.ReadSingle();
			this.gclass0_0[j].vector2_0.Y = binaryReader.ReadSingle();
		}
		binaryReader.Close();
		stream.Close();
		this.int_5 = 192;
		GClass29.float_4 = 0f;
	}

	public void method_6()
	{
		FileStream fileStream = new FileStream("Content/levels/" + this.string_0 + "/" + this.string_1, FileMode.Create);
		BinaryWriter binaryWriter = new BinaryWriter(fileStream);
		this.int_5 = 192;
		binaryWriter.Write(this.int_5);
		binaryWriter.Write(this.int_6);
		int j;
		for (int i = 0; i < this.int_6; i++)
		{
			for (j = 0; j < this.int_5; j++)
			{
				binaryWriter.Write((short)this.int_2[i, j]);
			}
		}
		for (int i = 0; i < this.int_6; i++)
		{
			for (j = 0; j < this.int_5; j++)
			{
				binaryWriter.Write((short)this.int_3[i, j]);
			}
		}
		for (int i = 0; i < this.gclass0_0.Length - 1; i++)
		{
			for (j = 0; j < this.gclass0_0.Length - 1; j++)
			{
				if (this.gclass0_0[j] == null)
				{
					this.gclass0_0[j] = this.gclass0_0[j + 1];
					this.gclass0_0[j + 1] = null;
				}
			}
		}
		int num = 0;
		j = 0;
		while (j < this.gclass0_0.Length && this.gclass0_0[j] != null)
		{
			num++;
			j++;
		}
		this.int_4 = num;
		binaryWriter.Write(this.int_4);
		j = 0;
		IL_1F9:
		while (j < this.int_4)
		{
			for (int i = 0; i < GClass29.gclass0_0.Length; i++)
			{
				if (GClass29.gclass0_0[i] != null && this.gclass0_0[j].GetType() == GClass29.gclass0_0[i].GetType())
				{
					binaryWriter.Write((byte)i);
					IL_1B1:
					binaryWriter.Write((byte)this.gclass0_0[j].int_1);
					binaryWriter.Write(this.gclass0_0[j].vector2_0.X);
					binaryWriter.Write(this.gclass0_0[j].vector2_0.Y);
					j++;
					goto IL_1F9;
				}
			}
			goto IL_1B1;
		}
		binaryWriter.Close();
		fileStream.Close();
	}

	// Fields
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
	private static bool bool_3 = false;
}
