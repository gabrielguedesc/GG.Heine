using GG.Heine.Core.Application.Abstractions;
using GG.Heine.Core.Application.Implementations;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GG.Heine.Api.DynamicControllers
{
    public class CommandController<T> : Controller where T : ICommand<CommandResult>
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Post([FromServices] IMediator mediator, [FromBody] T command)
        {
            var result = await mediator.Send(command);

            return Ok(result);
        }
    }
}
