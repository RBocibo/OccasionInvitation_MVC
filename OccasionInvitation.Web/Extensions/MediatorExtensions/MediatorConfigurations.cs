using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OccasionInvitation.Core.CQRS.Commands.RSVPCommandHandlers;
using System.Reflection;

namespace OccasionInvitation.Web.Extensions.MediatorExtensions
{
    public static class MediatorConfigurations
    {
        public static void RegisterMediator(this IServiceCollection services)
        {   
            var commandAssembly = typeof(RSVPCommand).GetTypeInfo().Assembly;

            services.AddMediatR(commandAssembly);
        }
    }
}
