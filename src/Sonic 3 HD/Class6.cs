using System;
using System.Reflection;

// Token: 0x02000042 RID: 66
internal class Class6
{
	// Token: 0x0600012B RID: 299 RVA: 0x0001700C File Offset: 0x0001520C
	internal static void smethod_0(int typemdt)
	{
		Type type = Class6.module_0.ResolveType(33554432 + typemdt);
		foreach (FieldInfo fieldInfo in type.GetFields())
		{
			MethodInfo method = (MethodInfo)Class6.module_0.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	// Token: 0x040001B4 RID: 436
	internal static Module module_0 = typeof(Class6).Assembly.ManifestModule;

	// Token: 0x02000043 RID: 67
	// (Invoke) Token: 0x0600012F RID: 303
	internal delegate void Delegate18(object o);
}
