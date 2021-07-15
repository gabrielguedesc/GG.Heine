using GG.Heine.Core.Application.Implementations;
using System.Threading;
using System.Threading.Tasks;

namespace GG.Heine.Domain.Commands.Customer
{
    public class CreateCustomerHandler : Handler<CreateCustomerCommand>
    {
        public override Task<CommandResult> HandleCommandAsync(CreateCustomerCommand command, CancellationToken cancellation)
        {
            var result = new CommandResult(true, null, "Success");

            return Task.FromResult(result);
        }
    }
}
