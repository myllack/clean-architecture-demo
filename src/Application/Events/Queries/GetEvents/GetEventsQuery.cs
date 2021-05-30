using MediatR;
using System.Collections.Generic;

namespace Application.Events.Queries.GetEvents
{
    public class GetEventsQuery : IRequest<List<EventViewModel>>
    {
    }
}