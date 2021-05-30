using Application.Events.Commands.CreateEvent;
using Application.Events.Queries.GetEventDetails;
using Application.Events.Queries.GetEvents;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    public class EventController : ApiControllerBase
    {
        [HttpPost]
        public async Task<int> Create([FromBody] CreateEventCommand createEventCommand)
        {
            return await Mediator.Send(createEventCommand);
        }

        [HttpGet("{id}")]
        public async Task<EventDetailsViewModel> GetEventDetails([FromRoute] int id, CancellationToken cancellationToken)
        {
            var query = new GetEventDetailsQuery(id);
            return await Mediator.Send(query, cancellationToken);
        }

        [HttpGet("list")]
        public async Task<List<EventViewModel>> GetEventList(CancellationToken cancellationToken)
        {
            var query = new GetEventsQuery();
            return await Mediator.Send(query, cancellationToken);
        }
    }
}