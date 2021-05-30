using Application.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Events.Queries.GetEvents
{
    public class GetEventsQueryHandler : IRequestHandler<GetEventsQuery, List<EventViewModel>>
    {
        private readonly IEventQueries _eventQueries;

        public GetEventsQueryHandler(IEventQueries eventQueries)
        {
            _eventQueries = eventQueries;
        }

        public async Task<List<EventViewModel>> Handle(GetEventsQuery request, CancellationToken cancellationToken)
        {
            var events = await _eventQueries.GetEvents();
            return events;
        }
    }
}