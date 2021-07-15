using GG.Heine.Domain.Attributes;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Reflection;

namespace GG.Heine.Api.DynamicControllers
{
    public class CommandControllersRoutes : IControllerModelConvention
    {
        private readonly Type ControllerType = typeof(CommandController<>);

        public void Apply(ControllerModel controller)
        {
            if (controller.ControllerType.IsGenericType)
            {
                if (IsCommandController(controller.ControllerType))
                    AddCommandRoutes(controller);
            }
        }

        private bool IsCommandController(Type controllerType) =>
            controllerType.GetGenericTypeDefinition() == ControllerType;

        private static string GetDefaultCommandRoute(string commandName) =>
            $"/api/resource/command/{commandName.Replace("Command", "")}";

        private static void AddCommandRoutes(ControllerModel controller)
        {
            var commandType = controller.ControllerType.GenericTypeArguments[0];
            var commandAttribute = commandType.GetCustomAttribute<CommandRouteAttribute>();

            var route = commandAttribute == null ? GetDefaultCommandRoute(commandType.Name) : commandAttribute.Route;

            controller.Selectors.Add(new SelectorModel
            {
                AttributeRouteModel = new AttributeRouteModel()
                {
                    Template = route
                }
            });
        }
    }
}
