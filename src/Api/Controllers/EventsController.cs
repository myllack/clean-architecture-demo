using Application.Events.Queries.GetEvents;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    public class EventsController : ApiControllerBase
    {
        [HttpGet("list")]
        public async Task<List<EventViewModel>> Get(CancellationToken cancellationToken)
        {
            var query = new GetEventsQuery();
            return await Mediator.Send(query, cancellationToken);
        }
    }
}