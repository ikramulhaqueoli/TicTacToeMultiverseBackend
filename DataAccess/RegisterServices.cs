using DataAccess.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
	public static class RegisterServices
	{
		public static void AddDataAccess(this IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<IBoardRepository, BoardRepository>();
            serviceCollection.AddSingleton<InMemoryDatabase>();
        }
	}
}