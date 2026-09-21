public class GClass28
{
	public GClass25 gclass25_0;

	private int int_0 = 0;

	private GClass26[] gclass26_0 = new GClass26[100];

	public GClass28(GClass25 gclass25_1)
	{
		gclass25_0 = gclass25_1;
		gclass26_0[int_0] = Class2.smethod_0();
	}

	public void method_0(GClass26 gclass26_1)
	{
		gclass26_0[int_0] = gclass26_1;
	}

	public void method_1(GClass26 gclass26_1)
	{
		if (int_0 > gclass26_0.Length)
		{
			int_0 = 0;
		}
		else
		{
			int_0++;
		}
		gclass26_0[int_0] = gclass26_1;
	}

	public void method_2()
	{
		if (int_0 > 0)
		{
			int_0--;
		}
		else
		{
			gclass25_0.bool_0 = true;
		}
	}

	public void method_3()
	{
		gclass26_0[int_0].Update(this);
	}

	public void method_4()
	{
		gclass26_0[int_0].Draw(this);
	}
}
