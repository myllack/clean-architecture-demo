using Application.Events.Queries.GetEvents;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    public class EventsController : ApiControllerBase
    {
        private readonly ILogger<EventsController> _logger;

        public EventsController(ILogger<EventsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("list")]
        public async Task<List<EventViewModel>> Get(CancellationToken cancellationToken)
        {
            var query = new GetEventsQuery();
            return await Mediator.Send(query, cancellationToken);
        }
    }
}