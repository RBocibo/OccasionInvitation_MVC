using OccasionInvitation.Services.PersonServices;

namespace OccasionInvitation.Web.Extensions.ServiceExtensions
{
    public static class ServicesConfigurations
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>();
        }
    }
}
