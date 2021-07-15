using System;

namespace GG.Heine.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class CommandRouteAttribute : Attribute
    {
        public string Route { get; set; }

        public CommandRouteAttribute(string route)
            => Route = "api/" + route;
    }
}
