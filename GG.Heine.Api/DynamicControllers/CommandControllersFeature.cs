using GG.Heine.Core.Application.Implementations;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Controllers;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using System.Reflection;

namespace GG.Heine.Api.DynamicControllers
{
    public class CommandControllersFeature : IApplicationFeatureProvider<ControllerFeature>
    {
        public Assembly CommandAssembly { get; }

        public CommandControllersFeature(Assembly commandAssembly)
        {
            CommandAssembly = commandAssembly;
        }

        public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
        {
            var commandType = typeof(Command);

            foreach (var candidate in CommandAssembly.ExportedTypes)
            {
                if (!candidate.IsAssignableTo(commandType))
                    continue;

                var controllerType = typeof(CommandController<>).MakeGenericType(candidate);
                feature.Controllers.Add(controllerType.GetTypeInfo());
            }
        }
    }
}
