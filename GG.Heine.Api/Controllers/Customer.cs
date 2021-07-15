using GG.Heine.Domain.Commands.Customer;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GG.Heine.Api.Controllers
{
    [ApiController]
    [Route("api/customer")]
    public class Customer : ControllerBase
    {
        private IMediator mediator;

        public Customer(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        [Route("create-controller")]
        public async Task<IActionResult> Get()
        {
            var command = new CreateCustomerCommand();

            var result = await mediator.Send(command);

            return Ok(result);
        }
    }
}
