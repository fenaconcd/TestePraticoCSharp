using System;

namespace IFEN.CSharp.TestePratico
{
	internal static class ServiceProviderExtensions
	{
		public static T GetService<T>(this IServiceProvider provider)
		{
			return (T)provider.GetService(typeof(T));
		}
	}
}
