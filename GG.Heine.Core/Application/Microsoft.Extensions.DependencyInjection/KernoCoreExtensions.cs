using GG.Heine.Core.Application.Abstractions;
using GG.Heine.Core.Application.Implementations;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace GG.Heine.Core.Application.Microsoft.Extensions.DependencyInjection
{
    public static class KernoCoreExtensions
    {
        public static IServiceCollection AddCommander(this IServiceCollection services, params Assembly[] assemblies)
        {
            var fAssemblies = assemblies.ToList();

            fAssemblies.Add(Assembly.Load("GG.Heine.Domain"));

            services.AddMediatR(fAssemblies.ToArray());

            return services;
        }
    }
}
