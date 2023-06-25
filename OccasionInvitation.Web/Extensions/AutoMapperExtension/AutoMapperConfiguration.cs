using System.Reflection;

namespace OccasionInvitation.Web.Extensions.AutoMapperExtension
{
    public static class AutoMapperConfiguration
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.Load("OccasionInvitation.Models"));
        }
    }
}
