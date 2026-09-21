using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

internal static class Class1
{
	private static void Main(string[] args)
	{
		GClass25.stopwatch_0 = new Stopwatch();
		GClass25.stopwatch_0.Start();
		GClass25 gClass = new GClass25();
		try
		{
			((Game)gClass).Run();
		}
		finally
		{
			if (gClass != null)
			{
				((IDisposable)gClass).Dispose();
			}
		}
	}
}
