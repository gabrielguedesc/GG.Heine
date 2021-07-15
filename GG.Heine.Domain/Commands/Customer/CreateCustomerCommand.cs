using GG.Heine.Core.Application.Implementations;
using GG.Heine.Domain.Attributes;

namespace GG.Heine.Domain.Commands.Customer
{
    [CommandRoute("customer/create")]
    public class CreateCustomerCommand : Command
    {
        public string Name { get; set; }

        public override void Validate() => string.IsNullOrWhiteSpace(Name);
    }
}
